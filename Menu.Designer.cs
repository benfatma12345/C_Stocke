namespace C_Stock
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param namSe="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            panel1 = new Panel();
            pnlbtn = new Panel();
            Panel = new Button();
            btnUtilisateur = new Button();
            btnCommend = new Button();
            btnProduit = new Button();
            btnCategorie = new Button();
            btnClient = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panlfiche = new Panel();
            btnParametre = new Button();
            plparamette = new Panel();
            btndeconnecter = new Button();
            btnrestaurer = new Button();
            btncopie = new Button();
            btnconnecter = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            plparamette.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 35, 40);
            panel1.Controls.Add(pnlbtn);
            panel1.Controls.Add(Panel);
            panel1.Controls.Add(btnUtilisateur);
            panel1.Controls.Add(btnCommend);
            panel1.Controls.Add(btnProduit);
            panel1.Controls.Add(btnCategorie);
            panel1.Controls.Add(btnClient);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 706);
            panel1.TabIndex = 0;
            panel1.Click += btnParametre_Click;
            // 
            // pnlbtn
            // 
            pnlbtn.BackColor = Color.FromArgb(178, 8, 55);
            pnlbtn.Location = new Point(4, 113);
            pnlbtn.Margin = new Padding(4, 3, 4, 3);
            pnlbtn.Name = "pnlbtn";
            pnlbtn.Size = new Size(12, 54);
            pnlbtn.TabIndex = 4;
            pnlbtn.Click += btnParametre_Click;
            // 
            // Panel
            // 
            Panel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Panel.FlatAppearance.BorderSize = 0;
            Panel.FlatStyle = FlatStyle.Flat;
            Panel.ForeColor = SystemColors.Control;
            Panel.Image = C_Stocke.Properties.Resources.menu;
            Panel.Location = new Point(200, 14);
            Panel.Margin = new Padding(4, 3, 4, 3);
            Panel.Name = "Panel";
            Panel.Size = new Size(48, 31);
            Panel.TabIndex = 4;
            Panel.UseVisualStyleBackColor = true;
            Panel.Click += Panel_Click;
            // 
            // btnUtilisateur
            // 
            btnUtilisateur.FlatAppearance.BorderSize = 0;
            btnUtilisateur.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btnUtilisateur.FlatStyle = FlatStyle.Flat;
            btnUtilisateur.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUtilisateur.ForeColor = SystemColors.ControlLightLight;
            btnUtilisateur.Image = C_Stocke.Properties.Resources.user_profile;
            btnUtilisateur.ImageAlign = ContentAlignment.MiddleLeft;
            btnUtilisateur.Location = new Point(22, 599);
            btnUtilisateur.Margin = new Padding(4, 3, 4, 3);
            btnUtilisateur.Name = "btnUtilisateur";
            btnUtilisateur.Size = new Size(203, 46);
            btnUtilisateur.TabIndex = 8;
            btnUtilisateur.Text = "      Utilisateur";
            btnUtilisateur.UseVisualStyleBackColor = true;
            btnUtilisateur.Click += btnUtilisateur_Click;
            // 
            // btnCommend
            // 
            btnCommend.FlatAppearance.BorderSize = 0;
            btnCommend.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btnCommend.FlatStyle = FlatStyle.Flat;
            btnCommend.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCommend.ForeColor = SystemColors.ControlLightLight;
            btnCommend.Image = C_Stocke.Properties.Resources.shopping_cart;
            btnCommend.ImageAlign = ContentAlignment.MiddleLeft;
            btnCommend.Location = new Point(27, 467);
            btnCommend.Margin = new Padding(4, 3, 4, 3);
            btnCommend.Name = "btnCommend";
            btnCommend.Size = new Size(203, 46);
            btnCommend.TabIndex = 7;
            btnCommend.Text = "       Commend";
            btnCommend.UseVisualStyleBackColor = true;
            btnCommend.Click += btnCommend_Click;
            // 
            // btnProduit
            // 
            btnProduit.FlatAppearance.BorderSize = 0;
            btnProduit.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btnProduit.FlatStyle = FlatStyle.Flat;
            btnProduit.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduit.ForeColor = SystemColors.ControlLightLight;
            btnProduit.Image = C_Stocke.Properties.Resources.shopping_cart;
            btnProduit.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduit.Location = new Point(22, 231);
            btnProduit.Margin = new Padding(4, 3, 4, 3);
            btnProduit.Name = "btnProduit";
            btnProduit.Size = new Size(208, 46);
            btnProduit.TabIndex = 6;
            btnProduit.Text = "  Produit";
            btnProduit.UseVisualStyleBackColor = true;
            btnProduit.Click += btnProduit_Click;
            // 
            // btnCategorie
            // 
            btnCategorie.FlatAppearance.BorderSize = 0;
            btnCategorie.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btnCategorie.FlatStyle = FlatStyle.Flat;
            btnCategorie.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategorie.ForeColor = SystemColors.ControlLightLight;
            btnCategorie.Image = C_Stocke.Properties.Resources.catalog;
            btnCategorie.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategorie.Location = new Point(22, 348);
            btnCategorie.Margin = new Padding(4, 3, 4, 3);
            btnCategorie.Name = "btnCategorie";
            btnCategorie.Size = new Size(208, 46);
            btnCategorie.TabIndex = 5;
            btnCategorie.Text = "      Categorie";
            btnCategorie.UseVisualStyleBackColor = true;
            btnCategorie.Click += btnCategorie_Click;
            // 
            // btnClient
            // 
            btnClient.FlatAppearance.BorderSize = 0;
            btnClient.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btnClient.FlatStyle = FlatStyle.Flat;
            btnClient.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClient.ForeColor = SystemColors.ControlLightLight;
            btnClient.Image = C_Stocke.Properties.Resources.client;
            btnClient.ImageAlign = ContentAlignment.MiddleLeft;
            btnClient.Location = new Point(27, 121);
            btnClient.Margin = new Padding(4, 3, 4, 3);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(203, 46);
            btnClient.TabIndex = 4;
            btnClient.Text = "Client";
            btnClient.UseVisualStyleBackColor = true;
            btnClient.Click += btnClient_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(178, 8, 55);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(247, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 13);
            panel2.TabIndex = 1;
            panel2.Click += btnParametre_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panlfiche);
            panel3.Controls.Add(btnParametre);
            panel3.Controls.Add(plparamette);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(247, 13);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(914, 693);
            panel3.TabIndex = 2;
            panel3.Click += btnParametre_Click;
            // 
            // panlfiche
            // 
            panlfiche.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panlfiche.BackColor = Color.White;
            panlfiche.Location = new Point(7, 64);
            panlfiche.Margin = new Padding(4, 3, 4, 3);
            panlfiche.Name = "panlfiche";
            panlfiche.Size = new Size(900, 616);
            panlfiche.TabIndex = 11;
            // 
            // btnParametre
            // 
            btnParametre.FlatAppearance.BorderSize = 0;
            btnParametre.FlatStyle = FlatStyle.Flat;
            btnParametre.Image = C_Stocke.Properties.Resources.settings;
            btnParametre.Location = new Point(7, 3);
            btnParametre.Margin = new Padding(4, 3, 4, 3);
            btnParametre.Name = "btnParametre";
            btnParametre.Size = new Size(34, 31);
            btnParametre.TabIndex = 10;
            btnParametre.UseVisualStyleBackColor = true;
            btnParametre.Click += btnParametre_Click;
            // 
            // plparamette
            // 
            plparamette.BackColor = Color.FromArgb(41, 35, 40);
            plparamette.Controls.Add(btndeconnecter);
            plparamette.Controls.Add(btnrestaurer);
            plparamette.Controls.Add(btncopie);
            plparamette.Controls.Add(btnconnecter);
            plparamette.Location = new Point(48, 7);
            plparamette.Margin = new Padding(4, 3, 4, 3);
            plparamette.Name = "plparamette";
            plparamette.Size = new Size(513, 51);
            plparamette.TabIndex = 9;
            // 
            // btndeconnecter
            // 
            btndeconnecter.FlatAppearance.BorderColor = Color.FromArgb(178, 8, 55);
            btndeconnecter.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btndeconnecter.FlatStyle = FlatStyle.Flat;
            btndeconnecter.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndeconnecter.ForeColor = SystemColors.ControlLightLight;
            btndeconnecter.Image = C_Stocke.Properties.Resources._new;
            btndeconnecter.ImageAlign = ContentAlignment.MiddleLeft;
            btndeconnecter.Location = new Point(4, 190);
            btndeconnecter.Margin = new Padding(4, 3, 4, 3);
            btndeconnecter.Name = "btndeconnecter";
            btndeconnecter.Size = new Size(506, 58);
            btndeconnecter.TabIndex = 3;
            btndeconnecter.Text = "Déconnecter";
            btndeconnecter.UseVisualStyleBackColor = true;
            btndeconnecter.Click += btndeconnecter_Click;
            // 
            // btnrestaurer
            // 
            btnrestaurer.FlatAppearance.BorderColor = Color.FromArgb(178, 8, 55);
            btnrestaurer.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btnrestaurer.FlatStyle = FlatStyle.Flat;
            btnrestaurer.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnrestaurer.ForeColor = SystemColors.ControlLightLight;
            btnrestaurer.Image = C_Stocke.Properties.Resources.cloud_computing__1_;
            btnrestaurer.ImageAlign = ContentAlignment.MiddleLeft;
            btnrestaurer.Location = new Point(4, 52);
            btnrestaurer.Margin = new Padding(4, 3, 4, 3);
            btnrestaurer.Name = "btnrestaurer";
            btnrestaurer.Size = new Size(506, 60);
            btnrestaurer.TabIndex = 2;
            btnrestaurer.Text = "Resaturer une copie enregistrée";
            btnrestaurer.UseVisualStyleBackColor = true;
            // 
            // btncopie
            // 
            btncopie.FlatAppearance.BorderColor = Color.FromArgb(178, 8, 55);
            btncopie.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btncopie.FlatStyle = FlatStyle.Flat;
            btncopie.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncopie.ForeColor = SystemColors.ControlLightLight;
            btncopie.Image = C_Stocke.Properties.Resources.cloud_computing;
            btncopie.ImageAlign = ContentAlignment.MiddleLeft;
            btncopie.Location = new Point(3, 118);
            btncopie.Margin = new Padding(4, 3, 4, 3);
            btncopie.Name = "btncopie";
            btncopie.Size = new Size(506, 66);
            btncopie.TabIndex = 1;
            btncopie.Text = "Créer une copie de l'application";
            btncopie.UseVisualStyleBackColor = true;
            // 
            // btnconnecter
            // 
            btnconnecter.FlatAppearance.BorderColor = Color.FromArgb(178, 8, 55);
            btnconnecter.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btnconnecter.FlatStyle = FlatStyle.Flat;
            btnconnecter.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnconnecter.ForeColor = SystemColors.ControlLightLight;
            btnconnecter.Image = C_Stocke.Properties.Resources.user_profile;
            btnconnecter.ImageAlign = ContentAlignment.MiddleLeft;
            btnconnecter.Location = new Point(4, 3);
            btnconnecter.Margin = new Padding(4, 3, 4, 3);
            btnconnecter.Name = "btnconnecter";
            btnconnecter.Size = new Size(506, 43);
            btnconnecter.TabIndex = 0;
            btnconnecter.Text = "Connecter";
            btnconnecter.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = C_Stocke.Properties.Resources.minus_sign1;
            button2.Location = new Point(815, 3);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(51, 31);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = C_Stocke.Properties.Resources._switch;
            button1.Location = new Point(860, 3);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(48, 31);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 706);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Menu";
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            plparamette.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnUtilisateur;
        private System.Windows.Forms.Button btnCommend;
        private System.Windows.Forms.Button btnProduit;
        private System.Windows.Forms.Button btnCategorie;
        private System.Windows.Forms.Button Panel;
        private System.Windows.Forms.Panel pnlbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel plparamette;
        private System.Windows.Forms.Button btndeconnecter;
        private System.Windows.Forms.Button btnrestaurer;
        private System.Windows.Forms.Button btncopie;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnconnecter;
        private System.Windows.Forms.Button btnParametre;
        private bool isParamOpen = false;
        private int panelMaxHeight = 200; // hauteur max du panel paramètres
        private System.Windows.Forms.Panel panlfiche;
    }
}
