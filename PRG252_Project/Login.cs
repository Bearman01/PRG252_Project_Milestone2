using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PRG252_Project
{
    public partial class Login : Form
    {
        FileHandler fh = new FileHandler();   

        public Login()
        {
            InitializeComponent();
        }

        string[] arr;

        private void button1_Click(object sender, EventArgs e)
        {


            if (fh.CheckUser(txt_UserName.Text, int.Parse(txt_Pass.Text)) == true)
            {
                new Main().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            txt_UserName.Text = "";
            txt_Pass.Text = "";
        }

        private void btn_GoToRegister_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }
    }
}
