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

namespace C_Stocke.Commandes
{
    public partial class DetailCommande : Form
    {

        private readonly ProduitRepository _produitRepo;
        private readonly IServiceProvider _serviceProvider;


        public DetailCommande(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _produitRepo = serviceProvider.GetRequiredService<ProduitRepository>();
            InitializePlaceholder();
            this.Load += Liste_Produit_Load;
            dataproduit.CellFormatting += dataproduit_CellFormatting;

        }

        private void Liste_Produit_Load(object sender, EventArgs e)
        {
            LoadProduits();
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

        private void btnquitte_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            var clientForm = new Client_Commande(_serviceProvider);
            var result = clientForm.ShowDialog();

            if (result == DialogResult.OK && clientForm.SelectedClient != null)
            {
                var client = clientForm.SelectedClient;

                txtNom.Text = client.Nom_Client;
                txtPrenom.Text = client.Prenom_Client;
                txttele.Text = client.Telephone_Client;
                txtmail.Text = client.Email_Client;
                txtPays.Text = client.Pays_Client;
                txtVille.Text = client.Ville_Client;
            }
        }
        private string SelectVerif()
        {
            int NombreligneSelect = 0;

            for (int i = 0; i < dataproduit.Rows.Count; i++)
            {
                if (dataproduit.Rows[i].Cells[0].Value != null && (bool)dataproduit.Rows[i].Cells[0].Value == true)
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
        private void dataproduit_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Vérifie si on est sur la colonne de la quantité
            if (dataproduit.Columns[e.ColumnIndex].DataPropertyName == "Quantite_Produit")
            {
                var produit = dataproduit.Rows[e.RowIndex].DataBoundItem as Produit;
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
        private void dataproduit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataproduit.Rows.Count)
            {
                var selectedProduit = dataproduit.Rows[e.RowIndex].DataBoundItem as Produit;

                if (selectedProduit == null)
                    return;

                if (selectedProduit.Quantite_Produit == 0)
                {
                    MessageBox.Show("Ce produit est en rupture de stock (quantité = 0).", "Produit indisponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var produitForm = new Produit_Commande(_serviceProvider, selectedProduit);
                var result = produitForm.ShowDialog();

                if (result == DialogResult.OK && produitForm.SelectedProduit != null)
                {
                    var produit = produitForm.SelectedProduit;

                    /*lbnom.Text = produit.Nom_Produit;
                    lbStock.Text = produit.Quantite_Produit.ToString();
                    lbPrix.Text = produit.Prix_Produit.ToString("F2");
                    txtto.Text = produit.Prix_Produit.ToString("F2");*/
                }
            }


        }
    }
}
