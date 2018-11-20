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
    public partial class SolutionByMember : Form
    {
        public SolutionByMember()
        {
            InitializeComponent();
        }
        MemberClass mc = new MemberClass();
        ReportClass rc = new ReportClass();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvReport.DataSource = rc.GetSolutionsByMember(Convert.ToInt32(cmbMemberName.SelectedValue.ToString()));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void SolutionByMember_Load(object sender, EventArgs e)
        {
            try
            {
                cmbMemberName.DataSource = mc.getAllMembers();
                cmbMemberName.DisplayMember = "MemberName";
                cmbMemberName.ValueMember = "MemberId";
                cmbMemberName.SelectedIndex = -1;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
