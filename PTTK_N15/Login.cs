using BUS;
using DTO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace PTTK_N15
{
    public partial class Login : Form


    {
        public event EventHandler btnClick;
        public static SqlConnection conn;
        public Login()
        {
            InitializeComponent();
            conn = DBProvider.GetOpenConnection();
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
            string response = ""; // Dùng kiểm tra đăng nhập do sai mật khẩu hoặc không tồn tại
            User result = UserBus.CheckLogin(tbxUserName.Text, tbxPassWord.Text, ref response);
            if (result != null)
            {
                MainFrame mf = new MainFrame(result.UserName, result.Role);
                this.Hide();
                mf.ShowDialog();
                this.Show();
                
            }
            else
            {
                if(response == "WRONGPASS")
                {
                    // Thông báo đăng nhập thất bại do sai mật khẩu
                    MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại mật khẩu.");
                }
                else if(response == "NOTFOUND")
                {
                    MessageBox.Show("Đăng nhập thất bại. Tài khoản không tồn tại" +
                        ", vùi lòng đăng ký ứng viện hoặc doanh nghiệp");
                }
                else
                {
                    MessageBox.Show(response);
                }               
            }
        }
    }
}
