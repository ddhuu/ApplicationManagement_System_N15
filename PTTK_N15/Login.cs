﻿using BUS;
using DTO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace PTTK_N15
{
    public partial class Login : Form

    {
        public static SqlConnection con = DBProvider.GetOpenConnection();
        public Login()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void registerForDNBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Enterprise.Register f = new Enterprise.Register();
            f.ShowDialog();
            this.Show();
        }

        private void registerForUVBtn_Click(object sender, EventArgs e)
        {

            Candidate.Register f = new Candidate.Register();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User result = UserBus.CheckLogin(tbxUserName.Text, tbxPassWord.Text);
            if (result != null)
            {
                // Thông báo đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!");
            }
            else
            {
                // Thông báo đăng nhập thất bại
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.");
            }
        }
    }
}
