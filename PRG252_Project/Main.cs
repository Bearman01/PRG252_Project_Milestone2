using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG252_Project
{
    public partial class Main : Form
    {
        List<Student> list = new List<Student>();
        DataHandler dh = new DataHandler();

        public Main()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list = dh.View();
            BindingSource bs = new BindingSource();
            bs.DataSource = list;
            studentView.DataSource = bs;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            list = dh.Search(int.Parse(txtSearch.Text));
            BindingSource bs = new BindingSource();
            bs.DataSource = list;
            studentView.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
