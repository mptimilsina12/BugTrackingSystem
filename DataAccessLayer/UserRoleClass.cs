using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    class UserRoleClass
    {

        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int manageUserRole(int userRoleId,
            String userRole,
            String roleDescription,
            int mode)
        {
            try
            {
                int result = 0;
                SqlCommand commandToManageUserRole = new SqlCommand("SP_ManageUserRole", conn);
                commandToManageUserRole.CommandType = CommandType.StoredProcedure;
                commandToManageUserRole.Parameters.AddWithValue("@userRoleId", userRoleId);
                commandToManageUserRole.Parameters.AddWithValue("@userRole", userRole);
                commandToManageUserRole.Parameters.AddWithValue("@roleDescription", roleDescription);
                commandToManageUserRole.Parameters.AddWithValue("@mode", mode);
                conn.Open();
                result = commandToManageUserRole.ExecuteNonQuery();
                conn.Close();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable getAllUserRoles()
        {
            try
            {
                DataTable dataTableToGetAllTheRoleInformation = new DataTable();
                SqlCommand commandToGetAllTheRoleInformation = new SqlCommand("SELECT * FROM UserRoleTable", conn);
                commandToGetAllTheRoleInformation.CommandType = CommandType.Text;
                conn.Open();
                SqlDataReader dataReaderToGetAllTheRoleInformation = commandToGetAllTheRoleInformation.ExecuteReader();
                dataTableToGetAllTheRoleInformation.Load(dataReaderToGetAllTheRoleInformation);
                conn.Close();
                return dataTableToGetAllTheRoleInformation;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
