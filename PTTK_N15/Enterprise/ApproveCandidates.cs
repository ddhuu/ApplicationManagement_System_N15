﻿using BUS;
using DTO;
using PTTK_N15.Candidate;
using PTTK_N15.Recruiter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PTTK_N15.Enterprise
{
    public partial class ApproveCandidates : Form
    {
        private BindingSource bindingSource;
        private int postID;
        private MainFrame mainFrame;
        public event EventHandler dataUpdated;

        public delegate void PostSuccessHandler();
        public event PostSuccessHandler PostSuccessEvent;
        public ApproveCandidates(int postID, MainFrame mainFrame)
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            bindingSource.DataSource = ApplicationBUS.getAllApplicationOfAPost(postID, EnterpriseBUS.getEnterpriseID(mainFrame.UserName));
            this.postID = postID;
            AppproveCandidate_Load();
            this.mainFrame = mainFrame;



        }
        private void AppproveCandidate_Load()
        {
            applicationList.AutoGenerateColumns = false;
            applicationList.DataSource = bindingSource;

            string eyeIconPath = @"..\..\Resource\eye-icon.png";
            DataGridViewImageColumn eyeIconColumn = new DataGridViewImageColumn();
            eyeIconColumn.Name = "ViewDetails";
            eyeIconColumn.HeaderText = "CHI TIẾT";
            eyeIconColumn.Image = Image.FromFile(eyeIconPath); // Ensure you have this resource
            eyeIconColumn.DefaultCellStyle.Padding = new Padding(0);
            applicationList.Columns.Add(eyeIconColumn);

            var toggleColumn = new DataGridViewCheckBoxColumn();
            toggleColumn.HeaderText = "DUYỆT";
            toggleColumn.Name = "Accept";
            applicationList.Columns.Add(toggleColumn);
        }

        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            List<KeyValuePair<int, string>> applicationStatus = new List<KeyValuePair<int, string>>();
            foreach (DataGridViewRow row in applicationList.Rows)
            {
                if (row.Cells["ApplicationID"].Value != null)
                {

                    int applicationID = Convert.ToInt32(row.Cells["ApplicationID"].Value);
                    bool isChecked = Convert.ToBoolean(row.Cells["Accept"].Value);
                    string status = "Không đạt";
                    if (isChecked)
                    {
                        status = "Đạt";
                    }

                    applicationStatus.Add(new KeyValuePair<int, string>(applicationID, status));

                }

            }

            int count = ApplicationBUS.changeApplicationStatus(applicationStatus);
            string pair = "";
            foreach (var entry in applicationStatus)
            {
                pair += entry.Key.ToString() + entry.Value;
            }

            MessageBox.Show("Duyệt thành công.");
/*            dataUpdated?.Invoke(this, EventArgs.Empty);*/
            this.Dispose();
            int enterpriseID;
            if (mainFrame.Role.Equals("DoanhNghiep"))
            {
                enterpriseID = EnterpriseBUS.getEnterpriseID(mainFrame.UserName);
            }
            else
            {
                enterpriseID = 0;
            }
            /*mainFrame.Refresh();
            var postToProcess = new PostToProcess_View(enterpriseID, mainFrame);
*//*            postToProcess.ReLoadData();*//*
            mainFrame.Show();
            mainFrame.OpenChildForm(postToProcess, sender);*/
            PostSuccessEvent?.Invoke();
            this.Close();
        }

        private void ApproveCandidates_Load(object sender, EventArgs e)
        {

        }

        private void applicationList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (applicationList.Columns[e.ColumnIndex].Name == "ViewDetails")
            {
                if (e.RowIndex >= 0 && e.RowIndex < applicationList.Rows.Count)
                {
                    DataGridViewRow row = applicationList.Rows[e.RowIndex];
                    int applicationID = Convert.ToInt32(row.Cells["ApplicationID"].Value);
                    ApplicationDetailDTO item = ApplicationBUS.viewApplicantDetail(applicationID);
                    var applicationDetails = new ApplicationDetail(item);
                    applicationDetails.Show();

                }
            }
            else if (applicationList.Columns[e.ColumnIndex].Name == "Accept")
            {

                if (e.RowIndex >= 0 && e.RowIndex < applicationList.Rows.Count)
                {
                    DataGridViewRow row = applicationList.Rows[e.RowIndex];
                    bool isChecked = Convert.ToBoolean(row.Cells["Accept"].Value);
                    row.Cells["Accept"].Value = !isChecked;

                }

            }
        }
    }
}
