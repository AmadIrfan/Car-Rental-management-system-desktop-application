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
    public partial class BookCars : Form
    {
       // DataTable data =null;
        private string Name1;
        private int ID;
        public BookCars(string Name1,int iD)
        {
            this.Name1 = Name;
            this.ID = iD;
            InitializeComponent();
        }
        private void BookCars_Load(object sender, EventArgs e)
        {
            txtBoxID.ReadOnly = true;
            txtName.ReadOnly = true;
            txtBoxID.Text = ID.ToString();
            txtName.Text = Name1;
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
               for(int j=0; j< CustomerDL.CustomerList[i].Car.Count; j++)
               {
                   data.Rows.Add(CustomerDL.CustomerList[i].CustName, CustomerDL.CustomerList[i].CustID, CustomerDL.CustomerList[i].Car[j].Reg_number, CustomerDL.CustomerList[i].Car[j].Car_class, CustomerDL.CustomerList[i].Car[j].Ppd, CustomerDL.CustomerList[i].Car[j].Color, CustomerDL.CustomerList[i].Car[j].Model, CustomerDL.CustomerList[i].Car[j].Brand, CustomerDL.CustomerList[i].FromDate, CustomerDL.CustomerList[i].Todate);
               }
            }
            GVbookcars.DataSource = data;
            GVcars.DataSource = CarsDL.Carslist;
        }
        private void btnselect_Click(object sender, EventArgs e)
        {
            Cars car = (Cars)GVcars.CurrentRow.DataBoundItem;
            txtboxRnum.Text=car.Reg_number.ToString();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            UserForm userForm=new UserForm(Name1 ,ID);
            userForm.Show();
            this.Close();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Exit ???", "Question ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Btnbook_Click(object sender, EventArgs e)
        {
            Cars temp;
            List<Cars> cars = new List<Cars>();
            temp = CarsDL.findCars(txtboxRnum.Text);
            cars.Add(temp);
            Customers customer = new Customers(Name,ID,DPStart.Text,DPEND.Text,cars);
            CustomerDL.AddCustomerToList(customer);
            dataBind();
            MessageBox.Show("you booked a car");
        }

        public void dataBind()
        {
           // GVbookcars.DataSource = null;
         //   GVbookcars.DataSource = data;
            GVbookcars.Refresh();
        }
        private void txtboxRnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void GVcars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cars car = (Cars)GVcars.CurrentRow.DataBoundItem;
            txtboxRnum.Text = car.Reg_number.ToString();
        }

        private void txtBoxID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxID.Text != "")
                {
                    int.Parse(txtBoxID.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
