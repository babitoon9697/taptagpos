namespace TAPTAGPOS
{
    partial class paycreditclient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.txtDebt = new System.Windows.Forms.TextBox();
            this.lblDebt = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnFindCustomer = new System.Windows.Forms.Button();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.dgvDebts = new System.Windows.Forms.DataGridView();
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCurrentPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOldPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnDeselectAll = new System.Windows.Forms.Button();
            this.btnPrintList = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.txtDocumentNumber = new System.Windows.Forms.TextBox();
            this.lblDocumentNumber = new System.Windows.Forms.Label();
            this.gbPaymentMethod = new System.Windows.Forms.GroupBox();
            this.rbBankTransfer = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbEffect = new System.Windows.Forms.RadioButton();
            this.rbCheck = new System.Windows.Forms.RadioButton();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.txtTotalSum = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebts)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.gbPaymentMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlTop.Controls.Add(this.txtPayment);
            this.pnlTop.Controls.Add(this.lblPayment);
            this.pnlTop.Controls.Add(this.txtDebt);
            this.pnlTop.Controls.Add(this.lblDebt);
            this.pnlTop.Controls.Add(this.dtpDate);
            this.pnlTop.Controls.Add(this.lblDate);
            this.pnlTop.Controls.Add(this.btnFindCustomer);
            this.pnlTop.Controls.Add(this.cmbCustomer);
            this.pnlTop.Controls.Add(this.lblCustomer);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(984, 90);
            this.pnlTop.TabIndex = 0;
            // 
            // txtPayment
            // 
            this.txtPayment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.Location = new System.Drawing.Point(21, 52);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(150, 23);
            this.txtPayment.TabIndex = 8;
            this.txtPayment.Text = "0,00";
            this.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(177, 55);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(38, 16);
            this.lblPayment.TabIndex = 7;
            this.lblPayment.Text = "الدفع";
            // 
            // txtDebt
            // 
            this.txtDebt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebt.Location = new System.Drawing.Point(21, 19);
            this.txtDebt.Name = "txtDebt";
            this.txtDebt.ReadOnly = true;
            this.txtDebt.Size = new System.Drawing.Size(150, 23);
            this.txtDebt.TabIndex = 6;
            this.txtDebt.Text = "0,00";
            this.txtDebt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDebt
            // 
            this.lblDebt.AutoSize = true;
            this.lblDebt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebt.Location = new System.Drawing.Point(177, 22);
            this.lblDebt.Name = "lblDebt";
            this.lblDebt.Size = new System.Drawing.Size(37, 16);
            this.lblDebt.TabIndex = 5;
            this.lblDebt.Text = "الدين";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(734, 52);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(149, 23);
            this.dtpDate.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(889, 55);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 16);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "التاريخ";
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.Location = new System.Drawing.Point(509, 19);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(40, 25);
            this.btnFindCustomer.TabIndex = 2;
            this.btnFindCustomer.Text = "...";
            this.btnFindCustomer.UseVisualStyleBackColor = true;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(555, 19);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(328, 24);
            this.cmbCustomer.TabIndex = 1;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectionChangeCommitted);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(889, 22);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(43, 16);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "الزبون";
            // 
            // dgvDebts
            // 
            this.dgvDebts.AllowUserToAddRows = false;
            this.dgvDebts.AllowUserToDeleteRows = false;
            this.dgvDebts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDebts.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDebts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvDebts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDebts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.colCurrentPayment,
            this.colRemaining,
            this.colOldPayment,
            this.colTotal,
            this.colInvoice,
            this.colDate});
            this.dgvDebts.Location = new System.Drawing.Point(21, 96);
            this.dgvDebts.Name = "dgvDebts";
            this.dgvDebts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDebts.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvDebts.Size = new System.Drawing.Size(941, 230);
            this.dgvDebts.TabIndex = 1;
            this.dgvDebts.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDebts_CellValueChanged);
            this.dgvDebts.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvDebts_CurrentCellDirtyStateChanged);
            // 
            // colSelect
            // 
            this.colSelect.FillWeight = 50F;
            this.colSelect.HeaderText = "اختيار";
            this.colSelect.Name = "colSelect";
            // 
            // colCurrentPayment
            // 
            this.colCurrentPayment.HeaderText = "الدفع الحالي";
            this.colCurrentPayment.Name = "colCurrentPayment";
            // 
            // colRemaining
            // 
            this.colRemaining.HeaderText = "الباقي";
            this.colRemaining.Name = "colRemaining";
            this.colRemaining.ReadOnly = true;
            // 
            // colOldPayment
            // 
            this.colOldPayment.HeaderText = "الدفع القديم";
            this.colOldPayment.Name = "colOldPayment";
            this.colOldPayment.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "المجموع";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colInvoice
            // 
            this.colInvoice.HeaderText = "الفاتورة";
            this.colInvoice.Name = "colInvoice";
            this.colInvoice.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "التاريخ";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAll.Location = new System.Drawing.Point(847, 332);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(115, 30);
            this.btnSelectAll.TabIndex = 2;
            this.btnSelectAll.Text = "اختيار الكل";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnDeselectAll
            // 
            this.btnDeselectAll.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeselectAll.Location = new System.Drawing.Point(726, 332);
            this.btnDeselectAll.Name = "btnDeselectAll";
            this.btnDeselectAll.Size = new System.Drawing.Size(115, 30);
            this.btnDeselectAll.TabIndex = 3;
            this.btnDeselectAll.Text = "إلغاء الاختيار";
            this.btnDeselectAll.UseVisualStyleBackColor = true;
            this.btnDeselectAll.Click += new System.EventHandler(this.btnDeselectAll_Click);
            // 
            // btnPrintList
            // 
            this.btnPrintList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintList.Location = new System.Drawing.Point(605, 332);
            this.btnPrintList.Name = "btnPrintList";
            this.btnPrintList.Size = new System.Drawing.Size(115, 30);
            this.btnPrintList.TabIndex = 4;
            this.btnPrintList.Text = "طباعة اللائحة";
            this.btnPrintList.UseVisualStyleBackColor = true;
            this.btnPrintList.Click += new System.EventHandler(this.btnPrintList_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnConfirm);
            this.pnlBottom.Controls.Add(this.txtNotes);
            this.pnlBottom.Controls.Add(this.lblNotes);
            this.pnlBottom.Controls.Add(this.dtpDueDate);
            this.pnlBottom.Controls.Add(this.lblDueDate);
            this.pnlBottom.Controls.Add(this.txtBank);
            this.pnlBottom.Controls.Add(this.lblBank);
            this.pnlBottom.Controls.Add(this.txtDocumentNumber);
            this.pnlBottom.Controls.Add(this.lblDocumentNumber);
            this.pnlBottom.Controls.Add(this.gbPaymentMethod);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 395);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(984, 166);
            this.pnlBottom.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(34, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(34, 25);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(120, 50);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "تأكيد";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(198, 25);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(350, 116);
            this.txtNotes.TabIndex = 8;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(554, 25);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(61, 16);
            this.lblNotes.TabIndex = 7;
            this.lblNotes.Text = "ملاحظات";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(625, 84);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(180, 23);
            this.dtpDueDate.TabIndex = 6;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(811, 87);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(105, 16);
            this.lblDueDate.TabIndex = 5;
            this.lblDueDate.Text = "تاريخ الإستحقاق";
            // 
            // txtBank
            // 
            this.txtBank.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBank.Location = new System.Drawing.Point(625, 55);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(180, 23);
            this.txtBank.TabIndex = 4;
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBank.Location = new System.Drawing.Point(811, 58);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(37, 16);
            this.lblBank.TabIndex = 3;
            this.lblBank.Text = "البنك";
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentNumber.Location = new System.Drawing.Point(625, 25);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(180, 23);
            this.txtDocumentNumber.TabIndex = 2;
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentNumber.Location = new System.Drawing.Point(811, 28);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(74, 16);
            this.lblDocumentNumber.TabIndex = 1;
            this.lblDocumentNumber.Text = "رقم الوثيقة";
            // 
            // gbPaymentMethod
            // 
            this.gbPaymentMethod.Controls.Add(this.rbBankTransfer);
            this.gbPaymentMethod.Controls.Add(this.rbCash);
            this.gbPaymentMethod.Controls.Add(this.rbEffect);
            this.gbPaymentMethod.Controls.Add(this.rbCheck);
            this.gbPaymentMethod.Controls.Add(this.rbCreditCard);
            this.gbPaymentMethod.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPaymentMethod.Location = new System.Drawing.Point(625, 113);
            this.gbPaymentMethod.Name = "gbPaymentMethod";
            this.gbPaymentMethod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbPaymentMethod.Size = new System.Drawing.Size(337, 41);
            this.gbPaymentMethod.TabIndex = 0;
            this.gbPaymentMethod.TabStop = false;
            this.gbPaymentMethod.Text = "طريقة الدفع";
            // 
            // rbBankTransfer
            // 
            this.rbBankTransfer.AutoSize = true;
            this.rbBankTransfer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBankTransfer.Location = new System.Drawing.Point(6, 18);
            this.rbBankTransfer.Name = "rbBankTransfer";
            this.rbBankTransfer.Size = new System.Drawing.Size(49, 17);
            this.rbBankTransfer.TabIndex = 4;
            this.rbBankTransfer.TabStop = true;
            this.rbBankTransfer.Text = "حوالة";
            this.rbBankTransfer.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCash.Location = new System.Drawing.Point(67, 18);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(44, 17);
            this.rbCash.TabIndex = 3;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "نقود";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // rbEffect
            // 
            this.rbEffect.AutoSize = true;
            this.rbEffect.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEffect.Location = new System.Drawing.Point(120, 18);
            this.rbEffect.Name = "rbEffect";
            this.rbEffect.Size = new System.Drawing.Size(49, 17);
            this.rbEffect.TabIndex = 2;
            this.rbEffect.TabStop = true;
            this.rbEffect.Text = "Effet";
            this.rbEffect.UseVisualStyleBackColor = true;
            // 
            // rbCheck
            // 
            this.rbCheck.AutoSize = true;
            this.rbCheck.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCheck.Location = new System.Drawing.Point(178, 18);
            this.rbCheck.Name = "rbCheck";
            this.rbCheck.Size = new System.Drawing.Size(56, 17);
            this.rbCheck.TabIndex = 1;
            this.rbCheck.TabStop = true;
            this.rbCheck.Text = "الشيك";
            this.rbCheck.UseVisualStyleBackColor = true;
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCreditCard.Location = new System.Drawing.Point(235, 18);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(90, 17);
            this.rbCreditCard.TabIndex = 0;
            this.rbCreditCard.TabStop = true;
            this.rbCreditCard.Text = "البطاقة البنكية";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            // 
            // txtTotalSum
            // 
            this.txtTotalSum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSum.Location = new System.Drawing.Point(21, 336);
            this.txtTotalSum.Name = "txtTotalSum";
            this.txtTotalSum.ReadOnly = true;
            this.txtTotalSum.Size = new System.Drawing.Size(150, 23);
            this.txtTotalSum.TabIndex = 7;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.Location = new System.Drawing.Point(177, 339);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(53, 16);
            this.lblSum.TabIndex = 6;
            this.lblSum.Text = "Somme";
            // 
            // paycreditclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.txtTotalSum);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.btnPrintList);
            this.Controls.Add(this.btnDeselectAll);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.dgvDebts);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "paycreditclient";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسديد ديون الزبون";
            this.Load += new System.EventHandler(this.paycreditclient_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebts)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.gbPaymentMethod.ResumeLayout(false);
            this.gbPaymentMethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Button btnFindCustomer;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDebt;
        private System.Windows.Forms.Label lblDebt;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.DataGridView dgvDebts;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnDeselectAll;
        private System.Windows.Forms.Button btnPrintList;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TextBox txtTotalSum;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.GroupBox gbPaymentMethod;
        private System.Windows.Forms.RadioButton rbBankTransfer;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbEffect;
        private System.Windows.Forms.RadioButton rbCheck;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.Label lblDocumentNumber;
        private System.Windows.Forms.TextBox txtDocumentNumber;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOldPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
    }
}
