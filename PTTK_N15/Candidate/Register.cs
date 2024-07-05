using BUS;
using System;
using System.Windows.Forms;

namespace PTTK_N15.Candidate
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void loginBack_lablel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string response = "";
            CandidateBUS.createAUser(userNameTB.Text,passwordTB.Text,recheckPassTB.Text,
                candidateNameTB.Text,genderCB.Text,addressTB.Text,cccdTB.Text,emailTB.Text,phoneNumberTB.Text,ref response);
            if (response == "")
            {
                MessageBox.Show("Đăng ký thành công");
                this.Dispose();
            }
            else
            {
                MessageBox.Show(response);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void genderCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
