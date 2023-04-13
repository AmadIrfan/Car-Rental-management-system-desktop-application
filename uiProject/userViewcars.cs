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
    public partial class userViewcars : Form
    {
            private string name;
        private int ID;
        public userViewcars(string name,int iD)

        {
            this.name = name;
            this.ID = iD;
            InitializeComponent();
        }

        private void userViewcars_Load(object sender, EventArgs e)
        {
            GVusercars.DataSource = CarsDL.Carslist;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Exit ???", "Question ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            UserForm user = new UserForm(name,ID);
            user.Show();
            this.Hide();
        }

        private void btnDeshboard_Click(object sender, EventArgs e)
        {
            UserDash userDash =new UserDash(name, ID);
            userDash.Show();
            this.Hide();
        }
    }
}
