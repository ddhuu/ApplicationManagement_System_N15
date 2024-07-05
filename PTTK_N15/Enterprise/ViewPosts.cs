<<<<<<< HEAD
﻿using System.Windows.Forms;
=======
﻿using BUS;
using System;
using System.Data;
using System.Windows.Forms;
>>>>>>> 567736b8194d5d0b77c24218a907bd8b412ca159

namespace PTTK_N15.Enterprise
{
    public partial class ViewPosts : Form
    {
        private Form currentForm = null;
        public string UserRole = "";
        public string UserName = "";
        public int IdPost;

        public ViewPosts(string userName, string role)
        {
            InitializeComponent();
            this.UserName = userName;
            this.UserRole = role;
        }

        private void ViewPosts_Load(object sender, EventArgs e)
        {
            if (UserRole == "DoanhNghiep")
            {

                getListPostByUser();
                return;
            }

            else
            {
                return;
            }

        }



        private void getListPostByUser()
        {
            try
            {
                string userName = this.UserName;
                DataSet data = JobPostingBUS.GetPostByUser(userName);

                dgv_JobPost.AutoGenerateColumns = true;
                dgv_JobPost.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_JobPost.DataSource = data.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading DataGridView: " + ex.Message);
            }
        }



        private void OpenChildForm(Form childForm, object sender)
        {
            if (currentForm != null && currentForm.GetType() == childForm.GetType())
            {
                return;
            }

            if (currentForm != null)
            {
                this.Controls.Remove(currentForm);
                currentForm.Close();
            }


            childForm.FormClosed += (s, args) => currentForm = null;

            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.Controls.Add(childForm);
            this.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void dgv_JobPost_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_JobPost.Rows[e.RowIndex];

                if (selectedRow.Cells["ID"].Value != null)
                {
                    this.IdPost = Convert.ToInt32(selectedRow.Cells["ID"].Value.ToString());
                    OpenChildForm(new PostDetail(IdPost), sender);
                }
            }
        }
    }
}
