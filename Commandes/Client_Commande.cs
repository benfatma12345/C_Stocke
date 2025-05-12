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
    public partial class Client_Commande : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ClientRepository _clientRepo;
        public Client SelectedClient { get; private set; }

        public Client_Commande(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _clientRepo = _serviceProvider.GetRequiredService<ClientRepository>();
            InitializeComponent();
        }
        private async void LoadClients()
        {
            try
            {
                var clients = _clientRepo.GetAll(); // Méthode synchrone
                clientBindingSource.DataSource = clients;
                dataClinet.DataSource = clientBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des clients: {ex.Message}");
            }
        }
        private void Client_Commande_Load(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void dataClinet_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataClinet.Rows[e.RowIndex];
                SelectedClient = (C_Stocke.Entities.Client)row.DataBoundItem;
                DialogResult = DialogResult.OK; // Important pour fermer le form avec succès
            }

        }

    }
}
