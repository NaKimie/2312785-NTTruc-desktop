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

namespace Lab_Advanced_Command
{
    public partial class ActivityLogForm : Form
    {
        private string accountName;
        public ActivityLogForm()
        {
            InitializeComponent();
        }
        public ActivityLogForm(string acc)
        {
            InitializeComponent();
            accountName = acc;
        }
        private void LoadBillDates()
        {
            string connectionString = "server=DESKTOP-PGKIS28\\SQLEXPRESS;database=Restaurant Management;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("GetBillDatesByAccount", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AccountName", accountName);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lstDates.Items.Add(Convert.ToDateTime(reader["BillDate"]).ToShortDateString());
            }
            conn.Close();
        }

        private void lstDates_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstDates.SelectedItem == null) return;
            DateTime selectedDate = Convert.ToDateTime(lstDates.SelectedItem);
            LoadBillsByDates(selectedDate);
        }

        private void dgvBills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ActivityLogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadBillDates();
        }
        private void LoadBillsByDates(DateTime date)
        {
            string connectionString = "server=DESKTOP-PGKIS28\\SQLEXPRESS;database=Restaurant Management;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("GetBillsByDateAndAccount", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AccountName", accountName);
            cmd.Parameters.AddWithValue("@BillDate", date);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBills.DataSource = dt;

            // Tính tổng
            int totalBills = dt.Rows.Count;
            decimal totalAmount = 0;
            foreach (DataRow row in dt.Rows)
            {
                totalAmount += Convert.ToDecimal(row["Amount"]);
            }

            lblTotalBills.Text = $"Số hóa đơn: {totalBills}";
            lblTotalAmount.Text = $"Tổng tiền: {totalAmount:#,##0}";
        }

        private void ActivityLogForm_Load(object sender, EventArgs e)
        {

        }
    }
}
