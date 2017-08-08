using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PioneerTech.Consultancy.DAL
{
    public class EmployeeDataAccessLayer
    {
        public int InjectPersonalDetails(string FirstName, string LastName, string EmailID, string Mobile, string phone, string Address1, string Address2, int ZipCode, string HomeCountry, string CurrentCountry)
        {
            SqlConnection conn = new SqlConnection("Data Source=EARTHLING;" +
           "Initial Catalog=EmployeeDataBaseManagementSystem;" +
           "Integrated Security=true");

            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO PersonalDetails VALUES(" +
                       "'" + FirstName + "','" + LastName + "','" + EmailID + "'," +
                        Mobile + "," + phone + ",'" + Address1 + "','" + Address2 +
                       "','" + CurrentCountry + "','" + HomeCountry + "'," + ZipCode + ")", conn);
            int result = command.ExecuteNonQuery();


            conn.Close();

            return result;


        }

        public int InjectCompanyDetails(string employeeName, string employeeID, string location, string contact, string website)
        {
            SqlConnection conn = new SqlConnection("Data Source=EARTHLING;" +
             "Initial Catalog=EmployeeDataBaseManagementSystem;" +
             "Integrated Security=true");
            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [Company Details] VALUES(" +
                       "'" + employeeName + "','" + contact + "','" + location + "','" +
                        website + "'," + employeeID + ")", conn);
            


            
            int result = command.ExecuteNonQuery();
            conn.Close();
            return result;


        }


        public int InjectProjectDetails(string projectName, string clientName, string location, string role, string employeeID)
        {
            SqlConnection conn = new SqlConnection("Data Source=EARTHLING;" +
                "Initial Catalog=EmployeeDataBaseManagementSystem;" +
                "Integrated Security=true");

            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO ProjectDetails VALUES(" +
                       "'" + projectName + "','" + clientName + "','" + location + "','" +
                        role + "'," + employeeID + ")", conn);

            int result = command.ExecuteNonQuery();

            conn.Close();
            return result;


        }

    }
}
