﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace BugTrackingSystem
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        UserClass uc = new UserClass();
        BugSolutionClass BSC = new BugSolutionClass();
        RegisterBugSolution RBS = new RegisterBugSolution();
        Dashboard DAS = new Dashboard();


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  this.Hide();
            //  Dashboard DAS = new Dashboard();
            //    DAS.Show();
            try
            {
                DataTable result = uc.userType(txtUserName.Text, txtPassword.Text);
                String Role = result.Rows[0]["userRole"].ToString();

                if (Role == "Project Manager")
                {
                    DAS.currentuser.Text = txtUserName.Text;
                    this.Hide();
                    DAS.Show();
                }
                if (Role == "Developer")
                {
                    DAS.userToolStripMenuItem.Enabled = false;
                    DAS.memberToolStripMenuItem.Enabled = false;
                    DAS.UserManage.Enabled = false;
                    DAS.MemberManage.Enabled = false;
                    this.Hide();
                    DAS.currentuser.Text = txtUserName.Text;
                    DAS.Show();
                }
                if (Role == "Tester")
                {
                    DAS.userToolStripMenuItem.Enabled = false;
                    DAS.memberToolStripMenuItem.Enabled = false;
                    DAS.projectToolStripMenuItem.Enabled = false;
                    DAS.registerBUGToolStripMenuItem.Enabled = false;
                    DAS.UserManage.Enabled = false;
                    DAS.MemberManage.Enabled = false;
                    DAS.BugEntry.Enabled = false;
                    DAS.Show();
                    DAS.currentuser.Text = txtUserName.Text;
                    this.Hide();
                    RBS.btnAdd.Visible = false;
                    RBS.btnUpdate.Visible = false;
                    RBS.btnDel.Visible = false;
                

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid User Name or Password");
            }
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;

            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
