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
    public partial class Rental : Form
    {
        private string name;
        private int ID;
        public Rental(string name, int id)
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
        private void Rental_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data.Columns.Add("Reg Number");
            data.Columns.Add("Class");
            data.Columns.Add("Ppd");
            data.Columns.Add("Color");
            data.Columns.Add("Model");
            data.Columns.Add("Brand");
            for (int i = 0; i < CustomerDL.CustomerList.Count; i++)
            {
                 for(int j=0; j< CustomerDL.CustomerList[i].Car.Count; j++)
                 {
                     data.Rows.Add(CustomerDL.CustomerList[i].Car[j].Reg_number, CustomerDL.CustomerList[i].Car[j].Car_class, CustomerDL.CustomerList[i].Car[j].Ppd, CustomerDL.CustomerList[i].Car[j].Color,CustomerDL.CustomerList[i].Car[j].Model,CustomerDL.CustomerList[i].Car[j].Brand);
                 }
            }
            GVCandC.DataSource= data;
        }
    }
}
