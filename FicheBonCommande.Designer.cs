namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class FicheBonCommande
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelFournisseur = new System.Windows.Forms.Label();
            this.txtBC = new System.Windows.Forms.TextBox();
            this.labelBC = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAjouterLigne = new System.Windows.Forms.ToolStripButton();
            this.btnSupprimerLigne = new System.Windows.Forms.ToolStripButton();
            this.dgvLignes = new System.Windows.Forms.DataGridView();
            this.colRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.txtTotalTTC = new System.Windows.Forms.TextBox();
            this.labelTTC = new System.Windows.Forms.Label();
            this.txtTva = new System.Windows.Forms.TextBox();
            this.labelTva = new System.Windows.Forms.Label();
            this.txtTotalHT = new System.Windows.Forms.TextBox();
            this.labelHT = new System.Windows.Forms.Label();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnImprimerSansEP = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.cmbSupplier = new Bunifu.UI.WinForms.BunifuDropdown();
            this.panelHeader.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLignes)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.cmbSupplier);
            this.panelHeader.Controls.Add(this.labelFournisseur);
            this.panelHeader.Controls.Add(this.txtBC);
            this.panelHeader.Controls.Add(this.labelBC);
            this.panelHeader.Controls.Add(this.dtpDate);
            this.panelHeader.Controls.Add(this.labelDate);
            this.panelHeader.Location = new System.Drawing.Point(9, 10);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(570, 73);
            this.panelHeader.TabIndex = 0;
            // 
            // labelFournisseur
            // 
            this.labelFournisseur.AutoSize = true;
            this.labelFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFournisseur.Location = new System.Drawing.Point(267, 41);
            this.labelFournisseur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFournisseur.Name = "labelFournisseur";
            this.labelFournisseur.Size = new System.Drawing.Size(72, 15);
            this.labelFournisseur.TabIndex = 4;
            this.labelFournisseur.Text = "Fournisseur";
            // 
            // txtBC
            // 
            this.txtBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBC.Location = new System.Drawing.Point(344, 7);
            this.txtBC.Margin = new System.Windows.Forms.Padding(2);
            this.txtBC.Name = "txtBC";
            this.txtBC.ReadOnly = true;
            this.txtBC.Size = new System.Drawing.Size(220, 21);
            this.txtBC.TabIndex = 3;
            // 
            // labelBC
            // 
            this.labelBC.AutoSize = true;
            this.labelBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBC.Location = new System.Drawing.Point(267, 14);
            this.labelBC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBC.Name = "labelBC";
            this.labelBC.Size = new System.Drawing.Size(40, 15);
            this.labelBC.TabIndex = 2;
            this.labelBC.Text = "N° BC";
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
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(813, 20);
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
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(813, 58);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(90, 32);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAjouterLigne,
            this.btnSupprimerLigne});
            this.toolStrip1.Location = new System.Drawing.Point(9, 85);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(201, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAjouterLigne
            // 
            this.btnAjouterLigne.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAjouterLigne.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAjouterLigne.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAjouterLigne.Name = "btnAjouterLigne";
            this.btnAjouterLigne.Size = new System.Drawing.Size(86, 22);
            this.btnAjouterLigne.Text = "Ajouter Ligne";
            // 
            // btnSupprimerLigne
            // 
            this.btnSupprimerLigne.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSupprimerLigne.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSupprimerLigne.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSupprimerLigne.Name = "btnSupprimerLigne";
            this.btnSupprimerLigne.Size = new System.Drawing.Size(103, 22);
            this.btnSupprimerLigne.Text = "Supprimer Ligne";
            // 
            // dgvLignes
            // 
            this.dgvLignes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLignes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLignes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLignes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvLignes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLignes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRef,
            this.colDesignation,
            this.colQte,
            this.colPrix,
            this.colTva,
            this.colTotal});
            this.dgvLignes.EnableHeadersVisualStyles = false;
            this.dgvLignes.Location = new System.Drawing.Point(9, 110);
            this.dgvLignes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLignes.Name = "dgvLignes";
            this.dgvLignes.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dgvLignes.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvLignes.RowTemplate.Height = 24;
            this.dgvLignes.Size = new System.Drawing.Size(894, 292);
            this.dgvLignes.TabIndex = 4;
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
            this.colPrix.HeaderText = "Prix ht";
            this.colPrix.MinimumWidth = 6;
            this.colPrix.Name = "colPrix";
            // 
            // colTva
            // 
            this.colTva.HeaderText = "Tva";
            this.colTva.MinimumWidth = 6;
            this.colTva.Name = "colTva";
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
            this.panelFooter.Controls.Add(this.txtTva);
            this.panelFooter.Controls.Add(this.labelTva);
            this.panelFooter.Controls.Add(this.txtTotalHT);
            this.panelFooter.Controls.Add(this.labelHT);
            this.panelFooter.Controls.Add(this.btnImprimer);
            this.panelFooter.Controls.Add(this.btnImprimerSansEP);
            this.panelFooter.Controls.Add(this.btnFermer);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 406);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(915, 50);
            this.panelFooter.TabIndex = 5;
            // 
            // txtTotalTTC
            // 
            this.txtTotalTTC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalTTC.Location = new System.Drawing.Point(799, 13);
            this.txtTotalTTC.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalTTC.Name = "txtTotalTTC";
            this.txtTotalTTC.ReadOnly = true;
            this.txtTotalTTC.Size = new System.Drawing.Size(106, 20);
            this.txtTotalTTC.TabIndex = 8;
            this.txtTotalTTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTTC
            // 
            this.labelTTC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTTC.AutoSize = true;
            this.labelTTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTTC.Location = new System.Drawing.Point(733, 15);
            this.labelTTC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTTC.Name = "labelTTC";
            this.labelTTC.Size = new System.Drawing.Size(64, 13);
            this.labelTTC.TabIndex = 7;
            this.labelTTC.Text = "Total TTC";
            // 
            // txtTva
            // 
            this.txtTva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTva.Location = new System.Drawing.Point(623, 13);
            this.txtTva.Margin = new System.Windows.Forms.Padding(2);
            this.txtTva.Name = "txtTva";
            this.txtTva.ReadOnly = true;
            this.txtTva.Size = new System.Drawing.Size(106, 20);
            this.txtTva.TabIndex = 6;
            this.txtTva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTva
            // 
            this.labelTva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTva.AutoSize = true;
            this.labelTva.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTva.Location = new System.Drawing.Point(594, 15);
            this.labelTva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTva.Name = "labelTva";
            this.labelTva.Size = new System.Drawing.Size(29, 13);
            this.labelTva.TabIndex = 5;
            this.labelTva.Text = "Tva";
            // 
            // txtTotalHT
            // 
            this.txtTotalHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalHT.Location = new System.Drawing.Point(485, 13);
            this.txtTotalHT.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalHT.Name = "txtTotalHT";
            this.txtTotalHT.ReadOnly = true;
            this.txtTotalHT.Size = new System.Drawing.Size(106, 20);
            this.txtTotalHT.TabIndex = 4;
            this.txtTotalHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelHT
            // 
            this.labelHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHT.AutoSize = true;
            this.labelHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHT.Location = new System.Drawing.Point(425, 15);
            this.labelHT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHT.Name = "labelHT";
            this.labelHT.Size = new System.Drawing.Size(57, 13);
            this.labelHT.TabIndex = 3;
            this.labelHT.Text = "Total HT";
            // 
            // btnImprimer
            // 
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.Location = new System.Drawing.Point(9, 2);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(75, 45);
            this.btnImprimer.TabIndex = 0;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // btnImprimerSansEP
            // 
            this.btnImprimerSansEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerSansEP.Location = new System.Drawing.Point(88, 2);
            this.btnImprimerSansEP.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimerSansEP.Name = "btnImprimerSansEP";
            this.btnImprimerSansEP.Size = new System.Drawing.Size(75, 45);
            this.btnImprimerSansEP.TabIndex = 1;
            this.btnImprimerSansEP.Text = "Imprimer sans E.P";
            this.btnImprimerSansEP.UseVisualStyleBackColor = true;
            this.btnImprimerSansEP.Click += new System.EventHandler(this.btnImprimerSansEP_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(168, 2);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 45);
            this.btnFermer.TabIndex = 2;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.BackColor = System.Drawing.Color.Transparent;
            this.cmbSupplier.BackgroundColor = System.Drawing.Color.White;
            this.cmbSupplier.BorderColor = System.Drawing.Color.Silver;
            this.cmbSupplier.BorderRadius = 1;
            this.cmbSupplier.Color = System.Drawing.Color.Silver;
            this.cmbSupplier.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbSupplier.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbSupplier.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbSupplier.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbSupplier.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbSupplier.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSupplier.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbSupplier.FillDropDown = true;
            this.cmbSupplier.FillIndicator = false;
            this.cmbSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbSupplier.ForeColor = System.Drawing.Color.Black;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Icon = null;
            this.cmbSupplier.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbSupplier.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbSupplier.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbSupplier.IndicatorThickness = 2;
            this.cmbSupplier.IsDropdownOpened = false;
            this.cmbSupplier.ItemBackColor = System.Drawing.Color.White;
            this.cmbSupplier.ItemBorderColor = System.Drawing.Color.White;
            this.cmbSupplier.ItemForeColor = System.Drawing.Color.Black;
            this.cmbSupplier.ItemHeight = 26;
            this.cmbSupplier.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmbSupplier.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbSupplier.ItemTopMargin = 3;
            this.cmbSupplier.Location = new System.Drawing.Point(344, 33);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(220, 32);
            this.cmbSupplier.TabIndex = 5;
            this.cmbSupplier.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbSupplier.TextLeftMargin = 5;
            // 
            // FicheBonCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 456);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.dgvLignes);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(709, 495);
            this.Name = "FicheBonCommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fiche Bon de Commande";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLignes)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtBC;
        private System.Windows.Forms.Label labelBC;
        private System.Windows.Forms.Label labelFournisseur;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAjouterLigne;
        private System.Windows.Forms.ToolStripButton btnSupprimerLigne;
        private System.Windows.Forms.DataGridView dgvLignes;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnImprimerSansEP;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.TextBox txtTotalHT;
        private System.Windows.Forms.Label labelHT;
        private System.Windows.Forms.TextBox txtTva;
        private System.Windows.Forms.Label labelTva;
        private System.Windows.Forms.TextBox txtTotalTTC;
        private System.Windows.Forms.Label labelTTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTva;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private Bunifu.UI.WinForms.BunifuDropdown cmbSupplier;
    }
}