using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace PTTK_N15.Leadership
{
    public partial class ContractDetail_View : UserControl
    {
        private ContractDTO contractDTO;
        public ContractDetail_View(ContractDTO _contractDTO)
        {
            InitializeComponent();
            infoRouteBtn.Enabled = false;
            contractDTO = _contractDTO;
            ContractDetail_View_Load();

        }

        private void businessRouteBtn_Click(object sender, EventArgs e)
        {
            int idContract = int.Parse(txtContractCode.Text);
            infoContractPanel.Controls.Clear();
            infoContractPanel.Controls.Add(new BusinessDetail_View(idContract));
        }

        private void ContractDetail_View_Load()
        {

            if (contractDTO != null)
            {
                txtContractCode.Text = contractDTO.idContract.ToString();
                txtContractName.Text = contractDTO.nameContract.ToString();
                txtSignDate.Text = contractDTO.signDate.ToString("dd/MM/yyyy");
                txtIdRecruimentForm.Text = contractDTO.idRecruimentForm.ToString();
                dtpExpiryDate.Value = contractDTO.outOfDate;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpExpiryDate.Value;

            DateTime currentDate = DateTime.Now;

            if (contractDTO != null)
            {
                // Check if OutOfDate is less than SignDate
                if (selectedDate <= contractDTO.signDate || selectedDate < currentDate.Date || ContractBUS.checkDate(selectedDate))
                {
                    MessageBox.Show("Error: Ngày hết hạn không được trước ngày ký hoặc ngày hiện tại.");
                    return;
                }
                contractDTO.outOfDate = selectedDate;

                bool updateSuccessful = ContractBUS.updateOutOfDate(contractDTO);

                if (updateSuccessful)
                {
                    MessageBox.Show("Gia hạn thành công.");
                }
                else
                {
                    MessageBox.Show("Gia hạn thất bại.");
                }
            }
            else
            {
                MessageBox.Show("Error: Không tìm thấy hợp đồng.");
            }
        }

    }
}
