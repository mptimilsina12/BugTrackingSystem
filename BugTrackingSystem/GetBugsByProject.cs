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

namespace BugTrackingSystem
{
    public partial class GetBugsByProject : Form
    {
        public GetBugsByProject()
        {
            InitializeComponent();
        }
        public BugEntryForm BugEntryForm
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        ProjectClass pc = new ProjectClass();
        ReportClass rc = new ReportClass();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvReport.DataSource = rc.GetBugByProject(Convert.ToInt32(cmbProjectName.SelectedValue.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetBugsByProject_Load(object sender, EventArgs e)
        {
            try
            {
                cmbProjectName.DataSource = pc.getAllProjects();
                cmbProjectName.DisplayMember = "ProjectName";
                cmbProjectName.ValueMember = "ProjectId";
                cmbProjectName.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
