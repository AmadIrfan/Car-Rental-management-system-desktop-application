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
    public partial class CarsForm : Form
    {
        private string name;
        private int ID;
        public CarsForm(string name, int id)
        {
            this.name = name;
            this.ID = id;
            InitializeComponent();
        }

        private void CarsForm_Load(object sender, EventArgs e)
        {
            GVcars.DataSource = CarsDL.Carslist;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(name, ID);
            adminForm.Show();
            this.Hide();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if ( txtBoxbrand.Text == "" || txtBoxmodel.Text == "" || txtboxRnum.Text == "" || txtBoxcolor.Text == "" || txtBoxppd.Text == "" || txtBoxClass.Text == ""||cBoxavail.Text=="")
            {
                MessageBox.Show("Field is empty", "warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
               DialogResult result= MessageBox.Show("Are you sure to add car???","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Cars obj = new Cars(txtBoxbrand.Text,txtBoxmodel.Text,txtboxRnum.Text,txtBoxcolor.Text,int.Parse(txtBoxppd.Text),txtBoxClass.Text,cBoxavail.SelectedItem.ToString());
                    CarsDL.AddCarsToList(obj);
                    MessageBox.Show("Car Registered");
                    CarsDL.UserDataTofile();
                    dataBind();
                }
            }
        }
        private void GVcars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cars SelecetdCars = (Cars)GVcars.CurrentRow.DataBoundItem;
            txtboxRnum.Text = SelecetdCars.Reg_number;
            txtBoxbrand.Text = SelecetdCars.Brand;
            txtBoxmodel.Text = SelecetdCars.Model;
            txtBoxppd.Text = SelecetdCars.Ppd.ToString();
            txtBoxcolor.Text = SelecetdCars.Color;
            txtBoxClass.Text = SelecetdCars.Car_class;
            cBoxavail.Text = SelecetdCars.Availible.ToString();
        }
        public void dataBind()
        {
            GVcars.DataSource = null;
            GVcars.DataSource = CarsDL.Carslist;
            GVcars.Refresh();
        }
        private void txtBoxbrand_TextChanged(object sender, EventArgs e)
        {
            txtBoxbrand.MaxLength = 10;
        }
        private void txtBoxmodel_TextChanged(object sender, EventArgs e)
        {
            txtBoxmodel.MaxLength = 5;
        }
        private void txtBoxppd_TextChanged(object sender, EventArgs e)
        {
            txtBoxppd.MaxLength = 6;
            try
            {
                if (txtBoxppd.Text!="")
                {
                int.Parse(txtBoxppd.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtBoxcolor_TextChanged(object sender, EventArgs e)
        {
            txtBoxcolor.MaxLength = 10;
        }
        private void txtBoxCpass_TextChanged(object sender, EventArgs e)
        {
            txtBoxClass.MaxLength = 10;
        }
        private void txtboxName_TextChanged(object sender, EventArgs e)
        {
            txtboxRnum.MaxLength = 8;
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            string Reg_number;
            if ( txtboxRnum.Text == "" )
            {
                MessageBox.Show("Field is empty", "warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            int index;
            Reg_number = txtboxRnum.Text;
            Cars obj = new Cars(Reg_number);
            index = CarsDL.searchDataFromList(obj);
            if (index != -1)
            {
                DialogResult result = MessageBox.Show("Data Founded", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                  CarsDL.DeleteDataFromList(index);
                    MessageBox.Show("Data deleted", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    dataBind();
                }
            }
            else if(txtboxRnum.Text != "")
            {
                MessageBox.Show("Data Not Founded", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool Edited = false;
                DialogResult result = MessageBox.Show("Are You Sure TO Edit Data ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
            Edited=CarsDL.EditDataCars(txtboxRnum.Text, txtBoxbrand.Text, txtBoxmodel.Text, int.Parse(txtBoxppd.Text), txtBoxcolor.Text, txtBoxClass.Text, cBoxavail.Text);
                if (Edited==true)
                {
               
                    MessageBox.Show("Data Updated", "Note", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    dataBind();
                }
                else
                {
                    MessageBox.Show("Data Not Founded", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                }
            }
        }
        private void panel10_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Exit ???", "Question ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
