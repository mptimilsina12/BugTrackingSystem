using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //its for current date
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            this.Hide();
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
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            BugEntryForm BEF = new BugEntryForm();
            BEF.Show();
        }

        private void bUGSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterBugSolution RBS = new RegisterBugSolution();
            RBS.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report Rep = new Report();
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
    }
}
