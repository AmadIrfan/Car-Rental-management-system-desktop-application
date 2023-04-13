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
    public partial class mainpage : Form
    {
        public mainpage()
        {
            InitializeComponent();
        }

        private void mainpage_Load(object sender, EventArgs e)
        {
           MuserDL.DataFromFile();
            CarsDL.DataFromFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loginform loginform = new Loginform();  
            loginform.Show();
            this.Hide();
        }

        private void Btnsignup_Click(object sender, EventArgs e)
        {
            signup Signupform = new signup();   
            Signupform.Show();
            this.Hide();
        }

        private void btnLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
