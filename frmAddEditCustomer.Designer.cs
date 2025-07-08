namespace TAPTAGPOS
{
    partial class frmAddEditCustomer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtCIN = new System.Windows.Forms.TextBox();
            this.lblCIN = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.txtICE = new System.Windows.Forms.TextBox();
            this.lblICE = new System.Windows.Forms.Label();
            this.txtIF = new System.Windows.Forms.TextBox();
            this.lblIF = new System.Windows.Forms.Label();
            this.txtCheckCeiling = new System.Windows.Forms.TextBox();
            this.lblCheckCeiling = new System.Windows.Forms.Label();
            this.txtPaymentTerm = new System.Windows.Forms.TextBox();
            this.lblPaymentTerm = new System.Windows.Forms.Label();
            this.txtDebtCeiling = new System.Windows.Forms.TextBox();
            this.lblDebtCeiling = new System.Windows.Forms.Label();
            this.chkCreditAllowed = new System.Windows.Forms.CheckBox();
            this.lblCreditAllowed = new System.Windows.Forms.Label();
            this.btnTariffDetail = new System.Windows.Forms.Button();
            this.cmbTariff = new System.Windows.Forms.ComboBox();
            this.lblTariff = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.cmbSalesperson = new System.Windows.Forms.ComboBox();
            this.lblSalesperson = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnAddCode = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(221)))), ((int)(((byte)(233)))));
            this.pnlMain.Controls.Add(this.tableLayoutPanel1);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnConfirm);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(980, 669);
            this.pnlMain.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(357, 612);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 45);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "إلغاء ❌";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfirm.BackColor = System.Drawing.Color.ForestGreen;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(507, 612);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(130, 45);
            this.btnConfirm.TabIndex = 38;
            this.btnConfirm.Text = "تأكيد ✔";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtCIN
            // 
            this.txtCIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCIN.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCIN.Location = new System.Drawing.Point(189, 528);
            this.txtCIN.Name = "txtCIN";
            this.txtCIN.Size = new System.Drawing.Size(178, 25);
            this.txtCIN.TabIndex = 37;
            // 
            // lblCIN
            // 
            this.lblCIN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCIN.AutoSize = true;
            this.lblCIN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCIN.Location = new System.Drawing.Point(145, 532);
            this.lblCIN.Name = "lblCIN";
            this.lblCIN.Size = new System.Drawing.Size(38, 17);
            this.lblCIN.TabIndex = 36;
            this.lblCIN.Text = "C.I.N";
            // 
            // txtPatente
            // 
            this.txtPatente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatente.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPatente.Location = new System.Drawing.Point(557, 528);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(178, 25);
            this.txtPatente.TabIndex = 35;
            // 
            // lblPatente
            // 
            this.lblPatente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPatente.Location = new System.Drawing.Point(496, 532);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(55, 17);
            this.lblPatente.TabIndex = 34;
            this.lblPatente.Text = "Patente";
            // 
            // txtICE
            // 
            this.txtICE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtICE.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtICE.Location = new System.Drawing.Point(189, 482);
            this.txtICE.Name = "txtICE";
            this.txtICE.Size = new System.Drawing.Size(178, 25);
            this.txtICE.TabIndex = 33;
            // 
            // lblICE
            // 
            this.lblICE.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblICE.AutoSize = true;
            this.lblICE.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblICE.Location = new System.Drawing.Point(148, 486);
            this.lblICE.Name = "lblICE";
            this.lblICE.Size = new System.Drawing.Size(35, 17);
            this.lblICE.TabIndex = 32;
            this.lblICE.Text = "I.C.E";
            // 
            // txtIF
            // 
            this.txtIF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIF.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtIF.Location = new System.Drawing.Point(557, 482);
            this.txtIF.Name = "txtIF";
            this.txtIF.Size = new System.Drawing.Size(178, 25);
            this.txtIF.TabIndex = 31;
            // 
            // lblIF
            // 
            this.lblIF.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIF.AutoSize = true;
            this.lblIF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblIF.Location = new System.Drawing.Point(528, 486);
            this.lblIF.Name = "lblIF";
            this.lblIF.Size = new System.Drawing.Size(23, 17);
            this.lblIF.TabIndex = 30;
            this.lblIF.Text = "I.F";
            // 
            // txtCheckCeiling
            // 
            this.txtCheckCeiling.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCheckCeiling.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCheckCeiling.Location = new System.Drawing.Point(678, 439);
            this.txtCheckCeiling.Name = "txtCheckCeiling";
            this.txtCheckCeiling.Size = new System.Drawing.Size(57, 25);
            this.txtCheckCeiling.TabIndex = 29;
            this.txtCheckCeiling.Text = "0.00";
            // 
            // lblCheckCeiling
            // 
            this.lblCheckCeiling.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCheckCeiling.AutoSize = true;
            this.lblCheckCeiling.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCheckCeiling.Location = new System.Drawing.Point(832, 443);
            this.lblCheckCeiling.Name = "lblCheckCeiling";
            this.lblCheckCeiling.Size = new System.Drawing.Size(87, 17);
            this.lblCheckCeiling.TabIndex = 28;
            this.lblCheckCeiling.Text = "سقف الشيكات";
            // 
            // txtPaymentTerm
            // 
            this.txtPaymentTerm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPaymentTerm.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPaymentTerm.Location = new System.Drawing.Point(310, 439);
            this.txtPaymentTerm.Name = "txtPaymentTerm";
            this.txtPaymentTerm.Size = new System.Drawing.Size(57, 25);
            this.txtPaymentTerm.TabIndex = 27;
            this.txtPaymentTerm.Text = "0";
            // 
            // lblPaymentTerm
            // 
            this.lblPaymentTerm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPaymentTerm.AutoSize = true;
            this.lblPaymentTerm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPaymentTerm.Location = new System.Drawing.Point(447, 400);
            this.lblPaymentTerm.Name = "lblPaymentTerm";
            this.lblPaymentTerm.Size = new System.Drawing.Size(104, 17);
            this.lblPaymentTerm.TabIndex = 26;
            this.lblPaymentTerm.Text = "أجل الدفع (بالأيام)";
            // 
            // txtDebtCeiling
            // 
            this.txtDebtCeiling.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDebtCeiling.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDebtCeiling.Location = new System.Drawing.Point(310, 396);
            this.txtDebtCeiling.Name = "txtDebtCeiling";
            this.txtDebtCeiling.Size = new System.Drawing.Size(57, 25);
            this.txtDebtCeiling.TabIndex = 25;
            this.txtDebtCeiling.Text = "0.00";
            // 
            // lblDebtCeiling
            // 
            this.lblDebtCeiling.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDebtCeiling.AutoSize = true;
            this.lblDebtCeiling.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDebtCeiling.Location = new System.Drawing.Point(481, 443);
            this.lblDebtCeiling.Name = "lblDebtCeiling";
            this.lblDebtCeiling.Size = new System.Drawing.Size(70, 17);
            this.lblDebtCeiling.TabIndex = 24;
            this.lblDebtCeiling.Text = "سقف الدين";
            // 
            // chkCreditAllowed
            // 
            this.chkCreditAllowed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkCreditAllowed.AutoSize = true;
            this.chkCreditAllowed.Location = new System.Drawing.Point(720, 401);
            this.chkCreditAllowed.Name = "chkCreditAllowed";
            this.chkCreditAllowed.Size = new System.Drawing.Size(15, 14);
            this.chkCreditAllowed.TabIndex = 23;
            this.chkCreditAllowed.UseVisualStyleBackColor = true;
            // 
            // lblCreditAllowed
            // 
            this.lblCreditAllowed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCreditAllowed.AutoSize = true;
            this.lblCreditAllowed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCreditAllowed.Location = new System.Drawing.Point(852, 400);
            this.lblCreditAllowed.Name = "lblCreditAllowed";
            this.lblCreditAllowed.Size = new System.Drawing.Size(67, 17);
            this.lblCreditAllowed.TabIndex = 22;
            this.lblCreditAllowed.Text = "منح السلف";
            // 
            // btnTariffDetail
            // 
            this.btnTariffDetail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTariffDetail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnTariffDetail.Location = new System.Drawing.Point(511, 352);
            this.btnTariffDetail.Name = "btnTariffDetail";
            this.btnTariffDetail.Size = new System.Drawing.Size(40, 27);
            this.btnTariffDetail.TabIndex = 21;
            this.btnTariffDetail.Text = "...";
            this.btnTariffDetail.UseVisualStyleBackColor = true;
            // 
            // cmbTariff
            // 
            this.cmbTariff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTariff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTariff.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbTariff.FormattingEnabled = true;
            this.cmbTariff.Items.AddRange(new object[] {
            "Détail"});
            this.cmbTariff.Location = new System.Drawing.Point(557, 353);
            this.cmbTariff.Name = "cmbTariff";
            this.cmbTariff.Size = new System.Drawing.Size(178, 25);
            this.cmbTariff.TabIndex = 20;
            // 
            // lblTariff
            // 
            this.lblTariff.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTariff.AutoSize = true;
            this.lblTariff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTariff.Location = new System.Drawing.Point(866, 357);
            this.lblTariff.Name = "lblTariff";
            this.lblTariff.Size = new System.Drawing.Size(53, 17);
            this.lblTariff.TabIndex = 19;
            this.lblTariff.Text = "التسعيرة";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtEmail, 3);
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtEmail.Location = new System.Drawing.Point(189, 310);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(546, 25);
            this.txtEmail.TabIndex = 18;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(828, 314);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(91, 17);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "البريد الالكتروني";
            // 
            // txtFax
            // 
            this.txtFax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFax.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtFax.Location = new System.Drawing.Point(189, 267);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(178, 25);
            this.txtFax.TabIndex = 16;
            // 
            // lblFax
            // 
            this.lblFax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFax.AutoSize = true;
            this.lblFax.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFax.Location = new System.Drawing.Point(504, 271);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(47, 17);
            this.lblFax.TabIndex = 15;
            this.lblFax.Text = "الفاكس";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPhone.Location = new System.Drawing.Point(557, 267);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(178, 25);
            this.txtPhone.TabIndex = 14;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(877, 271);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(42, 17);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "الهاتف";
            // 
            // txtCity
            // 
            this.txtCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtCity, 2);
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCity.Location = new System.Drawing.Point(373, 224);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(362, 25);
            this.txtCity.TabIndex = 12;
            // 
            // lblCity
            // 
            this.lblCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCity.Location = new System.Drawing.Point(874, 228);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(45, 17);
            this.lblCity.TabIndex = 11;
            this.lblCity.Text = "المدينة";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtAddress, 2);
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAddress.Location = new System.Drawing.Point(373, 181);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(362, 25);
            this.txtAddress.TabIndex = 10;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(873, 185);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(46, 17);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "العنوان";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtCustomerName, 2);
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCustomerName.Location = new System.Drawing.Point(373, 138);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(362, 25);
            this.txtCustomerName.TabIndex = 8;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.Location = new System.Drawing.Point(853, 142);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(66, 17);
            this.lblCustomerName.TabIndex = 7;
            this.lblCustomerName.Text = "إسم الزبون";
            // 
            // cmbSalesperson
            // 
            this.cmbSalesperson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cmbSalesperson, 2);
            this.cmbSalesperson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesperson.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbSalesperson.FormattingEnabled = true;
            this.cmbSalesperson.Location = new System.Drawing.Point(373, 95);
            this.cmbSalesperson.Name = "cmbSalesperson";
            this.cmbSalesperson.Size = new System.Drawing.Size(362, 25);
            this.cmbSalesperson.TabIndex = 6;
            // 
            // lblSalesperson
            // 
            this.lblSalesperson.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSalesperson.AutoSize = true;
            this.lblSalesperson.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSalesperson.Location = new System.Drawing.Point(885, 99);
            this.lblSalesperson.Name = "lblSalesperson";
            this.lblSalesperson.Size = new System.Drawing.Size(34, 17);
            this.lblSalesperson.TabIndex = 5;
            this.lblSalesperson.Text = "البائع";
            // 
            // cmbArea
            // 
            this.cmbArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cmbArea, 2);
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(373, 52);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(362, 25);
            this.cmbArea.TabIndex = 4;
            // 
            // lblArea
            // 
            this.lblArea.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblArea.Location = new System.Drawing.Point(867, 56);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(52, 17);
            this.lblArea.TabIndex = 3;
            this.lblArea.Text = "المنطقة";
            // 
            // btnAddCode
            // 
            this.btnAddCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddCode.Location = new System.Drawing.Point(327, 8);
            this.btnAddCode.Name = "btnAddCode";
            this.btnAddCode.Size = new System.Drawing.Size(40, 27);
            this.btnAddCode.TabIndex = 2;
            this.btnAddCode.Text = "+";
            this.btnAddCode.UseVisualStyleBackColor = true;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtCode, 2);
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCode.Location = new System.Drawing.Point(373, 9);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(362, 25);
            this.txtCode.TabIndex = 1;
            // 
            // lblCode
            // 
            this.lblCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCode.Location = new System.Drawing.Point(883, 13);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(36, 17);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "الكود";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbArea, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCIN, 3, 12);
            this.tableLayoutPanel1.Controls.Add(this.lblArea, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSalesperson, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPatente, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomerName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbSalesperson, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtICE, 3, 11);
            this.tableLayoutPanel1.Controls.Add(this.txtCustomerName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblAddress, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtIF, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.txtAddress, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblCity, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtPaymentTerm, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.txtCheckCeiling, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.txtCity, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblCheckCeiling, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.lblPhone, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtPhone, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtDebtCeiling, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblTariff, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblCreditAllowed, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.cmbTariff, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnTariffDetail, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.chkCreditAllowed, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblPaymentTerm, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnAddCode, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFax, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtFax, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblDebtCeiling, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.lblICE, 4, 11);
            this.tableLayoutPanel1.Controls.Add(this.lblCIN, 4, 12);
            this.tableLayoutPanel1.Controls.Add(this.lblIF, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.lblPatente, 2, 12);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692543F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692543F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692543F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692543F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692543F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692543F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692543F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692543F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692543F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692543F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692543F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692543F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.689466F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(922, 566);
            this.tableLayoutPanel1.TabIndex = 40;
            // 
            // frmAddEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 669);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAddEditCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fiche Client";
            this.pnlMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnAddCode;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label lblSalesperson;
        private System.Windows.Forms.ComboBox cmbSalesperson;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTariff;
        private System.Windows.Forms.ComboBox cmbTariff;
        private System.Windows.Forms.Button btnTariffDetail;
        private System.Windows.Forms.Label lblCreditAllowed;
        private System.Windows.Forms.CheckBox chkCreditAllowed;
        private System.Windows.Forms.Label lblDebtCeiling;
        private System.Windows.Forms.TextBox txtDebtCeiling;
        private System.Windows.Forms.Label lblPaymentTerm;
        private System.Windows.Forms.TextBox txtPaymentTerm;
        private System.Windows.Forms.Label lblCheckCeiling;
        private System.Windows.Forms.TextBox txtCheckCeiling;
        private System.Windows.Forms.Label lblIF;
        private System.Windows.Forms.TextBox txtIF;
        private System.Windows.Forms.Label lblICE;
        private System.Windows.Forms.TextBox txtICE;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblCIN;
        private System.Windows.Forms.TextBox txtCIN;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}