using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;

namespace TAPTAGPOS
{
    partial class FormStatistiquesVentes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistiquesVentes));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.aujourdhuiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semaineEnCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semainePrécédenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moisEnCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moisPrécédentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deuxDerniersMoisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deuxMoisFlottantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annéeEnCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annéePrécédentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annéeFlottanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.dtpDateFin = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dtpDateDebut = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFermer = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnPeriode = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnValider = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnImprimer = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.colFamille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGridFooter = new System.Windows.Forms.Panel();
            this.txtTotal = new Bunifu.UI.WinForms.BunifuTextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelChartTotal = new System.Windows.Forms.Label();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelChartTitle = new System.Windows.Forms.Label();
            this.contextMenuPeriode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelFilters.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.panelGridFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
            this.contextMenuPeriode.SuspendLayout();
            this.SuspendLayout();
            // 
            // aujourdhuiToolStripMenuItem
            // 
            this.aujourdhuiToolStripMenuItem.Name = "aujourdhuiToolStripMenuItem";
            this.aujourdhuiToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.aujourdhuiToolStripMenuItem.Text = "Aujourd\'hui";
            // 
            // hierToolStripMenuItem
            // 
            this.hierToolStripMenuItem.Name = "hierToolStripMenuItem";
            this.hierToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.hierToolStripMenuItem.Text = "Hier";
            // 
            // semaineEnCoursToolStripMenuItem
            // 
            this.semaineEnCoursToolStripMenuItem.Name = "semaineEnCoursToolStripMenuItem";
            this.semaineEnCoursToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.semaineEnCoursToolStripMenuItem.Text = "Semaine en cours";
            // 
            // semainePrécédenteToolStripMenuItem
            // 
            this.semainePrécédenteToolStripMenuItem.Name = "semainePrécédenteToolStripMenuItem";
            this.semainePrécédenteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.semainePrécédenteToolStripMenuItem.Text = "Semaine précédente";
            // 
            // moisEnCoursToolStripMenuItem
            // 
            this.moisEnCoursToolStripMenuItem.Name = "moisEnCoursToolStripMenuItem";
            this.moisEnCoursToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.moisEnCoursToolStripMenuItem.Text = "Mois en cours";
            // 
            // moisPrécédentToolStripMenuItem
            // 
            this.moisPrécédentToolStripMenuItem.Name = "moisPrécédentToolStripMenuItem";
            this.moisPrécédentToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.moisPrécédentToolStripMenuItem.Text = "Mois précédent";
            // 
            // deuxDerniersMoisToolStripMenuItem
            // 
            this.deuxDerniersMoisToolStripMenuItem.Name = "deuxDerniersMoisToolStripMenuItem";
            this.deuxDerniersMoisToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.deuxDerniersMoisToolStripMenuItem.Text = "Deux derniers mois";
            // 
            // deuxMoisFlottantsToolStripMenuItem
            // 
            this.deuxMoisFlottantsToolStripMenuItem.Name = "deuxMoisFlottantsToolStripMenuItem";
            this.deuxMoisFlottantsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.deuxMoisFlottantsToolStripMenuItem.Text = "Deux mois flottants";
            // 
            // annéeEnCoursToolStripMenuItem
            // 
            this.annéeEnCoursToolStripMenuItem.Name = "annéeEnCoursToolStripMenuItem";
            this.annéeEnCoursToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.annéeEnCoursToolStripMenuItem.Text = "Année en cours";
            // 
            // annéePrécédentToolStripMenuItem
            // 
            this.annéePrécédentToolStripMenuItem.Name = "annéePrécédentToolStripMenuItem";
            this.annéePrécédentToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.annéePrécédentToolStripMenuItem.Text = "Année précédente";
            // 
            // annéeFlottanteToolStripMenuItem
            // 
            this.annéeFlottanteToolStripMenuItem.Name = "annéeFlottanteToolStripMenuItem";
            this.annéeFlottanteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.annéeFlottanteToolStripMenuItem.Text = "Année flottante";
            // 
            // panelFilters
            // 
            this.panelFilters.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelFilters.Controls.Add(this.tableLayoutPanel2);
            this.panelFilters.Controls.Add(this.tableLayoutPanel1);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Margin = new System.Windows.Forms.Padding(2);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(935, 85);
            this.panelFilters.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.98693F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.01307F));
            this.tableLayoutPanel2.Controls.Add(this.labelDateDebut, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelDateFin, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpDateFin, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpDateDebut, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(306, 74);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelDateDebut.Location = new System.Drawing.Point(2, 10);
            this.labelDateDebut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(96, 16);
            this.labelDateDebut.TabIndex = 0;
            this.labelDateDebut.Text = "Date de début";
            // 
            // labelDateFin
            // 
            this.labelDateFin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelDateFin.Location = new System.Drawing.Point(2, 47);
            this.labelDateFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(76, 16);
            this.labelDateFin.TabIndex = 2;
            this.labelDateFin.Text = "Date de fin";
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateFin.BackColor = System.Drawing.Color.Transparent;
            this.dtpDateFin.BorderColor = System.Drawing.Color.Silver;
            this.dtpDateFin.BorderRadius = 1;
            this.dtpDateFin.CalendarFont = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.dtpDateFin.Color = System.Drawing.Color.Silver;
            this.dtpDateFin.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpDateFin.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpDateFin.DisabledColor = System.Drawing.Color.Gray;
            this.dtpDateFin.DisplayWeekNumbers = false;
            this.dtpDateFin.DPHeight = 0;
            this.dtpDateFin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDateFin.FillDatePicker = false;
            this.dtpDateFin.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.dtpDateFin.ForeColor = System.Drawing.Color.Black;
            this.dtpDateFin.Icon = ((System.Drawing.Image)(resources.GetObject("dtpDateFin.Icon")));
            this.dtpDateFin.IconColor = System.Drawing.Color.Gray;
            this.dtpDateFin.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpDateFin.LeftTextMargin = 5;
            this.dtpDateFin.Location = new System.Drawing.Point(106, 39);
            this.dtpDateFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateFin.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(198, 32);
            this.dtpDateFin.TabIndex = 3;
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateDebut.BackColor = System.Drawing.Color.Transparent;
            this.dtpDateDebut.BorderColor = System.Drawing.Color.Silver;
            this.dtpDateDebut.BorderRadius = 1;
            this.dtpDateDebut.CalendarFont = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.dtpDateDebut.Color = System.Drawing.Color.Silver;
            this.dtpDateDebut.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpDateDebut.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpDateDebut.DisabledColor = System.Drawing.Color.Gray;
            this.dtpDateDebut.DisplayWeekNumbers = false;
            this.dtpDateDebut.DPHeight = 0;
            this.dtpDateDebut.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDateDebut.FillDatePicker = false;
            this.dtpDateDebut.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.dtpDateDebut.ForeColor = System.Drawing.Color.Black;
            this.dtpDateDebut.Icon = ((System.Drawing.Image)(resources.GetObject("dtpDateDebut.Icon")));
            this.dtpDateDebut.IconColor = System.Drawing.Color.Gray;
            this.dtpDateDebut.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpDateDebut.LeftTextMargin = 5;
            this.dtpDateDebut.Location = new System.Drawing.Point(106, 2);
            this.dtpDateDebut.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateDebut.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(198, 32);
            this.dtpDateDebut.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.btnFermer, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPeriode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnValider, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnImprimer, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(324, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(599, 74);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // btnFermer
            // 
            this.btnFermer.AllowAnimations = true;
            this.btnFermer.AllowMouseEffects = true;
            this.btnFermer.AllowToggling = false;
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.AnimationSpeed = 200;
            this.btnFermer.AutoGenerateColors = false;
            this.btnFermer.AutoRoundBorders = false;
            this.btnFermer.AutoSizeLeftIcon = true;
            this.btnFermer.AutoSizeRightIcon = true;
            this.btnFermer.BackColor = System.Drawing.Color.Transparent;
            this.btnFermer.BackColor1 = System.Drawing.Color.Red;
            this.btnFermer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFermer.BackgroundImage")));
            this.btnFermer.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnFermer.ButtonText = "Fermer";
            this.btnFermer.ButtonTextMarginLeft = 0;
            this.btnFermer.ColorContrastOnClick = 45;
            this.btnFermer.ColorContrastOnHover = 45;
            this.btnFermer.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnFermer.CustomizableEdges = borderEdges1;
            this.btnFermer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFermer.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFermer.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFermer.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFermer.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFermer.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnFermer.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnFermer.IconMarginLeft = 11;
            this.btnFermer.IconPadding = 10;
            this.btnFermer.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFermer.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnFermer.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnFermer.IconSize = 25;
            this.btnFermer.IdleBorderColor = System.Drawing.Color.Red;
            this.btnFermer.IdleBorderRadius = 6;
            this.btnFermer.IdleBorderThickness = 1;
            this.btnFermer.IdleFillColor = System.Drawing.Color.Red;
            this.btnFermer.IdleIconLeftImage = null;
            this.btnFermer.IdleIconRightImage = null;
            this.btnFermer.IndicateFocus = false;
            this.btnFermer.Location = new System.Drawing.Point(497, 12);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFermer.OnDisabledState.BorderRadius = 6;
            this.btnFermer.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnFermer.OnDisabledState.BorderThickness = 1;
            this.btnFermer.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFermer.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFermer.OnDisabledState.IconLeftImage = null;
            this.btnFermer.OnDisabledState.IconRightImage = null;
            this.btnFermer.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnFermer.onHoverState.BorderRadius = 6;
            this.btnFermer.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnFermer.onHoverState.BorderThickness = 1;
            this.btnFermer.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnFermer.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnFermer.onHoverState.IconLeftImage = null;
            this.btnFermer.onHoverState.IconRightImage = null;
            this.btnFermer.OnIdleState.BorderColor = System.Drawing.Color.Red;
            this.btnFermer.OnIdleState.BorderRadius = 6;
            this.btnFermer.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnFermer.OnIdleState.BorderThickness = 1;
            this.btnFermer.OnIdleState.FillColor = System.Drawing.Color.Red;
            this.btnFermer.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnFermer.OnIdleState.IconLeftImage = null;
            this.btnFermer.OnIdleState.IconRightImage = null;
            this.btnFermer.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnFermer.OnPressedState.BorderRadius = 6;
            this.btnFermer.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnFermer.OnPressedState.BorderThickness = 1;
            this.btnFermer.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnFermer.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnFermer.OnPressedState.IconLeftImage = null;
            this.btnFermer.OnPressedState.IconRightImage = null;
            this.btnFermer.Size = new System.Drawing.Size(100, 50);
            this.btnFermer.TabIndex = 7;
            this.btnFermer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFermer.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFermer.TextMarginLeft = 0;
            this.btnFermer.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFermer.UseDefaultRadiusAndThickness = true;
            // 
            // btnPeriode
            // 
            this.btnPeriode.AllowAnimations = true;
            this.btnPeriode.AllowMouseEffects = true;
            this.btnPeriode.AllowToggling = false;
            this.btnPeriode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPeriode.AnimationSpeed = 200;
            this.btnPeriode.AutoGenerateColors = false;
            this.btnPeriode.AutoRoundBorders = false;
            this.btnPeriode.AutoSizeLeftIcon = true;
            this.btnPeriode.AutoSizeRightIcon = true;
            this.btnPeriode.BackColor = System.Drawing.Color.Transparent;
            this.btnPeriode.BackColor1 = System.Drawing.Color.SaddleBrown;
            this.btnPeriode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPeriode.BackgroundImage")));
            this.btnPeriode.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnPeriode.ButtonText = "Période";
            this.btnPeriode.ButtonTextMarginLeft = 0;
            this.btnPeriode.ColorContrastOnClick = 45;
            this.btnPeriode.ColorContrastOnHover = 45;
            this.btnPeriode.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnPeriode.CustomizableEdges = borderEdges2;
            this.btnPeriode.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPeriode.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPeriode.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPeriode.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPeriode.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriode.ForeColor = System.Drawing.Color.Yellow;
            this.btnPeriode.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeriode.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPeriode.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPeriode.IconMarginLeft = 11;
            this.btnPeriode.IconPadding = 10;
            this.btnPeriode.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPeriode.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPeriode.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPeriode.IconSize = 25;
            this.btnPeriode.IdleBorderColor = System.Drawing.Color.SaddleBrown;
            this.btnPeriode.IdleBorderRadius = 6;
            this.btnPeriode.IdleBorderThickness = 1;
            this.btnPeriode.IdleFillColor = System.Drawing.Color.SaddleBrown;
            this.btnPeriode.IdleIconLeftImage = null;
            this.btnPeriode.IdleIconRightImage = null;
            this.btnPeriode.IndicateFocus = false;
            this.btnPeriode.Location = new System.Drawing.Point(2, 12);
            this.btnPeriode.Margin = new System.Windows.Forms.Padding(2);
            this.btnPeriode.Name = "btnPeriode";
            this.btnPeriode.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPeriode.OnDisabledState.BorderRadius = 6;
            this.btnPeriode.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnPeriode.OnDisabledState.BorderThickness = 1;
            this.btnPeriode.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPeriode.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPeriode.OnDisabledState.IconLeftImage = null;
            this.btnPeriode.OnDisabledState.IconRightImage = null;
            this.btnPeriode.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPeriode.onHoverState.BorderRadius = 6;
            this.btnPeriode.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnPeriode.onHoverState.BorderThickness = 1;
            this.btnPeriode.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPeriode.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPeriode.onHoverState.IconLeftImage = null;
            this.btnPeriode.onHoverState.IconRightImage = null;
            this.btnPeriode.OnIdleState.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnPeriode.OnIdleState.BorderRadius = 6;
            this.btnPeriode.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnPeriode.OnIdleState.BorderThickness = 1;
            this.btnPeriode.OnIdleState.FillColor = System.Drawing.Color.SaddleBrown;
            this.btnPeriode.OnIdleState.ForeColor = System.Drawing.Color.Yellow;
            this.btnPeriode.OnIdleState.IconLeftImage = null;
            this.btnPeriode.OnIdleState.IconRightImage = null;
            this.btnPeriode.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPeriode.OnPressedState.BorderRadius = 6;
            this.btnPeriode.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnPeriode.OnPressedState.BorderThickness = 1;
            this.btnPeriode.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPeriode.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPeriode.OnPressedState.IconLeftImage = null;
            this.btnPeriode.OnPressedState.IconRightImage = null;
            this.btnPeriode.Size = new System.Drawing.Size(95, 50);
            this.btnPeriode.TabIndex = 4;
            this.btnPeriode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPeriode.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPeriode.TextMarginLeft = 0;
            this.btnPeriode.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPeriode.UseDefaultRadiusAndThickness = true;
            // 
            // btnValider
            // 
            this.btnValider.AllowAnimations = true;
            this.btnValider.AllowMouseEffects = true;
            this.btnValider.AllowToggling = false;
            this.btnValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValider.AnimationSpeed = 200;
            this.btnValider.AutoGenerateColors = false;
            this.btnValider.AutoRoundBorders = false;
            this.btnValider.AutoSizeLeftIcon = true;
            this.btnValider.AutoSizeRightIcon = true;
            this.btnValider.BackColor = System.Drawing.Color.Transparent;
            this.btnValider.BackColor1 = System.Drawing.Color.Green;
            this.btnValider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnValider.BackgroundImage")));
            this.btnValider.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnValider.ButtonText = "Valider";
            this.btnValider.ButtonTextMarginLeft = 0;
            this.btnValider.ColorContrastOnClick = 45;
            this.btnValider.ColorContrastOnHover = 45;
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnValider.CustomizableEdges = borderEdges3;
            this.btnValider.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnValider.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnValider.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnValider.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnValider.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnValider.IdleBorderColor = System.Drawing.Color.Green;
            this.btnValider.IdleBorderRadius = 6;
            this.btnValider.IdleBorderThickness = 1;
            this.btnValider.IdleFillColor = System.Drawing.Color.Green;
            this.btnValider.IdleIconLeftImage = null;
            this.btnValider.IdleIconRightImage = null;
            this.btnValider.IndicateFocus = false;
            this.btnValider.Location = new System.Drawing.Point(299, 12);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2);
            this.btnValider.Name = "btnValider";
            this.btnValider.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnValider.OnDisabledState.BorderRadius = 6;
            this.btnValider.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnValider.OnDisabledState.BorderThickness = 1;
            this.btnValider.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnValider.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnValider.OnDisabledState.IconLeftImage = null;
            this.btnValider.OnDisabledState.IconRightImage = null;
            this.btnValider.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnValider.onHoverState.BorderRadius = 6;
            this.btnValider.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnValider.onHoverState.BorderThickness = 1;
            this.btnValider.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnValider.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnValider.onHoverState.IconLeftImage = null;
            this.btnValider.onHoverState.IconRightImage = null;
            this.btnValider.OnIdleState.BorderColor = System.Drawing.Color.Green;
            this.btnValider.OnIdleState.BorderRadius = 6;
            this.btnValider.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnValider.OnIdleState.BorderThickness = 1;
            this.btnValider.OnIdleState.FillColor = System.Drawing.Color.Green;
            this.btnValider.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnValider.OnIdleState.IconLeftImage = null;
            this.btnValider.OnIdleState.IconRightImage = null;
            this.btnValider.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnValider.OnPressedState.BorderRadius = 6;
            this.btnValider.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnValider.OnPressedState.BorderThickness = 1;
            this.btnValider.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnValider.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnValider.OnPressedState.IconLeftImage = null;
            this.btnValider.OnPressedState.IconRightImage = null;
            this.btnValider.Size = new System.Drawing.Size(95, 50);
            this.btnValider.TabIndex = 5;
            this.btnValider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnValider.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnValider.TextMarginLeft = 0;
            this.btnValider.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnValider.UseDefaultRadiusAndThickness = true;
            // 
            // btnImprimer
            // 
            this.btnImprimer.AllowAnimations = true;
            this.btnImprimer.AllowMouseEffects = true;
            this.btnImprimer.AllowToggling = false;
            this.btnImprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimer.AnimationSpeed = 200;
            this.btnImprimer.AutoGenerateColors = false;
            this.btnImprimer.AutoRoundBorders = false;
            this.btnImprimer.AutoSizeLeftIcon = true;
            this.btnImprimer.AutoSizeRightIcon = true;
            this.btnImprimer.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimer.BackColor1 = System.Drawing.Color.Navy;
            this.btnImprimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimer.BackgroundImage")));
            this.btnImprimer.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnImprimer.ButtonText = "Imprimer";
            this.btnImprimer.ButtonTextMarginLeft = 0;
            this.btnImprimer.ColorContrastOnClick = 45;
            this.btnImprimer.ColorContrastOnHover = 45;
            this.btnImprimer.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnImprimer.CustomizableEdges = borderEdges4;
            this.btnImprimer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImprimer.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnImprimer.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnImprimer.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnImprimer.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.ForeColor = System.Drawing.Color.White;
            this.btnImprimer.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimer.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnImprimer.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnImprimer.IconMarginLeft = 11;
            this.btnImprimer.IconPadding = 10;
            this.btnImprimer.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimer.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnImprimer.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnImprimer.IconSize = 25;
            this.btnImprimer.IdleBorderColor = System.Drawing.Color.Navy;
            this.btnImprimer.IdleBorderRadius = 6;
            this.btnImprimer.IdleBorderThickness = 1;
            this.btnImprimer.IdleFillColor = System.Drawing.Color.Navy;
            this.btnImprimer.IdleIconLeftImage = null;
            this.btnImprimer.IdleIconRightImage = null;
            this.btnImprimer.IndicateFocus = false;
            this.btnImprimer.Location = new System.Drawing.Point(398, 12);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnImprimer.OnDisabledState.BorderRadius = 6;
            this.btnImprimer.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnImprimer.OnDisabledState.BorderThickness = 1;
            this.btnImprimer.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnImprimer.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnImprimer.OnDisabledState.IconLeftImage = null;
            this.btnImprimer.OnDisabledState.IconRightImage = null;
            this.btnImprimer.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnImprimer.onHoverState.BorderRadius = 6;
            this.btnImprimer.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnImprimer.onHoverState.BorderThickness = 1;
            this.btnImprimer.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnImprimer.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnImprimer.onHoverState.IconLeftImage = null;
            this.btnImprimer.onHoverState.IconRightImage = null;
            this.btnImprimer.OnIdleState.BorderColor = System.Drawing.Color.Navy;
            this.btnImprimer.OnIdleState.BorderRadius = 6;
            this.btnImprimer.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnImprimer.OnIdleState.BorderThickness = 1;
            this.btnImprimer.OnIdleState.FillColor = System.Drawing.Color.Navy;
            this.btnImprimer.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnImprimer.OnIdleState.IconLeftImage = null;
            this.btnImprimer.OnIdleState.IconRightImage = null;
            this.btnImprimer.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnImprimer.OnPressedState.BorderRadius = 6;
            this.btnImprimer.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnImprimer.OnPressedState.BorderThickness = 1;
            this.btnImprimer.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnImprimer.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnImprimer.OnPressedState.IconLeftImage = null;
            this.btnImprimer.OnPressedState.IconRightImage = null;
            this.btnImprimer.Size = new System.Drawing.Size(95, 50);
            this.btnImprimer.TabIndex = 6;
            this.btnImprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImprimer.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnImprimer.TextMarginLeft = 0;
            this.btnImprimer.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnImprimer.UseDefaultRadiusAndThickness = true;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 85);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.dgvSales);
            this.splitContainerMain.Panel1.Controls.Add(this.panelGridFooter);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.labelChartTotal);
            this.splitContainerMain.Panel2.Controls.Add(this.chartSales);
            this.splitContainerMain.Panel2.Controls.Add(this.labelChartTitle);
            this.splitContainerMain.Size = new System.Drawing.Size(935, 453);
            this.splitContainerMain.SplitterDistance = 523;
            this.splitContainerMain.SplitterWidth = 3;
            this.splitContainerMain.TabIndex = 1;
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSales.ColumnHeadersHeight = 30;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFamille,
            this.colQuantite,
            this.colVentes});
            this.dgvSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSales.EnableHeadersVisualStyles = false;
            this.dgvSales.Location = new System.Drawing.Point(0, 0);
            this.dgvSales.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvSales.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSales.RowTemplate.Height = 24;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(523, 426);
            this.dgvSales.TabIndex = 0;
            // 
            // colFamille
            // 
            this.colFamille.FillWeight = 150F;
            this.colFamille.HeaderText = "Famille";
            this.colFamille.MinimumWidth = 6;
            this.colFamille.Name = "colFamille";
            this.colFamille.ReadOnly = true;
            // 
            // colQuantite
            // 
            this.colQuantite.HeaderText = "Quantite";
            this.colQuantite.MinimumWidth = 6;
            this.colQuantite.Name = "colQuantite";
            this.colQuantite.ReadOnly = true;
            // 
            // colVentes
            // 
            this.colVentes.HeaderText = "Ventes";
            this.colVentes.MinimumWidth = 6;
            this.colVentes.Name = "colVentes";
            this.colVentes.ReadOnly = true;
            // 
            // panelGridFooter
            // 
            this.panelGridFooter.Controls.Add(this.txtTotal);
            this.panelGridFooter.Controls.Add(this.labelTotal);
            this.panelGridFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelGridFooter.Location = new System.Drawing.Point(0, 426);
            this.panelGridFooter.Margin = new System.Windows.Forms.Padding(2);
            this.panelGridFooter.Name = "panelGridFooter";
            this.panelGridFooter.Size = new System.Drawing.Size(523, 27);
            this.panelGridFooter.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.AcceptsReturn = false;
            this.txtTotal.AcceptsTab = false;
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.AnimationSpeed = 200;
            this.txtTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTotal.AutoSizeHeight = true;
            this.txtTotal.BackColor = System.Drawing.Color.Transparent;
            this.txtTotal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTotal.BackgroundImage")));
            this.txtTotal.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTotal.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTotal.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTotal.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTotal.BorderRadius = 1;
            this.txtTotal.BorderThickness = 1;
            this.txtTotal.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtTotal.DefaultText = "";
            this.txtTotal.FillColor = System.Drawing.Color.White;
            this.txtTotal.HideSelection = true;
            this.txtTotal.IconLeft = null;
            this.txtTotal.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.IconPadding = 10;
            this.txtTotal.IconRight = null;
            this.txtTotal.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Lines = new string[0];
            this.txtTotal.Location = new System.Drawing.Point(409, 5);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTotal.Modified = false;
            this.txtTotal.Multiline = false;
            this.txtTotal.Name = "txtTotal";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTotal.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTotal.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTotal.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTotal.OnIdleState = stateProperties4;
            this.txtTotal.Padding = new System.Windows.Forms.Padding(3);
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTotal.PlaceholderText = "Enter text";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(106, 20);
            this.txtTotal.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtTotal.TabIndex = 1;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotal.TextMarginBottom = 0;
            this.txtTotal.TextMarginLeft = 3;
            this.txtTotal.TextMarginTop = 1;
            this.txtTotal.TextPlaceholder = "Enter text";
            this.txtTotal.UseSystemPasswordChar = false;
            this.txtTotal.WordWrap = true;
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(2, 7);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(47, 13);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "TOTAL";
            // 
            // labelChartTotal
            // 
            this.labelChartTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelChartTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChartTotal.Location = new System.Drawing.Point(0, 426);
            this.labelChartTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChartTotal.Name = "labelChartTotal";
            this.labelChartTotal.Size = new System.Drawing.Size(409, 27);
            this.labelChartTotal.TabIndex = 2;
            this.labelChartTotal.Text = "100%";
            this.labelChartTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartSales
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea1);
            this.chartSales.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartSales.Legends.Add(legend1);
            this.chartSales.Location = new System.Drawing.Point(0, 24);
            this.chartSales.Margin = new System.Windows.Forms.Padding(2);
            this.chartSales.Name = "chartSales";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSales.Series.Add(series1);
            this.chartSales.Size = new System.Drawing.Size(409, 429);
            this.chartSales.TabIndex = 1;
            this.chartSales.Text = "chart1";
            // 
            // labelChartTitle
            // 
            this.labelChartTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelChartTitle.Font = new System.Drawing.Font("Arial", 10.75F, System.Drawing.FontStyle.Bold);
            this.labelChartTitle.Location = new System.Drawing.Point(0, 0);
            this.labelChartTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChartTitle.Name = "labelChartTitle";
            this.labelChartTitle.Size = new System.Drawing.Size(409, 24);
            this.labelChartTitle.TabIndex = 0;
            this.labelChartTitle.Text = "Ventes par Famille";
            this.labelChartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuPeriode
            // 
            this.contextMenuPeriode.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuPeriode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aujourdhuiToolStripMenuItem,
            this.hierToolStripMenuItem,
            this.semaineEnCoursToolStripMenuItem,
            this.semainePrécédenteToolStripMenuItem,
            this.moisEnCoursToolStripMenuItem,
            this.moisPrécédentToolStripMenuItem,
            this.deuxDerniersMoisToolStripMenuItem,
            this.deuxMoisFlottantsToolStripMenuItem,
            this.annéeEnCoursToolStripMenuItem,
            this.annéePrécédentToolStripMenuItem,
            this.annéeFlottanteToolStripMenuItem});
            this.contextMenuPeriode.Name = "contextMenuPeriode";
            this.contextMenuPeriode.Size = new System.Drawing.Size(182, 246);
            // 
            // FormStatistiquesVentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 538);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.panelFilters);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(754, 495);
            this.Name = "FormStatistiquesVentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistique des Ventes";
            this.panelFilters.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.panelGridFooter.ResumeLayout(false);
            this.panelGridFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            this.contextMenuPeriode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuPeriode;
        private System.Windows.Forms.ToolStripMenuItem aujourdhuiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semaineEnCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semainePrécédenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moisEnCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moisPrécédentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deuxDerniersMoisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deuxMoisFlottantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annéeEnCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annéePrécédentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annéeFlottanteToolStripMenuItem;

        private System.Windows.Forms.Panel panelFilters;
        private BunifuDatePicker dtpDateDebut;
        private System.Windows.Forms.Label labelDateDebut;
        private BunifuDatePicker dtpDateFin;
        private System.Windows.Forms.Label labelDateFin;
        private BunifuButton2 btnPeriode;
        private BunifuButton2 btnValider;
        private BunifuButton2 btnImprimer;
        private BunifuButton2 btnFermer;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Panel panelGridFooter;
        private System.Windows.Forms.Label labelTotal;
        private BunifuTextBox txtTotal;
        private System.Windows.Forms.Label labelChartTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
        private System.Windows.Forms.Label labelChartTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFamille;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVentes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}