namespace TAPTAGPOS // <-- IMPORTANT: Change this to your project's actual namespace
{
    partial class InvoicesForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelAll = new System.Windows.Forms.Label();
            this.comboBoxAll = new System.Windows.Forms.ComboBox();
            this.labelSeller = new System.Windows.Forms.Label();
            this.dataGridViewInvoices = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDaysRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.buttonPrint);
            this.panelTop.Controls.Add(this.buttonConfirm);
            this.panelTop.Controls.Add(this.textBoxSearch);
            this.panelTop.Controls.Add(this.labelAll);
            this.panelTop.Controls.Add(this.comboBoxAll);
            this.panelTop.Controls.Add(this.labelSeller);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(856, 53);
            this.panelTop.TabIndex = 0;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPrint.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPrint.Location = new System.Drawing.Point(776, 11);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(70, 31);
            this.buttonPrint.TabIndex = 5;
            this.buttonPrint.Text = "طباعة";
            this.buttonPrint.UseVisualStyleBackColor = false;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.buttonConfirm.FlatAppearance.BorderSize = 0;
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonConfirm.Location = new System.Drawing.Point(455, 11);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(90, 31);
            this.buttonConfirm.TabIndex = 4;
            this.buttonConfirm.Text = "تأكيد";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxSearch.Location = new System.Drawing.Point(319, 15);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(132, 24);
            this.textBoxSearch.TabIndex = 3;
            // 
            // labelAll
            // 
            this.labelAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAll.AutoSize = true;
            this.labelAll.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelAll.Location = new System.Drawing.Point(590, 17);
            this.labelAll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAll.Name = "labelAll";
            this.labelAll.Size = new System.Drawing.Size(32, 17);
            this.labelAll.TabIndex = 2;
            this.labelAll.Text = "الكل";
            // 
            // comboBoxAll
            // 
            this.comboBoxAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAll.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxAll.FormattingEnabled = true;
            this.comboBoxAll.Location = new System.Drawing.Point(625, 15);
            this.comboBoxAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxAll.Name = "comboBoxAll";
            this.comboBoxAll.Size = new System.Drawing.Size(107, 24);
            this.comboBoxAll.TabIndex = 1;
            // 
            // labelSeller
            // 
            this.labelSeller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSeller.AutoSize = true;
            this.labelSeller.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelSeller.Location = new System.Drawing.Point(735, 17);
            this.labelSeller.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSeller.Name = "labelSeller";
            this.labelSeller.Size = new System.Drawing.Size(36, 17);
            this.labelSeller.TabIndex = 0;
            this.labelSeller.Text = "البائع";
            // 
            // dataGridViewInvoices
            // 
            this.dataGridViewInvoices.AllowUserToAddRows = false;
            this.dataGridViewInvoices.AllowUserToDeleteRows = false;
            this.dataGridViewInvoices.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colInvoiceNumber,
            this.colCustomer,
            this.colTotal,
            this.colDueDate,
            this.colDaysRemaining});
            this.dataGridViewInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInvoices.Location = new System.Drawing.Point(0, 53);
            this.dataGridViewInvoices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewInvoices.Name = "dataGridViewInvoices";
            this.dataGridViewInvoices.ReadOnly = true;
            this.dataGridViewInvoices.RowHeadersWidth = 51;
            this.dataGridViewInvoices.RowTemplate.Height = 24;
            this.dataGridViewInvoices.Size = new System.Drawing.Size(856, 455);
            this.dataGridViewInvoices.TabIndex = 1;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "التاريخ";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 125;
            // 
            // colInvoiceNumber
            // 
            this.colInvoiceNumber.HeaderText = "رقم الفاتورة";
            this.colInvoiceNumber.MinimumWidth = 6;
            this.colInvoiceNumber.Name = "colInvoiceNumber";
            this.colInvoiceNumber.ReadOnly = true;
            this.colInvoiceNumber.Width = 125;
            // 
            // colCustomer
            // 
            this.colCustomer.HeaderText = "الزبون";
            this.colCustomer.MinimumWidth = 6;
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.ReadOnly = true;
            this.colCustomer.Width = 150;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "المجموع";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 125;
            // 
            // colDueDate
            // 
            this.colDueDate.HeaderText = "تاريخ الاستحقاق";
            this.colDueDate.MinimumWidth = 6;
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;
            this.colDueDate.Width = 125;
            // 
            // colDaysRemaining
            // 
            this.colDaysRemaining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDaysRemaining.HeaderText = "الأيام المتبقية";
            this.colDaysRemaining.MinimumWidth = 6;
            this.colDaysRemaining.Name = "colDaysRemaining";
            this.colDaysRemaining.ReadOnly = true;
            // 
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 508);
            this.Controls.Add(this.dataGridViewInvoices);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InvoicesForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لائحة الفواتير الواجب أداؤها";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelAll;
        private System.Windows.Forms.ComboBox comboBoxAll;
        private System.Windows.Forms.Label labelSeller;
        private System.Windows.Forms.DataGridView dataGridViewInvoices;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDaysRemaining;
    }
}