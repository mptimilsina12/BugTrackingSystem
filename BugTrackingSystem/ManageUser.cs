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
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }
        UserClass userClass = new UserClass();
        UserRoleClass userRoleClass = new UserRoleClass();
        MemberClass memberClass = new MemberClass();
        BusinessLogicClass businessLogicClass = new BusinessLogicClass();
        int userId;
        private void label2_Click(object sender, EventArgs e)
        {

        }

      private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
       }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            dgvUserInformation.DataSource = userClass.getAllUsers();
            cmbFullName.DataSource = memberClass.getAllMembers();
            cmbFullName.ValueMember = "memberId";
            cmbFullName.DisplayMember = "memberName";
            cmbFullName.SelectedIndex = -1;
            cmbUserRole.DataSource = userRoleClass.getAllUserRoles();
            cmbUserRole.ValueMember = "userRoleId";
            cmbUserRole.DisplayMember = "userRole";
            cmbUserRole.SelectedIndex = -1;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbUserRole.Text == "")
                MessageBox.Show("Please Select User Role");
            else if (cmbFullName.Text == "")
                MessageBox.Show("Please Select Member");
            else if (txtUserName.Text == "")
                MessageBox.Show("Please Provide username");
            else if (txtPassword.Text == "")
                MessageBox.Show("Please Provide Password");

            else if (txtCPassword.Text == "")
                MessageBox.Show("Please Provide Confirm Password");

            else if (txtCPassword.Text != txtPassword.Text)
                MessageBox.Show("Password didnot Match");
          
            else
            {            
            try
            {
                bool result = businessLogicClass.manageUsers(0, Convert.ToInt32(cmbUserRole.SelectedValue.ToString()), Convert.ToInt32(cmbFullName.SelectedValue.ToString()), txtUserName.Text, txtPassword.Text, 1);
                if (result == true)
                {
                    MessageBox.Show("NEW USER HAS BEEN ADDED");
                    dgvUserInformation.DataSource = userClass.getAllUsers();
                    AssistantClass.makeFieldsBlank(groupBox1);
                }
                else
                {
                    MessageBox.Show("ERROR ON ADDING NEW USER");
                    dgvUserInformation.DataSource = userClass.getAllUsers();
                    AssistantClass.makeFieldsBlank(groupBox1);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbUserRole.Text == "")
                MessageBox.Show("Please Select User Role");
            else if (cmbFullName.Text == "")
                MessageBox.Show("Please Select Member");
            else if (txtUserName.Text == "")
                MessageBox.Show("Please Provide username");
            else if (txtPassword.Text == "")
                MessageBox.Show("Please Provide Password");

            else if (txtCPassword.Text == "")
                MessageBox.Show("Please Provide Confirm Password");

            else if (txtCPassword.Text != txtPassword.Text)
                MessageBox.Show("Password didnot Match");

            else
            {

                try
                {
                    bool result = businessLogicClass.manageUsers(userId, Convert.ToInt32(cmbUserRole.SelectedValue.ToString()), Convert.ToInt32(cmbFullName.SelectedValue.ToString()), txtUserName.Text, txtPassword.Text, 2);
                    if (result == true)
                    {
                        MessageBox.Show("NEW USER HAS BEEN UPDATED");
                        dgvUserInformation.DataSource = userClass.getAllUsers();
                        AssistantClass.makeFieldsBlank(groupBox1);
                    }
                    else
                    {
                        MessageBox.Show("ERROR ON ADDING NEW UPDAED");
                        dgvUserInformation.DataSource = userClass.getAllUsers();
                        AssistantClass.makeFieldsBlank(groupBox1);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvUserInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userId = Convert.ToInt32(dgvUserInformation.SelectedRows[0].Cells["Id"].Value.ToString());
                cmbUserRole.Text = dgvUserInformation.SelectedRows[0].Cells["Role"].Value.ToString();
                cmbFullName.Text = dgvUserInformation.SelectedRows[0].Cells["Name"].Value.ToString();
                txtUserName.Text = dgvUserInformation.SelectedRows[0].Cells["Username"].Value.ToString();
                txtPassword.Text = dgvUserInformation.SelectedRows[0].Cells["Password"].Value.ToString();
                txtCPassword.Text = dgvUserInformation.SelectedRows[0].Cells["Password"].Value.ToString();
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
                bool result = businessLogicClass.manageUsers(userId, Convert.ToInt32(cmbUserRole.SelectedValue.ToString()), Convert.ToInt32(cmbFullName.SelectedValue.ToString()), txtUserName.Text, txtPassword.Text, 3);
                if (result == true)
                {
                    MessageBox.Show("NEW USER HAS BEEN DELETED");
                    dgvUserInformation.DataSource = userClass.getAllUsers();
                    AssistantClass.makeFieldsBlank(groupBox1);
                }
                else
                {
                    MessageBox.Show("ERROR ON ADDING NEW DELETED");
                    dgvUserInformation.DataSource = userClass.getAllUsers();
                    AssistantClass.makeFieldsBlank(groupBox1);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
