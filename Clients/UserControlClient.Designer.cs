namespace C_Stocke.Clients
{
    partial class UserControlClient
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

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel2 = new Panel();
            txtRechercher = new TextBox();
            panel3 = new Panel();
            comboBox1 = new ComboBox();
            dataClinet = new DataGridView();
            Column1 = new DataGridViewCheckBoxColumn();
            iDClientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomClientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            prenomClientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresseClientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telephoneClientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paysClientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            villeClientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailClientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientBindingSource = new BindingSource(components);
            btnSuppC = new Button();
            btnModifC = new Button();
            btnAjouter = new Button();
            ((System.ComponentModel.ISupportInitialize)dataClinet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 28, 38);
            panel1.Location = new Point(71, 107);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1130, 2);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 28, 38);
            panel2.Location = new Point(71, 209);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1130, 2);
            panel2.TabIndex = 4;
            // 
            // txtRechercher
            // 
            txtRechercher.BackColor = Color.White;
            txtRechercher.BorderStyle = BorderStyle.None;
            txtRechercher.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRechercher.ForeColor = Color.Silver;
            txtRechercher.Location = new Point(696, 149);
            txtRechercher.Margin = new Padding(4, 3, 4, 3);
            txtRechercher.Multiline = true;
            txtRechercher.Name = "txtRechercher";
            txtRechercher.Size = new Size(349, 38);
            txtRechercher.TabIndex = 5;
            txtRechercher.Text = "Rechercher";
            txtRechercher.TextAlign = HorizontalAlignment.Center;
            txtRechercher.TextChanged += txtRechercher_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 28, 38);
            panel3.Location = new Point(696, 183);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(349, 3);
            panel3.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 25;
            comboBox1.Items.AddRange(new object[] { "Nom", "Prenom", "Teléphone", "Email", "Ville", "Pays" });
            comboBox1.Location = new Point(239, 154);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(307, 33);
            comboBox1.TabIndex = 6;
            // 
            // dataClinet
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 28, 38);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataClinet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataClinet.AutoGenerateColumns = false;
            dataClinet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataClinet.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 28, 38);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataClinet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataClinet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataClinet.Columns.AddRange(new DataGridViewColumn[] { Column1, iDClientDataGridViewTextBoxColumn, nomClientDataGridViewTextBoxColumn, prenomClientDataGridViewTextBoxColumn, adresseClientDataGridViewTextBoxColumn, telephoneClientDataGridViewTextBoxColumn, paysClientDataGridViewTextBoxColumn, villeClientDataGridViewTextBoxColumn, emailClientDataGridViewTextBoxColumn });
            dataClinet.DataSource = clientBindingSource;
            dataClinet.EnableHeadersVisualStyles = false;
            dataClinet.Location = new Point(19, 250);
            dataClinet.Margin = new Padding(4, 3, 4, 3);
            dataClinet.Name = "dataClinet";
            dataClinet.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataClinet.Size = new Size(1213, 261);
            dataClinet.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.HeaderText = "Select";
            Column1.Name = "Column1";
            // 
            // iDClientDataGridViewTextBoxColumn
            // 
            iDClientDataGridViewTextBoxColumn.DataPropertyName = "ID_Client";
            iDClientDataGridViewTextBoxColumn.HeaderText = "ID_Client";
            iDClientDataGridViewTextBoxColumn.Name = "iDClientDataGridViewTextBoxColumn";
            // 
            // nomClientDataGridViewTextBoxColumn
            // 
            nomClientDataGridViewTextBoxColumn.DataPropertyName = "Nom_Client";
            nomClientDataGridViewTextBoxColumn.HeaderText = "Nom_Client";
            nomClientDataGridViewTextBoxColumn.Name = "nomClientDataGridViewTextBoxColumn";
            // 
            // prenomClientDataGridViewTextBoxColumn
            // 
            prenomClientDataGridViewTextBoxColumn.DataPropertyName = "Prenom_Client";
            prenomClientDataGridViewTextBoxColumn.HeaderText = "Prenom_Client";
            prenomClientDataGridViewTextBoxColumn.Name = "prenomClientDataGridViewTextBoxColumn";
            // 
            // adresseClientDataGridViewTextBoxColumn
            // 
            adresseClientDataGridViewTextBoxColumn.DataPropertyName = "Adresse_Client";
            adresseClientDataGridViewTextBoxColumn.HeaderText = "Adresse_Client";
            adresseClientDataGridViewTextBoxColumn.Name = "adresseClientDataGridViewTextBoxColumn";
            // 
            // telephoneClientDataGridViewTextBoxColumn
            // 
            telephoneClientDataGridViewTextBoxColumn.DataPropertyName = "Telephone_Client";
            telephoneClientDataGridViewTextBoxColumn.HeaderText = "Telephone_Client";
            telephoneClientDataGridViewTextBoxColumn.Name = "telephoneClientDataGridViewTextBoxColumn";
            // 
            // paysClientDataGridViewTextBoxColumn
            // 
            paysClientDataGridViewTextBoxColumn.DataPropertyName = "Pays_Client";
            paysClientDataGridViewTextBoxColumn.HeaderText = "Pays_Client";
            paysClientDataGridViewTextBoxColumn.Name = "paysClientDataGridViewTextBoxColumn";
            // 
            // villeClientDataGridViewTextBoxColumn
            // 
            villeClientDataGridViewTextBoxColumn.DataPropertyName = "Ville_Client";
            villeClientDataGridViewTextBoxColumn.HeaderText = "Ville_Client";
            villeClientDataGridViewTextBoxColumn.Name = "villeClientDataGridViewTextBoxColumn";
            // 
            // emailClientDataGridViewTextBoxColumn
            // 
            emailClientDataGridViewTextBoxColumn.DataPropertyName = "Email_Client";
            emailClientDataGridViewTextBoxColumn.HeaderText = "Email_Client";
            emailClientDataGridViewTextBoxColumn.Name = "emailClientDataGridViewTextBoxColumn";
            // 
            // clientBindingSource
            // 
            clientBindingSource.DataSource = typeof(Entities.Client);
            // 
            // btnSuppC
            // 
            btnSuppC.BackColor = Color.FromArgb(30, 28, 38);
            btnSuppC.FlatStyle = FlatStyle.Flat;
            btnSuppC.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuppC.ForeColor = SystemColors.ControlLightLight;
            btnSuppC.Image = Properties.Resources.Recycle_iconaaa;
            btnSuppC.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuppC.Location = new Point(908, 16);
            btnSuppC.Margin = new Padding(4, 3, 4, 3);
            btnSuppC.Name = "btnSuppC";
            btnSuppC.Size = new Size(293, 85);
            btnSuppC.TabIndex = 2;
            btnSuppC.Text = "Supprimer";
            btnSuppC.UseVisualStyleBackColor = false;
            btnSuppC.Click += btnSuppC_Click;
            // 
            // btnModifC
            // 
            btnModifC.BackColor = Color.FromArgb(30, 28, 38);
            btnModifC.FlatStyle = FlatStyle.Flat;
            btnModifC.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifC.ForeColor = SystemColors.ControlLightLight;
            btnModifC.Image = Properties.Resources.Office_Client_Male_Light_icon;
            btnModifC.ImageAlign = ContentAlignment.MiddleLeft;
            btnModifC.Location = new Point(462, 16);
            btnModifC.Margin = new Padding(4, 3, 4, 3);
            btnModifC.Name = "btnModifC";
            btnModifC.Size = new Size(293, 85);
            btnModifC.TabIndex = 1;
            btnModifC.Text = "Modifer";
            btnModifC.UseVisualStyleBackColor = false;
            btnModifC.Click += btnModifC_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.FromArgb(30, 28, 38);
            btnAjouter.FlatStyle = FlatStyle.Flat;
            btnAjouter.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjouter.ForeColor = SystemColors.ControlLightLight;
            btnAjouter.Image = Properties.Resources.Actions_list_add_icon;
            btnAjouter.ImageAlign = ContentAlignment.MiddleLeft;
            btnAjouter.Location = new Point(71, 16);
            btnAjouter.Margin = new Padding(4, 3, 4, 3);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(293, 85);
            btnAjouter.TabIndex = 0;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // UserControlClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataClinet);
            Controls.Add(comboBox1);
            Controls.Add(panel3);
            Controls.Add(txtRechercher);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnSuppC);
            Controls.Add(btnModifC);
            Controls.Add(btnAjouter);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserControlClient";
            Size = new Size(1259, 831);
            ((System.ComponentModel.ISupportInitialize)dataClinet).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifC;
        private System.Windows.Forms.Button btnSuppC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataClinet;
        private BindingSource clientBindingSource;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewTextBoxColumn iDClientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomClientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prenomClientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresseClientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telephoneClientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paysClientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn villeClientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailClientDataGridViewTextBoxColumn;
    }
}