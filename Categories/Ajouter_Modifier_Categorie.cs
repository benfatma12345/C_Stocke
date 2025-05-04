using System;
using System.Windows.Forms;
using C_Stocke.Entities;
using C_Stocke.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace C_Stocke.Categories
{
    public partial class Ajouter_Modifier_Categorie : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly CategorieRepository _categorieRepo;
        private Categorie _categorie;

        public Ajouter_Modifier_Categorie(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _categorieRepo = _serviceProvider.GetRequiredService<CategorieRepository>();
            InitializeComponent();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            btnquitte.Click += (s, e) => this.Close();
            BtnAjouteCat.Click += BtnAjouteCat_Click;
            txtCategorie.Enter += TxtCategorie_Enter;
            txtCategorie.Leave += TxtCategorie_Leave;
        }

        private void TxtCategorie_Enter(object sender, EventArgs e)
        {
            if (txtCategorie.Text == "Nom Categorie")
            {
                txtCategorie.Text = "";
                txtCategorie.ForeColor = Color.Silver;
            }
        }

        private void TxtCategorie_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategorie.Text))
            {
                txtCategorie.Text = "Nom Categorie";
                txtCategorie.ForeColor = Color.Silver;
            }
        }

        public void SetCategorieData(Categorie categorie)
        {
            _categorie = categorie;
            txtCategorie.Text = categorie.Nom_Categorie;
            txtCategorie.ForeColor = Color.Silver;
        }

        private void BtnAjouteCat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategorie.Text) || txtCategorie.Text == "Nom Categorie")
            {
                MessageBox.Show("Veuillez entrer un nom de catégorie valide", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (_categorie == null)
                {
                    // Ajout d'une nouvelle catégorie
                    var newCategorie = new Categorie
                    {
                        Nom_Categorie = txtCategorie.Text
                    };
                    _categorieRepo.Add(newCategorie);
                    MessageBox.Show("Catégorie ajoutée avec succès", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Modification d'une catégorie existante
                    _categorie.Nom_Categorie = txtCategorie.Text;
                    _categorieRepo.Update(_categorie);
                    MessageBox.Show("Catégorie modifiée avec succès", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'opération: {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}