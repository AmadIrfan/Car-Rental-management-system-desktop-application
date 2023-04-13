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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

   
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string rut, gender;
            gender = checkGender();
            if (textBoxID.Text == "" || txtBoxAge.Text == "" || txtBoxPassword.Text == "" || txtboxName.Text == "" || txtBoxPnumber.Text == "" || Cbox.Text == "")
            {
                MessageBox.Show("Fiels is Empty !!!");
            }
            else
            {

            
            rut = MuserDL.checkNewUser(txtboxName.Text, int.Parse(txtBoxAge.Text), txtBoxPassword.Text);
            if (rut == "name")
            {
                MessageBox.Show("you enterd name That alredy Exist", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            }
            else if (rut == "id")
            {
                MessageBox.Show("you enterd id That alredy Exist", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            }
            else if (rut == "pass")
            {
                MessageBox.Show("you enterd Password That alredy Exist", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            }
            else
            {

            DialogResult result = MessageBox.Show("Are you sure You want To register ???","Question",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
            Muser obj = new Muser(int.Parse(textBoxID.Text), txtboxName.Text, txtBoxPassword.Text, gender, txtBoxPnumber.Text, Cbox.SelectedItem.ToString(), int.Parse(txtBoxAge.Text));
                MuserDL.AddUserToList(obj);
                MuserDL.UserDataTofile();
                MessageBox.Show("You Registered Successfully !!!","Note" ,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBoxAge.Clear();
            txtboxName.Clear();
            txtBoxPassword.Clear();
            txtBoxPnumber.Clear();
            Cbox.Text="Select...";
            textBoxID.Clear();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Loginform loginform=new Loginform();
            loginform.Show();
            this.Hide();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            txtboxName.Select();
        }

        private void lblPnumber_Click(object sender, EventArgs e)
        {
            txtBoxPnumber.Select();
        }

        private void lblAge_Click(object sender, EventArgs e)
        {
            txtBoxAge.Select();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            txtBoxPassword.Select();
        }

        private void lblRoll_Click(object sender, EventArgs e)
        {
            Cbox.Select();
        }
        private string checkGender()
        { string gender = "";
            if (radioBtnMale.Checked == true)
            {
                gender = radioBtnMale.Text;
            }
            if (radioBtnFemale.Checked == true)
            {
                gender = radioBtnFemale.Text;
            }
            return gender;
        }
   
        private void signup_Load(object sender, EventArgs e)
        {
         
        }

        private void txtboxName_TextChanged(object sender, EventArgs e)
        {
            txtboxName.MaxLength = 8;
        }

        private void txtBoxAge_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxAge.Text != "")
                {
                    int.Parse(txtBoxAge.Text);
            txtBoxAge.MaxLength = 3;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBoxPnumber_TextChanged(object sender, EventArgs e)
        {
   txtBoxPnumber.MaxLength = 11;
        }
        private void lblID_Click(object sender, EventArgs e)
        {
            textBoxID.Select();
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxID.Text != "")
                {
                    int.Parse(textBoxID.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Exit ???", "Question ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
