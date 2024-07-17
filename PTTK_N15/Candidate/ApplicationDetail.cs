using DTO;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PTTK_N15.Candidate
{
    public partial class ApplicationDetail : Form
    {
        private BindingSource bindingSource;
        private ApplicationDetailDTO applicationDetailDTO1 = null;
        public ApplicationDetail(ApplicationDetailDTO applicationDetailDTO)
        {
            InitializeComponent();
            this.applicationDetailDTO1 = applicationDetailDTO;
            ApplicationDetail_Load();
        }
        

        private void ApplicationDetail_Load()
        {
            txtApplicantName.Text = applicationDetailDTO1.ApplicantName;
            txtApplicantName.Enabled = false;
            AddressTextBox.Text = applicationDetailDTO1.Address;
            EmailTextBox.Text = applicationDetailDTO1.Email; 
            PhoneNumberTextBox.Text = applicationDetailDTO1.PhoneNumber;
            DOBTextBox.Text = applicationDetailDTO1.DOB.ToString();
            EmailTextBox.Enabled = false;
            PhoneNumberTextBox.Enabled = false;
            AddressTextBox.Enabled = false;
            DOBTextBox.Enabled = false;
            //string path = "D:\\InformationSysDesign\\PTTK-N15\\PTTK_N15\\Resource\\CV.pdf";
            //LoadFile(path);

            LoadPDf(@"..\..\..\Resume\" + applicationDetailDTO1.record);



        }
        //public void LoadFile(string filePath)
        //{
        //    if(File.Exists(filePath))
        //    {
        //        FilePictureBox.Image = Image.FromFile(filePath);
        //    }
        //    else
        //    {
        //        MessageBox.Show("File not found!");
        //    }
        //}
        public void LoadPDf(string selectedFilePath)
        {
            if (!string.IsNullOrEmpty(selectedFilePath) && File.Exists(selectedFilePath))
            {
                Process.Start(new ProcessStartInfo(selectedFilePath) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("The file does not exist.");
            }

        }

        private void txtApplicantName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApplicationDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
