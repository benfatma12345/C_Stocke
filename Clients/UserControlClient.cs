using System;
using System.Windows.Forms;
using C_Stocke.Entities;
using C_Stocke.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C_Stocke.Clients
{
    public partial class UserControlClient : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ClientRepository _clientRepo;
        private Ajouter_Modifier_Client _formAjoutModif;

        public UserControlClient(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _clientRepo = _serviceProvider.GetRequiredService<ClientRepository>();
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            InitializeComboBox();
            SetupDataGridView();
            ConfigureButtons();
            LoadClients();
        }

        private void ConfigureButtons()
        {
            btnAjouter.Click += btnAjouter_Click;
            btnModifC.Click += btnModifC_Click;
            btnSuppC.Click += btnSuppC_Click;
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

        private void SetupDataGridView()
        {
            dataClinet.AutoGenerateColumns = false;
            dataClinet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataClinet.MultiSelect = false;

            if (!dataClinet.Columns.Contains("Modifier"))
            {
                dataClinet.Columns.Add(new DataGridViewButtonColumn
                {
                    Name = "Modifier",
                    Text = "Modifier",
                    UseColumnTextForButtonValue = true,
                    FlatStyle = FlatStyle.Flat
                });
            }

            if (!dataClinet.Columns.Contains("Supprimer"))
            {
                dataClinet.Columns.Add(new DataGridViewButtonColumn
                {
                    Name = "Supprimer",
                    Text = "Supprimer",
                    UseColumnTextForButtonValue = true,
                    FlatStyle = FlatStyle.Flat
                });
            }

            dataClinet.CellContentClick += DataGridView_CellContentClick;
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedClient = (Client)dataClinet.Rows[e.RowIndex].DataBoundItem;

            if (dataClinet.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                DeleteClient(selectedClient);
            }
            else if (dataClinet.Columns[e.ColumnIndex].Name == "Modifier")
            {
                OpenClientForm(selectedClient);
            }
        }

        private void DeleteClient(Client client)
        {
            var confirm = MessageBox.Show(
                $"Confirmer la suppression de {client.Nom_Client} {client.Prenom_Client} ?",
                "Suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _clientRepo.Delete(client.ID_Client);
                    LoadClients();
                    MessageBox.Show("Client supprimé avec succès !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la suppression: {ex.Message}");
                }
            }
        }

        private void OpenClientForm(Client client = null)
        {
            _formAjoutModif = new Ajouter_Modifier_Client(_serviceProvider);
            _formAjoutModif.FormClosed += (s, args) => LoadClients();

            if (client != null)
            {
                _formAjoutModif.SetClientData(client);
                _formAjoutModif.Text = "Modifier Client";
            }
            else
            {
                _formAjoutModif.Text = "Ajouter Client";
            }

            _formAjoutModif.ShowDialog();
        }

        private void InitializeComboBox()
        {
            comboBox1.Items.AddRange(new[] { "Nom", "Prénom", "Email", "Téléphone" });
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRechercher_TextChanged(sender, e);
        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtRechercher.Text.ToLower();
            string selectedField = comboBox1.SelectedItem?.ToString();

            try
            {
                var clients = _clientRepo.GetAll();
                var filteredClients = FilterClients(clients, searchTerm, selectedField);
                clientBindingSource.DataSource = filteredClients;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la recherche: {ex.Message}");
            }
        }

        private List<Client> FilterClients(IEnumerable<Client> clients, string searchTerm, string field)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return clients.ToList();

            return field switch
            {
                "Nom" => clients.Where(c => c.Nom_Client?.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ?? false).ToList(),
                "Prénom" => clients.Where(c => c.Prenom_Client?.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ?? false).ToList(),
                "Email" => clients.Where(c => c.Email_Client?.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ?? false).ToList(),
                "Téléphone" => clients.Where(c => c.Telephone_Client?.Contains(searchTerm) ?? false).ToList(),
                _ => clients.ToList()
            };
        }

        private void btnAjouter_Click(object sender, EventArgs e) => OpenClientForm();

        private void btnModifC_Click(object sender, EventArgs e)
        {
            if (dataClinet.SelectedRows.Count > 0)
            {
                var client = (Client)dataClinet.SelectedRows[0].DataBoundItem;
                OpenClientForm(client);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un client à modifier");
            }
        }

        private void btnSuppC_Click(object sender, EventArgs e)
        {
            if (dataClinet.SelectedRows.Count > 0)
            {
                var client = (Client)dataClinet.SelectedRows[0].DataBoundItem;
                DeleteClient(client);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un client à supprimer");
            }
        }
    }
}