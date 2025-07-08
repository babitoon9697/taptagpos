namespace TAPTAGPOS
{
    partial class FormVentesParMois
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.numAnnee = new System.Windows.Forms.NumericUpDown();
            this.labelAnnee = new System.Windows.Forms.Label();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.colMois = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGridFooter = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelChartTitle = new System.Windows.Forms.Label();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnnee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.panelGridFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.btnFermer);
            this.panelFilters.Controls.Add(this.btnImprimer);
            this.panelFilters.Controls.Add(this.btnValider);
            this.panelFilters.Controls.Add(this.numAnnee);
            this.panelFilters.Controls.Add(this.labelAnnee);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(738, 65);
            this.panelFilters.TabIndex = 2;
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(441, 23);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(90, 28);
            this.btnFermer.TabIndex = 7;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // btnImprimer
            // 
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.Location = new System.Drawing.Point(346, 23);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(90, 28);
            this.btnImprimer.TabIndex = 6;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(252, 23);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(90, 28);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // numAnnee
            // 
            this.numAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAnnee.Location = new System.Drawing.Point(109, 27);
            this.numAnnee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numAnnee.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numAnnee.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numAnnee.Name = "numAnnee";
            this.numAnnee.Size = new System.Drawing.Size(90, 21);
            this.numAnnee.TabIndex = 1;
            this.numAnnee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numAnnee.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            // 
            // labelAnnee
            // 
            this.labelAnnee.AutoSize = true;
            this.labelAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnnee.Location = new System.Drawing.Point(17, 28);
            this.labelAnnee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAnnee.Name = "labelAnnee";
            this.labelAnnee.Size = new System.Drawing.Size(83, 15);
            this.labelAnnee.TabIndex = 0;
            this.labelAnnee.Text = "Choisir Année";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 65);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.dgvSales);
            this.splitContainerMain.Panel1.Controls.Add(this.panelGridFooter);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.chartSales);
            this.splitContainerMain.Panel2.Controls.Add(this.labelChartTitle);
            this.splitContainerMain.Size = new System.Drawing.Size(738, 391);
            this.splitContainerMain.SplitterDistance = 413;
            this.splitContainerMain.SplitterWidth = 3;
            this.splitContainerMain.TabIndex = 3;
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMois,
            this.colQuantite,
            this.colVentes});
            this.dgvSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSales.EnableHeadersVisualStyles = false;
            this.dgvSales.Location = new System.Drawing.Point(0, 0);
            this.dgvSales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvSales.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSales.RowTemplate.Height = 24;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(413, 364);
            this.dgvSales.TabIndex = 0;
            // 
            // colMois
            // 
            this.colMois.FillWeight = 150F;
            this.colMois.HeaderText = "Mois";
            this.colMois.MinimumWidth = 6;
            this.colMois.Name = "colMois";
            this.colMois.ReadOnly = true;
            // 
            // colQuantite
            // 
            this.colQuantite.HeaderText = "Quantité";
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
            this.panelGridFooter.Location = new System.Drawing.Point(0, 364);
            this.panelGridFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelGridFooter.Name = "panelGridFooter";
            this.panelGridFooter.Size = new System.Drawing.Size(413, 27);
            this.panelGridFooter.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Location = new System.Drawing.Point(299, 5);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(106, 20);
            this.txtTotal.TabIndex = 1;
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
            // chartSales
            // 
            chartArea1.AxisX.Title = "Mois";
            chartArea1.AxisY.Title = "Les Ventes";
            chartArea1.BackColor = System.Drawing.Color.Khaki;
            chartArea1.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea1);
            this.chartSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartSales.Location = new System.Drawing.Point(0, 24);
            this.chartSales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartSales.Name = "chartSales";
            this.chartSales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartSales.Series.Add(series1);
            this.chartSales.Size = new System.Drawing.Size(322, 367);
            this.chartSales.TabIndex = 1;
            this.chartSales.Text = "chart1";
            // 
            // labelChartTitle
            // 
            this.labelChartTitle.BackColor = System.Drawing.Color.Navy;
            this.labelChartTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelChartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChartTitle.ForeColor = System.Drawing.Color.White;
            this.labelChartTitle.Location = new System.Drawing.Point(0, 0);
            this.labelChartTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChartTitle.Name = "labelChartTitle";
            this.labelChartTitle.Size = new System.Drawing.Size(322, 24);
            this.labelChartTitle.TabIndex = 0;
            this.labelChartTitle.Text = "Ventes Par mois";
            this.labelChartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormVentesParMois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 456);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.panelFilters);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(754, 495);
            this.Name = "FormVentesParMois";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistique des Ventes Annuelles";
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnnee)).EndInit();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.panelGridFooter.ResumeLayout(false);
            this.panelGridFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Label labelAnnee;
        private System.Windows.Forms.NumericUpDown numAnnee;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Panel panelGridFooter;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label labelChartTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMois;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVentes;
    }
}