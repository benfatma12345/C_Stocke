namespace C_Stocke.Categories
{
    partial class UserCategori
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataCategorie = new DataGridView();
            Column1 = new DataGridViewCheckBoxColumn();
            iDCATEGORIEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomCategorieDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            produitsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewButtonColumn();
            Column5 = new DataGridViewButtonColumn();
            categorieBindingSource = new BindingSource(components);
            panel3 = new Panel();
            txtRechercher = new TextBox();
            btnAjouter = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataCategorie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categorieBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataCategorie
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 28, 38);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataCategorie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataCategorie.AutoGenerateColumns = false;
            dataCategorie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataCategorie.BackgroundColor = SystemColors.ControlLight;
            dataCategorie.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 28, 38);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataCategorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataCategorie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataCategorie.Columns.AddRange(new DataGridViewColumn[] { Column1, iDCATEGORIEDataGridViewTextBoxColumn, nomCategorieDataGridViewTextBoxColumn, produitsDataGridViewTextBoxColumn, Column4, Column5 });
            dataCategorie.DataSource = categorieBindingSource;
            dataCategorie.EnableHeadersVisualStyles = false;
            dataCategorie.Location = new Point(47, 164);
            dataCategorie.Margin = new Padding(4, 3, 4, 3);
            dataCategorie.Name = "dataCategorie";
            dataCategorie.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataCategorie.Size = new Size(993, 261);
            dataCategorie.TabIndex = 16;
            // 
            // Column1
            // 
            Column1.HeaderText = "Select";
            Column1.Name = "Column1";
            // 
            // iDCATEGORIEDataGridViewTextBoxColumn
            // 
            iDCATEGORIEDataGridViewTextBoxColumn.DataPropertyName = "ID_CATEGORIE";
            iDCATEGORIEDataGridViewTextBoxColumn.HeaderText = "ID_CATEGORIE";
            iDCATEGORIEDataGridViewTextBoxColumn.Name = "iDCATEGORIEDataGridViewTextBoxColumn";
            // 
            // nomCategorieDataGridViewTextBoxColumn
            // 
            nomCategorieDataGridViewTextBoxColumn.DataPropertyName = "Nom_Categorie";
            nomCategorieDataGridViewTextBoxColumn.HeaderText = "Nom_Categorie";
            nomCategorieDataGridViewTextBoxColumn.Name = "nomCategorieDataGridViewTextBoxColumn";
            // 
            // produitsDataGridViewTextBoxColumn
            // 
            produitsDataGridViewTextBoxColumn.DataPropertyName = "Produits";
            produitsDataGridViewTextBoxColumn.HeaderText = "Produits";
            produitsDataGridViewTextBoxColumn.Name = "produitsDataGridViewTextBoxColumn";
            // 
            // Column4
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(255, 224, 192);
            Column4.DefaultCellStyle = dataGridViewCellStyle3;
            Column4.FlatStyle = FlatStyle.Popup;
            Column4.HeaderText = "Modifier";
            Column4.Name = "Column4";
            Column4.Resizable = DataGridViewTriState.True;
            Column4.SortMode = DataGridViewColumnSortMode.Automatic;
            Column4.Text = "Modifier";
            Column4.ToolTipText = "Modifier";
            Column4.UseColumnTextForButtonValue = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(255, 224, 192);
            Column5.DefaultCellStyle = dataGridViewCellStyle4;
            Column5.FlatStyle = FlatStyle.Popup;
            Column5.HeaderText = "Supprimer";
            Column5.Name = "Column5";
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.Automatic;
            Column5.Text = "Supprimer";
            Column5.UseColumnTextForButtonValue = true;
            // 
            // categorieBindingSource
            // 
            categorieBindingSource.DataSource = typeof(Entities.Categorie);
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 28, 38);
            panel3.Location = new Point(654, 70);
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
            txtRechercher.Location = new Point(654, 20);
            txtRechercher.Margin = new Padding(4, 3, 4, 3);
            txtRechercher.Multiline = true;
            txtRechercher.Name = "txtRechercher";
            txtRechercher.Size = new Size(349, 54);
            txtRechercher.TabIndex = 14;
            txtRechercher.Text = "Rechercher";
            txtRechercher.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.FromArgb(30, 28, 38);
            btnAjouter.FlatStyle = FlatStyle.Flat;
            btnAjouter.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjouter.ForeColor = SystemColors.ControlLightLight;
            btnAjouter.Image = Properties.Resources.Actions_list_add_icon;
            btnAjouter.ImageAlign = ContentAlignment.MiddleLeft;
            btnAjouter.Location = new Point(56, 20);
            btnAjouter.Margin = new Padding(4, 3, 4, 3);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(293, 54);
            btnAjouter.TabIndex = 8;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(30, 28, 38);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Image = Properties.Resources.Excel_icon;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(92, 505);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(293, 85);
            button1.TabIndex = 17;
            button1.Text = "Exel";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(30, 28, 38);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Image = Properties.Resources.Imprimer;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(783, 505);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(293, 85);
            button2.TabIndex = 18;
            button2.Text = "imprime";
            button2.UseVisualStyleBackColor = false;
            // 
            // UserCategori
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataCategorie);
            Controls.Add(panel3);
            Controls.Add(txtRechercher);
            Controls.Add(btnAjouter);
            Name = "UserCategori";
            Size = new Size(1159, 831);
            ((System.ComponentModel.ISupportInitialize)dataCategorie).EndInit();
            ((System.ComponentModel.ISupportInitialize)categorieBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataCategorie;
        private Panel panel3;
        private TextBox txtRechercher;
        private Button btnAjouter;
        private Button button1;
        private Button button2;
        private BindingSource categorieBindingSource;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewTextBoxColumn iDCATEGORIEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomCategorieDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn produitsDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Column4;
        private DataGridViewButtonColumn Column5;
    }
}
