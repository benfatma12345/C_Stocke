using System;
using System.Windows.Forms;
using C_Stocke.Entities;
using C_Stocke.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace C_Stocke.Clients
{
    public partial class Ajouter_Modifier_Client : Form
    {
        private Client _currentClient;
        private readonly ClientRepository _clientRepo;

        public Ajouter_Modifier_Client(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _clientRepo = serviceProvider.GetRequiredService<ClientRepository>();
            InitializePlaceholders();
        }


        private void InitializePlaceholders()
        {
            txtNom.Enter += (s, e) => RemovePlaceholder(txtNom, "Nom d'utilisateur");
            txtNom.Leave += (s, e) => AddPlaceholder(txtNom, "Nom d'utilisateur");

            txtPrenom.Enter += (s, e) => RemovePlaceholder(txtPrenom, "Prenom d'utilisateur");
            txtPrenom.Leave += (s, e) => AddPlaceholder(txtPrenom, "Prenom d'utilisateur");

            txtAd.Enter += (s, e) => RemovePlaceholder(txtAd, "Adresse");
            txtAd.Leave += (s, e) => AddPlaceholder(txtAd, "Adresse");

            txtPays.Enter += (s, e) => RemovePlaceholder(txtPays, "Pays Client");
            txtPays.Leave += (s, e) => AddPlaceholder(txtPays, "Pays Client");

            txtVille.Enter += (s, e) => RemovePlaceholder(txtVille, "Ville Client");
            txtVille.Leave += (s, e) => AddPlaceholder(txtVille, "Ville Client");

            txtEmail.Enter += (s, e) => RemovePlaceholder(txtEmail, "Email");
            txtEmail.Leave += (s, e) => AddPlaceholder(txtEmail, "Email");

            txtNum.Enter += (s, e) => RemovePlaceholder(txtNum, "Numero");
            txtNum.Leave += (s, e) => AddPlaceholder(txtNum, "Numero");
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

        public void SetClientData(Client client)
        {
            _currentClient = client;

            txtNom.Text = client.Nom_Client;
            txtPrenom.Text = client.Prenom_Client;
            txtAd.Text = client.Adresse_Client;
            txtPays.Text = client.Pays_Client;
            txtVille.Text = client.Ville_Client;
            txtEmail.Text = client.Email_Client;
            txtNum.Text = client.Telephone_Client;

            // Changer la couleur du texte si ce n'est pas un placeholder
            txtNom.ForeColor = Color.White;
            txtPrenom.ForeColor = Color.White;
            txtAd.ForeColor = Color.White;
            txtPays.ForeColor = Color.White;
            txtVille.ForeColor = Color.White;
            txtEmail.ForeColor = Color.White;
            txtNum.ForeColor = Color.White;
        }

        public void ClearFields()
        {
            _currentClient = null;

            txtNom.Text = "Nom d'utilisateur";
            txtPrenom.Text = "Prenom d'utilisateur";
            txtAd.Text = "Adresse";
            txtPays.Text = "Pays Client";
            txtVille.Text = "Ville Client";
            txtEmail.Text = "Email";
            txtNum.Text = "Numero";

            txtNom.ForeColor = Color.Silver;
            txtPrenom.ForeColor = Color.Silver;
            txtAd.ForeColor = Color.Silver;
            txtPays.ForeColor = Color.Silver;
            txtVille.ForeColor = Color.Silver;
            txtEmail.ForeColor = Color.Silver;
            txtNum.ForeColor = Color.Silver;
        }

        private void btnEnrg_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                if (_currentClient == null)
                {
                    // Ajout d'un nouveau client
                    var newClient = new Client
                    {
                        Nom_Client = txtNom.Text,
                        Prenom_Client = txtPrenom.Text,
                        Adresse_Client = txtAd.Text,
                        Pays_Client = txtPays.Text,
                        Ville_Client = txtVille.Text,
                        Email_Client = txtEmail.Text,
                        Telephone_Client = txtNum.Text
                    };

                    _clientRepo.Add(newClient);
                    MessageBox.Show("Client ajouté avec succès !");
                }
                else
                {
                    // Modification d'un client existant
                    _currentClient.Nom_Client = txtNom.Text;
                    _currentClient.Prenom_Client = txtPrenom.Text;
                    _currentClient.Adresse_Client = txtAd.Text;
                    _currentClient.Pays_Client = txtPays.Text;
                    _currentClient.Ville_Client = txtVille.Text;
                    _currentClient.Email_Client = txtEmail.Text;
                    _currentClient.Telephone_Client = txtNum.Text;

                    _clientRepo.Update(_currentClient);
                    MessageBox.Show("Client modifié avec succès !");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }



        private bool ValidateFields()
        {
            if (txtNom.Text == "Nom d'utilisateur" || string.IsNullOrEmpty(txtNom.Text))
            {
                MessageBox.Show("Veuillez entrer un nom valide");
                return false;
            }

            if (txtPrenom.Text == "Prenom d'utilisateur" || string.IsNullOrEmpty(txtPrenom.Text))
            {
                MessageBox.Show("Veuillez entrer un prénom valide");
                return false;
            }

            if (txtEmail.Text == "Email" || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Veuillez entrer un email valide");
                return false;
            }

            if (txtNum.Text == "Numero" || string.IsNullOrEmpty(txtNum.Text))
            {
                MessageBox.Show("Veuillez entrer un numéro de téléphone valide");
                return false;
            }

            return true;
        }

        private void btnActualise_Click(object sender, EventArgs e)
        {
            ClearFields();
        }



        private void btnqut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnrg_Click_1(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                if (_currentClient == null)
                {
                    // Ajout d'un nouveau client
                    var newClient = new Client
                    {
                        Nom_Client = txtNom.Text,
                        Prenom_Client = txtPrenom.Text,
                        Adresse_Client = txtAd.Text,
                        Pays_Client = txtPays.Text,
                        Ville_Client = txtVille.Text,
                        Email_Client = txtEmail.Text,
                        Telephone_Client = txtNum.Text
                    };

                    // Ajout du client à la base de données via le repository
                    _clientRepo.Add(newClient);

                    // Message de confirmation
                    MessageBox.Show("Client ajouté avec succès !");

                    // Si nécessaire, tu peux fermer le formulaire ou le réinitialiser ici
                    this.DialogResult = DialogResult.OK; // Retourne un OK pour fermer la fenêtre avec succès
                    this.Close(); // Ferme la fenêtre
                }
                else
                {
                    // Modification d'un client existant
                    _currentClient.Nom_Client = txtNom.Text;
                    _currentClient.Prenom_Client = txtPrenom.Text;
                    _currentClient.Adresse_Client = txtAd.Text;
                    _currentClient.Pays_Client = txtPays.Text;
                    _currentClient.Ville_Client = txtVille.Text;
                    _currentClient.Email_Client = txtEmail.Text;
                    _currentClient.Telephone_Client = txtNum.Text;

                    // Mise à jour du client dans la base de données via le repository
                    _clientRepo.Update(_currentClient);

                    // Message de confirmation
                    MessageBox.Show("Client modifié avec succès !");

                    // Si nécessaire, tu peux fermer le formulaire ou le réinitialiser ici
                    this.DialogResult = DialogResult.OK; // Retourne un OK pour fermer la fenêtre avec succès
                    this.Close(); // Ferme la fenêtre
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}