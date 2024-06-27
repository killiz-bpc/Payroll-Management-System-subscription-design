namespace Payroll_Management_System.Forms.Menu_Form
{
    partial class frmAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvImportAttendance = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnImport = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportAttendance)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvImportAttendance
            // 
            this.dgvImportAttendance.AllowUserToAddRows = false;
            this.dgvImportAttendance.AllowUserToDeleteRows = false;
            this.dgvImportAttendance.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvImportAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImportAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvImportAttendance.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvImportAttendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvImportAttendance.ColumnHeadersHeight = 25;
            this.dgvImportAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvImportAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.emp_name,
            this.emp_date,
            this.time_in,
            this.time_out});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportAttendance.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvImportAttendance.GridColor = System.Drawing.Color.Black;
            this.dgvImportAttendance.Location = new System.Drawing.Point(26, 161);
            this.dgvImportAttendance.Name = "dgvImportAttendance";
            this.dgvImportAttendance.ReadOnly = true;
            this.dgvImportAttendance.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportAttendance.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvImportAttendance.RowHeadersVisible = false;
            this.dgvImportAttendance.RowTemplate.Height = 30;
            this.dgvImportAttendance.Size = new System.Drawing.Size(975, 407);
            this.dgvImportAttendance.TabIndex = 1;
            this.dgvImportAttendance.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvImportAttendance.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvImportAttendance.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvImportAttendance.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvImportAttendance.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvImportAttendance.ThemeStyle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvImportAttendance.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvImportAttendance.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvImportAttendance.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvImportAttendance.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvImportAttendance.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvImportAttendance.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvImportAttendance.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvImportAttendance.ThemeStyle.ReadOnly = true;
            this.dgvImportAttendance.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvImportAttendance.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvImportAttendance.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvImportAttendance.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvImportAttendance.ThemeStyle.RowsStyle.Height = 30;
            this.dgvImportAttendance.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvImportAttendance.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.dgvImportAttendance;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.btnImport);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2CustomGradientPanel1.Controls.Add(this.dgvImportAttendance);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Silver;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1013, 593);
            this.guna2CustomGradientPanel1.TabIndex = 2;
            // 
            // btnImport
            // 
            this.btnImport.Animated = true;
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.BorderColor = System.Drawing.Color.Transparent;
            this.btnImport.BorderRadius = 10;
            this.btnImport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnImport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnImport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnImport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnImport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.btnImport.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(268, 112);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(104, 29);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Open File";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(26, 108);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(265, 36);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Import Attendance";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // emp_name
            // 
            this.emp_name.HeaderText = "Employee Name";
            this.emp_name.Name = "emp_name";
            this.emp_name.ReadOnly = true;
            // 
            // emp_date
            // 
            this.emp_date.HeaderText = "Date";
            this.emp_date.Name = "emp_date";
            this.emp_date.ReadOnly = true;
            // 
            // time_in
            // 
            this.time_in.HeaderText = "Time In";
            this.time_in.Name = "time_in";
            this.time_in.ReadOnly = true;
            // 
            // time_out
            // 
            this.time_out.HeaderText = "Time Out";
            this.time_out.Name = "time_out";
            this.time_out.ReadOnly = true;
            // 
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1013, 593);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAttendance";
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportAttendance)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvImportAttendance;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnImport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_out;
    }
}