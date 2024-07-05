namespace PTTK_N15
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbUserRole = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSignOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewPosts = new Guna.UI2.WinForms.Guna2Button();
            this.btnPostJob = new Guna.UI2.WinForms.Guna2Button();
            this.btnRequestPost = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnlCommon111 = new System.Windows.Forms.Panel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lbUserRole);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(195)))), ((int)(((byte)(231)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(258, 595);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lbUserRole
            // 
            this.lbUserRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(195)))), ((int)(((byte)(231)))));
            this.lbUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserRole.Location = new System.Drawing.Point(12, 49);
            this.lbUserRole.Name = "lbUserRole";
            this.lbUserRole.Size = new System.Drawing.Size(229, 34);
            this.lbUserRole.TabIndex = 4;
            this.lbUserRole.Text = "User";
            this.lbUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(195)))), ((int)(((byte)(231)))));
            this.guna2Panel2.Controls.Add(this.btnSignOut);
            this.guna2Panel2.Controls.Add(this.btnViewPosts);
            this.guna2Panel2.Controls.Add(this.btnPostJob);
            this.guna2Panel2.Controls.Add(this.btnRequestPost);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 107);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(255, 502);
            this.guna2Panel2.TabIndex = 3;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // btnSignOut
            // 
            this.btnSignOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(195)))), ((int)(((byte)(231)))));
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSignOut.ForeColor = System.Drawing.Color.Black;
            this.btnSignOut.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Image")));
            this.btnSignOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSignOut.Location = new System.Drawing.Point(48, 442);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(160, 36);
            this.btnSignOut.TabIndex = 9;
            this.btnSignOut.Text = "Đăng xuất";
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnViewPosts
            // 
            this.btnViewPosts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewPosts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewPosts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewPosts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewPosts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(195)))), ((int)(((byte)(231)))));
            this.btnViewPosts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewPosts.ForeColor = System.Drawing.Color.Black;
            this.btnViewPosts.Image = ((System.Drawing.Image)(resources.GetObject("btnViewPosts.Image")));
            this.btnViewPosts.Location = new System.Drawing.Point(0, 109);
            this.btnViewPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewPosts.Name = "btnViewPosts";
            this.btnViewPosts.Size = new System.Drawing.Size(255, 59);
            this.btnViewPosts.TabIndex = 8;
            this.btnViewPosts.Text = "Xem bài đăng tuyển";
            this.btnViewPosts.Click += new System.EventHandler(this.btnXemBaiDangTuyen_Click_1);
            // 
            // btnPostJob
            // 
            this.btnPostJob.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPostJob.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPostJob.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPostJob.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPostJob.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(195)))), ((int)(((byte)(231)))));
            this.btnPostJob.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPostJob.ForeColor = System.Drawing.Color.Black;
            this.btnPostJob.Image = ((System.Drawing.Image)(resources.GetObject("btnPostJob.Image")));
            this.btnPostJob.Location = new System.Drawing.Point(0, 50);
            this.btnPostJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPostJob.Name = "btnPostJob";
            this.btnPostJob.Size = new System.Drawing.Size(255, 59);
            this.btnPostJob.TabIndex = 6;
            this.btnPostJob.Text = "Đăng tuyển dụng";
            this.btnPostJob.Click += new System.EventHandler(this.btnPostJob_Click);
            // 
            // btnRequestPost
            // 
            this.btnRequestPost.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRequestPost.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRequestPost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRequestPost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRequestPost.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRequestPost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(195)))), ((int)(((byte)(231)))));
            this.btnRequestPost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRequestPost.ForeColor = System.Drawing.Color.Black;
            this.btnRequestPost.Image = ((System.Drawing.Image)(resources.GetObject("btnRequestPost.Image")));
            this.btnRequestPost.Location = new System.Drawing.Point(0, 0);
            this.btnRequestPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRequestPost.Name = "btnRequestPost";
            this.btnRequestPost.Size = new System.Drawing.Size(255, 50);
            this.btnRequestPost.TabIndex = 5;
            this.btnRequestPost.Text = "Yêu cầu đăng tuyển";
            this.btnRequestPost.Click += new System.EventHandler(this.btnRequestPost_Click_1);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(36, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 2);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(699, 36);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(369, 39);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Yêu cầu đăng tuyển";
            // 
            // pnlCommon111
            // 
            this.pnlCommon111.Location = new System.Drawing.Point(268, 77);
            this.pnlCommon111.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCommon111.Name = "pnlCommon111";
            this.pnlCommon111.Size = new System.Drawing.Size(1024, 580);
            this.pnlCommon111.TabIndex = 3;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1317, 595);
            this.Controls.Add(this.pnlCommon111);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrame";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnRequestPost;
        private Guna.UI2.WinForms.Guna2Button btnPostJob;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnlCommon111;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lbUserRole;
        private Guna.UI2.WinForms.Guna2Button btnViewPosts;
        private Guna.UI2.WinForms.Guna2Button btnSignOut;
    }
}