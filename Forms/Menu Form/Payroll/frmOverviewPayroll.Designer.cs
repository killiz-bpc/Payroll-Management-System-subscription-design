namespace Payroll_Management_System.Forms.Menu_Form.Payroll
{
    partial class frmOverviewPayroll
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.tabInformation = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPersonal = new System.Windows.Forms.TabPage();
            this.panelPayslip = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.txtAttendanceBatch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDepartment = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLoad = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.dgvPayslip = new Guna.UI2.WinForms.Guna2DataGridView();
            this.emp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_more = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabWork = new System.Windows.Forms.TabPage();
            this.panelEmployment = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.tabOther = new System.Windows.Forms.TabPage();
            this.guna2GradientPanel4 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.guna2GradientPanel5 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            this.tabInformation.SuspendLayout();
            this.tabPersonal.SuspendLayout();
            this.panelPayslip.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.guna2GradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayslip)).BeginInit();
            this.tabWork.SuspendLayout();
            this.tabOther.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.tabInformation);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1200, 800);
            this.guna2GradientPanel1.TabIndex = 1;
            // 
            // tabInformation
            // 
            this.tabInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabInformation.Controls.Add(this.tabPersonal);
            this.tabInformation.Controls.Add(this.tabWork);
            this.tabInformation.Controls.Add(this.tabOther);
            this.tabInformation.Controls.Add(this.tabPage1);
            this.tabInformation.ItemSize = new System.Drawing.Size(180, 50);
            this.tabInformation.Location = new System.Drawing.Point(12, 75);
            this.tabInformation.Name = "tabInformation";
            this.tabInformation.SelectedIndex = 0;
            this.tabInformation.Size = new System.Drawing.Size(1173, 689);
            this.tabInformation.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabInformation.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.tabInformation.TabButtonHoverState.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.tabInformation.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabInformation.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.tabInformation.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabInformation.TabButtonIdleState.FillColor = System.Drawing.SystemColors.Control;
            this.tabInformation.TabButtonIdleState.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInformation.TabButtonIdleState.ForeColor = System.Drawing.Color.Black;
            this.tabInformation.TabButtonIdleState.InnerColor = System.Drawing.SystemColors.Control;
            this.tabInformation.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabInformation.TabButtonSelectedState.FillColor = System.Drawing.SystemColors.Control;
            this.tabInformation.TabButtonSelectedState.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInformation.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.tabInformation.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.tabInformation.TabButtonSize = new System.Drawing.Size(180, 50);
            this.tabInformation.TabIndex = 17;
            this.tabInformation.TabMenuBackColor = System.Drawing.SystemColors.Control;
            this.tabInformation.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPersonal
            // 
            this.tabPersonal.BackColor = System.Drawing.SystemColors.Control;
            this.tabPersonal.Controls.Add(this.panelPayslip);
            this.tabPersonal.Location = new System.Drawing.Point(4, 54);
            this.tabPersonal.Margin = new System.Windows.Forms.Padding(0);
            this.tabPersonal.Name = "tabPersonal";
            this.tabPersonal.Size = new System.Drawing.Size(1165, 631);
            this.tabPersonal.TabIndex = 0;
            this.tabPersonal.Text = "Payslips";
            // 
            // panelPayslip
            // 
            this.panelPayslip.BackColor = System.Drawing.SystemColors.Control;
            this.panelPayslip.Controls.Add(this.guna2GradientPanel2);
            this.panelPayslip.Controls.Add(this.guna2GradientPanel3);
            this.panelPayslip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPayslip.Location = new System.Drawing.Point(0, 0);
            this.panelPayslip.Name = "panelPayslip";
            this.panelPayslip.Size = new System.Drawing.Size(1165, 631);
            this.panelPayslip.TabIndex = 12;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientPanel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2GradientPanel2.Controls.Add(this.txtAttendanceBatch);
            this.guna2GradientPanel2.Controls.Add(this.guna2HtmlLabel6);
            this.guna2GradientPanel2.Controls.Add(this.txtDepartment);
            this.guna2GradientPanel2.Controls.Add(this.btnLoad);
            this.guna2GradientPanel2.Controls.Add(this.guna2HtmlLabel4);
            this.guna2GradientPanel2.Location = new System.Drawing.Point(8, 11);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(1149, 87);
            this.guna2GradientPanel2.TabIndex = 13;
            // 
            // txtAttendanceBatch
            // 
            this.txtAttendanceBatch.BackColor = System.Drawing.Color.Transparent;
            this.txtAttendanceBatch.BorderRadius = 10;
            this.txtAttendanceBatch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtAttendanceBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtAttendanceBatch.FocusedColor = System.Drawing.Color.Empty;
            this.txtAttendanceBatch.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttendanceBatch.ForeColor = System.Drawing.Color.Black;
            this.txtAttendanceBatch.ItemHeight = 30;
            this.txtAttendanceBatch.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.txtAttendanceBatch.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.txtAttendanceBatch.Location = new System.Drawing.Point(12, 37);
            this.txtAttendanceBatch.Name = "txtAttendanceBatch";
            this.txtAttendanceBatch.Size = new System.Drawing.Size(227, 36);
            this.txtAttendanceBatch.Sorted = true;
            this.txtAttendanceBatch.TabIndex = 30;
            this.txtAttendanceBatch.SelectedIndexChanged += new System.EventHandler(this.txtAttendanceBatch_SelectedIndexChanged);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(12, 15);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(210, 23);
            this.guna2HtmlLabel6.TabIndex = 22;
            this.guna2HtmlLabel6.Text = "Attendance Batch No.";
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
            this.txtDepartment.Location = new System.Drawing.Point(290, 37);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(226, 36);
            this.txtDepartment.Sorted = true;
            this.txtDepartment.TabIndex = 21;
            this.txtDepartment.SelectedIndexChanged += new System.EventHandler(this.txtDepartment_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnLoad.Location = new System.Drawing.Point(977, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(159, 47);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "&Load Data";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(290, 15);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(103, 23);
            this.guna2HtmlLabel4.TabIndex = 10;
            this.guna2HtmlLabel4.Text = "Department";
            // 
            // guna2GradientPanel3
            // 
            this.guna2GradientPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientPanel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2GradientPanel3.Controls.Add(this.dgvPayslip);
            this.guna2GradientPanel3.Location = new System.Drawing.Point(8, 113);
            this.guna2GradientPanel3.Name = "guna2GradientPanel3";
            this.guna2GradientPanel3.Size = new System.Drawing.Size(1149, 515);
            this.guna2GradientPanel3.TabIndex = 14;
            // 
            // dgvPayslip
            // 
            this.dgvPayslip.AllowUserToAddRows = false;
            this.dgvPayslip.AllowUserToDeleteRows = false;
            this.dgvPayslip.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPayslip.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayslip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayslip.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayslip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayslip.ColumnHeadersHeight = 30;
            this.dgvPayslip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPayslip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emp_id,
            this.employee_name,
            this.view_more});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayslip.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayslip.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPayslip.Location = new System.Drawing.Point(4, 6);
            this.dgvPayslip.Name = "dgvPayslip";
            this.dgvPayslip.ReadOnly = true;
            this.dgvPayslip.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayslip.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPayslip.RowHeadersVisible = false;
            this.dgvPayslip.RowTemplate.Height = 40;
            this.dgvPayslip.Size = new System.Drawing.Size(1141, 502);
            this.dgvPayslip.TabIndex = 3;
            this.dgvPayslip.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayslip.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayslip.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvPayslip.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPayslip.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPayslip.ThemeStyle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPayslip.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPayslip.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayslip.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPayslip.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayslip.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPayslip.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPayslip.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvPayslip.ThemeStyle.ReadOnly = true;
            this.dgvPayslip.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayslip.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPayslip.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayslip.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPayslip.ThemeStyle.RowsStyle.Height = 40;
            this.dgvPayslip.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPayslip.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPayslip.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayslip_CellContentClick);
            // 
            // emp_id
            // 
            this.emp_id.DataPropertyName = "emp_id";
            this.emp_id.FillWeight = 30.75713F;
            this.emp_id.HeaderText = "Employee ID";
            this.emp_id.Name = "emp_id";
            this.emp_id.ReadOnly = true;
            // 
            // employee_name
            // 
            this.employee_name.DataPropertyName = "employee_name";
            this.employee_name.HeaderText = "Employee Name";
            this.employee_name.Name = "employee_name";
            this.employee_name.ReadOnly = true;
            // 
            // view_more
            // 
            this.view_more.DataPropertyName = "view_more";
            this.view_more.FillWeight = 30.75713F;
            this.view_more.HeaderText = "Action";
            this.view_more.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.view_more.Name = "view_more";
            this.view_more.ReadOnly = true;
            this.view_more.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.view_more.Text = "View More";
            this.view_more.TrackVisitedState = false;
            this.view_more.UseColumnTextForLinkValue = true;
            // 
            // tabWork
            // 
            this.tabWork.BackColor = System.Drawing.SystemColors.Control;
            this.tabWork.Controls.Add(this.panelEmployment);
            this.tabWork.Location = new System.Drawing.Point(4, 54);
            this.tabWork.Name = "tabWork";
            this.tabWork.Padding = new System.Windows.Forms.Padding(3);
            this.tabWork.Size = new System.Drawing.Size(1165, 631);
            this.tabWork.TabIndex = 1;
            this.tabWork.Text = "Payroll";
            // 
            // panelEmployment
            // 
            this.panelEmployment.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelEmployment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEmployment.Location = new System.Drawing.Point(3, 3);
            this.panelEmployment.Name = "panelEmployment";
            this.panelEmployment.Size = new System.Drawing.Size(1159, 625);
            this.panelEmployment.TabIndex = 13;
            // 
            // tabOther
            // 
            this.tabOther.BackColor = System.Drawing.SystemColors.Control;
            this.tabOther.Controls.Add(this.guna2GradientPanel4);
            this.tabOther.Location = new System.Drawing.Point(4, 54);
            this.tabOther.Name = "tabOther";
            this.tabOther.Padding = new System.Windows.Forms.Padding(3);
            this.tabOther.Size = new System.Drawing.Size(1165, 631);
            this.tabOther.TabIndex = 2;
            this.tabOther.Text = "Other Allowances";
            // 
            // guna2GradientPanel4
            // 
            this.guna2GradientPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientPanel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2GradientPanel4.Location = new System.Drawing.Point(9, 6);
            this.guna2GradientPanel4.Name = "guna2GradientPanel4";
            this.guna2GradientPanel4.Size = new System.Drawing.Size(1150, 619);
            this.guna2GradientPanel4.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.guna2GradientPanel5);
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1165, 631);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Other Deductions";
            // 
            // guna2GradientPanel5
            // 
            this.guna2GradientPanel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2GradientPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel5.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel5.Name = "guna2GradientPanel5";
            this.guna2GradientPanel5.Size = new System.Drawing.Size(1165, 631);
            this.guna2GradientPanel5.TabIndex = 14;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(11, 47);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(299, 22);
            this.guna2HtmlLabel3.TabIndex = 11;
            this.guna2HtmlLabel3.Text = "Generate and monitor payroll for employees";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Payroll_Management_System.Properties.Resources.user;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(11, 16);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(24, 25);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 12;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Poppins Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(39, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(209, 36);
            this.guna2HtmlLabel1.TabIndex = 10;
            this.guna2HtmlLabel1.Text = "Payroll";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.tabInformation;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.guna2GradientPanel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.tabPersonal;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.guna2GradientPanel3;
            // 
            // frmOverviewPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOverviewPayroll";
            this.Text = "frmOverviewPayroll";
            this.Load += new System.EventHandler(this.frmOverviewPayroll_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.tabInformation.ResumeLayout(false);
            this.tabPersonal.ResumeLayout(false);
            this.panelPayslip.ResumeLayout(false);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayslip)).EndInit();
            this.tabWork.ResumeLayout(false);
            this.tabOther.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2ComboBox txtAttendanceBatch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2ComboBox txtDepartment;
        private Guna.UI2.WinForms.Guna2Button btnLoad;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TabControl tabInformation;
        private System.Windows.Forms.TabPage tabPersonal;
        private Guna.UI2.WinForms.Guna2GradientPanel panelPayslip;
        private System.Windows.Forms.TabPage tabWork;
        private Guna.UI2.WinForms.Guna2GradientPanel panelEmployment;
        private System.Windows.Forms.TabPage tabOther;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel4;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPayslip;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_name;
        private System.Windows.Forms.DataGridViewLinkColumn view_more;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel5;
    }
}