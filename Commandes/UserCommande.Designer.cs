using System.ComponentModel;

namespace C_Stocke.Commandes
{
    partial class UserCommande
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        private void InitializeComponent()
        {
            components = new Container();
            panel3 = new Panel();
            btnAjouter = new Button();
            btnExporterExcel = new Button();
            button2 = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            datacommande = new DataGridView();
            iDCommandeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dATECommandeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iDClientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalHTDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tauxTVADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalTVADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalTTCDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commandeBindingSource = new BindingSource(components);
            ((ISupportInitialize)datacommande).BeginInit();
            ((ISupportInitialize)commandeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 28, 38);
            panel3.Location = new Point(428, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(233, 10);
            panel3.TabIndex = 17;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.FromArgb(30, 28, 38);
            btnAjouter.FlatStyle = FlatStyle.Flat;
            btnAjouter.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btnAjouter.ForeColor = Color.White;
            btnAjouter.Image = Properties.Resources.Actions_list_add_icon;
            btnAjouter.ImageAlign = ContentAlignment.MiddleLeft;
            btnAjouter.Location = new Point(47, 13);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(210, 54);
            btnAjouter.TabIndex = 18;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnExporterExcel
            // 
            btnExporterExcel.BackColor = Color.FromArgb(30, 28, 38);
            btnExporterExcel.FlatStyle = FlatStyle.Flat;
            btnExporterExcel.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btnExporterExcel.ForeColor = Color.White;
            btnExporterExcel.Image = Properties.Resources.Excel_icon;
            btnExporterExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnExporterExcel.Location = new Point(92, 505);
            btnExporterExcel.Name = "btnExporterExcel";
            btnExporterExcel.Size = new Size(293, 85);
            btnExporterExcel.TabIndex = 7;
            btnExporterExcel.Text = "Excel";
            btnExporterExcel.UseVisualStyleBackColor = false;
            btnExporterExcel.Click += btnExporterCSV_Commandes_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(30, 28, 38);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.Imprimer;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(783, 505);
            button2.Name = "button2";
            button2.Size = new Size(293, 85);
            button2.TabIndex = 6;
            button2.Text = "Imprimer";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(263, 33);
            label1.Name = "label1";
            label1.Size = new Size(171, 33);
            label1.TabIndex = 5;
            label1.Text = "Date Début";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(431, 34);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(232, 23);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged_1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(800, 35);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(232, 23);
            dateTimePicker2.TabIndex = 3;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label2.Location = new Point(661, 34);
            label2.Name = "label2";
            label2.Size = new Size(133, 33);
            label2.TabIndex = 2;
            label2.Text = "Date Fin";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 28, 38);
            panel1.Location = new Point(797, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 10);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.search;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(1053, 35);
            button3.Name = "button3";
            button3.Size = new Size(63, 40);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = false;
            // 
            // datacommande
            // 
            datacommande.AutoGenerateColumns = false;
            datacommande.Columns.AddRange(new DataGridViewColumn[] { iDCommandeDataGridViewTextBoxColumn, dATECommandeDataGridViewTextBoxColumn, iDClientDataGridViewTextBoxColumn, clientDataGridViewTextBoxColumn, totalHTDataGridViewTextBoxColumn, tauxTVADataGridViewTextBoxColumn, totalTVADataGridViewTextBoxColumn, totalTTCDataGridViewTextBoxColumn });
            datacommande.DataSource = commandeBindingSource;
            datacommande.Location = new Point(160, 101);
            datacommande.Name = "datacommande";
            datacommande.Size = new Size(841, 248);
            datacommande.TabIndex = 0;
            // 
            // iDCommandeDataGridViewTextBoxColumn
            // 
            iDCommandeDataGridViewTextBoxColumn.DataPropertyName = "ID_Commande";
            iDCommandeDataGridViewTextBoxColumn.HeaderText = "ID_Commande";
            iDCommandeDataGridViewTextBoxColumn.Name = "iDCommandeDataGridViewTextBoxColumn";
            // 
            // dATECommandeDataGridViewTextBoxColumn
            // 
            dATECommandeDataGridViewTextBoxColumn.DataPropertyName = "DATE_Commande";
            dATECommandeDataGridViewTextBoxColumn.HeaderText = "DATE_Commande";
            dATECommandeDataGridViewTextBoxColumn.Name = "dATECommandeDataGridViewTextBoxColumn";
            // 
            // iDClientDataGridViewTextBoxColumn
            // 
            iDClientDataGridViewTextBoxColumn.DataPropertyName = "ID_Client";
            iDClientDataGridViewTextBoxColumn.HeaderText = "ID_Client";
            iDClientDataGridViewTextBoxColumn.Name = "iDClientDataGridViewTextBoxColumn";
            // 
            // clientDataGridViewTextBoxColumn
            // 
            clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            clientDataGridViewTextBoxColumn.HeaderText = "Client";
            clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            // 
            // totalHTDataGridViewTextBoxColumn
            // 
            totalHTDataGridViewTextBoxColumn.DataPropertyName = "TotalHT";
            totalHTDataGridViewTextBoxColumn.HeaderText = "TotalHT";
            totalHTDataGridViewTextBoxColumn.Name = "totalHTDataGridViewTextBoxColumn";
            // 
            // tauxTVADataGridViewTextBoxColumn
            // 
            tauxTVADataGridViewTextBoxColumn.DataPropertyName = "TauxTVA";
            tauxTVADataGridViewTextBoxColumn.HeaderText = "TauxTVA";
            tauxTVADataGridViewTextBoxColumn.Name = "tauxTVADataGridViewTextBoxColumn";
            // 
            // totalTVADataGridViewTextBoxColumn
            // 
            totalTVADataGridViewTextBoxColumn.DataPropertyName = "TotalTVA";
            totalTVADataGridViewTextBoxColumn.HeaderText = "TotalTVA";
            totalTVADataGridViewTextBoxColumn.Name = "totalTVADataGridViewTextBoxColumn";
            // 
            // totalTTCDataGridViewTextBoxColumn
            // 
            totalTTCDataGridViewTextBoxColumn.DataPropertyName = "TotalTTC";
            totalTTCDataGridViewTextBoxColumn.HeaderText = "TotalTTC";
            totalTTCDataGridViewTextBoxColumn.Name = "totalTTCDataGridViewTextBoxColumn";
            // 
            // commandeBindingSource
            // 
            commandeBindingSource.DataSource = typeof(Entities.Commande);
            // 
            // UserCommande
            // 
            Controls.Add(datacommande);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btnExporterExcel);
            Controls.Add(panel3);
            Controls.Add(btnAjouter);
            Name = "UserCommande";
            Size = new Size(1116, 620);
            ((ISupportInitialize)datacommande).EndInit();
            ((ISupportInitialize)commandeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private Button btnAjouter;
        private Button btnExporterExcel;
        private Button button2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Panel panel1;
        private Button button3;
        private DataGridView datacommande;
        private BindingSource commandeBindingSource;
        private DataGridViewTextBoxColumn iDCommandeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dATECommandeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDClientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalHTDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tauxTVADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalTVADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalTTCDataGridViewTextBoxColumn;
    }
}

