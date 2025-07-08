namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class FormImpressionBarcode
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnStickerItem = new System.Windows.Forms.Button();
            this.btnStickerPrices = new System.Windows.Forms.Button();
            this.btnPromotion = new System.Windows.Forms.Button();
            this.btnStickerPrice = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelFamily = new System.Windows.Forms.Label();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.labelItem = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelExpDate = new System.Windows.Forms.Label();
            this.labelCopies = new System.Windows.Forms.Label();
            this.chkTogglePos = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.picFamily = new System.Windows.Forms.PictureBox();
            this.labelFamilyInput = new System.Windows.Forms.Label();
            this.cmbFamily = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.chkTogglePrice = new System.Windows.Forms.CheckBox();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.picCopies = new System.Windows.Forms.PictureBox();
            this.numCopies = new System.Windows.Forms.NumericUpDown();
            this.picBarcode = new System.Windows.Forms.PictureBox();
            this.lblBarcodeNumber = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(705, 49);
            this.panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTitle.Size = new System.Drawing.Size(705, 49);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "طباعة الباركود";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStickerItem
            // 
            this.btnStickerItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStickerItem.Location = new System.Drawing.Point(27, 69);
            this.btnStickerItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnStickerItem.Name = "btnStickerItem";
            this.btnStickerItem.Size = new System.Drawing.Size(112, 41);
            this.btnStickerItem.TabIndex = 1;
            this.btnStickerItem.Text = "ملصق السلعة";
            this.btnStickerItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStickerItem.UseVisualStyleBackColor = true;
            // 
            // btnStickerPrices
            // 
            this.btnStickerPrices.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStickerPrices.Location = new System.Drawing.Point(27, 118);
            this.btnStickerPrices.Margin = new System.Windows.Forms.Padding(2);
            this.btnStickerPrices.Name = "btnStickerPrices";
            this.btnStickerPrices.Size = new System.Drawing.Size(112, 41);
            this.btnStickerPrices.TabIndex = 2;
            this.btnStickerPrices.Text = "ملصق الأسعار";
            this.btnStickerPrices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStickerPrices.UseVisualStyleBackColor = true;
            // 
            // btnPromotion
            // 
            this.btnPromotion.Enabled = false;
            this.btnPromotion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromotion.Location = new System.Drawing.Point(27, 166);
            this.btnPromotion.Margin = new System.Windows.Forms.Padding(2);
            this.btnPromotion.Name = "btnPromotion";
            this.btnPromotion.Size = new System.Drawing.Size(112, 41);
            this.btnPromotion.TabIndex = 3;
            this.btnPromotion.Text = "Promotion";
            this.btnPromotion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPromotion.UseVisualStyleBackColor = true;
            // 
            // btnStickerPrice
            // 
            this.btnStickerPrice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStickerPrice.Location = new System.Drawing.Point(27, 215);
            this.btnStickerPrice.Margin = new System.Windows.Forms.Padding(2);
            this.btnStickerPrice.Name = "btnStickerPrice";
            this.btnStickerPrice.Size = new System.Drawing.Size(112, 41);
            this.btnStickerPrice.TabIndex = 4;
            this.btnStickerPrice.Text = "ملصق السعر";
            this.btnStickerPrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStickerPrice.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(591, 80);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelName.Size = new System.Drawing.Size(56, 17);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "الإسم :";
            // 
            // labelFamily
            // 
            this.labelFamily.AutoSize = true;
            this.labelFamily.BackColor = System.Drawing.Color.Transparent;
            this.labelFamily.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFamily.Location = new System.Drawing.Point(591, 120);
            this.labelFamily.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFamily.Name = "labelFamily";
            this.labelFamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelFamily.Size = new System.Drawing.Size(58, 17);
            this.labelFamily.TabIndex = 6;
            this.labelFamily.Text = "العائلة :";
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.BackColor = System.Drawing.Color.Transparent;
            this.labelBarcode.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarcode.Location = new System.Drawing.Point(591, 161);
            this.labelBarcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelBarcode.Size = new System.Drawing.Size(66, 17);
            this.labelBarcode.TabIndex = 7;
            this.labelBarcode.Text = "الباركود :";
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.BackColor = System.Drawing.Color.Transparent;
            this.labelItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItem.Location = new System.Drawing.Point(591, 201);
            this.labelItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelItem.Name = "labelItem";
            this.labelItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelItem.Size = new System.Drawing.Size(64, 17);
            this.labelItem.TabIndex = 8;
            this.labelItem.Text = "السلعة :";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(591, 242);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelPrice.Size = new System.Drawing.Size(57, 17);
            this.labelPrice.TabIndex = 9;
            this.labelPrice.Text = "السعر :";
            // 
            // labelExpDate
            // 
            this.labelExpDate.AutoSize = true;
            this.labelExpDate.BackColor = System.Drawing.Color.Transparent;
            this.labelExpDate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpDate.Location = new System.Drawing.Point(591, 283);
            this.labelExpDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExpDate.Name = "labelExpDate";
            this.labelExpDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelExpDate.Size = new System.Drawing.Size(111, 17);
            this.labelExpDate.TabIndex = 10;
            this.labelExpDate.Text = "تاريخ الصلاحية :";
            // 
            // labelCopies
            // 
            this.labelCopies.AutoSize = true;
            this.labelCopies.BackColor = System.Drawing.Color.Transparent;
            this.labelCopies.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopies.Location = new System.Drawing.Point(591, 323);
            this.labelCopies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCopies.Name = "labelCopies";
            this.labelCopies.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelCopies.Size = new System.Drawing.Size(88, 17);
            this.labelCopies.TabIndex = 11;
            this.labelCopies.Text = "عدد النسخ :";
            // 
            // chkTogglePos
            // 
            this.chkTogglePos.AutoSize = true;
            this.chkTogglePos.BackColor = System.Drawing.Color.Transparent;
            this.chkTogglePos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTogglePos.Location = new System.Drawing.Point(217, 79);
            this.chkTogglePos.Margin = new System.Windows.Forms.Padding(2);
            this.chkTogglePos.Name = "chkTogglePos";
            this.chkTogglePos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkTogglePos.Size = new System.Drawing.Size(43, 18);
            this.chkTogglePos.TabIndex = 12;
            this.chkTogglePos.Text = "نعم";
            this.chkTogglePos.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(284, 77);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 24);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "POS";
            // 
            // picFamily
            // 
            this.picFamily.BackColor = System.Drawing.Color.Transparent;
            this.picFamily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFamily.Location = new System.Drawing.Point(237, 118);
            this.picFamily.Margin = new System.Windows.Forms.Padding(2);
            this.picFamily.Name = "picFamily";
            this.picFamily.Size = new System.Drawing.Size(23, 25);
            this.picFamily.TabIndex = 14;
            this.picFamily.TabStop = false;
            // 
            // labelFamilyInput
            // 
            this.labelFamilyInput.AutoSize = true;
            this.labelFamilyInput.BackColor = System.Drawing.Color.Transparent;
            this.labelFamilyInput.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFamilyInput.Location = new System.Drawing.Point(184, 122);
            this.labelFamilyInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFamilyInput.Name = "labelFamilyInput";
            this.labelFamilyInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelFamilyInput.Size = new System.Drawing.Size(49, 17);
            this.labelFamilyInput.TabIndex = 15;
            this.labelFamilyInput.Text = "العائلة";
            // 
            // cmbFamily
            // 
            this.cmbFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFamily.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFamily.FormattingEnabled = true;
            this.cmbFamily.Location = new System.Drawing.Point(284, 118);
            this.cmbFamily.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFamily.Name = "cmbFamily";
            this.cmbFamily.Size = new System.Drawing.Size(301, 25);
            this.cmbFamily.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(284, 158);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(301, 24);
            this.textBox2.TabIndex = 17;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(284, 199);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(301, 25);
            this.comboBox2.TabIndex = 18;
            // 
            // chkTogglePrice
            // 
            this.chkTogglePrice.AutoSize = true;
            this.chkTogglePrice.BackColor = System.Drawing.Color.Transparent;
            this.chkTogglePrice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTogglePrice.Location = new System.Drawing.Point(217, 243);
            this.chkTogglePrice.Margin = new System.Windows.Forms.Padding(2);
            this.chkTogglePrice.Name = "chkTogglePrice";
            this.chkTogglePrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkTogglePrice.Size = new System.Drawing.Size(43, 18);
            this.chkTogglePrice.TabIndex = 19;
            this.chkTogglePrice.Text = "نعم";
            this.chkTogglePrice.UseVisualStyleBackColor = false;
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrice.Location = new System.Drawing.Point(284, 240);
            this.numPrice.Margin = new System.Windows.Forms.Padding(2);
            this.numPrice.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(112, 24);
            this.numPrice.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(284, 280);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(301, 24);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // picCopies
            // 
            this.picCopies.BackColor = System.Drawing.Color.Transparent;
            this.picCopies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCopies.Location = new System.Drawing.Point(237, 320);
            this.picCopies.Margin = new System.Windows.Forms.Padding(2);
            this.picCopies.Name = "picCopies";
            this.picCopies.Size = new System.Drawing.Size(23, 25);
            this.picCopies.TabIndex = 22;
            this.picCopies.TabStop = false;
            // 
            // numCopies
            // 
            this.numCopies.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCopies.Location = new System.Drawing.Point(284, 321);
            this.numCopies.Margin = new System.Windows.Forms.Padding(2);
            this.numCopies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCopies.Name = "numCopies";
            this.numCopies.Size = new System.Drawing.Size(112, 24);
            this.numCopies.TabIndex = 23;
            this.numCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // picBarcode
            // 
            this.picBarcode.BackColor = System.Drawing.Color.White;
            this.picBarcode.Location = new System.Drawing.Point(27, 292);
            this.picBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.picBarcode.Name = "picBarcode";
            this.picBarcode.Size = new System.Drawing.Size(147, 114);
            this.picBarcode.TabIndex = 24;
            this.picBarcode.TabStop = false;
            // 
            // lblBarcodeNumber
            // 
            this.lblBarcodeNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblBarcodeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarcodeNumber.Location = new System.Drawing.Point(27, 408);
            this.lblBarcodeNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarcodeNumber.Name = "lblBarcodeNumber";
            this.lblBarcodeNumber.Size = new System.Drawing.Size(147, 22);
            this.lblBarcodeNumber.TabIndex = 25;
            this.lblBarcodeNumber.Text = "0123456789";
            this.lblBarcodeNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormImpressionBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(705, 446);
            this.Controls.Add(this.lblBarcodeNumber);
            this.Controls.Add(this.picBarcode);
            this.Controls.Add(this.numCopies);
            this.Controls.Add(this.picCopies);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.chkTogglePrice);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cmbFamily);
            this.Controls.Add(this.labelFamilyInput);
            this.Controls.Add(this.picFamily);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chkTogglePos);
            this.Controls.Add(this.labelCopies);
            this.Controls.Add(this.labelExpDate);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.labelBarcode);
            this.Controls.Add(this.labelFamily);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnStickerPrice);
            this.Controls.Add(this.btnPromotion);
            this.Controls.Add(this.btnStickerPrices);
            this.Controls.Add(this.btnStickerItem);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormImpressionBarcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طباعة الباركود";
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnStickerItem;
        private System.Windows.Forms.Button btnStickerPrices;
        private System.Windows.Forms.Button btnPromotion;
        private System.Windows.Forms.Button btnStickerPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelFamily;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelExpDate;
        private System.Windows.Forms.Label labelCopies;
        private System.Windows.Forms.CheckBox chkTogglePos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox picFamily;
        private System.Windows.Forms.Label labelFamilyInput;
        private System.Windows.Forms.ComboBox cmbFamily;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox chkTogglePrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox picCopies;
        private System.Windows.Forms.NumericUpDown numCopies;
        private System.Windows.Forms.PictureBox picBarcode;
        private System.Windows.Forms.Label lblBarcodeNumber;
    }
}