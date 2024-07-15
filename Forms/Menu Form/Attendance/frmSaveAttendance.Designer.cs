namespace Payroll_Management_System.Forms.Menu_Form.Attendance
{
    partial class frmSaveAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaveAttendance));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtAttendanceBatch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.isNewBatch = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtPeriod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.txtDateCreated = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPreparedBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDateTo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDateFrom = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtSeries = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtAttendanceBatch
            // 
            this.txtAttendanceBatch.BackColor = System.Drawing.Color.Transparent;
            this.txtAttendanceBatch.BorderRadius = 10;
            this.txtAttendanceBatch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtAttendanceBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtAttendanceBatch.FocusedColor = System.Drawing.Color.Empty;
            this.txtAttendanceBatch.Font = new System.Drawing.Font("Poppins", 9F);
            this.txtAttendanceBatch.ForeColor = System.Drawing.Color.Black;
            this.txtAttendanceBatch.ItemHeight = 30;
            this.txtAttendanceBatch.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.txtAttendanceBatch.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.txtAttendanceBatch.Location = new System.Drawing.Point(41, 110);
            this.txtAttendanceBatch.Name = "txtAttendanceBatch";
            this.txtAttendanceBatch.Size = new System.Drawing.Size(334, 36);
            this.txtAttendanceBatch.Sorted = true;
            this.txtAttendanceBatch.TabIndex = 20;
            this.txtAttendanceBatch.SelectedIndexChanged += new System.EventHandler(this.txtAttendanceBatch_SelectedIndexChanged);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(41, 88);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(151, 23);
            this.guna2HtmlLabel4.TabIndex = 19;
            this.guna2HtmlLabel4.Text = "Attendance Batch No.";
            // 
            // isNewBatch
            // 
            this.isNewBatch.Animated = true;
            this.isNewBatch.AutoSize = true;
            this.isNewBatch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.isNewBatch.CheckedState.BorderRadius = 0;
            this.isNewBatch.CheckedState.BorderThickness = 0;
            this.isNewBatch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.isNewBatch.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isNewBatch.Location = new System.Drawing.Point(198, 88);
            this.isNewBatch.Name = "isNewBatch";
            this.isNewBatch.Size = new System.Drawing.Size(97, 23);
            this.isNewBatch.TabIndex = 33;
            this.isNewBatch.Text = "Save as New";
            this.isNewBatch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.isNewBatch.UncheckedState.BorderRadius = 0;
            this.isNewBatch.UncheckedState.BorderThickness = 0;
            this.isNewBatch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.isNewBatch.CheckedChanged += new System.EventHandler(this.isNewBatch_CheckedChanged);
            // 
            // txtPeriod
            // 
            this.txtPeriod.BackColor = System.Drawing.Color.Transparent;
            this.txtPeriod.BorderRadius = 10;
            this.txtPeriod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPeriod.FocusedColor = System.Drawing.Color.Empty;
            this.txtPeriod.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriod.ForeColor = System.Drawing.Color.Black;
            this.txtPeriod.ItemHeight = 30;
            this.txtPeriod.Items.AddRange(new object[] {
            "(1) First cut-off of the month",
            "(2) Second cut-off of the month"});
            this.txtPeriod.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.txtPeriod.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.txtPeriod.Location = new System.Drawing.Point(41, 173);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(334, 36);
            this.txtPeriod.Sorted = true;
            this.txtPeriod.TabIndex = 35;
            this.txtPeriod.SelectedIndexChanged += new System.EventHandler(this.txtPeriod_SelectedIndexChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(41, 152);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(173, 23);
            this.guna2HtmlLabel1.TabIndex = 34;
            this.guna2HtmlLabel1.Text = "Period of the Month";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BorderRadius = 2;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(380, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 29);
            this.btnClose.TabIndex = 36;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.txtSeries);
            this.guna2GradientPanel1.Controls.Add(this.txtDateCreated);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel8);
            this.guna2GradientPanel1.Controls.Add(this.txtPreparedBy);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2GradientPanel1.Controls.Add(this.txtDateTo);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2GradientPanel1.Controls.Add(this.txtDateFrom);
            this.guna2GradientPanel1.Controls.Add(this.btnSave);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GradientPanel1.Controls.Add(this.txtAttendanceBatch);
            this.guna2GradientPanel1.Controls.Add(this.btnClose);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2GradientPanel1.Controls.Add(this.txtPeriod);
            this.guna2GradientPanel1.Controls.Add(this.isNewBatch);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.guna2GradientPanel1.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(424, 505);
            this.guna2GradientPanel1.TabIndex = 37;
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
            this.txtDateCreated.Location = new System.Drawing.Point(41, 309);
            this.txtDateCreated.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.PasswordChar = '\0';
            this.txtDateCreated.PlaceholderText = "Date Created";
            this.txtDateCreated.SelectedText = "";
            this.txtDateCreated.Size = new System.Drawing.Size(334, 36);
            this.txtDateCreated.TabIndex = 56;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.AutoSize = false;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(41, 288);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(97, 23);
            this.guna2HtmlLabel8.TabIndex = 57;
            this.guna2HtmlLabel8.Text = "Date Created";
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
            this.txtPreparedBy.Location = new System.Drawing.Point(41, 373);
            this.txtPreparedBy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPreparedBy.Name = "txtPreparedBy";
            this.txtPreparedBy.PasswordChar = '\0';
            this.txtPreparedBy.PlaceholderText = "Prepared by";
            this.txtPreparedBy.SelectedText = "";
            this.txtPreparedBy.Size = new System.Drawing.Size(334, 36);
            this.txtPreparedBy.TabIndex = 55;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.AutoSize = false;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(39, 352);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(97, 23);
            this.guna2HtmlLabel7.TabIndex = 54;
            this.guna2HtmlLabel7.Text = "Prepared by";
            // 
            // txtDateTo
            // 
            this.txtDateTo.BorderRadius = 8;
            this.txtDateTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDateTo.DefaultText = "";
            this.txtDateTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDateTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDateTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDateTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDateTo.Enabled = false;
            this.txtDateTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDateTo.Font = new System.Drawing.Font("Poppins", 9F);
            this.txtDateTo.ForeColor = System.Drawing.Color.Black;
            this.txtDateTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDateTo.Location = new System.Drawing.Point(224, 236);
            this.txtDateTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.PasswordChar = '\0';
            this.txtDateTo.PlaceholderText = "Date To";
            this.txtDateTo.SelectedText = "";
            this.txtDateTo.Size = new System.Drawing.Size(151, 36);
            this.txtDateTo.TabIndex = 52;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(224, 215);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(97, 23);
            this.guna2HtmlLabel6.TabIndex = 53;
            this.guna2HtmlLabel6.Text = "Date To";
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.BorderRadius = 8;
            this.txtDateFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDateFrom.DefaultText = "";
            this.txtDateFrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDateFrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDateFrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDateFrom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDateFrom.Enabled = false;
            this.txtDateFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDateFrom.Font = new System.Drawing.Font("Poppins", 9F);
            this.txtDateFrom.ForeColor = System.Drawing.Color.Black;
            this.txtDateFrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDateFrom.Location = new System.Drawing.Point(41, 236);
            this.txtDateFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.PasswordChar = '\0';
            this.txtDateFrom.PlaceholderText = "Date From";
            this.txtDateFrom.SelectedText = "";
            this.txtDateFrom.Size = new System.Drawing.Size(151, 36);
            this.txtDateFrom.TabIndex = 49;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Animated = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 10;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.btnSave.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(41, 433);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(334, 34);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(13, 38);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(353, 22);
            this.guna2HtmlLabel3.TabIndex = 38;
            this.guna2HtmlLabel3.Text = "Provide attendance information";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Poppins Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(13, 12);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(265, 36);
            this.guna2HtmlLabel2.TabIndex = 37;
            this.guna2HtmlLabel2.Text = "Save Attendance";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(41, 215);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(97, 23);
            this.guna2HtmlLabel5.TabIndex = 51;
            this.guna2HtmlLabel5.Text = "Date From";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.txtSeries.Location = new System.Drawing.Point(63, 60);
            this.txtSeries.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.PasswordChar = '\0';
            this.txtSeries.PlaceholderText = "Series No.";
            this.txtSeries.SelectedText = "";
            this.txtSeries.Size = new System.Drawing.Size(274, 21);
            this.txtSeries.TabIndex = 58;
            this.txtSeries.Visible = false;
            // 
            // frmSaveAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(424, 505);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSaveAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSaveAttendance";
            this.Load += new System.EventHandler(this.frmSaveAttendance_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ComboBox txtAttendanceBatch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2CheckBox isNewBatch;
        private Guna.UI2.WinForms.Guna2ComboBox txtPeriod;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtPreparedBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2TextBox txtDateTo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox txtDateFrom;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtDateCreated;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2TextBox txtSeries;
    }
}