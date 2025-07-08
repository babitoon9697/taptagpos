using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class changementWarehouse : Form
    {
        // --- Public properties to return the selected data ---
        public int SelectedWarehouseId { get; private set; }
        public string SelectedWarehouseName { get; private set; }

        public changementWarehouse()
        {
            InitializeComponent();
            this.Load += changementWarehouse_Load;

            // It's better to use a FlowLayoutPanel to automatically arrange the controls
            var flowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                AutoScroll = true
            };
            this.pnl_warehouse.Controls.Add(flowPanel);
        }

        private void changementWarehouse_Load(object sender, EventArgs e)
        {
            LoadWarehouses();
        }

        private void LoadWarehouses()
        {
            var flowPanel = this.pnl_warehouse.Controls[0] as FlowLayoutPanel;
            if (flowPanel == null) return;
            flowPanel.Controls.Clear(); 
            var allWarehousesControl = new pickwarehouse();
            allWarehousesControl.SetData(0, "Tous les Dépôts"); 
            allWarehousesControl.WarehouseClicked += OnWarehouseSelected;
            flowPanel.Controls.Add(allWarehousesControl);
            string connectionString = DatabaseConnection.GetConnectionString();
            string query = "SELECT WarehouseID, WarehouseName FROM Warehouses WHERE IsActive = 1";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["WarehouseID"]);
                            string name = reader["WarehouseName"].ToString();

                            // Create a new instance of our custom user control
                            var warehouseControl = new pickwarehouse();
                            warehouseControl.SetData(id, name);

                            // Subscribe to its click event
                            warehouseControl.WarehouseClicked += OnWarehouseSelected;

                            // Add it to the panel
                            flowPanel.Controls.Add(warehouseControl);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading warehouses: " + ex.Message);
            }
        }

        // --- This event is triggered when a warehouse control is clicked ---
        private void OnWarehouseSelected(int id, string name)
        {
            this.SelectedWarehouseId = id;
            this.SelectedWarehouseName = name;

            // Set the dialog result and close the form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}