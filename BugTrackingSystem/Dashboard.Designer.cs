namespace BugTrackingSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.currentuser = new System.Windows.Forms.ToolStripMenuItem();
            this.guthubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BugEntry = new System.Windows.Forms.PictureBox();
            this.LogOut = new System.Windows.Forms.PictureBox();
            this.ProjectManage = new System.Windows.Forms.PictureBox();
            this.MemberManage = new System.Windows.Forms.PictureBox();
            this.UserManage = new System.Windows.Forms.PictureBox();
            this.NEPALFLAG = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUSerRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerBUGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bUGSolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel6 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BugEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectManage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberManage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserManage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NEPALFLAG)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(133, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1342, 91);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(291, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(400, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bug Tracking System";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentuser,
            this.guthubToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1014, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(261, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // currentuser
            // 
            this.currentuser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.currentuser.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentuser.Image = ((System.Drawing.Image)(resources.GetObject("currentuser.Image")));
            this.currentuser.Name = "currentuser";
            this.currentuser.Size = new System.Drawing.Size(151, 27);
            this.currentuser.Text = "Current User";
            // 
            // guthubToolStripMenuItem
            // 
            this.guthubToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.guthubToolStripMenuItem.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guthubToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guthubToolStripMenuItem.Image")));
            this.guthubToolStripMenuItem.Name = "guthubToolStripMenuItem";
            this.guthubToolStripMenuItem.Size = new System.Drawing.Size(102, 27);
            this.guthubToolStripMenuItem.Text = "Guthub";
            this.guthubToolStripMenuItem.Click += new System.EventHandler(this.guthubToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.BugEntry);
            this.panel2.Controls.Add(this.LogOut);
            this.panel2.Controls.Add(this.ProjectManage);
            this.panel2.Controls.Add(this.MemberManage);
            this.panel2.Controls.Add(this.UserManage);
            this.panel2.Controls.Add(this.NEPALFLAG);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 703);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(132, 129);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1409, 574);
            this.panel5.TabIndex = 5;
            // 
            // BugEntry
            // 
            this.BugEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BugEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BugEntry.Image = ((System.Drawing.Image)(resources.GetObject("BugEntry.Image")));
            this.BugEntry.InitialImage = null;
            this.BugEntry.Location = new System.Drawing.Point(5, 471);
            this.BugEntry.Name = "BugEntry";
            this.BugEntry.Size = new System.Drawing.Size(121, 110);
            this.BugEntry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BugEntry.TabIndex = 5;
            this.BugEntry.TabStop = false;
            this.BugEntry.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // LogOut
            // 
            this.LogOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogOut.Image = ((System.Drawing.Image)(resources.GetObject("LogOut.Image")));
            this.LogOut.Location = new System.Drawing.Point(5, 587);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(121, 110);
            this.LogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogOut.TabIndex = 4;
            this.LogOut.TabStop = false;
            this.LogOut.Tag = "Logout";
            this.LogOut.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // ProjectManage
            // 
            this.ProjectManage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProjectManage.Image = ((System.Drawing.Image)(resources.GetObject("ProjectManage.Image")));
            this.ProjectManage.InitialImage = null;
            this.ProjectManage.Location = new System.Drawing.Point(5, 355);
            this.ProjectManage.Name = "ProjectManage";
            this.ProjectManage.Size = new System.Drawing.Size(121, 110);
            this.ProjectManage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProjectManage.TabIndex = 3;
            this.ProjectManage.TabStop = false;
            this.ProjectManage.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // MemberManage
            // 
            this.MemberManage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MemberManage.Image = ((System.Drawing.Image)(resources.GetObject("MemberManage.Image")));
            this.MemberManage.Location = new System.Drawing.Point(5, 239);
            this.MemberManage.Name = "MemberManage";
            this.MemberManage.Size = new System.Drawing.Size(121, 110);
            this.MemberManage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MemberManage.TabIndex = 2;
            this.MemberManage.TabStop = false;
            this.MemberManage.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // UserManage
            // 
            this.UserManage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserManage.Image = ((System.Drawing.Image)(resources.GetObject("UserManage.Image")));
            this.UserManage.Location = new System.Drawing.Point(5, 122);
            this.UserManage.Name = "UserManage";
            this.UserManage.Size = new System.Drawing.Size(121, 110);
            this.UserManage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserManage.TabIndex = 1;
            this.UserManage.TabStop = false;
            this.UserManage.Tag = "HOME";
            this.UserManage.Click += new System.EventHandler(this.HOME_Click);
            // 
            // NEPALFLAG
            // 
            this.NEPALFLAG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NEPALFLAG.Image = ((System.Drawing.Image)(resources.GetObject("NEPALFLAG.Image")));
            this.NEPALFLAG.Location = new System.Drawing.Point(5, 6);
            this.NEPALFLAG.Name = "NEPALFLAG";
            this.NEPALFLAG.Size = new System.Drawing.Size(121, 110);
            this.NEPALFLAG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NEPALFLAG.TabIndex = 0;
            this.NEPALFLAG.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(-1, 703);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1473, 55);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(1319, 15);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(76, 31);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(461, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(717, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Design by Mahesh Prasad Timilsina | BSC. Computing, Level 6 | The British College" +
    "";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.menuStrip2);
            this.panel4.Location = new System.Drawing.Point(133, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1348, 42);
            this.panel4.TabIndex = 4;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.memberToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.bugToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1348, 41);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUSerRoleToolStripMenuItem,
            this.manageUserToolStripMenuItem});
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Segoe Marker", 13.8F, System.Drawing.FontStyle.Bold);
            this.userToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userToolStripMenuItem.Image")));
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(87, 37);
            this.userToolStripMenuItem.Text = "User";
            // 
            // manageUSerRoleToolStripMenuItem
            // 
            this.manageUSerRoleToolStripMenuItem.Font = new System.Drawing.Font("Segoe Marker", 13.8F, System.Drawing.FontStyle.Italic);
            this.manageUSerRoleToolStripMenuItem.Name = "manageUSerRoleToolStripMenuItem";
            this.manageUSerRoleToolStripMenuItem.Size = new System.Drawing.Size(246, 32);
            this.manageUSerRoleToolStripMenuItem.Text = "Manage User Role";
            this.manageUSerRoleToolStripMenuItem.Click += new System.EventHandler(this.manageUSerRoleToolStripMenuItem_Click);
            // 
            // manageUserToolStripMenuItem
            // 
            this.manageUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe Marker", 13.8F, System.Drawing.FontStyle.Italic);
            this.manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            this.manageUserToolStripMenuItem.Size = new System.Drawing.Size(246, 32);
            this.manageUserToolStripMenuItem.Text = "Manage User";
            this.manageUserToolStripMenuItem.Click += new System.EventHandler(this.manageUserToolStripMenuItem_Click);
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageMemberToolStripMenuItem});
            this.memberToolStripMenuItem.Font = new System.Drawing.Font("Segoe Marker", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("memberToolStripMenuItem.Image")));
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(123, 37);
            this.memberToolStripMenuItem.Text = "Member";
            // 
            // manageMemberToolStripMenuItem
            // 
            this.manageMemberToolStripMenuItem.Font = new System.Drawing.Font("Segoe Marker", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageMemberToolStripMenuItem.Name = "manageMemberToolStripMenuItem";
            this.manageMemberToolStripMenuItem.Size = new System.Drawing.Size(227, 32);
            this.manageMemberToolStripMenuItem.Text = "Member Details";
            this.manageMemberToolStripMenuItem.Click += new System.EventHandler(this.manageMemberToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageProjectToolStripMenuItem,
            this.assignMemberToolStripMenuItem});
            this.projectToolStripMenuItem.Font = new System.Drawing.Font("Segoe Marker", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("projectToolStripMenuItem.Image")));
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(112, 37);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // manageProjectToolStripMenuItem
            // 
            this.manageProjectToolStripMenuItem.Font = new System.Drawing.Font("Segoe Marker", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageProjectToolStripMenuItem.Name = "manageProjectToolStripMenuItem";
            this.manageProjectToolStripMenuItem.Size = new System.Drawing.Size(225, 32);
            this.manageProjectToolStripMenuItem.Text = "Manage Project";
            this.manageProjectToolStripMenuItem.Click += new System.EventHandler(this.manageProjectToolStripMenuItem_Click);
            // 
            // assignMemberToolStripMenuItem
            // 
            this.assignMemberToolStripMenuItem.Font = new System.Drawing.Font("Segoe Marker", 13.8F, System.Drawing.FontStyle.Italic);
            this.assignMemberToolStripMenuItem.Name = "assignMemberToolStripMenuItem";
            this.assignMemberToolStripMenuItem.Size = new System.Drawing.Size(225, 32);
            this.assignMemberToolStripMenuItem.Text = "Assign Member";
            this.assignMemberToolStripMenuItem.Click += new System.EventHandler(this.assignMemberToolStripMenuItem_Click);
            // 
            // bugToolStripMenuItem
            // 
            this.bugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerBUGToolStripMenuItem,
            this.bUGSolutionToolStripMenuItem});
            this.bugToolStripMenuItem.Font = new System.Drawing.Font("Segoe Marker", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bugToolStripMenuItem.Image")));
            this.bugToolStripMenuItem.Name = "bugToolStripMenuItem";
            this.bugToolStripMenuItem.Size = new System.Drawing.Size(81, 37);
            this.bugToolStripMenuItem.Text = "Bug";
            // 
            // registerBUGToolStripMenuItem
            // 
            this.registerBUGToolStripMenuItem.Font = new System.Drawing.Font("Segoe Marker", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBUGToolStripMenuItem.Name = "registerBUGToolStripMenuItem";
            this.registerBUGToolStripMenuItem.Size = new System.Drawing.Size(216, 32);
            this.registerBUGToolStripMenuItem.Text = "Register BUG";
            this.registerBUGToolStripMenuItem.Click += new System.EventHandler(this.registerBUGToolStripMenuItem_Click);
            // 
            // bUGSolutionToolStripMenuItem
            // 
            this.bUGSolutionToolStripMenuItem.Font = new System.Drawing.Font("Segoe Marker", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUGSolutionToolStripMenuItem.Name = "bUGSolutionToolStripMenuItem";
            this.bUGSolutionToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.bUGSolutionToolStripMenuItem.Text = "BUG Solution";
            this.bUGSolutionToolStripMenuItem.Click += new System.EventHandler(this.bUGSolutionToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Segoe Marker", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportToolStripMenuItem.Image")));
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(109, 37);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe Marker", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(98, 37);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe Marker", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(124, 37);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(133, 123);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1342, 581);
            this.panel6.TabIndex = 5;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1471, 757);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BugEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectManage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberManage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserManage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NEPALFLAG)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox LogOut;
        private System.Windows.Forms.PictureBox NEPALFLAG;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem manageUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bUGSolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ToolStripMenuItem manageUSerRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignMemberToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guthubToolStripMenuItem;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem currentuser;
        public System.Windows.Forms.PictureBox BugEntry;
        public System.Windows.Forms.PictureBox ProjectManage;
        public System.Windows.Forms.PictureBox MemberManage;
        public System.Windows.Forms.PictureBox UserManage;
        public System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem registerBUGToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}

