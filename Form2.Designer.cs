// We are assuming the Bunifu.UI.WinForms components are available in your project.
// However, to ensure maximum compatibility and demonstrate the layout,
// this designer code will primarily use standard System.Windows.Forms controls
// styled to look like the modern UI. You can replace them with Bunifu controls.

namespace TAPTAGPOS
{
    partial class Form2
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.picAppIcon = new System.Windows.Forms.PictureBox();
            this.btnCaisse = new System.Windows.Forms.Button();
            this.btn_facture = new System.Windows.Forms.Button();
            this.btnAchat = new System.Windows.Forms.Button();
            this.btn_fournisseurs = new System.Windows.Forms.Button();
            this.Btn_CreditCustomer = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnArticles = new System.Windows.Forms.Button();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.btn_Statistic = new System.Windows.Forms.Button();
            this.Btn_ListePosSession = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.panelCard1 = new System.Windows.Forms.Panel();
            this.lblCard1Title = new System.Windows.Forms.Label();
            this.lblCard1Value_creditclient = new System.Windows.Forms.Label();
            this.picChart1_clientcredit = new System.Windows.Forms.PictureBox();
            this.panelCard2 = new System.Windows.Forms.Panel();
            this.lblCard2Title = new System.Windows.Forms.Label();
            this.lblCard2Value_creditsuppliers = new System.Windows.Forms.Label();
            this.picChart2_suppliercredit = new System.Windows.Forms.PictureBox();
            this.panelCard3 = new System.Windows.Forms.Panel();
            this.lblCard3Title = new System.Windows.Forms.Label();
            this.lblCard3Value_statistics = new System.Windows.Forms.Label();
            this.picChart3_statistics = new System.Windows.Forms.PictureBox();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppIcon)).BeginInit();
            this.panelMainContent.SuspendLayout();
            this.panelCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChart1_clientcredit)).BeginInit();
            this.panelCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChart2_suppliercredit)).BeginInit();
            this.panelCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChart3_statistics)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.panelSidebar.Controls.Add(this.lblAppName);
            this.panelSidebar.Controls.Add(this.picAppIcon);
            this.panelSidebar.Controls.Add(this.btnCaisse);
            this.panelSidebar.Controls.Add(this.btn_facture);
            this.panelSidebar.Controls.Add(this.btnAchat);
            this.panelSidebar.Controls.Add(this.btn_fournisseurs);
            this.panelSidebar.Controls.Add(this.Btn_CreditCustomer);
            this.panelSidebar.Controls.Add(this.btnStock);
            this.panelSidebar.Controls.Add(this.btnArticles);
            this.panelSidebar.Controls.Add(this.btnBarcode);
            this.panelSidebar.Controls.Add(this.btn_Statistic);
            this.panelSidebar.Controls.Add(this.Btn_ListePosSession);
            this.panelSidebar.Controls.Add(this.btnSettings);
            this.panelSidebar.Controls.Add(this.btnClose);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 722);
            this.panelSidebar.TabIndex = 1;
            // 
            // lblAppName
            // 
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(65, 28);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(150, 35);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "TAPTAG POS";
            // 
            // picAppIcon
            // 
            this.picAppIcon.Image = global::TAPTAGPOS.Properties.Resources.icons8_pos_100;
            this.picAppIcon.Location = new System.Drawing.Point(20, 25);
            this.picAppIcon.Name = "picAppIcon";
            this.picAppIcon.Size = new System.Drawing.Size(40, 40);
            this.picAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAppIcon.TabIndex = 1;
            this.picAppIcon.TabStop = false;
            // 
            // btnCaisse
            // 
            this.btnCaisse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnCaisse.FlatAppearance.BorderSize = 0;
            this.btnCaisse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaisse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCaisse.ForeColor = System.Drawing.Color.White;
            this.btnCaisse.Location = new System.Drawing.Point(20, 90);
            this.btnCaisse.Name = "btnCaisse";
            this.btnCaisse.Size = new System.Drawing.Size(210, 40);
            this.btnCaisse.TabIndex = 2;
            this.btnCaisse.Text = "Caisse";
            this.btnCaisse.UseVisualStyleBackColor = false;
            // 
            // btn_facture
            // 
            this.btn_facture.FlatAppearance.BorderSize = 0;
            this.btn_facture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facture.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_facture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btn_facture.Location = new System.Drawing.Point(20, 135);
            this.btn_facture.Name = "btn_facture";
            this.btn_facture.Size = new System.Drawing.Size(210, 40);
            this.btn_facture.TabIndex = 3;
            this.btn_facture.Text = "Factures";
            this.btn_facture.UseVisualStyleBackColor = true;
            // 
            // btnAchat
            // 
            this.btnAchat.FlatAppearance.BorderSize = 0;
            this.btnAchat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAchat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAchat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnAchat.Location = new System.Drawing.Point(20, 180);
            this.btnAchat.Name = "btnAchat";
            this.btnAchat.Size = new System.Drawing.Size(210, 40);
            this.btnAchat.TabIndex = 4;
            this.btnAchat.Text = "Achats";
            this.btnAchat.UseVisualStyleBackColor = true;
            // 
            // btn_fournisseurs
            // 
            this.btn_fournisseurs.FlatAppearance.BorderSize = 0;
            this.btn_fournisseurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fournisseurs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_fournisseurs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btn_fournisseurs.Location = new System.Drawing.Point(20, 225);
            this.btn_fournisseurs.Name = "btn_fournisseurs";
            this.btn_fournisseurs.Size = new System.Drawing.Size(210, 40);
            this.btn_fournisseurs.TabIndex = 5;
            this.btn_fournisseurs.Text = "Fournisseurs";
            this.btn_fournisseurs.UseVisualStyleBackColor = true;
            // 
            // Btn_CreditCustomer
            // 
            this.Btn_CreditCustomer.FlatAppearance.BorderSize = 0;
            this.Btn_CreditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CreditCustomer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_CreditCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.Btn_CreditCustomer.Location = new System.Drawing.Point(20, 270);
            this.Btn_CreditCustomer.Name = "Btn_CreditCustomer";
            this.Btn_CreditCustomer.Size = new System.Drawing.Size(210, 40);
            this.Btn_CreditCustomer.TabIndex = 6;
            this.Btn_CreditCustomer.Text = "Crédit Client";
            this.Btn_CreditCustomer.UseVisualStyleBackColor = true;
            // 
            // btnStock
            // 
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnStock.Location = new System.Drawing.Point(20, 315);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(210, 40);
            this.btnStock.TabIndex = 7;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            // 
            // btnArticles
            // 
            this.btnArticles.FlatAppearance.BorderSize = 0;
            this.btnArticles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnArticles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnArticles.Location = new System.Drawing.Point(20, 360);
            this.btnArticles.Name = "btnArticles";
            this.btnArticles.Size = new System.Drawing.Size(210, 40);
            this.btnArticles.TabIndex = 8;
            this.btnArticles.Text = "Articles";
            this.btnArticles.UseVisualStyleBackColor = true;
            // 
            // btnBarcode
            // 
            this.btnBarcode.FlatAppearance.BorderSize = 0;
            this.btnBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarcode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnBarcode.Location = new System.Drawing.Point(20, 405);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(210, 40);
            this.btnBarcode.TabIndex = 9;
            this.btnBarcode.Text = "Code-barres";
            this.btnBarcode.UseVisualStyleBackColor = true;
            // 
            // btn_Statistic
            // 
            this.btn_Statistic.FlatAppearance.BorderSize = 0;
            this.btn_Statistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Statistic.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Statistic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btn_Statistic.Location = new System.Drawing.Point(20, 450);
            this.btn_Statistic.Name = "btn_Statistic";
            this.btn_Statistic.Size = new System.Drawing.Size(210, 40);
            this.btn_Statistic.TabIndex = 10;
            this.btn_Statistic.Text = "Statistiques";
            this.btn_Statistic.UseVisualStyleBackColor = true;
            // 
            // Btn_ListePosSession
            // 
            this.Btn_ListePosSession.FlatAppearance.BorderSize = 0;
            this.Btn_ListePosSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ListePosSession.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_ListePosSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.Btn_ListePosSession.Location = new System.Drawing.Point(20, 495);
            this.Btn_ListePosSession.Name = "Btn_ListePosSession";
            this.Btn_ListePosSession.Size = new System.Drawing.Size(210, 40);
            this.Btn_ListePosSession.TabIndex = 11;
            this.Btn_ListePosSession.Text = "Sessions de Caisse";
            this.Btn_ListePosSession.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnSettings.Location = new System.Drawing.Point(20, 540);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(210, 40);
            this.btnSettings.TabIndex = 12;
            this.btnSettings.Text = "Paramètres";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnClose.Location = new System.Drawing.Point(0, 682);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(250, 40);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Fermer";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // panelMainContent
            // 
            this.panelMainContent.Controls.Add(this.lblDashboardTitle);
            this.panelMainContent.Controls.Add(this.panelCard1);
            this.panelMainContent.Controls.Add(this.panelCard2);
            this.panelMainContent.Controls.Add(this.panelCard3);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(250, 0);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(888, 722);
            this.panelMainContent.TabIndex = 0;
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardTitle.ForeColor = System.Drawing.Color.White;
            this.lblDashboardTitle.Location = new System.Drawing.Point(40, 35);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(119, 30);
            this.lblDashboardTitle.TabIndex = 0;
            this.lblDashboardTitle.Text = "Dashboard";
            // 
            // panelCard1
            // 
            this.panelCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.panelCard1.Controls.Add(this.lblCard1Title);
            this.panelCard1.Controls.Add(this.lblCard1Value_creditclient);
            this.panelCard1.Controls.Add(this.picChart1_clientcredit);
            this.panelCard1.Location = new System.Drawing.Point(45, 100);
            this.panelCard1.Name = "panelCard1";
            this.panelCard1.Size = new System.Drawing.Size(380, 250);
            this.panelCard1.TabIndex = 1;
            // 
            // lblCard1Title
            // 
            this.lblCard1Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCard1Title.ForeColor = System.Drawing.Color.White;
            this.lblCard1Title.Location = new System.Drawing.Point(20, 20);
            this.lblCard1Title.Name = "lblCard1Title";
            this.lblCard1Title.Size = new System.Drawing.Size(100, 23);
            this.lblCard1Title.TabIndex = 0;
            this.lblCard1Title.Text = "Crédit Client";
            // 
            // lblCard1Value_creditclient
            // 
            this.lblCard1Value_creditclient.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCard1Value_creditclient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblCard1Value_creditclient.Location = new System.Drawing.Point(20, 55);
            this.lblCard1Value_creditclient.Name = "lblCard1Value_creditclient";
            this.lblCard1Value_creditclient.Size = new System.Drawing.Size(100, 42);
            this.lblCard1Value_creditclient.TabIndex = 1;
            this.lblCard1Value_creditclient.Text = "1,250 DA";
            // 
            // picChart1_clientcredit
            // 
            this.picChart1_clientcredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.picChart1_clientcredit.Location = new System.Drawing.Point(25, 100);
            this.picChart1_clientcredit.Name = "picChart1_clientcredit";
            this.picChart1_clientcredit.Size = new System.Drawing.Size(330, 130);
            this.picChart1_clientcredit.TabIndex = 2;
            this.picChart1_clientcredit.TabStop = false;
            // 
            // panelCard2
            // 
            this.panelCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.panelCard2.Controls.Add(this.lblCard2Title);
            this.panelCard2.Controls.Add(this.lblCard2Value_creditsuppliers);
            this.panelCard2.Controls.Add(this.picChart2_suppliercredit);
            this.panelCard2.Location = new System.Drawing.Point(450, 100);
            this.panelCard2.Name = "panelCard2";
            this.panelCard2.Size = new System.Drawing.Size(380, 250);
            this.panelCard2.TabIndex = 2;
            // 
            // lblCard2Title
            // 
            this.lblCard2Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCard2Title.ForeColor = System.Drawing.Color.White;
            this.lblCard2Title.Location = new System.Drawing.Point(20, 20);
            this.lblCard2Title.Name = "lblCard2Title";
            this.lblCard2Title.Size = new System.Drawing.Size(182, 23);
            this.lblCard2Title.TabIndex = 0;
            this.lblCard2Title.Text = "Crédit Fournisseur";
            // 
            // lblCard2Value_creditsuppliers
            // 
            this.lblCard2Value_creditsuppliers.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCard2Value_creditsuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblCard2Value_creditsuppliers.Location = new System.Drawing.Point(20, 55);
            this.lblCard2Value_creditsuppliers.Name = "lblCard2Value_creditsuppliers";
            this.lblCard2Value_creditsuppliers.Size = new System.Drawing.Size(100, 42);
            this.lblCard2Value_creditsuppliers.TabIndex = 1;
            this.lblCard2Value_creditsuppliers.Text = "8,400 DA";
            // 
            // picChart2_suppliercredit
            // 
            this.picChart2_suppliercredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.picChart2_suppliercredit.Location = new System.Drawing.Point(25, 100);
            this.picChart2_suppliercredit.Name = "picChart2_suppliercredit";
            this.picChart2_suppliercredit.Size = new System.Drawing.Size(330, 130);
            this.picChart2_suppliercredit.TabIndex = 2;
            this.picChart2_suppliercredit.TabStop = false;
            // 
            // panelCard3
            // 
            this.panelCard3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.panelCard3.Controls.Add(this.lblCard3Title);
            this.panelCard3.Controls.Add(this.lblCard3Value_statistics);
            this.panelCard3.Controls.Add(this.picChart3_statistics);
            this.panelCard3.Location = new System.Drawing.Point(45, 380);
            this.panelCard3.Name = "panelCard3";
            this.panelCard3.Size = new System.Drawing.Size(785, 300);
            this.panelCard3.TabIndex = 3;
            // 
            // lblCard3Title
            // 
            this.lblCard3Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCard3Title.ForeColor = System.Drawing.Color.White;
            this.lblCard3Title.Location = new System.Drawing.Point(20, 13);
            this.lblCard3Title.Name = "lblCard3Title";
            this.lblCard3Title.Size = new System.Drawing.Size(100, 23);
            this.lblCard3Title.TabIndex = 0;
            this.lblCard3Title.Text = "Statistiques de Ventes";
            // 
            // lblCard3Value_statistics
            // 
            this.lblCard3Value_statistics.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCard3Value_statistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblCard3Value_statistics.Location = new System.Drawing.Point(20, 35);
            this.lblCard3Value_statistics.Name = "lblCard3Value_statistics";
            this.lblCard3Value_statistics.Size = new System.Drawing.Size(505, 42);
            this.lblCard3Value_statistics.TabIndex = 1;
            this.lblCard3Value_statistics.Text = "Ce Mois";
            // 
            // picChart3_statistics
            // 
            this.picChart3_statistics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picChart3_statistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.picChart3_statistics.Location = new System.Drawing.Point(0, 80);
            this.picChart3_statistics.Name = "picChart3_statistics";
            this.picChart3_statistics.Size = new System.Drawing.Size(782, 217);
            this.picChart3_statistics.TabIndex = 2;
            this.picChart3_statistics.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1138, 722);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAPTAG POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAppIcon)).EndInit();
            this.panelMainContent.ResumeLayout(false);
            this.panelMainContent.PerformLayout();
            this.panelCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picChart1_clientcredit)).EndInit();
            this.panelCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picChart2_suppliercredit)).EndInit();
            this.panelCard3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picChart3_statistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.PictureBox picAppIcon;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Button btnCaisse;
        private System.Windows.Forms.Button btn_facture;
        private System.Windows.Forms.Button btnAchat;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnArticles;
        private System.Windows.Forms.Button btn_fournisseurs;
        private System.Windows.Forms.Button Btn_CreditCustomer;
        private System.Windows.Forms.Button btn_Statistic;
        private System.Windows.Forms.Button btnBarcode;
        private System.Windows.Forms.Button Btn_ListePosSession;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.Label lblDashboardTitle;

        private System.Windows.Forms.Panel panelCard1;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Label lblCard1Value_creditclient;
        private System.Windows.Forms.PictureBox picChart1_clientcredit;

        private System.Windows.Forms.Panel panelCard2;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Label lblCard2Value_creditsuppliers;
        private System.Windows.Forms.PictureBox picChart2_suppliercredit;

        private System.Windows.Forms.Panel panelCard3;
        private System.Windows.Forms.Label lblCard3Title;
        private System.Windows.Forms.Label lblCard3Value_statistics;
        private System.Windows.Forms.PictureBox picChart3_statistics;
    }
}
