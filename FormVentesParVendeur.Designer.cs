namespace TAPTAGPOS
{
    partial class FormVentesParVendeur
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.cmbVendeur = new System.Windows.Forms.ComboBox();
            this.labelVendeur = new System.Windows.Forms.Label();
            this.btnPeriode = new System.Windows.Forms.Button();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommissionRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuPeriode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aujourdhuiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semaineEnCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semainePrécédenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moisEnCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moisPrécédentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deuxDerniersMoisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deuxMoisFlottantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annéeEnCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annéePrécédentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annéeFlottanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.contextMenuPeriode.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.btnFermer);
            this.panelFilters.Controls.Add(this.btnImprimer);
            this.panelFilters.Controls.Add(this.btnValider);
            this.panelFilters.Controls.Add(this.cmbVendeur);
            this.panelFilters.Controls.Add(this.labelVendeur);
            this.panelFilters.Controls.Add(this.btnPeriode);
            this.panelFilters.Controls.Add(this.dtpDateFin);
            this.panelFilters.Controls.Add(this.labelDateFin);
            this.panelFilters.Controls.Add(this.dtpDateDebut);
            this.panelFilters.Controls.Add(this.labelDateDebut);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(738, 98);
            this.panelFilters.TabIndex = 0;
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(632, 57);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(98, 32);
            this.btnFermer.TabIndex = 9;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // btnImprimer
            // 
            this.btnImprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.Location = new System.Drawing.Point(438, 57);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(90, 28);
            this.btnImprimer.TabIndex = 8;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(344, 57);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(90, 28);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // cmbVendeur
            // 
            this.cmbVendeur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVendeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendeur.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cmbVendeur.FormattingEnabled = true;
            this.cmbVendeur.Location = new System.Drawing.Point(438, 23);
            this.cmbVendeur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbVendeur.Name = "cmbVendeur";
            this.cmbVendeur.Size = new System.Drawing.Size(211, 22);
            this.cmbVendeur.TabIndex = 6;
            // 
            // labelVendeur
            // 
            this.labelVendeur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVendeur.AutoSize = true;
            this.labelVendeur.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendeur.Location = new System.Drawing.Point(653, 26);
            this.labelVendeur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVendeur.Name = "labelVendeur";
            this.labelVendeur.Size = new System.Drawing.Size(36, 14);
            this.labelVendeur.TabIndex = 5;
            this.labelVendeur.Text = "البائع";
            // 
            // btnPeriode
            // 
            this.btnPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriode.Location = new System.Drawing.Point(172, 34);
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
            this.dtpDateFin.Location = new System.Drawing.Point(19, 50);
            this.dtpDateFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(136, 21);
            this.dtpDateFin.TabIndex = 3;
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFin.Location = new System.Drawing.Point(16, 33);
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
            this.dtpDateDebut.Location = new System.Drawing.Point(19, 10);
            this.dtpDateDebut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(136, 21);
            this.dtpDateDebut.TabIndex = 1;
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateDebut.Location = new System.Drawing.Point(-58, 12);
            this.labelDateDebut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(84, 15);
            this.labelDateDebut.TabIndex = 0;
            this.labelDateDebut.Text = "Date de début";
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colItem,
            this.colQty,
            this.colTotal,
            this.colCommissionRate,
            this.colCommission});
            this.dgvSales.EnableHeadersVisualStyles = false;
            this.dgvSales.Location = new System.Drawing.Point(9, 102);
            this.dgvSales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dgvSales.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSales.RowTemplate.Height = 24;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(718, 337);
            this.dgvSales.TabIndex = 1;
            // 
            // colCode
            // 
            this.colCode.HeaderText = "كود";
            this.colCode.MinimumWidth = 6;
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            // 
            // colItem
            // 
            this.colItem.FillWeight = 200F;
            this.colItem.HeaderText = "السلعة";
            this.colItem.MinimumWidth = 6;
            this.colItem.Name = "colItem";
            this.colItem.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "الكمية";
            this.colQty.MinimumWidth = 6;
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "المجموع";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colCommissionRate
            // 
            this.colCommissionRate.HeaderText = "نسبة العمولة %";
            this.colCommissionRate.MinimumWidth = 6;
            this.colCommissionRate.Name = "colCommissionRate";
            this.colCommissionRate.ReadOnly = true;
            // 
            // colCommission
            // 
            this.colCommission.HeaderText = "العمولة";
            this.colCommission.MinimumWidth = 6;
            this.colCommission.Name = "colCommission";
            this.colCommission.ReadOnly = true;
            // 
            // contextMenuPeriode
            // 
            this.contextMenuPeriode.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuPeriode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aujourdhuiToolStripMenuItem,
            this.hierToolStripMenuItem,
            this.semaineEnCoursToolStripMenuItem,
            this.semainePrécédenteToolStripMenuItem,
            this.moisEnCoursToolStripMenuItem,
            this.moisPrécédentToolStripMenuItem,
            this.deuxDerniersMoisToolStripMenuItem,
            this.deuxMoisFlottantsToolStripMenuItem,
            this.annéeEnCoursToolStripMenuItem,
            this.annéePrécédentToolStripMenuItem,
            this.annéeFlottanteToolStripMenuItem});
            this.contextMenuPeriode.Name = "contextMenuPeriode";
            this.contextMenuPeriode.Size = new System.Drawing.Size(182, 246);
            // 
            // aujourdhuiToolStripMenuItem
            // 
            this.aujourdhuiToolStripMenuItem.Name = "aujourdhuiToolStripMenuItem";
            this.aujourdhuiToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.aujourdhuiToolStripMenuItem.Text = "Aujourd\'hui";
            // 
            // hierToolStripMenuItem
            // 
            this.hierToolStripMenuItem.Name = "hierToolStripMenuItem";
            this.hierToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.hierToolStripMenuItem.Text = "Hier";
            // 
            // semaineEnCoursToolStripMenuItem
            // 
            this.semaineEnCoursToolStripMenuItem.Name = "semaineEnCoursToolStripMenuItem";
            this.semaineEnCoursToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.semaineEnCoursToolStripMenuItem.Text = "Semaine en cours";
            // 
            // semainePrécédenteToolStripMenuItem
            // 
            this.semainePrécédenteToolStripMenuItem.Name = "semainePrécédenteToolStripMenuItem";
            this.semainePrécédenteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.semainePrécédenteToolStripMenuItem.Text = "Semaine précédente";
            // 
            // moisEnCoursToolStripMenuItem
            // 
            this.moisEnCoursToolStripMenuItem.Name = "moisEnCoursToolStripMenuItem";
            this.moisEnCoursToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.moisEnCoursToolStripMenuItem.Text = "Mois en cours";
            // 
            // moisPrécédentToolStripMenuItem
            // 
            this.moisPrécédentToolStripMenuItem.Name = "moisPrécédentToolStripMenuItem";
            this.moisPrécédentToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.moisPrécédentToolStripMenuItem.Text = "Mois précédent";
            // 
            // deuxDerniersMoisToolStripMenuItem
            // 
            this.deuxDerniersMoisToolStripMenuItem.Name = "deuxDerniersMoisToolStripMenuItem";
            this.deuxDerniersMoisToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.deuxDerniersMoisToolStripMenuItem.Text = "Deux derniers mois";
            // 
            // deuxMoisFlottantsToolStripMenuItem
            // 
            this.deuxMoisFlottantsToolStripMenuItem.Name = "deuxMoisFlottantsToolStripMenuItem";
            this.deuxMoisFlottantsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.deuxMoisFlottantsToolStripMenuItem.Text = "Deux mois flottants";
            // 
            // annéeEnCoursToolStripMenuItem
            // 
            this.annéeEnCoursToolStripMenuItem.Name = "annéeEnCoursToolStripMenuItem";
            this.annéeEnCoursToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.annéeEnCoursToolStripMenuItem.Text = "Année en cours";
            // 
            // annéePrécédentToolStripMenuItem
            // 
            this.annéePrécédentToolStripMenuItem.Name = "annéePrécédentToolStripMenuItem";
            this.annéePrécédentToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.annéePrécédentToolStripMenuItem.Text = "Année précédent";
            // 
            // annéeFlottanteToolStripMenuItem
            // 
            this.annéeFlottanteToolStripMenuItem.Name = "annéeFlottanteToolStripMenuItem";
            this.annéeFlottanteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.annéeFlottanteToolStripMenuItem.Text = "Année flottante";
            // 
            // FormVentesParVendeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 456);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.panelFilters);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(754, 495);
            this.Name = "FormVentesParVendeur";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etat des ventes par vendeur";
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.contextMenuPeriode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Label labelDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.Button btnPeriode;
        private System.Windows.Forms.Label labelVendeur;
        private System.Windows.Forms.ComboBox cmbVendeur;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommissionRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommission;
        private System.Windows.Forms.ContextMenuStrip contextMenuPeriode;
        private System.Windows.Forms.ToolStripMenuItem aujourdhuiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semaineEnCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semainePrécédenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moisEnCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moisPrécédentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deuxDerniersMoisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deuxMoisFlottantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annéeEnCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annéePrécédentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annéeFlottanteToolStripMenuItem;
    }
}