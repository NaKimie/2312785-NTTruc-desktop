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
    public partial class AddRole : Form
    {
        private string accountName;
        public AddRole()
        {
            InitializeComponent();
        }
        public AddRole(string acc)
        {
            InitializeComponent();
            accountName = acc;
        }
        private void AddRole_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void AddRole_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = "server=DESKTOP-PGKIS28\\SQLEXPRESS;database=Restaurant Management;Integrated Security=true";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("InsertRole", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoleName", txtRoleName.Text);
                cmd.Parameters.AddWithValue("@Path", string.IsNullOrEmpty(txtPath.Text) ? (object)DBNull.Value : txtPath.Text);
                cmd.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(txtNotes.Text) ? (object)DBNull.Value : txtNotes.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Đã thêm vai trò mới!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
