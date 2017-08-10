using PioneerTech.Consultancy.Sys.Model;
using PioneerTech.Consultancy.Sys.Model.Models;
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
        public int InjectPersonalDetails(PersonalDetails p_detail)
        {
            SqlConnection conn = new SqlConnection("Data Source=EARTHLING;" +
           "Initial Catalog=EmployeeDataBaseManagementSystem;" +
           "Integrated Security=true");

            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO PersonalDetails VALUES(" +
                       "'" + p_detail.FirstName + "','" + p_detail.LastName + "','" + p_detail.EmailID + "'," +
                        p_detail.Mobile + "," + p_detail.Phone + ",'" + p_detail.Address1 + "','" + p_detail.Address2 +
                       "','" + p_detail.CurrentCountry + "','" + p_detail.HomeCountry + "'," + p_detail.ZipCode + ")", conn);
            int result = command.ExecuteNonQuery();


            conn.Close();

            return result;


        }

        public int InjectCompanyDetails(CompanyDetails comp_details)
        {
            SqlConnection conn = new SqlConnection("Data Source=EARTHLING;" +
             "Initial Catalog=EmployeeDataBaseManagementSystem;" +
             "Integrated Security=true");
            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [Company Details] VALUES(" +
                       "'" + comp_details.EmployeeName + "','" + comp_details.Contact + "','" + comp_details.CompanyLocation + "','" +
                        comp_details.CompanyWebsite + "'," + comp_details.EmployeeID + ")", conn);
            


            
            int result = command.ExecuteNonQuery();
            conn.Close();
            return result;


        }


        public int InjectProjectDetails(ProjectDetails proj_details)
        {
            SqlConnection conn = new SqlConnection("Data Source=EARTHLING;" +
                "Initial Catalog=EmployeeDataBaseManagementSystem;" +
                "Integrated Security=true");

            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO ProjectDetails VALUES(" +
                       "'" + proj_details.ProjectName + "','" + proj_details.ClientName + "','" + proj_details.Location + "','" +
                        proj_details.Role + "'," + proj_details.EmployeeID + ")", conn);

            int result = command.ExecuteNonQuery();

            conn.Close();
            return result;


        }

    }
}
