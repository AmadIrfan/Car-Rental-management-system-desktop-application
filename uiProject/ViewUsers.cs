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
    public partial class user : Form
    {
        private string name;
        private int ID;
        public user(string name,int id)
        {
            this.name = name;
            this.ID = id;
            InitializeComponent();
           
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {
            GVusers.DataSource = MuserDL.userList;
        }
        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Exit ???", "Question ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void lblExit_MouseMove(object sender, MouseEventArgs e)
        {
            lblExit.BackColor = Color.White;
            lblExit.ForeColor = Color.Red;
            lblExit.BorderStyle = BorderStyle.FixedSingle;
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.BackColor = Color.Red;
            lblExit.ForeColor = Color.White;
            lblExit.BorderStyle = BorderStyle.None;;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string name, password, role, phoneNumber, gender;
            int age,ID;
            string rut;
            ID = int.Parse(txtBoxId.Text);
            name = txtboxName.Text;
            password = txtBoxPassword.Text;
            phoneNumber = txtBoxPnumber.Text;
            age = int.Parse(txtBoxAge.Text);
            role = Cbox.SelectedItem.ToString();
            gender = checkGender();
           rut= MuserDL.checkNewUser(name,ID,password);
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

            DialogResult result = MessageBox.Show("Are you sure You want To register a user ???", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Muser obj = new Muser(ID,name, password, gender, phoneNumber, role, age);
                MuserDL.AddUserToList(obj);
                MessageBox.Show("You Registered Successfully !!!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataBind();
                }
            }
        }
        private string checkGender()
        {
            string gender = "";
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminform = new AdminForm(name,ID);
            adminform.Show();
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            int id,index;
            id = int.Parse(txtBoxId.Text);
            Muser obj = new Muser(id);
           index= MuserDL.searchDataFromList(obj);
            if (index != -1)
            {
                DialogResult result = MessageBox.Show("Data Founded","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
                if (result==DialogResult.OK)
                {
                    MuserDL.DeleteDataFromList(index);
                    MessageBox.Show("Data deleted", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    dataBind();
                }     
            }
            else
            {
                MessageBox.Show("Data Not Founded", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtBoxId.Select();
        }
        
        public void dataBind()
        {
            GVusers.DataSource = null;
            GVusers.DataSource = MuserDL.userList;
            GVusers.Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        { string phone,name,pass,role,gender="";
            int id, age;
            bool Edited=false;
            name=txtboxName.Text;
            age=int.Parse(txtBoxAge.Text);
            id=int.Parse(txtBoxId.Text);
            pass=txtBoxPassword.Text;
            phone=txtBoxPnumber.Text;
            role=Cbox.SelectedItem.ToString();
            if (radioBtnFemale.Checked == true)
            {
                gender="Male";
            }
            else if (radioBtnMale.Checked==true)
            {
                gender="Female";
            }

            Edited=MuserDL.EditDataMUser(id,name,pass,gender,phone, role, age);
            if (Edited == true)
            {
         MessageBox.Show("Data Edited Sussesfully", " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dataBind();
            }
            else
            {
         MessageBox.Show("Data not founded ", " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
        private void lblExit_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Exit ???", "Question ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void GVusers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string gender="";
            Muser users = (Muser)GVusers.CurrentRow.DataBoundItem;
            txtboxName.Text = users.Name.ToString();
            txtBoxPassword.Text = users.Password.ToString();
            gender = users.Gender.ToString();
            txtBoxAge.Text =users.Age.ToString();
            txtBoxPnumber.Text = users.PhoneNumber.ToString();
            Cbox.Text = users.Role.ToString();
            txtBoxId.Text = users.iD.ToString();
            if (gender == "Male")
            {
                radioBtnMale.Checked = true;
                radioBtnFemale.Checked = false;
            }
            else if (gender == "Female")
            {
                radioBtnMale.Checked = false;
                radioBtnFemale.Checked = true;
            }
            else
            {
                radioBtnMale.Checked = false;
                radioBtnFemale.Checked = false;
            }
        }

        private void txtBoxId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxId.Text != "")
                {
                    int.Parse(txtBoxId.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBoxAge_TextChanged(object sender, EventArgs e)
        {
            txtBoxAge.MaxLength = 2;
            try
            {
                if (txtBoxAge.Text != "")
                {
                    int.Parse(txtBoxAge.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
