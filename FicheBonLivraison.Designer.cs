﻿namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class FicheBonLivraison
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
            this.txtConditionPaiement = new System.Windows.Forms.TextBox();
            this.labelConditionPaiement = new System.Windows.Forms.Label();
            this.btnSelectClient = new System.Windows.Forms.Button();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.txtBL = new System.Windows.Forms.TextBox();
            this.labelBL = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnEnlever = new System.Windows.Forms.Button();
            this.btnAjouterCodeBarre = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnImprimerSansEP = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.dgvLignes = new System.Windows.Forms.DataGridView();
            this.colRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPUHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.groupRemise = new System.Windows.Forms.GroupBox();
            this.txtRemiseMontant = new System.Windows.Forms.TextBox();
            this.labelMontant = new System.Windows.Forms.Label();
            this.txtRemiseTaux = new System.Windows.Forms.TextBox();
            this.labelTaux = new System.Windows.Forms.Label();
            this.chkImpressionAvecRemise = new System.Windows.Forms.CheckBox();
            this.groupTotals = new System.Windows.Forms.GroupBox();
            this.txtTotalTTC = new System.Windows.Forms.TextBox();
            this.labelTTC = new System.Windows.Forms.Label();
            this.txtTotalTVA = new System.Windows.Forms.TextBox();
            this.labelTVA = new System.Windows.Forms.Label();
            this.txtTotalBrut = new System.Windows.Forms.TextBox();
            this.labelBrut = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLignes)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.groupRemise.SuspendLayout();
            this.groupTotals.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.txtConditionPaiement);
            this.panelHeader.Controls.Add(this.labelConditionPaiement);
            this.panelHeader.Controls.Add(this.btnSelectClient);
            this.panelHeader.Controls.Add(this.txtClientName);
            this.panelHeader.Controls.Add(this.labelClient);
            this.panelHeader.Controls.Add(this.txtBL);
            this.panelHeader.Controls.Add(this.labelBL);
            this.panelHeader.Controls.Add(this.dtpDate);
            this.panelHeader.Controls.Add(this.labelDate);
            this.panelHeader.Location = new System.Drawing.Point(9, 10);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(860, 89);
            this.panelHeader.TabIndex = 0;
            // 
            // txtConditionPaiement
            // 
            this.txtConditionPaiement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConditionPaiement.Location = new System.Drawing.Point(128, 63);
            this.txtConditionPaiement.Margin = new System.Windows.Forms.Padding(2);
            this.txtConditionPaiement.Name = "txtConditionPaiement";
            this.txtConditionPaiement.Size = new System.Drawing.Size(121, 21);
            this.txtConditionPaiement.TabIndex = 8;
            // 
            // labelConditionPaiement
            // 
            this.labelConditionPaiement.AutoSize = true;
            this.labelConditionPaiement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConditionPaiement.Location = new System.Drawing.Point(18, 66);
            this.labelConditionPaiement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConditionPaiement.Name = "labelConditionPaiement";
            this.labelConditionPaiement.Size = new System.Drawing.Size(125, 15);
            this.labelConditionPaiement.TabIndex = 7;
            this.labelConditionPaiement.Text = "Condition de Paiment";
            // 
            // btnSelectClient
            // 
            this.btnSelectClient.Location = new System.Drawing.Point(528, 37);
            this.btnSelectClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectClient.Name = "btnSelectClient";
            this.btnSelectClient.Size = new System.Drawing.Size(30, 21);
            this.btnSelectClient.TabIndex = 6;
            this.btnSelectClient.UseVisualStyleBackColor = true;
            // 
            // txtClientName
            // 
            this.txtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.Location = new System.Drawing.Point(339, 38);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(186, 21);
            this.txtClientName.TabIndex = 5;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.Location = new System.Drawing.Point(267, 41);
            this.labelClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(38, 15);
            this.labelClient.TabIndex = 4;
            this.labelClient.Text = "Client";
            // 
            // txtBL
            // 
            this.txtBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBL.Location = new System.Drawing.Point(339, 11);
            this.txtBL.Margin = new System.Windows.Forms.Padding(2);
            this.txtBL.Name = "txtBL";
            this.txtBL.ReadOnly = true;
            this.txtBL.Size = new System.Drawing.Size(220, 21);
            this.txtBL.TabIndex = 3;
            // 
            // labelBL
            // 
            this.labelBL.AutoSize = true;
            this.labelBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBL.Location = new System.Drawing.Point(267, 14);
            this.labelBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBL.Name = "labelBL";
            this.labelBL.Size = new System.Drawing.Size(39, 15);
            this.labelBL.TabIndex = 2;
            this.labelBL.Text = "N° BL";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(52, 11);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(196, 21);
            this.dtpDate.TabIndex = 1;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(18, 14);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 15);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(884, 10);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 32);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(884, 48);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(90, 32);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(884, 114);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(90, 32);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnEnlever
            // 
            this.btnEnlever.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnlever.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnlever.Location = new System.Drawing.Point(884, 151);
            this.btnEnlever.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnlever.Name = "btnEnlever";
            this.btnEnlever.Size = new System.Drawing.Size(90, 32);
            this.btnEnlever.TabIndex = 4;
            this.btnEnlever.Text = "Enlever";
            this.btnEnlever.UseVisualStyleBackColor = true;
            // 
            // btnAjouterCodeBarre
            // 
            this.btnAjouterCodeBarre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterCodeBarre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterCodeBarre.Location = new System.Drawing.Point(884, 188);
            this.btnAjouterCodeBarre.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouterCodeBarre.Name = "btnAjouterCodeBarre";
            this.btnAjouterCodeBarre.Size = new System.Drawing.Size(90, 44);
            this.btnAjouterCodeBarre.TabIndex = 5;
            this.btnAjouterCodeBarre.Text = "Ajouter Code à barre";
            this.btnAjouterCodeBarre.UseVisualStyleBackColor = true;
            this.btnAjouterCodeBarre.Click += new System.EventHandler(this.btnAjouterCodeBarre_Click);
            // 
            // btnImprimer
            // 
            this.btnImprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.Location = new System.Drawing.Point(884, 236);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(90, 32);
            this.btnImprimer.TabIndex = 6;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            // 
            // btnImprimerSansEP
            // 
            this.btnImprimerSansEP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimerSansEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerSansEP.Location = new System.Drawing.Point(884, 273);
            this.btnImprimerSansEP.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimerSansEP.Name = "btnImprimerSansEP";
            this.btnImprimerSansEP.Size = new System.Drawing.Size(90, 44);
            this.btnImprimerSansEP.TabIndex = 7;
            this.btnImprimerSansEP.Text = "Imprimer sans E.P";
            this.btnImprimerSansEP.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(881, 463);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(90, 32);
            this.btnFermer.TabIndex = 8;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // dgvLignes
            // 
            this.dgvLignes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLignes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLignes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLignes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLignes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLignes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRef,
            this.colDesignation,
            this.colQte,
            this.colPUHT,
            this.colTVA,
            this.colRemise,
            this.colTotal});
            this.dgvLignes.EnableHeadersVisualStyles = false;
            this.dgvLignes.Location = new System.Drawing.Point(9, 114);
            this.dgvLignes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLignes.Name = "dgvLignes";
            this.dgvLignes.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvLignes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLignes.RowTemplate.Height = 24;
            this.dgvLignes.Size = new System.Drawing.Size(860, 381);
            this.dgvLignes.TabIndex = 9;
            // 
            // colRef
            // 
            this.colRef.HeaderText = "Référence";
            this.colRef.MinimumWidth = 6;
            this.colRef.Name = "colRef";
            // 
            // colDesignation
            // 
            this.colDesignation.FillWeight = 150F;
            this.colDesignation.HeaderText = "Désignation";
            this.colDesignation.MinimumWidth = 6;
            this.colDesignation.Name = "colDesignation";
            // 
            // colQte
            // 
            this.colQte.HeaderText = "Qte";
            this.colQte.MinimumWidth = 6;
            this.colQte.Name = "colQte";
            // 
            // colPUHT
            // 
            this.colPUHT.HeaderText = "P.U HT";
            this.colPUHT.MinimumWidth = 6;
            this.colPUHT.Name = "colPUHT";
            // 
            // colTVA
            // 
            this.colTVA.HeaderText = "TVA";
            this.colTVA.MinimumWidth = 6;
            this.colTVA.Name = "colTVA";
            // 
            // colRemise
            // 
            this.colRemise.HeaderText = "R (%)";
            this.colRemise.MinimumWidth = 6;
            this.colRemise.Name = "colRemise";
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.groupRemise);
            this.panelFooter.Controls.Add(this.chkImpressionAvecRemise);
            this.panelFooter.Controls.Add(this.groupTotals);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 507);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(983, 107);
            this.panelFooter.TabIndex = 10;
            // 
            // groupRemise
            // 
            this.groupRemise.Controls.Add(this.txtRemiseMontant);
            this.groupRemise.Controls.Add(this.labelMontant);
            this.groupRemise.Controls.Add(this.txtRemiseTaux);
            this.groupRemise.Controls.Add(this.labelTaux);
            this.groupRemise.Location = new System.Drawing.Point(9, 8);
            this.groupRemise.Margin = new System.Windows.Forms.Padding(2);
            this.groupRemise.Name = "groupRemise";
            this.groupRemise.Padding = new System.Windows.Forms.Padding(2);
            this.groupRemise.Size = new System.Drawing.Size(165, 73);
            this.groupRemise.TabIndex = 2;
            this.groupRemise.TabStop = false;
            this.groupRemise.Text = "Remise";
            // 
            // txtRemiseMontant
            // 
            this.txtRemiseMontant.Location = new System.Drawing.Point(68, 45);
            this.txtRemiseMontant.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemiseMontant.Name = "txtRemiseMontant";
            this.txtRemiseMontant.Size = new System.Drawing.Size(91, 20);
            this.txtRemiseMontant.TabIndex = 3;
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.Location = new System.Drawing.Point(11, 47);
            this.labelMontant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(46, 13);
            this.labelMontant.TabIndex = 2;
            this.labelMontant.Text = "Montant";
            // 
            // txtRemiseTaux
            // 
            this.txtRemiseTaux.Location = new System.Drawing.Point(68, 20);
            this.txtRemiseTaux.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemiseTaux.Name = "txtRemiseTaux";
            this.txtRemiseTaux.Size = new System.Drawing.Size(91, 20);
            this.txtRemiseTaux.TabIndex = 1;
            // 
            // labelTaux
            // 
            this.labelTaux.AutoSize = true;
            this.labelTaux.Location = new System.Drawing.Point(11, 23);
            this.labelTaux.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTaux.Name = "labelTaux";
            this.labelTaux.Size = new System.Drawing.Size(31, 13);
            this.labelTaux.TabIndex = 0;
            this.labelTaux.Text = "Taux";
            // 
            // chkImpressionAvecRemise
            // 
            this.chkImpressionAvecRemise.AutoSize = true;
            this.chkImpressionAvecRemise.Location = new System.Drawing.Point(11, 86);
            this.chkImpressionAvecRemise.Margin = new System.Windows.Forms.Padding(2);
            this.chkImpressionAvecRemise.Name = "chkImpressionAvecRemise";
            this.chkImpressionAvecRemise.Size = new System.Drawing.Size(137, 17);
            this.chkImpressionAvecRemise.TabIndex = 1;
            this.chkImpressionAvecRemise.Text = "Impression Avec remise";
            this.chkImpressionAvecRemise.UseVisualStyleBackColor = true;
            // 
            // groupTotals
            // 
            this.groupTotals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupTotals.Controls.Add(this.txtTotalTTC);
            this.groupTotals.Controls.Add(this.labelTTC);
            this.groupTotals.Controls.Add(this.txtTotalTVA);
            this.groupTotals.Controls.Add(this.labelTVA);
            this.groupTotals.Controls.Add(this.txtTotalBrut);
            this.groupTotals.Controls.Add(this.labelBrut);
            this.groupTotals.Location = new System.Drawing.Point(696, 8);
            this.groupTotals.Margin = new System.Windows.Forms.Padding(2);
            this.groupTotals.Name = "groupTotals";
            this.groupTotals.Padding = new System.Windows.Forms.Padding(2);
            this.groupTotals.Size = new System.Drawing.Size(278, 89);
            this.groupTotals.TabIndex = 0;
            this.groupTotals.TabStop = false;
            // 
            // txtTotalTTC
            // 
            this.txtTotalTTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTTC.Location = new System.Drawing.Point(105, 61);
            this.txtTotalTTC.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalTTC.Name = "txtTotalTTC";
            this.txtTotalTTC.ReadOnly = true;
            this.txtTotalTTC.Size = new System.Drawing.Size(166, 19);
            this.txtTotalTTC.TabIndex = 5;
            // 
            // labelTTC
            // 
            this.labelTTC.AutoSize = true;
            this.labelTTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTTC.Location = new System.Drawing.Point(11, 63);
            this.labelTTC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTTC.Name = "labelTTC";
            this.labelTTC.Size = new System.Drawing.Size(72, 13);
            this.labelTTC.TabIndex = 4;
            this.labelTTC.Text = "Total (TTC)";
            // 
            // txtTotalTVA
            // 
            this.txtTotalTVA.Location = new System.Drawing.Point(105, 37);
            this.txtTotalTVA.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalTVA.Name = "txtTotalTVA";
            this.txtTotalTVA.ReadOnly = true;
            this.txtTotalTVA.Size = new System.Drawing.Size(166, 20);
            this.txtTotalTVA.TabIndex = 3;
            // 
            // labelTVA
            // 
            this.labelTVA.AutoSize = true;
            this.labelTVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTVA.Location = new System.Drawing.Point(11, 39);
            this.labelTVA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTVA.Name = "labelTVA";
            this.labelTVA.Size = new System.Drawing.Size(64, 13);
            this.labelTVA.TabIndex = 2;
            this.labelTVA.Text = "Total TVA";
            // 
            // txtTotalBrut
            // 
            this.txtTotalBrut.Location = new System.Drawing.Point(105, 12);
            this.txtTotalBrut.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalBrut.Name = "txtTotalBrut";
            this.txtTotalBrut.ReadOnly = true;
            this.txtTotalBrut.Size = new System.Drawing.Size(166, 20);
            this.txtTotalBrut.TabIndex = 1;
            // 
            // labelBrut
            // 
            this.labelBrut.AutoSize = true;
            this.labelBrut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrut.Location = new System.Drawing.Point(11, 15);
            this.labelBrut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBrut.Name = "labelBrut";
            this.labelBrut.Size = new System.Drawing.Size(91, 13);
            this.labelBrut.TabIndex = 0;
            this.labelBrut.Text = "Total brut (HT)";
            // 
            // FicheBonLivraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 614);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.dgvLignes);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnImprimerSansEP);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnAjouterCodeBarre);
            this.Controls.Add(this.btnEnlever);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(709, 560);
            this.Name = "FicheBonLivraison";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fiche Bon de Livraison";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLignes)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.groupRemise.ResumeLayout(false);
            this.groupRemise.PerformLayout();
            this.groupTotals.ResumeLayout(false);
            this.groupTotals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtBL;
        private System.Windows.Forms.Label labelBL;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Button btnSelectClient;
        private System.Windows.Forms.TextBox txtConditionPaiement;
        private System.Windows.Forms.Label labelConditionPaiement;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnEnlever;
        private System.Windows.Forms.Button btnAjouterCodeBarre;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnImprimerSansEP;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.DataGridView dgvLignes;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.GroupBox groupTotals;
        private System.Windows.Forms.Label labelBrut;
        private System.Windows.Forms.TextBox txtTotalBrut;
        private System.Windows.Forms.TextBox txtTotalTVA;
        private System.Windows.Forms.Label labelTVA;
        private System.Windows.Forms.TextBox txtTotalTTC;
        private System.Windows.Forms.Label labelTTC;
        private System.Windows.Forms.CheckBox chkImpressionAvecRemise;
        private System.Windows.Forms.GroupBox groupRemise;
        private System.Windows.Forms.Label labelTaux;
        private System.Windows.Forms.TextBox txtRemiseTaux;
        private System.Windows.Forms.TextBox txtRemiseMontant;
        private System.Windows.Forms.Label labelMontant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPUHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemise;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    }
}