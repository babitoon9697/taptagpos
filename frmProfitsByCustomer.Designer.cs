using System.Windows.Forms;

namespace TAPTAGPOS
{
    partial class frmProfitsByCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.pnlTopSummary = new System.Windows.Forms.Panel();
            this.txtTotalPercentage = new System.Windows.Forms.TextBox();
            this.lblTotalPercentage = new System.Windows.Forms.Label();
            this.txtTotalProfitTop = new System.Windows.Forms.TextBox();
            this.lblTotalProfitTop = new System.Windows.Forms.Label();
            this.dgvProfits = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchaseValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBottomSummary = new System.Windows.Forms.Panel();
            this.txtNetProfit = new System.Windows.Forms.TextBox();
            this.lblNetProfit = new System.Windows.Forms.Label();
            this.txtExpenses = new System.Windows.Forms.TextBox();
            this.lblExpenses = new System.Windows.Forms.Label();
            this.txtTotalProfitBottom = new System.Windows.Forms.TextBox();
            this.lblTotalProfitBottom = new System.Windows.Forms.Label();
            this.pnlFilters.SuspendLayout();
            this.pnlTopSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfits)).BeginInit();
            this.pnlBottomSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFilters
            // 
            this.pnlFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlFilters.Controls.Add(this.btnSelectCustomer);
            this.pnlFilters.Controls.Add(this.cmbCustomer);
            this.pnlFilters.Controls.Add(this.lblCustomer);
            this.pnlFilters.Controls.Add(this.btnClose);
            this.pnlFilters.Controls.Add(this.btnPrint);
            this.pnlFilters.Controls.Add(this.btnConfirm);
            this.pnlFilters.Controls.Add(this.btnPeriod);
            this.pnlFilters.Controls.Add(this.dtpEndDate);
            this.pnlFilters.Controls.Add(this.lblEndDate);
            this.pnlFilters.Controls.Add(this.dtpStartDate);
            this.pnlFilters.Controls.Add(this.lblStartDate);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Location = new System.Drawing.Point(0, 0);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1084, 55);
            this.pnlFilters.TabIndex = 0;
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectCustomer.Location = new System.Drawing.Point(357, 17);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(35, 25);
            this.btnSelectCustomer.TabIndex = 11;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(398, 17);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(200, 25);
            this.cmbCustomer.TabIndex = 10;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCustomer.Location = new System.Drawing.Point(604, 21);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(40, 17);
            this.lblCustomer.TabIndex = 9;
            this.lblCustomer.Text = "الزبون";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 30);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "إغلاق";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Location = new System.Drawing.Point(108, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(90, 30);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "طباعة";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.Location = new System.Drawing.Point(204, 12);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(90, 30);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "تأكيد";
            // 
            // btnPeriod
            // 
            this.btnPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPeriod.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPeriod.Location = new System.Drawing.Point(659, 14);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(90, 30);
            this.btnPeriod.TabIndex = 5;
            this.btnPeriod.Text = "الفترة";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(755, 17);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(120, 25);
            this.dtpEndDate.TabIndex = 3;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEndDate.Location = new System.Drawing.Point(881, 21);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(69, 17);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "تاريخ النهاية";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(951, 17);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(120, 25);
            this.dtpStartDate.TabIndex = 1;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblStartDate.Location = new System.Drawing.Point(1168, 19);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(60, 17);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "تاريخ البدء";
            // 
            // pnlTopSummary
            // 
            this.pnlTopSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlTopSummary.Controls.Add(this.txtTotalPercentage);
            this.pnlTopSummary.Controls.Add(this.lblTotalPercentage);
            this.pnlTopSummary.Controls.Add(this.txtTotalProfitTop);
            this.pnlTopSummary.Controls.Add(this.lblTotalProfitTop);
            this.pnlTopSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopSummary.Location = new System.Drawing.Point(0, 55);
            this.pnlTopSummary.Name = "pnlTopSummary";
            this.pnlTopSummary.Size = new System.Drawing.Size(1084, 45);
            this.pnlTopSummary.TabIndex = 1;
            // 
            // txtTotalPercentage
            // 
            this.txtTotalPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPercentage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtTotalPercentage.Location = new System.Drawing.Point(725, 11);
            this.txtTotalPercentage.Name = "txtTotalPercentage";
            this.txtTotalPercentage.ReadOnly = true;
            this.txtTotalPercentage.Size = new System.Drawing.Size(120, 25);
            this.txtTotalPercentage.TabIndex = 3;
            // 
            // lblTotalPercentage
            // 
            this.lblTotalPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPercentage.AutoSize = true;
            this.lblTotalPercentage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTotalPercentage.Location = new System.Drawing.Point(851, 15);
            this.lblTotalPercentage.Name = "lblTotalPercentage";
            this.lblTotalPercentage.Size = new System.Drawing.Size(41, 17);
            this.lblTotalPercentage.TabIndex = 2;
            this.lblTotalPercentage.Text = "النسبة";
            // 
            // txtTotalProfitTop
            // 
            this.txtTotalProfitTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalProfitTop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtTotalProfitTop.Location = new System.Drawing.Point(907, 11);
            this.txtTotalProfitTop.Name = "txtTotalProfitTop";
            this.txtTotalProfitTop.ReadOnly = true;
            this.txtTotalProfitTop.Size = new System.Drawing.Size(120, 25);
            this.txtTotalProfitTop.TabIndex = 1;
            // 
            // lblTotalProfitTop
            // 
            this.lblTotalProfitTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalProfitTop.AutoSize = true;
            this.lblTotalProfitTop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTotalProfitTop.Location = new System.Drawing.Point(1033, 15);
            this.lblTotalProfitTop.Name = "lblTotalProfitTop";
            this.lblTotalProfitTop.Size = new System.Drawing.Size(38, 17);
            this.lblTotalProfitTop.TabIndex = 0;
            this.lblTotalProfitTop.Text = "الأرباح";
            // 
            // dgvProfits
            // 
            this.dgvProfits.AllowUserToAddRows = false;
            this.dgvProfits.AllowUserToDeleteRows = false;
            this.dgvProfits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProfits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProfits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colArticle,
            this.colSales,
            this.colPurchaseValue,
            this.colSaleValue,
            this.colProfit,
            this.colPercentage});
            this.dgvProfits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProfits.Location = new System.Drawing.Point(0, 100);
            this.dgvProfits.Name = "dgvProfits";
            this.dgvProfits.ReadOnly = true;
            this.dgvProfits.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvProfits.Size = new System.Drawing.Size(1084, 396);
            this.dgvProfits.TabIndex = 2;
            // 
            // colCode
            // 
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            // 
            // colArticle
            // 
            this.colArticle.Name = "colArticle";
            this.colArticle.ReadOnly = true;
            // 
            // colSales
            // 
            this.colSales.Name = "colSales";
            this.colSales.ReadOnly = true;
            // 
            // colPurchaseValue
            // 
            this.colPurchaseValue.Name = "colPurchaseValue";
            this.colPurchaseValue.ReadOnly = true;
            // 
            // colSaleValue
            // 
            this.colSaleValue.Name = "colSaleValue";
            this.colSaleValue.ReadOnly = true;
            // 
            // colProfit
            // 
            this.colProfit.Name = "colProfit";
            this.colProfit.ReadOnly = true;
            // 
            // colPercentage
            // 
            dataGridViewCellStyle3.Format = "P1";
            this.colPercentage.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPercentage.HeaderText = "النسبة";
            this.colPercentage.Name = "colPercentage";
            this.colPercentage.ReadOnly = true;
            // 
            // pnlBottomSummary
            // 
            this.pnlBottomSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlBottomSummary.Controls.Add(this.txtNetProfit);
            this.pnlBottomSummary.Controls.Add(this.lblNetProfit);
            this.pnlBottomSummary.Controls.Add(this.txtExpenses);
            this.pnlBottomSummary.Controls.Add(this.lblExpenses);
            this.pnlBottomSummary.Controls.Add(this.txtTotalProfitBottom);
            this.pnlBottomSummary.Controls.Add(this.lblTotalProfitBottom);
            this.pnlBottomSummary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomSummary.Location = new System.Drawing.Point(0, 496);
            this.pnlBottomSummary.Name = "pnlBottomSummary";
            this.pnlBottomSummary.Size = new System.Drawing.Size(1084, 65);
            this.pnlBottomSummary.TabIndex = 3;
            // 
            // txtNetProfit
            // 
            this.txtNetProfit.Location = new System.Drawing.Point(0, 0);
            this.txtNetProfit.Name = "txtNetProfit";
            this.txtNetProfit.Size = new System.Drawing.Size(100, 22);
            this.txtNetProfit.TabIndex = 0;
            // 
            // lblNetProfit
            // 
            this.lblNetProfit.Location = new System.Drawing.Point(0, 0);
            this.lblNetProfit.Name = "lblNetProfit";
            this.lblNetProfit.Size = new System.Drawing.Size(100, 23);
            this.lblNetProfit.TabIndex = 1;
            // 
            // txtExpenses
            // 
            this.txtExpenses.Location = new System.Drawing.Point(0, 0);
            this.txtExpenses.Name = "txtExpenses";
            this.txtExpenses.Size = new System.Drawing.Size(100, 22);
            this.txtExpenses.TabIndex = 2;
            // 
            // lblExpenses
            // 
            this.lblExpenses.Location = new System.Drawing.Point(0, 0);
            this.lblExpenses.Name = "lblExpenses";
            this.lblExpenses.Size = new System.Drawing.Size(100, 23);
            this.lblExpenses.TabIndex = 3;
            // 
            // txtTotalProfitBottom
            // 
            this.txtTotalProfitBottom.Location = new System.Drawing.Point(0, 0);
            this.txtTotalProfitBottom.Name = "txtTotalProfitBottom";
            this.txtTotalProfitBottom.Size = new System.Drawing.Size(100, 22);
            this.txtTotalProfitBottom.TabIndex = 4;
            // 
            // lblTotalProfitBottom
            // 
            this.lblTotalProfitBottom.Location = new System.Drawing.Point(0, 0);
            this.lblTotalProfitBottom.Name = "lblTotalProfitBottom";
            this.lblTotalProfitBottom.Size = new System.Drawing.Size(100, 23);
            this.lblTotalProfitBottom.TabIndex = 5;
            // 
            // frmProfitsByCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.dgvProfits);
            this.Controls.Add(this.pnlBottomSummary);
            this.Controls.Add(this.pnlTopSummary);
            this.Controls.Add(this.pnlFilters);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmProfitsByCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تقرير الأرباح حسب الزبون";
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.pnlTopSummary.ResumeLayout(false);
            this.pnlTopSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfits)).EndInit();
            this.pnlBottomSummary.ResumeLayout(false);
            this.pnlBottomSummary.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        // ... Declarations ...
        private System.Windows.Forms.Panel pnlFilters;
        private Button btnSelectCustomer;
        private ComboBox cmbCustomer;
        private Label lblCustomer;
        private Button btnClose;
        private Button btnPrint;
        private Button btnConfirm;
        private Button btnPeriod;
        private DateTimePicker dtpEndDate;
        private Label lblEndDate;
        private DateTimePicker dtpStartDate;
        private System.Windows.Forms.Panel pnlTopSummary;
        private TextBox txtTotalPercentage;
        private Label lblTotalPercentage;
        private TextBox txtTotalProfitTop;
        private Label lblTotalProfitTop;
        private System.Windows.Forms.Panel pnlBottomSummary;


        private TextBox txtNetProfit;
        private Label lblExpenses;
        private Label lblNetProfit;
        private TextBox txtExpenses;
        private Label lblTotalProfitBottom;
        private TextBox txtTotalProfitBottom;
        private System.Windows.Forms.DataGridView dgvProfits;
        private DataGridViewTextBoxColumn colCode;
        private DataGridViewTextBoxColumn colArticle;
        private DataGridViewTextBoxColumn colSales;
        private DataGridViewTextBoxColumn colPurchaseValue;
        private DataGridViewTextBoxColumn colSaleValue;
        private System.Windows.Forms.Label lblStartDate;
        private DataGridViewTextBoxColumn colProfit;
        private DataGridViewTextBoxColumn colPercentage;
        // ... all other declarations
    }
}