using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        private void btn_addcat_Click(object sender, EventArgs e)
        {
            // Retrieve values from text boxes
            string categoryName = TxtCatName.Text.Trim();
            string categoryDescription = txtCatDescription.Text.Trim();

            // Optional: Set the `CreatedOn` to current timestamp or use default from SQL
            DateTime createdOn = DateTime.Now;  // You can modify this if you need a different date

            // Optional: Set the `IsActive` flag, e.g., true for active
            bool isActive = true;  // Set to false if you want the category to be inactive by default

            // Validate category name
            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("المرجو إدخال إسم العائلة أولا", "لم يتم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Connection string to SQL Server
            string connectionString = DatabaseConnection.GetConnectionString();

            // SQL query to insert a new category with all fields
            string query = "INSERT INTO ArticleCategories (CategoryName, Description, CreatedOn, IsActive) " +
                           "VALUES (@CategoryName, @Description, @CreatedOn, @IsActive)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                // Define parameters and set their values
                cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                cmd.Parameters.AddWithValue("@Description", categoryDescription);
                cmd.Parameters.AddWithValue("@CreatedOn", createdOn);
                cmd.Parameters.AddWithValue("@IsActive", isActive);

                try
                {
                    // Open the connection and execute the query
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("تمت إضافة العائلة بنجاح.", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("حدث خطأ أثناء الحفظ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void LoadCategories()
        {
            // Define the connection string
            string connectionString = DatabaseConnection.GetConnectionString();

            // SQL query to retrieve categories (CategoryID, CategoryName, Description)
            string query = "SELECT CategoryID, CategoryName, Description FROM ArticleCategories";

            // Create a DataTable to hold the fetched data
            DataTable dtCategories = new DataTable();

            // Create the SQL connection and command
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    // Open the connection
                    conn.Open();

                    // Create a DataAdapter to fill the DataTable
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    // Fill the DataTable with data from the database
                    da.Fill(dtCategories);

                    // Set the DataGridView's DataSource to the DataTable
                    dgvCategories.DataSource = dtCategories; // Assuming 'dgvCategories' is your DataGridView's name

                    // Optionally, set column names to match what you've set in the DataGridView
                    dgvCategories.Columns["CategoryID"].HeaderText = "CatID";
                    dgvCategories.Columns["CategoryName"].HeaderText = "CatName";
                    dgvCategories.Columns["Description"].HeaderText = "CatDescription";
                }
                catch (Exception ex)
                {
                    // Handle any errors
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delcat_Click(object sender, EventArgs e)
        {

        }

        private void Category_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }
    }
}
