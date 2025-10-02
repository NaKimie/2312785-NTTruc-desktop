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

namespace Lab_Basic_Command
{
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }
        private void LoadAccount()
        {
            string connectionString = "server=PC614\\SQLEXPRESS;database=RestaurantManagement;Integrated Security=true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "SELECT AccountName,Password,FullName,Email,Tell,DateCreated FROM Account";
            SqlDataAdapter da=new SqlDataAdapter(query,sqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAccounts.AutoGenerateColumns = false;
            dgvAccounts.DataSource = dt;
        }

        private void AccountManagerForm_Load(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.CurrentRow == null) return;
            var drv = dgvAccounts.CurrentRow.DataBoundItem as DataRowView;
            if(drv==null) return;   
            string accountname = drv["AccountName"]?.ToString();
            if (string.IsNullOrEmpty(accountname)) return;
            string connectionString = "server=PC614\\SQLEXPRESS;database=RestaurantManagement;Integrated Security=true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "INSERT INTO Account (AccountName,Password,FullName,Email,Tell,DateCreated)" +
                "VALUES (@accountname,@pass,@fullname,@email,@tell,@datecreated)";
            SqlCommand cmd=new SqlCommand(query,sqlConnection);
            cmd.Parameters.AddWithValue("@accountname",accountname);
            cmd.Parameters.AddWithValue("@pass", drv["Password"] ?? "123");
            cmd.Parameters.AddWithValue("@fullname", drv["FullName"] ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@email", drv["Email"] ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@tell", drv["Tell"] ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@datecreated", DateTime.Now);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            LoadAccount();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.CurrentRow == null) return;
            var drv = dgvAccounts.CurrentRow.DataBoundItem as DataRowView;
            if (drv == null) return;
            string accountname = drv["AccountName"]?.ToString();
            if (string.IsNullOrEmpty(accountname)) return;
            string connectionString = "server=PC614\\SQLEXPRESS;database=RestaurantManagement;Integrated Security=true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "UPDATE Account SET Password=@pass,FullName=@fullname,Email=@email,Tell=@tell,DateCreated=@datecreated " +
                "WHERE AccountName=@accountname";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@accountname", accountname);
            cmd.Parameters.AddWithValue("@pass", drv["Password"] ?? "123");
            cmd.Parameters.AddWithValue("@fullname", drv["FullName"] ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@email", drv["Email"] ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@tell", drv["Tell"] ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@datecreated", DateTime.Now);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            LoadAccount();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.CurrentRow == null) return;
            var drv = dgvAccounts.CurrentRow.DataBoundItem as DataRowView;
            if (drv == null) return;
            string accountname = drv["AccountName"]?.ToString();
            string newpass = drv["Password"]?.ToString();
            if (string.IsNullOrEmpty(accountname)) return;
            if(string.IsNullOrEmpty(newpass)) return;
            string connectionString = "server=PC614\\SQLEXPRESS;database=RestaurantManagement;Integrated Security=true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "UPDATE Account SET Password=@pass WHERE AccountName=@accountname";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@accountname", accountname);
            cmd.Parameters.AddWithValue("@pass", newpass);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            LoadAccount();
        }
    }
}
