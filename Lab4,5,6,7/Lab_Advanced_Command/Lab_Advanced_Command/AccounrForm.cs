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
using Microsoft.VisualBasic;

namespace Lab_Advanced_Command
{
    public partial class AccounrForm : Form
    {
        public AccounrForm()
        {
            InitializeComponent();
        }

        private void AccounrForm_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            LoadRoles();
        }
        private void LoadAccounts()
        {
            string connectionString = "server=DESKTOP-PGKIS28\\SQLEXPRESS;database=Restaurant Management;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("GetAllAccounts", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAccounts.DataSource = dt;
        }
        private void LoadRoles()
        {
            string connectionString = "server=DESKTOP-PGKIS28\\SQLEXPRESS;database=Restaurant Management;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT ID, RoleName FROM Role", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            cboRole.DataSource = dt;
            cboRole.DisplayMember = "RoleName";
            cboRole.ValueMember = "ID";
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string connectionString = "server=DESKTOP-PGKIS28\\SQLEXPRESS;database=Restaurant Management;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("InsertAccount", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AccountName", txtAccountName.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Tell", txtTell.Text);
            cmd.ExecuteNonQuery();

            SqlCommand cmdRole = new SqlCommand("AssignRoleToAccount", conn);
            cmdRole.CommandType = CommandType.StoredProcedure;
            cmdRole.Parameters.AddWithValue("@AccountName", txtAccountName.Text);
            cmdRole.Parameters.AddWithValue("@RoleID", cboRole.SelectedValue);
            cmdRole.Parameters.AddWithValue("@Actived", chkActive.Checked);
            cmdRole.Parameters.AddWithValue("@Notes", DBNull.Value);
            cmdRole.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Thêm tài khoản và gán vai trò thành công!");
            LoadAccounts();
        }

        private void AccounrForm_ForeColorChanged(object sender, EventArgs e)
        {

        }

        private void AccounrForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void AccounrForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string connectionString = "server=DESKTOP-PGKIS28\\SQLEXPRESS;database=Restaurant Management;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UpdateAccount", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AccountName", txtAccountName.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Tell", txtTell.Text);

            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Cập nhật tài khoản thành công!");
           
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string acc = txtAccountName.Text;
            if (string.IsNullOrEmpty(acc))
            {
                MessageBox.Show("Chọn tài khoản cần reset mật khẩu!");
                return;
            }
            string connectionString = "server=DESKTOP-PGKIS28\\SQLEXPRESS;database=Restaurant Management;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("ResetPassword", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AccountName", acc);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Đã reset mật khẩu thành công!");
            LoadAccounts();
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            string roleName = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên vai trò mới:", "Thêm vai trò", "");
            if (!string.IsNullOrEmpty(roleName))
            {
                string connectionString = "server=DESKTOP-PGKIS28\\SQLEXPRESS;database=Restaurant Management;Integrated Security=true";
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("InsertRole", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoleName", roleName);
                cmd.Parameters.AddWithValue("@Path", DBNull.Value);
                cmd.Parameters.AddWithValue("@Notes", DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Đã thêm vai trò mới!");
                LoadRoles();
            }
        }

        private void dgvAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtAccountName.Text = dgvAccounts.Rows[e.RowIndex].Cells["AccountName"].Value.ToString();
                txtPassword.Text = dgvAccounts.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                txtFullName.Text = dgvAccounts.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                txtEmail.Text = dgvAccounts.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtTell.Text = dgvAccounts.Rows[e.RowIndex].Cells["Tell"].Value.ToString();
                chkActive.Checked = dgvAccounts.Rows[e.RowIndex].Cells["Actived"].Value.ToString() == "True";
                string roleName = dgvAccounts.Rows[e.RowIndex].Cells["RoleName"].Value.ToString();
                cboRole.SelectedIndex = cboRole.FindStringExact(roleName);
            }
        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAccountName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTell_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuAccount_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tsmViewRole_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string accountName = dgvAccounts.SelectedRows[0].Cells["AccountName"].Value.ToString();
            RoleListForm frm = new RoleListForm(accountName);
            frm.ShowDialog();
        }

        private void tsmDiary_Click(object sender, EventArgs e)
        {

            string acc = dgvAccounts.SelectedRows[0].Cells["AccountName"].Value.ToString();
            ActivityLogForm frm = new ActivityLogForm(acc);
            frm.ShowDialog();
        }
    }
}
