namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class FicheTechnique
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.numCoutRevient = new System.Windows.Forms.NumericUpDown();
            this.labelCoutRevient = new System.Windows.Forms.Label();
            this.btnNouveauArticle = new System.Windows.Forms.Button();
            this.cmbArticle = new System.Windows.Forms.ComboBox();
            this.labelArticle = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnEnlever = new System.Windows.Forms.Button();
            this.dgvComposants = new System.Windows.Forms.DataGridView();
            this.colCompReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompPrixAchat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompQte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblSumValue = new System.Windows.Forms.Label();
            this.labelSomme = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCoutRevient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComposants)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.numCoutRevient);
            this.panelHeader.Controls.Add(this.labelCoutRevient);
            this.panelHeader.Controls.Add(this.btnNouveauArticle);
            this.panelHeader.Controls.Add(this.cmbArticle);
            this.panelHeader.Controls.Add(this.labelArticle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(726, 49);
            this.panelHeader.TabIndex = 0;
            // 
            // numCoutRevient
            // 
            this.numCoutRevient.DecimalPlaces = 2;
            this.numCoutRevient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCoutRevient.Location = new System.Drawing.Point(556, 15);
            this.numCoutRevient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numCoutRevient.Name = "numCoutRevient";
            this.numCoutRevient.ReadOnly = true;
            this.numCoutRevient.Size = new System.Drawing.Size(90, 21);
            this.numCoutRevient.TabIndex = 4;
            // 
            // labelCoutRevient
            // 
            this.labelCoutRevient.AutoSize = true;
            this.labelCoutRevient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoutRevient.Location = new System.Drawing.Point(467, 17);
            this.labelCoutRevient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCoutRevient.Name = "labelCoutRevient";
            this.labelCoutRevient.Size = new System.Drawing.Size(88, 15);
            this.labelCoutRevient.TabIndex = 3;
            this.labelCoutRevient.Text = "Coût de revient";
            // 
            // btnNouveauArticle
            // 
            this.btnNouveauArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveauArticle.Location = new System.Drawing.Point(356, 11);
            this.btnNouveauArticle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNouveauArticle.Name = "btnNouveauArticle";
            this.btnNouveauArticle.Size = new System.Drawing.Size(98, 26);
            this.btnNouveauArticle.TabIndex = 2;
            this.btnNouveauArticle.Text = "Nouveau Article";
            this.btnNouveauArticle.UseVisualStyleBackColor = true;
            // 
            // cmbArticle
            // 
            this.cmbArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArticle.FormattingEnabled = true;
            this.cmbArticle.Location = new System.Drawing.Point(59, 14);
            this.cmbArticle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbArticle.Name = "cmbArticle";
            this.cmbArticle.Size = new System.Drawing.Size(286, 23);
            this.cmbArticle.TabIndex = 1;
            // 
            // labelArticle
            // 
            this.labelArticle.AutoSize = true;
            this.labelArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArticle.Location = new System.Drawing.Point(17, 17);
            this.labelArticle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelArticle.Name = "labelArticle";
            this.labelArticle.Size = new System.Drawing.Size(40, 15);
            this.labelArticle.TabIndex = 0;
            this.labelArticle.Text = "Article";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(619, 65);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(98, 32);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(619, 102);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(98, 32);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(619, 140);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(98, 32);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnEnlever
            // 
            this.btnEnlever.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnlever.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnlever.Location = new System.Drawing.Point(619, 177);
            this.btnEnlever.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnlever.Name = "btnEnlever";
            this.btnEnlever.Size = new System.Drawing.Size(98, 32);
            this.btnEnlever.TabIndex = 4;
            this.btnEnlever.Text = "Enlever";
            this.btnEnlever.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnlever.UseVisualStyleBackColor = true;
            // 
            // dgvComposants
            // 
            this.dgvComposants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComposants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComposants.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComposants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComposants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComposants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCompReference,
            this.colCompDesignation,
            this.colCompPrixAchat,
            this.colCompQte});
            this.dgvComposants.EnableHeadersVisualStyles = false;
            this.dgvComposants.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvComposants.Location = new System.Drawing.Point(9, 54);
            this.dgvComposants.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvComposants.Name = "dgvComposants";
            this.dgvComposants.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvComposants.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComposants.RowTemplate.Height = 24;
            this.dgvComposants.Size = new System.Drawing.Size(596, 382);
            this.dgvComposants.TabIndex = 5;
            // 
            // colCompReference
            // 
            this.colCompReference.HeaderText = "Référence";
            this.colCompReference.MinimumWidth = 6;
            this.colCompReference.Name = "colCompReference";
            // 
            // colCompDesignation
            // 
            this.colCompDesignation.FillWeight = 200F;
            this.colCompDesignation.HeaderText = "Désignation";
            this.colCompDesignation.MinimumWidth = 6;
            this.colCompDesignation.Name = "colCompDesignation";
            // 
            // colCompPrixAchat
            // 
            this.colCompPrixAchat.HeaderText = "Prix d\'achat";
            this.colCompPrixAchat.MinimumWidth = 6;
            this.colCompPrixAchat.Name = "colCompPrixAchat";
            // 
            // colCompQte
            // 
            this.colCompQte.FillWeight = 60F;
            this.colCompQte.HeaderText = "Qte";
            this.colCompQte.MinimumWidth = 6;
            this.colCompQte.Name = "colCompQte";
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.lblSumValue);
            this.panelFooter.Controls.Add(this.labelSomme);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 443);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(726, 35);
            this.panelFooter.TabIndex = 6;
            // 
            // lblSumValue
            // 
            this.lblSumValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSumValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSumValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumValue.Location = new System.Drawing.Point(68, 7);
            this.lblSumValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSumValue.Name = "lblSumValue";
            this.lblSumValue.Size = new System.Drawing.Size(112, 20);
            this.lblSumValue.TabIndex = 1;
            this.lblSumValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSomme
            // 
            this.labelSomme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSomme.AutoSize = true;
            this.labelSomme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSomme.Location = new System.Drawing.Point(9, 10);
            this.labelSomme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSomme.Name = "labelSomme";
            this.labelSomme.Size = new System.Drawing.Size(56, 15);
            this.labelSomme.TabIndex = 0;
            this.labelSomme.Text = "Somme";
            // 
            // FicheTechnique
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(726, 478);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.dgvComposants);
            this.Controls.Add(this.btnEnlever);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(642, 414);
            this.Name = "FicheTechnique";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fiche Technique";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCoutRevient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComposants)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelArticle;
        private System.Windows.Forms.ComboBox cmbArticle;
        private System.Windows.Forms.Button btnNouveauArticle;
        private System.Windows.Forms.Label labelCoutRevient;
        private System.Windows.Forms.NumericUpDown numCoutRevient;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnEnlever;
        private System.Windows.Forms.DataGridView dgvComposants;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelSomme;
        private System.Windows.Forms.Label lblSumValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompPrixAchat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompQte;
    }
}