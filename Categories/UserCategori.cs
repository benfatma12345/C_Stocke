using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_Stocke.Entities;
using C_Stocke.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace C_Stocke.Categories
{
    public partial class UserCategori : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly CategorieRepository _categorieRepo;
        private Ajouter_Modifier_Categorie _formAjoutModif;
        public UserCategori(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _categorieRepo = _serviceProvider.GetRequiredService<CategorieRepository>();
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            SetupDataGridView();
            ConfigureButtons();
            SetupSearch();
            dataCategorie.CellFormatting += dataCategorie_CellFormatting;
            LoadCategories();
        }

        private void SetupSearch()
        {
            txtRechercher.Enter += TxtRechercher_Enter;
            txtRechercher.Leave += TxtRechercher_Leave;
            txtRechercher.TextChanged += TxtRechercher_TextChanged;
        }
        // Ajoutez cette méthode à la classe UserCategori
        private void dataCategorie_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataCategorie.Columns[e.ColumnIndex].Name == "Column4" && e.Value is string && (string)e.Value == "Modifier")
            {
                e.CellStyle.BackColor = Color.FromArgb(0, 120, 215);
                e.CellStyle.ForeColor = Color.White;
            }
            else if (dataCategorie.Columns[e.ColumnIndex].Name == "Column5" && e.Value is string && (string)e.Value == "Supprimer")
            {
                e.CellStyle.BackColor = Color.FromArgb(220, 53, 69);
                e.CellStyle.ForeColor = Color.White;
            }
        }
        private void TxtRechercher_Enter(object sender, EventArgs e)
        {
            if (txtRechercher.Text == "Rechercher")
            {
                txtRechercher.Text = "";
                txtRechercher.ForeColor = SystemColors.WindowText;
            }
        }

        private void TxtRechercher_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRechercher.Text))
            {
                txtRechercher.Text = "Rechercher";
                txtRechercher.ForeColor = SystemColors.GrayText;
            }
        }

        private void TxtRechercher_TextChanged(object sender, EventArgs e)
        {
            if (txtRechercher.Text != "Rechercher")
            {
                FilterCategories(txtRechercher.Text);
            }
        }

        private void FilterCategories(string searchText)
        {
            if (categorieBindingSource.DataSource is List<Categorie> categories)
            {
                var filtered = categories
                    .Where(c => c.Nom_Categorie?.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();

                categorieBindingSource.DataSource = filtered;
            }
        }

        private void ConfigureButtons()
        {
            btnAjouter.Click += BtnAjouter_Click;
            dataCategorie.CellContentClick += DataCategorie_CellContentClick;
            button1.Click += BtnExportExcel_Click;
            button2.Click += BtnPrint_Click;
        }

        private void BtnExportExcel_Click(object sender, EventArgs e)
        {
            // Implémentez l'export Excel ici
            MessageBox.Show("Fonctionnalité d'export Excel à implémenter");
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            // Implémentez l'impression ici
            MessageBox.Show("Fonctionnalité d'impression à implémenter");
        }

        private void DataCategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var categorie = (Categorie)dataCategorie.Rows[e.RowIndex].DataBoundItem;

            if (dataCategorie.Columns[e.ColumnIndex].Name == "Column4") // Modifier
            {
                OpenCategorieForm(categorie);
            }
            else if (dataCategorie.Columns[e.ColumnIndex].Name == "Column5") // Supprimer
            {
                DeleteCategorie(categorie);
            }
        }

        private void LoadCategories()
        {
            try
            {
                var categories = _categorieRepo.GetAllCategories().ToList();
                categorieBindingSource.DataSource = categories;

                // Réinitialiser la recherche
                txtRechercher.Text = "Rechercher";
                txtRechercher.ForeColor = SystemColors.GrayText;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement: {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            dataCategorie.AutoGenerateColumns = false;
            dataCategorie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataCategorie.MultiSelect = false;
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            OpenCategorieForm();
        }

        private void OpenCategorieForm(Categorie categorie = null)
        {
            _formAjoutModif = new Ajouter_Modifier_Categorie(_serviceProvider);

            if (categorie != null)
            {
                _formAjoutModif.SetCategorieData(categorie);
                _formAjoutModif.Text = "Modifier Catégorie";
            }
            else
            {
                _formAjoutModif.Text = "Ajouter Catégorie";
            }

            _formAjoutModif.FormClosed += (s, args) => LoadCategories();
            _formAjoutModif.ShowDialog();
        }

        private void DeleteCategorie(Categorie categorie)
        {
            var confirm = MessageBox.Show(
                $"Confirmer la suppression de la catégorie {categorie.Nom_Categorie} ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _categorieRepo.Delete(categorie.ID_CATEGORIE);
                    LoadCategories();
                    MessageBox.Show("Catégorie supprimée avec succès", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la suppression: {ex.Message}", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UserControlCategorie_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }
    }
}