using System;
using System.Windows.Forms;
using C_Stock;
using C_Stocke.Context;
using Microsoft.Extensions.DependencyInjection;

namespace C_Stocke.Auth
{
    public partial class Connextion : Form
    {
        private readonly GestionStockDbContext _context;

        public Connextion(GestionStockDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        string testObligatoire()
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) || txtNom.Text == "Nom d'utilisateur")
                return "Entrez votre Nom";

            if (string.IsNullOrWhiteSpace(txtmotpass.Text) || txtmotpass.Text == "Mot de Passe")
                return "Entrez votre Mot de Passe";

            return null;
        }

        private void btnquitte_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if (txtNom.Text == "Nom d'utilisateur")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtpasse_Enter(object sender, EventArgs e)
        {
            if (txtmotpass.Text == "Mot de Passe")
            {
                txtmotpass.Text = "";
                txtmotpass.ForeColor = Color.WhiteSmoke;
                txtmotpass.UseSystemPasswordChar = true;
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                txtNom.Text = "Nom d'utilisateur";
                txtNom.ForeColor = Color.Silver;
            }
        }

        private void txtmotdepasse_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmotpass.Text))
            {
                txtmotpass.Text = "Mot de Passe";
                txtmotpass.ForeColor = Color.Silver;
                txtmotpass.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var messageErreur = testObligatoire();
            if (messageErreur != null)
            {
                MessageBox.Show(messageErreur, "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var utilisateur = _context.Utilisateurs
                    .FirstOrDefault(u => u.NomUtilisateur == txtNom.Text && u.Mot_De_Passe == txtmotpass.Text);

                if (utilisateur != null)
                {
                    this.Hide();

                    using (var scope = Program.ServiceProvider.CreateScope())
                    {
                        var menu = scope.ServiceProvider.GetRequiredService<Menu>();
                        menu.ShowDialog();
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion: {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}