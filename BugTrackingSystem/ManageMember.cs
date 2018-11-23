using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataAccessLayer;
using System.IO;

namespace BugTrackingSystem
{
    public partial class ManageMember : Form
    {
        public ManageMember()
        {
            InitializeComponent();
        }
        MemberClass memberClass = new MemberClass();
        BusinessLogicClass businessLogicClass = new BusinessLogicClass();
        public int memberId;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //Retrieve the data on DataGridView Box
        private void ManageMember_Load(object sender, EventArgs e)
        {
            dgvMemberInformation.DataSource = memberClass.getAllMembers();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        //Close the window
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Shows the image location to browse the image
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        picBrowse.Image = Image.FromFile(ofd.FileName);

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
        //RETRIEVE ALL DATA FROM DATA GRID VIEW TO THE DETAILS ENTRY SECTION  ON A  SINGLE CLICK
        private void dgvMemberInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                memberId = Convert.ToInt32(dgvMemberInformation.SelectedRows[0].Cells["memberId"].Value.ToString());
                txtFname.Text = dgvMemberInformation.SelectedRows[0].Cells["memberName"].Value.ToString();
               txtAdd.Text = dgvMemberInformation.SelectedRows[0].Cells["memberAddress"].Value.ToString();
                tctContact.Text = dgvMemberInformation.SelectedRows[0].Cells["contactNumber"].Value.ToString();
                txtEmail.Text = dgvMemberInformation.SelectedRows[0].Cells["emailAddress"].Value.ToString();
                cmbGender.Text = dgvMemberInformation.SelectedRows[0].Cells["gender"].Value.ToString();
                dateDOB.Text = dgvMemberInformation.SelectedRows[0].Cells["dateOfBirth"].Value.ToString();
                dateDOJ.Text = dgvMemberInformation.SelectedRows[0].Cells["dateOfJoin"].Value.ToString();
                txtDescription.Text = dgvMemberInformation.SelectedRows[0].Cells["memberDesignation"].Value.ToString();
                MemoryStream memoryStream = new MemoryStream((byte[])dgvMemberInformation.SelectedRows[0].Cells["profilePicture"].Value);
                picBrowse.Image= Image.FromStream(memoryStream);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //Add Member Details
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFname.Text == "")
                MessageBox.Show("Please Select Full Name");
            else if (txtAdd.Text == "")
                MessageBox.Show("Please Provide Address");
            else if (tctContact.Text == "")
                MessageBox.Show("Please Provide Contact Details");
            else if (txtDescription.Text == "")
                MessageBox.Show("Please Provide Description");
            else if (txtEmail.Text == "")
                MessageBox.Show("Please Provide Email Address");
            else if (cmbGender.Text == "")
                MessageBox.Show("Please Select Gender");
            else if (dateDOB.Text == "")
                MessageBox.Show("Please Provide Date of Birth");
            else if (dateDOJ.Text == "")
                MessageBox.Show("Please Provide DAte of Join");
            else if (picBrowse.Image == null)
                MessageBox.Show("Please Upload");

            else
            {
                try
                {
                    bool result = businessLogicClass.manageMembers(0, txtFname.Text, txtAdd.Text, tctContact.Text, txtEmail.Text, cmbGender.Text, Convert.ToDateTime(dateDOB.Text), Convert.ToDateTime(dateDOJ.Text), txtDescription.Text, AssistantClass.imageConverter(picBrowse), 1);
                    if (result == true)
                    {
                        MessageBox.Show("NEW MEMBER HAS SUCCESSFULLY CREATED");
                        dgvMemberInformation.DataSource = memberClass.getAllMembers();
                        AssistantClass.makeFieldsBlank(gbMemberDetails);
                        picBrowse.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("ERROR IN CREATING MEMBER");
                        dgvMemberInformation.DataSource = memberClass.getAllMembers();
                        AssistantClass.makeFieldsBlank(gbMemberDetails);
                        picBrowse.Image = null;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        // Update Member Details
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (txtFname.Text == "")
                MessageBox.Show("Please Select Full Name");
            else if (txtAdd.Text == "")
                MessageBox.Show("Please Provide Address");
            else if (tctContact.Text == "")
                MessageBox.Show("Please Provide Contact Details");
            else if (txtDescription.Text == "")
                MessageBox.Show("Please Provide Description");
            else if (txtEmail.Text == "")
                MessageBox.Show("Please Provide Email Address");
            else if (cmbGender.Text == "")
                MessageBox.Show("Please Select Gender");
            else if (dateDOB.Text == "")
                MessageBox.Show("Please Provide Date of Birth");
            else if (dateDOJ.Text == "")
                MessageBox.Show("Please Provide DAte of Join");
            else if (picBrowse.Image == null)
                MessageBox.Show("Please Upload");

            else
            {
                try
                {
                    bool result = businessLogicClass.manageMembers(memberId, txtFname.Text, txtAdd.Text, tctContact.Text, txtEmail.Text, cmbGender.Text, Convert.ToDateTime(dateDOB.Text), Convert.ToDateTime(dateDOJ.Text), txtDescription.Text, AssistantClass.imageConverter(picBrowse), 2);
                    if (result == true)
                    {
                        MessageBox.Show("MEMBER HAS BEEN SUCCESSFULLY UPDATED");
                        dgvMemberInformation.DataSource = memberClass.getAllMembers();
                        AssistantClass.makeFieldsBlank(gbMemberDetails);
                        picBrowse.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("ERROR IN UPDATING MEMBER");
                        dgvMemberInformation.DataSource = memberClass.getAllMembers();
                        AssistantClass.makeFieldsBlank(gbMemberDetails);
                        picBrowse.Image = null;

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = businessLogicClass.manageMembers(memberId, txtFname.Text, txtAdd.Text, tctContact.Text, txtEmail.Text, cmbGender.Text, Convert.ToDateTime(dateDOB.Text), Convert.ToDateTime(dateDOJ.Text), txtDescription.Text, AssistantClass.imageConverter(picBrowse), 3);
                if (result == true)
                {
                    MessageBox.Show("MEMBER HAS BEEN SUCCESSFULLY DELETED");
                    dgvMemberInformation.DataSource = memberClass.getAllMembers();
                    AssistantClass.makeFieldsBlank(gbMemberDetails);
                    picBrowse.Image = null;
                }
                else
                {
                    MessageBox.Show("ERROR IN DELETING MEMBER");
                    dgvMemberInformation.DataSource = memberClass.getAllMembers();
                    AssistantClass.makeFieldsBlank(gbMemberDetails);
                    picBrowse.Image = null;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
