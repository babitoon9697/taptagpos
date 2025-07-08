namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class TableBonCommande
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBonCommande = new System.Windows.Forms.DataGridView();
            this.colBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodeFournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnImprimerSansEP = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnConvertToInvoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBonCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBonCommande
            // 
            this.dgvBonCommande.AllowUserToAddRows = false;
            this.dgvBonCommande.AllowUserToDeleteRows = false;
            this.dgvBonCommande.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBonCommande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBonCommande.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBonCommande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBonCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBonCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBC,
            this.colDate,
            this.colCodeFournisseur,
            this.colFournisseur});
            this.dgvBonCommande.EnableHeadersVisualStyles = false;
            this.dgvBonCommande.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvBonCommande.Location = new System.Drawing.Point(9, 10);
            this.dgvBonCommande.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBonCommande.Name = "dgvBonCommande";
            this.dgvBonCommande.ReadOnly = true;
            this.dgvBonCommande.RowHeadersVisible = false;
            this.dgvBonCommande.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvBonCommande.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBonCommande.RowTemplate.Height = 24;
            this.dgvBonCommande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBonCommande.Size = new System.Drawing.Size(648, 461);
            this.dgvBonCommande.TabIndex = 0;
            // 
            // colBC
            // 
            this.colBC.HeaderText = "N° BC";
            this.colBC.MinimumWidth = 6;
            this.colBC.Name = "colBC";
            this.colBC.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colCodeFournisseur
            // 
            this.colCodeFournisseur.HeaderText = "Code Fournisseur";
            this.colCodeFournisseur.MinimumWidth = 6;
            this.colCodeFournisseur.Name = "colCodeFournisseur";
            this.colCodeFournisseur.ReadOnly = true;
            // 
            // colFournisseur
            // 
            this.colFournisseur.FillWeight = 150F;
            this.colFournisseur.HeaderText = "Fournisseur";
            this.colFournisseur.MinimumWidth = 6;
            this.colFournisseur.Name = "colFournisseur";
            this.colFournisseur.ReadOnly = true;
            // 
            // btnNouveau
            // 
            this.btnNouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(668, 29);
            this.btnNouveau.Margin = new System.Windows.Forms.Padding(2);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(98, 32);
            this.btnNouveau.TabIndex = 1;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNouveau.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(668, 67);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(98, 32);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(668, 104);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(98, 32);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnImprimer
            // 
            this.btnImprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.Location = new System.Drawing.Point(668, 141);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(98, 32);
            this.btnImprimer.TabIndex = 4;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimer.UseVisualStyleBackColor = true;
            // 
            // btnImprimerSansEP
            // 
            this.btnImprimerSansEP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimerSansEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerSansEP.Location = new System.Drawing.Point(668, 179);
            this.btnImprimerSansEP.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimerSansEP.Name = "btnImprimerSansEP";
            this.btnImprimerSansEP.Size = new System.Drawing.Size(98, 32);
            this.btnImprimerSansEP.TabIndex = 5;
            this.btnImprimerSansEP.Text = "Imprimer sans E.P";
            this.btnImprimerSansEP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimerSansEP.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(668, 216);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(98, 32);
            this.btnFermer.TabIndex = 6;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // btnConvertToInvoice
            // 
            this.btnConvertToInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvertToInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertToInvoice.Location = new System.Drawing.Point(668, 415);
            this.btnConvertToInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.btnConvertToInvoice.Name = "btnConvertToInvoice";
            this.btnConvertToInvoice.Size = new System.Drawing.Size(98, 54);
            this.btnConvertToInvoice.TabIndex = 7;
            this.btnConvertToInvoice.Text = "Convertir en Facture";
            this.btnConvertToInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConvertToInvoice.UseVisualStyleBackColor = true;
            // 
            // TableBonCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 480);
            this.Controls.Add(this.btnConvertToInvoice);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnImprimerSansEP);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.dgvBonCommande);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(604, 373);
            this.Name = "TableBonCommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table BonCommande";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBonCommande)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBonCommande;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnImprimerSansEP;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodeFournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFournisseur;
        private System.Windows.Forms.Button btnConvertToInvoice;
    }
}