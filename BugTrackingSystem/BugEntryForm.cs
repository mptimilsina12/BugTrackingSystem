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
    public partial class BugEntryForm : Form
    {
        public BugEntryForm()
        {
            InitializeComponent();
        }
        public int BugID;
        BusinessLogicClass businessligicClass = new BusinessLogicClass();
        ProjectClass projectclass = new ProjectClass();
        MemberClass memberclass = new MemberClass();
        BugEntryClass bugentryclass = new BugEntryClass();
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        picSnap.Image = Image.FromFile(ofd.FileName);

                    }
                    else
                    {
                        MessageBox.Show("Please select a profile picture");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BugEntryForm_Load(object sender, EventArgs e)
        {
            dgvBugEntryInformation.DataSource = bugentryclass.getAllBugs();
            //get the name of Member
            cmbIdentifiedBy.DataSource = memberclass.getAllMembers();
            cmbIdentifiedBy.DisplayMember = "memberName";
            cmbIdentifiedBy.ValueMember = "memberId";
            cmbIdentifiedBy.SelectedIndex = -1;
            //gets the name of Project
            cmbProject.DataSource = projectclass.getAllProjects();
            cmbProject.ValueMember = "projectId";
            cmbProject.DisplayMember = "projectName";
            cmbProject.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                bool result = businessligicClass.manageBugs(0, Convert.ToDateTime(dateDate.Text), Convert.ToInt32(cmbIdentifiedBy.SelectedValue.ToString()), Convert.ToInt32(cmbProject.SelectedValue.ToString()), txtClassLibrary.Text, txtClass.Text, txtMethod.Text, txtBlock.Text, txtLineNumber.Text, txtBugDetails.Text, AssistantClass.imageConverter(picSnap), txtCode.Rtf, 1);
                if (result == true)
                {
                    MessageBox.Show("NEW BUG RECORD HAS BEEN ADDED");
                    dgvBugEntryInformation.DataSource = bugentryclass.getAllBugs();
                    AssistantClass.makeFieldsBlank(pnlBugDetails);
                    picSnap.Image = null;
                }
                else
                {
                    MessageBox.Show("ERROR IN ADDING BUG RECORD");
                    dgvBugEntryInformation.DataSource = bugentryclass.getAllBugs();
                    AssistantClass.makeFieldsBlank(pnlBugDetails);
                    picSnap.Image = null;
                }
            }
            
            catch (Exception ex)
            {

              MessageBox.Show(ex.Message);
            }
        }

        private void dgvBugEntryInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BugID = Convert.ToInt32(dgvBugEntryInformation.SelectedRows[0].Cells["bugId"].Value.ToString());
                dateDate.Text = dgvBugEntryInformation.SelectedRows[0].Cells["bugIdentifiedDate"].Value.ToString();
                cmbIdentifiedBy.Text = dgvBugEntryInformation.SelectedRows[0].Cells["memberName"].Value.ToString();
                cmbProject.Text = dgvBugEntryInformation.SelectedRows[0].Cells["projectName"].Value.ToString();
                txtClassLibrary.Text = dgvBugEntryInformation.SelectedRows[0].Cells["classLibraryName"].Value.ToString();
                txtClass.Text = dgvBugEntryInformation.SelectedRows[0].Cells["className"].Value.ToString();
                txtMethod.Text = dgvBugEntryInformation.SelectedRows[0].Cells["methodName"].Value.ToString();
                txtBlock.Text = dgvBugEntryInformation.SelectedRows[0].Cells["blockName"].Value.ToString();
                txtLineNumber.Text = dgvBugEntryInformation.SelectedRows[0].Cells["lineNumber"].Value.ToString();
                txtBugDetails.Text = dgvBugEntryInformation.SelectedRows[0].Cells["bugDetails"].Value.ToString();
                MemoryStream memoryStream = new MemoryStream((byte[])dgvBugEntryInformation.SelectedRows[0].Cells["snapShotOfBugMessage"].Value);
                picSnap.Image = Image.FromStream(memoryStream);
                txtCode.Rtf = dgvBugEntryInformation.SelectedRows[0].Cells["codeContainingBug"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                bool result = businessligicClass.manageBugs(BugID, Convert.ToDateTime(dateDate.Text), Convert.ToInt32(cmbIdentifiedBy.SelectedValue.ToString()), Convert.ToInt32(cmbProject.SelectedValue.ToString()), txtClassLibrary.Text, txtClass.Text, txtMethod.Text, txtBlock.Text, txtLineNumber.Text, txtBugDetails.Text, AssistantClass.imageConverter(picSnap), txtCode.Rtf, 2);
                if (result == true)
                {
                    MessageBox.Show("EXISTING BUG RECORD HAS BEEN UPDATED");
                    dgvBugEntryInformation.DataSource = bugentryclass.getAllBugs();
                    AssistantClass.makeFieldsBlank(pnlBugDetails);
                    picSnap.Image = null;
                }
                else
                {
                    MessageBox.Show("ERROR IN UPDATING BUG RECORD");
                    dgvBugEntryInformation.DataSource = bugentryclass.getAllBugs();
                    AssistantClass.makeFieldsBlank(pnlBugDetails);
                    picSnap.Image = null;
                }
            
            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
               
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {

                bool result = businessligicClass.manageBugs(BugID, Convert.ToDateTime(dateDate.Text), Convert.ToInt32(cmbIdentifiedBy.SelectedValue.ToString()), Convert.ToInt32(cmbProject.SelectedValue.ToString()), txtClassLibrary.Text, txtClass.Text, txtMethod.Text, txtBlock.Text, txtLineNumber.Text, txtBugDetails.Text, AssistantClass.imageConverter(picSnap), txtCode.Rtf, 3);
                if (result == true)
                {
                    MessageBox.Show("EXISTING BUG RECORD HAS BEEN DELETED");
                    dgvBugEntryInformation.DataSource = bugentryclass.getAllBugs();
                    AssistantClass.makeFieldsBlank(pnlBugDetails);
                    picSnap.Image = null;
                }
                else
                {
                    MessageBox.Show("ERROR IN DELETING BUG RECORD");
                    dgvBugEntryInformation.DataSource = bugentryclass.getAllBugs();
                    AssistantClass.makeFieldsBlank(pnlBugDetails);
                    picSnap.Image = null;
                }
            }
          
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message);
            }
        }
    }
}
