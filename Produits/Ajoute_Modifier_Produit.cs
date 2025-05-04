using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using C_Stocke.Entities;
using C_Stocke.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace C_Stocke.Produits
{
    public partial class Ajoute_Modifier_Produit : Form
    {
        private Produit _currentProduit;
        private readonly ProduitRepository _produitRepo;
        private readonly CategorieRepository _categorieRepo;
        private string _imagePath = string.Empty;

        public Ajoute_Modifier_Produit(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            // Initialisation des repositories
            _produitRepo = serviceProvider.GetRequiredService<ProduitRepository>();
            _categorieRepo = serviceProvider.GetRequiredService<CategorieRepository>();

            // Configuration initiale
            InitializePlaceholders();
            LoadCategories();
            SetupEventHandlers();
            SetupPictureBox();
        }

        private void SetupEventHandlers()
        {
            txtQuantitP.KeyPress += txtQuantitP_KeyPress;
            txtPrixP.KeyPress += txtPrixP_KeyPress;
            this.Load += (s, e) => ConfigureFormSize();
            this.KeyPreview = true;
            this.KeyDown += (s, e) => HandleKeyboardShortcuts(e);
        }

        private void SetupPictureBox()
        {
            PicProduit.SizeMode = PictureBoxSizeMode.Zoom;
            PicProduit.BorderStyle = BorderStyle.FixedSingle;
            PicProduit.BackColor = Color.White;
        }

        private void ConfigureFormSize()
        {
            this.MinimumSize = new Size(850, 550);
            this.MaximumSize = new Size(1000, 700);
            this.Size = new Size(850, 550);
        }

        private void HandleKeyboardShortcuts(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            else if (e.KeyCode == Keys.Enter)
                btnEnrgP.PerformClick();
        }

        private void InitializePlaceholders()
        {
            txtNumP.Enter += (s, e) => RemovePlaceholder(txtNumP, "Nom Produit");
            txtNumP.Leave += (s, e) => AddPlaceholder(txtNumP, "Nom Produit");

            txtQuantitP.Enter += (s, e) => RemovePlaceholder(txtQuantitP, "Quantite");
            txtQuantitP.Leave += (s, e) => AddPlaceholder(txtQuantitP, "Quantite");

            txtPrixP.Enter += (s, e) => RemovePlaceholder(txtPrixP, "Prix");
            txtPrixP.Leave += (s, e) => AddPlaceholder(txtPrixP, "Prix");
        }

        private void RemovePlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.White;
            }
        }

        private void AddPlaceholder(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Silver;
            }
        }

        private void LoadCategories()
        {
            try
            {
                var categories = _categorieRepo.GetAllCategories();
                comboCategorie.DataSource = categories.ToList();
                comboCategorie.DisplayMember = "Nom_Categorie";
                comboCategorie.ValueMember = "ID_Categorie";
                comboCategorie.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des catégories: {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void SetProduitData(Produit produit)
        {
            _currentProduit = produit;
            lbProduit.Text = "Modifier Produit";

            // Remplir les champs
            txtNumP.Text = produit.Nom_Produit;
            txtQuantitP.Text = produit.Quantite_Produit.ToString();
            txtPrixP.Text = produit.Prix_Produit.ToString("F2");

            // Charger l'image
            if (!string.IsNullOrEmpty(produit.Image_Produit) && File.Exists(produit.Image_Produit))
            {
                _imagePath = produit.Image_Produit;
                PicProduit.Image = Image.FromFile(produit.Image_Produit);
            }

            // Sélectionner la catégorie
            if (produit.Categorie != null)
            {
                comboCategorie.SelectedValue = produit.Categorie.ID_CATEGORIE;
            }

            // Changer la couleur du texte
            txtNumP.ForeColor = Color.White;
            txtQuantitP.ForeColor = Color.White;
            txtPrixP.ForeColor = Color.White;
        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Images (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
                openFileDialog.Title = "Sélectionner une image de produit";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                        if (fileInfo.Length > 5 * 1024 * 1024)
                        {
                            MessageBox.Show("L'image ne doit pas dépasser 5MB",
                                "Taille excessive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        _imagePath = openFileDialog.FileName;
                        PicProduit.Image = Image.FromFile(_imagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors du chargement de l'image: {ex.Message}",
                            "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string SaveProductImage(string sourcePath)
        {
            if (string.IsNullOrEmpty(sourcePath))
                return string.Empty;

            try
            {
                string appPath = Application.StartupPath;
                string imagesDir = Path.Combine(appPath, "ProduitImages");

                if (!Directory.Exists(imagesDir))
                    Directory.CreateDirectory(imagesDir);

                string ext = Path.GetExtension(sourcePath);
                string newFileName = $"prod_{Guid.NewGuid()}{ext}";
                string destPath = Path.Combine(imagesDir, newFileName);

                File.Copy(sourcePath, destPath, true);
                return destPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la sauvegarde de l'image: {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private void btnEnrgP_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                try
                {
                    string finalImagePath = _imagePath;
                    if (!string.IsNullOrEmpty(_imagePath) &&
                        (!_currentProduit?.Image_Produit?.Equals(_imagePath) ?? true))
                    {
                        finalImagePath = SaveProductImage(_imagePath);
                    }

                    if (_currentProduit == null)
                    {
                        var newProduit = new Produit
                        {
                            Nom_Produit = txtNumP.Text,
                            Quantite_Produit = int.Parse(txtQuantitP.Text),
                            Prix_Produit = decimal.Parse(txtPrixP.Text),
                            Image_Produit = finalImagePath,
                            ID_CATEGORIE = ((Categorie)comboCategorie.SelectedItem).ID_CATEGORIE
                        };

                        _produitRepo.Add(newProduit);
                        MessageBox.Show("Produit ajouté avec succès!", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _currentProduit.Nom_Produit = txtNumP.Text;
                        _currentProduit.Quantite_Produit = int.Parse(txtQuantitP.Text);
                        _currentProduit.Prix_Produit = decimal.Parse(txtPrixP.Text);

                        if (!string.IsNullOrEmpty(finalImagePath))
                            _currentProduit.Image_Produit = finalImagePath;

                        _currentProduit.ID_CATEGORIE = ((Categorie)comboCategorie.SelectedItem).ID_CATEGORIE;

                        _produitRepo.Update(_currentProduit);
                        MessageBox.Show("Produit modifié avec succès!", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de l'enregistrement: {ex.Message}",
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateFields()
        {
            if (txtNumP.Text == "Nom Produit" || string.IsNullOrEmpty(txtNumP.Text))
            {
                ShowValidationError("Veuillez entrer un nom de produit valide", txtNumP);
                return false;
            }

            if (txtQuantitP.Text == "Quantite" || !int.TryParse(txtQuantitP.Text, out int quantite) || quantite < 0)
            {
                ShowValidationError("Veuillez entrer une quantité valide (nombre entier positif)", txtQuantitP);
                return false;
            }

            if (txtPrixP.Text == "Prix" || !decimal.TryParse(txtPrixP.Text, out decimal prix) || prix <= 0)
            {
                ShowValidationError("Veuillez entrer un prix valide (nombre décimal positif)", txtPrixP);
                return false;
            }

            if (comboCategorie.SelectedIndex == -1)
            {
                ShowValidationError("Veuillez sélectionner une catégorie", comboCategorie);
                return false;
            }

            return true;
        }

        private void ShowValidationError(string message, Control control)
        {
            MessageBox.Show(message, "Erreur de validation",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            control.Focus();
        }

        private void txtQuantitP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrixP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnActualiseP_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        public void ClearFields()
        {
            _currentProduit = null;
            _imagePath = string.Empty;
            lbProduit.Text = "Ajouter Produit";

            txtNumP.Text = "Nom Produit";
            txtQuantitP.Text = "Quantite";
            txtPrixP.Text = "Prix";
            comboCategorie.SelectedIndex = -1;
            PicProduit.Image = null;

            txtNumP.ForeColor = Color.Silver;
            txtQuantitP.ForeColor = Color.Silver;
            txtPrixP.ForeColor = Color.Silver;
        }

        private void btnquitte_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Logique supplémentaire si nécessaire
        }
    }
}