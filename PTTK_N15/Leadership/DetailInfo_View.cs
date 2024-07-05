using DTO;
using System;
using System.Windows.Forms;

namespace PTTK_N15.Leadership
{
    public partial class DetailInfo_View : Form
    {
        private ContractDTO contractDTO;
        public DetailInfo_View(ContractDTO _contractDTO)
        {
            InitializeComponent();
            contractDTO = _contractDTO;
            DetailInfo_View_Load();

        }

        private void DetailInfo_View_Load()
        {
            this.detailInfoPanel.Controls.Clear();
            this.detailInfoPanel.Controls.Add(new ContractDetail_View(contractDTO));
            this.SuspendLayout();
            
        }

        private void DetailInfo_View_Load(object sender, EventArgs e)
        {

        }
    }
}
