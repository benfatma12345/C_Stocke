namespace C_Stocke.Commandes
{
    partial class Produit_Commande
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            btnquitte = new Button();
            btnEnrgP = new Button();
            panel8 = new Panel();
            txtto = new TextBox();
            textBox2 = new TextBox();
            txtQuantiteCommande = new TextBox();
            lbProduit = new Label();
            Detaill = new Label();
            txttotal = new Label();
            panel7 = new Panel();
            txtremise = new Label();
            panel6 = new Panel();
            txtQuantite = new Label();
            panel5 = new Panel();
            lbPrix = new Label();
            lbStock = new Label();
            lbnom = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel9 = new Panel();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(178, 8, 55);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(761, 1);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(178, 8, 55);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(760, 1);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 466);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(178, 8, 55);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 1);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 466);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(178, 8, 55);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 467);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(761, 1);
            panel4.TabIndex = 1;
            // 
            // btnquitte
            // 
            btnquitte.FlatAppearance.BorderSize = 0;
            btnquitte.FlatStyle = FlatStyle.Flat;
            btnquitte.Image = Properties.Resources.Deconnecte;
            btnquitte.Location = new Point(710, 10);
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
            btnEnrgP.Location = new Point(199, 408);
            btnEnrgP.Margin = new Padding(4, 3, 4, 3);
            btnEnrgP.Name = "btnEnrgP";
            btnEnrgP.Size = new Size(334, 38);
            btnEnrgP.TabIndex = 47;
            btnEnrgP.Text = "Enregistrer";
            btnEnrgP.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(txtto);
            panel8.Controls.Add(textBox2);
            panel8.Controls.Add(txtQuantiteCommande);
            panel8.Controls.Add(lbProduit);
            panel8.Controls.Add(Detaill);
            panel8.Controls.Add(txttotal);
            panel8.Controls.Add(panel7);
            panel8.Controls.Add(txtremise);
            panel8.Controls.Add(panel6);
            panel8.Controls.Add(txtQuantite);
            panel8.Controls.Add(panel5);
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(13, 37);
            panel8.Name = "panel8";
            panel8.Size = new Size(716, 351);
            panel8.TabIndex = 60;
            // 
            // txtto
            // 
            txtto.Enabled = false;
            txtto.Location = new Point(406, 300);
            txtto.Name = "txtto";
            txtto.Size = new Size(292, 23);
            txtto.TabIndex = 71;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(406, 191);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 23);
            textBox2.TabIndex = 70;
            // 
            // txtQuantiteCommande
            // 
            txtQuantiteCommande.Location = new Point(406, 87);
            txtQuantiteCommande.Name = "txtQuantiteCommande";
            txtQuantiteCommande.Size = new Size(292, 23);
            txtQuantiteCommande.TabIndex = 69;
            // 
            // lbProduit
            // 
            lbProduit.AutoSize = true;
            lbProduit.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProduit.ForeColor = Color.White;
            lbProduit.Location = new Point(3, 0);
            lbProduit.Margin = new Padding(4, 0, 4, 0);
            lbProduit.Name = "lbProduit";
            lbProduit.Size = new Size(151, 24);
            lbProduit.TabIndex = 68;
            lbProduit.Text = "Vender Produit";
            // 
            // Detaill
            // 
            Detaill.AutoSize = true;
            Detaill.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Detaill.ForeColor = SystemColors.ButtonFace;
            Detaill.Location = new Point(3, 27);
            Detaill.Name = "Detaill";
            Detaill.Size = new Size(134, 24);
            Detaill.TabIndex = 61;
            Detaill.Text = "Detail Produit";
            // 
            // txttotal
            // 
            txttotal.AutoSize = true;
            txttotal.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txttotal.ForeColor = SystemColors.ButtonFace;
            txttotal.Location = new Point(443, 243);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(56, 24);
            txttotal.TabIndex = 67;
            txttotal.Text = "Total";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(406, 252);
            panel7.Margin = new Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(292, 1);
            panel7.TabIndex = 66;
            // 
            // txtremise
            // 
            txtremise.AutoSize = true;
            txtremise.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtremise.ForeColor = SystemColors.ButtonFace;
            txtremise.Location = new Point(443, 134);
            txtremise.Name = "txtremise";
            txtremise.Size = new Size(80, 24);
            txtremise.TabIndex = 65;
            txtremise.Text = "Remise";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(406, 143);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(292, 1);
            panel6.TabIndex = 64;
            // 
            // txtQuantite
            // 
            txtQuantite.AutoSize = true;
            txtQuantite.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantite.ForeColor = SystemColors.ButtonFace;
            txtQuantite.Location = new Point(443, 27);
            txtQuantite.Name = "txtQuantite";
            txtQuantite.Size = new Size(88, 24);
            txtQuantite.TabIndex = 63;
            txtQuantite.Text = "Quantite";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(lbPrix);
            panel5.Controls.Add(lbStock);
            panel5.Controls.Add(lbnom);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(12, 36);
            panel5.Name = "panel5";
            panel5.Size = new Size(364, 287);
            panel5.TabIndex = 62;
            // 
            // lbPrix
            // 
            lbPrix.AutoSize = true;
            lbPrix.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPrix.Location = new Point(130, 205);
            lbPrix.Name = "lbPrix";
            lbPrix.Size = new Size(57, 20);
            lbPrix.TabIndex = 5;
            lbPrix.Text = "label1";
            // 
            // lbStock
            // 
            lbStock.AutoSize = true;
            lbStock.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbStock.Location = new Point(130, 137);
            lbStock.Name = "lbStock";
            lbStock.Size = new Size(57, 20);
            lbStock.TabIndex = 4;
            lbStock.Text = "label1";
            lbStock.Click += lbStock_Click;
            // 
            // lbnom
            // 
            lbnom.AutoSize = true;
            lbnom.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnom.Location = new Point(130, 72);
            lbnom.Name = "lbnom";
            lbnom.Size = new Size(57, 20);
            lbnom.TabIndex = 3;
            lbnom.Text = "label1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(58, 205);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 2;
            label6.Text = "Prix:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(58, 137);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 1;
            label5.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(58, 72);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 0;
            label4.Text = "Nom:";
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Location = new Point(406, 36);
            panel9.Margin = new Padding(4, 3, 4, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(292, 1);
            panel9.TabIndex = 61;
            // 
            // Produit_Commande
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 28, 38);
            ClientSize = new Size(761, 468);
            Controls.Add(panel8);
            Controls.Add(btnEnrgP);
            Controls.Add(btnquitte);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Produit_Commande";
            Text = "Ajoute_Modifier_Produit";
            Load += Produit_Commande_Load;
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnquitte;
        private System.Windows.Forms.Button btnEnrgP;
        private BindingSource produitBindingSource;
        private BindingSource categorieBindingSource;
        private Panel panel8;
        private Label txttotal;
        private Panel panel7;
        private Label txtremise;
        private Panel panel6;
        private Label txtQuantite;
        private Panel panel5;
        private Panel panel9;
        private TextBox textBox2;
        private TextBox txtQuantiteCommande;
        public Label lbProduit;
        private Label Detaill;
        private Label label6;
        private Label label5;
        private Label label4;
        public Label lbnom;
        public Label lbPrix;
        public Label lbStock;
        public TextBox txtto;
    }
}