namespace C_Stocke.Commandes
{
    partial class DetailCommande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            btnquitte = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel6 = new Panel();
            txtRechercher = new TextBox();
            dataproduit = new DataGridView();
            iDProduitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomProduitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantiteProduitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            prixProduitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            produitBindingSource = new BindingSource(components);
            label3 = new Label();
            panel16 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnClient = new Button();
            panel7 = new Panel();
            label6 = new Label();
            txtNom = new TextBox();
            clientBindingSource = new BindingSource(components);
            panel8 = new Panel();
            label7 = new Label();
            txtPrenom = new TextBox();
            panel9 = new Panel();
            label8 = new Label();
            txttele = new TextBox();
            panel11 = new Panel();
            label10 = new Label();
            txtVille = new TextBox();
            panel10 = new Panel();
            label9 = new Label();
            txtPays = new TextBox();
            panel12 = new Panel();
            label11 = new Label();
            txtmail = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            panel5 = new Panel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label5 = new Label();
            datadetailCommande = new DataGridView();
            panel13 = new Panel();
            label12 = new Label();
            txtHTT = new TextBox();
            panel14 = new Panel();
            label13 = new Label();
            txtTVA = new TextBox();
            panel15 = new Panel();
            label14 = new Label();
            txtTTC = new TextBox();
            BtnEnregistre = new Button();
            Client = new Label();
            Produit = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataproduit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produitBindingSource).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel12.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datadetailCommande).BeginInit();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(178, 8, 55);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1105, 2);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(178, 8, 55);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1103, 2);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(2, 573);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(178, 8, 55);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 573);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1103, 2);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(178, 8, 55);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 2);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(2, 571);
            panel4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MistyRose;
            label1.Location = new Point(410, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(310, 37);
            label1.TabIndex = 5;
            label1.Text = "Ajouter Commande";
            // 
            // btnquitte
            // 
            btnquitte.FlatAppearance.BorderSize = 0;
            btnquitte.FlatStyle = FlatStyle.Flat;
            btnquitte.Image = Properties.Resources.Deconnecte;
            btnquitte.Location = new Point(1039, 12);
            btnquitte.Margin = new Padding(4, 3, 4, 3);
            btnquitte.Name = "btnquitte";
            btnquitte.Size = new Size(31, 27);
            btnquitte.TabIndex = 4;
            btnquitte.UseVisualStyleBackColor = true;
            btnquitte.Click += btnquitte_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(dataproduit);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(panel16);
            flowLayoutPanel1.Location = new Point(12, 67);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(433, 496);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtRechercher);
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(420, 60);
            panel6.TabIndex = 26;
            // 
            // txtRechercher
            // 
            txtRechercher.BackColor = Color.White;
            txtRechercher.BorderStyle = BorderStyle.None;
            txtRechercher.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRechercher.ForeColor = Color.Silver;
            txtRechercher.Location = new Point(63, 17);
            txtRechercher.Margin = new Padding(4, 3, 4, 3);
            txtRechercher.Multiline = true;
            txtRechercher.Name = "txtRechercher";
            txtRechercher.Size = new Size(299, 28);
            txtRechercher.TabIndex = 7;
            txtRechercher.Text = "Rechercher";
            txtRechercher.TextAlign = HorizontalAlignment.Center;
            txtRechercher.TextChanged += txtRechercher_TextChanged;
            // 
            // dataproduit
            // 
            dataproduit.AllowUserToOrderColumns = true;
            dataproduit.AutoGenerateColumns = false;
            dataproduit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataproduit.Columns.AddRange(new DataGridViewColumn[] { iDProduitDataGridViewTextBoxColumn, nomProduitDataGridViewTextBoxColumn, quantiteProduitDataGridViewTextBoxColumn, prixProduitDataGridViewTextBoxColumn });
            dataproduit.DataSource = produitBindingSource;
            dataproduit.Location = new Point(3, 69);
            dataproduit.Name = "dataproduit";
            dataproduit.RowTemplate.ReadOnly = true;
            dataproduit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataproduit.Size = new Size(420, 471);
            dataproduit.TabIndex = 27;
            dataproduit.CellContentDoubleClick += dataproduit_CellContentDoubleClick;
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
            // produitBindingSource
            // 
            produitBindingSource.DataSource = typeof(Entities.Produit);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 543);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // panel16
            // 
            panel16.Location = new Point(3, 567);
            panel16.Name = "panel16";
            panel16.Size = new Size(616, 32);
            panel16.TabIndex = 34;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnClient);
            flowLayoutPanel2.Controls.Add(panel7);
            flowLayoutPanel2.Controls.Add(panel8);
            flowLayoutPanel2.Controls.Add(panel9);
            flowLayoutPanel2.Controls.Add(panel11);
            flowLayoutPanel2.Controls.Add(panel10);
            flowLayoutPanel2.Controls.Add(panel12);
            flowLayoutPanel2.Location = new Point(451, 67);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(642, 143);
            flowLayoutPanel2.TabIndex = 14;
            // 
            // btnClient
            // 
            btnClient.BackColor = Color.FromArgb(192, 0, 0);
            btnClient.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnClient.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnClient.ForeColor = SystemColors.AppWorkspace;
            btnClient.Location = new Point(3, 3);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(75, 41);
            btnClient.TabIndex = 32;
            btnClient.Text = "Parcourir";
            btnClient.UseVisualStyleBackColor = false;
            btnClient.Click += btnClient_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(label6);
            panel7.Controls.Add(txtNom);
            panel7.Location = new Point(84, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(246, 35);
            panel7.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(-5, 0);
            label6.Name = "label6";
            label6.Size = new Size(45, 21);
            label6.TabIndex = 8;
            label6.Text = "Nom";
            // 
            // txtNom
            // 
            txtNom.BackColor = Color.White;
            txtNom.BorderStyle = BorderStyle.None;
            txtNom.DataBindings.Add(new Binding("DataContext", clientBindingSource, "Nom_Client", true));
            txtNom.Enabled = false;
            txtNom.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNom.ForeColor = Color.Silver;
            txtNom.Location = new Point(49, 3);
            txtNom.Margin = new Padding(4, 3, 4, 3);
            txtNom.Multiline = true;
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(176, 29);
            txtNom.TabIndex = 7;
            // 
            // clientBindingSource
            // 
            clientBindingSource.DataSource = typeof(Entities.Client);
            // 
            // panel8
            // 
            panel8.Controls.Add(label7);
            panel8.Controls.Add(txtPrenom);
            panel8.Location = new Point(336, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(293, 35);
            panel8.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(-5, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 21);
            label7.TabIndex = 8;
            label7.Text = "Prenom";
            // 
            // txtPrenom
            // 
            txtPrenom.BackColor = Color.White;
            txtPrenom.BorderStyle = BorderStyle.None;
            txtPrenom.DataBindings.Add(new Binding("DataContext", clientBindingSource, "Prenom_Client", true));
            txtPrenom.Enabled = false;
            txtPrenom.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrenom.ForeColor = Color.Silver;
            txtPrenom.Location = new Point(60, 3);
            txtPrenom.Margin = new Padding(4, 3, 4, 3);
            txtPrenom.Multiline = true;
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(218, 29);
            txtPrenom.TabIndex = 7;
            // 
            // panel9
            // 
            panel9.Controls.Add(label8);
            panel9.Controls.Add(txttele);
            panel9.Location = new Point(3, 50);
            panel9.Name = "panel9";
            panel9.Size = new Size(288, 35);
            panel9.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(-5, 0);
            label8.Name = "label8";
            label8.Size = new Size(80, 21);
            label8.TabIndex = 8;
            label8.Text = "Telephone";
            // 
            // txttele
            // 
            txttele.BackColor = Color.White;
            txttele.BorderStyle = BorderStyle.None;
            txttele.DataBindings.Add(new Binding("DataContext", clientBindingSource, "Telephone_Client", true));
            txttele.Enabled = false;
            txttele.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txttele.ForeColor = Color.Silver;
            txttele.Location = new Point(74, 3);
            txttele.Margin = new Padding(4, 3, 4, 3);
            txttele.Multiline = true;
            txttele.Name = "txttele";
            txttele.Size = new Size(208, 29);
            txttele.TabIndex = 7;
            // 
            // panel11
            // 
            panel11.Controls.Add(label10);
            panel11.Controls.Add(txtVille);
            panel11.Location = new Point(297, 50);
            panel11.Name = "panel11";
            panel11.Size = new Size(332, 35);
            panel11.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(-5, -3);
            label10.Name = "label10";
            label10.Size = new Size(40, 21);
            label10.TabIndex = 8;
            label10.Text = "Ville";
            // 
            // txtVille
            // 
            txtVille.BackColor = Color.White;
            txtVille.BorderStyle = BorderStyle.None;
            txtVille.DataBindings.Add(new Binding("DataContext", clientBindingSource, "Ville_Client", true));
            txtVille.Enabled = false;
            txtVille.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtVille.ForeColor = Color.Silver;
            txtVille.Location = new Point(49, 3);
            txtVille.Margin = new Padding(4, 3, 4, 3);
            txtVille.Multiline = true;
            txtVille.Name = "txtVille";
            txtVille.Size = new Size(268, 29);
            txtVille.TabIndex = 7;
            // 
            // panel10
            // 
            panel10.Controls.Add(label9);
            panel10.Controls.Add(txtPays);
            panel10.Location = new Point(3, 91);
            panel10.Name = "panel10";
            panel10.Size = new Size(292, 35);
            panel10.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(-5, 0);
            label9.Name = "label9";
            label9.Size = new Size(41, 21);
            label9.TabIndex = 8;
            label9.Text = "Pays";
            // 
            // txtPays
            // 
            txtPays.BackColor = Color.White;
            txtPays.BorderStyle = BorderStyle.None;
            txtPays.DataBindings.Add(new Binding("DataContext", clientBindingSource, "Pays_Client", true));
            txtPays.Enabled = false;
            txtPays.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPays.ForeColor = Color.Silver;
            txtPays.Location = new Point(49, 3);
            txtPays.Margin = new Padding(4, 3, 4, 3);
            txtPays.Multiline = true;
            txtPays.Name = "txtPays";
            txtPays.Size = new Size(239, 29);
            txtPays.TabIndex = 7;
            // 
            // panel12
            // 
            panel12.Controls.Add(label11);
            panel12.Controls.Add(txtmail);
            panel12.Location = new Point(301, 91);
            panel12.Name = "panel12";
            panel12.Size = new Size(328, 35);
            panel12.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(-5, 0);
            label11.Name = "label11";
            label11.Size = new Size(48, 21);
            label11.TabIndex = 8;
            label11.Text = "Email";
            // 
            // txtmail
            // 
            txtmail.BackColor = Color.White;
            txtmail.BorderStyle = BorderStyle.None;
            txtmail.DataBindings.Add(new Binding("DataContext", clientBindingSource, "Email_Client", true));
            txtmail.Enabled = false;
            txtmail.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtmail.ForeColor = Color.Silver;
            txtmail.Location = new Point(49, 3);
            txtmail.Margin = new Padding(4, 3, 4, 3);
            txtmail.Multiline = true;
            txtmail.Name = "txtmail";
            txtmail.Size = new Size(264, 29);
            txtmail.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(714, 214);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(285, 23);
            dateTimePicker1.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label2.Location = new Point(546, 213);
            label2.Name = "label2";
            label2.Size = new Size(171, 33);
            label2.TabIndex = 22;
            label2.Text = "Date Début";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 28, 38);
            panel5.Location = new Point(711, 237);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(286, 10);
            panel5.TabIndex = 21;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label5);
            flowLayoutPanel3.Controls.Add(datadetailCommande);
            flowLayoutPanel3.Controls.Add(panel13);
            flowLayoutPanel3.Controls.Add(panel14);
            flowLayoutPanel3.Controls.Add(panel15);
            flowLayoutPanel3.Controls.Add(BtnEnregistre);
            flowLayoutPanel3.Location = new Point(451, 253);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(651, 310);
            flowLayoutPanel3.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(98, 21);
            label5.TabIndex = 25;
            label5.Text = "Commande";
            // 
            // datadetailCommande
            // 
            datadetailCommande.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datadetailCommande.Location = new Point(3, 24);
            datadetailCommande.Name = "datadetailCommande";
            datadetailCommande.Size = new Size(639, 150);
            datadetailCommande.TabIndex = 0;
            // 
            // panel13
            // 
            panel13.Controls.Add(label12);
            panel13.Controls.Add(txtHTT);
            panel13.Location = new Point(3, 180);
            panel13.Name = "panel13";
            panel13.Size = new Size(341, 35);
            panel13.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(-5, 0);
            label12.Name = "label12";
            label12.Size = new Size(73, 21);
            label12.TabIndex = 8;
            label12.Text = "Total HTT";
            // 
            // txtHTT
            // 
            txtHTT.BackColor = Color.White;
            txtHTT.BorderStyle = BorderStyle.None;
            txtHTT.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHTT.ForeColor = Color.Silver;
            txtHTT.Location = new Point(75, 3);
            txtHTT.Margin = new Padding(4, 3, 4, 3);
            txtHTT.Multiline = true;
            txtHTT.Name = "txtHTT";
            txtHTT.Size = new Size(229, 29);
            txtHTT.TabIndex = 7;
            // 
            // panel14
            // 
            panel14.Controls.Add(label13);
            panel14.Controls.Add(txtTVA);
            panel14.Location = new Point(350, 180);
            panel14.Name = "panel14";
            panel14.Size = new Size(292, 35);
            panel14.TabIndex = 32;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(-5, 0);
            label13.Name = "label13";
            label13.Size = new Size(37, 21);
            label13.TabIndex = 8;
            label13.Text = "TVA";
            // 
            // txtTVA
            // 
            txtTVA.BackColor = Color.White;
            txtTVA.BorderStyle = BorderStyle.None;
            txtTVA.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTVA.ForeColor = Color.Silver;
            txtTVA.Location = new Point(49, 3);
            txtTVA.Margin = new Padding(4, 3, 4, 3);
            txtTVA.Multiline = true;
            txtTVA.Name = "txtTVA";
            txtTVA.Size = new Size(243, 29);
            txtTVA.TabIndex = 7;
            // 
            // panel15
            // 
            panel15.Controls.Add(label14);
            panel15.Controls.Add(txtTTC);
            panel15.Location = new Point(3, 221);
            panel15.Name = "panel15";
            panel15.Size = new Size(639, 35);
            panel15.TabIndex = 33;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(-5, 0);
            label14.Name = "label14";
            label14.Size = new Size(71, 21);
            label14.TabIndex = 8;
            label14.Text = "Total TTC";
            // 
            // txtTTC
            // 
            txtTTC.BackColor = Color.White;
            txtTTC.BorderStyle = BorderStyle.None;
            txtTTC.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTTC.ForeColor = Color.Silver;
            txtTTC.Location = new Point(184, 3);
            txtTTC.Margin = new Padding(4, 3, 4, 3);
            txtTTC.Multiline = true;
            txtTTC.Name = "txtTTC";
            txtTTC.Size = new Size(229, 29);
            txtTTC.TabIndex = 7;
            // 
            // BtnEnregistre
            // 
            BtnEnregistre.BackColor = Color.FromArgb(178, 8, 55);
            BtnEnregistre.FlatAppearance.BorderSize = 0;
            BtnEnregistre.FlatStyle = FlatStyle.Flat;
            BtnEnregistre.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEnregistre.ForeColor = SystemColors.ControlLightLight;
            BtnEnregistre.Location = new Point(4, 262);
            BtnEnregistre.Margin = new Padding(4, 3, 4, 3);
            BtnEnregistre.Name = "BtnEnregistre";
            BtnEnregistre.Size = new Size(638, 38);
            BtnEnregistre.TabIndex = 35;
            BtnEnregistre.Text = "Enregistrer";
            BtnEnregistre.UseVisualStyleBackColor = false;
            // 
            // Client
            // 
            Client.AutoSize = true;
            Client.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Client.ForeColor = SystemColors.ButtonHighlight;
            Client.Location = new Point(449, 49);
            Client.Name = "Client";
            Client.Size = new Size(55, 21);
            Client.TabIndex = 0;
            Client.Text = "Client";
            // 
            // Produit
            // 
            Produit.AutoSize = true;
            Produit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Produit.ForeColor = SystemColors.ButtonHighlight;
            Produit.Location = new Point(12, 63);
            Produit.Name = "Produit";
            Produit.Size = new Size(67, 21);
            Produit.TabIndex = 25;
            Produit.Text = "Produit";
            // 
            // DetailCommande
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 28, 38);
            ClientSize = new Size(1105, 575);
            Controls.Add(Produit);
            Controls.Add(Client);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(panel5);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(btnquitte);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "DetailCommande";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connextion";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataproduit).EndInit();
            ((System.ComponentModel.ISupportInitialize)produitBindingSource).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datadetailCommande).EndInit();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnquitte;
        private System.Windows.Forms.Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Panel panel5;
        private DataGridView dataproduit;
        private DataGridViewTextBoxColumn iDProduitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomProduitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantiteProduitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prixProduitDataGridViewTextBoxColumn;
        private BindingSource produitBindingSource;
        private FlowLayoutPanel flowLayoutPanel3;
        private DataGridView datadetailCommande;
        private Label Client;
        private Label Produit;
        private Label label3;
        private Label label5;
        private Panel panel6;
        private TextBox txtRechercher;
        private Panel panel7;
        private TextBox textBox1;
        private Label label4;
        private Label label6;
        private Panel panel8;
        private Label label7;
        private TextBox textBox2;
        private Panel panel9;
        private Label label8;
        private TextBox textBox3;
        private Panel panel11;
        private Label label10;
        private TextBox txtVille;
        private Panel panel10;
        private Label label9;
        private TextBox txtPays;
        private Panel panel12;
        private Label label11;
        private TextBox txtmail;
        private Panel panel13;
        private Label label12;
        private TextBox txtHTT;
        private Panel panel14;
        private Label label13;
        private TextBox txtTVA;
        private Panel panel15;
        private Label label14;
        private TextBox txtTTC;
        private Panel panel16;
        private Button BtnEnregistre;
        private Button btnClient;
        // Dans DetailCd.cs, ajoutez ces déclarations de contrôle au début de la classe
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txttele;
        private BindingSource clientBindingSource;


        // Assurez-vous que ces contrôles sont bien initialisés dans InitializeComponent()
    }
}