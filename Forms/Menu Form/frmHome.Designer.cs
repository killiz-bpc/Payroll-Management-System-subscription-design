﻿namespace Payroll_Management_System.Forms.Menu_Form
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelLeft = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelButtons = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnPayroll = new Guna.UI2.WinForms.Guna2Button();
            this.btnAttendance = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployees = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel4 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelMain = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnMin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMax = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelLeft.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.guna2GradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelLeft.Controls.Add(this.panelButtons);
            this.panelLeft.Controls.Add(this.guna2GradientPanel4);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 29);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(199, 810);
            this.panelLeft.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelButtons.Controls.Add(this.btnLogout);
            this.panelButtons.Controls.Add(this.btnPayroll);
            this.panelButtons.Controls.Add(this.btnAttendance);
            this.panelButtons.Controls.Add(this.btnEmployees);
            this.panelButtons.Controls.Add(this.btnDashboard);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(0, 72);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(199, 738);
            this.panelButtons.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnLogout.Location = new System.Drawing.Point(0, 685);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.btnLogout.PressedDepth = 50;
            this.btnLogout.Size = new System.Drawing.Size(199, 53);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.TextOffset = new System.Drawing.Point(30, 0);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPayroll
            // 
            this.btnPayroll.Animated = true;
            this.btnPayroll.BackColor = System.Drawing.Color.Transparent;
            this.btnPayroll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPayroll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPayroll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPayroll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPayroll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayroll.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPayroll.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPayroll.ForeColor = System.Drawing.Color.Black;
            this.btnPayroll.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.btnPayroll.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnPayroll.Image = ((System.Drawing.Image)(resources.GetObject("btnPayroll.Image")));
            this.btnPayroll.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPayroll.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnPayroll.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPayroll.Location = new System.Drawing.Point(0, 159);
            this.btnPayroll.Name = "btnPayroll";
            this.btnPayroll.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.btnPayroll.PressedDepth = 50;
            this.btnPayroll.Size = new System.Drawing.Size(199, 53);
            this.btnPayroll.TabIndex = 7;
            this.btnPayroll.Text = "Payroll";
            this.btnPayroll.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPayroll.TextOffset = new System.Drawing.Point(22, 0);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Animated = true;
            this.btnAttendance.BackColor = System.Drawing.Color.Transparent;
            this.btnAttendance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAttendance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAttendance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAttendance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttendance.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAttendance.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAttendance.ForeColor = System.Drawing.Color.Black;
            this.btnAttendance.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.btnAttendance.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Image = ((System.Drawing.Image)(resources.GetObject("btnAttendance.Image")));
            this.btnAttendance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAttendance.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnAttendance.Location = new System.Drawing.Point(0, 106);
            this.btnAttendance.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.btnAttendance.PressedDepth = 50;
            this.btnAttendance.Size = new System.Drawing.Size(199, 53);
            this.btnAttendance.TabIndex = 6;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAttendance.TextOffset = new System.Drawing.Point(25, 0);
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Animated = true;
            this.btnEmployees.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployees.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployees.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmployees.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEmployees.ForeColor = System.Drawing.Color.Black;
            this.btnEmployees.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.btnEmployees.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployees.Image")));
            this.btnEmployees.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployees.ImageOffset = new System.Drawing.Point(14, 0);
            this.btnEmployees.ImageSize = new System.Drawing.Size(25, 25);
            this.btnEmployees.Location = new System.Drawing.Point(0, 53);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.btnEmployees.PressedDepth = 50;
            this.btnEmployees.Size = new System.Drawing.Size(199, 53);
            this.btnEmployees.TabIndex = 5;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployees.TextOffset = new System.Drawing.Point(20, 0);
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Animated = true;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashboard.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.btnDashboard.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.btnDashboard.PressedDepth = 50;
            this.btnDashboard.Size = new System.Drawing.Size(199, 53);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.TextOffset = new System.Drawing.Point(25, 0);
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // guna2GradientPanel4
            // 
            this.guna2GradientPanel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2GradientPanel4.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GradientPanel4.Controls.Add(this.guna2CirclePictureBox2);
            this.guna2GradientPanel4.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GradientPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel4.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel4.Name = "guna2GradientPanel4";
            this.guna2GradientPanel4.Size = new System.Drawing.Size(199, 72);
            this.guna2GradientPanel4.TabIndex = 2;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(60, 37);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(117, 19);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "Junior Programmer";
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Image = global::Payroll_Management_System.Properties.Resources.user;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(21, 18);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(36, 36);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 2;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(34)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(60, 17);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(117, 23);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Vidal, Cleeve";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(199, 29);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1124, 810);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel2_Paint);
            this.panelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2GradientPanel2_MouseMove);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.guna2CirclePictureBox3);
            this.panelTop.Controls.Add(this.btnMin);
            this.panelTop.Controls.Add(this.btnMax);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1323, 29);
            this.panelTop.TabIndex = 0;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_top_Paint);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Payroll Management System";
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox3.Image")));
            this.guna2CirclePictureBox3.ImageRotate = 0F;
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(5, 4);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(23, 20);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox3.TabIndex = 7;
            this.guna2CirclePictureBox3.TabStop = false;
            // 
            // btnMin
            // 
            this.btnMin.BorderRadius = 2;
            this.btnMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FillColor = System.Drawing.Color.Transparent;
            this.btnMin.IconColor = System.Drawing.Color.Black;
            this.btnMin.Location = new System.Drawing.Point(1233, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 29);
            this.btnMin.TabIndex = 6;
            // 
            // btnMax
            // 
            this.btnMax.BorderRadius = 2;
            this.btnMax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FillColor = System.Drawing.Color.Transparent;
            this.btnMax.IconColor = System.Drawing.Color.Black;
            this.btnMax.Location = new System.Drawing.Point(1263, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(30, 29);
            this.btnMax.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 2;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1293, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 29);
            this.btnClose.TabIndex = 4;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1323, 839);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.guna2GradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel panelMain;
        private Guna.UI2.WinForms.Guna2GradientPanel panelLeft;
        private Guna.UI2.WinForms.Guna2GradientPanel panelButtons;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel4;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2ControlBox btnMin;
        private Guna.UI2.WinForms.Guna2ControlBox btnMax;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button btnPayroll;
        private Guna.UI2.WinForms.Guna2Button btnAttendance;
        private Guna.UI2.WinForms.Guna2Button btnEmployees;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
    }
}