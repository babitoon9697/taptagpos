namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class TableFacture
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
            this.btnAfficherTous = new System.Windows.Forms.Button();
            this.btnParClient = new System.Windows.Forms.Button();
            this.btnParDate = new System.Windows.Forms.Button();
            this.btnPeriode = new System.Windows.Forms.Button();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.dgvFactures = new System.Windows.Forms.DataGridView();
            this.colNumFacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMontant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEtat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnImprimerSansEP = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactures)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.btnAfficherTous);
            this.panelFilters.Controls.Add(this.btnParClient);
            this.panelFilters.Controls.Add(this.btnParDate);
            this.panelFilters.Controls.Add(this.btnPeriode);
            this.panelFilters.Controls.Add(this.dtpDateFin);
            this.panelFilters.Controls.Add(this.labelDateFin);
            this.panelFilters.Controls.Add(this.dtpDateDebut);
            this.panelFilters.Controls.Add(this.labelDateDebut);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(738, 65);
            this.panelFilters.TabIndex = 0;
            // 
            // btnAfficherTous
            // 
            this.btnAfficherTous.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficherTous.Location = new System.Drawing.Point(472, 23);
            this.btnAfficherTous.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAfficherTous.Name = "btnAfficherTous";
            this.btnAfficherTous.Size = new System.Drawing.Size(90, 28);
            this.btnAfficherTous.TabIndex = 7;
            this.btnAfficherTous.Text = "Afficher tous";
            this.btnAfficherTous.UseVisualStyleBackColor = true;
            // 
            // btnParClient
            // 
            this.btnParClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParClient.Location = new System.Drawing.Point(377, 23);
            this.btnParClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnParClient.Name = "btnParClient";
            this.btnParClient.Size = new System.Drawing.Size(90, 28);
            this.btnParClient.TabIndex = 6;
            this.btnParClient.Text = "Par Client";
            this.btnParClient.UseVisualStyleBackColor = true;
            // 
            // btnParDate
            // 
            this.btnParDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParDate.Location = new System.Drawing.Point(283, 23);
            this.btnParDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnParDate.Name = "btnParDate";
            this.btnParDate.Size = new System.Drawing.Size(90, 28);
            this.btnParDate.TabIndex = 5;
            this.btnParDate.Text = "Par Date";
            this.btnParDate.UseVisualStyleBackColor = true;
            // 
            // btnPeriode
            // 
            this.btnPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriode.Location = new System.Drawing.Point(188, 23);
            this.btnPeriode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPeriode.Name = "btnPeriode";
            this.btnPeriode.Size = new System.Drawing.Size(90, 28);
            this.btnPeriode.TabIndex = 4;
            this.btnPeriode.Text = "Période";
            this.btnPeriode.UseVisualStyleBackColor = true;
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFin.Location = new System.Drawing.Point(83, 37);
            this.dtpDateFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(97, 21);
            this.dtpDateFin.TabIndex = 3;
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFin.Location = new System.Drawing.Point(17, 39);
            this.labelDateFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(66, 15);
            this.labelDateFin.TabIndex = 2;
            this.labelDateFin.Text = "Date de fin";
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDebut.Location = new System.Drawing.Point(83, 10);
            this.dtpDateDebut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(97, 21);
            this.dtpDateDebut.TabIndex = 1;
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateDebut.Location = new System.Drawing.Point(17, 12);
            this.labelDateDebut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(84, 15);
            this.labelDateDebut.TabIndex = 0;
            this.labelDateDebut.Text = "Date de début";
            // 
            // dgvFactures
            // 
            this.dgvFactures.AllowUserToAddRows = false;
            this.dgvFactures.AllowUserToDeleteRows = false;
            this.dgvFactures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFactures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFactures.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFactures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFactures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumFacture,
            this.colDate,
            this.colClient,
            this.colMontant,
            this.colEtat});
            this.dgvFactures.EnableHeadersVisualStyles = false;
            this.dgvFactures.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvFactures.Location = new System.Drawing.Point(9, 70);
            this.dgvFactures.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvFactures.Name = "dgvFactures";
            this.dgvFactures.ReadOnly = true;
            this.dgvFactures.RowHeadersVisible = false;
            this.dgvFactures.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvFactures.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFactures.RowTemplate.Height = 24;
            this.dgvFactures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFactures.Size = new System.Drawing.Size(615, 341);
            this.dgvFactures.TabIndex = 1;
            // 
            // colNumFacture
            // 
            this.colNumFacture.HeaderText = "N° Facture";
            this.colNumFacture.MinimumWidth = 6;
            this.colNumFacture.Name = "colNumFacture";
            this.colNumFacture.ReadOnly = true;
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
            // colMontant
            // 
            this.colMontant.HeaderText = "Montant TTC";
            this.colMontant.MinimumWidth = 6;
            this.colMontant.Name = "colMontant";
            this.colMontant.ReadOnly = true;
            // 
            // colEtat
            // 
            this.colEtat.HeaderText = "Etat";
            this.colEtat.MinimumWidth = 6;
            this.colEtat.Name = "colEtat";
            this.colEtat.ReadOnly = true;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.labelTotal);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 421);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(738, 35);
            this.panelFooter.TabIndex = 2;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(9, 10);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(39, 15);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Total";
            // 
            // btnNouveau
            // 
            this.btnNouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(630, 70);
            this.btnNouveau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(98, 32);
            this.btnNouveau.TabIndex = 3;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(630, 107);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(98, 32);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(630, 145);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(98, 32);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnImprimer
            // 
            this.btnImprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.Location = new System.Drawing.Point(630, 182);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(98, 32);
            this.btnImprimer.TabIndex = 6;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            // 
            // btnImprimerSansEP
            // 
            this.btnImprimerSansEP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimerSansEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerSansEP.Location = new System.Drawing.Point(630, 219);
            this.btnImprimerSansEP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImprimerSansEP.Name = "btnImprimerSansEP";
            this.btnImprimerSansEP.Size = new System.Drawing.Size(98, 32);
            this.btnImprimerSansEP.TabIndex = 7;
            this.btnImprimerSansEP.Text = "Imprimer sans E.P";
            this.btnImprimerSansEP.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(630, 257);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(98, 32);
            this.btnFermer.TabIndex = 8;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // TableFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 456);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnImprimerSansEP);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.dgvFactures);
            this.Controls.Add(this.panelFilters);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(754, 495);
            this.Name = "TableFacture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Facture";
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactures)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.DataGridView dgvFactures;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Label labelDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.Button btnPeriode;
        private System.Windows.Forms.Button btnParDate;
        private System.Windows.Forms.Button btnParClient;
        private System.Windows.Forms.Button btnAfficherTous;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnImprimerSansEP;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumFacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEtat;
    }
}