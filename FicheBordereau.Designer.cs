namespace TAPTAGPOS
{
    partial class FicheBordereau
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
            this.groupBordereau = new System.Windows.Forms.GroupBox();
            this.txtNombreCaisse = new System.Windows.Forms.TextBox();
            this.labelNombreCaisse = new System.Windows.Forms.Label();
            this.txtNumBordereau = new System.Windows.Forms.TextBox();
            this.labelNumBordereau = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.groupClient = new System.Windows.Forms.GroupBox();
            this.btnSelectClient = new System.Windows.Forms.Button();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.groupTransport = new System.Windows.Forms.GroupBox();
            this.cmbTransport = new System.Windows.Forms.ComboBox();
            this.groupPaiement = new System.Windows.Forms.GroupBox();
            this.rbCredit = new System.Windows.Forms.RadioButton();
            this.rbRemboursement = new System.Windows.Forms.RadioButton();
            this.rbContreCheque = new System.Windows.Forms.RadioButton();
            this.groupBonLivraison = new System.Windows.Forms.GroupBox();
            this.dgvLignes = new System.Windows.Forms.DataGridView();
            this.colRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.txtTotalTTC = new System.Windows.Forms.TextBox();
            this.labelTTC = new System.Windows.Forms.Label();
            this.txtTVA = new System.Windows.Forms.TextBox();
            this.labelTVA = new System.Windows.Forms.Label();
            this.txtTotalHT = new System.Windows.Forms.TextBox();
            this.labelHT = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBordereau.SuspendLayout();
            this.groupClient.SuspendLayout();
            this.groupTransport.SuspendLayout();
            this.groupPaiement.SuspendLayout();
            this.groupBonLivraison.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLignes)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBordereau
            // 
            this.groupBordereau.Controls.Add(this.txtNombreCaisse);
            this.groupBordereau.Controls.Add(this.labelNombreCaisse);
            this.groupBordereau.Controls.Add(this.txtNumBordereau);
            this.groupBordereau.Controls.Add(this.labelNumBordereau);
            this.groupBordereau.Controls.Add(this.dtpDate);
            this.groupBordereau.Controls.Add(this.labelDate);
            this.groupBordereau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupBordereau.Location = new System.Drawing.Point(9, 10);
            this.groupBordereau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBordereau.Name = "groupBordereau";
            this.groupBordereau.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBordereau.Size = new System.Drawing.Size(831, 57);
            this.groupBordereau.TabIndex = 0;
            this.groupBordereau.TabStop = false;
            this.groupBordereau.Text = "Bordereau";
            // 
            // txtNombreCaisse
            // 
            this.txtNombreCaisse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNombreCaisse.Location = new System.Drawing.Point(562, 24);
            this.txtNombreCaisse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreCaisse.Name = "txtNombreCaisse";
            this.txtNombreCaisse.Size = new System.Drawing.Size(144, 21);
            this.txtNombreCaisse.TabIndex = 5;
            // 
            // labelNombreCaisse
            // 
            this.labelNombreCaisse.AutoSize = true;
            this.labelNombreCaisse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelNombreCaisse.Location = new System.Drawing.Point(465, 27);
            this.labelNombreCaisse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreCaisse.Name = "labelNombreCaisse";
            this.labelNombreCaisse.Size = new System.Drawing.Size(109, 15);
            this.labelNombreCaisse.TabIndex = 4;
            this.labelNombreCaisse.Text = "Nombre de Caisse";
            // 
            // txtNumBordereau
            // 
            this.txtNumBordereau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNumBordereau.Location = new System.Drawing.Point(300, 24);
            this.txtNumBordereau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumBordereau.Name = "txtNumBordereau";
            this.txtNumBordereau.ReadOnly = true;
            this.txtNumBordereau.Size = new System.Drawing.Size(144, 21);
            this.txtNumBordereau.TabIndex = 3;
            // 
            // labelNumBordereau
            // 
            this.labelNumBordereau.AutoSize = true;
            this.labelNumBordereau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelNumBordereau.Location = new System.Drawing.Point(225, 27);
            this.labelNumBordereau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumBordereau.Name = "labelNumBordereau";
            this.labelNumBordereau.Size = new System.Drawing.Size(82, 15);
            this.labelNumBordereau.TabIndex = 2;
            this.labelNumBordereau.Text = "N° Bordereau";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(52, 24);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(144, 21);
            this.dtpDate.TabIndex = 1;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelDate.Location = new System.Drawing.Point(19, 27);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 15);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date";
            // 
            // groupClient
            // 
            this.groupClient.Controls.Add(this.btnSelectClient);
            this.groupClient.Controls.Add(this.cmbClient);
            this.groupClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupClient.Location = new System.Drawing.Point(9, 73);
            this.groupClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupClient.Name = "groupClient";
            this.groupClient.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupClient.Size = new System.Drawing.Size(236, 65);
            this.groupClient.TabIndex = 1;
            this.groupClient.TabStop = false;
            this.groupClient.Text = "Client";
            // 
            // btnSelectClient
            // 
            this.btnSelectClient.Location = new System.Drawing.Point(195, 26);
            this.btnSelectClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectClient.Name = "btnSelectClient";
            this.btnSelectClient.Size = new System.Drawing.Size(30, 23);
            this.btnSelectClient.TabIndex = 1;
            this.btnSelectClient.UseVisualStyleBackColor = true;
            // 
            // cmbClient
            // 
            this.cmbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(11, 27);
            this.cmbClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(180, 23);
            this.cmbClient.TabIndex = 0;
            // 
            // groupTransport
            // 
            this.groupTransport.Controls.Add(this.cmbTransport);
            this.groupTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupTransport.Location = new System.Drawing.Point(250, 73);
            this.groupTransport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupTransport.Name = "groupTransport";
            this.groupTransport.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupTransport.Size = new System.Drawing.Size(236, 65);
            this.groupTransport.TabIndex = 2;
            this.groupTransport.TabStop = false;
            this.groupTransport.Text = "Transport";
            // 
            // cmbTransport
            // 
            this.cmbTransport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbTransport.FormattingEnabled = true;
            this.cmbTransport.Location = new System.Drawing.Point(11, 27);
            this.cmbTransport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTransport.Name = "cmbTransport";
            this.cmbTransport.Size = new System.Drawing.Size(215, 23);
            this.cmbTransport.TabIndex = 0;
            // 
            // groupPaiement
            // 
            this.groupPaiement.Controls.Add(this.rbCredit);
            this.groupPaiement.Controls.Add(this.rbRemboursement);
            this.groupPaiement.Controls.Add(this.rbContreCheque);
            this.groupPaiement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupPaiement.Location = new System.Drawing.Point(490, 73);
            this.groupPaiement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupPaiement.Name = "groupPaiement";
            this.groupPaiement.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupPaiement.Size = new System.Drawing.Size(350, 65);
            this.groupPaiement.TabIndex = 3;
            this.groupPaiement.TabStop = false;
            this.groupPaiement.Text = "Moyen de paiement";
            // 
            // rbCredit
            // 
            this.rbCredit.AutoSize = true;
            this.rbCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbCredit.Location = new System.Drawing.Point(275, 28);
            this.rbCredit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCredit.Name = "rbCredit";
            this.rbCredit.Size = new System.Drawing.Size(57, 19);
            this.rbCredit.TabIndex = 2;
            this.rbCredit.TabStop = true;
            this.rbCredit.Text = "Crédit";
            this.rbCredit.UseVisualStyleBackColor = true;
            // 
            // rbRemboursement
            // 
            this.rbRemboursement.AutoSize = true;
            this.rbRemboursement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbRemboursement.Location = new System.Drawing.Point(119, 28);
            this.rbRemboursement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbRemboursement.Name = "rbRemboursement";
            this.rbRemboursement.Size = new System.Drawing.Size(152, 19);
            this.rbRemboursement.TabIndex = 1;
            this.rbRemboursement.TabStop = true;
            this.rbRemboursement.Text = "Contre remboursement";
            this.rbRemboursement.UseVisualStyleBackColor = true;
            // 
            // rbContreCheque
            // 
            this.rbContreCheque.AutoSize = true;
            this.rbContreCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbContreCheque.Location = new System.Drawing.Point(11, 28);
            this.rbContreCheque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbContreCheque.Name = "rbContreCheque";
            this.rbContreCheque.Size = new System.Drawing.Size(105, 19);
            this.rbContreCheque.TabIndex = 0;
            this.rbContreCheque.TabStop = true;
            this.rbContreCheque.Text = "Contre chèque";
            this.rbContreCheque.UseVisualStyleBackColor = true;
            // 
            // groupBonLivraison
            // 
            this.groupBonLivraison.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBonLivraison.Controls.Add(this.dgvLignes);
            this.groupBonLivraison.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupBonLivraison.Location = new System.Drawing.Point(9, 143);
            this.groupBonLivraison.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBonLivraison.Name = "groupBonLivraison";
            this.groupBonLivraison.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBonLivraison.Size = new System.Drawing.Size(833, 298);
            this.groupBonLivraison.TabIndex = 4;
            this.groupBonLivraison.TabStop = false;
            this.groupBonLivraison.Text = "Bon de livraison";
            // 
            // dgvLignes
            // 
            this.dgvLignes.AllowUserToAddRows = false;
            this.dgvLignes.AllowUserToDeleteRows = false;
            this.dgvLignes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLignes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLignes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLignes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLignes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRef,
            this.colDesignation,
            this.colQte,
            this.colPrix,
            this.colTotal});
            this.dgvLignes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLignes.EnableHeadersVisualStyles = false;
            this.dgvLignes.Location = new System.Drawing.Point(2, 14);
            this.dgvLignes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLignes.Name = "dgvLignes";
            this.dgvLignes.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvLignes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLignes.RowTemplate.Height = 24;
            this.dgvLignes.Size = new System.Drawing.Size(829, 282);
            this.dgvLignes.TabIndex = 0;
            // 
            // colRef
            // 
            this.colRef.HeaderText = "Référence";
            this.colRef.MinimumWidth = 6;
            this.colRef.Name = "colRef";
            // 
            // colDesignation
            // 
            this.colDesignation.FillWeight = 200F;
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
            // colPrix
            // 
            this.colPrix.HeaderText = "Prix";
            this.colPrix.MinimumWidth = 6;
            this.colPrix.Name = "colPrix";
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
            this.panelFooter.Controls.Add(this.txtTotalTTC);
            this.panelFooter.Controls.Add(this.labelTTC);
            this.panelFooter.Controls.Add(this.txtTVA);
            this.panelFooter.Controls.Add(this.labelTVA);
            this.panelFooter.Controls.Add(this.txtTotalHT);
            this.panelFooter.Controls.Add(this.labelHT);
            this.panelFooter.Controls.Add(this.btnFermer);
            this.panelFooter.Controls.Add(this.btnImprimer);
            this.panelFooter.Controls.Add(this.btnOK);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 452);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(853, 54);
            this.panelFooter.TabIndex = 5;
            // 
            // txtTotalTTC
            // 
            this.txtTotalTTC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalTTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtTotalTTC.Location = new System.Drawing.Point(715, 24);
            this.txtTotalTTC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalTTC.Name = "txtTotalTTC";
            this.txtTotalTTC.ReadOnly = true;
            this.txtTotalTTC.Size = new System.Drawing.Size(128, 21);
            this.txtTotalTTC.TabIndex = 8;
            // 
            // labelTTC
            // 
            this.labelTTC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTTC.AutoSize = true;
            this.labelTTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelTTC.Location = new System.Drawing.Point(718, 7);
            this.labelTTC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTTC.Name = "labelTTC";
            this.labelTTC.Size = new System.Drawing.Size(68, 15);
            this.labelTTC.TabIndex = 7;
            this.labelTTC.Text = "Total TTC";
            // 
            // txtTVA
            // 
            this.txtTVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtTVA.Location = new System.Drawing.Point(583, 24);
            this.txtTVA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTVA.Name = "txtTVA";
            this.txtTVA.ReadOnly = true;
            this.txtTVA.Size = new System.Drawing.Size(128, 21);
            this.txtTVA.TabIndex = 6;
            // 
            // labelTVA
            // 
            this.labelTVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTVA.AutoSize = true;
            this.labelTVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelTVA.Location = new System.Drawing.Point(586, 7);
            this.labelTVA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTVA.Name = "labelTVA";
            this.labelTVA.Size = new System.Drawing.Size(65, 15);
            this.labelTVA.TabIndex = 5;
            this.labelTVA.Text = "Total Tva";
            // 
            // txtTotalHT
            // 
            this.txtTotalHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtTotalHT.Location = new System.Drawing.Point(451, 24);
            this.txtTotalHT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalHT.Name = "txtTotalHT";
            this.txtTotalHT.ReadOnly = true;
            this.txtTotalHT.Size = new System.Drawing.Size(128, 21);
            this.txtTotalHT.TabIndex = 4;
            // 
            // labelHT
            // 
            this.labelHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHT.AutoSize = true;
            this.labelHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelHT.Location = new System.Drawing.Point(454, 7);
            this.labelHT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHT.Name = "labelHT";
            this.labelHT.Size = new System.Drawing.Size(61, 15);
            this.labelHT.TabIndex = 3;
            this.labelHT.Text = "Total HT";
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnFermer.Location = new System.Drawing.Point(198, 11);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(90, 32);
            this.btnFermer.TabIndex = 2;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // btnImprimer
            // 
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnImprimer.Location = new System.Drawing.Point(104, 11);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(90, 32);
            this.btnImprimer.TabIndex = 1;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnOK.Location = new System.Drawing.Point(9, 11);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 32);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // FicheBordereau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 506);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.groupBonLivraison);
            this.Controls.Add(this.groupPaiement);
            this.Controls.Add(this.groupTransport);
            this.Controls.Add(this.groupClient);
            this.Controls.Add(this.groupBordereau);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(754, 495);
            this.Name = "FicheBordereau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bordereau";
            this.groupBordereau.ResumeLayout(false);
            this.groupBordereau.PerformLayout();
            this.groupClient.ResumeLayout(false);
            this.groupTransport.ResumeLayout(false);
            this.groupPaiement.ResumeLayout(false);
            this.groupPaiement.PerformLayout();
            this.groupBonLivraison.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLignes)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBordereau;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label labelNumBordereau;
        private System.Windows.Forms.TextBox txtNumBordereau;
        private System.Windows.Forms.Label labelNombreCaisse;
        private System.Windows.Forms.TextBox txtNombreCaisse;
        private System.Windows.Forms.GroupBox groupClient;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Button btnSelectClient;
        private System.Windows.Forms.GroupBox groupTransport;
        private System.Windows.Forms.ComboBox cmbTransport;
        private System.Windows.Forms.GroupBox groupPaiement;
        private System.Windows.Forms.RadioButton rbContreCheque;
        private System.Windows.Forms.RadioButton rbRemboursement;
        private System.Windows.Forms.RadioButton rbCredit;
        private System.Windows.Forms.GroupBox groupBonLivraison;
        private System.Windows.Forms.DataGridView dgvLignes;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label labelHT;
        private System.Windows.Forms.TextBox txtTotalHT;
        private System.Windows.Forms.TextBox txtTVA;
        private System.Windows.Forms.Label labelTVA;
        private System.Windows.Forms.TextBox txtTotalTTC;
        private System.Windows.Forms.Label labelTTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    }
}