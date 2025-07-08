namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class PopupTableArticles
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.btnChoisir = new System.Windows.Forms.Button();
            this.colRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(9, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(548, 21);
            this.txtSearch.TabIndex = 0;
            // 
            // dgvArticles
            // 
            this.dgvArticles.AllowUserToAddRows = false;
            this.dgvArticles.AllowUserToDeleteRows = false;
            this.dgvArticles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticles.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRef,
            this.colDesignation,
            this.colPrix,
            this.colSelect});
            this.dgvArticles.EnableHeadersVisualStyles = false;
            this.dgvArticles.Location = new System.Drawing.Point(9, 34);
            this.dgvArticles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvArticles.Name = "dgvArticles";
            this.dgvArticles.ReadOnly = true;
            this.dgvArticles.RowHeadersVisible = false;
            this.dgvArticles.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvArticles.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticles.RowTemplate.Height = 24;
            this.dgvArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticles.Size = new System.Drawing.Size(546, 399);
            this.dgvArticles.TabIndex = 1;
            // 
            // btnChoisir
            // 
            this.btnChoisir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoisir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnChoisir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoisir.Location = new System.Drawing.Point(567, 34);
            this.btnChoisir.Margin = new System.Windows.Forms.Padding(2);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(109, 399);
            this.btnChoisir.TabIndex = 2;
            this.btnChoisir.Text = "CHOISIR ARTICLE";
            this.btnChoisir.UseVisualStyleBackColor = true;
            // 
            // colRef
            // 
            this.colRef.HeaderText = "Reference";
            this.colRef.MinimumWidth = 6;
            this.colRef.Name = "colRef";
            this.colRef.ReadOnly = true;
            // 
            // colDesignation
            // 
            this.colDesignation.FillWeight = 200F;
            this.colDesignation.HeaderText = "Designation";
            this.colDesignation.MinimumWidth = 6;
            this.colDesignation.Name = "colDesignation";
            this.colDesignation.ReadOnly = true;
            // 
            // colPrix
            // 
            this.colPrix.HeaderText = "Prix";
            this.colPrix.MinimumWidth = 6;
            this.colPrix.Name = "colPrix";
            this.colPrix.ReadOnly = true;
            // 
            // colSelect
            // 
            this.colSelect.HeaderText = "Select";
            this.colSelect.Name = "colSelect";
            this.colSelect.ReadOnly = true;
            this.colSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PopupTableArticles
            // 
            this.AcceptButton = this.btnChoisir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 443);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.dgvArticles);
            this.Controls.Add(this.txtSearch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(454, 332);
            this.Name = "PopupTableArticles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Table ARTICLES";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvArticles;
        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrix;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
    }
}