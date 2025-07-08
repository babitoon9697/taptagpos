namespace TAPTAGPOS
{
    partial class FicheStockCorrection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicheStockCorrection));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnChangeWarehouse = new System.Windows.Forms.Button();
            this.cmbWarehouse = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.panelBottomLeft = new System.Windows.Forms.Panel();
            this.tablelayout_articlescontroluser = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnNext = new Bunifu.UI.WinForms.BunifuImageButton();
            this.BtnPrevious = new Bunifu.UI.WinForms.BunifuImageButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnSaveItem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCorrectionLines = new System.Windows.Forms.DataGridView();
            this.colRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOldStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNewStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDifference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRight = new System.Windows.Forms.Panel();
            this.flowLayoutPanelFamilies = new System.Windows.Forms.FlowLayoutPanel();
            this.labelFamily = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelBottomLeft.SuspendLayout();
            this.tablelayout_articlescontroluser.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrectionLines)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Gold;
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.btnChangeWarehouse);
            this.panelTop.Controls.Add(this.cmbWarehouse);
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.dtpDate);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1296, 49);
            this.panelTop.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1254, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 32);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnChangeWarehouse
            // 
            this.btnChangeWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeWarehouse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnChangeWarehouse.Location = new System.Drawing.Point(1122, 12);
            this.btnChangeWarehouse.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeWarehouse.Name = "btnChangeWarehouse";
            this.btnChangeWarehouse.Size = new System.Drawing.Size(112, 24);
            this.btnChangeWarehouse.TabIndex = 3;
            this.btnChangeWarehouse.Text = "تبديل المستودع";
            this.btnChangeWarehouse.UseVisualStyleBackColor = true;
            // 
            // cmbWarehouse
            // 
            this.cmbWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWarehouse.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cmbWarehouse.FormattingEnabled = true;
            this.cmbWarehouse.Location = new System.Drawing.Point(980, 14);
            this.cmbWarehouse.Margin = new System.Windows.Forms.Padding(2);
            this.cmbWarehouse.Name = "cmbWarehouse";
            this.cmbWarehouse.Size = new System.Drawing.Size(136, 22);
            this.cmbWarehouse.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtSearch.Location = new System.Drawing.Point(161, 14);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(808, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "البحث عن السلعة";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtpDate.Location = new System.Drawing.Point(9, 14);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(144, 22);
            this.dtpDate.TabIndex = 0;
            // 
            // panelBottomLeft
            // 
            this.panelBottomLeft.Controls.Add(this.tablelayout_articlescontroluser);
            this.panelBottomLeft.Controls.Add(this.tableLayoutPanel1);
            this.panelBottomLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomLeft.Location = new System.Drawing.Point(0, 465);
            this.panelBottomLeft.Margin = new System.Windows.Forms.Padding(2);
            this.panelBottomLeft.Name = "panelBottomLeft";
            this.panelBottomLeft.Size = new System.Drawing.Size(1296, 267);
            this.panelBottomLeft.TabIndex = 2;
            // 
            // tablelayout_articlescontroluser
            // 
            this.tablelayout_articlescontroluser.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tablelayout_articlescontroluser.ColumnCount = 6;
            this.tablelayout_articlescontroluser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tablelayout_articlescontroluser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tablelayout_articlescontroluser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tablelayout_articlescontroluser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tablelayout_articlescontroluser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tablelayout_articlescontroluser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tablelayout_articlescontroluser.Controls.Add(this.tableLayoutPanel14, 5, 3);
            this.tablelayout_articlescontroluser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablelayout_articlescontroluser.Location = new System.Drawing.Point(135, 0);
            this.tablelayout_articlescontroluser.Margin = new System.Windows.Forms.Padding(2);
            this.tablelayout_articlescontroluser.Name = "tablelayout_articlescontroluser";
            this.tablelayout_articlescontroluser.RowCount = 4;
            this.tablelayout_articlescontroluser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablelayout_articlescontroluser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablelayout_articlescontroluser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablelayout_articlescontroluser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablelayout_articlescontroluser.Size = new System.Drawing.Size(1161, 267);
            this.tablelayout_articlescontroluser.TabIndex = 8;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 2;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Controls.Add(this.BtnNext, 1, 0);
            this.tableLayoutPanel14.Controls.Add(this.BtnPrevious, 0, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(968, 201);
            this.tableLayoutPanel14.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(190, 63);
            this.tableLayoutPanel14.TabIndex = 0;
            // 
            // BtnNext
            // 
            this.BtnNext.ActiveImage = null;
            this.BtnNext.AllowAnimations = true;
            this.BtnNext.AllowBuffering = false;
            this.BtnNext.AllowToggling = false;
            this.BtnNext.AllowZooming = true;
            this.BtnNext.AllowZoomingOnFocus = false;
            this.BtnNext.BackColor = System.Drawing.Color.Transparent;
            this.BtnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNext.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnNext.ErrorImage")));
            this.BtnNext.FadeWhenInactive = false;
            this.BtnNext.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.BtnNext.Image = ((System.Drawing.Image)(resources.GetObject("BtnNext.Image")));
            this.BtnNext.ImageActive = null;
            this.BtnNext.ImageLocation = null;
            this.BtnNext.ImageMargin = 3;
            this.BtnNext.ImageSize = new System.Drawing.Size(86, 54);
            this.BtnNext.ImageZoomSize = new System.Drawing.Size(89, 57);
            this.BtnNext.InitialImage = ((System.Drawing.Image)(resources.GetObject("BtnNext.InitialImage")));
            this.BtnNext.Location = new System.Drawing.Point(98, 3);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Rotation = 0;
            this.BtnNext.ShowActiveImage = true;
            this.BtnNext.ShowCursorChanges = true;
            this.BtnNext.ShowImageBorders = true;
            this.BtnNext.ShowSizeMarkers = false;
            this.BtnNext.Size = new System.Drawing.Size(89, 57);
            this.BtnNext.TabIndex = 1;
            this.BtnNext.ToolTipText = "";
            this.BtnNext.WaitOnLoad = false;
            this.BtnNext.Zoom = 3;
            this.BtnNext.ZoomSpeed = 10;
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.ActiveImage = null;
            this.BtnPrevious.AllowAnimations = true;
            this.BtnPrevious.AllowBuffering = false;
            this.BtnPrevious.AllowToggling = false;
            this.BtnPrevious.AllowZooming = true;
            this.BtnPrevious.AllowZoomingOnFocus = false;
            this.BtnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.BtnPrevious.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPrevious.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnPrevious.ErrorImage")));
            this.BtnPrevious.FadeWhenInactive = false;
            this.BtnPrevious.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.BtnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrevious.Image")));
            this.BtnPrevious.ImageActive = null;
            this.BtnPrevious.ImageLocation = null;
            this.BtnPrevious.ImageMargin = 3;
            this.BtnPrevious.ImageSize = new System.Drawing.Size(86, 54);
            this.BtnPrevious.ImageZoomSize = new System.Drawing.Size(89, 57);
            this.BtnPrevious.InitialImage = ((System.Drawing.Image)(resources.GetObject("BtnPrevious.InitialImage")));
            this.BtnPrevious.Location = new System.Drawing.Point(3, 3);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Rotation = 0;
            this.BtnPrevious.ShowActiveImage = true;
            this.BtnPrevious.ShowCursorChanges = true;
            this.BtnPrevious.ShowImageBorders = true;
            this.BtnPrevious.ShowSizeMarkers = false;
            this.BtnPrevious.Size = new System.Drawing.Size(89, 57);
            this.BtnPrevious.TabIndex = 0;
            this.BtnPrevious.ToolTipText = "";
            this.BtnPrevious.WaitOnLoad = false;
            this.BtnPrevious.Zoom = 3;
            this.BtnPrevious.ZoomSpeed = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnConfirm, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSaveItem, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(135, 267);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.ForestGreen;
            this.btnConfirm.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(2, 2);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(131, 41);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "تأكيد";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSaveItem.ForeColor = System.Drawing.Color.White;
            this.btnSaveItem.Location = new System.Drawing.Point(2, 135);
            this.btnSaveItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.Size = new System.Drawing.Size(131, 41);
            this.btnSaveItem.TabIndex = 1;
            this.btnSaveItem.Text = "حفظ السلعة";
            this.btnSaveItem.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCorrectionLines);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 416);
            this.panel1.TabIndex = 3;
            // 
            // dgvCorrectionLines
            // 
            this.dgvCorrectionLines.AllowUserToAddRows = false;
            this.dgvCorrectionLines.AllowUserToDeleteRows = false;
            this.dgvCorrectionLines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCorrectionLines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCorrectionLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorrectionLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRef,
            this.colDesignation,
            this.colOldStock,
            this.colNewStock,
            this.colDifference});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCorrectionLines.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCorrectionLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCorrectionLines.Location = new System.Drawing.Point(0, 0);
            this.dgvCorrectionLines.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCorrectionLines.Name = "dgvCorrectionLines";
            this.dgvCorrectionLines.RowHeadersVisible = false;
            this.dgvCorrectionLines.RowHeadersWidth = 51;
            this.dgvCorrectionLines.RowTemplate.Height = 24;
            this.dgvCorrectionLines.Size = new System.Drawing.Size(1296, 416);
            this.dgvCorrectionLines.TabIndex = 4;
            // 
            // colRef
            // 
            this.colRef.HeaderText = "Référence";
            this.colRef.MinimumWidth = 6;
            this.colRef.Name = "colRef";
            this.colRef.ReadOnly = true;
            // 
            // colDesignation
            // 
            this.colDesignation.FillWeight = 150F;
            this.colDesignation.HeaderText = "Désignation";
            this.colDesignation.MinimumWidth = 6;
            this.colDesignation.Name = "colDesignation";
            this.colDesignation.ReadOnly = true;
            // 
            // colOldStock
            // 
            this.colOldStock.HeaderText = "Ancien Stock";
            this.colOldStock.MinimumWidth = 6;
            this.colOldStock.Name = "colOldStock";
            this.colOldStock.ReadOnly = true;
            // 
            // colNewStock
            // 
            this.colNewStock.HeaderText = "Nouveau Stock";
            this.colNewStock.MinimumWidth = 6;
            this.colNewStock.Name = "colNewStock";
            // 
            // colDifference
            // 
            this.colDifference.HeaderText = "Ecart";
            this.colDifference.MinimumWidth = 6;
            this.colDifference.Name = "colDifference";
            this.colDifference.ReadOnly = true;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.flowLayoutPanelFamilies);
            this.panelRight.Controls.Add(this.labelFamily);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(942, 49);
            this.panelRight.Margin = new System.Windows.Forms.Padding(2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(354, 416);
            this.panelRight.TabIndex = 4;
            // 
            // flowLayoutPanelFamilies
            // 
            this.flowLayoutPanelFamilies.AutoScroll = true;
            this.flowLayoutPanelFamilies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelFamilies.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanelFamilies.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelFamilies.Name = "flowLayoutPanelFamilies";
            this.flowLayoutPanelFamilies.Size = new System.Drawing.Size(354, 392);
            this.flowLayoutPanelFamilies.TabIndex = 1;
            // 
            // labelFamily
            // 
            this.labelFamily.BackColor = System.Drawing.Color.Gray;
            this.labelFamily.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFamily.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelFamily.ForeColor = System.Drawing.Color.White;
            this.labelFamily.Location = new System.Drawing.Point(0, 0);
            this.labelFamily.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFamily.Name = "labelFamily";
            this.labelFamily.Size = new System.Drawing.Size(354, 24);
            this.labelFamily.TabIndex = 0;
            this.labelFamily.Text = "العائلة";
            this.labelFamily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FicheStockCorrection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 732);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBottomLeft);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FicheStockCorrection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottomLeft.ResumeLayout(false);
            this.tablelayout_articlescontroluser.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrectionLines)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottomLeft;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbWarehouse;
        private System.Windows.Forms.Button btnChangeWarehouse;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnSaveItem;
        private System.Windows.Forms.TableLayoutPanel tablelayout_articlescontroluser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private Bunifu.UI.WinForms.BunifuImageButton BtnNext;
        private Bunifu.UI.WinForms.BunifuImageButton BtnPrevious;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCorrectionLines;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOldStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNewStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDifference;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFamilies;
        private System.Windows.Forms.Label labelFamily;
    }
}