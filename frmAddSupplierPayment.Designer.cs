namespace TAPTAGPOS
{
    partial class frmAddSupplierPayment
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.dgvUnpaidInvoices = new System.Windows.Forms.DataGridView();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.grpPaymentMethod = new System.Windows.Forms.GroupBox();
            this.rbBankTransfer = new System.Windows.Forms.RadioButton();
            this.rbCheque = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtDocumentNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnpaidInvoices)).BeginInit();
            this.grpPaymentMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSupplier.Location = new System.Drawing.Point(35, 23);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(41, 17);
            this.lblSupplier.TabIndex = 0;
            this.lblSupplier.Text = "المورد";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(105, 20);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(320, 25);
            this.cmbSupplier.TabIndex = 1;
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            // 
            // dgvUnpaidInvoices
            // 
            this.dgvUnpaidInvoices.AllowUserToAddRows = false;
            this.dgvUnpaidInvoices.AllowUserToDeleteRows = false;
            this.dgvUnpaidInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnpaidInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnpaidInvoices.Location = new System.Drawing.Point(25, 60);
            this.dgvUnpaidInvoices.MultiSelect = false;
            this.dgvUnpaidInvoices.Name = "dgvUnpaidInvoices";
            this.dgvUnpaidInvoices.ReadOnly = true;
            this.dgvUnpaidInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnpaidInvoices.Size = new System.Drawing.Size(690, 221);
            this.dgvUnpaidInvoices.TabIndex = 2;
            this.dgvUnpaidInvoices.SelectionChanged += new System.EventHandler(this.dgvUnpaidInvoices_SelectionChanged);
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPaymentAmount.Location = new System.Drawing.Point(373, 303);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(110, 21);
            this.lblPaymentAmount.TabIndex = 3;
            this.lblPaymentAmount.Text = "المبلغ المدفوع :";
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtPaymentAmount.Location = new System.Drawing.Point(497, 303);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(150, 29);
            this.txtPaymentAmount.TabIndex = 4;
            // 
            // grpPaymentMethod
            // 
            this.grpPaymentMethod.Controls.Add(this.rbBankTransfer);
            this.grpPaymentMethod.Controls.Add(this.rbCheque);
            this.grpPaymentMethod.Controls.Add(this.rbCash);
            this.grpPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpPaymentMethod.Location = new System.Drawing.Point(25, 300);
            this.grpPaymentMethod.Name = "grpPaymentMethod";
            this.grpPaymentMethod.Size = new System.Drawing.Size(300, 70);
            this.grpPaymentMethod.TabIndex = 5;
            this.grpPaymentMethod.TabStop = false;
            this.grpPaymentMethod.Text = "طريقة الدفع";
            // 
            // rbBankTransfer
            // 
            this.rbBankTransfer.AutoSize = true;
            this.rbBankTransfer.Location = new System.Drawing.Point(20, 30);
            this.rbBankTransfer.Name = "rbBankTransfer";
            this.rbBankTransfer.Size = new System.Drawing.Size(85, 21);
            this.rbBankTransfer.TabIndex = 2;
            this.rbBankTransfer.Text = "حوالة بنكية";
            this.rbBankTransfer.UseVisualStyleBackColor = true;
            // 
            // rbCheque
            // 
            this.rbCheque.AutoSize = true;
            this.rbCheque.Location = new System.Drawing.Point(130, 30);
            this.rbCheque.Name = "rbCheque";
            this.rbCheque.Size = new System.Drawing.Size(52, 21);
            this.rbCheque.TabIndex = 1;
            this.rbCheque.Text = "شيك";
            this.rbCheque.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Checked = true;
            this.rbCash.Location = new System.Drawing.Point(220, 30);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(47, 21);
            this.rbCash.TabIndex = 0;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "نقداً";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.Location = new System.Drawing.Point(192, 393);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(150, 50);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "تأكيد الدفع";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.Location = new System.Drawing.Point(27, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtNotes.Location = new System.Drawing.Point(497, 393);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(229, 67);
            this.txtNotes.TabIndex = 8;
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtDocumentNumber.Location = new System.Drawing.Point(497, 347);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(199, 29);
            this.txtDocumentNumber.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(373, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "رقم الشيك :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(373, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "ملاحظات :";
            // 
            // frmAddSupplierPayment
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(744, 472);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDocumentNumber);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grpPaymentMethod);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.lblPaymentAmount);
            this.Controls.Add(this.dgvUnpaidInvoices);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.lblSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAddSupplierPayment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تسديد دين المورد";
            this.Load += new System.EventHandler(this.frmAddSupplierPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnpaidInvoices)).EndInit();
            this.grpPaymentMethod.ResumeLayout(false);
            this.grpPaymentMethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.DataGridView dgvUnpaidInvoices;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.GroupBox grpPaymentMethod;
        private System.Windows.Forms.RadioButton rbBankTransfer;
        private System.Windows.Forms.RadioButton rbCheque;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtDocumentNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}