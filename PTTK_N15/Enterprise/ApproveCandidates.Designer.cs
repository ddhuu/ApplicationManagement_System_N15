namespace PTTK_N15.Enterprise
{
    partial class ApproveCandidates
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ViewPostDetailBtn = new Guna.UI2.WinForms.Guna2Button();
            this.applicationList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameContractCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationList)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.ViewPostDetailBtn);
            this.guna2Panel1.Controls.Add(this.applicationList);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Location = new System.Drawing.Point(-2, -1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(891, 505);
            this.guna2Panel1.TabIndex = 0;
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
            this.ViewPostDetailBtn.Location = new System.Drawing.Point(34, 36);
            this.ViewPostDetailBtn.Name = "ViewPostDetailBtn";
            this.ViewPostDetailBtn.Size = new System.Drawing.Size(178, 43);
            this.ViewPostDetailBtn.TabIndex = 43;
            this.ViewPostDetailBtn.Text = "Xem phiếu đăng tuyển";
            // 
            // applicationList
            // 
            this.applicationList.AllowUserToAddRows = false;
            this.applicationList.AllowUserToDeleteRows = false;
            this.applicationList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.applicationList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.applicationList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.applicationList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.applicationList.ColumnHeadersHeight = 42;
            this.applicationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.applicationList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApplicationID,
            this.nameContractCol,
            this.signDateCol});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.applicationList.DefaultCellStyle = dataGridViewCellStyle4;
            this.applicationList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.applicationList.Location = new System.Drawing.Point(34, 112);
            this.applicationList.Margin = new System.Windows.Forms.Padding(4);
            this.applicationList.Name = "applicationList";
            this.applicationList.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.applicationList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.applicationList.RowHeadersVisible = false;
            this.applicationList.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.applicationList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.applicationList.Size = new System.Drawing.Size(823, 280);
            this.applicationList.TabIndex = 41;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.nameContractCol.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.guna2Button1.FillColor = System.Drawing.Color.LightSkyBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(683, 429);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 49);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Gửi danh sách hồ sơ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ApproveCandidates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 503);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ApproveCandidates";
            this.Text = "ApproveCandidates";
            this.Load += new System.EventHandler(this.ApproveCandidates_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.applicationList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DataGridView applicationList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameContractCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn signDateCol;
        private Guna.UI2.WinForms.Guna2Button ViewPostDetailBtn;
    }
}