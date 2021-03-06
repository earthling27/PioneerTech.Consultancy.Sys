﻿using PioneerTech.Consultancy.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PioneerTech.Consultancy.Sys.Model;
using PioneerTech.Consultancy.Sys.Model.Models;

namespace PioneerTech.Consultancy.Sys
{
    public partial class PioneerEmployeeDB : Form
    {
        public PioneerEmployeeDB()
        {
            InitializeComponent();

        }




        private void emailtextbox_edit(object sender, EventArgs e)
        {

        }

        private void ClearButton_Personal(object sender, EventArgs e)
        {

            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            emailtextbox.Text = "";
            phonetextbox.Text = "";
            address1textbox.Text = "";
            address2textbox.Text = "";
            mobiletextbox.Text = "";
            zipcodetextbox.Text = "";
            HomeCountryTextBox.Text = "";
            CurrentCountrtyTextBox.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void nameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mobiletextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void address1textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void address2textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void zipcodetextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void coursetextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void specializationtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void graduationtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userinterfacetextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void programminglanguagetextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ormtechnologytextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void databasetextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_buttonClick(object sender, EventArgs e)
        {
            //string DataBase = databasetextbox.Text;
            //string ORM_Technology = ormtechnologytextbox.Text;
            //string ProgrammingLanguage = programminglanguagetextbox.Text;
            //string UserInterface = userinterfacetextbox.Text;
            //string Graduation = graduationtextbox.Text;
            //string Specialization = specializationtextbox.Text;

            //string Course = coursetextbox.Text;


            PersonalDetails personal_details = new PersonalDetails() { 
             Address2 = address2textbox.Text,
             Address1 = address1textbox.Text,
             FirstName = FirstNameTextBox.Text,
             Mobile = Convert.ToInt64(mobiletextbox.Text),
             EmailID = emailtextbox.Text,
             LastName = LastNameTextBox.Text,
             HomeCountry = HomeCountryTextBox.Text,
             CurrentCountry = CurrentCountrtyTextBox.Text,
             Phone = Convert.ToInt64(phonetextbox.Text),
             ZipCode = Convert.ToInt32(zipcodetextbox.Text) };

         
            EmployeeDataAccessLayer employeedata = new EmployeeDataAccessLayer();

            var result = employeedata.InjectPersonalDetails(personal_details);
            if(result>0)
            {
                MessageBox.Show("Personal Details Sucessfully Updated for {0} ",personal_details.FirstName);
            }
            else
            {
                MessageBox.Show("Personal Details Update Failed for {0}",personal_details.FirstName);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchEmployeeID_button_Click(object sender, EventArgs e)
        {
            int EmployeeID = Convert.ToInt32(searchEmployeeIDtextBox.Text);
            SqlConnection conn = new SqlConnection("Data Source=EARTHLING;" +
               "Initial Catalog=EmployeeDataBaseManagementSystem;" +
               "Integrated Security=true");
            try
            {
                conn.Open();
                SqlCommand command1 = new SqlCommand("SELECT * FROM PersonalDetails WHERE EmployeeID = '" + EmployeeID + "'", conn);
                SqlCommand command2 = new SqlCommand("SELECT * FROM ProjectDetails WHERE EmployeeID = '" + EmployeeID + "'", conn);
                SqlCommand command3 = new SqlCommand("SELECT * FROM [Company Details] WHERE EmployeeID = '" + EmployeeID + "'", conn);


                SqlDataReader rr1 = command1.ExecuteReader();
                BindingSource source1 = new BindingSource();
                source1.DataSource = rr1;
                rr1.Close();

                SqlDataReader rr2 = command2.ExecuteReader();
                BindingSource source2 = new BindingSource();
                source2.DataSource = rr2;
                rr2.Close();

                SqlDataReader rr3 = command3.ExecuteReader();
                BindingSource source3 = new BindingSource();
                source3.DataSource = rr3;
                rr3.Close();

                Personal_Details_Box.DataSource = source1;
                Project_Details_Box.DataSource = source2;
                Company_Details_Box.DataSource = source3;
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void FirstNameTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            //LastNameTextBox.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //string courseLevel = coursetextbox.Text;
            //string Speclization = specializationtextbox.Text;
            //DateTime Graduation = Convert.ToDateTime(graduationtextbox.Text);

            //SqlConnection conn = new SqlConnection("Data Source=EARTHLING;" +
            //    "Initial Catalog=EmployeeDataBaseManagementSystem;" +
            //    "Integrated Security=true");
            //try
            //{
            //    conn.Open();
            //    SqlCommand command = new SqlCommand("INSERT INTO AcademicAchievements VALUES(" +
            //               "'" + courseLevel + "','" + Speclization + "','" + Graduation + ")", conn);
            //    SqlDataReader rr = command.ExecuteReader();

            //}
            //catch (Exception exception)
            //{
            //    MessageBox.Show(exception.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string UserInterFace = userinterfacetextbox.Text;
            //string ProgrammingLanguage = programminglanguagetextbox.Text;
            //string orm_technology = ormtechnologytextbox.Text;
            //string database = databasetextbox.Text;
            //SqlConnection conn = new SqlConnection("Data Source=EARTHLING;" +
            //    "Initial Catalog=EmployeeDataBaseManagementSystem;" +
            //    "Integrated Security=true");
            //try
            //{
            //    conn.Open();
            //    SqlCommand command = new SqlCommand("INSERT INTO TechnicalDetails VALUES(" +
            //               "'" + UserInterFace + "','" + ProgrammingLanguage + "','" + orm_technology + "'," +
            //               database + ")", conn);
            //    SqlDataReader rr = command.ExecuteReader();

            //}
            //catch (Exception exception)
            //{
            //    MessageBox.Show(exception.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //}
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {


            ProjectDetails proj_details = new ProjectDetails()
            {
                EmployeeID = Convert.ToInt32(employeeIDTextBox.Text),
                ProjectName = projectNameTextBox.Text,
                Location = LocationTextBox.Text,
                Role = RoleTextBox.Text,
                ClientName = ClientNameTextBox.Text
            };

            EmployeeDataAccessLayer projectDetailsDataInect = new EmployeeDataAccessLayer();
            int result = projectDetailsDataInect.InjectProjectDetails(proj_details);

            if(result>0)
            {
                MessageBox.Show("The Project Details record Sucessfully Updated");

            } else
            {
                MessageBox.Show("The Project Details record Update Failed");
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void Personal_Details_Box_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {


            CompanyDetails comp_details = new CompanyDetails()
            {
                EmployeeName = employeeName_companyDetails_textBox.Text,
                EmployeeID = Convert.ToInt32(employeeID_companyDetails_textBox.Text),
                CompanyLocation = location_companyDetails_textBox.Text,
                Contact = Convert.ToInt64(contact_companyDetails_textbox.Text),
                CompanyWebsite = website_companyDetails_textBox.Text

            };
        EmployeeDataAccessLayer projectdata = new EmployeeDataAccessLayer();
            int  result = projectdata.InjectCompanyDetails(comp_details);
            if (result>0)
            {
                MessageBox.Show("The Company Details record has been sucessfully Updated");
            }
            else
            {
                MessageBox.Show("The Company Details cannot be updated");
            }
            
            


        }

        private void Project_Details_Box_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            employeeName_companyDetails_textBox.Text = "";
            location_companyDetails_textBox.Text = "";
            contact_companyDetails_textbox.Text = "";
            website_companyDetails_textBox.Text = "";

        }
    }

}
    

