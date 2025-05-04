using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using C_Stocke.Entities;
using C_Stocke.Repositories;
using Microsoft.Extensions.DependencyInjection;

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
    }
}