namespace C_Stocke.Produits
{
    partial class Ajoute_Modifier_Produit
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
            lbProduit = new Label();
            btnquitte = new Button();
            btnEnrgP = new Button();
            btnActualiseP = new Button();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel10 = new Panel();
            txtQuantitP = new TextBox();
            produitBindingSource = new BindingSource(components);
            panel9 = new Panel();
            txtNumP = new TextBox();
            pictureBox3 = new PictureBox();
            panel7 = new Panel();
            txtPrixP = new TextBox();
            PicProduit = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnParcourir = new Button();
            comboCategorie = new ComboBox();
            categorieBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produitBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicProduit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categorieBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(178, 8, 55);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 1);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(178, 8, 55);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(817, 1);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 517);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(178, 8, 55);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 1);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 517);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(178, 8, 55);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 518);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(818, 1);
            panel4.TabIndex = 1;
            // 
            // lbProduit
            // 
            lbProduit.AutoSize = true;
            lbProduit.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProduit.ForeColor = Color.White;
            lbProduit.Location = new Point(14, 21);
            lbProduit.Margin = new Padding(4, 0, 4, 0);
            lbProduit.Name = "lbProduit";
            lbProduit.Size = new Size(222, 33);
            lbProduit.TabIndex = 6;
            lbProduit.Text = "Ajouter Produit";
            // 
            // btnquitte
            // 
            btnquitte.FlatAppearance.BorderSize = 0;
            btnquitte.FlatStyle = FlatStyle.Flat;
            btnquitte.Image = Properties.Resources.Deconnecte;
            btnquitte.Location = new Point(772, 21);
            btnquitte.Margin = new Padding(4, 3, 4, 3);
            btnquitte.Name = "btnquitte";
            btnquitte.Size = new Size(31, 27);
            btnquitte.TabIndex = 7;
            btnquitte.UseVisualStyleBackColor = true;
            btnquitte.Click += btnquitte_Click;
            // 
            // btnEnrgP
            // 
            btnEnrgP.BackColor = Color.FromArgb(178, 8, 55);
            btnEnrgP.FlatAppearance.BorderSize = 0;
            btnEnrgP.FlatStyle = FlatStyle.Flat;
            btnEnrgP.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnrgP.ForeColor = SystemColors.ControlLightLight;
            btnEnrgP.Location = new Point(449, 392);
            btnEnrgP.Margin = new Padding(4, 3, 4, 3);
            btnEnrgP.Name = "btnEnrgP";
            btnEnrgP.Size = new Size(334, 38);
            btnEnrgP.TabIndex = 47;
            btnEnrgP.Text = "Enregistrer";
            btnEnrgP.UseVisualStyleBackColor = false;
            btnEnrgP.Click += btnEnrgP_Click;
            // 
            // btnActualiseP
            // 
            btnActualiseP.BackColor = Color.FromArgb(178, 8, 55);
            btnActualiseP.FlatAppearance.BorderSize = 0;
            btnActualiseP.FlatStyle = FlatStyle.Flat;
            btnActualiseP.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualiseP.ForeColor = SystemColors.ControlLightLight;
            btnActualiseP.Location = new Point(44, 392);
            btnActualiseP.Margin = new Padding(4, 3, 4, 3);
            btnActualiseP.Name = "btnActualiseP";
            btnActualiseP.Size = new Size(334, 38);
            btnActualiseP.TabIndex = 46;
            btnActualiseP.Text = "Actualiser";
            btnActualiseP.UseVisualStyleBackColor = false;
            btnActualiseP.Click += btnActualiseP_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Quantie_32;
            pictureBox6.Location = new Point(444, 249);
            pictureBox6.Margin = new Padding(4, 3, 4, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 32);
            pictureBox6.TabIndex = 41;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.login_32;
            pictureBox5.Location = new Point(444, 162);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 32);
            pictureBox5.TabIndex = 45;
            pictureBox5.TabStop = false;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Location = new Point(491, 279);
            panel10.Margin = new Padding(4, 3, 4, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(292, 1);
            panel10.TabIndex = 38;
            // 
            // txtQuantitP
            // 
            txtQuantitP.BackColor = Color.FromArgb(30, 28, 38);
            txtQuantitP.BorderStyle = BorderStyle.None;
            txtQuantitP.DataBindings.Add(new Binding("DataContext", produitBindingSource, "Quantite_Produit", true));
            txtQuantitP.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantitP.ForeColor = Color.Silver;
            txtQuantitP.Location = new Point(491, 249);
            txtQuantitP.Margin = new Padding(4, 3, 4, 3);
            txtQuantitP.Multiline = true;
            txtQuantitP.Name = "txtQuantitP";
            txtQuantitP.Size = new Size(272, 23);
            txtQuantitP.TabIndex = 35;
            txtQuantitP.Text = "Quantite";
            txtQuantitP.KeyPress += txtQuantitP_KeyPress;
            // 
            // produitBindingSource
            // 
            produitBindingSource.DataSource = typeof(Entities.Produit);
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Location = new Point(491, 192);
            panel9.Margin = new Padding(4, 3, 4, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(292, 1);
            panel9.TabIndex = 44;
            // 
            // txtNumP
            // 
            txtNumP.BackColor = Color.FromArgb(30, 28, 38);
            txtNumP.BorderStyle = BorderStyle.None;
            txtNumP.DataBindings.Add(new Binding("DataContext", produitBindingSource, "Nom_Produit", true));
            txtNumP.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumP.ForeColor = Color.Silver;
            txtNumP.Location = new Point(491, 162);
            txtNumP.Margin = new Padding(4, 3, 4, 3);
            txtNumP.Multiline = true;
            txtNumP.Name = "txtNumP";
            txtNumP.Size = new Size(272, 23);
            txtNumP.TabIndex = 43;
            txtNumP.Text = "Nom Produit";
            txtNumP.Enter += comboCategorie_SelectedIndexChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.prix_32;
            pictureBox3.Location = new Point(440, 331);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 32);
            pictureBox3.TabIndex = 53;
            pictureBox3.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(491, 369);
            panel7.Margin = new Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(292, 1);
            panel7.TabIndex = 52;
            // 
            // txtPrixP
            // 
            txtPrixP.BackColor = Color.FromArgb(30, 28, 38);
            txtPrixP.BorderStyle = BorderStyle.None;
            txtPrixP.DataBindings.Add(new Binding("DataContext", produitBindingSource, "Prix_Produit", true));
            txtPrixP.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrixP.ForeColor = Color.Silver;
            txtPrixP.Location = new Point(486, 331);
            txtPrixP.Margin = new Padding(4, 3, 4, 3);
            txtPrixP.Multiline = true;
            txtPrixP.Name = "txtPrixP";
            txtPrixP.Size = new Size(272, 36);
            txtPrixP.TabIndex = 51;
            txtPrixP.Text = "Prix";
            txtPrixP.KeyPress += txtPrixP_KeyPress;
            // 
            // PicProduit
            // 
            PicProduit.BackColor = Color.FromArgb(224, 224, 224);
            PicProduit.DataBindings.Add(new Binding("DataContext", produitBindingSource, "Image_Produit", true));
            PicProduit.Location = new Point(132, 115);
            PicProduit.Margin = new Padding(4, 3, 4, 3);
            PicProduit.Name = "PicProduit";
            PicProduit.Size = new Size(246, 138);
            PicProduit.SizeMode = PictureBoxSizeMode.StretchImage;
            PicProduit.TabIndex = 54;
            PicProduit.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(40, 115);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 55;
            label1.Text = "Image:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(421, 115);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 56;
            label2.Text = "Categorie:";
            // 
            // btnParcourir
            // 
            btnParcourir.BackColor = Color.CornflowerBlue;
            btnParcourir.FlatAppearance.BorderSize = 0;
            btnParcourir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnParcourir.ForeColor = SystemColors.ControlLightLight;
            btnParcourir.Location = new Point(250, 279);
            btnParcourir.Margin = new Padding(4, 3, 4, 3);
            btnParcourir.Name = "btnParcourir";
            btnParcourir.Size = new Size(128, 36);
            btnParcourir.TabIndex = 58;
            btnParcourir.Text = "Parcourir..";
            btnParcourir.UseVisualStyleBackColor = false;
            btnParcourir.Click += btnParcourir_Click;
            // 
            // comboCategorie
            // 
            comboCategorie.DataBindings.Add(new Binding("DataContext", produitBindingSource, "Categorie", true));
            comboCategorie.DataSource = categorieBindingSource;
            comboCategorie.FormattingEnabled = true;
            comboCategorie.Location = new Point(552, 118);
            comboCategorie.Margin = new Padding(4, 3, 4, 3);
            comboCategorie.Name = "comboCategorie";
            comboCategorie.Size = new Size(230, 23);
            comboCategorie.TabIndex = 59;
            comboCategorie.SelectedIndexChanged += comboCategorie_SelectedIndexChanged;
            comboCategorie.Click += comboCategorie_SelectedIndexChanged;
            // 
            // categorieBindingSource
            // 
            categorieBindingSource.DataSource = typeof(Entities.Categorie);
            // 
            // Ajoute_Modifier_Produit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 28, 38);
            ClientSize = new Size(818, 519);
            Controls.Add(comboCategorie);
            Controls.Add(btnParcourir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PicProduit);
            Controls.Add(pictureBox3);
            Controls.Add(panel7);
            Controls.Add(txtPrixP);
            Controls.Add(btnEnrgP);
            Controls.Add(btnActualiseP);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(panel10);
            Controls.Add(txtQuantitP);
            Controls.Add(panel9);
            Controls.Add(txtNumP);
            Controls.Add(btnquitte);
            Controls.Add(lbProduit);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Ajoute_Modifier_Produit";
            Text = "Ajoute_Modifier_Produit";
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)produitBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicProduit).EndInit();
            ((System.ComponentModel.ISupportInitialize)categorieBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnquitte;
        public System.Windows.Forms.Label lbProduit;
        private System.Windows.Forms.Button btnEnrgP;
        public System.Windows.Forms.Button btnActualiseP;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtQuantitP;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtNumP;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtPrixP;
        private System.Windows.Forms.PictureBox PicProduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnParcourir;
        private System.Windows.Forms.ComboBox comboCategorie;
        private BindingSource produitBindingSource;
        private BindingSource categorieBindingSource;
    }
}