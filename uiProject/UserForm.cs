using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uiProject
{
    public partial class UserForm : Form
    {
        private string name;
        private int ID;

        public UserForm(string name ,int iD)
        {
            InitializeComponent();
                
            this.name = name;
            this.ID = iD;

        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }
        private void lblExit_MouseHover(object sender, EventArgs e)
        {
            lblExit.BackColor = Color.White;
            lblExit.ForeColor = Color.Red;
            lblExit.BorderStyle = BorderStyle.FixedSingle;
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.BackColor = Color.Red;
            lblExit.ForeColor = Color.White;
            lblExit.BorderStyle = BorderStyle.None;
        }
        private void btnBookCars_Click(object sender, EventArgs e)
        {
            BookCars bookCars=new BookCars(name,ID);
            bookCars.Show();
            this.Hide();
        }

        private void btncars_Click_1(object sender, EventArgs e)
        {
            userViewcars UserViewcars = new userViewcars(name ,ID);
            UserViewcars.Show();
            this.Hide();
        }

        private void btnlogout_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you Soure you want to Logout ???", "Warning ", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                Loginform loginform = new Loginform();
                loginform.Show();
                this.Hide();
            }
            else
            {

            }
        }
        private void panel5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Exit ???", "Question ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void btnDeshboard_Click(object sender, EventArgs e)
        {
            UserDash userDash = new UserDash(name,ID);
            userDash.Show();
            this.Hide();
        }

        private void btnPrivious_Click(object sender, EventArgs e)
        {
            PriviousRecord priviousRecord = new PriviousRecord(name,ID);
            priviousRecord.Show();
            this.Hide();
        }
    }
}
