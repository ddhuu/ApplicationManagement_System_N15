﻿using System;
using System.Windows.Forms;

namespace PTTK_N15
{
    public partial class Login : Form
    {
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
    }
}
