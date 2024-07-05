namespace PTTK_N15.Recruiter
{
    partial class ProcessApplication
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SendListBtn = new Guna.UI2.WinForms.Guna2Button();
            this.applicationList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameContractCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.ViewPostDetailBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.applicationList)).BeginInit();
            this.SuspendLayout();
            // 
            // SendListBtn
            // 
            this.SendListBtn.BorderRadius = 10;
            this.SendListBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SendListBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SendListBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SendListBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SendListBtn.FillColor = System.Drawing.Color.LightSkyBlue;
            this.SendListBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SendListBtn.ForeColor = System.Drawing.Color.White;
            this.SendListBtn.Location = new System.Drawing.Point(734, 465);
            this.SendListBtn.Name = "SendListBtn";
            this.SendListBtn.Size = new System.Drawing.Size(153, 45);
            this.SendListBtn.TabIndex = 39;
            this.SendListBtn.Text = "Gửi hồ sơ";
            this.SendListBtn.Click += new System.EventHandler(this.SendListBtn_Click);
            // 
            // applicationList
            // 
            this.applicationList.AllowUserToAddRows = false;
            this.applicationList.AllowUserToDeleteRows = false;
            this.applicationList.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.applicationList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.applicationList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.applicationList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.applicationList.ColumnHeadersHeight = 42;
            this.applicationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.applicationList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApplicationID,
            this.nameContractCol,
            this.signDateCol});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.applicationList.DefaultCellStyle = dataGridViewCellStyle16;
            this.applicationList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.applicationList.Location = new System.Drawing.Point(36, 153);
            this.applicationList.Margin = new System.Windows.Forms.Padding(4);
            this.applicationList.Name = "applicationList";
            this.applicationList.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.applicationList.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.applicationList.RowHeadersVisible = false;
            this.applicationList.RowHeadersWidth = 51;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.applicationList.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.applicationList.Size = new System.Drawing.Size(823, 280);
            this.applicationList.TabIndex = 40;
            this.applicationList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.applicationList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.applicationList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.applicationList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.applicationList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.applicationList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.applicationList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.applicationList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.applicationList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.applicationList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.applicationList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.applicationList.ThemeStyle.HeaderStyle.Height = 42;
            this.applicationList.ThemeStyle.ReadOnly = true;
            this.applicationList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.applicationList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.applicationList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.applicationList.ThemeStyle.RowsStyle.Height = 22;
            this.applicationList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.applicationList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.applicationList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.applicationList_CellContentClick);
            // 
            // ApplicationID
            // 
            this.ApplicationID.DataPropertyName = "ApplicationID";
            this.ApplicationID.HeaderText = "#";
            this.ApplicationID.MinimumWidth = 6;
            this.ApplicationID.Name = "ApplicationID";
            this.ApplicationID.ReadOnly = true;
            // 
            // nameContractCol
            // 
            this.nameContractCol.DataPropertyName = "ApplicantName";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.nameContractCol.DefaultCellStyle = dataGridViewCellStyle15;
            this.nameContractCol.HeaderText = "TÊN ỨNG VIÊN";
            this.nameContractCol.MinimumWidth = 6;
            this.nameContractCol.Name = "nameContractCol";
            this.nameContractCol.ReadOnly = true;
            // 
            // signDateCol
            // 
            this.signDateCol.DataPropertyName = "SubmittedDate";
            this.signDateCol.HeaderText = "NGÀY NỘP";
            this.signDateCol.MinimumWidth = 6;
            this.signDateCol.Name = "signDateCol";
            this.signDateCol.ReadOnly = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.LightSlateGray;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(496, 465);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 41;
            this.guna2Button1.Text = "Tạm dừng";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ViewPostDetailBtn
            // 
            this.ViewPostDetailBtn.BorderRadius = 10;
            this.ViewPostDetailBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ViewPostDetailBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ViewPostDetailBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ViewPostDetailBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ViewPostDetailBtn.FillColor = System.Drawing.Color.LightSkyBlue;
            this.ViewPostDetailBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ViewPostDetailBtn.ForeColor = System.Drawing.Color.White;
            this.ViewPostDetailBtn.Location = new System.Drawing.Point(36, 83);
            this.ViewPostDetailBtn.Name = "ViewPostDetailBtn";
            this.ViewPostDetailBtn.Size = new System.Drawing.Size(178, 30);
            this.ViewPostDetailBtn.TabIndex = 42;
            this.ViewPostDetailBtn.Text = "Xem phiếu đăng tuyển";
            this.ViewPostDetailBtn.Click += new System.EventHandler(this.ViewPostDetailBtn_Click);
            // 
            // ProcessApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 522);
            this.Controls.Add(this.ViewPostDetailBtn);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.applicationList);
            this.Controls.Add(this.SendListBtn);
            this.Name = "ProcessApplication";
            this.Text = "ProcessApplication";
            this.Load += new System.EventHandler(this.ProcessApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.applicationList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button SendListBtn;
        private Guna.UI2.WinForms.Guna2DataGridView applicationList;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button ViewPostDetailBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameContractCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn signDateCol;
    }
}