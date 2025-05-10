namespace C_Stocke.Clients
{
    partial class Ajouter_Modifier_Client
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
            lbClient = new Label();
            panel5 = new Panel();
            txtNom = new TextBox();
            clientBindingSource = new BindingSource(components);
            panel6 = new Panel();
            txtAd = new TextBox();
            panel7 = new Panel();
            txtPays = new TextBox();
            panel8 = new Panel();
            txtEmail = new TextBox();
            panel9 = new Panel();
            txtNum = new TextBox();
            panel10 = new Panel();
            txtVille = new TextBox();
            btnActualise = new Button();
            btnEnrg = new Button();
            panel11 = new Panel();
            txtPrenom = new TextBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnquitte = new Button();
            btnqut = new Button();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(178, 8, 55);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(828, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 486);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(178, 8, 55);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 1);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 484);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(178, 8, 55);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 485);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(828, 1);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(178, 8, 55);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(828, 1);
            panel4.TabIndex = 1;
            // 
            // lbClient
            // 
            lbClient.AutoSize = true;
            lbClient.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbClient.ForeColor = Color.White;
            lbClient.Location = new Point(27, 25);
            lbClient.Margin = new Padding(4, 0, 4, 0);
            lbClient.Name = "lbClient";
            lbClient.Size = new Size(191, 31);
            lbClient.TabIndex = 2;
            lbClient.Text = "Ajouter Client";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(65, 140);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(292, 1);
            panel5.TabIndex = 12;
            // 
            // txtNom
            // 
            txtNom.BackColor = Color.FromArgb(30, 28, 38);
            txtNom.BorderStyle = BorderStyle.None;
            txtNom.DataBindings.Add(new Binding("DataContext", clientBindingSource, "Nom_Client", true));
            txtNom.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNom.ForeColor = Color.Silver;
            txtNom.Location = new Point(65, 110);
            txtNom.Margin = new Padding(4, 3, 4, 3);
            txtNom.Multiline = true;
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(272, 23);
            txtNom.TabIndex = 11;
            txtNom.Text = "Nom d'utilisateur";
            // 
            // clientBindingSource
            // 
            clientBindingSource.DataSource = typeof(Entities.Client);
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(61, 292);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(292, 1);
            panel6.TabIndex = 15;
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.FromArgb(30, 28, 38);
            txtAd.BorderStyle = BorderStyle.None;
            txtAd.DataBindings.Add(new Binding("DataContext", clientBindingSource, "Adresse_Client", true));
            txtAd.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAd.ForeColor = Color.Silver;
            txtAd.Location = new Point(61, 262);
            txtAd.Margin = new Padding(4, 3, 4, 3);
            txtAd.Multiline = true;
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(272, 23);
            txtAd.TabIndex = 14;
            txtAd.Text = "Adresse";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(61, 353);
            panel7.Margin = new Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(292, 1);
            panel7.TabIndex = 18;
            // 
            // txtPays
            // 
            txtPays.BackColor = Color.FromArgb(30, 28, 38);
            txtPays.BorderStyle = BorderStyle.None;
            txtPays.DataBindings.Add(new Binding("DataContext", clientBindingSource, "Pays_Client", true));
            txtPays.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPays.ForeColor = Color.Silver;
            txtPays.Location = new Point(56, 315);
            txtPays.Margin = new Padding(4, 3, 4, 3);
            txtPays.Multiline = true;
            txtPays.Name = "txtPays";
            txtPays.Size = new Size(272, 36);
            txtPays.TabIndex = 17;
            txtPays.Text = "Pays Client";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Location = new Point(465, 141);
            panel8.Margin = new Padding(4, 3, 4, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(292, 1);
            panel8.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(30, 28, 38);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.DataBindings.Add(new Binding("DataContext", clientBindingSource, "Email_Client", true));
            txtEmail.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.Silver;
            txtEmail.Location = new Point(465, 111);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(272, 23);
            txtEmail.TabIndex = 17;
            txtEmail.Text = "Email";
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Location = new Point(465, 212);
            panel9.Margin = new Padding(4, 3, 4, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(292, 1);
            panel9.TabIndex = 21;
            // 
            // txtNum
            // 
            txtNum.BackColor = Color.FromArgb(30, 28, 38);
            txtNum.BorderStyle = BorderStyle.None;
            txtNum.DataBindings.Add(new Binding("DataContext", clientBindingSource, "Telephone_Client", true));
            txtNum.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum.ForeColor = Color.Silver;
            txtNum.Location = new Point(465, 182);
            txtNum.Margin = new Padding(4, 3, 4, 3);
            txtNum.Multiline = true;
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(272, 23);
            txtNum.TabIndex = 20;
            txtNum.Text = "Numero";
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Location = new Point(465, 300);
            panel10.Margin = new Padding(4, 3, 4, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(292, 1);
            panel10.TabIndex = 18;
            // 
            // txtVille
            // 
            txtVille.BackColor = Color.FromArgb(30, 28, 38);
            txtVille.BorderStyle = BorderStyle.None;
            txtVille.DataBindings.Add(new Binding("DataContext", clientBindingSource, "Ville_Client", true));
            txtVille.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVille.ForeColor = Color.Silver;
            txtVille.Location = new Point(465, 270);
            txtVille.Margin = new Padding(4, 3, 4, 3);
            txtVille.Multiline = true;
            txtVille.Name = "txtVille";
            txtVille.Size = new Size(272, 23);
            txtVille.TabIndex = 17;
            txtVille.Text = "Ville Client";
            // 
            // btnActualise
            // 
            btnActualise.BackColor = Color.FromArgb(178, 8, 55);
            btnActualise.FlatAppearance.BorderSize = 0;
            btnActualise.FlatStyle = FlatStyle.Flat;
            btnActualise.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualise.ForeColor = SystemColors.ControlLightLight;
            btnActualise.Location = new Point(19, 413);
            btnActualise.Margin = new Padding(4, 3, 4, 3);
            btnActualise.Name = "btnActualise";
            btnActualise.Size = new Size(334, 38);
            btnActualise.TabIndex = 23;
            btnActualise.Text = "Actualiser";
            btnActualise.UseVisualStyleBackColor = false;
            // 
            // btnEnrg
            // 
            btnEnrg.BackColor = Color.FromArgb(178, 8, 55);
            btnEnrg.FlatAppearance.BorderSize = 0;
            btnEnrg.FlatStyle = FlatStyle.Flat;
            btnEnrg.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnrg.ForeColor = SystemColors.ControlLightLight;
            btnEnrg.Location = new Point(424, 413);
            btnEnrg.Margin = new Padding(4, 3, 4, 3);
            btnEnrg.Name = "btnEnrg";
            btnEnrg.Size = new Size(334, 38);
            btnEnrg.TabIndex = 24;
            btnEnrg.Text = "Enregistrer";
            btnEnrg.UseVisualStyleBackColor = false;
            btnEnrg.Click += btnEnrg_Click_1;
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.Location = new Point(61, 213);
            panel11.Margin = new Padding(4, 3, 4, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(292, 1);
            panel11.TabIndex = 26;
            // 
            // txtPrenom
            // 
            txtPrenom.BackColor = Color.FromArgb(30, 28, 38);
            txtPrenom.BorderStyle = BorderStyle.None;
            txtPrenom.DataBindings.Add(new Binding("DataContext", clientBindingSource, "Prenom_Client", true));
            txtPrenom.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrenom.ForeColor = Color.Silver;
            txtPrenom.Location = new Point(61, 183);
            txtPrenom.Margin = new Padding(4, 3, 4, 3);
            txtPrenom.Multiline = true;
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(272, 23);
            txtPrenom.TabIndex = 25;
            txtPrenom.Text = "Prenom d'utilisateur";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.login_32;
            pictureBox7.Location = new Point(14, 183);
            pictureBox7.Margin = new Padding(4, 3, 4, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(41, 32);
            pictureBox7.TabIndex = 27;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.ville_32;
            pictureBox6.Location = new Point(419, 270);
            pictureBox6.Margin = new Padding(4, 3, 4, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 32);
            pictureBox6.TabIndex = 19;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.telephone_call;
            pictureBox5.Location = new Point(419, 182);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 32);
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Gmail_32;
            pictureBox4.Location = new Point(419, 111);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 32);
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Country_32;
            pictureBox3.Location = new Point(14, 322);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 32);
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.adresse;
            pictureBox2.Location = new Point(14, 262);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 32);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login_32;
            pictureBox1.Location = new Point(14, 109);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 32);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnquitte
            // 
            btnquitte.FlatAppearance.BorderSize = 0;
            btnquitte.FlatStyle = FlatStyle.Flat;
            btnquitte.Location = new Point(0, 0);
            btnquitte.Margin = new Padding(4, 3, 4, 3);
            btnquitte.Name = "btnquitte";
            btnquitte.Size = new Size(31, 27);
            btnquitte.TabIndex = 5;
            btnquitte.UseVisualStyleBackColor = true;
            // 
            // btnqut
            // 
            btnqut.FlatStyle = FlatStyle.Flat;
            btnqut.Image = Properties.Resources.Deconnecte;
            btnqut.Location = new Point(742, 12);
            btnqut.Name = "btnqut";
            btnqut.Size = new Size(75, 44);
            btnqut.TabIndex = 28;
            btnqut.UseVisualStyleBackColor = true;
            btnqut.Click += btnqut_Click;
            // 
            // Ajouter_Modifier_Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 28, 38);
            ClientSize = new Size(829, 486);
            Controls.Add(btnqut);
            Controls.Add(pictureBox7);
            Controls.Add(panel11);
            Controls.Add(txtPrenom);
            Controls.Add(btnEnrg);
            Controls.Add(btnActualise);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(panel10);
            Controls.Add(txtVille);
            Controls.Add(panel9);
            Controls.Add(txtNum);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(panel8);
            Controls.Add(txtEmail);
            Controls.Add(panel7);
            Controls.Add(txtPays);
            Controls.Add(pictureBox2);
            Controls.Add(panel6);
            Controls.Add(txtAd);
            Controls.Add(pictureBox1);
            Controls.Add(panel5);
            Controls.Add(txtNom);
            Controls.Add(btnquitte);
            Controls.Add(lbClient);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Ajouter_Modifier_Client";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ajouter_Modifier_Client";
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnquitte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtPays;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Button btnEnrg;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtPrenom;
        public System.Windows.Forms.Label lbClient;
        public System.Windows.Forms.Button btnActualise;
        private BindingSource clientBindingSource;
        private Button btnqut;
    }
}