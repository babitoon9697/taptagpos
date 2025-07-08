namespace TAPTAGPOS
{
    partial class TableBordereaux
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
            this.btnFiltrer = new System.Windows.Forms.Button();
            this.btnPeriode = new System.Windows.Forms.Button();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.dgvBordereaux = new System.Windows.Forms.DataGridView();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoyenPaiement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMontant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnImprimerListe = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBordereaux)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.btnFiltrer);
            this.panelFilters.Controls.Add(this.btnPeriode);
            this.panelFilters.Controls.Add(this.dtpDateFin);
            this.panelFilters.Controls.Add(this.labelDateFin);
            this.panelFilters.Controls.Add(this.dtpDateDebut);
            this.panelFilters.Controls.Add(this.labelDateDebut);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(984, 80);
            this.panelFilters.TabIndex = 0;
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnFiltrer.Location = new System.Drawing.Point(380, 28);
            this.btnFiltrer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(120, 34);
            this.btnFiltrer.TabIndex = 5;
            this.btnFiltrer.Text = "Filtrer";
            this.btnFiltrer.UseVisualStyleBackColor = true;
            // 
            // btnPeriode
            // 
            this.btnPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnPeriode.Location = new System.Drawing.Point(253, 28);
            this.btnPeriode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPeriode.Name = "btnPeriode";
            this.btnPeriode.Size = new System.Drawing.Size(120, 34);
            this.btnPeriode.TabIndex = 4;
            this.btnPeriode.Text = "Période";
            this.btnPeriode.UseVisualStyleBackColor = true;
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFin.Location = new System.Drawing.Point(109, 46);
            this.dtpDateFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(129, 21);
            this.dtpDateFin.TabIndex = 3;
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelDateFin.Location = new System.Drawing.Point(23, 48);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(66, 15);
            this.labelDateFin.TabIndex = 2;
            this.labelDateFin.Text = "Date de fin";
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDebut.Location = new System.Drawing.Point(109, 12);
            this.dtpDateDebut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(129, 21);
            this.dtpDateDebut.TabIndex = 1;
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelDateDebut.Location = new System.Drawing.Point(23, 15);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(84, 15);
            this.labelDateDebut.TabIndex = 0;
            this.labelDateDebut.Text = "Date de début";
            // 
            // dgvBordereaux
            // 
            this.dgvBordereaux.AllowUserToAddRows = false;
            this.dgvBordereaux.AllowUserToDeleteRows = false;
            this.dgvBordereaux.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBordereaux.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBordereaux.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBordereaux.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBordereaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBordereaux.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNum,
            this.colDate,
            this.colClient,
            this.colMoyenPaiement,
            this.colMontant,
            this.colTransport});
            this.dgvBordereaux.EnableHeadersVisualStyles = false;
            this.dgvBordereaux.Location = new System.Drawing.Point(12, 86);
            this.dgvBordereaux.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBordereaux.Name = "dgvBordereaux";
            this.dgvBordereaux.ReadOnly = true;
            this.dgvBordereaux.RowHeadersVisible = false;
            this.dgvBordereaux.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvBordereaux.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBordereaux.RowTemplate.Height = 24;
            this.dgvBordereaux.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBordereaux.Size = new System.Drawing.Size(820, 455);
            this.dgvBordereaux.TabIndex = 1;
            // 
            // colNum
            // 
            this.colNum.HeaderText = "N°";
            this.colNum.MinimumWidth = 6;
            this.colNum.Name = "colNum";
            this.colNum.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colClient
            // 
            this.colClient.FillWeight = 150F;
            this.colClient.HeaderText = "Client";
            this.colClient.MinimumWidth = 6;
            this.colClient.Name = "colClient";
            this.colClient.ReadOnly = true;
            // 
            // colMoyenPaiement
            // 
            this.colMoyenPaiement.HeaderText = "Moyen de paiement";
            this.colMoyenPaiement.MinimumWidth = 6;
            this.colMoyenPaiement.Name = "colMoyenPaiement";
            this.colMoyenPaiement.ReadOnly = true;
            // 
            // colMontant
            // 
            this.colMontant.HeaderText = "Montant";
            this.colMontant.MinimumWidth = 6;
            this.colMontant.Name = "colMontant";
            this.colMontant.ReadOnly = true;
            // 
            // colTransport
            // 
            this.colTransport.HeaderText = "Transport";
            this.colTransport.MinimumWidth = 6;
            this.colTransport.Name = "colTransport";
            this.colTransport.ReadOnly = true;
            // 
            // btnNouveau
            // 
            this.btnNouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnNouveau.Location = new System.Drawing.Point(840, 100);
            this.btnNouveau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(131, 39);
            this.btnNouveau.TabIndex = 2;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnModifier.Location = new System.Drawing.Point(840, 146);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(131, 39);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnSupprimer.Location = new System.Drawing.Point(840, 192);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(131, 39);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnImprimer
            // 
            this.btnImprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnImprimer.Location = new System.Drawing.Point(840, 238);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(131, 39);
            this.btnImprimer.TabIndex = 5;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            // 
            // btnImprimerListe
            // 
            this.btnImprimerListe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimerListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnImprimerListe.Location = new System.Drawing.Point(840, 284);
            this.btnImprimerListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImprimerListe.Name = "btnImprimerListe";
            this.btnImprimerListe.Size = new System.Drawing.Size(131, 39);
            this.btnImprimerListe.TabIndex = 6;
            this.btnImprimerListe.Text = "Imprimer Liste";
            this.btnImprimerListe.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnFermer.Location = new System.Drawing.Point(840, 330);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(131, 39);
            this.btnFermer.TabIndex = 7;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // TableBordereaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnImprimerListe);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.dgvBordereaux);
            this.Controls.Add(this.panelFilters);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "TableBordereaux";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table des bordereaux";
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBordereaux)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.DataGridView dgvBordereaux;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Label labelDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.Button btnPeriode;
        private System.Windows.Forms.Button btnFiltrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoyenPaiement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransport;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnImprimerListe;
        private System.Windows.Forms.Button btnFermer;
    }
}