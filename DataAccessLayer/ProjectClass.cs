using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
   public class ProjectClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int manageProjects(int projectId,
            String projectName,
            DateTime projectStartDate,
            DateTime projectEndDate,
            String projectDescription,
            int mode)
        {
            try
            {
                SqlCommand commandToManageProjectTable = new SqlCommand("SP_ManageProjects", conn);
                commandToManageProjectTable.CommandType = CommandType.StoredProcedure;
                commandToManageProjectTable.Parameters.AddWithValue("@projectId", projectId);
                commandToManageProjectTable.Parameters.AddWithValue("@projectName", projectName);
                commandToManageProjectTable.Parameters.AddWithValue("@projectStartDate", projectStartDate);
                commandToManageProjectTable.Parameters.AddWithValue("@projectEndDate", projectEndDate);
                commandToManageProjectTable.Parameters.AddWithValue("@ProjectDescription", projectDescription);
                commandToManageProjectTable.Parameters.AddWithValue("@mode", mode);
                conn.Open();
                int resultOfManageProject = commandToManageProjectTable.ExecuteNonQuery();
                conn.Close();
                return resultOfManageProject;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        /// <summary>
        /// Here I will declare a DataTable which will get information of all the project from ProjectTable
        /// And then I will SQLCommand  of CommandType Text to run query for selecting all the project information from ProjectTable
        /// And Since I am using connection Model as DataAccessModel I will first open the database connnection and initiate SQLDataReader to fetch data using SQLCommand
        /// Now I will Load the fetched data to the DataTable and then Close the connection
        /// and Finally I will return the internally declared data table so as to return the information fetched from the database
        /// </summary>
        /// <returns></returns>
        public DataTable getAllProjects()
        {
            try
            {
                DataTable dataTableToGetAllProjects = new DataTable();
                SqlCommand dataSelectionCommand = new SqlCommand("Select * from ProjectTable", conn);
                dataSelectionCommand.CommandType = CommandType.Text;
                conn.Open();
                SqlDataReader dataReaderForGettingAllProjects = dataSelectionCommand.ExecuteReader();
                dataTableToGetAllProjects.Load(dataReaderForGettingAllProjects);
                conn.Close();
                return dataTableToGetAllProjects;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        /// <summary>
        /// This method is declared to count the the number Of Projects
        /// </summary>
        /// <returns></returns>
        public int countNumberOfProjects()
        {
            try
            {
                DataTable dataTableToCountNumberOfProjects = new DataTable();
                SqlCommand cmd = new SqlCommand("Select count(*) from ProjectTable", conn);
                conn.Open();
                SqlDataReader dataReaderToGetNumberOfProjectsInDatabase = cmd.ExecuteReader();
                dataTableToCountNumberOfProjects.Load(dataReaderToGetNumberOfProjectsInDatabase);
                conn.Close();
                int numberOfProjects = Convert.ToInt32(dataTableToCountNumberOfProjects.Rows[0][0].ToString());
                return numberOfProjects;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
    }
}
