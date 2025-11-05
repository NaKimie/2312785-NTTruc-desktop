namespace Lab_Advanced_Command
{
    partial class ActivityLogForm
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
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalBills = new System.Windows.Forms.Label();
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.lstDates = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(422, 479);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(13, 20);
            this.lblTotalAmount.TabIndex = 6;
            this.lblTotalAmount.Text = ".";
            // 
            // lblTotalBills
            // 
            this.lblTotalBills.AutoSize = true;
            this.lblTotalBills.Location = new System.Drawing.Point(422, 432);
            this.lblTotalBills.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalBills.Name = "lblTotalBills";
            this.lblTotalBills.Size = new System.Drawing.Size(13, 20);
            this.lblTotalBills.TabIndex = 7;
            this.lblTotalBills.Text = ".";
            // 
            // dgvBills
            // 
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBills.Location = new System.Drawing.Point(412, 175);
            this.dgvBills.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.RowHeadersWidth = 62;
            this.dgvBills.Size = new System.Drawing.Size(882, 231);
            this.dgvBills.TabIndex = 5;
            this.dgvBills.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBills_CellContentClick);
            // 
            // lstDates
            // 
            this.lstDates.FormattingEnabled = true;
            this.lstDates.ItemHeight = 20;
            this.lstDates.Location = new System.Drawing.Point(133, 175);
            this.lstDates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstDates.Name = "lstDates";
            this.lstDates.Size = new System.Drawing.Size(271, 144);
            this.lstDates.TabIndex = 4;
            this.lstDates.SelectedIndexChanged += new System.EventHandler(this.lstDates_SelectedIndexChanged);
            // 
            // ActivityLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 674);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTotalBills);
            this.Controls.Add(this.dgvBills);
            this.Controls.Add(this.lstDates);
            this.Name = "ActivityLogForm";
            this.Text = "ActivityLogForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActivityLogForm_FormClosing);
            this.Load += new System.EventHandler(this.ActivityLogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalBills;
        private System.Windows.Forms.DataGridView dgvBills;
        private System.Windows.Forms.ListBox lstDates;
    }
}