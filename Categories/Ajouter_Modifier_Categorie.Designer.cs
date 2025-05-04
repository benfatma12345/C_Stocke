namespace C_Stocke.Categories
{
    partial class Ajouter_Modifier_Categorie
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
            txtCategorie = new TextBox();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            btnquitte = new Button();
            BtnAjouteCat = new Button();
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
            panel2.Size = new Size(2, 245);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(178, 8, 55);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 245);
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
            panel4.Size = new Size(2, 243);
            panel4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MistyRose;
            label1.Location = new Point(45, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(283, 37);
            label1.TabIndex = 5;
            label1.Text = "Ajouter Categorie";
            // 
            // txtCategorie
            // 
            txtCategorie.BackColor = Color.FromArgb(30, 28, 38);
            txtCategorie.BorderStyle = BorderStyle.None;
            txtCategorie.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategorie.ForeColor = Color.Silver;
            txtCategorie.Location = new Point(56, 111);
            txtCategorie.Margin = new Padding(4, 3, 4, 3);
            txtCategorie.Multiline = true;
            txtCategorie.Name = "txtCategorie";
            txtCategorie.Size = new Size(272, 23);
            txtCategorie.TabIndex = 6;
            txtCategorie.Text = "Nom Categorie";
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
            // 
            // BtnAjouteCat
            // 
            BtnAjouteCat.BackColor = Color.FromArgb(178, 8, 55);
            BtnAjouteCat.FlatAppearance.BorderSize = 0;
            BtnAjouteCat.FlatStyle = FlatStyle.Flat;
            BtnAjouteCat.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAjouteCat.ForeColor = SystemColors.ControlLightLight;
            BtnAjouteCat.Location = new Point(24, 184);
            BtnAjouteCat.Margin = new Padding(4, 3, 4, 3);
            BtnAjouteCat.Name = "BtnAjouteCat";
            BtnAjouteCat.Size = new Size(334, 38);
            BtnAjouteCat.TabIndex = 12;
            BtnAjouteCat.Text = "Ajouter";
            BtnAjouteCat.UseVisualStyleBackColor = false;
            // 
            // Ajouter_Modifier_Categorie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 28, 38);
            ClientSize = new Size(372, 247);
            Controls.Add(BtnAjouteCat);
            Controls.Add(pictureBox1);
            Controls.Add(panel5);
            Controls.Add(txtCategorie);
            Controls.Add(label1);
            Controls.Add(btnquitte);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Ajouter_Modifier_Categorie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connextion";
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
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnAjouteCat;
    }
}