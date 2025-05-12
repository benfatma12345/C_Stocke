namespace C_Stocke.Commandes
{
    partial class Client_Commande
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataClinet = new DataGridView();
            iDClientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomClientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            prenomClientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresseClientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telephoneClientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paysClientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            villeClientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailClientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataClinet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            SuspendLayout();
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
            dataClinet.Columns.AddRange(new DataGridViewColumn[] { iDClientDataGridViewTextBoxColumn, nomClientDataGridViewTextBoxColumn, prenomClientDataGridViewTextBoxColumn, adresseClientDataGridViewTextBoxColumn, telephoneClientDataGridViewTextBoxColumn, paysClientDataGridViewTextBoxColumn, villeClientDataGridViewTextBoxColumn, emailClientDataGridViewTextBoxColumn });
            dataClinet.DataSource = clientBindingSource;
            dataClinet.Dock = DockStyle.Fill;
            dataClinet.EnableHeadersVisualStyles = false;
            dataClinet.Location = new Point(0, 0);
            dataClinet.Margin = new Padding(4, 3, 4, 3);
            dataClinet.Name = "dataClinet";
            dataClinet.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataClinet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataClinet.Size = new Size(803, 406);
            dataClinet.TabIndex = 7;
            dataClinet.CellContentDoubleClick += dataClinet_CellContentDoubleClick;
            // 
            // iDClientDataGridViewTextBoxColumn
            // 
            iDClientDataGridViewTextBoxColumn.DataPropertyName = "ID_Client";
            iDClientDataGridViewTextBoxColumn.HeaderText = "ID_Client";
            iDClientDataGridViewTextBoxColumn.Name = "iDClientDataGridViewTextBoxColumn";
            // 
            // nomClientDataGridViewTextBoxColumn
            // 
            nomClientDataGridViewTextBoxColumn.DataPropertyName = "Nom_Client";
            nomClientDataGridViewTextBoxColumn.HeaderText = "Nom_Client";
            nomClientDataGridViewTextBoxColumn.Name = "nomClientDataGridViewTextBoxColumn";
            // 
            // prenomClientDataGridViewTextBoxColumn
            // 
            prenomClientDataGridViewTextBoxColumn.DataPropertyName = "Prenom_Client";
            prenomClientDataGridViewTextBoxColumn.HeaderText = "Prenom_Client";
            prenomClientDataGridViewTextBoxColumn.Name = "prenomClientDataGridViewTextBoxColumn";
            // 
            // adresseClientDataGridViewTextBoxColumn
            // 
            adresseClientDataGridViewTextBoxColumn.DataPropertyName = "Adresse_Client";
            adresseClientDataGridViewTextBoxColumn.HeaderText = "Adresse_Client";
            adresseClientDataGridViewTextBoxColumn.Name = "adresseClientDataGridViewTextBoxColumn";
            // 
            // telephoneClientDataGridViewTextBoxColumn
            // 
            telephoneClientDataGridViewTextBoxColumn.DataPropertyName = "Telephone_Client";
            telephoneClientDataGridViewTextBoxColumn.HeaderText = "Telephone_Client";
            telephoneClientDataGridViewTextBoxColumn.Name = "telephoneClientDataGridViewTextBoxColumn";
            // 
            // paysClientDataGridViewTextBoxColumn
            // 
            paysClientDataGridViewTextBoxColumn.DataPropertyName = "Pays_Client";
            paysClientDataGridViewTextBoxColumn.HeaderText = "Pays_Client";
            paysClientDataGridViewTextBoxColumn.Name = "paysClientDataGridViewTextBoxColumn";
            // 
            // villeClientDataGridViewTextBoxColumn
            // 
            villeClientDataGridViewTextBoxColumn.DataPropertyName = "Ville_Client";
            villeClientDataGridViewTextBoxColumn.HeaderText = "Ville_Client";
            villeClientDataGridViewTextBoxColumn.Name = "villeClientDataGridViewTextBoxColumn";
            // 
            // emailClientDataGridViewTextBoxColumn
            // 
            emailClientDataGridViewTextBoxColumn.DataPropertyName = "Email_Client";
            emailClientDataGridViewTextBoxColumn.HeaderText = "Email_Client";
            emailClientDataGridViewTextBoxColumn.Name = "emailClientDataGridViewTextBoxColumn";
            // 
            // clientBindingSource
            // 
            clientBindingSource.DataSource = typeof(Entities.Client);
            // 
            // Client_Commande
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 406);
            Controls.Add(dataClinet);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Client_Commande";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Client_Commande_Load;
            ((System.ComponentModel.ISupportInitialize)dataClinet).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource clientBindingSource;
        private DataGridViewTextBoxColumn iDClientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomClientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prenomClientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresseClientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telephoneClientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paysClientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn villeClientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailClientDataGridViewTextBoxColumn;
        public DataGridView dataClinet;
    }
}