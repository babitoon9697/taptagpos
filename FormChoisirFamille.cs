using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FormChoisirFamille : Form
    {
        // Public properties to return the selected data to the calling form
        public int SelectedCategoryId { get; private set; }
        public string SelectedCategoryName { get; private set; }

        private string connectionString = DatabaseConnection.GetConnectionString();

        public FormChoisirFamille()
        {
            InitializeComponent();
            this.Load += FormChoisirFamille_Load;
        }

        private void FormChoisirFamille_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            flowLayoutPanelFamilies.Controls.Clear(); // Assuming your panel is named this

            string query = "SELECT CategoryID, CategoryName FROM ArticleCategories WHERE IsActive = 1 ORDER BY CategoryName";
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
                            int id = Convert.ToInt32(reader["CategoryID"]);
                            string name = reader["CategoryName"].ToString();

                            // --- START OF FIX ---
                            // Use the new, correct way to create the control
                            var categoryControl = new CategoryControl();
                            categoryControl.SetData(id, name);

                            // Subscribe to the control's custom click event
                            categoryControl.CategoryClicked += CategoryControl_Clicked;
                            // --- END OF FIX ---

                            flowLayoutPanelFamilies.Controls.Add(categoryControl);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // This method handles the click from any of the category controls
        private void CategoryControl_Clicked(object sender, EventArgs e)
        {
            var clickedControl = sender as CategoryControl;
            if (clickedControl != null)
            {
                // Set the public properties with the data from the clicked control
                this.SelectedCategoryId = clickedControl.CategoryID.GetValueOrDefault();
                this.SelectedCategoryName = clickedControl.CategoryName;

                // Set the dialog result and close the form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}