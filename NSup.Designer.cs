namespace TAPTAGPOS
{
    partial class NewSupplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewSuppliers = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1112, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 695);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(59, 695);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridViewSuppliers);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(59, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1053, 642);
            this.panel4.TabIndex = 7;
            // 
            // dataGridViewSuppliers
            // 
            this.dataGridViewSuppliers.AllowCustomTheming = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewSuppliers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSuppliers.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSuppliers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewSuppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewSuppliers.ColumnHeadersHeight = 40;
            this.dataGridViewSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierID,
            this.Name,
            this.Phone,
            this.Email,
            this.City});
            this.dataGridViewSuppliers.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dataGridViewSuppliers.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewSuppliers.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewSuppliers.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dataGridViewSuppliers.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewSuppliers.CurrentTheme.BackColor = System.Drawing.Color.Teal;
            this.dataGridViewSuppliers.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dataGridViewSuppliers.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.dataGridViewSuppliers.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewSuppliers.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewSuppliers.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dataGridViewSuppliers.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewSuppliers.CurrentTheme.Name = null;
            this.dataGridViewSuppliers.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dataGridViewSuppliers.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewSuppliers.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewSuppliers.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dataGridViewSuppliers.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSuppliers.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSuppliers.EnableHeadersVisualStyles = false;
            this.dataGridViewSuppliers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dataGridViewSuppliers.HeaderBackColor = System.Drawing.Color.Teal;
            this.dataGridViewSuppliers.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewSuppliers.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewSuppliers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            this.dataGridViewSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewSuppliers.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSuppliers.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewSuppliers.RowTemplate.Height = 40;
            this.dataGridViewSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSuppliers.Size = new System.Drawing.Size(1053, 642);
            this.dataGridViewSuppliers.TabIndex = 2;
            this.dataGridViewSuppliers.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal;
            this.dataGridViewSuppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSuppliers_CellClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(59, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1053, 53);
            this.panel5.TabIndex = 6;
            // 
            // SupplierID
            // 
            this.SupplierID.HeaderText = "كود المزود";
            this.SupplierID.Name = "SupplierID";
            // 
            // Name
            // 
            this.Name.HeaderText = "إسم مزود";
            this.Name.Name = "Name";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "الهاتف";
            this.Phone.Name = "Phone";
            // 
            // Email
            // 
            this.Email.HeaderText = "البريد الإلكتروني";
            this.Email.Name = "Email";
            // 
            // City
            // 
            this.City.HeaderText = "المدينة";
            this.City.Name = "City";
            // 
            // NewSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 695);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "NewSupplier";
            this.Load += new System.EventHandler(this.NewSupplier_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewSuppliers;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
    }
}