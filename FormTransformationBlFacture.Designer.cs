namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class FormTransformationBlFacture
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupFacture = new System.Windows.Forms.GroupBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.txtClientCode = new System.Windows.Forms.TextBox();
            this.labelClientCode = new System.Windows.Forms.Label();
            this.txtNumFacture = new System.Windows.Forms.TextBox();
            this.labelNumFacture = new System.Windows.Forms.Label();
            this.dgvSource = new System.Windows.Forms.DataGridView();
            this.btnAjouterUn = new System.Windows.Forms.Button();
            this.btnAjouterTous = new System.Windows.Forms.Button();
            this.btnSupprimerUn = new System.Windows.Forms.Button();
            this.btnSupprimerTous = new System.Windows.Forms.Button();
            this.dgvDestination = new System.Windows.Forms.DataGridView();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.txtTotalTTC = new System.Windows.Forms.TextBox();
            this.labelTTC = new System.Windows.Forms.Label();
            this.txtTVA = new System.Windows.Forms.TextBox();
            this.labelTVA = new System.Windows.Forms.Label();
            this.txtTotalHT = new System.Windows.Forms.TextBox();
            this.labelHT = new System.Windows.Forms.Label();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.colSourceBL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourceRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourceDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourceQte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourcePrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourceTVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestBL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestQte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestTVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupFacture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestination)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupFacture
            // 
            this.groupFacture.Controls.Add(this.txtClientName);
            this.groupFacture.Controls.Add(this.labelClient);
            this.groupFacture.Controls.Add(this.dtpDate);
            this.groupFacture.Controls.Add(this.labelDate);
            this.groupFacture.Controls.Add(this.txtClientCode);
            this.groupFacture.Controls.Add(this.labelClientCode);
            this.groupFacture.Controls.Add(this.txtNumFacture);
            this.groupFacture.Controls.Add(this.labelNumFacture);
            this.groupFacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupFacture.Location = new System.Drawing.Point(12, 12);
            this.groupFacture.Name = "groupFacture";
            this.groupFacture.Size = new System.Drawing.Size(958, 100);
            this.groupFacture.TabIndex = 0;
            this.groupFacture.TabStop = false;
            this.groupFacture.Text = "Facture";
            // 
            // txtClientName
            // 
            this.txtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.Location = new System.Drawing.Point(620, 65);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.ReadOnly = true;
            this.txtClientName.Size = new System.Drawing.Size(320, 24);
            this.txtClientName.TabIndex = 7;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.Location = new System.Drawing.Point(542, 68);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(45, 18);
            this.labelClient.TabIndex = 6;
            this.labelClient.Text = "Client";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(620, 30);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(320, 24);
            this.dtpDate.TabIndex = 5;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(542, 33);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(39, 18);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Date";
            // 
            // txtClientCode
            // 
            this.txtClientCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCode.Location = new System.Drawing.Point(130, 65);
            this.txtClientCode.Name = "txtClientCode";
            this.txtClientCode.ReadOnly = true;
            this.txtClientCode.Size = new System.Drawing.Size(250, 24);
            this.txtClientCode.TabIndex = 3;
            // 
            // labelClientCode
            // 
            this.labelClientCode.AutoSize = true;
            this.labelClientCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientCode.Location = new System.Drawing.Point(20, 68);
            this.labelClientCode.Name = "labelClientCode";
            this.labelClientCode.Size = new System.Drawing.Size(84, 18);
            this.labelClientCode.TabIndex = 2;
            this.labelClientCode.Text = "Code Client";
            // 
            // txtNumFacture
            // 
            this.txtNumFacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumFacture.Location = new System.Drawing.Point(130, 30);
            this.txtNumFacture.Name = "txtNumFacture";
            this.txtNumFacture.ReadOnly = true;
            this.txtNumFacture.Size = new System.Drawing.Size(250, 24);
            this.txtNumFacture.TabIndex = 1;
            // 
            // labelNumFacture
            // 
            this.labelNumFacture.AutoSize = true;
            this.labelNumFacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumFacture.Location = new System.Drawing.Point(20, 33);
            this.labelNumFacture.Name = "labelNumFacture";
            this.labelNumFacture.Size = new System.Drawing.Size(77, 18);
            this.labelNumFacture.TabIndex = 0;
            this.labelNumFacture.Text = "N° Facture";
            // 
            // dgvSource
            // 
            this.dgvSource.AllowUserToAddRows = false;
            this.dgvSource.AllowUserToDeleteRows = false;
            this.dgvSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSource.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSource.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSource.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSourceBL,
            this.colSourceRef,
            this.colSourceDesignation,
            this.colSourceQte,
            this.colSourcePrix,
            this.colSourceTVA,
            this.colSourceTotal});
            this.dgvSource.EnableHeadersVisualStyles = false;
            this.dgvSource.Location = new System.Drawing.Point(12, 120);
            this.dgvSource.Name = "dgvSource";
            this.dgvSource.ReadOnly = true;
            this.dgvSource.RowHeadersVisible = false;
            this.dgvSource.RowHeadersWidth = 51;
            this.dgvSource.RowTemplate.Height = 24;
            this.dgvSource.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSource.Size = new System.Drawing.Size(820, 180);
            this.dgvSource.TabIndex = 1;
            // 
            // btnAjouterUn
            // 
            this.btnAjouterUn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterUn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterUn.Location = new System.Drawing.Point(840, 120);
            this.btnAjouterUn.Name = "btnAjouterUn";
            this.btnAjouterUn.Size = new System.Drawing.Size(130, 40);
            this.btnAjouterUn.TabIndex = 2;
            this.btnAjouterUn.Text = "Ajouter Un";
            this.btnAjouterUn.UseVisualStyleBackColor = true;
            // 
            // btnAjouterTous
            // 
            this.btnAjouterTous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterTous.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterTous.Location = new System.Drawing.Point(840, 166);
            this.btnAjouterTous.Name = "btnAjouterTous";
            this.btnAjouterTous.Size = new System.Drawing.Size(130, 40);
            this.btnAjouterTous.TabIndex = 3;
            this.btnAjouterTous.Text = "Ajouter Tous";
            this.btnAjouterTous.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerUn
            // 
            this.btnSupprimerUn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimerUn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerUn.Location = new System.Drawing.Point(840, 212);
            this.btnSupprimerUn.Name = "btnSupprimerUn";
            this.btnSupprimerUn.Size = new System.Drawing.Size(130, 40);
            this.btnSupprimerUn.TabIndex = 4;
            this.btnSupprimerUn.Text = "Suppr Un";
            this.btnSupprimerUn.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerTous
            // 
            this.btnSupprimerTous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimerTous.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerTous.Location = new System.Drawing.Point(840, 258);
            this.btnSupprimerTous.Name = "btnSupprimerTous";
            this.btnSupprimerTous.Size = new System.Drawing.Size(130, 40);
            this.btnSupprimerTous.TabIndex = 5;
            this.btnSupprimerTous.Text = "Suppr Tous";
            this.btnSupprimerTous.UseVisualStyleBackColor = true;
            // 
            // dgvDestination
            // 
            this.dgvDestination.AllowUserToAddRows = false;
            this.dgvDestination.AllowUserToDeleteRows = false;
            this.dgvDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDestination.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDestination.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDestination.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestination.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDestBL,
            this.colDestRef,
            this.colDestDesignation,
            this.colDestQte,
            this.colDestPrix,
            this.colDestTVA,
            this.colDestTotal});
            this.dgvDestination.Location = new System.Drawing.Point(12, 306);
            this.dgvDestination.Name = "dgvDestination";
            this.dgvDestination.ReadOnly = true;
            this.dgvDestination.RowHeadersVisible = false;
            this.dgvDestination.RowHeadersWidth = 51;
            this.dgvDestination.RowTemplate.Height = 24;
            this.dgvDestination.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDestination.Size = new System.Drawing.Size(958, 200);
            this.dgvDestination.TabIndex = 6;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.txtTotalTTC);
            this.panelFooter.Controls.Add(this.labelTTC);
            this.panelFooter.Controls.Add(this.txtTVA);
            this.panelFooter.Controls.Add(this.labelTVA);
            this.panelFooter.Controls.Add(this.txtTotalHT);
            this.panelFooter.Controls.Add(this.labelHT);
            this.panelFooter.Controls.Add(this.btnImprimer);
            this.panelFooter.Controls.Add(this.btnValider);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 512);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(982, 60);
            this.panelFooter.TabIndex = 7;
            // 
            // txtTotalTTC
            // 
            this.txtTotalTTC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalTTC.Location = new System.Drawing.Point(798, 20);
            this.txtTotalTTC.Name = "txtTotalTTC";
            this.txtTotalTTC.ReadOnly = true;
            this.txtTotalTTC.Size = new System.Drawing.Size(170, 22);
            this.txtTotalTTC.TabIndex = 7;
            // 
            // labelTTC
            // 
            this.labelTTC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTTC.AutoSize = true;
            this.labelTTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTTC.Location = new System.Drawing.Point(708, 23);
            this.labelTTC.Name = "labelTTC";
            this.labelTTC.Size = new System.Drawing.Size(78, 16);
            this.labelTTC.TabIndex = 6;
            this.labelTTC.Text = "Total TTC";
            // 
            // txtTVA
            // 
            this.txtTVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTVA.Location = new System.Drawing.Point(528, 20);
            this.txtTVA.Name = "txtTVA";
            this.txtTVA.ReadOnly = true;
            this.txtTVA.Size = new System.Drawing.Size(170, 22);
            this.txtTVA.TabIndex = 5;
            // 
            // labelTVA
            // 
            this.labelTVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTVA.AutoSize = true;
            this.labelTVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTVA.Location = new System.Drawing.Point(489, 23);
            this.labelTVA.Name = "labelTVA";
            this.labelTVA.Size = new System.Drawing.Size(33, 16);
            this.labelTVA.TabIndex = 4;
            this.labelTVA.Text = "TVA";
            // 
            // txtTotalHT
            // 
            this.txtTotalHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalHT.Location = new System.Drawing.Point(308, 20);
            this.txtTotalHT.Name = "txtTotalHT";
            this.txtTotalHT.ReadOnly = true;
            this.txtTotalHT.Size = new System.Drawing.Size(170, 22);
            this.txtTotalHT.TabIndex = 3;
            // 
            // labelHT
            // 
            this.labelHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHT.AutoSize = true;
            this.labelHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHT.Location = new System.Drawing.Point(228, 23);
            this.labelHT.Name = "labelHT";
            this.labelHT.Size = new System.Drawing.Size(69, 16);
            this.labelHT.TabIndex = 2;
            this.labelHT.Text = "Total HT";
            // 
            // btnImprimer
            // 
            this.btnImprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.Location = new System.Drawing.Point(128, 10);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(110, 40);
            this.btnImprimer.TabIndex = 1;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(12, 10);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(110, 40);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // colSourceBL
            // 
            this.colSourceBL.HeaderText = "N° Bl";
            this.colSourceBL.MinimumWidth = 6;
            this.colSourceBL.Name = "colSourceBL";
            this.colSourceBL.ReadOnly = true;
            // 
            // colSourceRef
            // 
            this.colSourceRef.HeaderText = "Référence";
            this.colSourceRef.MinimumWidth = 6;
            this.colSourceRef.Name = "colSourceRef";
            this.colSourceRef.ReadOnly = true;
            // 
            // colSourceDesignation
            // 
            this.colSourceDesignation.FillWeight = 150F;
            this.colSourceDesignation.HeaderText = "Désignation";
            this.colSourceDesignation.MinimumWidth = 6;
            this.colSourceDesignation.Name = "colSourceDesignation";
            this.colSourceDesignation.ReadOnly = true;
            // 
            // colSourceQte
            // 
            this.colSourceQte.FillWeight = 70F;
            this.colSourceQte.HeaderText = "Qte";
            this.colSourceQte.MinimumWidth = 6;
            this.colSourceQte.Name = "colSourceQte";
            this.colSourceQte.ReadOnly = true;
            // 
            // colSourcePrix
            // 
            this.colSourcePrix.HeaderText = "Prix";
            this.colSourcePrix.MinimumWidth = 6;
            this.colSourcePrix.Name = "colSourcePrix";
            this.colSourcePrix.ReadOnly = true;
            // 
            // colSourceTVA
            // 
            this.colSourceTVA.FillWeight = 70F;
            this.colSourceTVA.HeaderText = "Tva";
            this.colSourceTVA.MinimumWidth = 6;
            this.colSourceTVA.Name = "colSourceTVA";
            this.colSourceTVA.ReadOnly = true;
            // 
            // colSourceTotal
            // 
            this.colSourceTotal.HeaderText = "Total";
            this.colSourceTotal.MinimumWidth = 6;
            this.colSourceTotal.Name = "colSourceTotal";
            this.colSourceTotal.ReadOnly = true;
            // 
            // colDestBL
            // 
            this.colDestBL.HeaderText = "N° Bl";
            this.colDestBL.MinimumWidth = 6;
            this.colDestBL.Name = "colDestBL";
            this.colDestBL.ReadOnly = true;
            // 
            // colDestRef
            // 
            this.colDestRef.HeaderText = "Référence";
            this.colDestRef.MinimumWidth = 6;
            this.colDestRef.Name = "colDestRef";
            this.colDestRef.ReadOnly = true;
            // 
            // colDestDesignation
            // 
            this.colDestDesignation.FillWeight = 150F;
            this.colDestDesignation.HeaderText = "Désignation";
            this.colDestDesignation.MinimumWidth = 6;
            this.colDestDesignation.Name = "colDestDesignation";
            this.colDestDesignation.ReadOnly = true;
            // 
            // colDestQte
            // 
            this.colDestQte.FillWeight = 70F;
            this.colDestQte.HeaderText = "Qte";
            this.colDestQte.MinimumWidth = 6;
            this.colDestQte.Name = "colDestQte";
            this.colDestQte.ReadOnly = true;
            // 
            // colDestPrix
            // 
            this.colDestPrix.HeaderText = "Prix";
            this.colDestPrix.MinimumWidth = 6;
            this.colDestPrix.Name = "colDestPrix";
            this.colDestPrix.ReadOnly = true;
            // 
            // colDestTVA
            // 
            this.colDestTVA.FillWeight = 70F;
            this.colDestTVA.HeaderText = "Tva";
            this.colDestTVA.MinimumWidth = 6;
            this.colDestTVA.Name = "colDestTVA";
            this.colDestTVA.ReadOnly = true;
            // 
            // colDestTotal
            // 
            this.colDestTotal.HeaderText = "Total";
            this.colDestTotal.MinimumWidth = 6;
            this.colDestTotal.Name = "colDestTotal";
            this.colDestTotal.ReadOnly = true;
            // 
            // FormTransformationBlFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 572);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.dgvDestination);
            this.Controls.Add(this.btnSupprimerTous);
            this.Controls.Add(this.btnSupprimerUn);
            this.Controls.Add(this.btnAjouterTous);
            this.Controls.Add(this.btnAjouterUn);
            this.Controls.Add(this.dgvSource);
            this.Controls.Add(this.groupFacture);
            this.MinimumSize = new System.Drawing.Size(1000, 619);
            this.Name = "FormTransformationBlFacture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transformation des BLS en Facture";
            this.groupFacture.ResumeLayout(false);
            this.groupFacture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestination)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupFacture;
        private System.Windows.Forms.Label labelNumFacture;
        private System.Windows.Forms.TextBox txtNumFacture;
        private System.Windows.Forms.TextBox txtClientCode;
        private System.Windows.Forms.Label labelClientCode;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.DataGridView dgvSource;
        private System.Windows.Forms.Button btnAjouterUn;
        private System.Windows.Forms.Button btnAjouterTous;
        private System.Windows.Forms.Button btnSupprimerUn;
        private System.Windows.Forms.Button btnSupprimerTous;
        private System.Windows.Forms.DataGridView dgvDestination;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Label labelHT;
        private System.Windows.Forms.TextBox txtTotalHT;
        private System.Windows.Forms.TextBox txtTVA;
        private System.Windows.Forms.Label labelTVA;
        private System.Windows.Forms.TextBox txtTotalTTC;
        private System.Windows.Forms.Label labelTTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceBL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourcePrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceTVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestBL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestTVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestTotal;
    }
}