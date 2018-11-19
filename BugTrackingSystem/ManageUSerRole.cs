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

namespace BugTrackingSystem
{
    public partial class ManageUSerRole : Form
    {
        public ManageUSerRole()
        {
            InitializeComponent();
        }
        UserRoleClass userRoleClass = new UserRoleClass();
        BusinessLogicClass businessLogicClass = new BusinessLogicClass();
        int userRoleId;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageUSerRole_Load(object sender, EventArgs e)
        {
            dgvUserRoleInformation.DataSource = userRoleClass.getAllUserRoles();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = businessLogicClass.manageUserRole(0, cmbUserRole.Text, txtDescription.Text, 1);
                if (result == true)
                {
                    MessageBox.Show("NEW USER ROLE HAS BEEN ADDED");
                    dgvUserRoleInformation.DataSource = userRoleClass.getAllUserRoles();
                    AssistantClass.makeFieldsBlank(pnlUserInformation);
                }
                else
                {
                    MessageBox.Show("ERROR IN ADDING USER ROLE");
                    dgvUserRoleInformation.DataSource = userRoleClass.getAllUserRoles();
                    AssistantClass.makeFieldsBlank(pnlUserInformation);
                }
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
                bool result = businessLogicClass.manageUserRole(userRoleId, cmbUserRole.Text, txtDescription.Text, 2);
                if (result == true)
                {
                    MessageBox.Show("NEW USER HAS BEEN UPDATED");
                    dgvUserRoleInformation.DataSource = userRoleClass.getAllUserRoles();
                    AssistantClass.makeFieldsBlank(pnlUserInformation);
                }
                else
                {
                    MessageBox.Show("ERROR ON ADDING NEW UPDAED");
                    dgvUserRoleInformation.DataSource = userRoleClass.getAllUserRoles();
                    AssistantClass.makeFieldsBlank(pnlUserInformation);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUserRoleInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userRoleId = Convert.ToInt32(dgvUserRoleInformation.SelectedRows[0].Cells["userRoleId"].Value.ToString());
                cmbUserRole.Text = dgvUserRoleInformation.SelectedRows[0].Cells["userRole"].Value.ToString();
                txtDescription.Text = dgvUserRoleInformation.SelectedRows[0].Cells["roleDescription"].Value.ToString();
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
                bool result = businessLogicClass.manageUserRole(userRoleId, cmbUserRole.Text,txtDescription.Text, 3);
                if (result == true)
                {
                    MessageBox.Show("NEW USER HAS BEEN DELETED");
                    dgvUserRoleInformation.DataSource = userRoleClass.getAllUserRoles();
                    AssistantClass.makeFieldsBlank(pnlUserInformation);
                }
                else
                {
                    MessageBox.Show("ERROR ON ADDING NEW DELETED");
                    dgvUserRoleInformation.DataSource = userRoleClass.getAllUserRoles();
                    AssistantClass.makeFieldsBlank(pnlUserInformation);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }
}
