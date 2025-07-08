namespace TAPTAGPOS
{
    partial class FormEtatGlobalStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.labelRupture = new System.Windows.Forms.Label();
            this.panelRed = new System.Windows.Forms.Panel();
            this.labelNormal = new System.Windows.Forms.Label();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cmbWarehouse = new System.Windows.Forms.ComboBox();
            this.cmbFamily = new System.Windows.Forms.ComboBox();
            this.labelFamily = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartonStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFilters
            // 
            this.panelFilters.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelFilters.Controls.Add(this.btnView);
            this.panelFilters.Controls.Add(this.labelRupture);
            this.panelFilters.Controls.Add(this.panelRed);
            this.panelFilters.Controls.Add(this.labelNormal);
            this.panelFilters.Controls.Add(this.panelGreen);
            this.panelFilters.Controls.Add(this.btnPrint);
            this.panelFilters.Controls.Add(this.cmbWarehouse);
            this.panelFilters.Controls.Add(this.cmbFamily);
            this.panelFilters.Controls.Add(this.labelFamily);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Margin = new System.Windows.Forms.Padding(2);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(738, 65);
            this.panelFilters.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnView.Location = new System.Drawing.Point(11, 24);
            this.btnView.Margin = new System.Windows.Forms.Padding(2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(90, 28);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "Chercher";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // labelRupture
            // 
            this.labelRupture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRupture.AutoSize = true;
            this.labelRupture.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelRupture.Location = new System.Drawing.Point(621, 39);
            this.labelRupture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRupture.Name = "labelRupture";
            this.labelRupture.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelRupture.Size = new System.Drawing.Size(80, 14);
            this.labelRupture.TabIndex = 7;
            this.labelRupture.Text = "نفاد المخزون";
            // 
            // panelRed
            // 
            this.panelRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(707, 37);
            this.panelRed.Margin = new System.Windows.Forms.Padding(2);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(19, 21);
            this.panelRed.TabIndex = 6;
            // 
            // labelNormal
            // 
            this.labelNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNormal.AutoSize = true;
            this.labelNormal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelNormal.Location = new System.Drawing.Point(621, 12);
            this.labelNormal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNormal.Name = "labelNormal";
            this.labelNormal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelNormal.Size = new System.Drawing.Size(96, 14);
            this.labelNormal.TabIndex = 5;
            this.labelNormal.Text = "المخزون العادي";
            // 
            // panelGreen
            // 
            this.panelGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGreen.BackColor = System.Drawing.Color.LimeGreen;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(707, 10);
            this.panelGreen.Margin = new System.Windows.Forms.Padding(2);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(19, 21);
            this.panelGreen.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Location = new System.Drawing.Point(442, 20);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(90, 28);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // cmbWarehouse
            // 
            this.cmbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWarehouse.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cmbWarehouse.FormattingEnabled = true;
            this.cmbWarehouse.Location = new System.Drawing.Point(281, 24);
            this.cmbWarehouse.Margin = new System.Windows.Forms.Padding(2);
            this.cmbWarehouse.Name = "cmbWarehouse";
            this.cmbWarehouse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbWarehouse.Size = new System.Drawing.Size(136, 22);
            this.cmbWarehouse.TabIndex = 2;
            // 
            // cmbFamily
            // 
            this.cmbFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFamily.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cmbFamily.FormattingEnabled = true;
            this.cmbFamily.Location = new System.Drawing.Point(119, 24);
            this.cmbFamily.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFamily.Name = "cmbFamily";
            this.cmbFamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbFamily.Size = new System.Drawing.Size(136, 22);
            this.cmbFamily.TabIndex = 1;
            // 
            // labelFamily
            // 
            this.labelFamily.AutoSize = true;
            this.labelFamily.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelFamily.Location = new System.Drawing.Point(203, 0);
            this.labelFamily.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFamily.Name = "labelFamily";
            this.labelFamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelFamily.Size = new System.Drawing.Size(43, 14);
            this.labelFamily.TabIndex = 0;
            this.labelFamily.Text = "الفائلة";
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colItemName,
            this.colStock,
            this.colValue,
            this.colCartonStock});
            this.dgvStock.EnableHeadersVisualStyles = false;
            this.dgvStock.Location = new System.Drawing.Point(9, 70);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dgvStock.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(718, 340);
            this.dgvStock.TabIndex = 1;
            // 
            // colCode
            // 
            this.colCode.HeaderText = "كود";
            this.colCode.MinimumWidth = 6;
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            // 
            // colItemName
            // 
            this.colItemName.FillWeight = 150F;
            this.colItemName.HeaderText = "إسم السلعة";
            this.colItemName.MinimumWidth = 6;
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "المخزون";
            this.colStock.MinimumWidth = 6;
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // colValue
            // 
            this.colValue.HeaderText = "القيمة";
            this.colValue.MinimumWidth = 6;
            this.colValue.Name = "colValue";
            this.colValue.ReadOnly = true;
            // 
            // colCartonStock
            // 
            this.colCartonStock.HeaderText = "مخزون الكرطون";
            this.colCartonStock.MinimumWidth = 6;
            this.colCartonStock.Name = "colCartonStock";
            this.colCartonStock.ReadOnly = true;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.txtTotal);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 421);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(738, 35);
            this.panelFooter.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(9, 8);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(114, 20);
            this.txtTotal.TabIndex = 0;
            // 
            // FormEtatGlobalStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 456);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.panelFilters);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(754, 495);
            this.Name = "FormEtatGlobalStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المخزون";
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelFamily;
        private System.Windows.Forms.ComboBox cmbFamily;
        private System.Windows.Forms.ComboBox cmbWarehouse;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Label labelNormal;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label labelRupture;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartonStock;
        private System.Windows.Forms.Button btnView;
    }
}