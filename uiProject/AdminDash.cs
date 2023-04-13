using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uiProject.BL;
using uiProject.DL;

namespace uiProject
{
    public partial class AdminDash : Form
    {
        private string name;
        private int ID;
        public AdminDash(string name, int id)
        {
            this.name = name;
            this.ID = id;
            InitializeComponent();
        }
        private void AdminDash_Load(object sender, EventArgs e)
        {
            label2.Text = name;
            label4.Text = ID.ToString();
            lblcarnumbers.Text = CarsDL.Carslist.Count.ToString();
            lblusernum.Text = MuserDL.userList.Count.ToString();
            lblcustno.Text = CustomerDL.CustomerList.Count.ToString();
        }
        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Exit ???", "Question ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm adminDash = new AdminForm(name,ID);
            adminDash.Show();
            this.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
