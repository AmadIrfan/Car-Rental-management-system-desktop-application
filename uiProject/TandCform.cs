using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uiProject
{
    public partial class TandCform : Form
    {
        public TandCform()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Loginform loginform = new Loginform();
            loginform.Show();
            this.Hide();
        }

        private void lblExit_Paint(object sender, PaintEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Exit ???", "Question ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void TandCform_Load(object sender, EventArgs e)
        {

        }
    }
}
