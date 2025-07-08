namespace TAPTAGPOS // <-- IMPORTANT: Change this to your project's actual namespace
{
    partial class GlobalSupplierSituationForm
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
            this.buttonPayment = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.buttonPeriod = new System.Windows.Forms.Button();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.textBoxTotalBalance = new System.Windows.Forms.TextBox();
            this.textBoxTotalCredit = new System.Windows.Forms.TextBox();
            this.textBoxTotalPayment = new System.Windows.Forms.TextBox();
            this.textBoxTotalTotal = new System.Windows.Forms.TextBox();
            this.textBoxTotalOldBalance = new System.Windows.Forms.TextBox();
            this.labelTotalFooter = new System.Windows.Forms.Label();
            this.dataGridViewSituation = new System.Windows.Forms.DataGridView();
            this.colSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOldBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSituation)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.buttonPayment);
            this.panelTop.Controls.Add(this.buttonPrint);
            this.panelTop.Controls.Add(this.buttonValidate);
            this.panelTop.Controls.Add(this.buttonPeriod);
            this.panelTop.Controls.Add(this.dateTimePickerEndDate);
            this.panelTop.Controls.Add(this.labelEndDate);
            this.panelTop.Controls.Add(this.dateTimePickerStartDate);
            this.panelTop.Controls.Add(this.labelStartDate);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(799, 49);
            this.panelTop.TabIndex = 0;
            // 
            // buttonPayment
            // 
            this.buttonPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.buttonPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonPayment.ForeColor = System.Drawing.Color.White;
            this.buttonPayment.Location = new System.Drawing.Point(708, 10);
            this.buttonPayment.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(82, 28);
            this.buttonPayment.TabIndex = 7;
            this.buttonPayment.Text = "Règlement";
            this.buttonPayment.UseVisualStyleBackColor = false;
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Location = new System.Drawing.Point(621, 10);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(82, 28);
            this.buttonPrint.TabIndex = 6;
            this.buttonPrint.Text = "Imprimer";
            this.buttonPrint.UseVisualStyleBackColor = false;
            // 
            // buttonValidate
            // 
            this.buttonValidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.buttonValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonValidate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonValidate.ForeColor = System.Drawing.Color.White;
            this.buttonValidate.Location = new System.Drawing.Point(534, 10);
            this.buttonValidate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(82, 28);
            this.buttonValidate.TabIndex = 5;
            this.buttonValidate.Text = "Valider";
            this.buttonValidate.UseVisualStyleBackColor = false;
            // 
            // buttonPeriod
            // 
            this.buttonPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.buttonPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPeriod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonPeriod.ForeColor = System.Drawing.Color.White;
            this.buttonPeriod.Location = new System.Drawing.Point(439, 10);
            this.buttonPeriod.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPeriod.Name = "buttonPeriod";
            this.buttonPeriod.Size = new System.Drawing.Size(82, 28);
            this.buttonPeriod.TabIndex = 4;
            this.buttonPeriod.Text = "Période";
            this.buttonPeriod.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(299, 15);
            this.dateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerEndDate.TabIndex = 3;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelEndDate.Location = new System.Drawing.Point(221, 16);
            this.labelEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(72, 14);
            this.labelEndDate.TabIndex = 2;
            this.labelEndDate.Text = "Date de fin:";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(104, 15);
            this.dateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerStartDate.TabIndex = 1;
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelStartDate.Location = new System.Drawing.Point(8, 16);
            this.labelStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(92, 14);
            this.labelStartDate.TabIndex = 0;
            this.labelStartDate.Text = "Date de début:";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.textBoxTotalBalance);
            this.panelBottom.Controls.Add(this.textBoxTotalCredit);
            this.panelBottom.Controls.Add(this.textBoxTotalPayment);
            this.panelBottom.Controls.Add(this.textBoxTotalTotal);
            this.panelBottom.Controls.Add(this.textBoxTotalOldBalance);
            this.panelBottom.Controls.Add(this.labelTotalFooter);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 474);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(2);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(799, 42);
            this.panelBottom.TabIndex = 1;
            // 
            // textBoxTotalBalance
            // 
            this.textBoxTotalBalance.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTotalBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalBalance.Location = new System.Drawing.Point(661, 8);
            this.textBoxTotalBalance.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalBalance.Name = "textBoxTotalBalance";
            this.textBoxTotalBalance.ReadOnly = true;
            this.textBoxTotalBalance.Size = new System.Drawing.Size(105, 12);
            this.textBoxTotalBalance.TabIndex = 5;
            // 
            // textBoxTotalCredit
            // 
            this.textBoxTotalCredit.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTotalCredit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalCredit.Location = new System.Drawing.Point(551, 8);
            this.textBoxTotalCredit.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalCredit.Name = "textBoxTotalCredit";
            this.textBoxTotalCredit.ReadOnly = true;
            this.textBoxTotalCredit.Size = new System.Drawing.Size(105, 12);
            this.textBoxTotalCredit.TabIndex = 4;
            // 
            // textBoxTotalPayment
            // 
            this.textBoxTotalPayment.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTotalPayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalPayment.Location = new System.Drawing.Point(442, 8);
            this.textBoxTotalPayment.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalPayment.Name = "textBoxTotalPayment";
            this.textBoxTotalPayment.ReadOnly = true;
            this.textBoxTotalPayment.Size = new System.Drawing.Size(105, 12);
            this.textBoxTotalPayment.TabIndex = 3;
            // 
            // textBoxTotalTotal
            // 
            this.textBoxTotalTotal.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTotalTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalTotal.Location = new System.Drawing.Point(332, 8);
            this.textBoxTotalTotal.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalTotal.Name = "textBoxTotalTotal";
            this.textBoxTotalTotal.ReadOnly = true;
            this.textBoxTotalTotal.Size = new System.Drawing.Size(105, 12);
            this.textBoxTotalTotal.TabIndex = 2;
            // 
            // textBoxTotalOldBalance
            // 
            this.textBoxTotalOldBalance.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTotalOldBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalOldBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalOldBalance.Location = new System.Drawing.Point(223, 8);
            this.textBoxTotalOldBalance.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalOldBalance.Name = "textBoxTotalOldBalance";
            this.textBoxTotalOldBalance.ReadOnly = true;
            this.textBoxTotalOldBalance.Size = new System.Drawing.Size(105, 12);
            this.textBoxTotalOldBalance.TabIndex = 1;
            // 
            // labelTotalFooter
            // 
            this.labelTotalFooter.AutoSize = true;
            this.labelTotalFooter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelTotalFooter.Location = new System.Drawing.Point(9, 15);
            this.labelTotalFooter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalFooter.Name = "labelTotalFooter";
            this.labelTotalFooter.Size = new System.Drawing.Size(38, 14);
            this.labelTotalFooter.TabIndex = 0;
            this.labelTotalFooter.Text = "Total";
            // 
            // dataGridViewSituation
            // 
            this.dataGridViewSituation.AllowUserToAddRows = false;
            this.dataGridViewSituation.AllowUserToDeleteRows = false;
            this.dataGridViewSituation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSituation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSituation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSituation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSituation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSupplier,
            this.colOldBalance,
            this.colTotal,
            this.colPayment,
            this.colCredit,
            this.colBalance});
            this.dataGridViewSituation.Location = new System.Drawing.Point(7, 8);
            this.dataGridViewSituation.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSituation.Name = "dataGridViewSituation";
            this.dataGridViewSituation.ReadOnly = true;
            this.dataGridViewSituation.RowHeadersVisible = false;
            this.dataGridViewSituation.RowHeadersWidth = 51;
            this.dataGridViewSituation.RowTemplate.Height = 24;
            this.dataGridViewSituation.Size = new System.Drawing.Size(786, 407);
            this.dataGridViewSituation.TabIndex = 2;
            this.dataGridViewSituation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSituation_CellClick);
            // 
            // colSupplier
            // 
            this.colSupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSupplier.HeaderText = "Fournisseur";
            this.colSupplier.MinimumWidth = 6;
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.ReadOnly = true;
            // 
            // colOldBalance
            // 
            this.colOldBalance.HeaderText = "Ancien solde";
            this.colOldBalance.MinimumWidth = 6;
            this.colOldBalance.Name = "colOldBalance";
            this.colOldBalance.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colPayment
            // 
            this.colPayment.HeaderText = "Règlement";
            this.colPayment.MinimumWidth = 6;
            this.colPayment.Name = "colPayment";
            this.colPayment.ReadOnly = true;
            // 
            // colCredit
            // 
            this.colCredit.HeaderText = "Avoir";
            this.colCredit.MinimumWidth = 6;
            this.colCredit.Name = "colCredit";
            this.colCredit.ReadOnly = true;
            // 
            // colBalance
            // 
            this.colBalance.HeaderText = "Solde";
            this.colBalance.MinimumWidth = 6;
            this.colBalance.Name = "colBalance";
            this.colBalance.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewSituation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 425);
            this.panel1.TabIndex = 3;
            // 
            // GlobalSupplierSituationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GlobalSupplierSituationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Situation Global des Fournisseur";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSituation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.DataGridView dataGridViewSituation;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Button buttonPeriod;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.Label labelTotalFooter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOldBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalance;
        private System.Windows.Forms.TextBox textBoxTotalOldBalance;
        private System.Windows.Forms.TextBox textBoxTotalBalance;
        private System.Windows.Forms.TextBox textBoxTotalCredit;
        private System.Windows.Forms.TextBox textBoxTotalPayment;
        private System.Windows.Forms.TextBox textBoxTotalTotal;
        private System.Windows.Forms.Panel panel1;
    }
}