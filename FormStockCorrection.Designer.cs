namespace TAPTAGPOS
{
    partial class FormStockCorrection
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnItemList = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cmbWarehouse2 = new System.Windows.Forms.ComboBox();
            this.cmbWarehouse1 = new System.Windows.Forms.ComboBox();
            this.labelWarehouse = new System.Windows.Forms.Label();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dgvCorrections = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrections)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.btnItemList);
            this.panelTop.Controls.Add(this.btnConfirm);
            this.panelTop.Controls.Add(this.cmbWarehouse2);
            this.panelTop.Controls.Add(this.cmbWarehouse1);
            this.panelTop.Controls.Add(this.labelWarehouse);
            this.panelTop.Controls.Add(this.btnPeriod);
            this.panelTop.Controls.Add(this.dtpEndDate);
            this.panelTop.Controls.Add(this.labelEndDate);
            this.panelTop.Controls.Add(this.dtpStartDate);
            this.panelTop.Controls.Add(this.labelStartDate);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(738, 81);
            this.panelTop.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(696, 24);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 32);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnItemList
            // 
            this.btnItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnItemList.Location = new System.Drawing.Point(601, 24);
            this.btnItemList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnItemList.Name = "btnItemList";
            this.btnItemList.Size = new System.Drawing.Size(90, 32);
            this.btnItemList.TabIndex = 10;
            this.btnItemList.Text = "لائحة السلعة";
            this.btnItemList.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.Location = new System.Drawing.Point(507, 24);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(90, 32);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "تأكيد";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // cmbWarehouse2
            // 
            this.cmbWarehouse2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWarehouse2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cmbWarehouse2.FormattingEnabled = true;
            this.cmbWarehouse2.Location = new System.Drawing.Point(315, 41);
            this.cmbWarehouse2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbWarehouse2.Name = "cmbWarehouse2";
            this.cmbWarehouse2.Size = new System.Drawing.Size(114, 22);
            this.cmbWarehouse2.TabIndex = 8;
            // 
            // cmbWarehouse1
            // 
            this.cmbWarehouse1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWarehouse1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cmbWarehouse1.FormattingEnabled = true;
            this.cmbWarehouse1.Location = new System.Drawing.Point(315, 12);
            this.cmbWarehouse1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbWarehouse1.Name = "cmbWarehouse1";
            this.cmbWarehouse1.Size = new System.Drawing.Size(114, 22);
            this.cmbWarehouse1.TabIndex = 7;
            // 
            // labelWarehouse
            // 
            this.labelWarehouse.AutoSize = true;
            this.labelWarehouse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelWarehouse.Location = new System.Drawing.Point(255, 15);
            this.labelWarehouse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWarehouse.Name = "labelWarehouse";
            this.labelWarehouse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelWarehouse.Size = new System.Drawing.Size(64, 14);
            this.labelWarehouse.TabIndex = 6;
            this.labelWarehouse.Text = "المستودع";
            // 
            // btnPeriod
            // 
            this.btnPeriod.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnPeriod.Location = new System.Drawing.Point(150, 24);
            this.btnPeriod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(90, 32);
            this.btnPeriod.TabIndex = 5;
            this.btnPeriod.Text = "الفترة الزمنية";
            this.btnPeriod.UseVisualStyleBackColor = true;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(9, 41);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(128, 22);
            this.dtpEndDate.TabIndex = 3;
            // 
            // labelEndDate
            // 
            this.labelEndDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelEndDate.Location = new System.Drawing.Point(-38, 43);
            this.labelEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelEndDate.Size = new System.Drawing.Size(90, 19);
            this.labelEndDate.TabIndex = 2;
            this.labelEndDate.Text = "تاريخ النهاية :";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(9, 12);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(128, 22);
            this.dtpStartDate.TabIndex = 1;
            // 
            // labelStartDate
            // 
            this.labelStartDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelStartDate.Location = new System.Drawing.Point(-38, 15);
            this.labelStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelStartDate.Size = new System.Drawing.Size(90, 19);
            this.labelStartDate.TabIndex = 0;
            this.labelStartDate.Text = "تاريخ البدء :";
            // 
            // dgvCorrections
            // 
            this.dgvCorrections.AllowUserToAddRows = false;
            this.dgvCorrections.AllowUserToDeleteRows = false;
            this.dgvCorrections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCorrections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCorrections.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCorrections.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCorrections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorrections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colUser,
            this.colWarehouse});
            this.dgvCorrections.Location = new System.Drawing.Point(9, 86);
            this.dgvCorrections.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCorrections.Name = "dgvCorrections";
            this.dgvCorrections.ReadOnly = true;
            this.dgvCorrections.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCorrections.RowHeadersVisible = false;
            this.dgvCorrections.RowHeadersWidth = 51;
            this.dgvCorrections.RowTemplate.Height = 24;
            this.dgvCorrections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCorrections.Size = new System.Drawing.Size(615, 353);
            this.dgvCorrections.TabIndex = 1;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "التاريخ";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colUser
            // 
            this.colUser.HeaderText = "المستخدم";
            this.colUser.MinimumWidth = 6;
            this.colUser.Name = "colUser";
            this.colUser.ReadOnly = true;
            // 
            // colWarehouse
            // 
            this.colWarehouse.HeaderText = "المستودع";
            this.colWarehouse.MinimumWidth = 6;
            this.colWarehouse.Name = "colWarehouse";
            this.colWarehouse.ReadOnly = true;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelRight.Controls.Add(this.btnView);
            this.panelRight.Controls.Add(this.btnAdd);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(630, 81);
            this.panelRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(108, 375);
            this.panelRight.TabIndex = 2;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnView.Location = new System.Drawing.Point(9, 49);
            this.btnView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(90, 41);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "مشاهدة";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(9, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 41);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormStockCorrection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 456);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.dgvCorrections);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(754, 495);
            this.Name = "FormStockCorrection";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تصحيح المخزون";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrections)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.DataGridView dgvCorrections;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Button btnPeriod;
        private System.Windows.Forms.Label labelWarehouse;
        private System.Windows.Forms.ComboBox cmbWarehouse1;
        private System.Windows.Forms.ComboBox cmbWarehouse2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnItemList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWarehouse;
    }
}