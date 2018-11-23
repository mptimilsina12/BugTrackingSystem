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
    public partial class MembersinProject : Form
    {
        public MembersinProject()
        {
            InitializeComponent();
        }
        MemberinProjectClass memberprojectClass = new MemberinProjectClass();
        BusinessLogicClass businessligicClass = new BusinessLogicClass();
        MemberClass memberclass = new MemberClass();
        UserRoleClass userroleclass = new UserRoleClass();
        ProjectClass projectclass = new ProjectClass();
        public int projetID;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MembersinProject_Load(object sender, EventArgs e)
        {
            //displays the data on datagridview which are stored on Database 
            dgvMemberProjectInformation.DataSource = memberprojectClass.getAllMembersInProject();
            //shows Member Name 
            cmbMember.DataSource = memberclass.getAllMembers();
            cmbMember.ValueMember = "memberId";
            cmbMember.DisplayMember = "memberName";
            cmbMember.SelectedIndex = -1;
            //shows Project Name 
            cmbProject.DataSource = projectclass.getAllProjects();
            cmbProject.ValueMember = "projectId";
            cmbProject.DisplayMember = "projectName";
            cmbProject.SelectedIndex = -1;
            //Display list of Member Role  
            cmbMemberRole.DataSource = userroleclass.getAllUserRoles();
            cmbMemberRole.ValueMember = "userRoleId";
            cmbMemberRole.DisplayMember = "userRole";
            cmbMemberRole.SelectedIndex = -1;
        }
        //Add the datainserted on the form
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbProject.Text == "")
                MessageBox.Show("Please Provide Project Name");
            else if (cmbMember.Text == "")
                MessageBox.Show("Please Select Member");
            else if (cmbMemberRole.Text == "")
                MessageBox.Show("Please Select Member Role");
            else if (txtDescription.Text == "")
                MessageBox.Show("Please Provide Description");
            else
            {
                bool result = businessligicClass.manageProjectMembers(0, Convert.ToInt32(cmbProject.SelectedValue.ToString()), Convert.ToInt32(cmbMember.SelectedValue.ToString()), cmbMemberRole.Text, txtDescription.Text, 1);
                if (result == true)
                {
                    MessageBox.Show("NEW MEMBER HAS BEEN ADDED TO THE PROJECT");
                    dgvMemberProjectInformation.DataSource = memberprojectClass.getAllMembersInProject();
                    AssistantClass.makeFieldsBlank(gbMemberInProject);
                }
                else
                {
                    MessageBox.Show("ERROR IN ADDING MEMBER IN THE PROJECT");
                    dgvMemberProjectInformation.DataSource = memberprojectClass.getAllMembersInProject();
                    AssistantClass.makeFieldsBlank(gbMemberInProject);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbProject.Text == "")
                MessageBox.Show("Please Provide Project Name");
            else if (cmbMember.Text == "")
                MessageBox.Show("Please Select Member");
            else if (cmbMemberRole.Text == "")
                MessageBox.Show("Please Select Member Role");
            else if (txtDescription.Text == "")
                MessageBox.Show("Please Provide Description");
            else
            {
                bool result = businessligicClass.manageProjectMembers(projetID, Convert.ToInt32(cmbProject.SelectedValue.ToString()), Convert.ToInt32(cmbMember.SelectedValue.ToString()), cmbMemberRole.Text, txtDescription.Text, 2);
                if (result == true)
                {
                    MessageBox.Show("EXISTING MEMBER HAS BEEN UPDATED TO THE PROJECT");
                    dgvMemberProjectInformation.DataSource = memberprojectClass.getAllMembersInProject();
                    AssistantClass.makeFieldsBlank(gbMemberInProject);
                }
                else
                {
                    MessageBox.Show("ERROR IN UPDATING MEMBER IN THE PROJECT");
                    dgvMemberProjectInformation.DataSource = memberprojectClass.getAllMembersInProject();
                    AssistantClass.makeFieldsBlank(gbMemberInProject);
                }
            }
        }

        private void dgvMemberProjectInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                projetID = Convert.ToInt32(dgvMemberProjectInformation.SelectedRows[0].Cells["id"].Value.ToString());
                cmbProject.Text = dgvMemberProjectInformation.SelectedRows[0].Cells["projectName"].Value.ToString();
                cmbMember.Text = dgvMemberProjectInformation.SelectedRows[0].Cells["memberName"].Value.ToString();
                cmbMemberRole.Text = dgvMemberProjectInformation.SelectedRows[0].Cells["memberRole"].Value.ToString();
                txtDescription.Text = dgvMemberProjectInformation.SelectedRows[0].Cells["memberResponsibilities"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            bool result = businessligicClass.manageProjectMembers(projetID, Convert.ToInt32(cmbProject.SelectedValue.ToString()), Convert.ToInt32(cmbMember.SelectedValue.ToString()), cmbMemberRole.Text, txtDescription.Text, 3);
            if (result == true)
            {
                MessageBox.Show("EXISTING MEMBER HAS BEEN DELETED FROM THE PROJECT");
                dgvMemberProjectInformation.DataSource = memberprojectClass.getAllMembersInProject();
                AssistantClass.makeFieldsBlank(gbMemberInProject);
            }
            else
            {
                MessageBox.Show("ERROR IN DELETING MEMBER FROM THE PROJECT");
                dgvMemberProjectInformation.DataSource = memberprojectClass.getAllMembersInProject();
                AssistantClass.makeFieldsBlank(gbMemberInProject);
            }
        }
    }
}
