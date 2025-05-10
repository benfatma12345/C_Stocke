namespace C_Stocke.Produits
{
    partial class Photo_Produit
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
            btnquitte = new Button();
            produitBindingSource = new BindingSource(components);
            ImageProduit = new PictureBox();
            categorieBindingSource = new BindingSource(components);
            ProduitNom = new Label();
            ((System.ComponentModel.ISupportInitialize)produitBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageProduit).BeginInit();
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
            panel1.Size = new Size(506, 1);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(178, 8, 55);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(505, 1);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 441);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(178, 8, 55);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 1);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 441);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(178, 8, 55);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 442);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(506, 1);
            panel4.TabIndex = 1;
            // 
            // btnquitte
            // 
            btnquitte.FlatAppearance.BorderSize = 0;
            btnquitte.FlatStyle = FlatStyle.Flat;
            btnquitte.Image = Properties.Resources.Deconnecte;
            btnquitte.Location = new Point(462, 12);
            btnquitte.Margin = new Padding(4, 3, 4, 3);
            btnquitte.Name = "btnquitte";
            btnquitte.Size = new Size(31, 27);
            btnquitte.TabIndex = 7;
            btnquitte.UseVisualStyleBackColor = true;
            btnquitte.Click += btnquitte_Click;
            // 
            // produitBindingSource
            // 
            produitBindingSource.DataSource = typeof(Entities.Produit);
            // 
            // ImageProduit
            // 
            ImageProduit.BackColor = Color.FromArgb(224, 224, 224);
            ImageProduit.DataBindings.Add(new Binding("DataContext", produitBindingSource, "Image_Produit", true));
            ImageProduit.Location = new Point(14, 73);
            ImageProduit.Margin = new Padding(4, 3, 4, 3);
            ImageProduit.Name = "ImageProduit";
            ImageProduit.Size = new Size(479, 358);
            ImageProduit.SizeMode = PictureBoxSizeMode.StretchImage;
            ImageProduit.TabIndex = 54;
            ImageProduit.TabStop = false;
            // 
            // categorieBindingSource
            // 
            categorieBindingSource.DataSource = typeof(Entities.Categorie);
            // 
            // ProduitNom
            // 
            ProduitNom.AutoSize = true;
            ProduitNom.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProduitNom.ForeColor = SystemColors.ButtonHighlight;
            ProduitNom.Location = new Point(191, 21);
            ProduitNom.Name = "ProduitNom";
            ProduitNom.Size = new Size(102, 18);
            ProduitNom.TabIndex = 55;
            ProduitNom.Text = "ProduitNom";
            // 
            // Photo_Produit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 28, 38);
            ClientSize = new Size(506, 443);
            Controls.Add(ProduitNom);
            Controls.Add(ImageProduit);
            Controls.Add(btnquitte);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Photo_Produit";
            Text = "Ajoute_Modifier_Produit";
            ((System.ComponentModel.ISupportInitialize)produitBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageProduit).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnParcourir;
        private System.Windows.Forms.ComboBox comboCategorie;
        private BindingSource produitBindingSource;
        private BindingSource categorieBindingSource;
        public PictureBox ImageProduit;
        public Label ProduitNom;
    }
}