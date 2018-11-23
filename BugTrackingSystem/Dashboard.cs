using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DataAccessLayer;
namespace BugTrackingSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        UserClass UC = new UserClass();
        public String UserType;


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //its for current date
            lblTime.Text = DateTime.Now.ToLongTimeString();
            //tooltip to display the name of object
            //DataTable dtt = UC.GetUserTypeByUserName(currentuser.Text);
            //UserType = Convert.ToString(dtt.Rows[0]["userRoleId"].ToString());
            
            ToolTip userToolTip = new ToolTip();
            userToolTip.ToolTipTitle = "Manage User";
            userToolTip.UseFading = true;
            userToolTip.UseAnimation = true;
            userToolTip.IsBalloon = true;
            userToolTip.ShowAlways = true;
            userToolTip.AutoPopDelay = 5000;
            userToolTip.InitialDelay = 1000;
            userToolTip.ReshowDelay = 500;
            userToolTip.SetToolTip(UserManage, "Click me to execute.");

            ToolTip member = new ToolTip();
            member.ToolTipTitle = "Manage Member";
            member.UseFading = true;
            member.UseAnimation = true;
            member.IsBalloon = true;
            member.ShowAlways = true;
            member.AutoPopDelay = 5000;
            member.InitialDelay = 1000;
            member.ReshowDelay = 500;
            member.SetToolTip(MemberManage, "Click me to execute.");


            ToolTip Project = new ToolTip();
            Project.ToolTipTitle = "Manage Project";
            Project.UseFading = true;
            Project.UseAnimation = true;
            Project.IsBalloon = true;
            Project.ShowAlways = true;
            Project.AutoPopDelay = 5000;
            Project.InitialDelay = 1000;
            Project.ReshowDelay = 500;
            Project.SetToolTip(ProjectManage, "Click me to execute.");

            ToolTip Bugentry= new ToolTip();
            Bugentry.ToolTipTitle = "Enter New Bug";
            Bugentry.UseFading = true;
            Bugentry.UseAnimation = true;
            Bugentry.IsBalloon = true;
            Bugentry.ShowAlways = true;
            Bugentry.AutoPopDelay = 5000;
            Bugentry.InitialDelay = 1000;
            Bugentry.ReshowDelay = 500;
            Bugentry.SetToolTip(BugEntry, "Click me to execute.");

            ToolTip Logout = new ToolTip();
            Logout.ToolTipTitle = "Log OUt Current User";
            Logout.UseFading = true;
            Logout.UseAnimation = true;
            Logout.IsBalloon = true;
            Logout.ShowAlways = true;
            Logout.AutoPopDelay = 5000;
            Logout.InitialDelay = 1000;
            Logout.ReshowDelay = 500;
            Logout.SetToolTip(LogOut, "Click me to Log Out.");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage LP = new LoginPage();
            LP.Show();
        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUser MU = new ManageUser();
            MU.Show();
        }

        private void manageUSerRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUSerRole MUR = new ManageUSerRole();
            MUR.Show();
        }

        private void HOME_Click(object sender, EventArgs e)
        {
            ManageUser MU = new ManageUser();
            MU.Show();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
            LoginPage LP = new LoginPage();
            LP.Show();
        }

        private void manageMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMember MM = new ManageMember();
            MM.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ManageMember MM = new ManageMember();
            MM.Show();
        }

        private void manageProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageProject MP = new ManageProject();
            MP.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ManageProject MP = new ManageProject();
            MP.Show();
        }

        private void assignMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MembersinProject MiP = new MembersinProject();
            MiP.Show();
        }

        private void registerBUGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BugEntryForm BEF = new BugEntryForm();
            BEF.Show();
           if (UserType == "")
            {
                BEF.btnAdd.Enabled = false;
                BEF.btnDel.Enabled = false;
                BEF.btnUpdate.Enabled = false;

            }
            else if (UserType == "Tester")
            {
                BEF.btnDel.Enabled = false;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            BugEntryForm BEF = new BugEntryForm();
            BEF.Show();
        }

        private void bUGSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterBugSolution RBS = new RegisterBugSolution();
            if (UserType == "2")
            {
                RBS.btnAdd.Enabled = false;
                RBS.btnDel.Enabled = false;
                RBS.btnUpdate.Enabled = false;

            }
            else if (UserType == "3")
            {
                RBS.btnDel.Enabled = false;
            }
            RBS.Show();

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBug Rep = new SearchBug();
            Rep.Show();
        }

        private void guthubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mptimilsina12/BugTrackingSystem");

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:/Bug Tracking/BugTrackingSystem/BUGTRACKINGHelp-Section.pdf");
        }

        private void ChartReport_Click(object sender, EventArgs e)
        {

        }

        private void projectReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectReport PR = new ProjectReport();
            PR.Show();
        }

        private void bugByReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetBugsByProject GBP = new GetBugsByProject();
            GBP.Show();
        }

        private void solutionByMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolutionByMember SM = new SolutionByMember();
            SM.Show();
        }

        private void bugByMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BugByMember BM = new BugByMember();
            BM.Show();
        }
    }
}
