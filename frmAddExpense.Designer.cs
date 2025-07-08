using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;

namespace TAPTAGPOS
{
    partial class frmAddExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddExpense));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpExpenseDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpenseType = new System.Windows.Forms.Label();
            this.cmbExpenseType = new System.Windows.Forms.ComboBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnConfirm = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.txtAmount = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtDetails = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnAddType = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(440, 43);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 18);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "التاريخ";
            // 
            // dtpExpenseDate
            // 
            this.dtpExpenseDate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpenseDate.Location = new System.Drawing.Point(40, 40);
            this.dtpExpenseDate.Name = "dtpExpenseDate";
            this.dtpExpenseDate.RightToLeftLayout = true;
            this.dtpExpenseDate.Size = new System.Drawing.Size(380, 26);
            this.dtpExpenseDate.TabIndex = 1;
            // 
            // lblExpenseType
            // 
            this.lblExpenseType.AutoSize = true;
            this.lblExpenseType.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseType.Location = new System.Drawing.Point(440, 88);
            this.lblExpenseType.Name = "lblExpenseType";
            this.lblExpenseType.Size = new System.Drawing.Size(100, 18);
            this.lblExpenseType.TabIndex = 2;
            this.lblExpenseType.Text = "نوع المصروف";
            // 
            // cmbExpenseType
            // 
            this.cmbExpenseType.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpenseType.FormattingEnabled = true;
            this.cmbExpenseType.Location = new System.Drawing.Point(90, 85);
            this.cmbExpenseType.Name = "cmbExpenseType";
            this.cmbExpenseType.Size = new System.Drawing.Size(330, 26);
            this.cmbExpenseType.TabIndex = 2;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(440, 133);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(69, 18);
            this.lblDetails.TabIndex = 5;
            this.lblDetails.Text = "التفاصيل";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(440, 178);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(49, 18);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "المبلغ";
            // 
            // btnCancel
            // 
            this.btnCancel.AllowAnimations = true;
            this.btnCancel.AllowMouseEffects = true;
            this.btnCancel.AllowToggling = false;
            this.btnCancel.AnimationSpeed = 200;
            this.btnCancel.AutoGenerateColors = false;
            this.btnCancel.AutoRoundBorders = false;
            this.btnCancel.AutoSizeLeftIcon = true;
            this.btnCancel.AutoSizeRightIcon = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackColor1 = System.Drawing.Color.Red;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancel.ButtonText = "إلغاء ❌";
            this.btnCancel.ButtonTextMarginLeft = 0;
            this.btnCancel.ColorContrastOnClick = 45;
            this.btnCancel.ColorContrastOnHover = 45;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCancel.CustomizableEdges = borderEdges1;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCancel.IconMarginLeft = 11;
            this.btnCancel.IconPadding = 10;
            this.btnCancel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCancel.IconSize = 25;
            this.btnCancel.IdleBorderColor = System.Drawing.Color.Red;
            this.btnCancel.IdleBorderRadius = 10;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleFillColor = System.Drawing.Color.Red;
            this.btnCancel.IdleIconLeftImage = null;
            this.btnCancel.IdleIconRightImage = null;
            this.btnCancel.IndicateFocus = false;
            this.btnCancel.Location = new System.Drawing.Point(120, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancel.OnDisabledState.BorderRadius = 10;
            this.btnCancel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancel.OnDisabledState.BorderThickness = 1;
            this.btnCancel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancel.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancel.OnDisabledState.IconLeftImage = null;
            this.btnCancel.OnDisabledState.IconRightImage = null;
            this.btnCancel.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCancel.onHoverState.BorderRadius = 10;
            this.btnCancel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancel.onHoverState.BorderThickness = 1;
            this.btnCancel.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCancel.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.onHoverState.IconLeftImage = null;
            this.btnCancel.onHoverState.IconRightImage = null;
            this.btnCancel.OnIdleState.BorderColor = System.Drawing.Color.Red;
            this.btnCancel.OnIdleState.BorderRadius = 10;
            this.btnCancel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancel.OnIdleState.BorderThickness = 1;
            this.btnCancel.OnIdleState.FillColor = System.Drawing.Color.Red;
            this.btnCancel.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.OnIdleState.IconLeftImage = null;
            this.btnCancel.OnIdleState.IconRightImage = null;
            this.btnCancel.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancel.OnPressedState.BorderRadius = 10;
            this.btnCancel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancel.OnPressedState.BorderThickness = 1;
            this.btnCancel.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancel.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.OnPressedState.IconLeftImage = null;
            this.btnCancel.OnPressedState.IconRightImage = null;
            this.btnCancel.Size = new System.Drawing.Size(140, 45);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.TextMarginLeft = 0;
            this.btnCancel.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCancel.UseDefaultRadiusAndThickness = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.AllowAnimations = true;
            this.btnConfirm.AllowMouseEffects = true;
            this.btnConfirm.AllowToggling = false;
            this.btnConfirm.AnimationSpeed = 200;
            this.btnConfirm.AutoGenerateColors = false;
            this.btnConfirm.AutoRoundBorders = false;
            this.btnConfirm.AutoSizeLeftIcon = true;
            this.btnConfirm.AutoSizeRightIcon = true;
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BackColor1 = System.Drawing.Color.Green;
            this.btnConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirm.BackgroundImage")));
            this.btnConfirm.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnConfirm.ButtonText = "تأكيد ✔️";
            this.btnConfirm.ButtonTextMarginLeft = 0;
            this.btnConfirm.ColorContrastOnClick = 45;
            this.btnConfirm.ColorContrastOnHover = 45;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnConfirm.CustomizableEdges = borderEdges2;
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirm.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConfirm.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfirm.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnConfirm.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnConfirm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirm.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnConfirm.IconMarginLeft = 11;
            this.btnConfirm.IconPadding = 10;
            this.btnConfirm.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirm.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirm.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnConfirm.IconSize = 25;
            this.btnConfirm.IdleBorderColor = System.Drawing.Color.Green;
            this.btnConfirm.IdleBorderRadius = 10;
            this.btnConfirm.IdleBorderThickness = 1;
            this.btnConfirm.IdleFillColor = System.Drawing.Color.Green;
            this.btnConfirm.IdleIconLeftImage = null;
            this.btnConfirm.IdleIconRightImage = null;
            this.btnConfirm.IndicateFocus = false;
            this.btnConfirm.Location = new System.Drawing.Point(280, 230);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConfirm.OnDisabledState.BorderRadius = 10;
            this.btnConfirm.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnConfirm.OnDisabledState.BorderThickness = 1;
            this.btnConfirm.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfirm.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnConfirm.OnDisabledState.IconLeftImage = null;
            this.btnConfirm.OnDisabledState.IconRightImage = null;
            this.btnConfirm.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnConfirm.onHoverState.BorderRadius = 10;
            this.btnConfirm.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnConfirm.onHoverState.BorderThickness = 1;
            this.btnConfirm.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnConfirm.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.onHoverState.IconLeftImage = null;
            this.btnConfirm.onHoverState.IconRightImage = null;
            this.btnConfirm.OnIdleState.BorderColor = System.Drawing.Color.Green;
            this.btnConfirm.OnIdleState.BorderRadius = 10;
            this.btnConfirm.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnConfirm.OnIdleState.BorderThickness = 1;
            this.btnConfirm.OnIdleState.FillColor = System.Drawing.Color.Green;
            this.btnConfirm.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.OnIdleState.IconLeftImage = null;
            this.btnConfirm.OnIdleState.IconRightImage = null;
            this.btnConfirm.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConfirm.OnPressedState.BorderRadius = 10;
            this.btnConfirm.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnConfirm.OnPressedState.BorderThickness = 1;
            this.btnConfirm.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConfirm.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.OnPressedState.IconLeftImage = null;
            this.btnConfirm.OnPressedState.IconRightImage = null;
            this.btnConfirm.Size = new System.Drawing.Size(140, 45);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirm.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfirm.TextMarginLeft = 0;
            this.btnConfirm.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnConfirm.UseDefaultRadiusAndThickness = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.AcceptsReturn = false;
            this.txtAmount.AcceptsTab = false;
            this.txtAmount.AnimationSpeed = 200;
            this.txtAmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAmount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAmount.AutoSizeHeight = true;
            this.txtAmount.BackColor = System.Drawing.Color.Transparent;
            this.txtAmount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAmount.BackgroundImage")));
            this.txtAmount.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtAmount.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtAmount.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtAmount.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtAmount.BorderRadius = 1;
            this.txtAmount.BorderThickness = 1;
            this.txtAmount.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.DefaultText = "";
            this.txtAmount.FillColor = System.Drawing.Color.White;
            this.txtAmount.HideSelection = true;
            this.txtAmount.IconLeft = null;
            this.txtAmount.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.IconPadding = 10;
            this.txtAmount.IconRight = null;
            this.txtAmount.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.Lines = new string[0];
            this.txtAmount.Location = new System.Drawing.Point(40, 175);
            this.txtAmount.MaxLength = 32767;
            this.txtAmount.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtAmount.Modified = false;
            this.txtAmount.Multiline = false;
            this.txtAmount.Name = "txtAmount";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAmount.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtAmount.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAmount.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAmount.OnIdleState = stateProperties4;
            this.txtAmount.Padding = new System.Windows.Forms.Padding(3);
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAmount.PlaceholderText = "Enter text";
            this.txtAmount.ReadOnly = false;
            this.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.ShortcutsEnabled = true;
            this.txtAmount.Size = new System.Drawing.Size(380, 30);
            this.txtAmount.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtAmount.TabIndex = 5;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAmount.TextMarginBottom = 0;
            this.txtAmount.TextMarginLeft = 3;
            this.txtAmount.TextMarginTop = 1;
            this.txtAmount.TextPlaceholder = "Enter text";
            this.txtAmount.UseSystemPasswordChar = false;
            this.txtAmount.WordWrap = true;
            // 
            // txtDetails
            // 
            this.txtDetails.AcceptsReturn = false;
            this.txtDetails.AcceptsTab = false;
            this.txtDetails.AnimationSpeed = 200;
            this.txtDetails.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDetails.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDetails.AutoSizeHeight = true;
            this.txtDetails.BackColor = System.Drawing.Color.Transparent;
            this.txtDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtDetails.BackgroundImage")));
            this.txtDetails.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtDetails.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDetails.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtDetails.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtDetails.BorderRadius = 1;
            this.txtDetails.BorderThickness = 1;
            this.txtDetails.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtDetails.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDetails.DefaultFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.DefaultText = "";
            this.txtDetails.FillColor = System.Drawing.Color.White;
            this.txtDetails.HideSelection = true;
            this.txtDetails.IconLeft = null;
            this.txtDetails.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDetails.IconPadding = 10;
            this.txtDetails.IconRight = null;
            this.txtDetails.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDetails.Lines = new string[0];
            this.txtDetails.Location = new System.Drawing.Point(40, 130);
            this.txtDetails.MaxLength = 32767;
            this.txtDetails.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtDetails.Modified = false;
            this.txtDetails.Multiline = false;
            this.txtDetails.Name = "txtDetails";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDetails.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDetails.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDetails.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDetails.OnIdleState = stateProperties8;
            this.txtDetails.Padding = new System.Windows.Forms.Padding(3);
            this.txtDetails.PasswordChar = '\0';
            this.txtDetails.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDetails.PlaceholderText = "Enter text";
            this.txtDetails.ReadOnly = false;
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetails.SelectedText = "";
            this.txtDetails.SelectionLength = 0;
            this.txtDetails.SelectionStart = 0;
            this.txtDetails.ShortcutsEnabled = true;
            this.txtDetails.Size = new System.Drawing.Size(380, 30);
            this.txtDetails.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtDetails.TabIndex = 4;
            this.txtDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDetails.TextMarginBottom = 0;
            this.txtDetails.TextMarginLeft = 3;
            this.txtDetails.TextMarginTop = 1;
            this.txtDetails.TextPlaceholder = "Enter text";
            this.txtDetails.UseSystemPasswordChar = false;
            this.txtDetails.WordWrap = true;
            // 
            // btnAddType
            // 
            this.btnAddType.AllowAnimations = true;
            this.btnAddType.AllowMouseEffects = true;
            this.btnAddType.AllowToggling = false;
            this.btnAddType.AnimationSpeed = 200;
            this.btnAddType.AutoGenerateColors = false;
            this.btnAddType.AutoRoundBorders = false;
            this.btnAddType.AutoSizeLeftIcon = true;
            this.btnAddType.AutoSizeRightIcon = true;
            this.btnAddType.BackColor = System.Drawing.Color.Transparent;
            this.btnAddType.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnAddType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddType.BackgroundImage")));
            this.btnAddType.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAddType.ButtonText = "+";
            this.btnAddType.ButtonTextMarginLeft = 0;
            this.btnAddType.ColorContrastOnClick = 45;
            this.btnAddType.ColorContrastOnHover = 45;
            this.btnAddType.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnAddType.CustomizableEdges = borderEdges3;
            this.btnAddType.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddType.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddType.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddType.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddType.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnAddType.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddType.ForeColor = System.Drawing.Color.White;
            this.btnAddType.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddType.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddType.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddType.IconMarginLeft = 11;
            this.btnAddType.IconPadding = 10;
            this.btnAddType.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddType.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddType.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddType.IconSize = 25;
            this.btnAddType.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddType.IdleBorderRadius = 8;
            this.btnAddType.IdleBorderThickness = 1;
            this.btnAddType.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddType.IdleIconLeftImage = null;
            this.btnAddType.IdleIconRightImage = null;
            this.btnAddType.IndicateFocus = false;
            this.btnAddType.Location = new System.Drawing.Point(40, 84);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddType.OnDisabledState.BorderRadius = 8;
            this.btnAddType.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAddType.OnDisabledState.BorderThickness = 1;
            this.btnAddType.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddType.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddType.OnDisabledState.IconLeftImage = null;
            this.btnAddType.OnDisabledState.IconRightImage = null;
            this.btnAddType.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddType.onHoverState.BorderRadius = 8;
            this.btnAddType.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAddType.onHoverState.BorderThickness = 1;
            this.btnAddType.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddType.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddType.onHoverState.IconLeftImage = null;
            this.btnAddType.onHoverState.IconRightImage = null;
            this.btnAddType.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddType.OnIdleState.BorderRadius = 8;
            this.btnAddType.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAddType.OnIdleState.BorderThickness = 1;
            this.btnAddType.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddType.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddType.OnIdleState.IconLeftImage = null;
            this.btnAddType.OnIdleState.IconRightImage = null;
            this.btnAddType.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddType.OnPressedState.BorderRadius = 8;
            this.btnAddType.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAddType.OnPressedState.BorderThickness = 1;
            this.btnAddType.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddType.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddType.OnPressedState.IconLeftImage = null;
            this.btnAddType.OnPressedState.IconRightImage = null;
            this.btnAddType.Size = new System.Drawing.Size(40, 28);
            this.btnAddType.TabIndex = 3;
            this.btnAddType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddType.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddType.TextMarginLeft = 0;
            this.btnAddType.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddType.UseDefaultRadiusAndThickness = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // frmAddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(564, 301);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.btnAddType);
            this.Controls.Add(this.cmbExpenseType);
            this.Controls.Add(this.lblExpenseType);
            this.Controls.Add(this.dtpExpenseDate);
            this.Controls.Add(this.lblDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddExpense";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "المصروف";
            this.Load += new System.EventHandler(this.frmAddExpense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion



        private System.Windows.Forms.Label lblDate;

        private System.Windows.Forms.DateTimePicker dtpExpenseDate;

        private System.Windows.Forms.Label lblExpenseType;

        private System.Windows.Forms.ComboBox cmbExpenseType;

        private BunifuButton2 btnAddType;

        private System.Windows.Forms.Label lblDetails;

        private BunifuTextBox txtDetails;

        private System.Windows.Forms.Label lblAmount;

        private BunifuTextBox txtAmount;

        private BunifuButton2 btnConfirm;

        private BunifuButton2 btnCancel;
    }
}