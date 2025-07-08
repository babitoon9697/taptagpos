namespace TAPTAGPOS
{
    partial class FormMouvementStock
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
            this.panelFilters = new System.Windows.Forms.Panel();
            this.labelRupture = new System.Windows.Forms.Label();
            this.panelRed = new System.Windows.Forms.Panel();
            this.labelAlerte = new System.Windows.Forms.Label();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.cmbFamille = new System.Windows.Forms.ComboBox();
            this.labelFamille = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.colReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSortie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.labelRupture);
            this.panelFilters.Controls.Add(this.panelRed);
            this.panelFilters.Controls.Add(this.labelAlerte);
            this.panelFilters.Controls.Add(this.panelGreen);
            this.panelFilters.Controls.Add(this.btnAfficher);
            this.panelFilters.Controls.Add(this.cmbFamille);
            this.panelFilters.Controls.Add(this.labelFamille);
            this.panelFilters.Controls.Add(this.dtpDate);
            this.panelFilters.Controls.Add(this.labelDate);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Margin = new System.Windows.Forms.Padding(2);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(738, 65);
            this.panelFilters.TabIndex = 0;
            // 
            // labelRupture
            // 
            this.labelRupture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRupture.AutoSize = true;
            this.labelRupture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelRupture.Location = new System.Drawing.Point(578, 39);
            this.labelRupture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRupture.Name = "labelRupture";
            this.labelRupture.Size = new System.Drawing.Size(101, 15);
            this.labelRupture.TabIndex = 8;
            this.labelRupture.Text = "Rupture de Stock";
            // 
            // panelRed
            // 
            this.panelRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(696, 38);
            this.panelRed.Margin = new System.Windows.Forms.Padding(2);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(19, 21);
            this.panelRed.TabIndex = 7;
            // 
            // labelAlerte
            // 
            this.labelAlerte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAlerte.AutoSize = true;
            this.labelAlerte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelAlerte.Location = new System.Drawing.Point(578, 12);
            this.labelAlerte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlerte.Name = "labelAlerte";
            this.labelAlerte.Size = new System.Drawing.Size(88, 15);
            this.labelAlerte.TabIndex = 6;
            this.labelAlerte.Text = "Stock en Alerte";
            // 
            // panelGreen
            // 
            this.panelGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGreen.BackColor = System.Drawing.Color.LimeGreen;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(696, 11);
            this.panelGreen.Margin = new System.Windows.Forms.Padding(2);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(19, 21);
            this.panelGreen.TabIndex = 5;
            // 
            // btnAfficher
            // 
            this.btnAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnAfficher.Location = new System.Drawing.Point(405, 23);
            this.btnAfficher.Margin = new System.Windows.Forms.Padding(2);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(90, 28);
            this.btnAfficher.TabIndex = 4;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            // 
            // cmbFamille
            // 
            this.cmbFamille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFamille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbFamille.FormattingEnabled = true;
            this.cmbFamille.Location = new System.Drawing.Point(243, 26);
            this.cmbFamille.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFamille.Name = "cmbFamille";
            this.cmbFamille.Size = new System.Drawing.Size(151, 23);
            this.cmbFamille.TabIndex = 3;
            // 
            // labelFamille
            // 
            this.labelFamille.AutoSize = true;
            this.labelFamille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelFamille.Location = new System.Drawing.Point(195, 28);
            this.labelFamille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFamille.Name = "labelFamille";
            this.labelFamille.Size = new System.Drawing.Size(48, 15);
            this.labelFamille.TabIndex = 2;
            this.labelFamille.Text = "Famille";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(52, 26);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(121, 21);
            this.dtpDate.TabIndex = 1;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelDate.Location = new System.Drawing.Point(19, 28);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 15);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReference,
            this.colDesignation,
            this.colStock,
            this.colEntree,
            this.colSortie});
            this.dgvStock.EnableHeadersVisualStyles = false;
            this.dgvStock.Location = new System.Drawing.Point(9, 70);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dgvStock.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(718, 370);
            this.dgvStock.TabIndex = 1;
            // 
            // colReference
            // 
            this.colReference.HeaderText = "Reference";
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
            // colEntree
            // 
            this.colEntree.HeaderText = "entree";
            this.colEntree.MinimumWidth = 6;
            this.colEntree.Name = "colEntree";
            this.colEntree.ReadOnly = true;
            // 
            // colSortie
            // 
            this.colSortie.HeaderText = "sortie";
            this.colSortie.MinimumWidth = 6;
            this.colSortie.Name = "colSortie";
            this.colSortie.ReadOnly = true;
            // 
            // FormMouvementStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 456);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.panelFilters);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(754, 495);
            this.Name = "FormMouvementStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouvement Du Stock par période";
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label labelFamille;
        private System.Windows.Forms.ComboBox cmbFamille;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Label labelAlerte;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label labelRupture;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntree;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSortie;
    }
}