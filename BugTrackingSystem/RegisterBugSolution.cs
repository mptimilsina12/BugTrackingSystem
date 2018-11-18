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
using System.IO;


namespace BugTrackingSystem
{
    public partial class RegisterBugSolution : Form
    {
        public RegisterBugSolution()
        {
            InitializeComponent();
        }
        
        public int RegBugID;
        BugEntryClass bugentryclass = new BugEntryClass();
        ProjectClass projectclass = new ProjectClass();
        MemberClass memberclass = new MemberClass();
        BugSolutionClass bugsolnclass = new BugSolutionClass();
        BusinessLogicClass businesslogicclass =new BusinessLogicClass();
      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }

        private void txtBugDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLineNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void picSnap_Click(object sender, EventArgs e)
        {

        }

        private void txtBlock_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbIdentifiedBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMethod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtClassLibrary_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void RegisterBugSolution_Load(object sender, EventArgs e)
        {
            
            dgvBugSolutionInformation.DataSource = bugsolnclass.getAllBugSolutions();

          //  cmbProject.DataSource = projectclass.getAllProjects();
           // cmbProject.ValueMember = "projectId";
         //   cmbProject.DisplayMember = "projectName";
        //    cmbProject.SelectedIndex = -1;

            cmbBugDetails.DataSource = bugentryclass.getBugsByMemberAndProject(Convert.ToInt32(int memberId, int productId).ToString );
            cmbBugDetails.ValueMember = "bugId";
            cmbBugDetails.DisplayMember = "bugDetails";
            cmbProject.DisplayMember = "projectName";

            cmbBugDetails.DisplayMember = "snapShotOfBugMessage";
            cmbBugDetails.SelectedIndex = -1;

            cmbbugsolvedby.DataSource = memberclass.getAllMembers();
            cmbbugsolvedby.ValueMember = "memberId";
            cmbbugsolvedby.DisplayMember = "memberName";
            cmbbugsolvedby.SelectedIndex = -1;
        }

        private void dgvBugSolutionInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RegBugID = Convert.ToInt32(dgvBugSolutionInformation.SelectedRows[0].Cells["bugSolutionId"].Value.ToString());
                cmbbugsolvedby.Text = dgvBugSolutionInformation.SelectedRows[0].Cells["memberName"].Value.ToString();
                dateDate.Text = dgvBugSolutionInformation.SelectedRows[0].Cells["dateOfSolutionIdentified"].Value.ToString();
                cmbProject.Text = dgvBugSolutionInformation.SelectedRows[0].Cells["projectName"].Value.ToString();
                cmbBugDetails.Text = dgvBugSolutionInformation.SelectedRows[0].Cells["solutionDetails"].Value.ToString();              
                MemoryStream memoryStream = new MemoryStream((byte[])dgvBugSolutionInformation.SelectedRows[0].Cells["snapShotOfBugMessage"].Value);
                picSnap.Image = Image.FromStream(memoryStream);
                txtCode.Text = dgvBugSolutionInformation.SelectedRows[0].Cells["codeAfterFixingBug"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
