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
    public partial class UserDash : Form
    {
            private string name;
        private int ID;
        public UserDash(string name,int iD)
        {
            this.name = name;
            this.ID = iD;
            InitializeComponent();
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
            UserForm frm = new UserForm(name,ID);
            frm.Show();
            this.Hide();
        }

        private void UserDash_Load(object sender, EventArgs e)
        {
            int index = 0;
            for(int i = 0; i <CustomerDL.CustomerList.Count; i++)
            {
                if (ID == CustomerDL.CustomerList[i].CustID && name == CustomerDL.CustomerList[i].CustName)
                    index++;
            }
            lblcarnumber.Text=index.ToString();
            label2.Text = name;
            label4.Text=ID.ToString();
        }
    }
}
