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


namespace C_Stocke.Commandes
{
    public partial class Produit_Commande : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public Produit SelectedProduit { get; private set; }


        private Produit _produit;
        public Produit_Commande(IServiceProvider serviceProvider, Produit produit)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
            InitializeComponent();
            _produit = produit;
            LoadProduitDetails(); // méthode pour remplir les labels
        }

        private void Produit_Commande_Load(object sender, EventArgs e)
        {

        }
        private void LoadProduitDetails()
        {
            if (_produit != null)
            {
                lbnom.Text = _produit.Nom_Produit;
                lbPrix.Text = _produit.Prix_Produit.ToString("F2");
                lbStock.Text = _produit.Quantite_Produit.ToString();
            }
        }

        private void lbStock_Click(object sender, EventArgs e)
        {

        }
        
       
        private void btnquitte_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

