namespace TAPTAGPOS // <-- IMPORTANT: Change this to your project's actual namespace
{
    partial class SupplierChecksForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopControls = new System.Windows.Forms.Panel();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.checkBoxPaid = new System.Windows.Forms.CheckBox();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.buttonPeriod = new System.Windows.Forms.Button();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.panelBottomTotals = new System.Windows.Forms.Panel();
            this.buttonSolder = new System.Windows.Forms.Button();
            this.textBoxAmountRemaining = new System.Windows.Forms.TextBox();
            this.labelAmountRemaining = new System.Windows.Forms.Label();
            this.textBoxAmountPaid = new System.Windows.Forms.TextBox();
            this.labelAmountPaid = new System.Windows.Forms.Label();
            this.textBoxAmountTotal = new System.Windows.Forms.TextBox();
            this.labelAmountTotal = new System.Windows.Forms.Label();
            this.labelChecksAmount = new System.Windows.Forms.Label();
            this.textBoxCountRemaining = new System.Windows.Forms.TextBox();
            this.labelCountRemaining = new System.Windows.Forms.Label();
            this.textBoxCountPaid = new System.Windows.Forms.TextBox();
            this.labelCountPaid = new System.Windows.Forms.Label();
            this.textBoxCountTotal = new System.Windows.Forms.TextBox();
            this.labelCountTotal = new System.Windows.Forms.Label();
            this.labelChecksNumber = new System.Windows.Forms.Label();
            this.dataGridViewChecks = new System.Windows.Forms.DataGridView();
            this.colCheckNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsPaid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colObservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTopControls.SuspendLayout();
            this.panelBottomTotals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChecks)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopControls
            // 
            this.panelTopControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTopControls.Controls.Add(this.buttonPrint);
            this.panelTopControls.Controls.Add(this.buttonSave);
            this.panelTopControls.Controls.Add(this.buttonValidate);
            this.panelTopControls.Controls.Add(this.checkBoxPaid);
            this.panelTopControls.Controls.Add(this.checkBoxAll);
            this.panelTopControls.Controls.Add(this.comboBoxSupplier);
            this.panelTopControls.Controls.Add(this.labelSupplier);
            this.panelTopControls.Controls.Add(this.buttonPeriod);
            this.panelTopControls.Controls.Add(this.dateTimePickerEndDate);
            this.panelTopControls.Controls.Add(this.labelEndDate);
            this.panelTopControls.Controls.Add(this.dateTimePickerStartDate);
            this.panelTopControls.Controls.Add(this.labelStartDate);
            this.panelTopControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopControls.Location = new System.Drawing.Point(0, 0);
            this.panelTopControls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTopControls.Name = "panelTopControls";
            this.panelTopControls.Size = new System.Drawing.Size(812, 74);
            this.panelTopControls.TabIndex = 0;
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrint.Location = new System.Drawing.Point(695, 38);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(30, 24);
            this.buttonPrint.TabIndex = 11;
            this.buttonPrint.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Location = new System.Drawing.Point(661, 38);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(30, 24);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonValidate
            // 
            this.buttonValidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonValidate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonValidate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonValidate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonValidate.Location = new System.Drawing.Point(580, 38);
            this.buttonValidate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.buttonValidate.Size = new System.Drawing.Size(76, 24);
            this.buttonValidate.TabIndex = 9;
            this.buttonValidate.Text = "Valider";
            this.buttonValidate.UseVisualStyleBackColor = false;
            // 
            // checkBoxPaid
            // 
            this.checkBoxPaid.AutoSize = true;
            this.checkBoxPaid.Location = new System.Drawing.Point(524, 43);
            this.checkBoxPaid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxPaid.Name = "checkBoxPaid";
            this.checkBoxPaid.Size = new System.Drawing.Size(53, 17);
            this.checkBoxPaid.TabIndex = 8;
            this.checkBoxPaid.Text = "Soldé";
            this.checkBoxPaid.UseVisualStyleBackColor = true;
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Location = new System.Drawing.Point(467, 43);
            this.checkBoxAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(50, 17);
            this.checkBoxAll.TabIndex = 7;
            this.checkBoxAll.Text = "Tous";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(296, 41);
            this.comboBoxSupplier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(160, 21);
            this.comboBoxSupplier.TabIndex = 6;
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Location = new System.Drawing.Point(231, 44);
            this.labelSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(64, 13);
            this.labelSupplier.TabIndex = 5;
            this.labelSupplier.Text = "Fournisseur:";
            // 
            // buttonPeriod
            // 
            this.buttonPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPeriod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonPeriod.Location = new System.Drawing.Point(233, 10);
            this.buttonPeriod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPeriod.Name = "buttonPeriod";
            this.buttonPeriod.Size = new System.Drawing.Size(65, 23);
            this.buttonPeriod.TabIndex = 4;
            this.buttonPeriod.Text = "Période";
            this.buttonPeriod.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(73, 40);
            this.dateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(91, 20);
            this.dateTimePickerEndDate.TabIndex = 3;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(13, 44);
            this.labelEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(62, 13);
            this.labelEndDate.TabIndex = 2;
            this.labelEndDate.Text = "Date de fin:";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(73, 12);
            this.dateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(91, 20);
            this.dateTimePickerStartDate.TabIndex = 1;
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(8, 16);
            this.labelStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(66, 13);
            this.labelStartDate.TabIndex = 0;
            this.labelStartDate.Text = "Date de but:";
            // 
            // panelBottomTotals
            // 
            this.panelBottomTotals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottomTotals.Controls.Add(this.buttonSolder);
            this.panelBottomTotals.Controls.Add(this.textBoxAmountRemaining);
            this.panelBottomTotals.Controls.Add(this.labelAmountRemaining);
            this.panelBottomTotals.Controls.Add(this.textBoxAmountPaid);
            this.panelBottomTotals.Controls.Add(this.labelAmountPaid);
            this.panelBottomTotals.Controls.Add(this.textBoxAmountTotal);
            this.panelBottomTotals.Controls.Add(this.labelAmountTotal);
            this.panelBottomTotals.Controls.Add(this.labelChecksAmount);
            this.panelBottomTotals.Controls.Add(this.textBoxCountRemaining);
            this.panelBottomTotals.Controls.Add(this.labelCountRemaining);
            this.panelBottomTotals.Controls.Add(this.textBoxCountPaid);
            this.panelBottomTotals.Controls.Add(this.labelCountPaid);
            this.panelBottomTotals.Controls.Add(this.textBoxCountTotal);
            this.panelBottomTotals.Controls.Add(this.labelCountTotal);
            this.panelBottomTotals.Controls.Add(this.labelChecksNumber);
            this.panelBottomTotals.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomTotals.Location = new System.Drawing.Point(0, 384);
            this.panelBottomTotals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBottomTotals.Name = "panelBottomTotals";
            this.panelBottomTotals.Size = new System.Drawing.Size(812, 65);
            this.panelBottomTotals.TabIndex = 1;
            // 
            // buttonSolder
            // 
            this.buttonSolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSolder.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSolder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSolder.ForeColor = System.Drawing.Color.White;
            this.buttonSolder.Location = new System.Drawing.Point(718, 16);
            this.buttonSolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSolder.Name = "buttonSolder";
            this.buttonSolder.Size = new System.Drawing.Size(83, 32);
            this.buttonSolder.TabIndex = 14;
            this.buttonSolder.Text = "Solder";
            this.buttonSolder.UseVisualStyleBackColor = false;
            // 
            // textBoxAmountRemaining
            // 
            this.textBoxAmountRemaining.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxAmountRemaining.Location = new System.Drawing.Point(619, 35);
            this.textBoxAmountRemaining.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAmountRemaining.Name = "textBoxAmountRemaining";
            this.textBoxAmountRemaining.ReadOnly = true;
            this.textBoxAmountRemaining.Size = new System.Drawing.Size(76, 20);
            this.textBoxAmountRemaining.TabIndex = 13;
            this.textBoxAmountRemaining.Text = "0,00";
            this.textBoxAmountRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelAmountRemaining
            // 
            this.labelAmountRemaining.AutoSize = true;
            this.labelAmountRemaining.Location = new System.Drawing.Point(616, 18);
            this.labelAmountRemaining.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAmountRemaining.Name = "labelAmountRemaining";
            this.labelAmountRemaining.Size = new System.Drawing.Size(40, 13);
            this.labelAmountRemaining.TabIndex = 12;
            this.labelAmountRemaining.Text = "Restes";
            // 
            // textBoxAmountPaid
            // 
            this.textBoxAmountPaid.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxAmountPaid.Location = new System.Drawing.Point(539, 35);
            this.textBoxAmountPaid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAmountPaid.Name = "textBoxAmountPaid";
            this.textBoxAmountPaid.ReadOnly = true;
            this.textBoxAmountPaid.Size = new System.Drawing.Size(76, 20);
            this.textBoxAmountPaid.TabIndex = 11;
            this.textBoxAmountPaid.Text = "0,00";
            this.textBoxAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelAmountPaid
            // 
            this.labelAmountPaid.AutoSize = true;
            this.labelAmountPaid.Location = new System.Drawing.Point(537, 18);
            this.labelAmountPaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAmountPaid.Name = "labelAmountPaid";
            this.labelAmountPaid.Size = new System.Drawing.Size(39, 13);
            this.labelAmountPaid.TabIndex = 10;
            this.labelAmountPaid.Text = "Soldes";
            // 
            // textBoxAmountTotal
            // 
            this.textBoxAmountTotal.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxAmountTotal.Location = new System.Drawing.Point(460, 35);
            this.textBoxAmountTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAmountTotal.Name = "textBoxAmountTotal";
            this.textBoxAmountTotal.ReadOnly = true;
            this.textBoxAmountTotal.Size = new System.Drawing.Size(76, 20);
            this.textBoxAmountTotal.TabIndex = 9;
            this.textBoxAmountTotal.Text = "0,00";
            this.textBoxAmountTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelAmountTotal
            // 
            this.labelAmountTotal.AutoSize = true;
            this.labelAmountTotal.Location = new System.Drawing.Point(458, 18);
            this.labelAmountTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAmountTotal.Name = "labelAmountTotal";
            this.labelAmountTotal.Size = new System.Drawing.Size(31, 13);
            this.labelAmountTotal.TabIndex = 8;
            this.labelAmountTotal.Text = "Total";
            // 
            // labelChecksAmount
            // 
            this.labelChecksAmount.AutoSize = true;
            this.labelChecksAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChecksAmount.Location = new System.Drawing.Point(338, 5);
            this.labelChecksAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChecksAmount.Name = "labelChecksAmount";
            this.labelChecksAmount.Size = new System.Drawing.Size(129, 13);
            this.labelChecksAmount.TabIndex = 7;
            this.labelChecksAmount.Text = "Montant des chèques";
            // 
            // textBoxCountRemaining
            // 
            this.textBoxCountRemaining.Location = new System.Drawing.Point(244, 35);
            this.textBoxCountRemaining.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCountRemaining.Name = "textBoxCountRemaining";
            this.textBoxCountRemaining.ReadOnly = true;
            this.textBoxCountRemaining.Size = new System.Drawing.Size(54, 20);
            this.textBoxCountRemaining.TabIndex = 6;
            this.textBoxCountRemaining.Text = "0";
            this.textBoxCountRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCountRemaining
            // 
            this.labelCountRemaining.AutoSize = true;
            this.labelCountRemaining.Location = new System.Drawing.Point(242, 18);
            this.labelCountRemaining.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountRemaining.Name = "labelCountRemaining";
            this.labelCountRemaining.Size = new System.Drawing.Size(40, 13);
            this.labelCountRemaining.TabIndex = 5;
            this.labelCountRemaining.Text = "Restes";
            // 
            // textBoxCountPaid
            // 
            this.textBoxCountPaid.Location = new System.Drawing.Point(188, 35);
            this.textBoxCountPaid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCountPaid.Name = "textBoxCountPaid";
            this.textBoxCountPaid.ReadOnly = true;
            this.textBoxCountPaid.Size = new System.Drawing.Size(54, 20);
            this.textBoxCountPaid.TabIndex = 4;
            this.textBoxCountPaid.Text = "0";
            this.textBoxCountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCountPaid
            // 
            this.labelCountPaid.AutoSize = true;
            this.labelCountPaid.Location = new System.Drawing.Point(185, 18);
            this.labelCountPaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountPaid.Name = "labelCountPaid";
            this.labelCountPaid.Size = new System.Drawing.Size(39, 13);
            this.labelCountPaid.TabIndex = 3;
            this.labelCountPaid.Text = "Soldes";
            // 
            // textBoxCountTotal
            // 
            this.textBoxCountTotal.Location = new System.Drawing.Point(130, 35);
            this.textBoxCountTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCountTotal.Name = "textBoxCountTotal";
            this.textBoxCountTotal.ReadOnly = true;
            this.textBoxCountTotal.Size = new System.Drawing.Size(54, 20);
            this.textBoxCountTotal.TabIndex = 2;
            this.textBoxCountTotal.Text = "0";
            this.textBoxCountTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCountTotal
            // 
            this.labelCountTotal.AutoSize = true;
            this.labelCountTotal.Location = new System.Drawing.Point(128, 18);
            this.labelCountTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountTotal.Name = "labelCountTotal";
            this.labelCountTotal.Size = new System.Drawing.Size(31, 13);
            this.labelCountTotal.TabIndex = 1;
            this.labelCountTotal.Text = "Total";
            // 
            // labelChecksNumber
            // 
            this.labelChecksNumber.AutoSize = true;
            this.labelChecksNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChecksNumber.Location = new System.Drawing.Point(8, 5);
            this.labelChecksNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChecksNumber.Name = "labelChecksNumber";
            this.labelChecksNumber.Size = new System.Drawing.Size(126, 13);
            this.labelChecksNumber.TabIndex = 0;
            this.labelChecksNumber.Text = "Nombre des chèques";
            // 
            // dataGridViewChecks
            // 
            this.dataGridViewChecks.AllowUserToAddRows = false;
            this.dataGridViewChecks.AllowUserToDeleteRows = false;
            this.dataGridViewChecks.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChecks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewChecks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChecks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheckNumber,
            this.colAccount,
            this.colDueDate,
            this.colAmount,
            this.colIsPaid,
            this.colObservation,
            this.colSupplier});
            this.dataGridViewChecks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewChecks.Location = new System.Drawing.Point(0, 74);
            this.dataGridViewChecks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewChecks.Name = "dataGridViewChecks";
            this.dataGridViewChecks.RowHeadersVisible = false;
            this.dataGridViewChecks.RowHeadersWidth = 51;
            this.dataGridViewChecks.RowTemplate.Height = 24;
            this.dataGridViewChecks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChecks.Size = new System.Drawing.Size(812, 310);
            this.dataGridViewChecks.TabIndex = 2;
            // 
            // colCheckNumber
            // 
            this.colCheckNumber.HeaderText = "N Cheque";
            this.colCheckNumber.MinimumWidth = 6;
            this.colCheckNumber.Name = "colCheckNumber";
            this.colCheckNumber.Width = 125;
            // 
            // colAccount
            // 
            this.colAccount.HeaderText = "Compte";
            this.colAccount.MinimumWidth = 6;
            this.colAccount.Name = "colAccount";
            this.colAccount.Width = 125;
            // 
            // colDueDate
            // 
            this.colDueDate.HeaderText = "Echéance";
            this.colDueDate.MinimumWidth = 6;
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.Width = 125;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Montant";
            this.colAmount.MinimumWidth = 6;
            this.colAmount.Name = "colAmount";
            this.colAmount.Width = 125;
            // 
            // colIsPaid
            // 
            this.colIsPaid.HeaderText = "Soldé";
            this.colIsPaid.MinimumWidth = 6;
            this.colIsPaid.Name = "colIsPaid";
            this.colIsPaid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsPaid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colIsPaid.Width = 60;
            // 
            // colObservation
            // 
            this.colObservation.HeaderText = "Observation";
            this.colObservation.MinimumWidth = 6;
            this.colObservation.Name = "colObservation";
            this.colObservation.Width = 200;
            // 
            // colSupplier
            // 
            this.colSupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSupplier.HeaderText = "Fournisseur";
            this.colSupplier.MinimumWidth = 6;
            this.colSupplier.Name = "colSupplier";
            // 
            // SupplierChecksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 449);
            this.Controls.Add(this.dataGridViewChecks);
            this.Controls.Add(this.panelBottomTotals);
            this.Controls.Add(this.panelTopControls);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SupplierChecksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Situation des Chèques Fournisseurs";
            this.panelTopControls.ResumeLayout(false);
            this.panelTopControls.PerformLayout();
            this.panelBottomTotals.ResumeLayout(false);
            this.panelBottomTotals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChecks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopControls;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Panel panelBottomTotals;
        private System.Windows.Forms.DataGridView dataGridViewChecks;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Button buttonPeriod;
        private System.Windows.Forms.CheckBox checkBoxPaid;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxCountTotal;
        private System.Windows.Forms.Label labelCountTotal;
        private System.Windows.Forms.Label labelChecksNumber;
        private System.Windows.Forms.TextBox textBoxCountRemaining;
        private System.Windows.Forms.Label labelCountRemaining;
        private System.Windows.Forms.TextBox textBoxCountPaid;
        private System.Windows.Forms.Label labelCountPaid;
        private System.Windows.Forms.TextBox textBoxAmountRemaining;
        private System.Windows.Forms.Label labelAmountRemaining;
        private System.Windows.Forms.TextBox textBoxAmountPaid;
        private System.Windows.Forms.Label labelAmountPaid;
        private System.Windows.Forms.TextBox textBoxAmountTotal;
        private System.Windows.Forms.Label labelAmountTotal;
        private System.Windows.Forms.Label labelChecksAmount;
        private System.Windows.Forms.Button buttonSolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier;
    }
}