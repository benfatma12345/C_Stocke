using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using C_Stocke.Entities;
using C_Stocke.Repositories;
using Microsoft.Extensions.DependencyInjection;
using OfficeOpenXml;
namespace C_Stocke.Produits
{
    public partial class Liste_Produit : UserControl
    {
        private readonly ProduitRepository _produitRepo;
        private readonly IServiceProvider _serviceProvider;
        private static Liste_Produit _instance;
        public static Liste_Produit Instance(IServiceProvider serviceProvider)
        {
            if (_instance == null)
            {
                _instance = new Liste_Produit(serviceProvider);
            }
            return _instance;
        }
        public Liste_Produit(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _produitRepo = serviceProvider.GetRequiredService<ProduitRepository>();
            InitializePlaceholder();
            dataClinet.CellFormatting += dataClinet_CellFormatting;
        }

        private void InitializePlaceholder()
        {
            txtRechercher.Enter += (s, e) => RemovePlaceholder(txtRechercher, "Rechercher");
            txtRechercher.Leave += (s, e) => AddPlaceholder(txtRechercher, "Rechercher");
        }
        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            if (txtRechercher.Text != "Rechercher")
            {
                var searchText = txtRechercher.Text.ToLowerInvariant(); // Correction ici
                var filtered = _produitRepo.GetAll()
                    .Where(p => p.Nom_Produit.ToLowerInvariant().Contains(searchText) ||
                               (p.Categorie != null && p.Categorie.Nom_Categorie.ToLowerInvariant().Contains(searchText)) ||
                               p.Prix_Produit.ToString().Contains(searchText))
                    .ToList();
                produitBindingSource.DataSource = filtered;
            }
        }
        private void RemovePlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
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

        private void LoadProduits()
        {
            try
            {
                var produits = _produitRepo.GetAll();
                produitBindingSource.DataSource = produits.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des produits: {ex.Message}");
            }
        }

