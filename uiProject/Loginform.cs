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
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnableoginBtn();
            CbShowPass.Checked=false;
            if (CbShowPass.Checked == true)
            {
                txtBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxPassword.UseSystemPasswordChar = true;
            }
            txtUnameInput.Select();
        }

   
        private void CbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            lblError.Hide();
            if (CbShowPass.Checked==true)
            {
                txtBoxPassword.UseSystemPasswordChar=false;
            }
            else
            {
                txtBoxPassword.UseSystemPasswordChar=true;
            }
        }

        private void txtUnameInput_TextChanged(object sender, EventArgs e)
        {
            txtUnameInput.MaxLength= 8;
            EnableoginBtn();
            lblError.Hide();
        }
        private void lblCreateAcut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblError.Hide();
            signup signupform = new signup();
            signupform.Show();
            this.Hide();
        }

        private void lblUname_Click(object sender, EventArgs e)
        {
            txtUnameInput.Select();
            lblError.Hide();
        }

        private void lblUpass_Click(object sender, EventArgs e)
        {
            txtBoxPassword.Select();
            lblError.Hide();

        }
        private void EnableoginBtn()
        {
            if (txtBoxPassword.Text != "" && txtUnameInput.Text != "")
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;

            }
        }
        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            EnableoginBtn();
            lblError.Hide();
        }
        private void lblUfClick_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TandCform tandCform=new TandCform();
            tandCform.Show();
            this.Hide();   
            lblError.Hide();
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string name, pass,role,nam;
            int id;
            Muser temp=null;
            name = txtUnameInput.Text;
            pass = txtBoxPassword.Text;
            lblError.Text = "You Login as User ";
            Muser obj = new Muser(name, pass);
            lblError.Text = "You Enterd Wrong Username or Password ";
            role = MuserDL.roleReturn(obj);
            temp = MuserDL.Checkuser(obj);
            if (temp != null)
            {
                nam = temp.Name;
                id = temp.iD;
            }
            else
            {
                nam = "";
                id=0;
            }
           
            if (role == "User"|| role == "user")
            {
                lblError.Show();
                lblError.ForeColor = Color.Green;
                lblError.Text = "You Login as User ";
               UserForm userform = new UserForm(nam,id);
                userform.Show();
                this.Hide();
            }
            else if (role == "Admin")
            {
                lblError.Show();
                lblError.ForeColor=Color.Green;
                lblError.Text = "You Login as Admin ";
                AdminForm adminform = new AdminForm(nam,id);
                adminform.Show();
                this.Hide();

            }
            else
            {
                lblError.Show();
                lblError.Text = "You Enterd Wrong Username or Password ";
            }

        }
        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            txtBoxPassword.Clear();
            txtUnameInput.Clear();
            lblError.Hide();
            EnableoginBtn();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Exit ???", "Question ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void label1_MouseHover(object sender, EventArgs e)
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
    }
}
