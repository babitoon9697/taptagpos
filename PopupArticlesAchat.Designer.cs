namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class PopupArticlesAchat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.colRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPAchat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQteStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQteAlerte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNouveauArticle = new System.Windows.Forms.Button();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.numQte = new System.Windows.Forms.NumericUpDown();
            this.labelQte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQte)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(9, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(555, 21);
            this.txtSearch.TabIndex = 0;
            // 
            // dgvArticles
            // 
            this.dgvArticles.AllowUserToAddRows = false;
            this.dgvArticles.AllowUserToDeleteRows = false;
            this.dgvArticles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticles.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRef,
            this.colDesignation,
            this.colPAchat,
            this.colQteStock,
            this.colQteAlerte});
            this.dgvArticles.EnableHeadersVisualStyles = false;
            this.dgvArticles.Location = new System.Drawing.Point(9, 34);
            this.dgvArticles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvArticles.Name = "dgvArticles";
            this.dgvArticles.ReadOnly = true;
            this.dgvArticles.RowHeadersVisible = false;
            this.dgvArticles.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvArticles.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvArticles.RowTemplate.Height = 24;
            this.dgvArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticles.Size = new System.Drawing.Size(643, 357);
            this.dgvArticles.TabIndex = 1;
            // 
            // colRef
            // 
            this.colRef.HeaderText = "Référence";
            this.colRef.MinimumWidth = 6;
            this.colRef.Name = "colRef";
            this.colRef.ReadOnly = true;
            // 
            // colDesignation
            // 
            this.colDesignation.FillWeight = 150F;
            this.colDesignation.HeaderText = "Désignation";
            this.colDesignation.MinimumWidth = 6;
            this.colDesignation.Name = "colDesignation";
            this.colDesignation.ReadOnly = true;
            // 
            // colPAchat
            // 
            this.colPAchat.HeaderText = "P.Achat";
            this.colPAchat.MinimumWidth = 6;
            this.colPAchat.Name = "colPAchat";
            this.colPAchat.ReadOnly = true;
            // 
            // colQteStock
            // 
            this.colQteStock.HeaderText = "Qte Stock";
            this.colQteStock.MinimumWidth = 6;
            this.colQteStock.Name = "colQteStock";
            this.colQteStock.ReadOnly = true;
            // 
            // colQteAlerte
            // 
            this.colQteAlerte.HeaderText = "Qte alerte";
            this.colQteAlerte.MinimumWidth = 6;
            this.colQteAlerte.Name = "colQteAlerte";
            this.colQteAlerte.ReadOnly = true;
            // 
            // btnNouveauArticle
            // 
            this.btnNouveauArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNouveauArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveauArticle.Location = new System.Drawing.Point(567, 6);
            this.btnNouveauArticle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNouveauArticle.Name = "btnNouveauArticle";
            this.btnNouveauArticle.Size = new System.Drawing.Size(86, 26);
            this.btnNouveauArticle.TabIndex = 2;
            this.btnNouveauArticle.Text = "Nouveau Article";
            this.btnNouveauArticle.UseVisualStyleBackColor = true;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.btnAjouter);
            this.panelFooter.Controls.Add(this.numQte);
            this.panelFooter.Controls.Add(this.labelQte);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 396);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(661, 45);
            this.panelFooter.TabIndex = 3;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(555, 6);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(98, 32);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "F1 Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // numQte
            // 
            this.numQte.DecimalPlaces = 3;
            this.numQte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQte.Location = new System.Drawing.Point(447, 12);
            this.numQte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numQte.Name = "numQte";
            this.numQte.Size = new System.Drawing.Size(90, 21);
            this.numQte.TabIndex = 1;
            // 
            // labelQte
            // 
            this.labelQte.AutoSize = true;
            this.labelQte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQte.Location = new System.Drawing.Point(321, 14);
            this.labelQte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQte.Name = "labelQte";
            this.labelQte.Size = new System.Drawing.Size(114, 15);
            this.labelQte.TabIndex = 0;
            this.labelQte.Text = "Qte Commandée";
            // 
            // PopupArticlesAchat
            // 
            this.AcceptButton = this.btnAjouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 441);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.btnNouveauArticle);
            this.Controls.Add(this.dgvArticles);
            this.Controls.Add(this.txtSearch);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(492, 332);
            this.Name = "PopupArticlesAchat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Table ARTICLES";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvArticles;
        private System.Windows.Forms.Button btnNouveauArticle;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelQte;
        private System.Windows.Forms.NumericUpDown numQte;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPAchat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQteStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQteAlerte;
    }
}