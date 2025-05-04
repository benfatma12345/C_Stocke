using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_Stocke;
using C_Stocke.Auth;
using C_Stocke.Categories;
using C_Stocke.Clients;
using C_Stocke.Produits;
using Microsoft.Extensions.DependencyInjection;




namespace C_Stock
{
   // private readonly UserControlClient _userControlClient;

    public partial class Menu : Form
    {
        private bool isPanelExpanded = true;
        private readonly IServiceProvider _serviceProvider;
        public Menu(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
            panel1.Size = new Size(229, 612);
            plparamette.Height = 0;
            plparamette.Visible = true;
        }
        void desactiverForm()
        {
            btnClient.Enabled = false;
            btnProduit.Enabled = false;
            btnCategorie.Enabled = false;
            btnUtilisateur.Enabled = false;
            btncopie.Enabled = false;
            btnrestaurer.Enabled = false;
            btnCommend.Enabled = false;

            btndeconnecter.Enabled = false;
            pnlbtn.Enabled = false; // ligne en cours d’écriture ou incomplète
            btnconnecter.Enabled = true;
        }
        public void activerForm()
        {
            btnClient.Enabled = true;
            btnProduit.Enabled = true;
            btnCategorie.Enabled = true;
            btnUtilisateur.Enabled = true;
            btncopie.Enabled = true;
            btnrestaurer.Enabled = true;
            btnCommend.Enabled = true;
            btndeconnecter.Enabled = true;
            pnlbtn.Enabled = true; // ligne en cours d’écriture ou incomplète
            btnconnecter.Enabled = false;
            btnParametre.Visible = false;
        }
        private void FRM_Menu_Load(object sender, EventArgs e)
        {
            desactiverForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            if (isPanelExpanded)
            {
                panel1.Size = new Size(75, 612);
            }
            else
            {
                panel1.Size = new Size(229, 612);
            }

            isPanelExpanded = !isPanelExpanded;
        }

        private void btnProduit_Click(object sender, EventArgs e)
        {
            pnlbtn.Top = btnProduit.Top;

           
                var listeProduit = Program.ServiceProvider.GetService<Liste_Produit>();

                if (listeProduit == null)
                {
                    MessageBox.Show("Le service Liste_Produit n'a pas pu être trouvé.");
                    return;
                }

                if (!panlfiche.Controls.Contains(listeProduit))
                {
                    panlfiche.Controls.Add(listeProduit);
                    listeProduit.Dock = DockStyle.Fill;
                    listeProduit.BringToFront();
                }
                else
                {
                    listeProduit.BringToFront();
                }
            
        }
        private void btnClient_Click(object sender, EventArgs e)
        {
            pnlbtn.Top = btnClient.Top;
          
                // Utiliser Program.ServiceProvider pour accéder à l'instance de ServiceProvider
                var userControlClient = Program.ServiceProvider.GetService<UserControlClient>();

                if (userControlClient == null)
                {
                    MessageBox.Show("Le service UserControlClient n'a pas pu être trouvé.");
                    return;
                }

                if (!panlfiche.Controls.Contains(userControlClient))
                {
                    panlfiche.Controls.Add(userControlClient);
                    userControlClient.Dock = DockStyle.Fill;
                    userControlClient.BringToFront();
                }
                else
                {
                    userControlClient.BringToFront();
                }
            

        }





        private void btnCategorie_Click(object sender, EventArgs e)
        {
            pnlbtn.Top = btnCategorie.Top;
            // Utiliser Program.ServiceProvider pour accéder à l'instance de ServiceProvider
                var userCategori = Program.ServiceProvider.GetService<UserCategori>();

                if (userCategori == null)
                {
                    MessageBox.Show("Le service UserCategori n'a pas pu être trouvé.");
                    return;
                }

                if (!panlfiche.Controls.Contains(userCategori))
                {
                    panlfiche.Controls.Add(userCategori);
                    userCategori.Dock = DockStyle.Fill;
                    userCategori.BringToFront();
                }
                else
                {
                    userCategori.BringToFront();
                }
            
        }
        private void btnCommend_Click(object sender, EventArgs e)
        {
            pnlbtn.Top = btnCommend.Top;
        }

        private void btnUtilisateur_Click(object sender, EventArgs e)
        {
            pnlbtn.Top = btnUtilisateur.Top;
        }

        private void btnParametre_Click(object sender, EventArgs e)

        {
            plparamette.Size = new Size(440, 236);
            // Si le bouton est déjà visible, on le masque
            plparamette.Visible = !plparamette.Visible;
            plparamette.BringToFront();
            
        }
        private void AnimateParamPanel(object sender, EventArgs e)
        {
            if (isParamOpen)
            {
                plparamette.Height -= 20;
                if (plparamette.Height <= 0)
                {
                   
                    plparamette.Visible = false;
                    isParamOpen = false;
                }
            }
            else
            {
                plparamette.Visible = true;
                plparamette.Height += 20;
                if (plparamette.Height >= panelMaxHeight)
                {
                    
                    isParamOpen = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btndeconnecter_Click(object sender, EventArgs e)
        {
            desactiverForm();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

