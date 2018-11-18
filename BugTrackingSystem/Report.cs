using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using BusinessLogicLayer;

namespace BugTrackingSystem
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        ProjectClass projectClass = new ProjectClass();
        MemberClass memberClass = new MemberClass();
        BugEntryClass bugEntry = new BugEntryClass();
        BugSolutionClass bugSolutionClass = new BugSolutionClass();
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvReport.DataSource = bugSolutionClass.searchBugSolutionByBugDetails(txtSearch.Text);

        }

        private void Report_Load(object sender, EventArgs e)
        {
            try
            {

                dgvReport.DataSource = bugSolutionClass.getAllBugSolutions();
                lblTotalProjects.Text = projectClass.countNumberOfProjects().ToString();
                lblTotalMembers.Text = memberClass.totalMember().ToString();
                lblTotalRegBug.Text =  bugEntry.getAllBugs().Rows.Count.ToString();
                lblTotalSolvedBug.Text = bugSolutionClass.getAllBugSolutions().Rows.Count.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
