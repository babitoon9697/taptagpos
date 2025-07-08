using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;

namespace TAPTAGPOS // <-- IMPORTANT: Change this to your project's actual namespace
{
    partial class ClientSituationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientSituationForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonPrint = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.buttonCalendar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.buttonConfirm = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.buttonPeriod = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.labelTo = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.labelFrom = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.buttonSelectClient = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.textBoxCurrentDebt = new Bunifu.UI.WinForms.BunifuTextBox();
            this.labelCurrentDebt = new System.Windows.Forms.Label();
            this.dataGridViewSituation = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSituation)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.tableLayoutPanel1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(917, 65);
            this.panelTop.TabIndex = 0;
            // 
            // buttonPrint
            // 
            this.buttonPrint.AllowAnimations = true;
            this.buttonPrint.AllowMouseEffects = true;
            this.buttonPrint.AllowToggling = false;
            this.buttonPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrint.AnimationSpeed = 200;
            this.buttonPrint.AutoGenerateColors = false;
            this.buttonPrint.AutoRoundBorders = false;
            this.buttonPrint.AutoSizeLeftIcon = true;
            this.buttonPrint.AutoSizeRightIcon = true;
            this.buttonPrint.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrint.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.buttonPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPrint.BackgroundImage")));
            this.buttonPrint.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonPrint.ButtonText = "طباعة";
            this.buttonPrint.ButtonTextMarginLeft = 0;
            this.buttonPrint.ColorContrastOnClick = 45;
            this.buttonPrint.ColorContrastOnHover = 45;
            this.buttonPrint.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.buttonPrint.CustomizableEdges = borderEdges1;
            this.buttonPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonPrint.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonPrint.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonPrint.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonPrint.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.buttonPrint.Font = new System.Drawing.Font("Tahoma", 9F);
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrint.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonPrint.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonPrint.IconMarginLeft = 11;
            this.buttonPrint.IconPadding = 10;
            this.buttonPrint.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPrint.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonPrint.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonPrint.IconSize = 25;
            this.buttonPrint.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonPrint.IdleBorderRadius = 1;
            this.buttonPrint.IdleBorderThickness = 1;
            this.buttonPrint.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.buttonPrint.IdleIconLeftImage = null;
            this.buttonPrint.IdleIconRightImage = null;
            this.buttonPrint.IndicateFocus = false;
            this.buttonPrint.Location = new System.Drawing.Point(38, 14);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonPrint.OnDisabledState.BorderRadius = 1;
            this.buttonPrint.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonPrint.OnDisabledState.BorderThickness = 1;
            this.buttonPrint.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonPrint.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonPrint.OnDisabledState.IconLeftImage = null;
            this.buttonPrint.OnDisabledState.IconRightImage = null;
            this.buttonPrint.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonPrint.onHoverState.BorderRadius = 1;
            this.buttonPrint.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonPrint.onHoverState.BorderThickness = 1;
            this.buttonPrint.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonPrint.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.onHoverState.IconLeftImage = null;
            this.buttonPrint.onHoverState.IconRightImage = null;
            this.buttonPrint.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonPrint.OnIdleState.BorderRadius = 1;
            this.buttonPrint.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonPrint.OnIdleState.BorderThickness = 1;
            this.buttonPrint.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.buttonPrint.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.OnIdleState.IconLeftImage = null;
            this.buttonPrint.OnIdleState.IconRightImage = null;
            this.buttonPrint.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonPrint.OnPressedState.BorderRadius = 1;
            this.buttonPrint.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonPrint.OnPressedState.BorderThickness = 1;
            this.buttonPrint.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonPrint.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.OnPressedState.IconLeftImage = null;
            this.buttonPrint.OnPressedState.IconRightImage = null;
            this.tableLayoutPanel1.SetRowSpan(this.buttonPrint, 2);
            this.buttonPrint.Size = new System.Drawing.Size(75, 32);
            this.buttonPrint.TabIndex = 10;
            this.buttonPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonPrint.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonPrint.TextMarginLeft = 0;
            this.buttonPrint.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonPrint.UseDefaultRadiusAndThickness = true;
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.AllowAnimations = true;
            this.buttonCalendar.AllowMouseEffects = true;
            this.buttonCalendar.AllowToggling = false;
            this.buttonCalendar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCalendar.AnimationSpeed = 200;
            this.buttonCalendar.AutoGenerateColors = false;
            this.buttonCalendar.AutoRoundBorders = false;
            this.buttonCalendar.AutoSizeLeftIcon = true;
            this.buttonCalendar.AutoSizeRightIcon = true;
            this.buttonCalendar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCalendar.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.buttonCalendar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCalendar.BackgroundImage")));
            this.buttonCalendar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonCalendar.ButtonText = "Bunifu Button";
            this.buttonCalendar.ButtonTextMarginLeft = 0;
            this.buttonCalendar.ColorContrastOnClick = 45;
            this.buttonCalendar.ColorContrastOnHover = 45;
            this.buttonCalendar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.buttonCalendar.CustomizableEdges = borderEdges5;
            this.buttonCalendar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonCalendar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonCalendar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonCalendar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonCalendar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.buttonCalendar.Font = new System.Drawing.Font("Tahoma", 9F);
            this.buttonCalendar.ForeColor = System.Drawing.Color.White;
            this.buttonCalendar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCalendar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonCalendar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonCalendar.IconMarginLeft = 11;
            this.buttonCalendar.IconPadding = 10;
            this.buttonCalendar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCalendar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonCalendar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonCalendar.IconSize = 25;
            this.buttonCalendar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonCalendar.IdleBorderRadius = 1;
            this.buttonCalendar.IdleBorderThickness = 1;
            this.buttonCalendar.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.buttonCalendar.IdleIconLeftImage = null;
            this.buttonCalendar.IdleIconRightImage = null;
            this.buttonCalendar.IndicateFocus = false;
            this.buttonCalendar.Location = new System.Drawing.Point(159, 14);
            this.buttonCalendar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonCalendar.OnDisabledState.BorderRadius = 1;
            this.buttonCalendar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonCalendar.OnDisabledState.BorderThickness = 1;
            this.buttonCalendar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonCalendar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonCalendar.OnDisabledState.IconLeftImage = null;
            this.buttonCalendar.OnDisabledState.IconRightImage = null;
            this.buttonCalendar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonCalendar.onHoverState.BorderRadius = 1;
            this.buttonCalendar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonCalendar.onHoverState.BorderThickness = 1;
            this.buttonCalendar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonCalendar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonCalendar.onHoverState.IconLeftImage = null;
            this.buttonCalendar.onHoverState.IconRightImage = null;
            this.buttonCalendar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonCalendar.OnIdleState.BorderRadius = 1;
            this.buttonCalendar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonCalendar.OnIdleState.BorderThickness = 1;
            this.buttonCalendar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.buttonCalendar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonCalendar.OnIdleState.IconLeftImage = null;
            this.buttonCalendar.OnIdleState.IconRightImage = null;
            this.buttonCalendar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonCalendar.OnPressedState.BorderRadius = 1;
            this.buttonCalendar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonCalendar.OnPressedState.BorderThickness = 1;
            this.buttonCalendar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonCalendar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonCalendar.OnPressedState.IconLeftImage = null;
            this.buttonCalendar.OnPressedState.IconRightImage = null;
            this.tableLayoutPanel1.SetRowSpan(this.buttonCalendar, 2);
            this.buttonCalendar.Size = new System.Drawing.Size(44, 32);
            this.buttonCalendar.TabIndex = 9;
            this.buttonCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonCalendar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonCalendar.TextMarginLeft = 0;
            this.buttonCalendar.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonCalendar.UseDefaultRadiusAndThickness = true;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.AllowAnimations = true;
            this.buttonConfirm.AllowMouseEffects = true;
            this.buttonConfirm.AllowToggling = false;
            this.buttonConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConfirm.AnimationSpeed = 200;
            this.buttonConfirm.AutoGenerateColors = false;
            this.buttonConfirm.AutoRoundBorders = false;
            this.buttonConfirm.AutoSizeLeftIcon = true;
            this.buttonConfirm.AutoSizeRightIcon = true;
            this.buttonConfirm.BackColor = System.Drawing.Color.Transparent;
            this.buttonConfirm.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.buttonConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConfirm.BackgroundImage")));
            this.buttonConfirm.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonConfirm.ButtonText = "تأكيد";
            this.buttonConfirm.ButtonTextMarginLeft = 0;
            this.buttonConfirm.ColorContrastOnClick = 45;
            this.buttonConfirm.ColorContrastOnHover = 45;
            this.buttonConfirm.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.buttonConfirm.CustomizableEdges = borderEdges3;
            this.buttonConfirm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonConfirm.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonConfirm.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonConfirm.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonConfirm.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.buttonConfirm.Font = new System.Drawing.Font("Tahoma", 9F);
            this.buttonConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonConfirm.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfirm.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonConfirm.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonConfirm.IconMarginLeft = 11;
            this.buttonConfirm.IconPadding = 10;
            this.buttonConfirm.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfirm.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonConfirm.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonConfirm.IconSize = 25;
            this.buttonConfirm.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonConfirm.IdleBorderRadius = 1;
            this.buttonConfirm.IdleBorderThickness = 1;
            this.buttonConfirm.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.buttonConfirm.IdleIconLeftImage = null;
            this.buttonConfirm.IdleIconRightImage = null;
            this.buttonConfirm.IndicateFocus = false;
            this.buttonConfirm.Location = new System.Drawing.Point(223, 14);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonConfirm.OnDisabledState.BorderRadius = 1;
            this.buttonConfirm.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonConfirm.OnDisabledState.BorderThickness = 1;
            this.buttonConfirm.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonConfirm.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonConfirm.OnDisabledState.IconLeftImage = null;
            this.buttonConfirm.OnDisabledState.IconRightImage = null;
            this.buttonConfirm.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonConfirm.onHoverState.BorderRadius = 1;
            this.buttonConfirm.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonConfirm.onHoverState.BorderThickness = 1;
            this.buttonConfirm.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonConfirm.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonConfirm.onHoverState.IconLeftImage = null;
            this.buttonConfirm.onHoverState.IconRightImage = null;
            this.buttonConfirm.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonConfirm.OnIdleState.BorderRadius = 1;
            this.buttonConfirm.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonConfirm.OnIdleState.BorderThickness = 1;
            this.buttonConfirm.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.buttonConfirm.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonConfirm.OnIdleState.IconLeftImage = null;
            this.buttonConfirm.OnIdleState.IconRightImage = null;
            this.buttonConfirm.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonConfirm.OnPressedState.BorderRadius = 1;
            this.buttonConfirm.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonConfirm.OnPressedState.BorderThickness = 1;
            this.buttonConfirm.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonConfirm.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonConfirm.OnPressedState.IconLeftImage = null;
            this.buttonConfirm.OnPressedState.IconRightImage = null;
            this.tableLayoutPanel1.SetRowSpan(this.buttonConfirm, 2);
            this.buttonConfirm.Size = new System.Drawing.Size(75, 32);
            this.buttonConfirm.TabIndex = 8;
            this.buttonConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonConfirm.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonConfirm.TextMarginLeft = 0;
            this.buttonConfirm.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonConfirm.UseDefaultRadiusAndThickness = true;
            // 
            // buttonPeriod
            // 
            this.buttonPeriod.AllowAnimations = true;
            this.buttonPeriod.AllowMouseEffects = true;
            this.buttonPeriod.AllowToggling = false;
            this.buttonPeriod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPeriod.AnimationSpeed = 200;
            this.buttonPeriod.AutoGenerateColors = false;
            this.buttonPeriod.AutoRoundBorders = false;
            this.buttonPeriod.AutoSizeLeftIcon = true;
            this.buttonPeriod.AutoSizeRightIcon = true;
            this.buttonPeriod.BackColor = System.Drawing.Color.Transparent;
            this.buttonPeriod.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.buttonPeriod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPeriod.BackgroundImage")));
            this.buttonPeriod.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonPeriod.ButtonText = "المدة الزمنية";
            this.buttonPeriod.ButtonTextMarginLeft = 0;
            this.buttonPeriod.ColorContrastOnClick = 45;
            this.buttonPeriod.ColorContrastOnHover = 45;
            this.buttonPeriod.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.buttonPeriod.CustomizableEdges = borderEdges2;
            this.buttonPeriod.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonPeriod.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonPeriod.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonPeriod.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonPeriod.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.buttonPeriod.Font = new System.Drawing.Font("Tahoma", 9F);
            this.buttonPeriod.ForeColor = System.Drawing.Color.White;
            this.buttonPeriod.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPeriod.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonPeriod.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonPeriod.IconMarginLeft = 11;
            this.buttonPeriod.IconPadding = 10;
            this.buttonPeriod.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPeriod.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonPeriod.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonPeriod.IconSize = 25;
            this.buttonPeriod.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonPeriod.IdleBorderRadius = 1;
            this.buttonPeriod.IdleBorderThickness = 1;
            this.buttonPeriod.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.buttonPeriod.IdleIconLeftImage = null;
            this.buttonPeriod.IdleIconRightImage = null;
            this.buttonPeriod.IndicateFocus = false;
            this.buttonPeriod.Location = new System.Drawing.Point(335, 14);
            this.buttonPeriod.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPeriod.Name = "buttonPeriod";
            this.buttonPeriod.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonPeriod.OnDisabledState.BorderRadius = 1;
            this.buttonPeriod.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonPeriod.OnDisabledState.BorderThickness = 1;
            this.buttonPeriod.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonPeriod.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonPeriod.OnDisabledState.IconLeftImage = null;
            this.buttonPeriod.OnDisabledState.IconRightImage = null;
            this.buttonPeriod.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonPeriod.onHoverState.BorderRadius = 1;
            this.buttonPeriod.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonPeriod.onHoverState.BorderThickness = 1;
            this.buttonPeriod.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonPeriod.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonPeriod.onHoverState.IconLeftImage = null;
            this.buttonPeriod.onHoverState.IconRightImage = null;
            this.buttonPeriod.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonPeriod.OnIdleState.BorderRadius = 1;
            this.buttonPeriod.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonPeriod.OnIdleState.BorderThickness = 1;
            this.buttonPeriod.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.buttonPeriod.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonPeriod.OnIdleState.IconLeftImage = null;
            this.buttonPeriod.OnIdleState.IconRightImage = null;
            this.buttonPeriod.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonPeriod.OnPressedState.BorderRadius = 1;
            this.buttonPeriod.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonPeriod.OnPressedState.BorderThickness = 1;
            this.buttonPeriod.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonPeriod.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonPeriod.OnPressedState.IconLeftImage = null;
            this.buttonPeriod.OnPressedState.IconRightImage = null;
            this.tableLayoutPanel1.SetRowSpan(this.buttonPeriod, 2);
            this.buttonPeriod.Size = new System.Drawing.Size(82, 32);
            this.buttonPeriod.TabIndex = 7;
            this.buttonPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonPeriod.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonPeriod.TextMarginLeft = 0;
            this.buttonPeriod.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonPeriod.UseDefaultRadiusAndThickness = true;
            // 
            // labelTo
            // 
            this.labelTo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelTo.Location = new System.Drawing.Point(558, 38);
            this.labelTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(25, 14);
            this.labelTo.TabIndex = 6;
            this.labelTo.Text = "إلى";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(443, 35);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(111, 20);
            this.dateTimePickerTo.TabIndex = 5;
            // 
            // labelFrom
            // 
            this.labelFrom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelFrom.Location = new System.Drawing.Point(558, 8);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(22, 14);
            this.labelFrom.TabIndex = 4;
            this.labelFrom.Text = "من";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(443, 5);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(111, 20);
            this.dateTimePickerFrom.TabIndex = 3;
            // 
            // buttonSelectClient
            // 
            this.buttonSelectClient.AllowAnimations = true;
            this.buttonSelectClient.AllowMouseEffects = true;
            this.buttonSelectClient.AllowToggling = false;
            this.buttonSelectClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSelectClient.AnimationSpeed = 200;
            this.buttonSelectClient.AutoGenerateColors = false;
            this.buttonSelectClient.AutoRoundBorders = false;
            this.buttonSelectClient.AutoSizeLeftIcon = true;
            this.buttonSelectClient.AutoSizeRightIcon = true;
            this.buttonSelectClient.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSelectClient.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.buttonSelectClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSelectClient.BackgroundImage")));
            this.buttonSelectClient.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonSelectClient.ButtonText = "Bunifu Button";
            this.buttonSelectClient.ButtonTextMarginLeft = 0;
            this.buttonSelectClient.ColorContrastOnClick = 45;
            this.buttonSelectClient.ColorContrastOnHover = 45;
            this.buttonSelectClient.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.buttonSelectClient.CustomizableEdges = borderEdges4;
            this.buttonSelectClient.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonSelectClient.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonSelectClient.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonSelectClient.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonSelectClient.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.buttonSelectClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSelectClient.ForeColor = System.Drawing.Color.White;
            this.buttonSelectClient.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectClient.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonSelectClient.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonSelectClient.IconMarginLeft = 11;
            this.buttonSelectClient.IconPadding = 10;
            this.buttonSelectClient.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSelectClient.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonSelectClient.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonSelectClient.IconSize = 25;
            this.buttonSelectClient.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonSelectClient.IdleBorderRadius = 1;
            this.buttonSelectClient.IdleBorderThickness = 1;
            this.buttonSelectClient.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.buttonSelectClient.IdleIconLeftImage = null;
            this.buttonSelectClient.IdleIconRightImage = null;
            this.buttonSelectClient.IndicateFocus = false;
            this.buttonSelectClient.Location = new System.Drawing.Point(628, 14);
            this.buttonSelectClient.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelectClient.Name = "buttonSelectClient";
            this.buttonSelectClient.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonSelectClient.OnDisabledState.BorderRadius = 1;
            this.buttonSelectClient.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonSelectClient.OnDisabledState.BorderThickness = 1;
            this.buttonSelectClient.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonSelectClient.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonSelectClient.OnDisabledState.IconLeftImage = null;
            this.buttonSelectClient.OnDisabledState.IconRightImage = null;
            this.buttonSelectClient.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonSelectClient.onHoverState.BorderRadius = 1;
            this.buttonSelectClient.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonSelectClient.onHoverState.BorderThickness = 1;
            this.buttonSelectClient.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonSelectClient.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonSelectClient.onHoverState.IconLeftImage = null;
            this.buttonSelectClient.onHoverState.IconRightImage = null;
            this.buttonSelectClient.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonSelectClient.OnIdleState.BorderRadius = 1;
            this.buttonSelectClient.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonSelectClient.OnIdleState.BorderThickness = 1;
            this.buttonSelectClient.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.buttonSelectClient.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonSelectClient.OnIdleState.IconLeftImage = null;
            this.buttonSelectClient.OnIdleState.IconRightImage = null;
            this.buttonSelectClient.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonSelectClient.OnPressedState.BorderRadius = 1;
            this.buttonSelectClient.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonSelectClient.OnPressedState.BorderThickness = 1;
            this.buttonSelectClient.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonSelectClient.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonSelectClient.OnPressedState.IconLeftImage = null;
            this.buttonSelectClient.OnPressedState.IconRightImage = null;
            this.tableLayoutPanel1.SetRowSpan(this.buttonSelectClient, 2);
            this.buttonSelectClient.Size = new System.Drawing.Size(30, 32);
            this.buttonSelectClient.TabIndex = 2;
            this.buttonSelectClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSelectClient.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonSelectClient.TextMarginLeft = 0;
            this.buttonSelectClient.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonSelectClient.UseDefaultRadiusAndThickness = true;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(670, 20);
            this.comboBoxClient.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxClient.Name = "comboBoxClient";
            this.tableLayoutPanel1.SetRowSpan(this.comboBoxClient, 2);
            this.comboBoxClient.Size = new System.Drawing.Size(163, 21);
            this.comboBoxClient.TabIndex = 1;
            // 
            // labelClient
            // 
            this.labelClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelClient.Location = new System.Drawing.Point(851, 23);
            this.labelClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClient.Name = "labelClient";
            this.tableLayoutPanel1.SetRowSpan(this.labelClient, 2);
            this.labelClient.Size = new System.Drawing.Size(34, 14);
            this.labelClient.TabIndex = 0;
            this.labelClient.Text = "الزبون";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.textBoxCurrentDebt);
            this.panelBottom.Controls.Add(this.labelCurrentDebt);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 542);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(2);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(917, 47);
            this.panelBottom.TabIndex = 1;
            // 
            // textBoxCurrentDebt
            // 
            this.textBoxCurrentDebt.AcceptsReturn = false;
            this.textBoxCurrentDebt.AcceptsTab = false;
            this.textBoxCurrentDebt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrentDebt.AnimationSpeed = 200;
            this.textBoxCurrentDebt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxCurrentDebt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxCurrentDebt.AutoSizeHeight = true;
            this.textBoxCurrentDebt.BackColor = System.Drawing.Color.Transparent;
            this.textBoxCurrentDebt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxCurrentDebt.BackgroundImage")));
            this.textBoxCurrentDebt.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.textBoxCurrentDebt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBoxCurrentDebt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.textBoxCurrentDebt.BorderColorIdle = System.Drawing.Color.Silver;
            this.textBoxCurrentDebt.BorderRadius = 1;
            this.textBoxCurrentDebt.BorderThickness = 1;
            this.textBoxCurrentDebt.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.textBoxCurrentDebt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxCurrentDebt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCurrentDebt.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentDebt.DefaultText = "0,00";
            this.textBoxCurrentDebt.FillColor = System.Drawing.Color.White;
            this.textBoxCurrentDebt.HideSelection = true;
            this.textBoxCurrentDebt.IconLeft = null;
            this.textBoxCurrentDebt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCurrentDebt.IconPadding = 10;
            this.textBoxCurrentDebt.IconRight = null;
            this.textBoxCurrentDebt.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCurrentDebt.Lines = new string[] {
        "0,00"};
            this.textBoxCurrentDebt.Location = new System.Drawing.Point(694, 11);
            this.textBoxCurrentDebt.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCurrentDebt.MaxLength = 32767;
            this.textBoxCurrentDebt.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBoxCurrentDebt.Modified = false;
            this.textBoxCurrentDebt.Multiline = false;
            this.textBoxCurrentDebt.Name = "textBoxCurrentDebt";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxCurrentDebt.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textBoxCurrentDebt.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxCurrentDebt.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxCurrentDebt.OnIdleState = stateProperties4;
            this.textBoxCurrentDebt.Padding = new System.Windows.Forms.Padding(3);
            this.textBoxCurrentDebt.PasswordChar = '\0';
            this.textBoxCurrentDebt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.textBoxCurrentDebt.PlaceholderText = "Enter text";
            this.textBoxCurrentDebt.ReadOnly = true;
            this.textBoxCurrentDebt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxCurrentDebt.SelectedText = "";
            this.textBoxCurrentDebt.SelectionLength = 0;
            this.textBoxCurrentDebt.SelectionStart = 4;
            this.textBoxCurrentDebt.ShortcutsEnabled = true;
            this.textBoxCurrentDebt.Size = new System.Drawing.Size(114, 21);
            this.textBoxCurrentDebt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.textBoxCurrentDebt.TabIndex = 1;
            this.textBoxCurrentDebt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCurrentDebt.TextMarginBottom = 0;
            this.textBoxCurrentDebt.TextMarginLeft = 3;
            this.textBoxCurrentDebt.TextMarginTop = 1;
            this.textBoxCurrentDebt.TextPlaceholder = "Enter text";
            this.textBoxCurrentDebt.UseSystemPasswordChar = false;
            this.textBoxCurrentDebt.WordWrap = true;
            // 
            // labelCurrentDebt
            // 
            this.labelCurrentDebt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentDebt.AutoSize = true;
            this.labelCurrentDebt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelCurrentDebt.Location = new System.Drawing.Point(811, 13);
            this.labelCurrentDebt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentDebt.Name = "labelCurrentDebt";
            this.labelCurrentDebt.Size = new System.Drawing.Size(79, 14);
            this.labelCurrentDebt.TabIndex = 0;
            this.labelCurrentDebt.Text = "الدين الحالي";
            // 
            // dataGridViewSituation
            // 
            this.dataGridViewSituation.AllowUserToAddRows = false;
            this.dataGridViewSituation.AllowUserToDeleteRows = false;
            this.dataGridViewSituation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSituation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colOperation,
            this.colSale,
            this.colPayment});
            this.dataGridViewSituation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSituation.Location = new System.Drawing.Point(0, 65);
            this.dataGridViewSituation.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSituation.Name = "dataGridViewSituation";
            this.dataGridViewSituation.ReadOnly = true;
            this.dataGridViewSituation.RowHeadersWidth = 51;
            this.dataGridViewSituation.RowTemplate.Height = 24;
            this.dataGridViewSituation.Size = new System.Drawing.Size(917, 477);
            this.dataGridViewSituation.TabIndex = 2;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "التاريخ";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 150;
            // 
            // colOperation
            // 
            this.colOperation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOperation.HeaderText = "العملية";
            this.colOperation.MinimumWidth = 6;
            this.colOperation.Name = "colOperation";
            this.colOperation.ReadOnly = true;
            // 
            // colSale
            // 
            this.colSale.HeaderText = "البيع";
            this.colSale.MinimumWidth = 6;
            this.colSale.Name = "colSale";
            this.colSale.ReadOnly = true;
            this.colSale.Width = 150;
            // 
            // colPayment
            // 
            this.colPayment.HeaderText = "الدفع";
            this.colPayment.MinimumWidth = 6;
            this.colPayment.Name = "colPayment";
            this.colPayment.ReadOnly = true;
            this.colPayment.Width = 150;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.436182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75694F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.771365F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.881243F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.98557F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.76138F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.770255F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.64817F));
            this.tableLayoutPanel1.Controls.Add(this.buttonPrint, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTo, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonPeriod, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerTo, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonConfirm, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelClient, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxClient, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSelectClient, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelFrom, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCalendar, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerFrom, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(901, 61);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // ClientSituationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 589);
            this.Controls.Add(this.dataGridViewSituation);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientSituationForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Situation Client";
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSituation)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.DataGridView dataGridViewSituation;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private BunifuButton2 buttonSelectClient;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private BunifuButton2 buttonPeriod;
        private BunifuButton2 buttonConfirm;
        private BunifuButton2 buttonCalendar;
        private BunifuButton2 buttonPrint;
        private BunifuTextBox textBoxCurrentDebt;
        private System.Windows.Forms.Label labelCurrentDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}