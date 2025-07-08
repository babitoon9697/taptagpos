namespace TAPTAGPOS 
{
    partial class TableBonLivraison
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
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.btnFiltrer = new System.Windows.Forms.Button();
            this.btnPeriode = new System.Windows.Forms.Button();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.dgvBonLivraison = new System.Windows.Forms.DataGridView();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnImprimerSansEP = new System.Windows.Forms.Button();
            this.btnImprimerListe = new System.Windows.Forms.Button();
            this.btnBLtoFacture = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnValiderSelection = new System.Windows.Forms.Button();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReglement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBonLivraison)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.cmbClient);
            this.panelFilters.Controls.Add(this.labelClient);
            this.panelFilters.Controls.Add(this.btnFiltrer);
            this.panelFilters.Controls.Add(this.btnPeriode);
            this.panelFilters.Controls.Add(this.dtpDateFin);
            this.panelFilters.Controls.Add(this.labelDateFin);
            this.panelFilters.Controls.Add(this.dtpDateDebut);
            this.panelFilters.Controls.Add(this.labelDateDebut);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(1107, 90);
            this.panelFilters.TabIndex = 0;
            // 
            // cmbClient
            // 
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(609, 36);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(224, 26);
            this.cmbClient.TabIndex = 7;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.Location = new System.Drawing.Point(552, 39);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(45, 17);
            this.labelClient.TabIndex = 6;
            this.labelClient.Text = "Client";
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnFiltrer.Location = new System.Drawing.Point(411, 32);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(135, 39);
            this.btnFiltrer.TabIndex = 5;
            this.btnFiltrer.Text = "Filtrer";
            this.btnFiltrer.UseVisualStyleBackColor = true;
            // 
            // btnPeriode
            // 
            this.btnPeriode.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnPeriode.Location = new System.Drawing.Point(268, 32);
            this.btnPeriode.Name = "btnPeriode";
            this.btnPeriode.Size = new System.Drawing.Size(135, 39);
            this.btnPeriode.TabIndex = 4;
            this.btnPeriode.Text = "Période";
            this.btnPeriode.UseVisualStyleBackColor = true;
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFin.Location = new System.Drawing.Point(118, 51);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(144, 25);
            this.dtpDateFin.TabIndex = 3;
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFin.Location = new System.Drawing.Point(26, 54);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(78, 17);
            this.labelDateFin.TabIndex = 2;
            this.labelDateFin.Text = "Date de fin";
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDebut.Location = new System.Drawing.Point(118, 14);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(144, 25);
            this.dtpDateDebut.TabIndex = 1;
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateDebut.Location = new System.Drawing.Point(26, 17);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(99, 17);
            this.labelDateDebut.TabIndex = 0;
            this.labelDateDebut.Text = "Date de début";
            // 
            // dgvBonLivraison
            // 
            this.dgvBonLivraison.AllowUserToAddRows = false;
            this.dgvBonLivraison.AllowUserToDeleteRows = false;
            this.dgvBonLivraison.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBonLivraison.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBonLivraison.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBonLivraison.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBonLivraison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBonLivraison.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colBL,
            this.colClient,
            this.colTotal,
            this.colReglement,
            this.colReste,
            this.colSelect});
            this.dgvBonLivraison.EnableHeadersVisualStyles = false;
            this.dgvBonLivraison.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvBonLivraison.Location = new System.Drawing.Point(14, 97);
            this.dgvBonLivraison.Name = "dgvBonLivraison";
            this.dgvBonLivraison.ReadOnly = true;
            this.dgvBonLivraison.RowHeadersVisible = false;
            this.dgvBonLivraison.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvBonLivraison.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBonLivraison.RowTemplate.Height = 24;
            this.dgvBonLivraison.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBonLivraison.Size = new System.Drawing.Size(922, 472);
            this.dgvBonLivraison.TabIndex = 1;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.labelTotal);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 583);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1107, 48);
            this.panelFooter.TabIndex = 2;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(14, 14);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(49, 15);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "TOTAL";
            // 
            // btnNouveau
            // 
            this.btnNouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNouveau.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNouveau.Location = new System.Drawing.Point(945, 97);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(147, 44);
            this.btnNouveau.TabIndex = 3;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModifier.Location = new System.Drawing.Point(945, 148);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(147, 44);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSupprimer.Location = new System.Drawing.Point(945, 201);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(147, 44);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnImprimer
            // 
            this.btnImprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnImprimer.Location = new System.Drawing.Point(945, 252);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(147, 44);
            this.btnImprimer.TabIndex = 6;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            // 
            // btnImprimerSansEP
            // 
            this.btnImprimerSansEP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimerSansEP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnImprimerSansEP.Location = new System.Drawing.Point(945, 303);
            this.btnImprimerSansEP.Name = "btnImprimerSansEP";
            this.btnImprimerSansEP.Size = new System.Drawing.Size(147, 44);
            this.btnImprimerSansEP.TabIndex = 7;
            this.btnImprimerSansEP.Text = "Imprimer sans E.P";
            this.btnImprimerSansEP.UseVisualStyleBackColor = true;
            // 
            // btnImprimerListe
            // 
            this.btnImprimerListe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimerListe.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnImprimerListe.Location = new System.Drawing.Point(945, 356);
            this.btnImprimerListe.Name = "btnImprimerListe";
            this.btnImprimerListe.Size = new System.Drawing.Size(147, 44);
            this.btnImprimerListe.TabIndex = 8;
            this.btnImprimerListe.Text = "Imprimer Liste";
            this.btnImprimerListe.UseVisualStyleBackColor = true;
            // 
            // btnBLtoFacture
            // 
            this.btnBLtoFacture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBLtoFacture.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBLtoFacture.Location = new System.Drawing.Point(945, 407);
            this.btnBLtoFacture.Name = "btnBLtoFacture";
            this.btnBLtoFacture.Size = new System.Drawing.Size(147, 44);
            this.btnBLtoFacture.TabIndex = 9;
            this.btnBLtoFacture.Text = "Bl à Facture";
            this.btnBLtoFacture.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFermer.Location = new System.Drawing.Point(945, 460);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(147, 44);
            this.btnFermer.TabIndex = 10;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // btnValiderSelection
            // 
            this.btnValiderSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValiderSelection.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnValiderSelection.Location = new System.Drawing.Point(945, 510);
            this.btnValiderSelection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnValiderSelection.Name = "btnValiderSelection";
            this.btnValiderSelection.Size = new System.Drawing.Size(147, 60);
            this.btnValiderSelection.TabIndex = 11;
            this.btnValiderSelection.Text = "Valider Sélection";
            this.btnValiderSelection.UseVisualStyleBackColor = true;
            this.btnValiderSelection.Visible = false;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colBL
            // 
            this.colBL.HeaderText = "N° B.L.";
            this.colBL.MinimumWidth = 6;
            this.colBL.Name = "colBL";
            this.colBL.ReadOnly = true;
            // 
            // colClient
            // 
            this.colClient.FillWeight = 150F;
            this.colClient.HeaderText = "Client";
            this.colClient.MinimumWidth = 6;
            this.colClient.Name = "colClient";
            this.colClient.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colReglement
            // 
            this.colReglement.HeaderText = "Règlement";
            this.colReglement.MinimumWidth = 6;
            this.colReglement.Name = "colReglement";
            this.colReglement.ReadOnly = true;
            // 
            // colReste
            // 
            this.colReste.HeaderText = "Reste";
            this.colReste.MinimumWidth = 6;
            this.colReste.Name = "colReste";
            this.colReste.ReadOnly = true;
            // 
            // colSelect
            // 
            this.colSelect.FillWeight = 50F;
            this.colSelect.HeaderText = "Select";
            this.colSelect.Name = "colSelect";
            this.colSelect.ReadOnly = true;
            // 
            // TableBonLivraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 631);
            this.Controls.Add(this.btnValiderSelection);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnBLtoFacture);
            this.Controls.Add(this.btnImprimerListe);
            this.Controls.Add(this.btnImprimerSansEP);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.dgvBonLivraison);
            this.Controls.Add(this.panelFilters);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1123, 670);
            this.Name = "TableBonLivraison";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Bon de Livraison";
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBonLivraison)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.DataGridView dgvBonLivraison;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Label labelDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.Button btnPeriode;
        private System.Windows.Forms.Button btnFiltrer;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnImprimerSansEP;
        private System.Windows.Forms.Button btnImprimerListe;
        private System.Windows.Forms.Button btnBLtoFacture;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnValiderSelection;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReglement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReste;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelect;
    }
}