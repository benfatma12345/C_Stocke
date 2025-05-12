using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C_Stocke.Entities;
using C_Stocke.Repositories;
using Microsoft.Extensions.DependencyInjection;
using OfficeOpenXml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace C_Stocke.Commandes
{
    public partial class UserCommande : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly CommandeRepository _commandeRepo;
        public UserCommande(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _commandeRepo = _serviceProvider.GetRequiredService<CommandeRepository>();
            InitializeComponent();
            InitializeComponents();
        }
        private void InitializeComponents()
        {

            ConfigureButtons();
            LoadCommandes();
        }
        private void ConfigureButtons()
        {
            btnAjouter.Click += btnAjouter_Click;

        }

        private async void LoadCommandes()
        {
            try
            {
                var commandes = await _commandeRepo.GetAllAsync();
                commandeBindingSource.DataSource = commandes;
                datacommande.DataSource = commandeBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des commandes : {ex.Message}");
            }
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var detailForm = new DetailCommande(_serviceProvider);
            if (detailForm.ShowDialog() == DialogResult.OK)
            {
                LoadCommandes();
            }
        }


   
        private void btnExporterCSV_Commandes_Click(object sender, EventArgs e)
        {
            try
            {
                var commandes = _commandeRepo.GetAll().ToList();

                using (var saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "Fichiers CSV (*.csv)|*.csv";
                    saveDialog.FileName = $"Export_Produits_{DateTime.Now:yyyyMMdd_HHmmss}";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var writer = new StreamWriter(saveDialog.FileName))
                        {
                            writer.WriteLine("ID;Date;Client;Total HT;TVA;Total TTC");


                            foreach (var commande in commandes)
                            {
                                writer.WriteLine(
                                    $"{commande.ID_Commande};" +
                                    $"{commande.DATE_Commande:yyyy-MM-dd HH:mm:ss};" + // Format de la date
                                    $"{EscapeCsvField(commande.Client?.Nom_Client ?? "Inconnu")};" +
                                    $"{commande.TotalHT:F2};" + // Total HT formaté à 2 décimales
                                    $"{commande.TotalTVA:F2};" + // TVA formatée à 2 décimales
                                    $"{commande.TotalTTC:F2}"); // Total TTC formaté à 2 décimales
                            }
                        }

                        MessageBox.Show("Export CSV réussi!", "Succès",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}", "Erreur",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Méthode pour échapper les champs CSV
        private string EscapeCsvField(string field)
        {
            if (field == null)
                return string.Empty;

            // Si le champ contient un point-virgule, des guillemets ou une nouvelle ligne, on l'encadre de guillemets et on échappe les guillemets internes.
            if (field.Contains(";") || field.Contains("\"") || field.Contains("\n"))
            {
                return $"\"{field.Replace("\"", "\"\"")}\"";
            }

            return field;
        }




        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                dateTimePicker2.Value = dateTimePicker1.Value;
            }
        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                dateTimePicker1.Value = dateTimePicker2.Value;
            }
        }
    }
}
