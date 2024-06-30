using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK_N15.Enterprise
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }


        private void label12_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void registerBtn_Click(object sender, EventArgs e)
        {
            string response = "";
            EnterpriseBUS.createAUser(userNameTB.Text,passwordTB.Text,recheckPassTB.Text,companyNameTB.Text,
                taxCodeTB.Text,nameDDTB.Text,addressTB.Text,emailTB.Text,ref response);
            if(response == "")
            {
                MessageBox.Show("Đăng ký thành công");
                this.Dispose();
            }
            else
            {
                MessageBox.Show(response);
            }
        }
    }
}
