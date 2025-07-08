namespace TAPTAGPOS
{
    partial class FormStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.labelAlerte = new System.Windows.Forms.Label();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.labelRupture = new System.Windows.Forms.Label();
            this.panelRed = new System.Windows.Forms.Panel();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.cmbDepot = new System.Windows.Forms.ComboBox();
            this.labelDepot = new System.Windows.Forms.Label();
            this.cmbFamille = new System.Windows.Forms.ComboBox();
            this.labelFamille = new System.Windows.Forms.Label();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.labelDesignation = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.colReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrixAchat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.txtStockValue = new System.Windows.Forms.TextBox();
            this.labelStockValue = new System.Windows.Forms.Label();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.labelAlerte);
            this.panelFilters.Controls.Add(this.panelGreen);
            this.panelFilters.Controls.Add(this.labelRupture);
            this.panelFilters.Controls.Add(this.panelRed);
            this.panelFilters.Controls.Add(this.btnImprimer);
            this.panelFilters.Controls.Add(this.cmbDepot);
            this.panelFilters.Controls.Add(this.labelDepot);
            this.panelFilters.Controls.Add(this.cmbFamille);
            this.panelFilters.Controls.Add(this.labelFamille);
            this.panelFilters.Controls.Add(this.cmbDesignation);
            this.panelFilters.Controls.Add(this.labelDesignation);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(738, 81);
            this.panelFilters.TabIndex = 0;
            // 
            // labelAlerte
            // 
            this.labelAlerte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAlerte.AutoSize = true;
            this.labelAlerte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelAlerte.Location = new System.Drawing.Point(578, 20);
            this.labelAlerte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlerte.Name = "labelAlerte";
            this.labelAlerte.Size = new System.Drawing.Size(88, 15);
            this.labelAlerte.TabIndex = 10;
            this.labelAlerte.Text = "Stock en Alerte";
            // 
            // panelGreen
            // 
            this.panelGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGreen.BackColor = System.Drawing.Color.LimeGreen;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(689, 20);
            this.panelGreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(19, 21);
            this.panelGreen.TabIndex = 9;
            // 
            // labelRupture
            // 
            this.labelRupture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRupture.AutoSize = true;
            this.labelRupture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelRupture.Location = new System.Drawing.Point(578, 47);
            this.labelRupture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRupture.Name = "labelRupture";
            this.labelRupture.Size = new System.Drawing.Size(101, 15);
            this.labelRupture.TabIndex = 12;
            this.labelRupture.Text = "Rupture de Stock";
            // 
            // panelRed
            // 
            this.panelRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(689, 46);
            this.panelRed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(19, 21);
            this.panelRed.TabIndex = 11;
            // 
            // btnImprimer
            // 
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnImprimer.Location = new System.Drawing.Point(446, 31);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(90, 28);
            this.btnImprimer.TabIndex = 6;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            // 
            // cmbDepot
            // 
            this.cmbDepot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbDepot.FormattingEnabled = true;
            this.cmbDepot.Location = new System.Drawing.Point(90, 53);
            this.cmbDepot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDepot.Name = "cmbDepot";
            this.cmbDepot.Size = new System.Drawing.Size(338, 23);
            this.cmbDepot.TabIndex = 5;
            // 
            // labelDepot
            // 
            this.labelDepot.AutoSize = true;
            this.labelDepot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelDepot.Location = new System.Drawing.Point(17, 55);
            this.labelDepot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDepot.Name = "labelDepot";
            this.labelDepot.Size = new System.Drawing.Size(40, 15);
            this.labelDepot.TabIndex = 4;
            this.labelDepot.Text = "Dépôt";
            // 
            // cmbFamille
            // 
            this.cmbFamille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFamille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbFamille.FormattingEnabled = true;
            this.cmbFamille.Location = new System.Drawing.Point(90, 31);
            this.cmbFamille.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFamille.Name = "cmbFamille";
            this.cmbFamille.Size = new System.Drawing.Size(338, 23);
            this.cmbFamille.TabIndex = 3;
            // 
            // labelFamille
            // 
            this.labelFamille.AutoSize = true;
            this.labelFamille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelFamille.Location = new System.Drawing.Point(17, 33);
            this.labelFamille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFamille.Name = "labelFamille";
            this.labelFamille.Size = new System.Drawing.Size(48, 15);
            this.labelFamille.TabIndex = 2;
            this.labelFamille.Text = "Famille";
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Location = new System.Drawing.Point(90, 8);
            this.cmbDesignation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(338, 23);
            this.cmbDesignation.TabIndex = 1;
            // 
            // labelDesignation
            // 
            this.labelDesignation.AutoSize = true;
            this.labelDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelDesignation.Location = new System.Drawing.Point(17, 11);
            this.labelDesignation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDesignation.Name = "labelDesignation";
            this.labelDesignation.Size = new System.Drawing.Size(73, 15);
            this.labelDesignation.TabIndex = 0;
            this.labelDesignation.Text = "Désignation";
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReference,
            this.colDesignation,
            this.colStock,
            this.colPrixAchat,
            this.colValeur});
            this.dgvStock.EnableHeadersVisualStyles = false;
            this.dgvStock.Location = new System.Drawing.Point(9, 86);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dgvStock.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(718, 323);
            this.dgvStock.TabIndex = 1;
            // 
            // colReference
            // 
            this.colReference.HeaderText = "Référence";
            this.colReference.MinimumWidth = 6;
            this.colReference.Name = "colReference";
            this.colReference.ReadOnly = true;
            // 
            // colDesignation
            // 
            this.colDesignation.FillWeight = 200F;
            this.colDesignation.HeaderText = "Désignation";
            this.colDesignation.MinimumWidth = 6;
            this.colDesignation.Name = "colDesignation";
            this.colDesignation.ReadOnly = true;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.MinimumWidth = 6;
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // colPrixAchat
            // 
            this.colPrixAchat.HeaderText = "Prix d\'achat";
            this.colPrixAchat.MinimumWidth = 6;
            this.colPrixAchat.Name = "colPrixAchat";
            this.colPrixAchat.ReadOnly = true;
            // 
            // colValeur
            // 
            this.colValeur.HeaderText = "Valeur";
            this.colValeur.MinimumWidth = 6;
            this.colValeur.Name = "colValeur";
            this.colValeur.ReadOnly = true;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.txtStockValue);
            this.panelFooter.Controls.Add(this.labelStockValue);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 421);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(738, 35);
            this.panelFooter.TabIndex = 2;
            // 
            // txtStockValue
            // 
            this.txtStockValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockValue.Location = new System.Drawing.Point(602, 8);
            this.txtStockValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStockValue.Name = "txtStockValue";
            this.txtStockValue.ReadOnly = true;
            this.txtStockValue.Size = new System.Drawing.Size(128, 20);
            this.txtStockValue.TabIndex = 1;
            // 
            // labelStockValue
            // 
            this.labelStockValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStockValue.AutoSize = true;
            this.labelStockValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelStockValue.Location = new System.Drawing.Point(17, 10);
            this.labelStockValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStockValue.Name = "labelStockValue";
            this.labelStockValue.Size = new System.Drawing.Size(107, 15);
            this.labelStockValue.TabIndex = 0;
            this.labelStockValue.Text = "Valeur de Stock";
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 456);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.panelFilters);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(754, 495);
            this.Name = "FormStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelDesignation;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.Label labelFamille;
        private System.Windows.Forms.ComboBox cmbFamille;
        private System.Windows.Forms.Label labelDepot;
        private System.Windows.Forms.ComboBox cmbDepot;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Label labelAlerte;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label labelRupture;
        private System.Windows.Forms.Label labelStockValue;
        private System.Windows.Forms.TextBox txtStockValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrixAchat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValeur;
    }
}