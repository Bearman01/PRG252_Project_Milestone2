using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PRG252_Project
{
    public partial class Register : Form
    {
        FileHandler fh = new FileHandler();
        DataHandler dh = new DataHandler();

        SqlConnection conn = new SqlConnection("Server=.; Initial Catalog= BelciumCampusDB; Integrated Security= SSPI");
        SqlCommand command;
        string imgLoc = "";

        public Register()
        {
            InitializeComponent();
        }

        private void btn_GoToLogin_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_UserName.Text = "";
            txt_Pass.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fh.Write(txt_UserName.Text, int.Parse(txt_Pass.Text));
            MessageBox.Show("Username And Password has been added");
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txt_Pass.PasswordChar = '\0';
            }
            else
            {
                txt_Pass.PasswordChar = '•';
            }
        }

        private void btn_AddModule_Click(object sender, EventArgs e)
        {
            dh.InsertModule(int.Parse(txtModuleCode.Text), txtModuleName.Text, txtModuleDescription.Text, txtModuleLink.Text);
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Student Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    picStudent.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {

                //byte[] img = null;
                //FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                //BinaryReader br = new BinaryReader(fs);
                //img = br.ReadBytes((int)fs.Length);
                //string sql = "INSERT INTO tbl_Student(StudentImage)VALUES(@img)";
                //conn.Open();


                dh.InsertStudent(int.Parse(txtStudentNumber.Text), txtStudentName.Text, txtStudentSurname.Text, DOB.Text, cm_Gender.Text, int.Parse(txtPhone.Text), txtAddress.Text, int.Parse(txt_SmodCode.Text));

                //command = new SqlCommand(sql, conn);
                //command.Parameters.Add(new SqlParameter("@img", img));

                //int y = command.ExecuteNonQuery();
                //conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
