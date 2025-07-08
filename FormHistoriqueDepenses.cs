using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FormHistoriqueDepenses : Form
    {
        private readonly string connectionString = DatabaseConnection.GetConnectionString();

        public FormHistoriqueDepenses()
        {
            InitializeComponent();
            this.Load += FormHistoriqueDepenses_Load;
            this.btnAfficher.Click += BtnAfficher_Click;
        }

        private void FormHistoriqueDepenses_Load(object sender, EventArgs e)
        {
            LoadExpenseTypes();
            dtpDateDebut.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDateFin.Value = DateTime.Now;
            BtnAfficher_Click(sender, e); // Load data automatically on open
        }

        private void LoadExpenseTypes()
        {
            try
            {
                var dt = new DataTable();
                using (var conn = new SqlConnection(connectionString))
                {
                    var query = "SELECT ExpenseTypeID, TypeName FROM ExpenseTypes ORDER BY TypeName";
                    new SqlDataAdapter(query, conn).Fill(dt);
                }
                DataRow dr = dt.NewRow();
                dr["ExpenseTypeID"] = 0;
                dr["TypeName"] = "Toutes les rubriques";
                dt.Rows.InsertAt(dr, 0);

                cmbRubrique.DataSource = dt;
                cmbRubrique.DisplayMember = "TypeName";
                cmbRubrique.ValueMember = "ExpenseTypeID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement des rubriques: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAfficher_Click(object sender, EventArgs e)
        {
            int expenseTypeId = (int)cmbRubrique.SelectedValue;
            DateTime startDate = dtpDateDebut.Value.Date;
            DateTime endDate = dtpDateFin.Value.Date.AddDays(1).AddSeconds(-1);

            string query = @"
                SELECT 
                    e.ExpenseDate,
                    et.TypeName,
                    e.Description,
                    e.Amount,
                    e.UserID
                FROM Expenses e
                JOIN ExpenseTypes et ON e.ExpenseTypeID = et.ExpenseTypeID
                WHERE e.ExpenseDate BETWEEN @StartDate AND @EndDate
                  AND (@ExpenseTypeID = 0 OR e.ExpenseTypeID = @ExpenseTypeID)
                ORDER BY e.ExpenseDate DESC";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    var adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@StartDate", startDate);
                    adapter.SelectCommand.Parameters.AddWithValue("@EndDate", endDate);
                    adapter.SelectCommand.Parameters.AddWithValue("@ExpenseTypeID", expenseTypeId);

                    var dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDepenses.DataSource = dt;

                    // Map columns and calculate total
                    dgvDepenses.Columns["colDate"].DataPropertyName = "ExpenseDate";
                    dgvDepenses.Columns["colRubrique"].DataPropertyName = "TypeName";
                    dgvDepenses.Columns["colLibelle"].DataPropertyName = "Description";
                    dgvDepenses.Columns["colMontant"].DataPropertyName = "Amount";
                    dgvDepenses.Columns["colUtilisateur"].DataPropertyName = "UserID";
                    dgvDepenses.Columns["colMontant"].DefaultCellStyle.Format = "N2";

                    decimal totalAmount = 0m;
                    foreach (DataRow row in dt.Rows)
                    {
                        totalAmount += Convert.ToDecimal(row["Amount"]);
                    }
                    labelTotal.Text = $"Total des dépenses: {totalAmount:C2}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la génération du rapport des dépenses: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}