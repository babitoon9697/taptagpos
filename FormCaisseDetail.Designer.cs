namespace TAPTAGPOS
{
    partial class FormCaisseDetail
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTotals = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCash = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.txtChecks = new System.Windows.Forms.TextBox();
            this.txtReturns = new System.Windows.Forms.TextBox();
            this.labelChecks = new System.Windows.Forms.Label();
            this.labelReturns = new System.Windows.Forms.Label();
            this.labelBankCard = new System.Windows.Forms.Label();
            this.txtExpenses = new System.Windows.Forms.TextBox();
            this.txtBankCard = new System.Windows.Forms.TextBox();
            this.labelExpenses = new System.Windows.Forms.Label();
            this.labelCredit = new System.Windows.Forms.Label();
            this.txtPromissoryNote = new System.Windows.Forms.TextBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.labelPromissoryNote = new System.Windows.Forms.Label();
            this.labelBankTransfer = new System.Windows.Forms.Label();
            this.txtBankTransfer = new System.Windows.Forms.TextBox();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelStartingCash = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.labelTotalCash = new System.Windows.Forms.Label();
            this.txtCarriedOver = new System.Windows.Forms.TextBox();
            this.txtTotalCash = new System.Windows.Forms.TextBox();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelCarriedOver = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtStartingCash = new System.Windows.Forms.TextBox();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrintZ = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelTotals.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.panelTotals);
            this.panelMain.Controls.Add(this.dgvTransactions);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1056, 687);
            this.panelMain.TabIndex = 0;
            // 
            // panelTotals
            // 
            this.panelTotals.BackColor = System.Drawing.Color.Khaki;
            this.panelTotals.Controls.Add(this.tableLayoutPanel1);
            this.panelTotals.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTotals.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.panelTotals.Location = new System.Drawing.Point(889, 182);
            this.panelTotals.Margin = new System.Windows.Forms.Padding(2);
            this.panelTotals.Name = "panelTotals";
            this.panelTotals.Size = new System.Drawing.Size(165, 503);
            this.panelTotals.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelCash, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDiscount, 0, 17);
            this.tableLayoutPanel1.Controls.Add(this.txtCash, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelDiscount, 0, 16);
            this.tableLayoutPanel1.Controls.Add(this.txtChecks, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtReturns, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.labelChecks, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelReturns, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.labelBankCard, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtExpenses, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.txtBankCard, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelExpenses, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.labelCredit, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtPromissoryNote, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.txtCredit, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelPromissoryNote, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.labelBankTransfer, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtBankTransfer, 0, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 18;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.847952F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.847952F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.847952F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.847952F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.847952F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.847952F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.847952F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.847952F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263157F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.847952F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(165, 503);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // labelCash
            // 
            this.labelCash.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelCash.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCash.Location = new System.Drawing.Point(26, 7);
            this.labelCash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCash.Name = "labelCash";
            this.labelCash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelCash.Size = new System.Drawing.Size(112, 19);
            this.labelCash.TabIndex = 4;
            this.labelCash.Text = "النقد";
            this.labelCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscount.Location = new System.Drawing.Point(2, 468);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(161, 26);
            this.txtDiscount.TabIndex = 21;
            // 
            // txtCash
            // 
            this.txtCash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCash.Location = new System.Drawing.Point(2, 28);
            this.txtCash.Margin = new System.Windows.Forms.Padding(2);
            this.txtCash.Name = "txtCash";
            this.txtCash.ReadOnly = true;
            this.txtCash.Size = new System.Drawing.Size(161, 26);
            this.txtCash.TabIndex = 5;
            // 
            // labelDiscount
            // 
            this.labelDiscount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelDiscount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscount.Location = new System.Drawing.Point(26, 447);
            this.labelDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelDiscount.Size = new System.Drawing.Size(112, 19);
            this.labelDiscount.TabIndex = 20;
            this.labelDiscount.Text = "الخصم";
            this.labelDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtChecks
            // 
            this.txtChecks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChecks.Location = new System.Drawing.Point(2, 83);
            this.txtChecks.Margin = new System.Windows.Forms.Padding(2);
            this.txtChecks.Name = "txtChecks";
            this.txtChecks.ReadOnly = true;
            this.txtChecks.Size = new System.Drawing.Size(161, 26);
            this.txtChecks.TabIndex = 7;
            // 
            // txtReturns
            // 
            this.txtReturns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReturns.Location = new System.Drawing.Point(2, 413);
            this.txtReturns.Margin = new System.Windows.Forms.Padding(2);
            this.txtReturns.Name = "txtReturns";
            this.txtReturns.ReadOnly = true;
            this.txtReturns.Size = new System.Drawing.Size(161, 26);
            this.txtReturns.TabIndex = 19;
            // 
            // labelChecks
            // 
            this.labelChecks.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelChecks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChecks.Location = new System.Drawing.Point(26, 62);
            this.labelChecks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChecks.Name = "labelChecks";
            this.labelChecks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelChecks.Size = new System.Drawing.Size(112, 19);
            this.labelChecks.TabIndex = 6;
            this.labelChecks.Text = "الشيكات";
            this.labelChecks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelReturns
            // 
            this.labelReturns.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelReturns.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturns.Location = new System.Drawing.Point(26, 392);
            this.labelReturns.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReturns.Name = "labelReturns";
            this.labelReturns.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelReturns.Size = new System.Drawing.Size(112, 19);
            this.labelReturns.TabIndex = 18;
            this.labelReturns.Text = "الإرجاع";
            this.labelReturns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBankCard
            // 
            this.labelBankCard.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelBankCard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBankCard.Location = new System.Drawing.Point(26, 117);
            this.labelBankCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBankCard.Name = "labelBankCard";
            this.labelBankCard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelBankCard.Size = new System.Drawing.Size(112, 19);
            this.labelBankCard.TabIndex = 8;
            this.labelBankCard.Text = "البطاقة البنكية";
            this.labelBankCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtExpenses
            // 
            this.txtExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExpenses.Location = new System.Drawing.Point(2, 358);
            this.txtExpenses.Margin = new System.Windows.Forms.Padding(2);
            this.txtExpenses.Name = "txtExpenses";
            this.txtExpenses.ReadOnly = true;
            this.txtExpenses.Size = new System.Drawing.Size(161, 26);
            this.txtExpenses.TabIndex = 17;
            // 
            // txtBankCard
            // 
            this.txtBankCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankCard.Location = new System.Drawing.Point(2, 138);
            this.txtBankCard.Margin = new System.Windows.Forms.Padding(2);
            this.txtBankCard.Name = "txtBankCard";
            this.txtBankCard.ReadOnly = true;
            this.txtBankCard.Size = new System.Drawing.Size(161, 26);
            this.txtBankCard.TabIndex = 9;
            // 
            // labelExpenses
            // 
            this.labelExpenses.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelExpenses.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpenses.Location = new System.Drawing.Point(26, 337);
            this.labelExpenses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExpenses.Name = "labelExpenses";
            this.labelExpenses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelExpenses.Size = new System.Drawing.Size(112, 19);
            this.labelExpenses.TabIndex = 16;
            this.labelExpenses.Text = "المصاريف";
            this.labelExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCredit
            // 
            this.labelCredit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelCredit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredit.Location = new System.Drawing.Point(26, 172);
            this.labelCredit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelCredit.Size = new System.Drawing.Size(112, 19);
            this.labelCredit.TabIndex = 10;
            this.labelCredit.Text = "الدين";
            this.labelCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPromissoryNote
            // 
            this.txtPromissoryNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPromissoryNote.Location = new System.Drawing.Point(2, 303);
            this.txtPromissoryNote.Margin = new System.Windows.Forms.Padding(2);
            this.txtPromissoryNote.Name = "txtPromissoryNote";
            this.txtPromissoryNote.ReadOnly = true;
            this.txtPromissoryNote.Size = new System.Drawing.Size(161, 26);
            this.txtPromissoryNote.TabIndex = 15;
            // 
            // txtCredit
            // 
            this.txtCredit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCredit.Location = new System.Drawing.Point(2, 193);
            this.txtCredit.Margin = new System.Windows.Forms.Padding(2);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.ReadOnly = true;
            this.txtCredit.Size = new System.Drawing.Size(161, 26);
            this.txtCredit.TabIndex = 11;
            // 
            // labelPromissoryNote
            // 
            this.labelPromissoryNote.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPromissoryNote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPromissoryNote.Location = new System.Drawing.Point(26, 282);
            this.labelPromissoryNote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPromissoryNote.Name = "labelPromissoryNote";
            this.labelPromissoryNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelPromissoryNote.Size = new System.Drawing.Size(112, 19);
            this.labelPromissoryNote.TabIndex = 14;
            this.labelPromissoryNote.Text = "كمبيالة";
            this.labelPromissoryNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBankTransfer
            // 
            this.labelBankTransfer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelBankTransfer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBankTransfer.Location = new System.Drawing.Point(26, 227);
            this.labelBankTransfer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBankTransfer.Name = "labelBankTransfer";
            this.labelBankTransfer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelBankTransfer.Size = new System.Drawing.Size(112, 19);
            this.labelBankTransfer.TabIndex = 12;
            this.labelBankTransfer.Text = "حوالة بنكية";
            this.labelBankTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBankTransfer
            // 
            this.txtBankTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankTransfer.Location = new System.Drawing.Point(2, 248);
            this.txtBankTransfer.Margin = new System.Windows.Forms.Padding(2);
            this.txtBankTransfer.Name = "txtBankTransfer";
            this.txtBankTransfer.ReadOnly = true;
            this.txtBankTransfer.Size = new System.Drawing.Size(161, 26);
            this.txtBankTransfer.TabIndex = 13;
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colTime,
            this.colOrderNum,
            this.colCustomer,
            this.colAmount});
            this.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransactions.Location = new System.Drawing.Point(0, 182);
            this.dgvTransactions.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTransactions.RowHeadersVisible = false;
            this.dgvTransactions.RowHeadersWidth = 51;
            this.dgvTransactions.RowTemplate.Height = 24;
            this.dgvTransactions.Size = new System.Drawing.Size(1054, 503);
            this.dgvTransactions.TabIndex = 1;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "التاريخ";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colTime
            // 
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.colTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTime.HeaderText = "الساعة";
            this.colTime.MinimumWidth = 6;
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            // 
            // colOrderNum
            // 
            this.colOrderNum.HeaderText = "رقم الطلب";
            this.colOrderNum.MinimumWidth = 6;
            this.colOrderNum.Name = "colOrderNum";
            this.colOrderNum.ReadOnly = true;
            // 
            // colCustomer
            // 
            this.colCustomer.FillWeight = 150F;
            this.colCustomer.HeaderText = "الزبون";
            this.colCustomer.MinimumWidth = 6;
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "المبلغ";
            this.colAmount.MinimumWidth = 6;
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.tableLayoutPanel3);
            this.panelHeader.Controls.Add(this.tableLayoutPanel2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1054, 182);
            this.panelHeader.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.txtEndDate, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelStartDate, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelStartingCash, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelUser, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelEndTime, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtEndTime, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.labelTotalCash, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtCarriedOver, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtTotalCash, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelEndDate, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelCarriedOver, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtUser, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtStartDate, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtStartingCash, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtStartTime, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelStartTime, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(11, 11);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(826, 161);
            this.tableLayoutPanel3.TabIndex = 19;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Location = new System.Drawing.Point(415, 82);
            this.txtEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(294, 26);
            this.txtEndDate.TabIndex = 18;
            // 
            // labelStartDate
            // 
            this.labelStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelStartDate.Font = new System.Drawing.Font("Arial", 11.5F, System.Drawing.FontStyle.Bold);
            this.labelStartDate.Location = new System.Drawing.Point(713, 10);
            this.labelStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelStartDate.Size = new System.Drawing.Size(111, 19);
            this.labelStartDate.TabIndex = 6;
            this.labelStartDate.Text = "تاريخ البدأ";
            // 
            // labelStartingCash
            // 
            this.labelStartingCash.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelStartingCash.Font = new System.Drawing.Font("Arial", 11.5F, System.Drawing.FontStyle.Bold);
            this.labelStartingCash.Location = new System.Drawing.Point(742, 50);
            this.labelStartingCash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartingCash.Name = "labelStartingCash";
            this.labelStartingCash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelStartingCash.Size = new System.Drawing.Size(82, 19);
            this.labelStartingCash.TabIndex = 8;
            this.labelStartingCash.Text = "مبلغ البدأ";
            // 
            // labelUser
            // 
            this.labelUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelUser.Font = new System.Drawing.Font("Arial", 11.5F, System.Drawing.FontStyle.Bold);
            this.labelUser.Location = new System.Drawing.Point(329, 50);
            this.labelUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelUser.Size = new System.Drawing.Size(82, 19);
            this.labelUser.TabIndex = 4;
            this.labelUser.Text = "البائع";
            // 
            // labelEndTime
            // 
            this.labelEndTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelEndTime.Font = new System.Drawing.Font("Arial", 11.5F, System.Drawing.FontStyle.Bold);
            this.labelEndTime.Location = new System.Drawing.Point(329, 131);
            this.labelEndTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelEndTime.Size = new System.Drawing.Size(82, 19);
            this.labelEndTime.TabIndex = 12;
            this.labelEndTime.Text = "ساعة الإغلاق";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndTime.Location = new System.Drawing.Point(2, 122);
            this.txtEndTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.ReadOnly = true;
            this.txtEndTime.Size = new System.Drawing.Size(294, 26);
            this.txtEndTime.TabIndex = 13;
            // 
            // labelTotalCash
            // 
            this.labelTotalCash.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTotalCash.Font = new System.Drawing.Font("Arial", 11.5F, System.Drawing.FontStyle.Bold);
            this.labelTotalCash.Location = new System.Drawing.Point(300, 90);
            this.labelTotalCash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalCash.Name = "labelTotalCash";
            this.labelTotalCash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTotalCash.Size = new System.Drawing.Size(111, 19);
            this.labelTotalCash.TabIndex = 10;
            this.labelTotalCash.Text = "النقد";
            this.labelTotalCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCarriedOver
            // 
            this.txtCarriedOver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCarriedOver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarriedOver.Location = new System.Drawing.Point(415, 122);
            this.txtCarriedOver.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarriedOver.Name = "txtCarriedOver";
            this.txtCarriedOver.ReadOnly = true;
            this.txtCarriedOver.Size = new System.Drawing.Size(294, 26);
            this.txtCarriedOver.TabIndex = 17;
            // 
            // txtTotalCash
            // 
            this.txtTotalCash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalCash.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCash.Location = new System.Drawing.Point(2, 82);
            this.txtTotalCash.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalCash.Name = "txtTotalCash";
            this.txtTotalCash.ReadOnly = true;
            this.txtTotalCash.Size = new System.Drawing.Size(294, 26);
            this.txtTotalCash.TabIndex = 11;
            // 
            // labelEndDate
            // 
            this.labelEndDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelEndDate.Font = new System.Drawing.Font("Arial", 11.5F, System.Drawing.FontStyle.Bold);
            this.labelEndDate.Location = new System.Drawing.Point(713, 90);
            this.labelEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelEndDate.Size = new System.Drawing.Size(111, 19);
            this.labelEndDate.TabIndex = 14;
            this.labelEndDate.Text = "تاريخ الإغلاق";
            // 
            // labelCarriedOver
            // 
            this.labelCarriedOver.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCarriedOver.Font = new System.Drawing.Font("Arial", 11.5F, System.Drawing.FontStyle.Bold);
            this.labelCarriedOver.Location = new System.Drawing.Point(742, 131);
            this.labelCarriedOver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCarriedOver.Name = "labelCarriedOver";
            this.labelCarriedOver.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelCarriedOver.Size = new System.Drawing.Size(82, 19);
            this.labelCarriedOver.TabIndex = 16;
            this.labelCarriedOver.Text = "المنقول";
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(2, 42);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(294, 26);
            this.txtUser.TabIndex = 5;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(415, 2);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(294, 26);
            this.txtStartDate.TabIndex = 7;
            // 
            // txtStartingCash
            // 
            this.txtStartingCash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartingCash.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartingCash.Location = new System.Drawing.Point(415, 42);
            this.txtStartingCash.Margin = new System.Windows.Forms.Padding(2);
            this.txtStartingCash.Name = "txtStartingCash";
            this.txtStartingCash.ReadOnly = true;
            this.txtStartingCash.Size = new System.Drawing.Size(294, 26);
            this.txtStartingCash.TabIndex = 9;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartTime.Location = new System.Drawing.Point(2, 2);
            this.txtStartTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.ReadOnly = true;
            this.txtStartTime.Size = new System.Drawing.Size(294, 26);
            this.txtStartTime.TabIndex = 3;
            // 
            // labelStartTime
            // 
            this.labelStartTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelStartTime.Font = new System.Drawing.Font("Arial", 11.5F, System.Drawing.FontStyle.Bold);
            this.labelStartTime.Location = new System.Drawing.Point(329, 10);
            this.labelStartTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelStartTime.Size = new System.Drawing.Size(82, 19);
            this.labelStartTime.TabIndex = 2;
            this.labelStartTime.Text = "ساعة البدأ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnPrintReceipt, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnConfirm, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnExit, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnPrintZ, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(843, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 164);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintReceipt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrintReceipt.Location = new System.Drawing.Point(2, 2);
            this.btnPrintReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(96, 78);
            this.btnPrintReceipt.TabIndex = 1;
            this.btnPrintReceipt.Text = "طباعة السلعة";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.Location = new System.Drawing.Point(102, 2);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(96, 78);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "تأكيد";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(102, 84);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 78);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnPrintZ
            // 
            this.btnPrintZ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintZ.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrintZ.Location = new System.Drawing.Point(2, 84);
            this.btnPrintZ.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintZ.Name = "btnPrintZ";
            this.btnPrintZ.Size = new System.Drawing.Size(96, 78);
            this.btnPrintZ.TabIndex = 2;
            this.btnPrintZ.Text = "طباعة Z";
            this.btnPrintZ.UseVisualStyleBackColor = true;
            // 
            // FormCaisseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 687);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCaisseDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "الصندوق";
            this.panelMain.ResumeLayout(false);
            this.panelTotals.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Panel panelTotals;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrintZ;
        private System.Windows.Forms.Label labelCash;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.TextBox txtChecks;
        private System.Windows.Forms.Label labelChecks;
        private System.Windows.Forms.TextBox txtBankCard;
        private System.Windows.Forms.Label labelBankCard;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Label labelCredit;
        private System.Windows.Forms.TextBox txtBankTransfer;
        private System.Windows.Forms.Label labelBankTransfer;
        private System.Windows.Forms.TextBox txtPromissoryNote;
        private System.Windows.Forms.Label labelPromissoryNote;
        private System.Windows.Forms.TextBox txtExpenses;
        private System.Windows.Forms.Label labelExpenses;
        private System.Windows.Forms.TextBox txtReturns;
        private System.Windows.Forms.Label labelReturns;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelStartingCash;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Label labelTotalCash;
        private System.Windows.Forms.TextBox txtCarriedOver;
        private System.Windows.Forms.TextBox txtTotalCash;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelCarriedOver;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtStartingCash;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label labelStartTime;
    }
}