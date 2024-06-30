using System.Windows.Forms;

namespace PTTK_N15
{
    partial class Login
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxPassWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.registerForUVBtn = new Guna.UI2.WinForms.Guna2Button();
            this.registerForDNBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(195)))), ((int)(((byte)(231)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 752);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(15, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 31);
            this.label3.TabIndex = 50;
            this.label3.Text = "Hệ thống quản lí hồ sơ ứng tuyển";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(133, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 66);
            this.label1.TabIndex = 50;
            this.label1.Text = "ABC";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(195)))), ((int)(((byte)(231)))));
            this.label2.Location = new System.Drawing.Point(677, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đăng nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(505, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(501, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tài khoản";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // tbxUserName
            // 
            this.tbxUserName.BorderRadius = 5;
            this.tbxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxUserName.DefaultText = "";
            this.tbxUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxUserName.Location = new System.Drawing.Point(604, 182);
            this.tbxUserName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.PasswordChar = '\0';
            this.tbxUserName.PlaceholderText = "";
            this.tbxUserName.SelectedText = "";
            this.tbxUserName.Size = new System.Drawing.Size(332, 35);
            this.tbxUserName.TabIndex = 0;
            this.tbxUserName.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // tbxPassWord
            // 
            this.tbxPassWord.BorderRadius = 5;
            this.tbxPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPassWord.DefaultText = "";
            this.tbxPassWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxPassWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxPassWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPassWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPassWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxPassWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxPassWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxPassWord.Location = new System.Drawing.Point(604, 265);
            this.tbxPassWord.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbxPassWord.Name = "tbxPassWord";
            this.tbxPassWord.PasswordChar = '*';
            this.tbxPassWord.PlaceholderText = "";
            this.tbxPassWord.SelectedText = "";
            this.tbxPassWord.Size = new System.Drawing.Size(332, 35);
            this.tbxPassWord.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(195)))), ((int)(((byte)(231)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(626, 338);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(284, 52);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(670, 465);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(186, 22);
            this.guna2HtmlLabel1.TabIndex = 12;
            this.guna2HtmlLabel1.TabStop = false;
            this.guna2HtmlLabel1.Text = "Bạn chưa có tài khoản?";
            // 
            // registerForUVBtn
            // 
            this.registerForUVBtn.BorderRadius = 10;
            this.registerForUVBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registerForUVBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registerForUVBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registerForUVBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registerForUVBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(89)))), ((int)(((byte)(119)))));
            this.registerForUVBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.registerForUVBtn.ForeColor = System.Drawing.Color.White;
            this.registerForUVBtn.Location = new System.Drawing.Point(640, 519);
            this.registerForUVBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registerForUVBtn.Name = "registerForUVBtn";
            this.registerForUVBtn.Size = new System.Drawing.Size(244, 52);
            this.registerForUVBtn.TabIndex = 13;
            this.registerForUVBtn.TabStop = false;
            this.registerForUVBtn.Text = "Đăng kí cho ứng viên";
            this.registerForUVBtn.Click += new System.EventHandler(this.registerForUVBtn_Click);
            // 
            // registerForDNBtn
            // 
            this.registerForDNBtn.BorderRadius = 10;
            this.registerForDNBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registerForDNBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registerForDNBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registerForDNBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registerForDNBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(89)))), ((int)(((byte)(119)))));
            this.registerForDNBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.registerForDNBtn.ForeColor = System.Drawing.Color.White;
            this.registerForDNBtn.Location = new System.Drawing.Point(640, 598);
            this.registerForDNBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registerForDNBtn.Name = "registerForDNBtn";
            this.registerForDNBtn.Size = new System.Drawing.Size(244, 52);
            this.registerForDNBtn.TabIndex = 14;
            this.registerForDNBtn.TabStop = false;
            this.registerForDNBtn.Text = "Đăng kí cho doanh nghiệp";
            this.registerForDNBtn.Click += new System.EventHandler(this.registerForDNBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 742);
            this.Controls.Add(this.registerForDNBtn);
            this.Controls.Add(this.registerForUVBtn);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPassWord);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbxUserName;
        private Guna.UI2.WinForms.Guna2TextBox tbxPassWord;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button registerForUVBtn;
        private Guna.UI2.WinForms.Guna2Button registerForDNBtn;
    }
}

