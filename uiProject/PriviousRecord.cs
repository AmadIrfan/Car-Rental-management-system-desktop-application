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
    public partial class PriviousRecord : Form
    {
        private string name;
        private int ID;
        public PriviousRecord(string name,int iD)
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
            UserForm userForm=new UserForm(name,ID);
            userForm.Show();
            this.Hide();

        }

        private void PriviousRecord_Load(object sender, EventArgs e)
        {
            
            DataTable data = new DataTable();
            data.Columns.Add("Cust Name");
            data.Columns.Add("Cust ID");
            data.Columns.Add("Reg Number");
            data.Columns.Add("Class");
            data.Columns.Add("Ppd");
            data.Columns.Add("Color");
            data.Columns.Add("Model");
            data.Columns.Add("Brand");
            data.Columns.Add("From Date");
            data.Columns.Add("To Date");
            for (int i = 0; i < CustomerDL.CustomerList.Count; i++)
            {
                if (CustomerDL.CustomerList[i].CustName==name&& CustomerDL.CustomerList[i].CustID==ID)
                {
                for (int j = 0; j < CustomerDL.CustomerList[i].Car.Count; j++)
                {
                    data.Rows.Add(CustomerDL.CustomerList[i].CustName, CustomerDL.CustomerList[i].CustID, CustomerDL.CustomerList[i].Car[j].Reg_number, CustomerDL.CustomerList[i].Car[j].Car_class, CustomerDL.CustomerList[i].Car[j].Ppd, CustomerDL.CustomerList[i].Car[j].Color, CustomerDL.CustomerList[i].Car[j].Model, CustomerDL.CustomerList[i].Car[j].Brand, CustomerDL.CustomerList[i].FromDate, CustomerDL.CustomerList[i].Todate);
                }
                }
            }
            GVuserpri.DataSource=data;
        }
    }
}