        private void Liste_Produit_Load(object sender, EventArgs e)
        {
            LoadProduits();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            LoadProduits();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var form = new Ajoute_Modifier_Produit(_serviceProvider);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadProduits();
            }
        }

        private void btnModifC_Click(object sender, EventArgs e)
        {
            if (dataClinet.SelectedRows.Count > 0)
            {
                var selectedProduit = (Produit)dataClinet.SelectedRows[0].DataBoundItem;
                var form = new Ajoute_Modifier_Produit(_serviceProvider);
                form.SetProduitData(selectedProduit);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadProduits();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un produit à modifier");
            }
        }

        private void btnSuppP_Click(object sender, EventArgs e)
        {
            if (dataClinet.SelectedRows.Count > 0)
            {
                var selectedProduit = (Produit)dataClinet.SelectedRows[0].DataBoundItem;
                if (MessageBox.Show($"Voulez-vous vraiment supprimer le produit {selectedProduit.Nom_Produit}?",
                    "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        _produitRepo.Delete(selectedProduit.ID_Produit);
                        LoadProduits();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de la suppression: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un produit à supprimer");
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var produits = _produitRepo.GetAll().AsQueryable();

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Nom Produit":
                    produits = produits.OrderBy(p => p.Nom_Produit);
                    break;
                case "Quantite":
                    produits = produits.OrderBy(p => p.Quantite_Produit);
                    break;
                case "Prix":
                    produits = produits.OrderBy(p => p.Prix_Produit);
                    break;
                case "Categorie":
                    produits = produits.OrderBy(p => p.Categorie);
                    break;
            }

            produitBindingSource.DataSource = produits.ToList();
        }

        private void btnSauvgarde_Click(object sender, EventArgs e)
        {
            try
            {
                // Save logic here (if needed)
                MessageBox.Show("Données sauvegardées avec succès");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la sauvegarde: {ex.Message}");
            }
        }

        private void btnImprime_Click(object sender, EventArgs e)
        {
            if (dataClinet.SelectedRows.Count > 0)
            {
                // Print selected product logic
                MessageBox.Show("Impression du produit sélectionné");
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un produit à imprimer");
            }
        }

        private void btnImprimerTous_Click(object sender, EventArgs e)
        {
            // Print all products logic
            MessageBox.Show("Impression de tous les produits");
        }

        private void dataClinet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) // Checkbox column
            {
                dataClinet.EndEdit();
            }
        }


        private void btnExel_Click(object sender, EventArgs e)
        {
            try
            {
                var produits = _produitRepo.GetAll().ToList();

                using (var saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "Fichiers CSV (*.csv)|*.csv";
                    saveDialog.FileName = $"Export_Produits_{DateTime.Now:yyyyMMdd_HHmmss}";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var writer = new StreamWriter(saveDialog.FileName))
                        {
                            writer.WriteLine("ID;Nom;Quantité;Prix;Catégorie");

                            foreach (var p in produits)
                            {
                                writer.WriteLine(
                                    $"{p.ID_Produit};" +
                                    $"{p.Nom_Produit?.Replace(";", "")};" +
                                    $"{p.Quantite_Produit};" +
                                    $"{p.Prix_Produit};" +
                                    $"{p.Categorie?.Nom_Categorie?.Replace(";", "") ?? "N/A"}");
                            }
                        }

                        MessageBox.Show("Export CSV réussi!", "Succès",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}", "Erreur",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private string SelectVerif()
        {
            int NombreligneSelect = 0;

            for (int i = 0; i < dataClinet.Rows.Count; i++)
            {
                if (dataClinet.Rows[i].Cells[0].Value != null && (bool)dataClinet.Rows[i].Cells[0].Value == true)
                {
                    NombreligneSelect++; // Incrémenter le compteur
                }
            }

            if (NombreligneSelect == 0)
            {
                return "Selectionner Produit";
            }

            if (NombreligneSelect > 1)
            {
                return "Selectionner Seulement 1 Produit";
            }

            return null; // Tout est bon
        }
        private bool IsBase64String(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            // Vérifier si la chaîne contient des caractères valides pour Base64
            str = str.Trim();
            return (str.Length % 4 == 0) && Regex.IsMatch(str, @"^[a-zA-Z0-9\+/]*={0,2}$");
        }

        private void btnafficherphoto_Click(object sender, EventArgs e)
        {
            Produit PR = new Produit();

            if (SelectVerif() != null)
            {
                MessageBox.Show(SelectVerif(), "Sélectionner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < dataClinet.Rows.Count; i++)
                {
                    if (dataClinet.Rows[i].Cells[0].Value != null && (bool)dataClinet.Rows[i].Cells[0].Value == true)
                    {
                        int MYIDSELECT = (int)dataClinet.Rows[i].Cells[1].Value;
                        PR = _produitRepo.GetAll().SingleOrDefault(s => s.ID_Produit == MYIDSELECT);

                        if (PR != null && !string.IsNullOrEmpty(PR.Image_Produit))
                        {
                            try
                            {
                                // Vérifier si l'image est en Base64 valide
                                if (IsBase64String(PR.Image_Produit))
                                {
                                    byte[] imageBytes = Convert.FromBase64String(PR.Image_Produit);
                                    MemoryStream ms = new MemoryStream(imageBytes);

                                    Photo_Produit frmP = new Photo_Produit();
                                    frmP.ImageProduit.SizeMode = PictureBoxSizeMode.Zoom; // important
                                    frmP.ImageProduit.Image = Image.FromStream(ms);
                                    frmP.ShowDialog(); // Affiche la fenêtre
                                }
                                else
                                {
                                    MessageBox.Show("L'image encodée n'est pas au format Base64 valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (FormatException ex)
                            {
                                MessageBox.Show($"Erreur lors du décodage de l'image : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void dataClinet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Vérifie si on est sur la colonne de la quantité
            if (dataClinet.Columns[e.ColumnIndex].DataPropertyName == "Quantite_Produit")
            {
                var produit = dataClinet.Rows[e.RowIndex].DataBoundItem as Produit;
                if (produit != null)
                {
                    if (produit.Quantite_Produit == 0)
                    {
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else if (produit.Quantite_Produit <= 5)
                    {
                        e.CellStyle.BackColor = Color.Gold;
                        e.CellStyle.ForeColor = Color.Black;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.LightGreen;
                        e.CellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }
        private void btnAfficher_Click_1(object sender, EventArgs e)
        {

        }
    }
}