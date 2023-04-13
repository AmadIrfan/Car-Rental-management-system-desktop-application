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
    public partial class AdminForm : Form
    {
        private string name;
        private int ID;
        public AdminForm(string name ,int id)
        {
            this.name = name;
            this.ID = id;
            InitializeComponent();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result =MessageBox.Show("Are you sure to log out??? ", "NOTE",MessageBoxButtons.OKCancel,MessageBoxIcon.Question );
            if (result == DialogResult.OK)
            {
                this.Close();
                Loginform loginform = new Loginform();
                loginform.Show();
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
        }

        
        private void btnlogout_Click(object sender, EventArgs e)
        {
            MuserDL.UserDataTofile();
            CarsDL.UserDataTofile();
            DialogResult result = MessageBox.Show("Are you Soure you want to Logout ???","Warning ",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
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
        private void btnUsers_Click(object sender, EventArgs e)
        {
            user viewUsers=new user(name,ID);
            viewUsers.Show();
            this.Hide();

        }
        private void btnCars_Click(object sender, EventArgs e)
        {
            CarsForm cars = new CarsForm(name, ID);
            cars.Show();
            this.Hide();
        }
        private void btnDeshboard_Click(object sender, EventArgs e)
        {
            AdminDash adminDash = new AdminDash(name,ID);
            adminDash.Show();
            this.Hide();
        }
        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Exit ???", "Question ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void lblExit_MouseLeave_1(object sender, EventArgs e)
        {
          
            lblExit.ForeColor = Color.White;
            lblExit.BorderStyle = BorderStyle.None;
        }

        private void lblExit_MouseHover_1(object sender, EventArgs e)
        {
            lblExit.BackColor = Color.White;
            lblExit.ForeColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(name, ID);
            customer.Show();
            this.Hide();
        }

        private void btnrental_Click(object sender, EventArgs e)
        {
            Rental rental=new Rental(name, ID);
            rental.Show();
            this.Hide();
        }

        private void lblExit_Paint(object sender, PaintEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Exit ???", "Question ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
