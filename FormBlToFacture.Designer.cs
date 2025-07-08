namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class FormBlToFacture
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupClient = new System.Windows.Forms.GroupBox();
            this.btnSelectClient = new System.Windows.Forms.Button();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.dgvDeliveryNotes = new System.Windows.Forms.DataGridView();
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colNumBL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.btnToggleSelection = new System.Windows.Forms.Button();
            this.btnFacturer = new System.Windows.Forms.Button();
            this.groupClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupClient
            // 
            this.groupClient.BackColor = System.Drawing.Color.Transparent;
            this.groupClient.Controls.Add(this.btnSelectClient);
            this.groupClient.Controls.Add(this.txtClientName);
            this.groupClient.Controls.Add(this.cmbClient);
            this.groupClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupClient.Location = new System.Drawing.Point(9, 10);
            this.groupClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupClient.Name = "groupClient";
            this.groupClient.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupClient.Size = new System.Drawing.Size(488, 65);
            this.groupClient.TabIndex = 0;
            this.groupClient.TabStop = false;
            this.groupClient.Text = "Client";
            // 
            // btnSelectClient
            // 
            this.btnSelectClient.Location = new System.Drawing.Point(442, 26);
            this.btnSelectClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectClient.Name = "btnSelectClient";
            this.btnSelectClient.Size = new System.Drawing.Size(34, 24);
            this.btnSelectClient.TabIndex = 2;
            this.btnSelectClient.UseVisualStyleBackColor = true;
            // 
            // txtClientName
            // 
            this.txtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.Location = new System.Drawing.Point(210, 28);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.ReadOnly = true;
            this.txtClientName.Size = new System.Drawing.Size(229, 21);
            this.txtClientName.TabIndex = 1;
            // 
            // cmbClient
            // 
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(15, 28);
            this.cmbClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(192, 23);
            this.cmbClient.TabIndex = 0;
            // 
            // dgvDeliveryNotes
            // 
            this.dgvDeliveryNotes.AllowUserToAddRows = false;
            this.dgvDeliveryNotes.AllowUserToDeleteRows = false;
            this.dgvDeliveryNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeliveryNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeliveryNotes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeliveryNotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeliveryNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliveryNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.colNumBL,
            this.colDate,
            this.colTotal});
            this.dgvDeliveryNotes.EnableHeadersVisualStyles = false;
            this.dgvDeliveryNotes.Location = new System.Drawing.Point(9, 89);
            this.dgvDeliveryNotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDeliveryNotes.Name = "dgvDeliveryNotes";
            this.dgvDeliveryNotes.RowHeadersVisible = false;
            this.dgvDeliveryNotes.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvDeliveryNotes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeliveryNotes.RowTemplate.Height = 24;
            this.dgvDeliveryNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeliveryNotes.Size = new System.Drawing.Size(598, 350);
            this.dgvDeliveryNotes.TabIndex = 1;
            // 
            // colSelect
            // 
            this.colSelect.FillWeight = 30F;
            this.colSelect.HeaderText = "";
            this.colSelect.MinimumWidth = 6;
            this.colSelect.Name = "colSelect";
            // 
            // colNumBL
            // 
            this.colNumBL.HeaderText = "N° Bl";
            this.colNumBL.MinimumWidth = 6;
            this.colNumBL.Name = "colNumBL";
            this.colNumBL.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "TOTAL T.T.C";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.BackColor = System.Drawing.Color.Transparent;
            this.chkSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelectAll.Location = new System.Drawing.Point(491, 38);
            this.chkSelectAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(123, 17);
            this.chkSelectAll.TabIndex = 2;
            this.chkSelectAll.Text = "Sélectionner tout";
            this.chkSelectAll.UseVisualStyleBackColor = false;
            // 
            // btnToggleSelection
            // 
            this.btnToggleSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleSelection.Location = new System.Drawing.Point(619, 98);
            this.btnToggleSelection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnToggleSelection.Name = "btnToggleSelection";
            this.btnToggleSelection.Size = new System.Drawing.Size(109, 32);
            this.btnToggleSelection.TabIndex = 3;
            this.btnToggleSelection.Text = "Sel. / Desel.";
            this.btnToggleSelection.UseVisualStyleBackColor = true;
            // 
            // btnFacturer
            // 
            this.btnFacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturer.Location = new System.Drawing.Point(619, 135);
            this.btnFacturer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFacturer.Name = "btnFacturer";
            this.btnFacturer.Size = new System.Drawing.Size(109, 32);
            this.btnFacturer.TabIndex = 4;
            this.btnFacturer.Text = "Facturer";
            this.btnFacturer.UseVisualStyleBackColor = true;
            this.btnFacturer.Click += new System.EventHandler(this.btnFacturer_Click);
            // 
            // FormBlToFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.btnFacturer);
            this.Controls.Add(this.btnToggleSelection);
            this.Controls.Add(this.chkSelectAll);
            this.Controls.Add(this.dgvDeliveryNotes);
            this.Controls.Add(this.groupClient);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(642, 414);
            this.Name = "FormBlToFacture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Facturation des B.L.";
            this.groupClient.ResumeLayout(false);
            this.groupClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupClient;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Button btnSelectClient;
        private System.Windows.Forms.DataGridView dgvDeliveryNotes;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Button btnToggleSelection;
        private System.Windows.Forms.Button btnFacturer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumBL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    }
}