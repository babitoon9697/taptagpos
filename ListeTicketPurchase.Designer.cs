namespace TAPTAGPOS
{
    partial class ListeTicketPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeTicketPurchase));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.dataGridViewFactures = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.InvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grandtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditPurchase = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuButton23 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuDatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuDatePicker2 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.cmbSuppliers = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_StockForm = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btn_AddArticlesForm = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrintA4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btndeleteFacture = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Navy;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 0;
            this.bunifuPanel1.BorderThickness = 0;
            this.bunifuPanel1.Controls.Add(this.dataGridViewFactures);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 102);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(898, 496);
            this.bunifuPanel1.TabIndex = 5;
            // 
            // dataGridViewFactures
            // 
            this.dataGridViewFactures.AllowCustomTheming = false;
            this.dataGridViewFactures.AllowUserToAddRows = false;
            this.dataGridViewFactures.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewFactures.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFactures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFactures.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewFactures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFactures.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewFactures.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFactures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFactures.ColumnHeadersHeight = 40;
            this.dataGridViewFactures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceID,
            this.InvoiceNumber,
            this.PurchaseDate,
            this.SupplierName,
            this.Grandtotal});
            this.dataGridViewFactures.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridViewFactures.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewFactures.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewFactures.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewFactures.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewFactures.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridViewFactures.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewFactures.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewFactures.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewFactures.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewFactures.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGridViewFactures.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewFactures.CurrentTheme.Name = null;
            this.dataGridViewFactures.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewFactures.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewFactures.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewFactures.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewFactures.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFactures.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFactures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFactures.EnableHeadersVisualStyles = false;
            this.dataGridViewFactures.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewFactures.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewFactures.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewFactures.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewFactures.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFactures.Name = "dataGridViewFactures";
            this.dataGridViewFactures.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewFactures.RowHeadersVisible = false;
            this.dataGridViewFactures.RowTemplate.Height = 40;
            this.dataGridViewFactures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFactures.Size = new System.Drawing.Size(898, 496);
            this.dataGridViewFactures.TabIndex = 7;
            this.dataGridViewFactures.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // InvoiceID
            // 
            this.InvoiceID.HeaderText = "رقم الشراء";
            this.InvoiceID.Name = "InvoiceID";
            // 
            // InvoiceNumber
            // 
            this.InvoiceNumber.HeaderText = "رقم الفاتورة";
            this.InvoiceNumber.Name = "InvoiceNumber";
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.HeaderText = "التاريخ";
            this.PurchaseDate.Name = "PurchaseDate";
            // 
            // SupplierName
            // 
            this.SupplierName.HeaderText = "المزود";
            this.SupplierName.Name = "SupplierName";
            // 
            // Grandtotal
            // 
            this.Grandtotal.HeaderText = "المبلغ";
            this.Grandtotal.Name = "Grandtotal";
            // 
            // btnEditPurchase
            // 
            this.btnEditPurchase.AllowAnimations = true;
            this.btnEditPurchase.AllowMouseEffects = true;
            this.btnEditPurchase.AllowToggling = false;
            this.btnEditPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditPurchase.AnimationSpeed = 200;
            this.btnEditPurchase.AutoGenerateColors = false;
            this.btnEditPurchase.AutoRoundBorders = false;
            this.btnEditPurchase.AutoSizeLeftIcon = true;
            this.btnEditPurchase.AutoSizeRightIcon = true;
            this.btnEditPurchase.BackColor = System.Drawing.Color.Transparent;
            this.btnEditPurchase.BackColor1 = System.Drawing.Color.Transparent;
            this.btnEditPurchase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditPurchase.BackgroundImage")));
            this.btnEditPurchase.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEditPurchase.ButtonText = "تعديل الفاتورة";
            this.btnEditPurchase.ButtonTextMarginLeft = 0;
            this.btnEditPurchase.ColorContrastOnClick = 45;
            this.btnEditPurchase.ColorContrastOnHover = 45;
            this.btnEditPurchase.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnEditPurchase.CustomizableEdges = borderEdges1;
            this.btnEditPurchase.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditPurchase.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEditPurchase.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEditPurchase.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEditPurchase.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnEditPurchase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPurchase.ForeColor = System.Drawing.Color.Red;
            this.btnEditPurchase.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPurchase.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEditPurchase.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEditPurchase.IconMarginLeft = 11;
            this.btnEditPurchase.IconPadding = 10;
            this.btnEditPurchase.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditPurchase.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEditPurchase.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEditPurchase.IconSize = 25;
            this.btnEditPurchase.IdleBorderColor = System.Drawing.Color.Red;
            this.btnEditPurchase.IdleBorderRadius = 5;
            this.btnEditPurchase.IdleBorderThickness = 1;
            this.btnEditPurchase.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnEditPurchase.IdleIconLeftImage = null;
            this.btnEditPurchase.IdleIconRightImage = null;
            this.btnEditPurchase.IndicateFocus = false;
            this.btnEditPurchase.Location = new System.Drawing.Point(3, 186);
            this.btnEditPurchase.Name = "btnEditPurchase";
            this.btnEditPurchase.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEditPurchase.OnDisabledState.BorderRadius = 5;
            this.btnEditPurchase.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEditPurchase.OnDisabledState.BorderThickness = 1;
            this.btnEditPurchase.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEditPurchase.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEditPurchase.OnDisabledState.IconLeftImage = null;
            this.btnEditPurchase.OnDisabledState.IconRightImage = null;
            this.btnEditPurchase.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnEditPurchase.onHoverState.BorderRadius = 5;
            this.btnEditPurchase.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEditPurchase.onHoverState.BorderThickness = 1;
            this.btnEditPurchase.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnEditPurchase.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnEditPurchase.onHoverState.IconLeftImage = null;
            this.btnEditPurchase.onHoverState.IconRightImage = null;
            this.btnEditPurchase.OnIdleState.BorderColor = System.Drawing.Color.Red;
            this.btnEditPurchase.OnIdleState.BorderRadius = 5;
            this.btnEditPurchase.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEditPurchase.OnIdleState.BorderThickness = 1;
            this.btnEditPurchase.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnEditPurchase.OnIdleState.ForeColor = System.Drawing.Color.Red;
            this.btnEditPurchase.OnIdleState.IconLeftImage = null;
            this.btnEditPurchase.OnIdleState.IconRightImage = null;
            this.btnEditPurchase.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEditPurchase.OnPressedState.BorderRadius = 5;
            this.btnEditPurchase.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEditPurchase.OnPressedState.BorderThickness = 1;
            this.btnEditPurchase.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEditPurchase.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEditPurchase.OnPressedState.IconLeftImage = null;
            this.btnEditPurchase.OnPressedState.IconRightImage = null;
            this.btnEditPurchase.Size = new System.Drawing.Size(164, 39);
            this.btnEditPurchase.TabIndex = 5;
            this.btnEditPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditPurchase.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditPurchase.TextMarginLeft = 0;
            this.btnEditPurchase.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEditPurchase.UseDefaultRadiusAndThickness = true;
            this.btnEditPurchase.Click += new System.EventHandler(this.btnEditPurchase_Click);
            // 
            // bunifuButton23
            // 
            this.bunifuButton23.AllowAnimations = true;
            this.bunifuButton23.AllowMouseEffects = true;
            this.bunifuButton23.AllowToggling = false;
            this.bunifuButton23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuButton23.AnimationSpeed = 200;
            this.bunifuButton23.AutoGenerateColors = false;
            this.bunifuButton23.AutoRoundBorders = false;
            this.bunifuButton23.AutoSizeLeftIcon = true;
            this.bunifuButton23.AutoSizeRightIcon = true;
            this.bunifuButton23.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton23.BackColor1 = System.Drawing.Color.DarkRed;
            this.bunifuButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton23.BackgroundImage")));
            this.bunifuButton23.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton23.ButtonText = "الخروج";
            this.bunifuButton23.ButtonTextMarginLeft = 0;
            this.bunifuButton23.ColorContrastOnClick = 45;
            this.bunifuButton23.ColorContrastOnHover = 45;
            this.bunifuButton23.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton23.CustomizableEdges = borderEdges2;
            this.bunifuButton23.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton23.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton23.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton23.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton23.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bunifuButton23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton23.ForeColor = System.Drawing.Color.White;
            this.bunifuButton23.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton23.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton23.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton23.IconMarginLeft = 11;
            this.bunifuButton23.IconPadding = 10;
            this.bunifuButton23.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton23.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton23.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton23.IconSize = 25;
            this.bunifuButton23.IdleBorderColor = System.Drawing.Color.DarkRed;
            this.bunifuButton23.IdleBorderRadius = 5;
            this.bunifuButton23.IdleBorderThickness = 1;
            this.bunifuButton23.IdleFillColor = System.Drawing.Color.DarkRed;
            this.bunifuButton23.IdleIconLeftImage = null;
            this.bunifuButton23.IdleIconRightImage = null;
            this.bunifuButton23.IndicateFocus = false;
            this.bunifuButton23.Location = new System.Drawing.Point(3, 550);
            this.bunifuButton23.Name = "bunifuButton23";
            this.bunifuButton23.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton23.OnDisabledState.BorderRadius = 5;
            this.bunifuButton23.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton23.OnDisabledState.BorderThickness = 1;
            this.bunifuButton23.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton23.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton23.OnDisabledState.IconLeftImage = null;
            this.bunifuButton23.OnDisabledState.IconRightImage = null;
            this.bunifuButton23.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton23.onHoverState.BorderRadius = 5;
            this.bunifuButton23.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton23.onHoverState.BorderThickness = 1;
            this.bunifuButton23.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton23.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton23.onHoverState.IconLeftImage = null;
            this.bunifuButton23.onHoverState.IconRightImage = null;
            this.bunifuButton23.OnIdleState.BorderColor = System.Drawing.Color.DarkRed;
            this.bunifuButton23.OnIdleState.BorderRadius = 5;
            this.bunifuButton23.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton23.OnIdleState.BorderThickness = 1;
            this.bunifuButton23.OnIdleState.FillColor = System.Drawing.Color.DarkRed;
            this.bunifuButton23.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton23.OnIdleState.IconLeftImage = null;
            this.bunifuButton23.OnIdleState.IconRightImage = null;
            this.bunifuButton23.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton23.OnPressedState.BorderRadius = 5;
            this.bunifuButton23.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton23.OnPressedState.BorderThickness = 1;
            this.bunifuButton23.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton23.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton23.OnPressedState.IconLeftImage = null;
            this.bunifuButton23.OnPressedState.IconRightImage = null;
            this.bunifuButton23.Size = new System.Drawing.Size(164, 39);
            this.bunifuButton23.TabIndex = 4;
            this.bunifuButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton23.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton23.TextMarginLeft = 0;
            this.bunifuButton23.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton23.UseDefaultRadiusAndThickness = true;
            this.bunifuButton23.Click += new System.EventHandler(this.bunifuButton23_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuPictureBox1.Image = global::TAPTAGPOS.Properties.Resources.icons8_cash_receipt_1600__1_;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(39, 23);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(93, 93);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 3;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.bunifuDatePicker1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bunifuDatePicker2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmbSuppliers, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(898, 102);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(197, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "إلى";
            // 
            // bunifuDatePicker1
            // 
            this.bunifuDatePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuDatePicker1.BackColor = System.Drawing.Color.White;
            this.bunifuDatePicker1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuDatePicker1.BorderRadius = 1;
            this.bunifuDatePicker1.Color = System.Drawing.Color.Silver;
            this.bunifuDatePicker1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.bunifuDatePicker1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bunifuDatePicker1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker1.DisplayWeekNumbers = false;
            this.bunifuDatePicker1.DPHeight = 0;
            this.bunifuDatePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bunifuDatePicker1.FillDatePicker = false;
            this.bunifuDatePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDatePicker1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatePicker1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDatePicker1.Icon")));
            this.bunifuDatePicker1.IconColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bunifuDatePicker1.LeftTextMargin = 5;
            this.bunifuDatePicker1.Location = new System.Drawing.Point(3, 9);
            this.bunifuDatePicker1.MinimumSize = new System.Drawing.Size(4, 32);
            this.bunifuDatePicker1.Name = "bunifuDatePicker1";
            this.bunifuDatePicker1.Size = new System.Drawing.Size(188, 32);
            this.bunifuDatePicker1.TabIndex = 8;
            // 
            // bunifuDatePicker2
            // 
            this.bunifuDatePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuDatePicker2.BackColor = System.Drawing.Color.White;
            this.bunifuDatePicker2.BorderColor = System.Drawing.Color.Silver;
            this.bunifuDatePicker2.BorderRadius = 1;
            this.bunifuDatePicker2.Color = System.Drawing.Color.Silver;
            this.bunifuDatePicker2.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.bunifuDatePicker2.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bunifuDatePicker2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker2.DisplayWeekNumbers = false;
            this.bunifuDatePicker2.DPHeight = 0;
            this.bunifuDatePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bunifuDatePicker2.FillDatePicker = false;
            this.bunifuDatePicker2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDatePicker2.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatePicker2.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDatePicker2.Icon")));
            this.bunifuDatePicker2.IconColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker2.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bunifuDatePicker2.LeftTextMargin = 5;
            this.bunifuDatePicker2.Location = new System.Drawing.Point(3, 60);
            this.bunifuDatePicker2.MinimumSize = new System.Drawing.Size(4, 32);
            this.bunifuDatePicker2.Name = "bunifuDatePicker2";
            this.bunifuDatePicker2.Size = new System.Drawing.Size(188, 32);
            this.bunifuDatePicker2.TabIndex = 9;
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSuppliers.BackColor = System.Drawing.Color.Transparent;
            this.cmbSuppliers.BackgroundColor = System.Drawing.Color.White;
            this.cmbSuppliers.BorderColor = System.Drawing.Color.Silver;
            this.cmbSuppliers.BorderRadius = 1;
            this.cmbSuppliers.Color = System.Drawing.Color.Silver;
            this.tableLayoutPanel2.SetColumnSpan(this.cmbSuppliers, 3);
            this.cmbSuppliers.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbSuppliers.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbSuppliers.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbSuppliers.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbSuppliers.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbSuppliers.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbSuppliers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSuppliers.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuppliers.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbSuppliers.FillDropDown = true;
            this.cmbSuppliers.FillIndicator = false;
            this.cmbSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSuppliers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbSuppliers.ForeColor = System.Drawing.Color.Black;
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Icon = null;
            this.cmbSuppliers.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbSuppliers.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbSuppliers.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbSuppliers.IndicatorThickness = 2;
            this.cmbSuppliers.IsDropdownOpened = false;
            this.cmbSuppliers.ItemBackColor = System.Drawing.Color.White;
            this.cmbSuppliers.ItemBorderColor = System.Drawing.Color.White;
            this.cmbSuppliers.ItemForeColor = System.Drawing.Color.Black;
            this.cmbSuppliers.ItemHeight = 26;
            this.cmbSuppliers.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmbSuppliers.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbSuppliers.ItemTopMargin = 3;
            this.cmbSuppliers.Location = new System.Drawing.Point(431, 35);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.tableLayoutPanel2.SetRowSpan(this.cmbSuppliers, 2);
            this.cmbSuppliers.Size = new System.Drawing.Size(268, 32);
            this.cmbSuppliers.TabIndex = 11;
            this.cmbSuppliers.Text = null;
            this.cmbSuppliers.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbSuppliers.TextLeftMargin = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(705, 40);
            this.label2.Name = "label2";
            this.tableLayoutPanel2.SetRowSpan(this.label2, 2);
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "المزود";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(237, 40);
            this.label1.Name = "label1";
            this.tableLayoutPanel2.SetRowSpan(this.label1, 2);
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "الفترة الزمنية";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(197, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "من";
            // 
            // Btn_StockForm
            // 
            this.Btn_StockForm.AllowAnimations = true;
            this.Btn_StockForm.AllowMouseEffects = true;
            this.Btn_StockForm.AllowToggling = false;
            this.Btn_StockForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_StockForm.AnimationSpeed = 200;
            this.Btn_StockForm.AutoGenerateColors = false;
            this.Btn_StockForm.AutoRoundBorders = false;
            this.Btn_StockForm.AutoSizeLeftIcon = true;
            this.Btn_StockForm.AutoSizeRightIcon = true;
            this.Btn_StockForm.BackColor = System.Drawing.Color.Transparent;
            this.Btn_StockForm.BackColor1 = System.Drawing.Color.Transparent;
            this.Btn_StockForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_StockForm.BackgroundImage")));
            this.Btn_StockForm.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.Btn_StockForm.ButtonText = "المخزون";
            this.Btn_StockForm.ButtonTextMarginLeft = 0;
            this.Btn_StockForm.ColorContrastOnClick = 45;
            this.Btn_StockForm.ColorContrastOnHover = 45;
            this.Btn_StockForm.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.Btn_StockForm.CustomizableEdges = borderEdges3;
            this.Btn_StockForm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_StockForm.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Btn_StockForm.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Btn_StockForm.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Btn_StockForm.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.Btn_StockForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_StockForm.ForeColor = System.Drawing.Color.Chocolate;
            this.Btn_StockForm.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_StockForm.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Btn_StockForm.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Btn_StockForm.IconMarginLeft = 11;
            this.Btn_StockForm.IconPadding = 10;
            this.Btn_StockForm.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_StockForm.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Btn_StockForm.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Btn_StockForm.IconSize = 25;
            this.Btn_StockForm.IdleBorderColor = System.Drawing.Color.Chocolate;
            this.Btn_StockForm.IdleBorderRadius = 5;
            this.Btn_StockForm.IdleBorderThickness = 1;
            this.Btn_StockForm.IdleFillColor = System.Drawing.Color.Transparent;
            this.Btn_StockForm.IdleIconLeftImage = null;
            this.Btn_StockForm.IdleIconRightImage = null;
            this.Btn_StockForm.IndicateFocus = false;
            this.Btn_StockForm.Location = new System.Drawing.Point(3, 276);
            this.Btn_StockForm.Name = "Btn_StockForm";
            this.Btn_StockForm.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Btn_StockForm.OnDisabledState.BorderRadius = 5;
            this.Btn_StockForm.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.Btn_StockForm.OnDisabledState.BorderThickness = 1;
            this.Btn_StockForm.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Btn_StockForm.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Btn_StockForm.OnDisabledState.IconLeftImage = null;
            this.Btn_StockForm.OnDisabledState.IconRightImage = null;
            this.Btn_StockForm.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Btn_StockForm.onHoverState.BorderRadius = 5;
            this.Btn_StockForm.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.Btn_StockForm.onHoverState.BorderThickness = 1;
            this.Btn_StockForm.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Btn_StockForm.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Btn_StockForm.onHoverState.IconLeftImage = null;
            this.Btn_StockForm.onHoverState.IconRightImage = null;
            this.Btn_StockForm.OnIdleState.BorderColor = System.Drawing.Color.Chocolate;
            this.Btn_StockForm.OnIdleState.BorderRadius = 5;
            this.Btn_StockForm.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.Btn_StockForm.OnIdleState.BorderThickness = 1;
            this.Btn_StockForm.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.Btn_StockForm.OnIdleState.ForeColor = System.Drawing.Color.Chocolate;
            this.Btn_StockForm.OnIdleState.IconLeftImage = null;
            this.Btn_StockForm.OnIdleState.IconRightImage = null;
            this.Btn_StockForm.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Btn_StockForm.OnPressedState.BorderRadius = 5;
            this.Btn_StockForm.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.Btn_StockForm.OnPressedState.BorderThickness = 1;
            this.Btn_StockForm.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Btn_StockForm.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Btn_StockForm.OnPressedState.IconLeftImage = null;
            this.Btn_StockForm.OnPressedState.IconRightImage = null;
            this.Btn_StockForm.Size = new System.Drawing.Size(164, 39);
            this.Btn_StockForm.TabIndex = 2;
            this.Btn_StockForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_StockForm.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_StockForm.TextMarginLeft = 0;
            this.Btn_StockForm.TextPadding = new System.Windows.Forms.Padding(0);
            this.Btn_StockForm.UseDefaultRadiusAndThickness = true;
            // 
            // btn_AddArticlesForm
            // 
            this.btn_AddArticlesForm.AllowAnimations = true;
            this.btn_AddArticlesForm.AllowMouseEffects = true;
            this.btn_AddArticlesForm.AllowToggling = false;
            this.btn_AddArticlesForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddArticlesForm.AnimationSpeed = 200;
            this.btn_AddArticlesForm.AutoGenerateColors = false;
            this.btn_AddArticlesForm.AutoRoundBorders = false;
            this.btn_AddArticlesForm.AutoSizeLeftIcon = true;
            this.btn_AddArticlesForm.AutoSizeRightIcon = true;
            this.btn_AddArticlesForm.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddArticlesForm.BackColor1 = System.Drawing.Color.Transparent;
            this.btn_AddArticlesForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AddArticlesForm.BackgroundImage")));
            this.btn_AddArticlesForm.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_AddArticlesForm.ButtonText = "فاتورة جديدة";
            this.btn_AddArticlesForm.ButtonTextMarginLeft = 0;
            this.btn_AddArticlesForm.ColorContrastOnClick = 45;
            this.btn_AddArticlesForm.ColorContrastOnHover = 45;
            this.btn_AddArticlesForm.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btn_AddArticlesForm.CustomizableEdges = borderEdges4;
            this.btn_AddArticlesForm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_AddArticlesForm.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_AddArticlesForm.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_AddArticlesForm.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_AddArticlesForm.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn_AddArticlesForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddArticlesForm.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_AddArticlesForm.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddArticlesForm.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_AddArticlesForm.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_AddArticlesForm.IconMarginLeft = 11;
            this.btn_AddArticlesForm.IconPadding = 10;
            this.btn_AddArticlesForm.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddArticlesForm.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_AddArticlesForm.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_AddArticlesForm.IconSize = 25;
            this.btn_AddArticlesForm.IdleBorderColor = System.Drawing.Color.ForestGreen;
            this.btn_AddArticlesForm.IdleBorderRadius = 5;
            this.btn_AddArticlesForm.IdleBorderThickness = 1;
            this.btn_AddArticlesForm.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_AddArticlesForm.IdleIconLeftImage = null;
            this.btn_AddArticlesForm.IdleIconRightImage = null;
            this.btn_AddArticlesForm.IndicateFocus = false;
            this.btn_AddArticlesForm.Location = new System.Drawing.Point(3, 141);
            this.btn_AddArticlesForm.Name = "btn_AddArticlesForm";
            this.btn_AddArticlesForm.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_AddArticlesForm.OnDisabledState.BorderRadius = 5;
            this.btn_AddArticlesForm.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_AddArticlesForm.OnDisabledState.BorderThickness = 1;
            this.btn_AddArticlesForm.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_AddArticlesForm.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_AddArticlesForm.OnDisabledState.IconLeftImage = null;
            this.btn_AddArticlesForm.OnDisabledState.IconRightImage = null;
            this.btn_AddArticlesForm.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_AddArticlesForm.onHoverState.BorderRadius = 5;
            this.btn_AddArticlesForm.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_AddArticlesForm.onHoverState.BorderThickness = 1;
            this.btn_AddArticlesForm.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_AddArticlesForm.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_AddArticlesForm.onHoverState.IconLeftImage = null;
            this.btn_AddArticlesForm.onHoverState.IconRightImage = null;
            this.btn_AddArticlesForm.OnIdleState.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_AddArticlesForm.OnIdleState.BorderRadius = 5;
            this.btn_AddArticlesForm.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_AddArticlesForm.OnIdleState.BorderThickness = 1;
            this.btn_AddArticlesForm.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btn_AddArticlesForm.OnIdleState.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_AddArticlesForm.OnIdleState.IconLeftImage = null;
            this.btn_AddArticlesForm.OnIdleState.IconRightImage = null;
            this.btn_AddArticlesForm.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_AddArticlesForm.OnPressedState.BorderRadius = 5;
            this.btn_AddArticlesForm.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_AddArticlesForm.OnPressedState.BorderThickness = 1;
            this.btn_AddArticlesForm.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_AddArticlesForm.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_AddArticlesForm.OnPressedState.IconLeftImage = null;
            this.btn_AddArticlesForm.OnPressedState.IconRightImage = null;
            this.btn_AddArticlesForm.Size = new System.Drawing.Size(164, 39);
            this.btn_AddArticlesForm.TabIndex = 0;
            this.btn_AddArticlesForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AddArticlesForm.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_AddArticlesForm.TextMarginLeft = 0;
            this.btn_AddArticlesForm.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_AddArticlesForm.UseDefaultRadiusAndThickness = true;
            this.btn_AddArticlesForm.Click += new System.EventHandler(this.btn_AddArticlesForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.btnPrintA4);
            this.panel1.Controls.Add(this.btnEditPurchase);
            this.panel1.Controls.Add(this.bunifuButton23);
            this.panel1.Controls.Add(this.bunifuPictureBox1);
            this.panel1.Controls.Add(this.Btn_StockForm);
            this.panel1.Controls.Add(this.btndeleteFacture);
            this.panel1.Controls.Add(this.btn_AddArticlesForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(898, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 598);
            this.panel1.TabIndex = 7;
            // 
            // btnPrintA4
            // 
            this.btnPrintA4.AllowAnimations = true;
            this.btnPrintA4.AllowMouseEffects = true;
            this.btnPrintA4.AllowToggling = false;
            this.btnPrintA4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintA4.AnimationSpeed = 200;
            this.btnPrintA4.AutoGenerateColors = false;
            this.btnPrintA4.AutoRoundBorders = false;
            this.btnPrintA4.AutoSizeLeftIcon = true;
            this.btnPrintA4.AutoSizeRightIcon = true;
            this.btnPrintA4.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintA4.BackColor1 = System.Drawing.Color.Transparent;
            this.btnPrintA4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrintA4.BackgroundImage")));
            this.btnPrintA4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnPrintA4.ButtonText = "Print";
            this.btnPrintA4.ButtonTextMarginLeft = 0;
            this.btnPrintA4.ColorContrastOnClick = 45;
            this.btnPrintA4.ColorContrastOnHover = 45;
            this.btnPrintA4.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnPrintA4.CustomizableEdges = borderEdges5;
            this.btnPrintA4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrintA4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPrintA4.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPrintA4.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPrintA4.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnPrintA4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintA4.ForeColor = System.Drawing.Color.Red;
            this.btnPrintA4.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintA4.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPrintA4.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPrintA4.IconMarginLeft = 11;
            this.btnPrintA4.IconPadding = 10;
            this.btnPrintA4.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintA4.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPrintA4.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPrintA4.IconSize = 25;
            this.btnPrintA4.IdleBorderColor = System.Drawing.Color.Red;
            this.btnPrintA4.IdleBorderRadius = 5;
            this.btnPrintA4.IdleBorderThickness = 1;
            this.btnPrintA4.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnPrintA4.IdleIconLeftImage = null;
            this.btnPrintA4.IdleIconRightImage = null;
            this.btnPrintA4.IndicateFocus = false;
            this.btnPrintA4.Location = new System.Drawing.Point(3, 321);
            this.btnPrintA4.Name = "btnPrintA4";
            this.btnPrintA4.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPrintA4.OnDisabledState.BorderRadius = 5;
            this.btnPrintA4.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnPrintA4.OnDisabledState.BorderThickness = 1;
            this.btnPrintA4.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPrintA4.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPrintA4.OnDisabledState.IconLeftImage = null;
            this.btnPrintA4.OnDisabledState.IconRightImage = null;
            this.btnPrintA4.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPrintA4.onHoverState.BorderRadius = 5;
            this.btnPrintA4.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnPrintA4.onHoverState.BorderThickness = 1;
            this.btnPrintA4.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPrintA4.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPrintA4.onHoverState.IconLeftImage = null;
            this.btnPrintA4.onHoverState.IconRightImage = null;
            this.btnPrintA4.OnIdleState.BorderColor = System.Drawing.Color.Red;
            this.btnPrintA4.OnIdleState.BorderRadius = 5;
            this.btnPrintA4.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnPrintA4.OnIdleState.BorderThickness = 1;
            this.btnPrintA4.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnPrintA4.OnIdleState.ForeColor = System.Drawing.Color.Red;
            this.btnPrintA4.OnIdleState.IconLeftImage = null;
            this.btnPrintA4.OnIdleState.IconRightImage = null;
            this.btnPrintA4.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPrintA4.OnPressedState.BorderRadius = 5;
            this.btnPrintA4.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnPrintA4.OnPressedState.BorderThickness = 1;
            this.btnPrintA4.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPrintA4.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPrintA4.OnPressedState.IconLeftImage = null;
            this.btnPrintA4.OnPressedState.IconRightImage = null;
            this.btnPrintA4.Size = new System.Drawing.Size(164, 39);
            this.btnPrintA4.TabIndex = 6;
            this.btnPrintA4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrintA4.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrintA4.TextMarginLeft = 0;
            this.btnPrintA4.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPrintA4.UseDefaultRadiusAndThickness = true;
            this.btnPrintA4.Click += new System.EventHandler(this.btnPrintA4_Click);
            // 
            // btndeleteFacture
            // 
            this.btndeleteFacture.AllowAnimations = true;
            this.btndeleteFacture.AllowMouseEffects = true;
            this.btndeleteFacture.AllowToggling = false;
            this.btndeleteFacture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btndeleteFacture.AnimationSpeed = 200;
            this.btndeleteFacture.AutoGenerateColors = false;
            this.btndeleteFacture.AutoRoundBorders = false;
            this.btndeleteFacture.AutoSizeLeftIcon = true;
            this.btndeleteFacture.AutoSizeRightIcon = true;
            this.btndeleteFacture.BackColor = System.Drawing.Color.Transparent;
            this.btndeleteFacture.BackColor1 = System.Drawing.Color.Transparent;
            this.btndeleteFacture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndeleteFacture.BackgroundImage")));
            this.btndeleteFacture.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btndeleteFacture.ButtonText = "حذف الفاتورة";
            this.btndeleteFacture.ButtonTextMarginLeft = 0;
            this.btndeleteFacture.ColorContrastOnClick = 45;
            this.btndeleteFacture.ColorContrastOnHover = 45;
            this.btndeleteFacture.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btndeleteFacture.CustomizableEdges = borderEdges6;
            this.btndeleteFacture.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btndeleteFacture.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btndeleteFacture.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btndeleteFacture.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btndeleteFacture.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btndeleteFacture.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteFacture.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btndeleteFacture.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndeleteFacture.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btndeleteFacture.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btndeleteFacture.IconMarginLeft = 11;
            this.btndeleteFacture.IconPadding = 10;
            this.btndeleteFacture.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndeleteFacture.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btndeleteFacture.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btndeleteFacture.IconSize = 25;
            this.btndeleteFacture.IdleBorderColor = System.Drawing.Color.Navy;
            this.btndeleteFacture.IdleBorderRadius = 5;
            this.btndeleteFacture.IdleBorderThickness = 1;
            this.btndeleteFacture.IdleFillColor = System.Drawing.Color.Transparent;
            this.btndeleteFacture.IdleIconLeftImage = null;
            this.btndeleteFacture.IdleIconRightImage = null;
            this.btndeleteFacture.IndicateFocus = false;
            this.btndeleteFacture.Location = new System.Drawing.Point(3, 231);
            this.btndeleteFacture.Name = "btndeleteFacture";
            this.btndeleteFacture.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btndeleteFacture.OnDisabledState.BorderRadius = 5;
            this.btndeleteFacture.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btndeleteFacture.OnDisabledState.BorderThickness = 1;
            this.btndeleteFacture.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btndeleteFacture.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btndeleteFacture.OnDisabledState.IconLeftImage = null;
            this.btndeleteFacture.OnDisabledState.IconRightImage = null;
            this.btndeleteFacture.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btndeleteFacture.onHoverState.BorderRadius = 5;
            this.btndeleteFacture.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btndeleteFacture.onHoverState.BorderThickness = 1;
            this.btndeleteFacture.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btndeleteFacture.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btndeleteFacture.onHoverState.IconLeftImage = null;
            this.btndeleteFacture.onHoverState.IconRightImage = null;
            this.btndeleteFacture.OnIdleState.BorderColor = System.Drawing.Color.Navy;
            this.btndeleteFacture.OnIdleState.BorderRadius = 5;
            this.btndeleteFacture.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btndeleteFacture.OnIdleState.BorderThickness = 1;
            this.btndeleteFacture.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btndeleteFacture.OnIdleState.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btndeleteFacture.OnIdleState.IconLeftImage = null;
            this.btndeleteFacture.OnIdleState.IconRightImage = null;
            this.btndeleteFacture.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btndeleteFacture.OnPressedState.BorderRadius = 5;
            this.btndeleteFacture.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btndeleteFacture.OnPressedState.BorderThickness = 1;
            this.btndeleteFacture.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btndeleteFacture.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btndeleteFacture.OnPressedState.IconLeftImage = null;
            this.btndeleteFacture.OnPressedState.IconRightImage = null;
            this.btndeleteFacture.Size = new System.Drawing.Size(164, 39);
            this.btndeleteFacture.TabIndex = 1;
            this.btndeleteFacture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndeleteFacture.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btndeleteFacture.TextMarginLeft = 0;
            this.btndeleteFacture.TextPadding = new System.Windows.Forms.Padding(0);
            this.btndeleteFacture.UseDefaultRadiusAndThickness = true;
            this.btndeleteFacture.Click += new System.EventHandler(this.btndeleteFacture_Click);
            // 
            // ListeTicketPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 598);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ListeTicketPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListeTicketPurchase";
            this.Load += new System.EventHandler(this.ListeTicketPurchase_Load);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnEditPurchase;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton23;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 Btn_StockForm;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_AddArticlesForm;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btndeleteFacture;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewFactures;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker1;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDropdown cmbSuppliers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grandtotal;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnPrintA4;
    }
}