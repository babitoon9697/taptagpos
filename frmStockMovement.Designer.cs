using System.Drawing;

namespace TAPTAGPOS
{
    partial class frmStockMovement
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockMovement));
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblStockAlert = new System.Windows.Forms.Label();
            this.pnlAlertKey = new System.Windows.Forms.Panel();
            this.lblOutOfStock = new System.Windows.Forms.Label();
            this.pnlOutOfStockKey = new System.Windows.Forms.Panel();
            this.dgvStockMovement = new System.Windows.Forms.DataGridView();
            this.colReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockInitial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockAlert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.dtpDateDebut = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dtpDateFin = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockMovement)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilters
            // 
            this.pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilters.Controls.Add(this.dtpDateFin);
            this.pnlFilters.Controls.Add(this.dtpDateDebut);
            this.pnlFilters.Controls.Add(this.btnPrint);
            this.pnlFilters.Controls.Add(this.btnDetail);
            this.pnlFilters.Controls.Add(this.cmbCategory);
            this.pnlFilters.Controls.Add(this.lblCategory);
            this.pnlFilters.Controls.Add(this.txtDesignation);
            this.pnlFilters.Controls.Add(this.lblDesignation);
            this.pnlFilters.Controls.Add(this.lblStockAlert);
            this.pnlFilters.Controls.Add(this.pnlAlertKey);
            this.pnlFilters.Controls.Add(this.lblOutOfStock);
            this.pnlFilters.Controls.Add(this.pnlOutOfStockKey);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Location = new System.Drawing.Point(0, 0);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(892, 89);
            this.pnlFilters.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Location = new System.Drawing.Point(601, 44);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(139, 30);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Imprimer";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDetail.Location = new System.Drawing.Point(601, 11);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(139, 30);
            this.btnDetail.TabIndex = 4;
            this.btnDetail.Text = "Détail";
            this.btnDetail.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(339, 49);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(180, 21);
            this.cmbCategory.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(245, 52);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(47, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Famille";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(339, 16);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(180, 20);
            this.txtDesignation.TabIndex = 1;
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDesignation.Location = new System.Drawing.Point(245, 18);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(74, 13);
            this.lblDesignation.TabIndex = 0;
            this.lblDesignation.Text = "Désignation";
            // 
            // lblStockAlert
            // 
            this.lblStockAlert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStockAlert.Location = new System.Drawing.Point(761, 8);
            this.lblStockAlert.Name = "lblStockAlert";
            this.lblStockAlert.Size = new System.Drawing.Size(100, 23);
            this.lblStockAlert.TabIndex = 0;
            this.lblStockAlert.Text = "Stock en Alerte";
            // 
            // pnlAlertKey
            // 
            this.pnlAlertKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAlertKey.BackColor = System.Drawing.Color.PaleGreen;
            this.pnlAlertKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAlertKey.Location = new System.Drawing.Point(867, 5);
            this.pnlAlertKey.Name = "pnlAlertKey";
            this.pnlAlertKey.Size = new System.Drawing.Size(20, 20);
            this.pnlAlertKey.TabIndex = 8;
            // 
            // lblOutOfStock
            // 
            this.lblOutOfStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutOfStock.Location = new System.Drawing.Point(761, 31);
            this.lblOutOfStock.Name = "lblOutOfStock";
            this.lblOutOfStock.Size = new System.Drawing.Size(100, 23);
            this.lblOutOfStock.TabIndex = 0;
            this.lblOutOfStock.Text = "Rupture de Stock";
            // 
            // pnlOutOfStockKey
            // 
            this.pnlOutOfStockKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOutOfStockKey.BackColor = System.Drawing.Color.LightCoral;
            this.pnlOutOfStockKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOutOfStockKey.Location = new System.Drawing.Point(867, 28);
            this.pnlOutOfStockKey.Name = "pnlOutOfStockKey";
            this.pnlOutOfStockKey.Size = new System.Drawing.Size(20, 20);
            this.pnlOutOfStockKey.TabIndex = 9;
            // 
            // dgvStockMovement
            // 
            this.dgvStockMovement.AllowUserToAddRows = false;
            this.dgvStockMovement.AllowUserToDeleteRows = false;
            this.dgvStockMovement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockMovement.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockMovement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStockMovement.ColumnHeadersHeight = 30;
            this.dgvStockMovement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReference,
            this.colDesignation,
            this.colStockInitial,
            this.colEntries,
            this.colExits,
            this.colStock,
            this.colStockAlert});
            this.dgvStockMovement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockMovement.EnableHeadersVisualStyles = false;
            this.dgvStockMovement.Location = new System.Drawing.Point(0, 89);
            this.dgvStockMovement.Name = "dgvStockMovement";
            this.dgvStockMovement.ReadOnly = true;
            this.dgvStockMovement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dgvStockMovement.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStockMovement.RowTemplate.Height = 24;
            this.dgvStockMovement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockMovement.Size = new System.Drawing.Size(892, 481);
            this.dgvStockMovement.TabIndex = 1;
            // 
            // colReference
            // 
            this.colReference.HeaderText = "Référence";
            this.colReference.Name = "colReference";
            this.colReference.ReadOnly = true;
            // 
            // colDesignation
            // 
            this.colDesignation.FillWeight = 200F;
            this.colDesignation.HeaderText = "Désignation";
            this.colDesignation.Name = "colDesignation";
            this.colDesignation.ReadOnly = true;
            // 
            // colStockInitial
            // 
            this.colStockInitial.HeaderText = "Stock Initial";
            this.colStockInitial.Name = "colStockInitial";
            this.colStockInitial.ReadOnly = true;
            // 
            // colEntries
            // 
            this.colEntries.HeaderText = "Les Entrées";
            this.colEntries.Name = "colEntries";
            this.colEntries.ReadOnly = true;
            // 
            // colExits
            // 
            this.colExits.HeaderText = "Les Sorties";
            this.colExits.Name = "colExits";
            this.colExits.ReadOnly = true;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // colStockAlert
            // 
            this.colStockAlert.HeaderText = "Stock Alerte";
            this.colStockAlert.Name = "colStockAlert";
            this.colStockAlert.ReadOnly = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.BackColor = System.Drawing.Color.Transparent;
            this.dtpDateDebut.BorderColor = System.Drawing.Color.Silver;
            this.dtpDateDebut.BorderRadius = 1;
            this.dtpDateDebut.Color = System.Drawing.Color.Silver;
            this.dtpDateDebut.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpDateDebut.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpDateDebut.DisabledColor = System.Drawing.Color.Gray;
            this.dtpDateDebut.DisplayWeekNumbers = false;
            this.dtpDateDebut.DPHeight = 0;
            this.dtpDateDebut.FillDatePicker = false;
            this.dtpDateDebut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDateDebut.ForeColor = System.Drawing.Color.Black;
            this.dtpDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDebut.Icon = ((System.Drawing.Image)(resources.GetObject("dtpDateDebut.Icon")));
            this.dtpDateDebut.IconColor = System.Drawing.Color.Gray;
            this.dtpDateDebut.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpDateDebut.LeftTextMargin = 5;
            this.dtpDateDebut.Location = new System.Drawing.Point(25, 8);
            this.dtpDateDebut.MinimumSize = new System.Drawing.Size(0, 32);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(180, 32);
            this.dtpDateDebut.TabIndex = 10;
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.BackColor = System.Drawing.Color.Transparent;
            this.dtpDateFin.BorderColor = System.Drawing.Color.Silver;
            this.dtpDateFin.BorderRadius = 1;
            this.dtpDateFin.Color = System.Drawing.Color.Silver;
            this.dtpDateFin.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpDateFin.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpDateFin.DisabledColor = System.Drawing.Color.Gray;
            this.dtpDateFin.DisplayWeekNumbers = false;
            this.dtpDateFin.DPHeight = 0;
            this.dtpDateFin.FillDatePicker = false;
            this.dtpDateFin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDateFin.ForeColor = System.Drawing.Color.Black;
            this.dtpDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFin.Icon = ((System.Drawing.Image)(resources.GetObject("dtpDateFin.Icon")));
            this.dtpDateFin.IconColor = System.Drawing.Color.Gray;
            this.dtpDateFin.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpDateFin.LeftTextMargin = 5;
            this.dtpDateFin.Location = new System.Drawing.Point(25, 42);
            this.dtpDateFin.MinimumSize = new System.Drawing.Size(0, 32);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(180, 32);
            this.dtpDateFin.TabIndex = 11;
            // 
            // frmStockMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 570);
            this.Controls.Add(this.dgvStockMovement);
            this.Controls.Add(this.pnlFilters);
            this.MinimumSize = new System.Drawing.Size(908, 609);
            this.Name = "frmStockMovement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Mouvement Du Stock Global";
            this.Load += new System.EventHandler(this.frmStockMovement_Load);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockMovement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilters;

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblOutOfStock;
        private System.Windows.Forms.Label lblStockAlert;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.DataGridView dgvStockMovement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockInitial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntries;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExits;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockAlert;
        private System.Windows.Forms.Panel pnlAlertKey;
        private System.Windows.Forms.Panel pnlOutOfStockKey;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpDateDebut;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpDateFin;
    }
}