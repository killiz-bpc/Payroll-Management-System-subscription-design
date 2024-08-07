namespace Payroll_Management_System.Forms.Menu_Form.Payroll
{
    partial class frmGeneratePayroll
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelEmployeeDetails = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.dgvPayroll = new Guna.UI2.WinForms.Guna2DataGridView();
            this.emp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basic_salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gross_salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_deductions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.net_salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_more = new System.Windows.Forms.DataGridViewLinkColumn();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnLoad = new Guna.UI2.WinForms.Guna2Button();
            this.txtAttendanceBatch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSeries = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDateFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDateCreated = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPreparedBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDepartment = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel19 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            this.panelEmployeeDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).BeginInit();
            this.guna2GradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.panelEmployeeDetails);
            this.guna2GradientPanel1.Controls.Add(this.btnBack);
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientPanel2);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1200, 800);
            this.guna2GradientPanel1.TabIndex = 14;
            // 
            // panelEmployeeDetails
            // 
            this.panelEmployeeDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEmployeeDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelEmployeeDetails.Controls.Add(this.dgvPayroll);
            this.panelEmployeeDetails.Controls.Add(this.guna2HtmlLabel5);
            this.panelEmployeeDetails.Location = new System.Drawing.Point(28, 335);
            this.panelEmployeeDetails.Name = "panelEmployeeDetails";
            this.panelEmployeeDetails.Size = new System.Drawing.Size(1140, 453);
            this.panelEmployeeDetails.TabIndex = 19;
            // 
            // dgvPayroll
            // 
            this.dgvPayroll.AllowUserToAddRows = false;
            this.dgvPayroll.AllowUserToDeleteRows = false;
            this.dgvPayroll.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPayroll.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayroll.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayroll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayroll.ColumnHeadersHeight = 30;
            this.dgvPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPayroll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emp_id,
            this.dataGridViewTextBoxColumn2,
            this.job_title,
            this.basic_salary,
            this.gross_salary,
            this.total_deductions,
            this.net_salary,
            this.view_more});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayroll.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPayroll.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPayroll.Location = new System.Drawing.Point(16, 52);
            this.dgvPayroll.Name = "dgvPayroll";
            this.dgvPayroll.ReadOnly = true;
            this.dgvPayroll.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayroll.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPayroll.RowHeadersVisible = false;
            this.dgvPayroll.RowTemplate.Height = 40;
            this.dgvPayroll.Size = new System.Drawing.Size(1121, 392);
            this.dgvPayroll.TabIndex = 158;
            this.dgvPayroll.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayroll.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayroll.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvPayroll.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPayroll.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPayroll.ThemeStyle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPayroll.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPayroll.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayroll.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPayroll.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayroll.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPayroll.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPayroll.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvPayroll.ThemeStyle.ReadOnly = true;
            this.dgvPayroll.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayroll.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPayroll.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayroll.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPayroll.ThemeStyle.RowsStyle.Height = 40;
            this.dgvPayroll.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPayroll.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPayroll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayroll_CellContentClick);
            this.dgvPayroll.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayroll_CellContentDoubleClick);
            // 
            // emp_id
            // 
            this.emp_id.DataPropertyName = "emp_id";
            this.emp_id.FillWeight = 30.75713F;
            this.emp_id.HeaderText = "Employee ID";
            this.emp_id.Name = "emp_id";
            this.emp_id.ReadOnly = true;
            this.emp_id.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "employee_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Employee Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // job_title
            // 
            this.job_title.DataPropertyName = "job_title";
            this.job_title.HeaderText = "Job Title";
            this.job_title.Name = "job_title";
            this.job_title.ReadOnly = true;
            // 
            // basic_salary
            // 
            this.basic_salary.DataPropertyName = "basic_salary";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.basic_salary.DefaultCellStyle = dataGridViewCellStyle3;
            this.basic_salary.HeaderText = "Basic Salary";
            this.basic_salary.Name = "basic_salary";
            this.basic_salary.ReadOnly = true;
            // 
            // gross_salary
            // 
            this.gross_salary.DataPropertyName = "gross_salary";
            dataGridViewCellStyle4.Format = "C2";
            this.gross_salary.DefaultCellStyle = dataGridViewCellStyle4;
            this.gross_salary.HeaderText = "Gross Salary";
            this.gross_salary.Name = "gross_salary";
            this.gross_salary.ReadOnly = true;
            // 
            // total_deductions
            // 
            this.total_deductions.DataPropertyName = "total_deductions";
            dataGridViewCellStyle5.Format = "C2";
            this.total_deductions.DefaultCellStyle = dataGridViewCellStyle5;
            this.total_deductions.HeaderText = "Deduction";
            this.total_deductions.Name = "total_deductions";
            this.total_deductions.ReadOnly = true;
            // 
            // net_salary
            // 
            this.net_salary.DataPropertyName = "net_salary";
            dataGridViewCellStyle6.Format = "C2";
            this.net_salary.DefaultCellStyle = dataGridViewCellStyle6;
            this.net_salary.HeaderText = "Net Salary";
            this.net_salary.Name = "net_salary";
            this.net_salary.ReadOnly = true;
            // 
            // view_more
            // 
            this.view_more.DataPropertyName = "view_more";
            this.view_more.FillWeight = 45F;
            this.view_more.HeaderText = "Action";
            this.view_more.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.view_more.Name = "view_more";
            this.view_more.ReadOnly = true;
            this.view_more.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.view_more.Text = "View More";
            this.view_more.TrackVisitedState = false;
            this.view_more.UseColumnTextForLinkValue = true;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(17, 19);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(217, 27);
            this.guna2HtmlLabel5.TabIndex = 157;
            this.guna2HtmlLabel5.Text = "Employee Details";
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderRadius = 10;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.SystemColors.Control;
            this.btnBack.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.btnBack.Location = new System.Drawing.Point(12, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 29);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "< Back";
            this.btnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBack.UseTransparentBackground = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientPanel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2GradientPanel2.Controls.Add(this.btnLoad);
            this.guna2GradientPanel2.Controls.Add(this.txtAttendanceBatch);
            this.guna2GradientPanel2.Controls.Add(this.guna2HtmlLabel6);
            this.guna2GradientPanel2.Controls.Add(this.txtSeries);
            this.guna2GradientPanel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GradientPanel2.Controls.Add(this.txtDateFrom);
            this.guna2GradientPanel2.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GradientPanel2.Controls.Add(this.txtDateCreated);
            this.guna2GradientPanel2.Controls.Add(this.guna2HtmlLabel8);
            this.guna2GradientPanel2.Controls.Add(this.txtPreparedBy);
            this.guna2GradientPanel2.Controls.Add(this.guna2HtmlLabel7);
            this.guna2GradientPanel2.Controls.Add(this.txtDepartment);
            this.guna2GradientPanel2.Controls.Add(this.guna2HtmlLabel4);
            this.guna2GradientPanel2.Controls.Add(this.guna2HtmlLabel19);
            this.guna2GradientPanel2.Location = new System.Drawing.Point(28, 40);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(1140, 270);
            this.guna2GradientPanel2.TabIndex = 10;
            // 
            // btnLoad
            // 
            this.btnLoad.Animated = true;
            this.btnLoad.BackColor = System.Drawing.Color.Transparent;
            this.btnLoad.BorderColor = System.Drawing.Color.Transparent;
            this.btnLoad.BorderRadius = 10;
            this.btnLoad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.btnLoad.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(17, 215);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(227, 37);
            this.btnLoad.TabIndex = 176;
            this.btnLoad.Text = "&Load Data";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtAttendanceBatch
            // 
            this.txtAttendanceBatch.BackColor = System.Drawing.Color.Transparent;
            this.txtAttendanceBatch.BorderRadius = 10;
            this.txtAttendanceBatch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtAttendanceBatch.DropDownHeight = 250;
            this.txtAttendanceBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtAttendanceBatch.FocusedColor = System.Drawing.Color.Empty;
            this.txtAttendanceBatch.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttendanceBatch.ForeColor = System.Drawing.Color.Black;
            this.txtAttendanceBatch.IntegralHeight = false;
            this.txtAttendanceBatch.ItemHeight = 30;
            this.txtAttendanceBatch.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.txtAttendanceBatch.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.txtAttendanceBatch.Location = new System.Drawing.Point(17, 73);
            this.txtAttendanceBatch.MaxDropDownItems = 10;
            this.txtAttendanceBatch.Name = "txtAttendanceBatch";
            this.txtAttendanceBatch.Size = new System.Drawing.Size(227, 36);
            this.txtAttendanceBatch.Sorted = true;
            this.txtAttendanceBatch.TabIndex = 175;
            this.txtAttendanceBatch.SelectedIndexChanged += new System.EventHandler(this.txtAttendanceBatch_SelectedIndexChanged);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(16, 52);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(210, 23);
            this.guna2HtmlLabel6.TabIndex = 174;
            this.guna2HtmlLabel6.Text = "Attendance Batch No.";
            // 
            // txtSeries
            // 
            this.txtSeries.BorderRadius = 8;
            this.txtSeries.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSeries.DefaultText = "";
            this.txtSeries.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSeries.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSeries.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeries.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeries.Enabled = false;
            this.txtSeries.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeries.Font = new System.Drawing.Font("Poppins", 9F);
            this.txtSeries.ForeColor = System.Drawing.Color.Black;
            this.txtSeries.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeries.Location = new System.Drawing.Point(17, 143);
            this.txtSeries.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.PasswordChar = '\0';
            this.txtSeries.PlaceholderText = "Attendance No.";
            this.txtSeries.SelectedText = "";
            this.txtSeries.Size = new System.Drawing.Size(227, 36);
            this.txtSeries.TabIndex = 172;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(15, 122);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(151, 23);
            this.guna2HtmlLabel1.TabIndex = 171;
            this.guna2HtmlLabel1.Text = "Payroll Batch No.";
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.BorderRadius = 5;
            this.txtDateFrom.Checked = true;
            this.txtDateFrom.CustomFormat = "yyyy-MM-dd";
            this.txtDateFrom.FillColor = System.Drawing.Color.White;
            this.txtDateFrom.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDateFrom.Location = new System.Drawing.Point(647, 73);
            this.txtDateFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtDateFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.Size = new System.Drawing.Size(291, 36);
            this.txtDateFrom.TabIndex = 168;
            this.txtDateFrom.Value = new System.DateTime(2024, 7, 1, 14, 6, 29, 436);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(647, 52);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(97, 23);
            this.guna2HtmlLabel2.TabIndex = 167;
            this.guna2HtmlLabel2.Text = "Payment Date";
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.BorderRadius = 8;
            this.txtDateCreated.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDateCreated.DefaultText = "";
            this.txtDateCreated.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDateCreated.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDateCreated.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDateCreated.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDateCreated.Enabled = false;
            this.txtDateCreated.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDateCreated.Font = new System.Drawing.Font("Poppins", 9F);
            this.txtDateCreated.ForeColor = System.Drawing.Color.Black;
            this.txtDateCreated.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDateCreated.Location = new System.Drawing.Point(647, 143);
            this.txtDateCreated.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.PasswordChar = '\0';
            this.txtDateCreated.PlaceholderText = "Date Created";
            this.txtDateCreated.SelectedText = "";
            this.txtDateCreated.Size = new System.Drawing.Size(291, 36);
            this.txtDateCreated.TabIndex = 165;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.AutoSize = false;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(647, 122);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(182, 23);
            this.guna2HtmlLabel8.TabIndex = 166;
            this.guna2HtmlLabel8.Text = "Date Generated";
            // 
            // txtPreparedBy
            // 
            this.txtPreparedBy.BorderRadius = 8;
            this.txtPreparedBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPreparedBy.DefaultText = "";
            this.txtPreparedBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPreparedBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPreparedBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPreparedBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPreparedBy.Enabled = false;
            this.txtPreparedBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPreparedBy.Font = new System.Drawing.Font("Poppins", 9F);
            this.txtPreparedBy.ForeColor = System.Drawing.Color.Black;
            this.txtPreparedBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPreparedBy.Location = new System.Drawing.Point(277, 143);
            this.txtPreparedBy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPreparedBy.Name = "txtPreparedBy";
            this.txtPreparedBy.PasswordChar = '\0';
            this.txtPreparedBy.PlaceholderText = "Prepared by";
            this.txtPreparedBy.SelectedText = "";
            this.txtPreparedBy.Size = new System.Drawing.Size(334, 36);
            this.txtPreparedBy.TabIndex = 164;
            this.txtPreparedBy.TextChanged += new System.EventHandler(this.txtPreparedBy_TextChanged);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.AutoSize = false;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(275, 122);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(122, 23);
            this.guna2HtmlLabel7.TabIndex = 163;
            this.guna2HtmlLabel7.Text = "Prepared by";
            // 
            // txtDepartment
            // 
            this.txtDepartment.BackColor = System.Drawing.Color.Transparent;
            this.txtDepartment.BorderRadius = 10;
            this.txtDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDepartment.FocusedColor = System.Drawing.Color.Empty;
            this.txtDepartment.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.ForeColor = System.Drawing.Color.Black;
            this.txtDepartment.ItemHeight = 30;
            this.txtDepartment.Items.AddRange(new object[] {
            ""});
            this.txtDepartment.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.txtDepartment.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.txtDepartment.Location = new System.Drawing.Point(277, 73);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(334, 36);
            this.txtDepartment.Sorted = true;
            this.txtDepartment.TabIndex = 162;
            this.txtDepartment.SelectedIndexChanged += new System.EventHandler(this.txtDepartment_SelectedIndexChanged);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(277, 51);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(103, 23);
            this.guna2HtmlLabel4.TabIndex = 161;
            this.guna2HtmlLabel4.Text = "Department";
            // 
            // guna2HtmlLabel19
            // 
            this.guna2HtmlLabel19.AutoSize = false;
            this.guna2HtmlLabel19.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel19.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel19.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel19.Location = new System.Drawing.Point(17, 17);
            this.guna2HtmlLabel19.Name = "guna2HtmlLabel19";
            this.guna2HtmlLabel19.Size = new System.Drawing.Size(217, 27);
            this.guna2HtmlLabel19.TabIndex = 156;
            this.guna2HtmlLabel19.Text = "Generate Payroll";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.guna2GradientPanel1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.guna2GradientPanel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panelEmployeeDetails;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmGeneratePayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGeneratePayroll";
            this.Text = "frmGeneratePayroll";
            this.Load += new System.EventHandler(this.frmGeneratePayroll_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.panelEmployeeDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).EndInit();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel panelEmployeeDetails;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel19;
        private Guna.UI2.WinForms.Guna2ComboBox txtDepartment;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtDateCreated;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2TextBox txtPreparedBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtDateFrom;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtSeries;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPayroll;
        private Guna.UI2.WinForms.Guna2ComboBox txtAttendanceBatch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2Button btnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn basic_salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn gross_salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_deductions;
        private System.Windows.Forms.DataGridViewTextBoxColumn net_salary;
        private System.Windows.Forms.DataGridViewLinkColumn view_more;
        private System.Windows.Forms.Timer timer1;
    }
}