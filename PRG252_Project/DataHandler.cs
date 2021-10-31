using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PRG252_Project
{
    class DataHandler
    {
        SqlConnection conn = new SqlConnection("Server=.; Initial Catalog= BelciumCampusDB; Integrated Security= SSPI");

        public void InsertStudent(int number, string name, string surname, string dob, string gender, int phone, string address, int modCode)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO tbl_Student(StudentNumber, StudentName, StudentSurname, DateOfBirth, Gender, PhoneNumber, Address, ModuleCode) VALUES('{number}','{name}','{surname}','{dob}','{gender}','{phone}','{address}', '{modCode}')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void InsertModule(int code, string name, string description, string link)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO tbl_Module VALUES('{code}', '{name}', '{description}', '{link}')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Module Information Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
