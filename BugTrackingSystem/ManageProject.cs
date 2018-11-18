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
    public partial class ManageProject : Form
    {
        public ManageProject()
        {
            InitializeComponent();
        }
        ProjectClass projectclass = new ProjectClass();
        BusinessLogicClass businesslogicclass = new BusinessLogicClass();
       public int ProjectId;
     
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageProject_Load(object sender, EventArgs e)
        {
            dgvProjectInformation.DataSource = projectclass.getAllProjects();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = businesslogicclass.manageProjects(0, txtPName.Text, Convert.ToDateTime(dateStart.Text), Convert.ToDateTime(dateEnd.Text), txtDescription.Text, 1);
                if (result == true)
                {
                    MessageBox.Show("NEW PROJECT HAS BEEN SUCCESSFULLY ADDED");
                    dgvProjectInformation.DataSource = projectclass.getAllProjects();
                    AssistantClass.makeFieldsBlank(pnlProjectInformation);
                }
                else
                {
                    MessageBox.Show("ERROR ON ADDING NEW PROJECT");
                    dgvProjectInformation.DataSource = projectclass.getAllProjects();
                    AssistantClass.makeFieldsBlank(pnlProjectInformation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvProjectInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ProjectId = Convert.ToInt32(dgvProjectInformation.SelectedRows[0].Cells["projectId"].Value.ToString());
                txtPName.Text = dgvProjectInformation.SelectedRows[0].Cells["projectName"].Value.ToString();
                dateStart.Text = dgvProjectInformation.SelectedRows[0].Cells["projectStartDate"].Value.ToString();
                dateEnd.Text = dgvProjectInformation.SelectedRows[0].Cells["projectEndDate"].Value.ToString();
                txtDescription.Text = dgvProjectInformation.SelectedRows[0].Cells["projectDescription"].Value.ToString();
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
                bool result = businesslogicclass.manageProjects(ProjectId, txtPName.Text, Convert.ToDateTime(dateStart.Text), Convert.ToDateTime(dateEnd.Text), txtDescription.Text, 2);
                if (result == true)
                {
                    MessageBox.Show(" PROJECT HAS BEEN SUCCESSFULLY UPDATED");
                    dgvProjectInformation.DataSource = projectclass.getAllProjects();
                    AssistantClass.makeFieldsBlank(pnlProjectInformation);
                }
                else
                {
                    MessageBox.Show("ERROR ON UPDATING EXISTING PROJECT");
                    dgvProjectInformation.DataSource = projectclass.getAllProjects();
                    AssistantClass.makeFieldsBlank(pnlProjectInformation);
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
                bool result = businesslogicclass.manageProjects(ProjectId, txtPName.Text, Convert.ToDateTime(dateStart.Text), Convert.ToDateTime(dateEnd.Text), txtDescription.Text, 3);
                if (result == true)
                {
                    MessageBox.Show(" PROJECT INFORMATION HAS BEEN SUCCESSFULLY DELETED");
                    dgvProjectInformation.DataSource = projectclass.getAllProjects();
                    AssistantClass.makeFieldsBlank(pnlProjectInformation);
                }
                else
                {
                    MessageBox.Show("ERROR ON DELETING EXISTING PROJECT");
                    dgvProjectInformation.DataSource = projectclass.getAllProjects();
                    AssistantClass.makeFieldsBlank(pnlProjectInformation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
