namespace TAPTAGPOS // <-- IMPORTANT: Change this to your project's actual namespace
{
    partial class SupplierDebtForm
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
            this.buttonSelectSupplier = new System.Windows.Forms.Button();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonTimePeriod = new System.Windows.Forms.Button();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.labelTo = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelFrom = new System.Windows.Forms.Label();
            this.panelRightButtons = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewDebts = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxCalendar = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            this.panelRightButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDebts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.buttonSelectSupplier);
            this.panelTop.Controls.Add(this.comboBoxSupplier);
            this.panelTop.Controls.Add(this.buttonConfirm);
            this.panelTop.Controls.Add(this.buttonTimePeriod);
            this.panelTop.Controls.Add(this.dateTimePickerTo);
            this.panelTop.Controls.Add(this.labelTo);
            this.panelTop.Controls.Add(this.dateTimePickerFrom);
            this.panelTop.Controls.Add(this.labelFrom);
            this.panelTop.Controls.Add(this.pictureBoxCalendar);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(885, 57);
            this.panelTop.TabIndex = 0;
            // 
            // buttonSelectSupplier
            // 
            this.buttonSelectSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectSupplier.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSelectSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectSupplier.ForeColor = System.Drawing.Color.White;
            this.buttonSelectSupplier.Location = new System.Drawing.Point(23, 14);
            this.buttonSelectSupplier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSelectSupplier.Name = "buttonSelectSupplier";
            this.buttonSelectSupplier.Size = new System.Drawing.Size(30, 24);
            this.buttonSelectSupplier.TabIndex = 8;
            this.buttonSelectSupplier.UseVisualStyleBackColor = false;
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSupplier.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(58, 15);
            this.comboBoxSupplier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(164, 24);
            this.comboBoxSupplier.TabIndex = 7;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.buttonConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfirm.Location = new System.Drawing.Point(287, 12);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.buttonConfirm.Size = new System.Drawing.Size(71, 27);
            this.buttonConfirm.TabIndex = 6;
            this.buttonConfirm.Text = "تأكيد";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // buttonTimePeriod
            // 
            this.buttonTimePeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTimePeriod.Font = new System.Drawing.Font("Tahoma", 8F);
            this.buttonTimePeriod.Location = new System.Drawing.Point(471, 12);
            this.buttonTimePeriod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTimePeriod.Name = "buttonTimePeriod";
            this.buttonTimePeriod.Size = new System.Drawing.Size(71, 27);
            this.buttonTimePeriod.TabIndex = 5;
            this.buttonTimePeriod.Text = "لمدة الزمنية";
            this.buttonTimePeriod.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(555, 18);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerTo.TabIndex = 4;
            // 
            // labelTo
            // 
            this.labelTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelTo.Location = new System.Drawing.Point(654, 20);
            this.labelTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(25, 14);
            this.labelTo.TabIndex = 3;
            this.labelTo.Text = "إلى";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(679, 18);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerFrom.TabIndex = 2;
            // 
            // labelFrom
            // 
            this.labelFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelFrom.Location = new System.Drawing.Point(777, 20);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(22, 14);
            this.labelFrom.TabIndex = 1;
            this.labelFrom.Text = "من";
            // 
            // panelRightButtons
            // 
            this.panelRightButtons.Controls.Add(this.buttonExit);
            this.panelRightButtons.Controls.Add(this.buttonPrint);
            this.panelRightButtons.Controls.Add(this.buttonDelete);
            this.panelRightButtons.Controls.Add(this.buttonEdit);
            this.panelRightButtons.Controls.Add(this.buttonAdd);
            this.panelRightButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightButtons.Location = new System.Drawing.Point(795, 57);
            this.panelRightButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRightButtons.Name = "panelRightButtons";
            this.panelRightButtons.Size = new System.Drawing.Size(90, 464);
            this.panelRightButtons.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.Location = new System.Drawing.Point(14, 232);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.buttonExit.Size = new System.Drawing.Size(64, 49);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "خروج";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Tahoma", 9F);
            this.buttonPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPrint.Location = new System.Drawing.Point(14, 178);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.buttonPrint.Size = new System.Drawing.Size(64, 49);
            this.buttonPrint.TabIndex = 3;
            this.buttonPrint.Text = "طباعة";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Tahoma", 9F);
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDelete.Location = new System.Drawing.Point(14, 124);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.buttonDelete.Size = new System.Drawing.Size(64, 49);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "حذف";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEdit.Location = new System.Drawing.Point(14, 69);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.buttonEdit.Size = new System.Drawing.Size(64, 49);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "تعديل";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 9F);
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdd.Location = new System.Drawing.Point(14, 15);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.buttonAdd.Size = new System.Drawing.Size(64, 49);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "إضافة";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDebts
            // 
            this.dataGridViewDebts.AllowUserToAddRows = false;
            this.dataGridViewDebts.AllowUserToDeleteRows = false;
            this.dataGridViewDebts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDebts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colSupplier,
            this.colPaymentMethod,
            this.colDocumentNumber,
            this.colAmount});
            this.dataGridViewDebts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDebts.Location = new System.Drawing.Point(0, 57);
            this.dataGridViewDebts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewDebts.Name = "dataGridViewDebts";
            this.dataGridViewDebts.ReadOnly = true;
            this.dataGridViewDebts.RowHeadersWidth = 51;
            this.dataGridViewDebts.RowTemplate.Height = 24;
            this.dataGridViewDebts.Size = new System.Drawing.Size(795, 464);
            this.dataGridViewDebts.TabIndex = 2;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "التاريخ";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 125;
            // 
            // colSupplier
            // 
            this.colSupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSupplier.HeaderText = "المورد";
            this.colSupplier.MinimumWidth = 6;
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.ReadOnly = true;
            // 
            // colPaymentMethod
            // 
            this.colPaymentMethod.HeaderText = "طريقة الدفع";
            this.colPaymentMethod.MinimumWidth = 6;
            this.colPaymentMethod.Name = "colPaymentMethod";
            this.colPaymentMethod.ReadOnly = true;
            this.colPaymentMethod.Width = 150;
            // 
            // colDocumentNumber
            // 
            this.colDocumentNumber.HeaderText = "رقم الوثيقة";
            this.colDocumentNumber.MinimumWidth = 6;
            this.colDocumentNumber.Name = "colDocumentNumber";
            this.colDocumentNumber.ReadOnly = true;
            this.colDocumentNumber.Width = 125;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "المبلغ";
            this.colAmount.MinimumWidth = 6;
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 125;
            // 
            // pictureBoxCalendar
            // 
            this.pictureBoxCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCalendar.Location = new System.Drawing.Point(811, 9);
            this.pictureBoxCalendar.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCalendar.Name = "pictureBoxCalendar";
            this.pictureBoxCalendar.Size = new System.Drawing.Size(36, 39);
            this.pictureBoxCalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCalendar.TabIndex = 0;
            this.pictureBoxCalendar.TabStop = false;
            // 
            // SupplierDebtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 521);
            this.Controls.Add(this.dataGridViewDebts);
            this.Controls.Add(this.panelRightButtons);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SupplierDebtForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تسديد ديون الموردين";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelRightButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDebts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalendar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelRightButtons;
        private System.Windows.Forms.DataGridView dataGridViewDebts;
        private System.Windows.Forms.PictureBox pictureBoxCalendar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Button buttonTimePeriod;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonSelectSupplier;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
    }
}