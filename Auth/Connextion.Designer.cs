namespace C_Stocke.Auth
{
    partial class Connextion
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
            label1 = new Label();
            txtNom = new TextBox();
            panel5 = new Panel();
            panel6 = new Panel();
            txtmotpass = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnquitte = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(178, 8, 55);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 2);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(178, 8, 55);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(370, 2);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(2, 341);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(178, 8, 55);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 341);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(370, 2);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(178, 8, 55);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 2);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(2, 339);
            panel4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MistyRose;
            label1.Location = new Point(96, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 37);
            label1.TabIndex = 5;
            label1.Text = "Connexion";
            // 
            // txtNom
            // 
            txtNom.BackColor = Color.FromArgb(30, 28, 38);
            txtNom.BorderStyle = BorderStyle.None;
            txtNom.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNom.ForeColor = Color.Silver;
            txtNom.Location = new Point(56, 111);
            txtNom.Margin = new Padding(4, 3, 4, 3);
            txtNom.Multiline = true;
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(272, 23);
            txtNom.TabIndex = 6;
            txtNom.Text = "Nom d'utilisateur";
            txtNom.Enter += txtNom_Enter;
            txtNom.Leave += txtNom_Leave;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(56, 141);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(292, 1);
            panel5.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(56, 226);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(290, 1);
            panel6.TabIndex = 9;
            // 
            // txtmotpass
            // 
            txtmotpass.BackColor = Color.FromArgb(30, 28, 38);
            txtmotpass.BorderStyle = BorderStyle.None;
            txtmotpass.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtmotpass.ForeColor = Color.Silver;
            txtmotpass.Location = new Point(56, 194);
            txtmotpass.Margin = new Padding(4, 3, 4, 3);
            txtmotpass.Name = "txtmotpass";
            txtmotpass.Size = new Size(272, 22);
            txtmotpass.TabIndex = 8;
            txtmotpass.Text = "Mot de Passe";
            txtmotpass.Enter += txtpasse_Enter;
            txtmotpass.Leave += txtmotdepasse_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(9, 194);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 32);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources._new;
            pictureBox1.Image = Properties.Resources.user__2_;
            pictureBox1.Location = new Point(9, 111);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 32);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnquitte
            // 
            btnquitte.FlatAppearance.BorderSize = 0;
            btnquitte.FlatStyle = FlatStyle.Flat;
            btnquitte.Image = Properties.Resources.Deconnecte;
            btnquitte.Location = new Point(327, 9);
            btnquitte.Margin = new Padding(4, 3, 4, 3);
            btnquitte.Name = "btnquitte";
            btnquitte.Size = new Size(31, 27);
            btnquitte.TabIndex = 4;
            btnquitte.UseVisualStyleBackColor = true;
            btnquitte.Click += btnquitte_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(178, 8, 55);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(14, 277);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(334, 38);
            button1.TabIndex = 12;
            button1.Text = "Se Connecter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Connextion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 28, 38);
            ClientSize = new Size(372, 343);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel6);
            Controls.Add(txtmotpass);
            Controls.Add(panel5);
            Controls.Add(txtNom);
            Controls.Add(label1);
            Controls.Add(btnquitte);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Connextion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Connextion";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtmotpass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}