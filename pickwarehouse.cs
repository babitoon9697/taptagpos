using System;
using System.Drawing;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class pickwarehouse : UserControl
    {
        // --- Properties to hold the data for this warehouse ---
        public int WarehouseID { get; private set; }
        public string WarehouseName { get; private set; }

        // --- Event that will be raised when this control is clicked ---
        public event Action<int, string> WarehouseClicked;

        public pickwarehouse()
        {
            InitializeComponent();
            // Make the entire control clickable
            this.tableLayoutPanel1.Click += OnWarehouseClick;
            this.Warehouse.Click += OnWarehouseClick;
        }

        /// <summary>
        /// Sets the data for this control.
        /// </summary>
        public void SetData(int id, string name)
        {
            this.WarehouseID = id;
            this.WarehouseName = name;
            this.Warehouse.Text = name;
        }

        /// <summary>
        /// When any part of the control is clicked, raise the WarehouseClicked event.
        /// </summary>
        private void OnWarehouseClick(object sender, EventArgs e)
        {
            // This will notify the parent form that this specific warehouse was chosen
            WarehouseClicked?.Invoke(this.WarehouseID, this.WarehouseName);
        }
    }
}