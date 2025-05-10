namespace C_Stocke.Produits
{
    partial class Liste_Produit
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
            comboBox1 = new ComboBox();
            panel3 = new Panel();
            txtRechercher = new TextBox();
            panel2 = new Panel();
            panel1 = new Panel();
            dataClinet = new DataGridView();
            Column1 = new DataGridViewCheckBoxColumn();
            iDProduitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomProduitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantiteProduitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            prixProduitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imageProduitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categorieDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            produitBindingSource = new BindingSource(components);
            btnSauvgarde = new Button();
            btnImprimerTous = new Button();
            btnImprime = new Button();
            btnAfficher = new Button();
            btnSuppP = new Button();
            btnModifC = new Button();
            btnAjouter = new Button();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataClinet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produitBindingSource).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 25;
            comboBox1.Items.AddRange(new object[] { "Nom Produit ", "Quantite", "Prix", "Image", "Categorie" });
            comboBox1.Location = new Point(312, 162);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(307, 33);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 28, 38);
            panel3.Location = new Point(686, 193);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(349, 3);
            panel3.TabIndex = 13;
            // 
            // txtRechercher
            // 
            txtRechercher.BackColor = Color.White;
            txtRechercher.BorderStyle = BorderStyle.None;
            txtRechercher.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRechercher.ForeColor = Color.Silver;
            txtRechercher.Location = new Point(686, 158);
            txtRechercher.Margin = new Padding(4, 3, 4, 3);
            txtRechercher.Multiline = true;
            txtRechercher.Name = "txtRechercher";
            txtRechercher.Size = new Size(349, 38);
            txtRechercher.TabIndex = 14;
            txtRechercher.Text = "Rechercher";
            txtRechercher.TextAlign = HorizontalAlignment.Center;
            txtRechercher.TextChanged += txtRechercher_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 28, 38);
            panel2.Location = new Point(81, 214);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(953, 10);
            panel2.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 28, 38);
            panel1.Location = new Point(0, 108);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 1);
            panel1.TabIndex = 11;
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
            dataClinet.Columns.AddRange(new DataGridViewColumn[] { Column1, iDProduitDataGridViewTextBoxColumn, nomProduitDataGridViewTextBoxColumn, quantiteProduitDataGridViewTextBoxColumn, prixProduitDataGridViewTextBoxColumn, imageProduitDataGridViewTextBoxColumn, categorieDataGridViewTextBoxColumn });
            dataClinet.DataSource = produitBindingSource;
            dataClinet.EnableHeadersVisualStyles = false;
            dataClinet.Location = new Point(81, 268);
            dataClinet.Margin = new Padding(4, 3, 4, 3);
            dataClinet.Name = "dataClinet";
            dataClinet.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataClinet.Size = new Size(953, 219);
            dataClinet.TabIndex = 16;
            // 
            // Column1
            // 
            Column1.HeaderText = "Select";
            Column1.Name = "Column1";
            // 
            // iDProduitDataGridViewTextBoxColumn
            // 
            iDProduitDataGridViewTextBoxColumn.DataPropertyName = "ID_Produit";
            iDProduitDataGridViewTextBoxColumn.HeaderText = "ID_Produit";
            iDProduitDataGridViewTextBoxColumn.Name = "iDProduitDataGridViewTextBoxColumn";
            // 
            // nomProduitDataGridViewTextBoxColumn
            // 
            nomProduitDataGridViewTextBoxColumn.DataPropertyName = "Nom_Produit";
            nomProduitDataGridViewTextBoxColumn.HeaderText = "Nom_Produit";
            nomProduitDataGridViewTextBoxColumn.Name = "nomProduitDataGridViewTextBoxColumn";
            // 
            // quantiteProduitDataGridViewTextBoxColumn
            // 
            quantiteProduitDataGridViewTextBoxColumn.DataPropertyName = "Quantite_Produit";
            quantiteProduitDataGridViewTextBoxColumn.HeaderText = "Quantite_Produit";
            quantiteProduitDataGridViewTextBoxColumn.Name = "quantiteProduitDataGridViewTextBoxColumn";
            // 
            // prixProduitDataGridViewTextBoxColumn
            // 
            prixProduitDataGridViewTextBoxColumn.DataPropertyName = "Prix_Produit";
            prixProduitDataGridViewTextBoxColumn.HeaderText = "Prix_Produit";
            prixProduitDataGridViewTextBoxColumn.Name = "prixProduitDataGridViewTextBoxColumn";
            // 
            // imageProduitDataGridViewTextBoxColumn
            // 
            imageProduitDataGridViewTextBoxColumn.DataPropertyName = "Image_Produit";
            imageProduitDataGridViewTextBoxColumn.HeaderText = "Image_Produit";
            imageProduitDataGridViewTextBoxColumn.Name = "imageProduitDataGridViewTextBoxColumn";
            // 
            // categorieDataGridViewTextBoxColumn
            // 
            categorieDataGridViewTextBoxColumn.DataPropertyName = "Categorie";
            categorieDataGridViewTextBoxColumn.HeaderText = "Categorie";
            categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            // 
            // produitBindingSource
            // 
            produitBindingSource.DataSource = typeof(Entities.Produit);
            // 
            // btnSauvgarde
            // 
            btnSauvgarde.BackColor = Color.FromArgb(30, 28, 38);
            btnSauvgarde.FlatStyle = FlatStyle.Flat;
            btnSauvgarde.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSauvgarde.ForeColor = SystemColors.ControlLightLight;
            btnSauvgarde.Image = Properties.Resources.print_icon;
            btnSauvgarde.ImageAlign = ContentAlignment.MiddleLeft;
            btnSauvgarde.Location = new Point(781, 543);
            btnSauvgarde.Margin = new Padding(4, 3, 4, 3);
            btnSauvgarde.Name = "btnSauvgarde";
            btnSauvgarde.Size = new Size(293, 52);
            btnSauvgarde.TabIndex = 20;
            btnSauvgarde.Text = "Sauvgarder";
            btnSauvgarde.UseVisualStyleBackColor = false;
            // 
            // btnImprimerTous
            // 
            btnImprimerTous.BackColor = Color.FromArgb(30, 28, 38);
            btnImprimerTous.FlatStyle = FlatStyle.Flat;
            btnImprimerTous.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimerTous.ForeColor = SystemColors.ControlLightLight;
            btnImprimerTous.Image = Properties.Resources.Excel_icon1;
            btnImprimerTous.ImageAlign = ContentAlignment.MiddleLeft;
            btnImprimerTous.Location = new Point(407, 543);
            btnImprimerTous.Margin = new Padding(4, 3, 4, 3);
            btnImprimerTous.Name = "btnImprimerTous";
            btnImprimerTous.Size = new Size(293, 52);
            btnImprimerTous.TabIndex = 19;
            btnImprimerTous.Text = "Imprimer toutes";
            btnImprimerTous.UseVisualStyleBackColor = false;
            btnImprimerTous.Click += btnExel_Click;
            // 
            // btnImprime
            // 
            btnImprime.BackColor = Color.FromArgb(30, 28, 38);
            btnImprime.FlatStyle = FlatStyle.Flat;
            btnImprime.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprime.ForeColor = SystemColors.ControlLightLight;
            btnImprime.Image = Properties.Resources.Imprimer;
            btnImprime.ImageAlign = ContentAlignment.MiddleLeft;
            btnImprime.Location = new Point(43, 543);
            btnImprime.Margin = new Padding(4, 3, 4, 3);
            btnImprime.Name = "btnImprime";
            btnImprime.Size = new Size(274, 52);
            btnImprime.TabIndex = 18;
            btnImprime.Text = "Imprimer ";
            btnImprime.UseVisualStyleBackColor = false;
            // 
            // btnAfficher
            // 
            btnAfficher.BackColor = Color.FromArgb(30, 28, 38);
            btnAfficher.FlatStyle = FlatStyle.Flat;
            btnAfficher.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAfficher.ForeColor = SystemColors.ControlLightLight;
            btnAfficher.Image = Properties.Resources.Pictures_icon;
            btnAfficher.ImageAlign = ContentAlignment.MiddleLeft;
            btnAfficher.Location = new Point(858, 25);
            btnAfficher.Margin = new Padding(4, 3, 4, 3);
            btnAfficher.Name = "btnAfficher";
            btnAfficher.Size = new Size(251, 67);
            btnAfficher.TabIndex = 17;
            btnAfficher.Text = "Afficher Photo";
            btnAfficher.UseVisualStyleBackColor = false;
            btnAfficher.Click += btnafficherphoto_Click;
            // 
            // btnSuppP
            // 
            btnSuppP.BackColor = Color.FromArgb(30, 28, 38);
            btnSuppP.FlatStyle = FlatStyle.Flat;
            btnSuppP.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuppP.ForeColor = SystemColors.ControlLightLight;
            btnSuppP.Image = Properties.Resources.Button_Delete_icon;
            btnSuppP.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuppP.Location = new Point(560, 25);
            btnSuppP.Margin = new Padding(4, 3, 4, 3);
            btnSuppP.Name = "btnSuppP";
            btnSuppP.Size = new Size(266, 67);
            btnSuppP.TabIndex = 10;
            btnSuppP.Text = "Supprimer";
            btnSuppP.UseVisualStyleBackColor = false;
            btnSuppP.Click += btnSuppP_Click;
            // 
            // btnModifC
            // 
            btnModifC.BackColor = Color.FromArgb(30, 28, 38);
            btnModifC.FlatStyle = FlatStyle.Flat;
            btnModifC.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifC.ForeColor = SystemColors.ControlLightLight;
            btnModifC.Image = Properties.Resources.Recycle_iconaaa1;
            btnModifC.ImageAlign = ContentAlignment.MiddleLeft;
            btnModifC.Location = new Point(275, 25);
            btnModifC.Margin = new Padding(4, 3, 4, 3);
            btnModifC.Name = "btnModifC";
            btnModifC.Size = new Size(255, 67);
            btnModifC.TabIndex = 9;
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
            btnAjouter.Location = new Point(4, 25);
            btnAjouter.Margin = new Padding(4, 3, 4, 3);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(240, 67);
            btnAjouter.TabIndex = 8;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(30, 28, 38);
            panel4.Location = new Point(78, 516);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(964, 10);
            panel4.TabIndex = 12;
            // 
            // Liste_Produit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(btnSauvgarde);
            Controls.Add(btnImprimerTous);
            Controls.Add(btnImprime);
            Controls.Add(btnAfficher);
            Controls.Add(dataClinet);
            Controls.Add(comboBox1);
            Controls.Add(panel3);
            Controls.Add(txtRechercher);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnSuppP);
            Controls.Add(btnModifC);
            Controls.Add(btnAjouter);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Liste_Produit";
            Size = new Size(1113, 661);
            Load += Liste_Produit_Load;
            ((System.ComponentModel.ISupportInitialize)dataClinet).EndInit();
            ((System.ComponentModel.ISupportInitialize)produitBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSuppP;
        private System.Windows.Forms.Button btnModifC;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.DataGridView dataClinet;
        private System.Windows.Forms.Button btnImprime;
        private System.Windows.Forms.Button btnImprimerTous;
        private System.Windows.Forms.Button btnSauvgarde;
        private BindingSource produitBindingSource;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewTextBoxColumn iDProduitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomProduitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantiteProduitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prixProduitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn imageProduitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private Panel panel4;
    }
}