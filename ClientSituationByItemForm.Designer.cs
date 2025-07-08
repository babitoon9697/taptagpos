namespace TAPTAGPOS // <-- IMPORTANT: Change this to your project's actual namespace
{
    partial class ClientSituationByItemForm
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
            this.comboBoxFamily = new System.Windows.Forms.ComboBox();
            this.labelFamily = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonItemDetails = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonTimePeriod = new System.Windows.Forms.Button();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.textBoxTotalSum = new System.Windows.Forms.TextBox();
            this.textBoxTotalQuantity = new System.Windows.Forms.TextBox();
            this.dataGridViewSituation = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSituation)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.comboBoxFamily);
            this.panelTop.Controls.Add(this.labelFamily);
            this.panelTop.Controls.Add(this.comboBoxClient);
            this.panelTop.Controls.Add(this.labelClient);
            this.panelTop.Controls.Add(this.buttonClose);
            this.panelTop.Controls.Add(this.buttonItemDetails);
            this.panelTop.Controls.Add(this.buttonPrint);
            this.panelTop.Controls.Add(this.buttonView);
            this.panelTop.Controls.Add(this.buttonTimePeriod);
            this.panelTop.Controls.Add(this.dateTimePickerEndDate);
            this.panelTop.Controls.Add(this.labelEndDate);
            this.panelTop.Controls.Add(this.dateTimePickerStartDate);
            this.panelTop.Controls.Add(this.labelStartDate);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(662, 94);
            this.panelTop.TabIndex = 1;
            // 
            // comboBoxFamily
            // 
            this.comboBoxFamily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFamily.FormattingEnabled = true;
            this.comboBoxFamily.Items.AddRange(new object[] {
            "الكل"});
            this.comboBoxFamily.Location = new System.Drawing.Point(181, 61);
            this.comboBoxFamily.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFamily.Name = "comboBoxFamily";
            this.comboBoxFamily.Size = new System.Drawing.Size(150, 21);
            this.comboBoxFamily.TabIndex = 13;
            // 
            // labelFamily
            // 
            this.labelFamily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFamily.AutoSize = true;
            this.labelFamily.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelFamily.Location = new System.Drawing.Point(334, 63);
            this.labelFamily.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFamily.Name = "labelFamily";
            this.labelFamily.Size = new System.Drawing.Size(37, 14);
            this.labelFamily.TabIndex = 12;
            this.labelFamily.Text = "العائلة";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Items.AddRange(new object[] {
            "الكل"});
            this.comboBoxClient.Location = new System.Drawing.Point(408, 61);
            this.comboBoxClient.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(187, 21);
            this.comboBoxClient.TabIndex = 11;
            // 
            // labelClient
            // 
            this.labelClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelClient.Location = new System.Drawing.Point(598, 63);
            this.labelClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(34, 14);
            this.labelClient.TabIndex = 10;
            this.labelClient.Text = "الزبون";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(17, 9);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 39);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            // 
            // buttonItemDetails
            // 
            this.buttonItemDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonItemDetails.Font = new System.Drawing.Font("Tahoma", 8F);
            this.buttonItemDetails.Location = new System.Drawing.Point(52, 9);
            this.buttonItemDetails.Margin = new System.Windows.Forms.Padding(2);
            this.buttonItemDetails.Name = "buttonItemDetails";
            this.buttonItemDetails.Size = new System.Drawing.Size(60, 39);
            this.buttonItemDetails.TabIndex = 8;
            this.buttonItemDetails.Text = "تفاصيل السلعة";
            this.buttonItemDetails.UseVisualStyleBackColor = true;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrint.Font = new System.Drawing.Font("Tahoma", 8F);
            this.buttonPrint.Location = new System.Drawing.Point(116, 9);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(60, 39);
            this.buttonPrint.TabIndex = 7;
            this.buttonPrint.Text = "طباعة";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // buttonView
            // 
            this.buttonView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonView.Font = new System.Drawing.Font("Tahoma", 8F);
            this.buttonView.Location = new System.Drawing.Point(181, 9);
            this.buttonView.Margin = new System.Windows.Forms.Padding(2);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(60, 39);
            this.buttonView.TabIndex = 6;
            this.buttonView.Text = "مشاهدة";
            this.buttonView.UseVisualStyleBackColor = true;
            // 
            // buttonTimePeriod
            // 
            this.buttonTimePeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTimePeriod.Font = new System.Drawing.Font("Tahoma", 8F);
            this.buttonTimePeriod.Location = new System.Drawing.Point(371, 9);
            this.buttonTimePeriod.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTimePeriod.Name = "buttonTimePeriod";
            this.buttonTimePeriod.Size = new System.Drawing.Size(71, 39);
            this.buttonTimePeriod.TabIndex = 5;
            this.buttonTimePeriod.Text = "الفترة الزمنية";
            this.buttonTimePeriod.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(447, 33);
            this.dateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(111, 20);
            this.dateTimePickerEndDate.TabIndex = 3;
            // 
            // labelEndDate
            // 
            this.labelEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelEndDate.Location = new System.Drawing.Point(562, 35);
            this.labelEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(64, 14);
            this.labelEndDate.TabIndex = 2;
            this.labelEndDate.Text = "تاريخ النهاية";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(447, 11);
            this.dateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(111, 20);
            this.dateTimePickerStartDate.TabIndex = 1;
            // 
            // labelStartDate
            // 
            this.labelStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelStartDate.Location = new System.Drawing.Point(562, 12);
            this.labelStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(55, 14);
            this.labelStartDate.TabIndex = 0;
            this.labelStartDate.Text = "تاريخ البدء";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.textBoxTotalSum);
            this.panelBottom.Controls.Add(this.textBoxTotalQuantity);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 341);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(2);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(662, 27);
            this.panelBottom.TabIndex = 2;
            // 
            // textBoxTotalSum
            // 
            this.textBoxTotalSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalSum.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTotalSum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalSum.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.textBoxTotalSum.Location = new System.Drawing.Point(132, 6);
            this.textBoxTotalSum.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalSum.Name = "textBoxTotalSum";
            this.textBoxTotalSum.ReadOnly = true;
            this.textBoxTotalSum.Size = new System.Drawing.Size(94, 15);
            this.textBoxTotalSum.TabIndex = 1;
            this.textBoxTotalSum.Text = "17320,00";
            // 
            // textBoxTotalQuantity
            // 
            this.textBoxTotalQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTotalQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalQuantity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.textBoxTotalQuantity.Location = new System.Drawing.Point(296, 6);
            this.textBoxTotalQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalQuantity.Name = "textBoxTotalQuantity";
            this.textBoxTotalQuantity.ReadOnly = true;
            this.textBoxTotalQuantity.Size = new System.Drawing.Size(94, 15);
            this.textBoxTotalQuantity.TabIndex = 0;
            this.textBoxTotalQuantity.Text = "184,00";
            // 
            // dataGridViewSituation
            // 
            this.dataGridViewSituation.AllowUserToAddRows = false;
            this.dataGridViewSituation.AllowUserToDeleteRows = false;
            this.dataGridViewSituation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSituation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colItem,
            this.colQuantity,
            this.colTotal});
            this.dataGridViewSituation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSituation.Location = new System.Drawing.Point(0, 94);
            this.dataGridViewSituation.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSituation.Name = "dataGridViewSituation";
            this.dataGridViewSituation.ReadOnly = true;
            this.dataGridViewSituation.RowHeadersWidth = 51;
            this.dataGridViewSituation.RowTemplate.Height = 24;
            this.dataGridViewSituation.Size = new System.Drawing.Size(662, 247);
            this.dataGridViewSituation.TabIndex = 3;
            // 
            // colCode
            // 
            this.colCode.HeaderText = "الكود";
            this.colCode.MinimumWidth = 6;
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            this.colCode.Width = 125;
            // 
            // colItem
            // 
            this.colItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItem.HeaderText = "السلعة";
            this.colItem.MinimumWidth = 6;
            this.colItem.Name = "colItem";
            this.colItem.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "الكمية";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 125;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "المجموع";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 150;
            // 
            // ClientSituationByItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 368);
            this.Controls.Add(this.dataGridViewSituation);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientSituationByItemForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Situation par Client";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSituation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonItemDetails;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonTimePeriod;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TextBox textBoxTotalSum;
        private System.Windows.Forms.TextBox textBoxTotalQuantity;
        private System.Windows.Forms.DataGridView dataGridViewSituation;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.ComboBox comboBoxFamily;
        private System.Windows.Forms.Label labelFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    }
}