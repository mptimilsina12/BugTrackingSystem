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
using System.Data.SqlClient;


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
        //BugSolutionClass bugsolnclass = new BugSolutionClass();
        BugSolutionClass bugSolutionEntryClass = new BugSolutionClass();

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
          //  dgvBugSolutionInformation.DataSource = bugsolnclass.getAllBugSolutions();
            dgvBugSolutionInformation.DataSource = bugSolutionEntryClass.getAllBugSolutions();

            //dgvBugSolutionInformation.DataSource = bugsolnclass.getAllBugSolutions();

            //  cmbProject.DataSource = projectclass.getAllProjects();
            // cmbProject.ValueMember = "projectId";
            //   cmbProject.DisplayMember = "projectName";
            //    cmbProject.SelectedIndex = -1;

            cmbBugDetails.DataSource = bugentryclass.getAllBugs();
            cmbBugDetails.ValueMember = "bugId";
            cmbBugDetails.DisplayMember = "bugDetails";
            cmbBugDetails.SelectedIndex = -1;

            cmbProject.DataSource = projectclass.getAllProjects();
            cmbProject.ValueMember = "projectId";
            cmbProject.DisplayMember = "projectName";
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
                cmbBugDetails.Text = dgvBugSolutionInformation.SelectedRows[0].Cells["bugDetails"].Value.ToString();
                txtSolutionDetails.Text = dgvBugSolutionInformation.SelectedRows[0].Cells["solutionDetails"].Value.ToString();
                MemoryStream memoryStream = new MemoryStream((byte[])dgvBugSolutionInformation.SelectedRows[0].Cells["snapShotOfBugMessage"].Value);
                picSnap.Image = Image.FromStream(memoryStream);
                txtCode.Text = dgvBugSolutionInformation.SelectedRows[0].Cells["codeAfterFixingBug"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmbBugDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (cmbBugDetails.SelectedIndex == -1)
                {
                    picSnap.Image = null;
                }
                else
                {
                    SqlConnection cn = new SqlConnection(ConnectionClass.ConnectionString);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT snapShotOfBugMessage from BugEntryTable where bugid=@bugid", cn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    cmd.Parameters.AddWithValue("@bugId", Convert.ToInt32(cmbBugDetails.SelectedValue.ToString()));
                    DataSet ds = new DataSet();
                    da.Fill(ds, "BugEntryTable");
                    int c = ds.Tables["BugEntryTable"].Rows.Count;
                    if (c > 0)
                    {
                        Byte[] byteBLOBData = new Byte[0];
                        byteBLOBData = (Byte[])(ds.Tables["BugEntryTable"].Rows[c - 1]["snapShotOfBugMessage"]);
                        MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                        picSnap.Image = Image.FromStream(stmBLOBData);
                    }
                    cn.Close();
                }
            }
            catch (Exception)
            {


            }


        }
        public void AddBugSolution()
        {

            try
            {
                if (dateDate.Text == "")
                {
                    MessageBox.Show("Please provide Bug Solution");
                    dateDate.Focus();
                }
                else if (cmbProject.SelectedIndex < 0)
                {
                    MessageBox.Show("Please choose Project");
                    cmbProject.Focus();
                }
                else if (cmbBugDetails.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select the Bug");
                    cmbBugDetails.Focus();
                }
                else if (txtSolutionDetails.Text == "")
                {
                    MessageBox.Show("Please provide the bug solution");
                    txtSolutionDetails.Focus();
                }
                else if (txtCode.Text
                    == "")
                {
                    MessageBox.Show("Please method the block which was modified after solving bug");
                    txtCode.Focus();
                }
                else
                {
                    AddBugSolution();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool result = businesslogicclass.manageBugSolutions(0, Convert.ToDateTime(dateDate.Text), Convert.ToInt32(cmbProject.SelectedValue.ToString()), Convert.ToInt32(cmbBugDetails.SelectedValue.ToString()), Convert.ToInt32(cmbbugsolvedby.SelectedValue.ToString()), txtSolutionDetails.Text, txtCode.Text, 1);
                if (result == true)
                {
                    MessageBox.Show("NEW BUG SOLUTION HAS BEEN REGISTERED");
                    AssistantClass.makeFieldsBlank(pnlBugSolnInfo);
                    AssistantClass.makeFieldsBlank(picSnap);

                    dgvBugSolutionInformation.DataSource = bugSolutionEntryClass.getAllBugSolutions();
                    dateDate.Focus();
                }
                else
                {

                    MessageBox.Show("ERROR IN REGISTERING BUG SOLUTION");
                    dgvBugSolutionInformation.DataSource = bugentryclass.getAllBugs();
                    AssistantClass.makeFieldsBlank(pnlBugSolnInfo);
                    AssistantClass.makeFieldsBlank(picSnap);

                    dateDate.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmbProject_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                cmbBugDetails.DataSource = bugentryclass.getBugsInProjectByProjectId(Convert.ToInt32(cmbProject.SelectedValue.ToString()));
                cmbBugDetails.ValueMember = "bugId";
                cmbBugDetails.DisplayMember = "bugDetails";
                cmbBugDetails.SelectedIndex = -1;
            }
            catch (NullReferenceException)
            {


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool result = businesslogicclass.manageBugSolutions(RegBugID, Convert.ToDateTime(dateDate.Text), Convert.ToInt32(cmbProject.SelectedValue.ToString()), Convert.ToInt32(cmbBugDetails.SelectedValue.ToString()), Convert.ToInt32(cmbbugsolvedby.SelectedValue.ToString()), txtSolutionDetails.Text, txtCode.Text,2);
                if (result == true)
                {
                    MessageBox.Show("BUG SOLUTION HAS BEEN MODIFIED");
                    dgvBugSolutionInformation.DataSource = bugentryclass.getAllBugs();
                    AssistantClass.makeFieldsBlank(pnlBugSolnInfo);
                }
                else
                {

                    MessageBox.Show("ERROR IN MODIFYING BUG SOLUTION");
                    dgvBugSolutionInformation.DataSource = bugentryclass.getAllBugs();
                    AssistantClass.makeFieldsBlank(pnlBugSolnInfo);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool result = businesslogicclass.manageBugSolutions(RegBugID, Convert.ToDateTime(dateDate.Text), Convert.ToInt32(cmbProject.SelectedValue.ToString()), Convert.ToInt32(cmbBugDetails.SelectedValue.ToString()), Convert.ToInt32(cmbbugsolvedby.SelectedValue.ToString()), txtSolutionDetails.Text, txtCode.Text, 3);
                if (result == true)
                {
                    MessageBox.Show("EXISTING BUG SOLUTION HAS BEEN DELETED");
                    dgvBugSolutionInformation.DataSource = bugSolutionEntryClass.getAllBugSolutions();
                    AssistantClass.makeFieldsBlank(pnlBugSolnInfo);
                }
                else
                {

                    MessageBox.Show("ERROR IN DELETING EXISTING BUG SOLUTION");
                    dgvBugSolutionInformation.DataSource = bugSolutionEntryClass.getAllBugSolutions();
                    AssistantClass.makeFieldsBlank(pnlBugSolnInfo);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
