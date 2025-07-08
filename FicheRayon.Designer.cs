namespace TAPTAGPOS
{
    partial class FicheRayon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicheRayon));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnValider = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnAnnuler = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.txtRayonName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblRayon = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(400, 40);
            this.pnlHeader.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Fiche Rayon";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnValider
            // 
            this.btnValider.AllowAnimations = true;
            this.btnValider.AllowMouseEffects = true;
            this.btnValider.AllowToggling = false;
            this.btnValider.AnimationSpeed = 200;
            this.btnValider.AutoGenerateColors = false;
            this.btnValider.AutoRoundBorders = false;
            this.btnValider.AutoSizeLeftIcon = true;
            this.btnValider.AutoSizeRightIcon = true;
            this.btnValider.BackColor = System.Drawing.Color.Transparent;
            this.btnValider.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnValider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnValider.BackgroundImage")));
            this.btnValider.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnValider.ButtonText = "✓ Valider";
            this.btnValider.ButtonTextMarginLeft = 0;
            this.btnValider.ColorContrastOnClick = 45;
            this.btnValider.ColorContrastOnHover = 45;
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnValider.CustomizableEdges = borderEdges1;
            this.btnValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnValider.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnValider.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnValider.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnValider.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnValider.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValider.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnValider.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnValider.IconMarginLeft = 11;
            this.btnValider.IconPadding = 10;
            this.btnValider.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValider.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnValider.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnValider.IconSize = 25;
            this.btnValider.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnValider.IdleBorderRadius = 15;
            this.btnValider.IdleBorderThickness = 1;
            this.btnValider.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnValider.IdleIconLeftImage = null;
            this.btnValider.IdleIconRightImage = null;
            this.btnValider.IndicateFocus = false;
            this.btnValider.Location = new System.Drawing.Point(212, 130);
            this.btnValider.Name = "btnValider";
            this.btnValider.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnValider.OnDisabledState.BorderRadius = 15;
            this.btnValider.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnValider.OnDisabledState.BorderThickness = 1;
            this.btnValider.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnValider.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnValider.OnDisabledState.IconLeftImage = null;
            this.btnValider.OnDisabledState.IconRightImage = null;
            this.btnValider.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(184)))), ((int)(((byte)(103)))));
            this.btnValider.onHoverState.BorderRadius = 15;
            this.btnValider.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnValider.onHoverState.BorderThickness = 1;
            this.btnValider.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(184)))), ((int)(((byte)(103)))));
            this.btnValider.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnValider.onHoverState.IconLeftImage = null;
            this.btnValider.onHoverState.IconRightImage = null;
            this.btnValider.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnValider.OnIdleState.BorderRadius = 15;
            this.btnValider.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnValider.OnIdleState.BorderThickness = 1;
            this.btnValider.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnValider.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnValider.OnIdleState.IconLeftImage = null;
            this.btnValider.OnIdleState.IconRightImage = null;
            this.btnValider.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(148)))), ((int)(((byte)(83)))));
            this.btnValider.OnPressedState.BorderRadius = 15;
            this.btnValider.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnValider.OnPressedState.BorderThickness = 1;
            this.btnValider.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(148)))), ((int)(((byte)(83)))));
            this.btnValider.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnValider.OnPressedState.IconLeftImage = null;
            this.btnValider.OnPressedState.IconRightImage = null;
            this.btnValider.Size = new System.Drawing.Size(150, 40);
            this.btnValider.TabIndex = 2;
            this.btnValider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnValider.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnValider.TextMarginLeft = 0;
            this.btnValider.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnValider.UseDefaultRadiusAndThickness = true;
            // 
            // btnAnnuler
            // 
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.AllowAnimations = true;
            this.btnAnnuler.AllowMouseEffects = true;
            this.btnAnnuler.AllowToggling = false;
            this.btnAnnuler.AnimationSpeed = 200;
            this.btnAnnuler.AutoGenerateColors = false;
            this.btnAnnuler.AutoRoundBorders = false;
            this.btnAnnuler.AutoSizeLeftIcon = true;
            this.btnAnnuler.AutoSizeRightIcon = true;
            this.btnAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.btnAnnuler.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnAnnuler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnnuler.BackgroundImage")));
            this.btnAnnuler.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAnnuler.ButtonText = "✗ Annuler";
            this.btnAnnuler.ButtonTextMarginLeft = 0;
            this.btnAnnuler.ColorContrastOnClick = 45;
            this.btnAnnuler.ColorContrastOnHover = 45;
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAnnuler.CustomizableEdges = borderEdges2;
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAnnuler.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAnnuler.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAnnuler.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnuler.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAnnuler.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAnnuler.IconMarginLeft = 11;
            this.btnAnnuler.IconPadding = 10;
            this.btnAnnuler.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnnuler.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAnnuler.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAnnuler.IconSize = 25;
            this.btnAnnuler.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnAnnuler.IdleBorderRadius = 15;
            this.btnAnnuler.IdleBorderThickness = 1;
            this.btnAnnuler.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnAnnuler.IdleIconLeftImage = null;
            this.btnAnnuler.IdleIconRightImage = null;
            this.btnAnnuler.IndicateFocus = false;
            this.btnAnnuler.Location = new System.Drawing.Point(42, 130);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAnnuler.OnDisabledState.BorderRadius = 15;
            this.btnAnnuler.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAnnuler.OnDisabledState.BorderThickness = 1;
            this.btnAnnuler.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAnnuler.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAnnuler.OnDisabledState.IconLeftImage = null;
            this.btnAnnuler.OnDisabledState.IconRightImage = null;
            this.btnAnnuler.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnAnnuler.onHoverState.BorderRadius = 15;
            this.btnAnnuler.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAnnuler.onHoverState.BorderThickness = 1;
            this.btnAnnuler.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnAnnuler.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.onHoverState.IconLeftImage = null;
            this.btnAnnuler.onHoverState.IconRightImage = null;
            this.btnAnnuler.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnAnnuler.OnIdleState.BorderRadius = 15;
            this.btnAnnuler.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAnnuler.OnIdleState.BorderThickness = 1;
            this.btnAnnuler.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnAnnuler.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.OnIdleState.IconLeftImage = null;
            this.btnAnnuler.OnIdleState.IconRightImage = null;
            this.btnAnnuler.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.btnAnnuler.OnPressedState.BorderRadius = 15;
            this.btnAnnuler.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAnnuler.OnPressedState.BorderThickness = 1;
            this.btnAnnuler.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.btnAnnuler.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.OnPressedState.IconLeftImage = null;
            this.btnAnnuler.OnPressedState.IconRightImage = null;
            this.btnAnnuler.Size = new System.Drawing.Size(150, 40);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnnuler.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAnnuler.TextMarginLeft = 0;
            this.btnAnnuler.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAnnuler.UseDefaultRadiusAndThickness = true;
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            // ...
            // 
            // txtRayonName
            // 
            // 
            // txtRayonName
            // 
            this.txtRayonName.AcceptsReturn = false;
            this.txtRayonName.AcceptsTab = false;
            this.txtRayonName.AnimationSpeed = 200;
            this.txtRayonName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtRayonName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtRayonName.AutoSizeHeight = true;
            this.txtRayonName.BackColor = System.Drawing.Color.Transparent;
            this.txtRayonName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtRayonName.BackgroundImage")));
            this.txtRayonName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtRayonName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtRayonName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtRayonName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtRayonName.BorderRadius = 15;
            this.txtRayonName.BorderThickness = 1;
            this.txtRayonName.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtRayonName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRayonName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRayonName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtRayonName.DefaultText = "";
            this.txtRayonName.FillColor = System.Drawing.Color.White;
            this.txtRayonName.HideSelection = true;
            this.txtRayonName.IconLeft = null;
            this.txtRayonName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRayonName.IconPadding = 10;
            this.txtRayonName.IconRight = null;
            this.txtRayonName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRayonName.Lines = new string[0];
            this.txtRayonName.Location = new System.Drawing.Point(42, 75);
            this.txtRayonName.MaxLength = 32767;
            this.txtRayonName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtRayonName.Modified = false;
            this.txtRayonName.Multiline = false;
            this.txtRayonName.Name = "txtRayonName";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtRayonName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtRayonName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtRayonName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtRayonName.OnIdleState = stateProperties4;
            this.txtRayonName.Padding = new System.Windows.Forms.Padding(3);
            this.txtRayonName.PasswordChar = '\0';
            this.txtRayonName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtRayonName.PlaceholderText = "Entrez le nom du rayon";
            this.txtRayonName.ReadOnly = false;
            this.txtRayonName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRayonName.SelectedText = "";
            this.txtRayonName.SelectionLength = 0;
            this.txtRayonName.SelectionStart = 0;
            this.txtRayonName.ShortcutsEnabled = true;
            this.txtRayonName.Size = new System.Drawing.Size(320, 39);
            this.txtRayonName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtRayonName.TabIndex = 1;
            this.txtRayonName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRayonName.TextMarginBottom = 0;
            this.txtRayonName.TextMarginLeft = 3;
            this.txtRayonName.TextMarginTop = 1;
            this.txtRayonName.TextPlaceholder = "Entrez le nom du rayon";
            this.txtRayonName.UseSystemPasswordChar = false;
            this.txtRayonName.WordWrap = true;
            // 
            // lblRayon
            // 
            this.lblRayon.AutoSize = true;
            this.lblRayon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRayon.Location = new System.Drawing.Point(38, 60);
            this.lblRayon.Name = "lblRayon";
            this.lblRayon.Size = new System.Drawing.Size(107, 19);
            this.lblRayon.TabIndex = 0;
            this.lblRayon.Text = "Nom du Rayon:";
            // 
            // FicheRayon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(400, 190);
            this.Controls.Add(this.lblRayon);
            this.Controls.Add(this.txtRayonName);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FicheRayon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FicheRayon";
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnValider;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnAnnuler;
        private Bunifu.UI.WinForms.BunifuTextBox txtRayonName;
        private System.Windows.Forms.Label lblRayon;
    }
}