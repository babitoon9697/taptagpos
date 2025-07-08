namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class TableOrdresFabrication
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
            this.cmbResponsable = new System.Windows.Forms.ComboBox();
            this.labelResponsable = new System.Windows.Forms.Label();
            this.cmbMachine = new System.Windows.Forms.ComboBox();
            this.labelMachine = new System.Windows.Forms.Label();
            this.btnFiltrer = new System.Windows.Forms.Button();
            this.btnPeriode = new System.Windows.Forms.Button();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.colOF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeureDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateFinGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeureFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnConsulter = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.cmbResponsable);
            this.panelFilters.Controls.Add(this.labelResponsable);
            this.panelFilters.Controls.Add(this.cmbMachine);
            this.panelFilters.Controls.Add(this.labelMachine);
            this.panelFilters.Controls.Add(this.btnFiltrer);
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
            // cmbResponsable
            // 
            this.cmbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbResponsable.FormattingEnabled = true;
            this.cmbResponsable.Location = new System.Drawing.Point(556, 37);
            this.cmbResponsable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.Size = new System.Drawing.Size(136, 23);
            this.cmbResponsable.TabIndex = 9;
            // 
            // labelResponsable
            // 
            this.labelResponsable.AutoSize = true;
            this.labelResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResponsable.Location = new System.Drawing.Point(477, 39);
            this.labelResponsable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResponsable.Name = "labelResponsable";
            this.labelResponsable.Size = new System.Drawing.Size(80, 15);
            this.labelResponsable.TabIndex = 8;
            this.labelResponsable.Text = "Responsable";
            // 
            // cmbMachine
            // 
            this.cmbMachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMachine.FormattingEnabled = true;
            this.cmbMachine.Location = new System.Drawing.Point(556, 10);
            this.cmbMachine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMachine.Name = "cmbMachine";
            this.cmbMachine.Size = new System.Drawing.Size(136, 23);
            this.cmbMachine.TabIndex = 7;
            // 
            // labelMachine
            // 
            this.labelMachine.AutoSize = true;
            this.labelMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMachine.Location = new System.Drawing.Point(477, 12);
            this.labelMachine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMachine.Name = "labelMachine";
            this.labelMachine.Size = new System.Drawing.Size(55, 15);
            this.labelMachine.TabIndex = 6;
            this.labelMachine.Text = "Machine";
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrer.Location = new System.Drawing.Point(375, 23);
            this.btnFiltrer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(90, 28);
            this.btnFiltrer.TabIndex = 5;
            this.btnFiltrer.Text = "Filtrer";
            this.btnFiltrer.UseVisualStyleBackColor = true;
            // 
            // btnPeriode
            // 
            this.btnPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriode.Location = new System.Drawing.Point(280, 23);
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
            this.dtpDateFin.Location = new System.Drawing.Point(94, 37);
            this.dtpDateFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(174, 21);
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
            this.dtpDateDebut.Location = new System.Drawing.Point(94, 10);
            this.dtpDateDebut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(174, 21);
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
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOF,
            this.colDateDebut,
            this.colHeureDebut,
            this.colDateFinGrid,
            this.colHeureFin,
            this.colLot,
            this.colResponsable});
            this.dgvOrders.EnableHeadersVisualStyles = false;
            this.dgvOrders.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvOrders.Location = new System.Drawing.Point(9, 70);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvOrders.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(615, 370);
            this.dgvOrders.TabIndex = 1;
            // 
            // colOF
            // 
            this.colOF.HeaderText = "N° OF";
            this.colOF.MinimumWidth = 6;
            this.colOF.Name = "colOF";
            this.colOF.ReadOnly = true;
            // 
            // colDateDebut
            // 
            this.colDateDebut.HeaderText = "Date de";
            this.colDateDebut.MinimumWidth = 6;
            this.colDateDebut.Name = "colDateDebut";
            this.colDateDebut.ReadOnly = true;
            // 
            // colHeureDebut
            // 
            this.colHeureDebut.FillWeight = 80F;
            this.colHeureDebut.HeaderText = "Heure";
            this.colHeureDebut.MinimumWidth = 6;
            this.colHeureDebut.Name = "colHeureDebut";
            this.colHeureDebut.ReadOnly = true;
            // 
            // colDateFinGrid
            // 
            this.colDateFinGrid.HeaderText = "Date de fin";
            this.colDateFinGrid.MinimumWidth = 6;
            this.colDateFinGrid.Name = "colDateFinGrid";
            this.colDateFinGrid.ReadOnly = true;
            // 
            // colHeureFin
            // 
            this.colHeureFin.FillWeight = 80F;
            this.colHeureFin.HeaderText = "Heure Fin";
            this.colHeureFin.MinimumWidth = 6;
            this.colHeureFin.Name = "colHeureFin";
            this.colHeureFin.ReadOnly = true;
            // 
            // colLot
            // 
            this.colLot.HeaderText = "N° de Lot";
            this.colLot.MinimumWidth = 6;
            this.colLot.Name = "colLot";
            this.colLot.ReadOnly = true;
            // 
            // colResponsable
            // 
            this.colResponsable.HeaderText = "Responsable";
            this.colResponsable.MinimumWidth = 6;
            this.colResponsable.Name = "colResponsable";
            this.colResponsable.ReadOnly = true;
            // 
            // btnNouveau
            // 
            this.btnNouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(630, 81);
            this.btnNouveau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(98, 32);
            this.btnNouveau.TabIndex = 2;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(630, 119);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(98, 32);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnConsulter
            // 
            this.btnConsulter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsulter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulter.Location = new System.Drawing.Point(630, 156);
            this.btnConsulter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsulter.Name = "btnConsulter";
            this.btnConsulter.Size = new System.Drawing.Size(98, 32);
            this.btnConsulter.TabIndex = 4;
            this.btnConsulter.Text = "Consulter";
            this.btnConsulter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsulter.UseVisualStyleBackColor = true;
            // 
            // btnImprimer
            // 
            this.btnImprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.Location = new System.Drawing.Point(630, 193);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(98, 32);
            this.btnImprimer.TabIndex = 5;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimer.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(630, 231);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(98, 32);
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(630, 268);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(98, 32);
            this.btnFermer.TabIndex = 7;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // TableOrdresFabrication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 456);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnConsulter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.panelFilters);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(754, 495);
            this.Name = "TableOrdresFabrication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des ordres de fabrication";
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Label labelDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.Button btnPeriode;
        private System.Windows.Forms.Button btnFiltrer;
        private System.Windows.Forms.ComboBox cmbMachine;
        private System.Windows.Forms.Label labelMachine;
        private System.Windows.Forms.ComboBox cmbResponsable;
        private System.Windows.Forms.Label labelResponsable;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnConsulter;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeureDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateFinGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeureFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResponsable;
    }
}