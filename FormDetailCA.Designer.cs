namespace TAPTAGPOS
{
    partial class FormDetailCA
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
            this.panelFilters = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnPeriode = new System.Windows.Forms.Button();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.dgvCA = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchaseValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.txtNetProfit = new System.Windows.Forms.TextBox();
            this.labelNetProfit = new System.Windows.Forms.Label();
            this.txtExpenses = new System.Windows.Forms.TextBox();
            this.labelExpenses = new System.Windows.Forms.Label();
            this.txtGrossProfit = new System.Windows.Forms.TextBox();
            this.labelGrossProfit = new System.Windows.Forms.Label();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCA)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.btnClose);
            this.panelFilters.Controls.Add(this.btnPrint);
            this.panelFilters.Controls.Add(this.btnConfirm);
            this.panelFilters.Controls.Add(this.btnPeriode);
            this.panelFilters.Controls.Add(this.dtpDateFin);
            this.panelFilters.Controls.Add(this.labelDateFin);
            this.panelFilters.Controls.Add(this.dtpDateDebut);
            this.panelFilters.Controls.Add(this.labelDateDebut);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(738, 53);
            this.panelFilters.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(645, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 28);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Location = new System.Drawing.Point(556, 15);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 28);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.Location = new System.Drawing.Point(466, 15);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(85, 28);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "تأكيد";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnPeriode
            // 
            this.btnPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnPeriode.Location = new System.Drawing.Point(338, 15);
            this.btnPeriode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPeriode.Name = "btnPeriode";
            this.btnPeriode.Size = new System.Drawing.Size(90, 28);
            this.btnPeriode.TabIndex = 4;
            this.btnPeriode.Text = "الفترة";
            this.btnPeriode.UseVisualStyleBackColor = true;
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpDateFin.Location = new System.Drawing.Point(180, 20);
            this.dtpDateFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(136, 21);
            this.dtpDateFin.TabIndex = 3;
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelDateFin.Location = new System.Drawing.Point(178, 2);
            this.labelDateFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(66, 15);
            this.labelDateFin.TabIndex = 2;
            this.labelDateFin.Text = "Date de fin";
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpDateDebut.Location = new System.Drawing.Point(20, 20);
            this.dtpDateDebut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(136, 21);
            this.dtpDateDebut.TabIndex = 1;
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelDateDebut.Location = new System.Drawing.Point(17, 2);
            this.labelDateDebut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(84, 15);
            this.labelDateDebut.TabIndex = 0;
            this.labelDateDebut.Text = "Date de début";
            // 
            // dgvCA
            // 
            this.dgvCA.AllowUserToAddRows = false;
            this.dgvCA.AllowUserToDeleteRows = false;
            this.dgvCA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCA.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colItem,
            this.colSales,
            this.colPurchaseValue,
            this.colSaleValue,
            this.colProfit});
            this.dgvCA.EnableHeadersVisualStyles = false;
            this.dgvCA.Location = new System.Drawing.Point(9, 58);
            this.dgvCA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCA.Name = "dgvCA";
            this.dgvCA.ReadOnly = true;
            this.dgvCA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCA.RowHeadersVisible = false;
            this.dgvCA.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dgvCA.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCA.RowTemplate.Height = 24;
            this.dgvCA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCA.Size = new System.Drawing.Size(718, 349);
            this.dgvCA.TabIndex = 1;
            // 
            // colCode
            // 
            this.colCode.HeaderText = "كود";
            this.colCode.MinimumWidth = 6;
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            // 
            // colItem
            // 
            this.colItem.FillWeight = 150F;
            this.colItem.HeaderText = "السلعة";
            this.colItem.MinimumWidth = 6;
            this.colItem.Name = "colItem";
            this.colItem.ReadOnly = true;
            // 
            // colSales
            // 
            this.colSales.HeaderText = "المبيعات";
            this.colSales.MinimumWidth = 6;
            this.colSales.Name = "colSales";
            this.colSales.ReadOnly = true;
            // 
            // colPurchaseValue
            // 
            this.colPurchaseValue.HeaderText = "قيمة الشراء";
            this.colPurchaseValue.MinimumWidth = 6;
            this.colPurchaseValue.Name = "colPurchaseValue";
            this.colPurchaseValue.ReadOnly = true;
            // 
            // colSaleValue
            // 
            this.colSaleValue.HeaderText = "قيمة البيع";
            this.colSaleValue.MinimumWidth = 6;
            this.colSaleValue.Name = "colSaleValue";
            this.colSaleValue.ReadOnly = true;
            // 
            // colProfit
            // 
            this.colProfit.HeaderText = "الربح";
            this.colProfit.MinimumWidth = 6;
            this.colProfit.Name = "colProfit";
            this.colProfit.ReadOnly = true;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.txtNetProfit);
            this.panelFooter.Controls.Add(this.labelNetProfit);
            this.panelFooter.Controls.Add(this.txtExpenses);
            this.panelFooter.Controls.Add(this.labelExpenses);
            this.panelFooter.Controls.Add(this.txtGrossProfit);
            this.panelFooter.Controls.Add(this.labelGrossProfit);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 419);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(738, 37);
            this.panelFooter.TabIndex = 2;
            // 
            // txtNetProfit
            // 
            this.txtNetProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNetProfit.Location = new System.Drawing.Point(618, 10);
            this.txtNetProfit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNetProfit.Name = "txtNetProfit";
            this.txtNetProfit.ReadOnly = true;
            this.txtNetProfit.Size = new System.Drawing.Size(112, 20);
            this.txtNetProfit.TabIndex = 5;
            // 
            // labelNetProfit
            // 
            this.labelNetProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNetProfit.AutoSize = true;
            this.labelNetProfit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelNetProfit.Location = new System.Drawing.Point(534, 11);
            this.labelNetProfit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNetProfit.Name = "labelNetProfit";
            this.labelNetProfit.Size = new System.Drawing.Size(83, 14);
            this.labelNetProfit.TabIndex = 4;
            this.labelNetProfit.Text = "الربح الصافي";
            // 
            // txtExpenses
            // 
            this.txtExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExpenses.Location = new System.Drawing.Point(410, 10);
            this.txtExpenses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExpenses.Name = "txtExpenses";
            this.txtExpenses.ReadOnly = true;
            this.txtExpenses.Size = new System.Drawing.Size(112, 20);
            this.txtExpenses.TabIndex = 3;
            // 
            // labelExpenses
            // 
            this.labelExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExpenses.AutoSize = true;
            this.labelExpenses.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelExpenses.Location = new System.Drawing.Point(348, 11);
            this.labelExpenses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExpenses.Name = "labelExpenses";
            this.labelExpenses.Size = new System.Drawing.Size(62, 14);
            this.labelExpenses.TabIndex = 2;
            this.labelExpenses.Text = "المصاريف";
            // 
            // txtGrossProfit
            // 
            this.txtGrossProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGrossProfit.Location = new System.Drawing.Point(226, 10);
            this.txtGrossProfit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGrossProfit.Name = "txtGrossProfit";
            this.txtGrossProfit.ReadOnly = true;
            this.txtGrossProfit.Size = new System.Drawing.Size(112, 20);
            this.txtGrossProfit.TabIndex = 1;
            // 
            // labelGrossProfit
            // 
            this.labelGrossProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGrossProfit.AutoSize = true;
            this.labelGrossProfit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelGrossProfit.Location = new System.Drawing.Point(161, 11);
            this.labelGrossProfit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGrossProfit.Name = "labelGrossProfit";
            this.labelGrossProfit.Size = new System.Drawing.Size(41, 14);
            this.labelGrossProfit.TabIndex = 0;
            this.labelGrossProfit.Text = "الأرباح";
            // 
            // FormDetailCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 456);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.dgvCA);
            this.Controls.Add(this.panelFilters);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(754, 495);
            this.Name = "FormDetailCA";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chiffre d\'affaire";
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCA)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.DataGridView dgvCA;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.Button btnPeriode;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchaseValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfit;
        private System.Windows.Forms.Label labelGrossProfit;
        private System.Windows.Forms.TextBox txtGrossProfit;
        private System.Windows.Forms.TextBox txtExpenses;
        private System.Windows.Forms.Label labelExpenses;
        private System.Windows.Forms.TextBox txtNetProfit;
        private System.Windows.Forms.Label labelNetProfit;
    }
}