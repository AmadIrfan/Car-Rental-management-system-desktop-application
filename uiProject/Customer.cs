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
    public partial class Customer : Form
    {
        private string name;
        private int ID;
        public Customer(string name, int id)
        {
            this.name = name;
            this.ID = id;
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(name,ID);
            adminForm.Show();
            this.Close();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Exit ???", "Question ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            DataTable data=new DataTable();
            data.Columns.Add("Cust Name");
            data.Columns.Add("Cust ID");
            data.Columns.Add("From Date");
            data.Columns.Add("To Date");
            for(int i=0; i < CustomerDL.CustomerList.Count; i++)
            {
                data.Rows.Add(CustomerDL.CustomerList[i].CustName, CustomerDL.CustomerList[i].CustID, CustomerDL.CustomerList[i].FromDate, CustomerDL.CustomerList[i].Todate);
            }
            GVCustomers.DataSource =data;
        }
    }
}
