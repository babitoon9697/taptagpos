namespace TAPTAGPOS // <-- IMPORTANT: Change this to your project's actual namespace
{
    partial class SupplierTableForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopButtons = new System.Windows.Forms.Panel();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewSuppliers = new System.Windows.Forms.DataGridView();
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSupplierCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTopButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopButtons
            // 
            this.panelTopButtons.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelTopButtons.Controls.Add(this.tableLayoutPanel1);
            this.panelTopButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopButtons.Location = new System.Drawing.Point(0, 0);
            this.panelTopButtons.Margin = new System.Windows.Forms.Padding(2);
            this.panelTopButtons.Name = "panelTopButtons";
            this.panelTopButtons.Size = new System.Drawing.Size(866, 76);
            this.panelTopButtons.TabIndex = 0;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrint.Font = new System.Drawing.Font("Arial", 11.75F, System.Drawing.FontStyle.Bold);
            this.buttonPrint.Location = new System.Drawing.Point(2, 2);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(137, 47);
            this.buttonPrint.TabIndex = 3;
            this.buttonPrint.Text = "طباعة";
            this.buttonPrint.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Arial", 11.75F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.Location = new System.Drawing.Point(143, 2);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(136, 47);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "حذف";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.BackColor = System.Drawing.Color.Yellow;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Arial", 11.75F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.Location = new System.Drawing.Point(283, 2);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(134, 47);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "تعديل";
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 11.75F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.Location = new System.Drawing.Point(421, 2);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(135, 47);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "إضافة";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // dataGridViewSuppliers
            // 
            this.dataGridViewSuppliers.BackgroundColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.colSupplierCode,
            this.colSupplierName,
            this.colAddress,
            this.colPhone,
            this.colContactPerson,
            this.colMobile});
            this.dataGridViewSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSuppliers.Location = new System.Drawing.Point(0, 76);
            this.dataGridViewSuppliers.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewSuppliers.RowHeadersWidth = 51;
            this.dataGridViewSuppliers.RowTemplate.Height = 24;
            this.dataGridViewSuppliers.Size = new System.Drawing.Size(866, 456);
            this.dataGridViewSuppliers.TabIndex = 1;
            // 
            // colSelect
            // 
            this.colSelect.HeaderText = "";
            this.colSelect.MinimumWidth = 6;
            this.colSelect.Name = "colSelect";
            this.colSelect.Width = 40;
            // 
            // colSupplierCode
            // 
            this.colSupplierCode.HeaderText = "كود المورد";
            this.colSupplierCode.MinimumWidth = 6;
            this.colSupplierCode.Name = "colSupplierCode";
            this.colSupplierCode.Width = 125;
            // 
            // colSupplierName
            // 
            this.colSupplierName.HeaderText = "اسم المورد";
            this.colSupplierName.MinimumWidth = 6;
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.Width = 200;
            // 
            // colAddress
            // 
            this.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAddress.HeaderText = "العنوان";
            this.colAddress.MinimumWidth = 6;
            this.colAddress.Name = "colAddress";
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "الهاتف";
            this.colPhone.MinimumWidth = 6;
            this.colPhone.Name = "colPhone";
            this.colPhone.Width = 125;
            // 
            // colContactPerson
            // 
            this.colContactPerson.HeaderText = "المسؤول";
            this.colContactPerson.MinimumWidth = 6;
            this.colContactPerson.Name = "colContactPerson";
            this.colContactPerson.Width = 125;
            // 
            // colMobile
            // 
            this.colMobile.HeaderText = "المحمول";
            this.colMobile.MinimumWidth = 6;
            this.colMobile.Name = "colMobile";
            this.colMobile.Width = 125;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.77477F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.07508F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.buttonAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPrint, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonEdit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonDelete, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(296, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(558, 51);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // SupplierTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 532);
            this.Controls.Add(this.dataGridViewSuppliers);
            this.Controls.Add(this.panelTopButtons);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SupplierTableForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Fournisseur";
            this.panelTopButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopButtons;
        private System.Windows.Forms.DataGridView dataGridViewSuppliers;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}