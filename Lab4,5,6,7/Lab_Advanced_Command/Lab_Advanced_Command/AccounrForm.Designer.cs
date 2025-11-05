namespace Lab_Advanced_Command
{
    partial class AccounrForm
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
            this.components = new System.ComponentModel.Container();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.txtTell = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.contextMenuAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmViewRole = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDiary = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.contextMenuAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(1109, 677);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(150, 35);
            this.btnResetPassword.TabIndex = 26;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(949, 677);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 35);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(791, 677);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(112, 35);
            this.btnAddAccount.TabIndex = 24;
            this.btnAddAccount.Text = "Add";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(842, 151);
            this.btnAddRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(112, 35);
            this.btnAddRole.TabIndex = 23;
            this.btnAddRole.Text = "Add Role";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(651, 201);
            this.chkActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(22, 21);
            this.chkActive.TabIndex = 22;
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // cboRole
            // 
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(651, 154);
            this.cboRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(180, 28);
            this.cboRole.TabIndex = 21;
            this.cboRole.SelectedIndexChanged += new System.EventHandler(this.cboRole_SelectedIndexChanged);
            // 
            // txtTell
            // 
            this.txtTell.Location = new System.Drawing.Point(651, 103);
            this.txtTell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTell.Name = "txtTell";
            this.txtTell.Size = new System.Drawing.Size(148, 26);
            this.txtTell.TabIndex = 19;
            this.txtTell.TextChanged += new System.EventHandler(this.txtTell_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(283, 232);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 26);
            this.txtEmail.TabIndex = 18;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(283, 191);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(148, 26);
            this.txtFullName.TabIndex = 20;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(283, 148);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(148, 26);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(283, 108);
            this.txtAccountName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(148, 26);
            this.txtAccountName.TabIndex = 16;
            this.txtAccountName.TextChanged += new System.EventHandler(this.txtAccountName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(529, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Active:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(529, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Role:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tell:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "FullName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "AccountName:";
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Location = new System.Drawing.Point(95, 291);
            this.dgvAccounts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.RowHeadersWidth = 62;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(1164, 362);
            this.dgvAccounts.TabIndex = 8;
            this.dgvAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_CellContentClick);
            // 
            // contextMenuAccount
            // 
            this.contextMenuAccount.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmViewRole,
            this.tsmDiary});
            this.contextMenuAccount.Name = "contextMenuAccount";
            this.contextMenuAccount.Size = new System.Drawing.Size(261, 101);
            this.contextMenuAccount.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuAccount_Opening);
            // 
            // tsmViewRole
            // 
            this.tsmViewRole.Name = "tsmViewRole";
            this.tsmViewRole.Size = new System.Drawing.Size(260, 32);
            this.tsmViewRole.Text = "Xem danh sách vai trò";
            this.tsmViewRole.Click += new System.EventHandler(this.tsmViewRole_Click);
            // 
            // tsmDiary
            // 
            this.tsmDiary.Name = "tsmDiary";
            this.tsmDiary.Size = new System.Drawing.Size(260, 32);
            this.tsmDiary.Text = "Nhật kí hoat động";
            this.tsmDiary.Click += new System.EventHandler(this.tsmDiary_Click);
            // 
            // AccounrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 814);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.btnAddRole);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.cboRole);
            this.Controls.Add(this.txtTell);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAccounts);
            this.Name = "AccounrForm";
            this.Text = "AccounrForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccounrForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccounrForm_FormClosed);
            this.Load += new System.EventHandler(this.AccounrForm_Load);
            this.ForeColorChanged += new System.EventHandler(this.AccounrForm_ForeColorChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.contextMenuAccount.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.TextBox txtTell;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.ContextMenuStrip contextMenuAccount;
        private System.Windows.Forms.ToolStripMenuItem tsmViewRole;
        private System.Windows.Forms.ToolStripMenuItem tsmDiary;
    }
}