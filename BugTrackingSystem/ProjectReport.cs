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
    public partial class ProjectReport : Form
    {
        public ProjectReport()
        {
            InitializeComponent();
        }
        ReportClass rc = new ReportClass();

        private void ProjectReport_Load(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                dgvReport.DataSource = rc.AllProjectsByDates(dateStart.Text, dateEnd.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
