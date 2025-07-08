namespace TAPTAGPOS
{
    partial class FormSituationReport
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabCommandes = new System.Windows.Forms.TabPage();
            this.splitContainerCommandes = new System.Windows.Forms.SplitContainer();
            this.dgvCommandes = new System.Windows.Forms.DataGridView();
            this.colCmdHeure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCmdBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCmdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCmdNature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCmdTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCmdEtat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCmdUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCmdFooter = new System.Windows.Forms.Panel();
            this.labelCmdSomme = new System.Windows.Forms.Label();
            this.dgvCommandeDetails = new System.Windows.Forms.DataGridView();
            this.colCmdDetRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCmdDetDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCmdDetQte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCmdDetPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCmdDetMontant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCmdDetFooter = new System.Windows.Forms.Panel();
            this.labelCmdDetSomme = new System.Windows.Forms.Label();
            this.tabLivraisons = new System.Windows.Forms.TabPage();
            this.splitContainerLivraisons = new System.Windows.Forms.SplitContainer();
            this.dgvLivraisons = new System.Windows.Forms.DataGridView();
            this.colBlNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBlClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBlTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBlEtat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBlFacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBlFooter = new System.Windows.Forms.Panel();
            this.labelBlSomme = new System.Windows.Forms.Label();
            this.dgvLivraisonDetails = new System.Windows.Forms.DataGridView();
            this.colBlDetRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBlDetDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBlDetQte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBlDetPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBlDetMontant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBlDetFooter = new System.Windows.Forms.Panel();
            this.labelBlDetSomme = new System.Windows.Forms.Label();
            this.tabFactures = new System.Windows.Forms.TabPage();
            this.splitContainerFactures = new System.Windows.Forms.SplitContainer();
            this.dgvFactures = new System.Windows.Forms.DataGridView();
            this.colFacDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFacFooter = new System.Windows.Forms.Panel();
            this.labelFacSomme = new System.Windows.Forms.Label();
            this.dgvFactureDetails = new System.Windows.Forms.DataGridView();
            this.colFacDetRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacDetDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacDetQte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacDetPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacDetMontant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFacDetFooter = new System.Windows.Forms.Panel();
            this.labelFacDetSomme = new System.Windows.Forms.Label();
            this.tabReglements = new System.Windows.Forms.TabPage();
            this.dgvReglements = new System.Windows.Forms.DataGridView();
            this.colRegClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegJustificatif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegMontant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelReglementsFooter = new System.Windows.Forms.Panel();
            this.txtVirement = new System.Windows.Forms.TextBox();
            this.labelVirement = new System.Windows.Forms.Label();
            this.txtEffet = new System.Windows.Forms.TextBox();
            this.labelEffet = new System.Windows.Forms.Label();
            this.txtCarte = new System.Windows.Forms.TextBox();
            this.labelCarte = new System.Windows.Forms.Label();
            this.txtCheque = new System.Windows.Forms.TextBox();
            this.labelCheque = new System.Windows.Forms.Label();
            this.txtEspece = new System.Windows.Forms.TextBox();
            this.labelEspece = new System.Windows.Forms.Label();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnPeriode = new System.Windows.Forms.Button();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabCommandes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCommandes)).BeginInit();
            this.splitContainerCommandes.Panel1.SuspendLayout();
            this.splitContainerCommandes.Panel2.SuspendLayout();
            this.splitContainerCommandes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandes)).BeginInit();
            this.panelCmdFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandeDetails)).BeginInit();
            this.panelCmdDetFooter.SuspendLayout();
            this.tabLivraisons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLivraisons)).BeginInit();
            this.splitContainerLivraisons.Panel1.SuspendLayout();
            this.splitContainerLivraisons.Panel2.SuspendLayout();
            this.splitContainerLivraisons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivraisons)).BeginInit();
            this.panelBlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivraisonDetails)).BeginInit();
            this.panelBlDetFooter.SuspendLayout();
            this.tabFactures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFactures)).BeginInit();
            this.splitContainerFactures.Panel1.SuspendLayout();
            this.splitContainerFactures.Panel2.SuspendLayout();
            this.splitContainerFactures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactures)).BeginInit();
            this.panelFacFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactureDetails)).BeginInit();
            this.panelFacDetFooter.SuspendLayout();
            this.tabReglements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReglements)).BeginInit();
            this.panelReglementsFooter.SuspendLayout();
            this.panelFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabCommandes);
            this.tabControlMain.Controls.Add(this.tabLivraisons);
            this.tabControlMain.Controls.Add(this.tabFactures);
            this.tabControlMain.Controls.Add(this.tabReglements);
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(0, 57);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1077, 523);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabCommandes
            // 
            this.tabCommandes.Controls.Add(this.splitContainerCommandes);
            this.tabCommandes.Location = new System.Drawing.Point(4, 24);
            this.tabCommandes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabCommandes.Name = "tabCommandes";
            this.tabCommandes.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabCommandes.Size = new System.Drawing.Size(728, 446);
            this.tabCommandes.TabIndex = 0;
            this.tabCommandes.Text = "Commandes";
            this.tabCommandes.UseVisualStyleBackColor = true;
            // 
            // splitContainerCommandes
            // 
            this.splitContainerCommandes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerCommandes.Location = new System.Drawing.Point(2, 2);
            this.splitContainerCommandes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainerCommandes.Name = "splitContainerCommandes";
            this.splitContainerCommandes.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerCommandes.Panel1
            // 
            this.splitContainerCommandes.Panel1.Controls.Add(this.dgvCommandes);
            this.splitContainerCommandes.Panel1.Controls.Add(this.panelCmdFooter);
            // 
            // splitContainerCommandes.Panel2
            // 
            this.splitContainerCommandes.Panel2.Controls.Add(this.dgvCommandeDetails);
            this.splitContainerCommandes.Panel2.Controls.Add(this.panelCmdDetFooter);
            this.splitContainerCommandes.Size = new System.Drawing.Size(724, 442);
            this.splitContainerCommandes.SplitterDistance = 216;
            this.splitContainerCommandes.SplitterWidth = 3;
            this.splitContainerCommandes.TabIndex = 0;
            // 
            // dgvCommandes
            // 
            this.dgvCommandes.AllowUserToAddRows = false;
            this.dgvCommandes.AllowUserToDeleteRows = false;
            this.dgvCommandes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommandes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCmdHeure,
            this.colCmdBC,
            this.colCmdClient,
            this.colCmdNature,
            this.colCmdTotal,
            this.colCmdEtat,
            this.colCmdUser});
            this.dgvCommandes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCommandes.Location = new System.Drawing.Point(0, 0);
            this.dgvCommandes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCommandes.Name = "dgvCommandes";
            this.dgvCommandes.ReadOnly = true;
            this.dgvCommandes.RowHeadersVisible = false;
            this.dgvCommandes.RowHeadersWidth = 51;
            this.dgvCommandes.RowTemplate.Height = 24;
            this.dgvCommandes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommandes.Size = new System.Drawing.Size(724, 192);
            this.dgvCommandes.TabIndex = 0;
            // 
            // colCmdHeure
            // 
            this.colCmdHeure.HeaderText = "Heure";
            this.colCmdHeure.MinimumWidth = 6;
            this.colCmdHeure.Name = "colCmdHeure";
            this.colCmdHeure.ReadOnly = true;
            // 
            // colCmdBC
            // 
            this.colCmdBC.HeaderText = "N° BC";
            this.colCmdBC.MinimumWidth = 6;
            this.colCmdBC.Name = "colCmdBC";
            this.colCmdBC.ReadOnly = true;
            // 
            // colCmdClient
            // 
            this.colCmdClient.FillWeight = 150F;
            this.colCmdClient.HeaderText = "Client";
            this.colCmdClient.MinimumWidth = 6;
            this.colCmdClient.Name = "colCmdClient";
            this.colCmdClient.ReadOnly = true;
            // 
            // colCmdNature
            // 
            this.colCmdNature.HeaderText = "Nature";
            this.colCmdNature.MinimumWidth = 6;
            this.colCmdNature.Name = "colCmdNature";
            this.colCmdNature.ReadOnly = true;
            // 
            // colCmdTotal
            // 
            this.colCmdTotal.HeaderText = "Total TTC";
            this.colCmdTotal.MinimumWidth = 6;
            this.colCmdTotal.Name = "colCmdTotal";
            this.colCmdTotal.ReadOnly = true;
            // 
            // colCmdEtat
            // 
            this.colCmdEtat.HeaderText = "Etat";
            this.colCmdEtat.MinimumWidth = 6;
            this.colCmdEtat.Name = "colCmdEtat";
            this.colCmdEtat.ReadOnly = true;
            // 
            // colCmdUser
            // 
            this.colCmdUser.HeaderText = "Utilisateur";
            this.colCmdUser.MinimumWidth = 6;
            this.colCmdUser.Name = "colCmdUser";
            this.colCmdUser.ReadOnly = true;
            // 
            // panelCmdFooter
            // 
            this.panelCmdFooter.Controls.Add(this.labelCmdSomme);
            this.panelCmdFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCmdFooter.Location = new System.Drawing.Point(0, 192);
            this.panelCmdFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCmdFooter.Name = "panelCmdFooter";
            this.panelCmdFooter.Size = new System.Drawing.Size(724, 24);
            this.panelCmdFooter.TabIndex = 1;
            // 
            // labelCmdSomme
            // 
            this.labelCmdSomme.AutoSize = true;
            this.labelCmdSomme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCmdSomme.Location = new System.Drawing.Point(4, 6);
            this.labelCmdSomme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCmdSomme.Name = "labelCmdSomme";
            this.labelCmdSomme.Size = new System.Drawing.Size(47, 13);
            this.labelCmdSomme.TabIndex = 0;
            this.labelCmdSomme.Text = "Somme";
            // 
            // dgvCommandeDetails
            // 
            this.dgvCommandeDetails.AllowUserToAddRows = false;
            this.dgvCommandeDetails.AllowUserToDeleteRows = false;
            this.dgvCommandeDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCommandeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommandeDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCmdDetRef,
            this.colCmdDetDesignation,
            this.colCmdDetQte,
            this.colCmdDetPrix,
            this.colCmdDetMontant});
            this.dgvCommandeDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCommandeDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvCommandeDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCommandeDetails.Name = "dgvCommandeDetails";
            this.dgvCommandeDetails.ReadOnly = true;
            this.dgvCommandeDetails.RowHeadersVisible = false;
            this.dgvCommandeDetails.RowHeadersWidth = 51;
            this.dgvCommandeDetails.RowTemplate.Height = 24;
            this.dgvCommandeDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommandeDetails.Size = new System.Drawing.Size(724, 199);
            this.dgvCommandeDetails.TabIndex = 0;
            // 
            // colCmdDetRef
            // 
            this.colCmdDetRef.HeaderText = "Référence";
            this.colCmdDetRef.MinimumWidth = 6;
            this.colCmdDetRef.Name = "colCmdDetRef";
            this.colCmdDetRef.ReadOnly = true;
            // 
            // colCmdDetDesignation
            // 
            this.colCmdDetDesignation.FillWeight = 200F;
            this.colCmdDetDesignation.HeaderText = "Désignation";
            this.colCmdDetDesignation.MinimumWidth = 6;
            this.colCmdDetDesignation.Name = "colCmdDetDesignation";
            this.colCmdDetDesignation.ReadOnly = true;
            // 
            // colCmdDetQte
            // 
            this.colCmdDetQte.HeaderText = "Quantite";
            this.colCmdDetQte.MinimumWidth = 6;
            this.colCmdDetQte.Name = "colCmdDetQte";
            this.colCmdDetQte.ReadOnly = true;
            // 
            // colCmdDetPrix
            // 
            this.colCmdDetPrix.HeaderText = "Prix de vente";
            this.colCmdDetPrix.MinimumWidth = 6;
            this.colCmdDetPrix.Name = "colCmdDetPrix";
            this.colCmdDetPrix.ReadOnly = true;
            // 
            // colCmdDetMontant
            // 
            this.colCmdDetMontant.HeaderText = "Montant";
            this.colCmdDetMontant.MinimumWidth = 6;
            this.colCmdDetMontant.Name = "colCmdDetMontant";
            this.colCmdDetMontant.ReadOnly = true;
            // 
            // panelCmdDetFooter
            // 
            this.panelCmdDetFooter.Controls.Add(this.labelCmdDetSomme);
            this.panelCmdDetFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCmdDetFooter.Location = new System.Drawing.Point(0, 199);
            this.panelCmdDetFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCmdDetFooter.Name = "panelCmdDetFooter";
            this.panelCmdDetFooter.Size = new System.Drawing.Size(724, 24);
            this.panelCmdDetFooter.TabIndex = 1;
            // 
            // labelCmdDetSomme
            // 
            this.labelCmdDetSomme.AutoSize = true;
            this.labelCmdDetSomme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCmdDetSomme.Location = new System.Drawing.Point(4, 6);
            this.labelCmdDetSomme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCmdDetSomme.Name = "labelCmdDetSomme";
            this.labelCmdDetSomme.Size = new System.Drawing.Size(47, 13);
            this.labelCmdDetSomme.TabIndex = 1;
            this.labelCmdDetSomme.Text = "Somme";
            // 
            // tabLivraisons
            // 
            this.tabLivraisons.Controls.Add(this.splitContainerLivraisons);
            this.tabLivraisons.Location = new System.Drawing.Point(4, 24);
            this.tabLivraisons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabLivraisons.Name = "tabLivraisons";
            this.tabLivraisons.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabLivraisons.Size = new System.Drawing.Size(728, 446);
            this.tabLivraisons.TabIndex = 1;
            this.tabLivraisons.Text = "Bon de Livraisons";
            this.tabLivraisons.UseVisualStyleBackColor = true;
            // 
            // splitContainerLivraisons
            // 
            this.splitContainerLivraisons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLivraisons.Location = new System.Drawing.Point(2, 2);
            this.splitContainerLivraisons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainerLivraisons.Name = "splitContainerLivraisons";
            this.splitContainerLivraisons.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLivraisons.Panel1
            // 
            this.splitContainerLivraisons.Panel1.Controls.Add(this.dgvLivraisons);
            this.splitContainerLivraisons.Panel1.Controls.Add(this.panelBlFooter);
            // 
            // splitContainerLivraisons.Panel2
            // 
            this.splitContainerLivraisons.Panel2.Controls.Add(this.dgvLivraisonDetails);
            this.splitContainerLivraisons.Panel2.Controls.Add(this.panelBlDetFooter);
            this.splitContainerLivraisons.Size = new System.Drawing.Size(724, 442);
            this.splitContainerLivraisons.SplitterDistance = 216;
            this.splitContainerLivraisons.SplitterWidth = 3;
            this.splitContainerLivraisons.TabIndex = 1;
            // 
            // dgvLivraisons
            // 
            this.dgvLivraisons.AllowUserToAddRows = false;
            this.dgvLivraisons.AllowUserToDeleteRows = false;
            this.dgvLivraisons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLivraisons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivraisons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBlNum,
            this.colBlClient,
            this.colBlTotal,
            this.colBlEtat,
            this.colBlFacture});
            this.dgvLivraisons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLivraisons.Location = new System.Drawing.Point(0, 0);
            this.dgvLivraisons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLivraisons.Name = "dgvLivraisons";
            this.dgvLivraisons.ReadOnly = true;
            this.dgvLivraisons.RowHeadersVisible = false;
            this.dgvLivraisons.RowHeadersWidth = 51;
            this.dgvLivraisons.RowTemplate.Height = 24;
            this.dgvLivraisons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivraisons.Size = new System.Drawing.Size(724, 192);
            this.dgvLivraisons.TabIndex = 0;
            // 
            // colBlNum
            // 
            this.colBlNum.HeaderText = "N° BL";
            this.colBlNum.MinimumWidth = 6;
            this.colBlNum.Name = "colBlNum";
            this.colBlNum.ReadOnly = true;
            // 
            // colBlClient
            // 
            this.colBlClient.FillWeight = 150F;
            this.colBlClient.HeaderText = "Client";
            this.colBlClient.MinimumWidth = 6;
            this.colBlClient.Name = "colBlClient";
            this.colBlClient.ReadOnly = true;
            // 
            // colBlTotal
            // 
            this.colBlTotal.HeaderText = "Total TTC";
            this.colBlTotal.MinimumWidth = 6;
            this.colBlTotal.Name = "colBlTotal";
            this.colBlTotal.ReadOnly = true;
            // 
            // colBlEtat
            // 
            this.colBlEtat.HeaderText = "Etat";
            this.colBlEtat.MinimumWidth = 6;
            this.colBlEtat.Name = "colBlEtat";
            this.colBlEtat.ReadOnly = true;
            // 
            // colBlFacture
            // 
            this.colBlFacture.HeaderText = "Facture";
            this.colBlFacture.MinimumWidth = 6;
            this.colBlFacture.Name = "colBlFacture";
            this.colBlFacture.ReadOnly = true;
            // 
            // panelBlFooter
            // 
            this.panelBlFooter.Controls.Add(this.labelBlSomme);
            this.panelBlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBlFooter.Location = new System.Drawing.Point(0, 192);
            this.panelBlFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBlFooter.Name = "panelBlFooter";
            this.panelBlFooter.Size = new System.Drawing.Size(724, 24);
            this.panelBlFooter.TabIndex = 1;
            // 
            // labelBlSomme
            // 
            this.labelBlSomme.AutoSize = true;
            this.labelBlSomme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlSomme.Location = new System.Drawing.Point(4, 6);
            this.labelBlSomme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBlSomme.Name = "labelBlSomme";
            this.labelBlSomme.Size = new System.Drawing.Size(47, 13);
            this.labelBlSomme.TabIndex = 0;
            this.labelBlSomme.Text = "Somme";
            // 
            // dgvLivraisonDetails
            // 
            this.dgvLivraisonDetails.AllowUserToAddRows = false;
            this.dgvLivraisonDetails.AllowUserToDeleteRows = false;
            this.dgvLivraisonDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLivraisonDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivraisonDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBlDetRef,
            this.colBlDetDesignation,
            this.colBlDetQte,
            this.colBlDetPU,
            this.colBlDetMontant});
            this.dgvLivraisonDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLivraisonDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvLivraisonDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLivraisonDetails.Name = "dgvLivraisonDetails";
            this.dgvLivraisonDetails.ReadOnly = true;
            this.dgvLivraisonDetails.RowHeadersVisible = false;
            this.dgvLivraisonDetails.RowHeadersWidth = 51;
            this.dgvLivraisonDetails.RowTemplate.Height = 24;
            this.dgvLivraisonDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivraisonDetails.Size = new System.Drawing.Size(724, 199);
            this.dgvLivraisonDetails.TabIndex = 0;
            // 
            // colBlDetRef
            // 
            this.colBlDetRef.HeaderText = "Référence";
            this.colBlDetRef.MinimumWidth = 6;
            this.colBlDetRef.Name = "colBlDetRef";
            this.colBlDetRef.ReadOnly = true;
            // 
            // colBlDetDesignation
            // 
            this.colBlDetDesignation.FillWeight = 200F;
            this.colBlDetDesignation.HeaderText = "Désignation";
            this.colBlDetDesignation.MinimumWidth = 6;
            this.colBlDetDesignation.Name = "colBlDetDesignation";
            this.colBlDetDesignation.ReadOnly = true;
            // 
            // colBlDetQte
            // 
            this.colBlDetQte.HeaderText = "Qte";
            this.colBlDetQte.MinimumWidth = 6;
            this.colBlDetQte.Name = "colBlDetQte";
            this.colBlDetQte.ReadOnly = true;
            // 
            // colBlDetPU
            // 
            this.colBlDetPU.HeaderText = "P.U";
            this.colBlDetPU.MinimumWidth = 6;
            this.colBlDetPU.Name = "colBlDetPU";
            this.colBlDetPU.ReadOnly = true;
            // 
            // colBlDetMontant
            // 
            this.colBlDetMontant.HeaderText = "Montant";
            this.colBlDetMontant.MinimumWidth = 6;
            this.colBlDetMontant.Name = "colBlDetMontant";
            this.colBlDetMontant.ReadOnly = true;
            // 
            // panelBlDetFooter
            // 
            this.panelBlDetFooter.Controls.Add(this.labelBlDetSomme);
            this.panelBlDetFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBlDetFooter.Location = new System.Drawing.Point(0, 199);
            this.panelBlDetFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBlDetFooter.Name = "panelBlDetFooter";
            this.panelBlDetFooter.Size = new System.Drawing.Size(724, 24);
            this.panelBlDetFooter.TabIndex = 1;
            // 
            // labelBlDetSomme
            // 
            this.labelBlDetSomme.AutoSize = true;
            this.labelBlDetSomme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlDetSomme.Location = new System.Drawing.Point(4, 6);
            this.labelBlDetSomme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBlDetSomme.Name = "labelBlDetSomme";
            this.labelBlDetSomme.Size = new System.Drawing.Size(47, 13);
            this.labelBlDetSomme.TabIndex = 1;
            this.labelBlDetSomme.Text = "Somme";
            // 
            // tabFactures
            // 
            this.tabFactures.Controls.Add(this.splitContainerFactures);
            this.tabFactures.Location = new System.Drawing.Point(4, 24);
            this.tabFactures.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabFactures.Name = "tabFactures";
            this.tabFactures.Size = new System.Drawing.Size(728, 446);
            this.tabFactures.TabIndex = 2;
            this.tabFactures.Text = "Factures";
            this.tabFactures.UseVisualStyleBackColor = true;
            // 
            // splitContainerFactures
            // 
            this.splitContainerFactures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFactures.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFactures.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainerFactures.Name = "splitContainerFactures";
            this.splitContainerFactures.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerFactures.Panel1
            // 
            this.splitContainerFactures.Panel1.Controls.Add(this.dgvFactures);
            this.splitContainerFactures.Panel1.Controls.Add(this.panelFacFooter);
            // 
            // splitContainerFactures.Panel2
            // 
            this.splitContainerFactures.Panel2.Controls.Add(this.dgvFactureDetails);
            this.splitContainerFactures.Panel2.Controls.Add(this.panelFacDetFooter);
            this.splitContainerFactures.Size = new System.Drawing.Size(728, 446);
            this.splitContainerFactures.SplitterDistance = 218;
            this.splitContainerFactures.SplitterWidth = 3;
            this.splitContainerFactures.TabIndex = 1;
            // 
            // dgvFactures
            // 
            this.dgvFactures.AllowUserToAddRows = false;
            this.dgvFactures.AllowUserToDeleteRows = false;
            this.dgvFactures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFactures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFacDate,
            this.colFacNum,
            this.colFacClient,
            this.colFacTotal});
            this.dgvFactures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFactures.Location = new System.Drawing.Point(0, 0);
            this.dgvFactures.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvFactures.Name = "dgvFactures";
            this.dgvFactures.ReadOnly = true;
            this.dgvFactures.RowHeadersVisible = false;
            this.dgvFactures.RowHeadersWidth = 51;
            this.dgvFactures.RowTemplate.Height = 24;
            this.dgvFactures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFactures.Size = new System.Drawing.Size(728, 194);
            this.dgvFactures.TabIndex = 0;
            // 
            // colFacDate
            // 
            this.colFacDate.HeaderText = "Date";
            this.colFacDate.MinimumWidth = 6;
            this.colFacDate.Name = "colFacDate";
            this.colFacDate.ReadOnly = true;
            // 
            // colFacNum
            // 
            this.colFacNum.HeaderText = "N° Facture";
            this.colFacNum.MinimumWidth = 6;
            this.colFacNum.Name = "colFacNum";
            this.colFacNum.ReadOnly = true;
            // 
            // colFacClient
            // 
            this.colFacClient.FillWeight = 150F;
            this.colFacClient.HeaderText = "Client";
            this.colFacClient.MinimumWidth = 6;
            this.colFacClient.Name = "colFacClient";
            this.colFacClient.ReadOnly = true;
            // 
            // colFacTotal
            // 
            this.colFacTotal.HeaderText = "Total TTC";
            this.colFacTotal.MinimumWidth = 6;
            this.colFacTotal.Name = "colFacTotal";
            this.colFacTotal.ReadOnly = true;
            // 
            // panelFacFooter
            // 
            this.panelFacFooter.Controls.Add(this.labelFacSomme);
            this.panelFacFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFacFooter.Location = new System.Drawing.Point(0, 194);
            this.panelFacFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFacFooter.Name = "panelFacFooter";
            this.panelFacFooter.Size = new System.Drawing.Size(728, 24);
            this.panelFacFooter.TabIndex = 1;
            // 
            // labelFacSomme
            // 
            this.labelFacSomme.AutoSize = true;
            this.labelFacSomme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacSomme.Location = new System.Drawing.Point(4, 6);
            this.labelFacSomme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFacSomme.Name = "labelFacSomme";
            this.labelFacSomme.Size = new System.Drawing.Size(47, 13);
            this.labelFacSomme.TabIndex = 0;
            this.labelFacSomme.Text = "Somme";
            // 
            // dgvFactureDetails
            // 
            this.dgvFactureDetails.AllowUserToAddRows = false;
            this.dgvFactureDetails.AllowUserToDeleteRows = false;
            this.dgvFactureDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFactureDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactureDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFacDetRef,
            this.colFacDetDesignation,
            this.colFacDetQte,
            this.colFacDetPU,
            this.colFacDetMontant});
            this.dgvFactureDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFactureDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvFactureDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvFactureDetails.Name = "dgvFactureDetails";
            this.dgvFactureDetails.ReadOnly = true;
            this.dgvFactureDetails.RowHeadersVisible = false;
            this.dgvFactureDetails.RowHeadersWidth = 51;
            this.dgvFactureDetails.RowTemplate.Height = 24;
            this.dgvFactureDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFactureDetails.Size = new System.Drawing.Size(728, 201);
            this.dgvFactureDetails.TabIndex = 0;
            // 
            // colFacDetRef
            // 
            this.colFacDetRef.HeaderText = "Référence";
            this.colFacDetRef.MinimumWidth = 6;
            this.colFacDetRef.Name = "colFacDetRef";
            this.colFacDetRef.ReadOnly = true;
            // 
            // colFacDetDesignation
            // 
            this.colFacDetDesignation.FillWeight = 200F;
            this.colFacDetDesignation.HeaderText = "Désignation";
            this.colFacDetDesignation.MinimumWidth = 6;
            this.colFacDetDesignation.Name = "colFacDetDesignation";
            this.colFacDetDesignation.ReadOnly = true;
            // 
            // colFacDetQte
            // 
            this.colFacDetQte.HeaderText = "Qte";
            this.colFacDetQte.MinimumWidth = 6;
            this.colFacDetQte.Name = "colFacDetQte";
            this.colFacDetQte.ReadOnly = true;
            // 
            // colFacDetPU
            // 
            this.colFacDetPU.HeaderText = "P.U";
            this.colFacDetPU.MinimumWidth = 6;
            this.colFacDetPU.Name = "colFacDetPU";
            this.colFacDetPU.ReadOnly = true;
            // 
            // colFacDetMontant
            // 
            this.colFacDetMontant.HeaderText = "Montant";
            this.colFacDetMontant.MinimumWidth = 6;
            this.colFacDetMontant.Name = "colFacDetMontant";
            this.colFacDetMontant.ReadOnly = true;
            // 
            // panelFacDetFooter
            // 
            this.panelFacDetFooter.Controls.Add(this.labelFacDetSomme);
            this.panelFacDetFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFacDetFooter.Location = new System.Drawing.Point(0, 201);
            this.panelFacDetFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFacDetFooter.Name = "panelFacDetFooter";
            this.panelFacDetFooter.Size = new System.Drawing.Size(728, 24);
            this.panelFacDetFooter.TabIndex = 1;
            // 
            // labelFacDetSomme
            // 
            this.labelFacDetSomme.AutoSize = true;
            this.labelFacDetSomme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacDetSomme.Location = new System.Drawing.Point(4, 6);
            this.labelFacDetSomme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFacDetSomme.Name = "labelFacDetSomme";
            this.labelFacDetSomme.Size = new System.Drawing.Size(47, 13);
            this.labelFacDetSomme.TabIndex = 1;
            this.labelFacDetSomme.Text = "Somme";
            // 
            // tabReglements
            // 
            this.tabReglements.Controls.Add(this.dgvReglements);
            this.tabReglements.Controls.Add(this.panelReglementsFooter);
            this.tabReglements.Location = new System.Drawing.Point(4, 24);
            this.tabReglements.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabReglements.Name = "tabReglements";
            this.tabReglements.Size = new System.Drawing.Size(1069, 495);
            this.tabReglements.TabIndex = 3;
            this.tabReglements.Text = "Règlements";
            this.tabReglements.UseVisualStyleBackColor = true;
            // 
            // dgvReglements
            // 
            this.dgvReglements.AllowUserToAddRows = false;
            this.dgvReglements.AllowUserToDeleteRows = false;
            this.dgvReglements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReglements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReglements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRegClient,
            this.colRegMode,
            this.colRegJustificatif,
            this.colRegMontant});
            this.dgvReglements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReglements.Location = new System.Drawing.Point(0, 0);
            this.dgvReglements.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvReglements.Name = "dgvReglements";
            this.dgvReglements.ReadOnly = true;
            this.dgvReglements.RowHeadersVisible = false;
            this.dgvReglements.RowHeadersWidth = 51;
            this.dgvReglements.RowTemplate.Height = 24;
            this.dgvReglements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReglements.Size = new System.Drawing.Size(1069, 454);
            this.dgvReglements.TabIndex = 0;
            // 
            // colRegClient
            // 
            this.colRegClient.FillWeight = 150F;
            this.colRegClient.HeaderText = "Client";
            this.colRegClient.MinimumWidth = 6;
            this.colRegClient.Name = "colRegClient";
            this.colRegClient.ReadOnly = true;
            // 
            // colRegMode
            // 
            this.colRegMode.HeaderText = "Mode";
            this.colRegMode.MinimumWidth = 6;
            this.colRegMode.Name = "colRegMode";
            this.colRegMode.ReadOnly = true;
            // 
            // colRegJustificatif
            // 
            this.colRegJustificatif.HeaderText = "N° Justificatif";
            this.colRegJustificatif.MinimumWidth = 6;
            this.colRegJustificatif.Name = "colRegJustificatif";
            this.colRegJustificatif.ReadOnly = true;
            // 
            // colRegMontant
            // 
            this.colRegMontant.HeaderText = "Montant";
            this.colRegMontant.MinimumWidth = 6;
            this.colRegMontant.Name = "colRegMontant";
            this.colRegMontant.ReadOnly = true;
            // 
            // panelReglementsFooter
            // 
            this.panelReglementsFooter.Controls.Add(this.txtVirement);
            this.panelReglementsFooter.Controls.Add(this.labelVirement);
            this.panelReglementsFooter.Controls.Add(this.txtEffet);
            this.panelReglementsFooter.Controls.Add(this.labelEffet);
            this.panelReglementsFooter.Controls.Add(this.txtCarte);
            this.panelReglementsFooter.Controls.Add(this.labelCarte);
            this.panelReglementsFooter.Controls.Add(this.txtCheque);
            this.panelReglementsFooter.Controls.Add(this.labelCheque);
            this.panelReglementsFooter.Controls.Add(this.txtEspece);
            this.panelReglementsFooter.Controls.Add(this.labelEspece);
            this.panelReglementsFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelReglementsFooter.Location = new System.Drawing.Point(0, 454);
            this.panelReglementsFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelReglementsFooter.Name = "panelReglementsFooter";
            this.panelReglementsFooter.Size = new System.Drawing.Size(1069, 41);
            this.panelReglementsFooter.TabIndex = 1;
            // 
            // txtVirement
            // 
            this.txtVirement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVirement.Location = new System.Drawing.Point(969, 10);
            this.txtVirement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVirement.Name = "txtVirement";
            this.txtVirement.ReadOnly = true;
            this.txtVirement.Size = new System.Drawing.Size(91, 21);
            this.txtVirement.TabIndex = 9;
            // 
            // labelVirement
            // 
            this.labelVirement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelVirement.AutoSize = true;
            this.labelVirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVirement.Location = new System.Drawing.Point(889, 15);
            this.labelVirement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVirement.Name = "labelVirement";
            this.labelVirement.Size = new System.Drawing.Size(89, 13);
            this.labelVirement.TabIndex = 8;
            this.labelVirement.Text = "Total Virement";
            // 
            // txtEffet
            // 
            this.txtEffet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEffet.Location = new System.Drawing.Point(766, 10);
            this.txtEffet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEffet.Name = "txtEffet";
            this.txtEffet.ReadOnly = true;
            this.txtEffet.Size = new System.Drawing.Size(91, 21);
            this.txtEffet.TabIndex = 7;
            // 
            // labelEffet
            // 
            this.labelEffet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEffet.AutoSize = true;
            this.labelEffet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEffet.Location = new System.Drawing.Point(685, 15);
            this.labelEffet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEffet.Name = "labelEffet";
            this.labelEffet.Size = new System.Drawing.Size(67, 13);
            this.labelEffet.TabIndex = 6;
            this.labelEffet.Text = "Total Effet";
            // 
            // txtCarte
            // 
            this.txtCarte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCarte.Location = new System.Drawing.Point(558, 10);
            this.txtCarte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCarte.Name = "txtCarte";
            this.txtCarte.ReadOnly = true;
            this.txtCarte.Size = new System.Drawing.Size(91, 21);
            this.txtCarte.TabIndex = 5;
            // 
            // labelCarte
            // 
            this.labelCarte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCarte.AutoSize = true;
            this.labelCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarte.Location = new System.Drawing.Point(470, 15);
            this.labelCarte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCarte.Name = "labelCarte";
            this.labelCarte.Size = new System.Drawing.Size(70, 13);
            this.labelCarte.TabIndex = 4;
            this.labelCarte.Text = "Total Carte";
            // 
            // txtCheque
            // 
            this.txtCheque.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCheque.Location = new System.Drawing.Point(334, 10);
            this.txtCheque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCheque.Name = "txtCheque";
            this.txtCheque.ReadOnly = true;
            this.txtCheque.Size = new System.Drawing.Size(91, 21);
            this.txtCheque.TabIndex = 3;
            // 
            // labelCheque
            // 
            this.labelCheque.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCheque.AutoSize = true;
            this.labelCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheque.Location = new System.Drawing.Point(238, 15);
            this.labelCheque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCheque.Name = "labelCheque";
            this.labelCheque.Size = new System.Drawing.Size(83, 13);
            this.labelCheque.TabIndex = 2;
            this.labelCheque.Text = "Total Cheque";
            // 
            // txtEspece
            // 
            this.txtEspece.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEspece.Location = new System.Drawing.Point(125, 10);
            this.txtEspece.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEspece.Name = "txtEspece";
            this.txtEspece.ReadOnly = true;
            this.txtEspece.Size = new System.Drawing.Size(91, 21);
            this.txtEspece.TabIndex = 1;
            // 
            // labelEspece
            // 
            this.labelEspece.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEspece.AutoSize = true;
            this.labelEspece.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEspece.Location = new System.Drawing.Point(29, 15);
            this.labelEspece.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEspece.Name = "labelEspece";
            this.labelEspece.Size = new System.Drawing.Size(82, 13);
            this.labelEspece.TabIndex = 0;
            this.labelEspece.Text = "Total Espece";
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.btnValider);
            this.panelFilters.Controls.Add(this.btnPeriode);
            this.panelFilters.Controls.Add(this.dtpDateFin);
            this.panelFilters.Controls.Add(this.labelDateFin);
            this.panelFilters.Controls.Add(this.dtpDateDebut);
            this.panelFilters.Controls.Add(this.labelDateDebut);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(1079, 52);
            this.panelFilters.TabIndex = 1;
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(390, 16);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(90, 28);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // btnPeriode
            // 
            this.btnPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriode.Location = new System.Drawing.Point(296, 16);
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
            this.dtpDateFin.Location = new System.Drawing.Point(188, 21);
            this.dtpDateFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(98, 21);
            this.dtpDateFin.TabIndex = 3;
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFin.Location = new System.Drawing.Point(126, 24);
            this.labelDateFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(66, 15);
            this.labelDateFin.TabIndex = 2;
            this.labelDateFin.Text = "Date de fin";
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateDebut.Location = new System.Drawing.Point(17, 21);
            this.dtpDateDebut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(98, 21);
            this.dtpDateDebut.TabIndex = 1;
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateDebut.Location = new System.Drawing.Point(-2, 24);
            this.labelDateDebut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(84, 15);
            this.labelDateDebut.TabIndex = 0;
            this.labelDateDebut.Text = "Date de début";
            // 
            // FormSituationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 586);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.tabControlMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(754, 576);
            this.Name = "FormSituationReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Situation Périodique";
            this.tabControlMain.ResumeLayout(false);
            this.tabCommandes.ResumeLayout(false);
            this.splitContainerCommandes.Panel1.ResumeLayout(false);
            this.splitContainerCommandes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCommandes)).EndInit();
            this.splitContainerCommandes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandes)).EndInit();
            this.panelCmdFooter.ResumeLayout(false);
            this.panelCmdFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandeDetails)).EndInit();
            this.panelCmdDetFooter.ResumeLayout(false);
            this.panelCmdDetFooter.PerformLayout();
            this.tabLivraisons.ResumeLayout(false);
            this.splitContainerLivraisons.Panel1.ResumeLayout(false);
            this.splitContainerLivraisons.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLivraisons)).EndInit();
            this.splitContainerLivraisons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivraisons)).EndInit();
            this.panelBlFooter.ResumeLayout(false);
            this.panelBlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivraisonDetails)).EndInit();
            this.panelBlDetFooter.ResumeLayout(false);
            this.panelBlDetFooter.PerformLayout();
            this.tabFactures.ResumeLayout(false);
            this.splitContainerFactures.Panel1.ResumeLayout(false);
            this.splitContainerFactures.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFactures)).EndInit();
            this.splitContainerFactures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactures)).EndInit();
            this.panelFacFooter.ResumeLayout(false);
            this.panelFacFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactureDetails)).EndInit();
            this.panelFacDetFooter.ResumeLayout(false);
            this.panelFacDetFooter.PerformLayout();
            this.tabReglements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReglements)).EndInit();
            this.panelReglementsFooter.ResumeLayout(false);
            this.panelReglementsFooter.PerformLayout();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabCommandes;
        private System.Windows.Forms.TabPage tabLivraisons;
        private System.Windows.Forms.TabPage tabFactures;
        private System.Windows.Forms.TabPage tabReglements;
        private System.Windows.Forms.SplitContainer splitContainerCommandes;
        private System.Windows.Forms.DataGridView dgvCommandes;
        private System.Windows.Forms.DataGridView dgvCommandeDetails;
        private System.Windows.Forms.Panel panelCmdFooter;
        private System.Windows.Forms.Label labelCmdSomme;
        private System.Windows.Forms.Panel panelCmdDetFooter;
        private System.Windows.Forms.Label labelCmdDetSomme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCmdHeure;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCmdBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCmdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCmdNature;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCmdTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCmdEtat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCmdUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCmdDetRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCmdDetDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCmdDetQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCmdDetPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCmdDetMontant;
        private System.Windows.Forms.SplitContainer splitContainerLivraisons;
        private System.Windows.Forms.DataGridView dgvLivraisons;
        private System.Windows.Forms.Panel panelBlFooter;
        private System.Windows.Forms.Label labelBlSomme;
        private System.Windows.Forms.DataGridView dgvLivraisonDetails;
        private System.Windows.Forms.Panel panelBlDetFooter;
        private System.Windows.Forms.Label labelBlDetSomme;
        private System.Windows.Forms.SplitContainer splitContainerFactures;
        private System.Windows.Forms.DataGridView dgvFactures;
        private System.Windows.Forms.Panel panelFacFooter;
        private System.Windows.Forms.Label labelFacSomme;
        private System.Windows.Forms.DataGridView dgvFactureDetails;
        private System.Windows.Forms.Panel panelFacDetFooter;
        private System.Windows.Forms.Label labelFacDetSomme;
        private System.Windows.Forms.DataGridView dgvReglements;
        private System.Windows.Forms.Panel panelReglementsFooter;
        private System.Windows.Forms.TextBox txtEspece;
        private System.Windows.Forms.Label labelEspece;
        private System.Windows.Forms.TextBox txtCheque;
        private System.Windows.Forms.Label labelCheque;
        private System.Windows.Forms.TextBox txtCarte;
        private System.Windows.Forms.Label labelCarte;
        private System.Windows.Forms.TextBox txtEffet;
        private System.Windows.Forms.Label labelEffet;
        private System.Windows.Forms.TextBox txtVirement;
        private System.Windows.Forms.Label labelVirement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBlNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBlClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBlTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBlEtat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBlFacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBlDetRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBlDetDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBlDetQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBlDetPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBlDetMontant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacDetRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacDetDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacDetQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacDetPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacDetMontant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegJustificatif;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegMontant;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnPeriode;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Label labelDateDebut;
    }
}