namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class FicheOrdreFabrication
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.txtObservation = new System.Windows.Forms.TextBox();
            this.labelObservation = new System.Windows.Forms.Label();
            this.txtHeureFin = new System.Windows.Forms.TextBox();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.txtHeureDebut = new System.Windows.Forms.TextBox();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.txtLot = new System.Windows.Forms.TextBox();
            this.labelLot = new System.Windows.Forms.Label();
            this.cmbResponsable = new System.Windows.Forms.ComboBox();
            this.labelResponsable = new System.Windows.Forms.Label();
            this.cmbMachine = new System.Windows.Forms.ComboBox();
            this.labelMachine = new System.Windows.Forms.Label();
            this.txtOF = new System.Windows.Forms.TextBox();
            this.labelOF = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.groupMatiere = new System.Windows.Forms.GroupBox();
            this.dgvMatiere = new System.Windows.Forms.DataGridView();
            this.colMatRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatQte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatDepot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMatEnlever = new System.Windows.Forms.Button();
            this.btnMatAjouter = new System.Windows.Forms.Button();
            this.groupProduits = new System.Windows.Forms.GroupBox();
            this.dgvProduits = new System.Windows.Forms.DataGridView();
            this.colProdRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdQtePrevue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdQteProduite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdEcart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProdEnlever = new System.Windows.Forms.Button();
            this.btnProdAjouter = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.groupMatiere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatiere)).BeginInit();
            this.groupProduits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.txtObservation);
            this.panelHeader.Controls.Add(this.labelObservation);
            this.panelHeader.Controls.Add(this.txtHeureFin);
            this.panelHeader.Controls.Add(this.dtpDateFin);
            this.panelHeader.Controls.Add(this.labelDateFin);
            this.panelHeader.Controls.Add(this.txtHeureDebut);
            this.panelHeader.Controls.Add(this.dtpDateDebut);
            this.panelHeader.Controls.Add(this.labelDateDebut);
            this.panelHeader.Controls.Add(this.txtLot);
            this.panelHeader.Controls.Add(this.labelLot);
            this.panelHeader.Controls.Add(this.cmbResponsable);
            this.panelHeader.Controls.Add(this.labelResponsable);
            this.panelHeader.Controls.Add(this.cmbMachine);
            this.panelHeader.Controls.Add(this.labelMachine);
            this.panelHeader.Controls.Add(this.txtOF);
            this.panelHeader.Controls.Add(this.labelOF);
            this.panelHeader.Location = new System.Drawing.Point(9, 10);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(570, 130);
            this.panelHeader.TabIndex = 0;
            // 
            // txtObservation
            // 
            this.txtObservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservation.Location = new System.Drawing.Point(315, 73);
            this.txtObservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtObservation.Multiline = true;
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(241, 50);
            this.txtObservation.TabIndex = 15;
            // 
            // labelObservation
            // 
            this.labelObservation.AutoSize = true;
            this.labelObservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObservation.Location = new System.Drawing.Point(313, 56);
            this.labelObservation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelObservation.Name = "labelObservation";
            this.labelObservation.Size = new System.Drawing.Size(72, 15);
            this.labelObservation.TabIndex = 14;
            this.labelObservation.Text = "Observation";
            // 
            // txtHeureFin
            // 
            this.txtHeureFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeureFin.Location = new System.Drawing.Point(213, 102);
            this.txtHeureFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHeureFin.Name = "txtHeureFin";
            this.txtHeureFin.Size = new System.Drawing.Size(76, 21);
            this.txtHeureFin.TabIndex = 13;
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFin.Location = new System.Drawing.Point(98, 102);
            this.dtpDateFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(112, 21);
            this.dtpDateFin.TabIndex = 12;
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFin.Location = new System.Drawing.Point(8, 105);
            this.labelDateFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(96, 15);
            this.labelDateFin.TabIndex = 11;
            this.labelDateFin.Text = "Date Fin / Heure";
            // 
            // txtHeureDebut
            // 
            this.txtHeureDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeureDebut.Location = new System.Drawing.Point(213, 72);
            this.txtHeureDebut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHeureDebut.Name = "txtHeureDebut";
            this.txtHeureDebut.Size = new System.Drawing.Size(76, 21);
            this.txtHeureDebut.TabIndex = 10;
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDebut.Location = new System.Drawing.Point(98, 72);
            this.dtpDateDebut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(112, 21);
            this.dtpDateDebut.TabIndex = 9;
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateDebut.Location = new System.Drawing.Point(8, 74);
            this.labelDateDebut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(112, 15);
            this.labelDateDebut.TabIndex = 8;
            this.labelDateDebut.Text = "Date Début / Heure";
            // 
            // txtLot
            // 
            this.txtLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLot.Location = new System.Drawing.Point(98, 41);
            this.txtLot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(192, 21);
            this.txtLot.TabIndex = 7;
            // 
            // labelLot
            // 
            this.labelLot.AutoSize = true;
            this.labelLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLot.Location = new System.Drawing.Point(8, 43);
            this.labelLot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLot.Name = "labelLot";
            this.labelLot.Size = new System.Drawing.Size(58, 15);
            this.labelLot.TabIndex = 6;
            this.labelLot.Text = "N° de Lot";
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbResponsable.FormattingEnabled = true;
            this.cmbResponsable.Location = new System.Drawing.Point(405, 10);
            this.cmbResponsable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.Size = new System.Drawing.Size(151, 23);
            this.cmbResponsable.TabIndex = 5;
            // 
            // labelResponsable
            // 
            this.labelResponsable.AutoSize = true;
            this.labelResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResponsable.Location = new System.Drawing.Point(326, 12);
            this.labelResponsable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResponsable.Name = "labelResponsable";
            this.labelResponsable.Size = new System.Drawing.Size(80, 15);
            this.labelResponsable.TabIndex = 4;
            this.labelResponsable.Text = "Responsable";
            // 
            // cmbMachine
            // 
            this.cmbMachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMachine.FormattingEnabled = true;
            this.cmbMachine.Location = new System.Drawing.Point(138, 10);
            this.cmbMachine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMachine.Name = "cmbMachine";
            this.cmbMachine.Size = new System.Drawing.Size(151, 23);
            this.cmbMachine.TabIndex = 3;
            // 
            // labelMachine
            // 
            this.labelMachine.AutoSize = true;
            this.labelMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMachine.Location = new System.Drawing.Point(86, 12);
            this.labelMachine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMachine.Name = "labelMachine";
            this.labelMachine.Size = new System.Drawing.Size(55, 15);
            this.labelMachine.TabIndex = 2;
            this.labelMachine.Text = "Machine";
            // 
            // txtOF
            // 
            this.txtOF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOF.Location = new System.Drawing.Point(46, 10);
            this.txtOF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOF.Name = "txtOF";
            this.txtOF.ReadOnly = true;
            this.txtOF.Size = new System.Drawing.Size(36, 21);
            this.txtOF.TabIndex = 1;
            // 
            // labelOF
            // 
            this.labelOF.AutoSize = true;
            this.labelOF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOF.Location = new System.Drawing.Point(8, 12);
            this.labelOF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOF.Name = "labelOF";
            this.labelOF.Size = new System.Drawing.Size(40, 15);
            this.labelOF.TabIndex = 0;
            this.labelOF.Text = "N° OF";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(591, 24);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 32);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(591, 62);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(90, 32);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnImprimer
            // 
            this.btnImprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.Location = new System.Drawing.Point(591, 99);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(90, 32);
            this.btnImprimer.TabIndex = 3;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            // 
            // groupMatiere
            // 
            this.groupMatiere.Controls.Add(this.dgvMatiere);
            this.groupMatiere.Controls.Add(this.btnMatEnlever);
            this.groupMatiere.Controls.Add(this.btnMatAjouter);
            this.groupMatiere.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMatiere.Location = new System.Drawing.Point(9, 145);
            this.groupMatiere.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupMatiere.Name = "groupMatiere";
            this.groupMatiere.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupMatiere.Size = new System.Drawing.Size(672, 179);
            this.groupMatiere.TabIndex = 4;
            this.groupMatiere.TabStop = false;
            this.groupMatiere.Text = "Matières premières";
            // 
            // dgvMatiere
            // 
            this.dgvMatiere.AllowUserToAddRows = false;
            this.dgvMatiere.AllowUserToDeleteRows = false;
            this.dgvMatiere.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatiere.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatiere.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMatiere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatiere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMatRef,
            this.colMatDesignation,
            this.colMatQte,
            this.colMatDepot});
            this.dgvMatiere.EnableHeadersVisualStyles = false;
            this.dgvMatiere.Location = new System.Drawing.Point(10, 22);
            this.dgvMatiere.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMatiere.Name = "dgvMatiere";
            this.dgvMatiere.RowHeadersVisible = false;
            this.dgvMatiere.RowHeadersWidth = 51;
            this.dgvMatiere.RowTemplate.Height = 24;
            this.dgvMatiere.Size = new System.Drawing.Size(560, 146);
            this.dgvMatiere.TabIndex = 2;
            // 
            // colMatRef
            // 
            this.colMatRef.HeaderText = "Référence";
            this.colMatRef.MinimumWidth = 6;
            this.colMatRef.Name = "colMatRef";
            // 
            // colMatDesignation
            // 
            this.colMatDesignation.FillWeight = 200F;
            this.colMatDesignation.HeaderText = "Désignation";
            this.colMatDesignation.MinimumWidth = 6;
            this.colMatDesignation.Name = "colMatDesignation";
            // 
            // colMatQte
            // 
            this.colMatQte.HeaderText = "Qte";
            this.colMatQte.MinimumWidth = 6;
            this.colMatQte.Name = "colMatQte";
            // 
            // colMatDepot
            // 
            this.colMatDepot.HeaderText = "Dépôt";
            this.colMatDepot.MinimumWidth = 6;
            this.colMatDepot.Name = "colMatDepot";
            // 
            // btnMatEnlever
            // 
            this.btnMatEnlever.Location = new System.Drawing.Point(582, 59);
            this.btnMatEnlever.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMatEnlever.Name = "btnMatEnlever";
            this.btnMatEnlever.Size = new System.Drawing.Size(82, 32);
            this.btnMatEnlever.TabIndex = 1;
            this.btnMatEnlever.Text = "Enlever";
            this.btnMatEnlever.UseVisualStyleBackColor = true;
            // 
            // btnMatAjouter
            // 
            this.btnMatAjouter.Location = new System.Drawing.Point(582, 22);
            this.btnMatAjouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMatAjouter.Name = "btnMatAjouter";
            this.btnMatAjouter.Size = new System.Drawing.Size(82, 32);
            this.btnMatAjouter.TabIndex = 0;
            this.btnMatAjouter.Text = "Ajouter";
            this.btnMatAjouter.UseVisualStyleBackColor = true;
            this.btnMatAjouter.Click += new System.EventHandler(this.btnMatAjouter_Click);
            // 
            // groupProduits
            // 
            this.groupProduits.Controls.Add(this.dgvProduits);
            this.groupProduits.Controls.Add(this.btnProdEnlever);
            this.groupProduits.Controls.Add(this.btnProdAjouter);
            this.groupProduits.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupProduits.Location = new System.Drawing.Point(9, 328);
            this.groupProduits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupProduits.Name = "groupProduits";
            this.groupProduits.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupProduits.Size = new System.Drawing.Size(672, 179);
            this.groupProduits.TabIndex = 5;
            this.groupProduits.TabStop = false;
            this.groupProduits.Text = "Articles Produits";
            // 
            // dgvProduits
            // 
            this.dgvProduits.AllowUserToAddRows = false;
            this.dgvProduits.AllowUserToDeleteRows = false;
            this.dgvProduits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduits.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProdRef,
            this.colProdDesignation,
            this.colProdQtePrevue,
            this.colProdQteProduite,
            this.colProdEcart});
            this.dgvProduits.Location = new System.Drawing.Point(10, 22);
            this.dgvProduits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProduits.Name = "dgvProduits";
            this.dgvProduits.RowHeadersVisible = false;
            this.dgvProduits.RowHeadersWidth = 51;
            this.dgvProduits.RowTemplate.Height = 24;
            this.dgvProduits.Size = new System.Drawing.Size(560, 146);
            this.dgvProduits.TabIndex = 2;
            // 
            // colProdRef
            // 
            this.colProdRef.HeaderText = "Référence";
            this.colProdRef.MinimumWidth = 6;
            this.colProdRef.Name = "colProdRef";
            // 
            // colProdDesignation
            // 
            this.colProdDesignation.FillWeight = 200F;
            this.colProdDesignation.HeaderText = "Désignation";
            this.colProdDesignation.MinimumWidth = 6;
            this.colProdDesignation.Name = "colProdDesignation";
            // 
            // colProdQtePrevue
            // 
            this.colProdQtePrevue.HeaderText = "Qte Prévue";
            this.colProdQtePrevue.MinimumWidth = 6;
            this.colProdQtePrevue.Name = "colProdQtePrevue";
            // 
            // colProdQteProduite
            // 
            this.colProdQteProduite.HeaderText = "Qte Produite";
            this.colProdQteProduite.MinimumWidth = 6;
            this.colProdQteProduite.Name = "colProdQteProduite";
            // 
            // colProdEcart
            // 
            this.colProdEcart.HeaderText = "Ecart";
            this.colProdEcart.MinimumWidth = 6;
            this.colProdEcart.Name = "colProdEcart";
            this.colProdEcart.ReadOnly = true;
            // 
            // btnProdEnlever
            // 
            this.btnProdEnlever.Location = new System.Drawing.Point(582, 59);
            this.btnProdEnlever.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProdEnlever.Name = "btnProdEnlever";
            this.btnProdEnlever.Size = new System.Drawing.Size(82, 32);
            this.btnProdEnlever.TabIndex = 1;
            this.btnProdEnlever.Text = "Enlever";
            this.btnProdEnlever.UseVisualStyleBackColor = true;
            // 
            // btnProdAjouter
            // 
            this.btnProdAjouter.Location = new System.Drawing.Point(582, 22);
            this.btnProdAjouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProdAjouter.Name = "btnProdAjouter";
            this.btnProdAjouter.Size = new System.Drawing.Size(82, 32);
            this.btnProdAjouter.TabIndex = 0;
            this.btnProdAjouter.Text = "Ajouter";
            this.btnProdAjouter.UseVisualStyleBackColor = true;
            // 
            // FicheOrdreFabrication
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(693, 521);
            this.Controls.Add(this.groupProduits);
            this.Controls.Add(this.groupMatiere);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(709, 560);
            this.Name = "FicheOrdreFabrication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ordre de fabrication";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.groupMatiere.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatiere)).EndInit();
            this.groupProduits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelOF;
        private System.Windows.Forms.TextBox txtOF;
        private System.Windows.Forms.Label labelMachine;
        private System.Windows.Forms.ComboBox cmbMachine;
        private System.Windows.Forms.ComboBox cmbResponsable;
        private System.Windows.Forms.Label labelResponsable;
        private System.Windows.Forms.TextBox txtLot;
        private System.Windows.Forms.Label labelLot;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Label labelDateDebut;
        private System.Windows.Forms.TextBox txtHeureDebut;
        private System.Windows.Forms.TextBox txtHeureFin;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.TextBox txtObservation;
        private System.Windows.Forms.Label labelObservation;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.GroupBox groupMatiere;
        private System.Windows.Forms.Button btnMatEnlever;
        private System.Windows.Forms.Button btnMatAjouter;
        private System.Windows.Forms.DataGridView dgvMatiere;
        private System.Windows.Forms.GroupBox groupProduits;
        private System.Windows.Forms.DataGridView dgvProduits;
        private System.Windows.Forms.Button btnProdEnlever;
        private System.Windows.Forms.Button btnProdAjouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatDepot;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdQtePrevue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdQteProduite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdEcart;
    }
}