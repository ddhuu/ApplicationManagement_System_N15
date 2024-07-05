using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PTTK_N15.Leadership
{
    public partial class BusinessDetail_View : UserControl
    {
        private ContractDTO contractDTO;
        private EnterpriseDTO enterpriseDTO;
        private List<StrategyDTO> strategyDTO;
        private BindingSource bindingSource;
        public BusinessDetail_View(int idContract)
        {
            InitializeComponent();
            contractDTO = new ContractDTO();
            contractDTO.idContract = idContract;
            enterpriseDTO = new EnterpriseDTO();
            strategyDTO = new List<StrategyDTO>();
            bindingSource = new BindingSource();
            businessRouteBtn.Enabled = false;
            txtEmail.Enabled = false;
            txtEnterpriseCode.Enabled = false;
            txtEnterpriseName.Enabled = false;
            txtRepresentative.Enabled = false;

            BusinessDetail_View_Load();
        }

        private void BusinessDetail_View_Load()
        {
            enterpriseDTO = EnterpriseBUS.getBusinessByContractID(contractDTO.idContract);
            positionList.AutoGenerateColumns = false;
            positionList.DataSource = EnterpriseBUS.getPositions(contractDTO.idContract);

            if (enterpriseDTO != null)
            {
                txtEnterpriseCode.Text = enterpriseDTO.idEnterprise.ToString();
                txtEnterpriseName.Text = enterpriseDTO.nameEnterprise;
                txtEmail.Text = enterpriseDTO.email;
                txtRepresentative.Text = enterpriseDTO.representative;
                switch (enterpriseDTO.potential)
                {
                    case 0:
                        potentialCombobox.SelectedItem = "Không có";
                        break;
                    case 1:
                        potentialCombobox.SelectedItem = "Tiềm năng";
                        break;
                    case 3:
                        potentialCombobox.SelectedItem = "Tiềm năng lớn";
                        break;
                    default:
                        potentialCombobox.SelectedItem = "";
                        break;
                }
                strategyDTO = StrategyBUS.GetStrategies(enterpriseDTO.idEnterprise);
                foreach(var strategy in strategyDTO)
                {
                    string formattedItem = $"{strategy.idStrategy}. {strategy.nameStrategy} - {strategy.amountEndow}%";
                    strategyCombobox.Items.Add(formattedItem);
                }
                potentialCombobox.SelectedIndexChanged += PotentialCombobox_SelectedIndexChanged;
                if (enterpriseDTO.potential == 2) // Check for "Tiềm năng lớn"
                {
                    strategyCombobox.Enabled = true;
                    potentialCombobox.SelectedItem = "Tiềm năng lớn";
                }
                else
                {
                    strategyCombobox.Enabled = false;
                }
            }
            else
            {
                // Handle case where enterpriseDTO is null
                txtEnterpriseCode.Text = string.Empty;
                txtEnterpriseName.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtRepresentative.Text = string.Empty;
            }

            /*positionList.Rows.Add(1, "Software Engineer", 15);
            positionList.Rows.Add(2, "Database Administrator", 16);
            positionList.Rows.Add(3, "Data Analyst", 17);*/

            positionList.RowPostPaint += new DataGridViewRowPostPaintEventHandler(positionList_RowPostPaint);
            
        }

        private void PotentialCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (potentialCombobox.SelectedItem != null && potentialCombobox.SelectedItem.ToString() == "Tiềm năng lớn")
            {
                strategyCombobox.Enabled = true;
            }
            else
            {
                strategyCombobox.Enabled = false;
            }
        }

        private void positionList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Set the value of the first cell to the row index + 1 (for 1-based numbering)
            positionList.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void infoRouteBtn_Click(object sender, EventArgs e)
        {
            contractDTO = ContractBUS.getDetailContract(enterpriseDTO.idEnterprise);
            infoBusinessPanel.Controls.Clear();
            infoBusinessPanel.Controls.Add(new ContractDetail_View(contractDTO));
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string potentialTxt = potentialCombobox.SelectedItem as string;
            switch (potentialTxt)
            {
                case "Không có":
                    enterpriseDTO.potential = 0;
                    break;
                case "Tiềm năng":
                    enterpriseDTO.potential = 1;
                    break;
                case "Tiềm năng lớn":
                    enterpriseDTO.potential = 2;
                    break;
                default:
                    enterpriseDTO.potential = 0;
                    break;
            }

            int idStrategy = 0;
            if (strategyCombobox.SelectedItem != null)
            {
                int periodIndex = strategyCombobox.SelectedItem.ToString().IndexOf('.');
                if (periodIndex > 0)
                {
                    string temp = strategyCombobox.SelectedItem.ToString().Substring(0, periodIndex).Trim();
                    if (!int.TryParse(temp, out idStrategy))
                    {
                        Console.WriteLine("Failed to parse the number.");
                    }
                }
            }

            int idEnterprise = 0;
            if (!int.TryParse(txtEnterpriseCode.Text, out idEnterprise))
            {
                Console.WriteLine("Failed to parse the number.");
            }

            bool updateEnterprise = EnterpriseBUS.updateEnterprise(enterpriseDTO);
            bool insertStraEnter = true;

            if (enterpriseDTO.potential == 2 && strategyCombobox.SelectedItem != null)
            {
                insertStraEnter = StrategyBUS.insertStrategyEnterprise(idEnterprise, idStrategy);
            }

            if (updateEnterprise && (enterpriseDTO.potential != 2 || (enterpriseDTO.potential == 2 && strategyCombobox.SelectedItem != null) || insertStraEnter))
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }

            if (enterpriseDTO.potential != 2)
            {
                strategyCombobox.Enabled = false;
            }
        }

    }
}
