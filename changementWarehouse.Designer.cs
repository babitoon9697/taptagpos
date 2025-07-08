namespace TAPTAGPOS
{
    partial class changementWarehouse
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
            this.pnl_warehouse = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_warehouse
            // 
            this.pnl_warehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_warehouse.Location = new System.Drawing.Point(0, 0);
            this.pnl_warehouse.Name = "pnl_warehouse";
            this.pnl_warehouse.Size = new System.Drawing.Size(800, 450);
            this.pnl_warehouse.TabIndex = 0;
            // 
            // changementWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_warehouse);
            this.Name = "changementWarehouse";
            this.Text = "changementWarehouse";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_warehouse;
    }
}