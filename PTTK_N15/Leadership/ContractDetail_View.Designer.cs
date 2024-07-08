namespace PTTK_N15.Leadership
{
    partial class ContractDetail_View
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.infoContractPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.routerPanel = new System.Windows.Forms.Panel();
            this.infoRouteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.businessRouteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.title = new System.Windows.Forms.Label();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.idRecruimentFormLabel = new System.Windows.Forms.Label();
            this.txtIdRecruimentForm = new Guna.UI2.WinForms.Guna2TextBox();
            this.signDateLabel = new System.Windows.Forms.Label();
            this.nameContractLabel = new System.Windows.Forms.Label();
            this.outOfDateLabel = new System.Windows.Forms.Label();
            this.idContractLabel = new System.Windows.Forms.Label();
            this.btnSaveChanges = new Guna.UI2.WinForms.Guna2Button();
            this.dtpExpiryDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtSignDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtContractName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtContractCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.infoContractPanel.SuspendLayout();
            this.routerPanel.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoContractPanel
            // 
            this.infoContractPanel.Controls.Add(this.routerPanel);
            this.infoContractPanel.Controls.Add(this.title);
            this.infoContractPanel.Controls.Add(this.panelMain);
            this.infoContractPanel.Location = new System.Drawing.Point(1, 1);
            this.infoContractPanel.Name = "infoContractPanel";
            this.infoContractPanel.Size = new System.Drawing.Size(897, 553);
            this.infoContractPanel.TabIndex = 12;
            // 
            // routerPanel
            // 
            this.routerPanel.Controls.Add(this.infoRouteBtn);
            this.routerPanel.Controls.Add(this.businessRouteBtn);
            this.routerPanel.Location = new System.Drawing.Point(12, 78);
            this.routerPanel.Name = "routerPanel";
            this.routerPanel.Size = new System.Drawing.Size(870, 40);
            this.routerPanel.TabIndex = 10;
            // 
            // infoRouteBtn
            // 
            this.infoRouteBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infoRouteBtn.FillColor = System.Drawing.Color.LightSkyBlue;
            this.infoRouteBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.infoRouteBtn.ForeColor = System.Drawing.Color.Black;
            this.infoRouteBtn.Location = new System.Drawing.Point(287, 4);
            this.infoRouteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.infoRouteBtn.Name = "infoRouteBtn";
            this.infoRouteBtn.Size = new System.Drawing.Size(136, 30);
            this.infoRouteBtn.TabIndex = 16;
            this.infoRouteBtn.Text = "Thông tin";
            // 
            // businessRouteBtn
            // 
            this.businessRouteBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.businessRouteBtn.FillColor = System.Drawing.Color.LightSkyBlue;
            this.businessRouteBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.businessRouteBtn.ForeColor = System.Drawing.Color.Black;
            this.businessRouteBtn.Location = new System.Drawing.Point(459, 4);
            this.businessRouteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.businessRouteBtn.Name = "businessRouteBtn";
            this.businessRouteBtn.Size = new System.Drawing.Size(153, 30);
            this.businessRouteBtn.TabIndex = 17;
            this.businessRouteBtn.Text = "Doanh nghiệp";
            this.businessRouteBtn.Click += new System.EventHandler(this.businessRouteBtn_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.Control;
            this.title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.title.Location = new System.Drawing.Point(10, 6);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(875, 37);
            this.title.TabIndex = 9;
            this.title.Text = "Thông tin hợp đồng";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMain.Controls.Add(this.idRecruimentFormLabel);
            this.panelMain.Controls.Add(this.txtIdRecruimentForm);
            this.panelMain.Controls.Add(this.signDateLabel);
            this.panelMain.Controls.Add(this.nameContractLabel);
            this.panelMain.Controls.Add(this.outOfDateLabel);
            this.panelMain.Controls.Add(this.idContractLabel);
            this.panelMain.Controls.Add(this.btnSaveChanges);
            this.panelMain.Controls.Add(this.dtpExpiryDate);
            this.panelMain.Controls.Add(this.txtSignDate);
            this.panelMain.Controls.Add(this.txtContractName);
            this.panelMain.Controls.Add(this.txtContractCode);
            this.panelMain.Location = new System.Drawing.Point(12, 155);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(873, 391);
            this.panelMain.TabIndex = 8;
            // 
            // idRecruimentFormLabel
            // 
            this.idRecruimentFormLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.idRecruimentFormLabel.Location = new System.Drawing.Point(20, 147);
            this.idRecruimentFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idRecruimentFormLabel.Name = "idRecruimentFormLabel";
            this.idRecruimentFormLabel.Size = new System.Drawing.Size(196, 37);
            this.idRecruimentFormLabel.TabIndex = 21;
            this.idRecruimentFormLabel.Text = "Mã phiếu đăng tuyển:";
            this.idRecruimentFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIdRecruimentForm
            // 
            this.txtIdRecruimentForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdRecruimentForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdRecruimentForm.DefaultText = "";
            this.txtIdRecruimentForm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdRecruimentForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdRecruimentForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdRecruimentForm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdRecruimentForm.Enabled = false;
            this.txtIdRecruimentForm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdRecruimentForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdRecruimentForm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdRecruimentForm.Location = new System.Drawing.Point(223, 148);
            this.txtIdRecruimentForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdRecruimentForm.Name = "txtIdRecruimentForm";
            this.txtIdRecruimentForm.PasswordChar = '\0';
            this.txtIdRecruimentForm.PlaceholderText = "";
            this.txtIdRecruimentForm.SelectedText = "";
            this.txtIdRecruimentForm.Size = new System.Drawing.Size(200, 36);
            this.txtIdRecruimentForm.TabIndex = 20;
            // 
            // signDateLabel
            // 
            this.signDateLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.signDateLabel.Location = new System.Drawing.Point(463, 147);
            this.signDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signDateLabel.Name = "signDateLabel";
            this.signDateLabel.Size = new System.Drawing.Size(136, 37);
            this.signDateLabel.TabIndex = 19;
            this.signDateLabel.Text = "Ngày ký:";
            this.signDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameContractLabel
            // 
            this.nameContractLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nameContractLabel.Location = new System.Drawing.Point(459, 81);
            this.nameContractLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameContractLabel.Name = "nameContractLabel";
            this.nameContractLabel.Size = new System.Drawing.Size(140, 37);
            this.nameContractLabel.TabIndex = 18;
            this.nameContractLabel.Text = "Tên hợp đồng:";
            this.nameContractLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outOfDateLabel
            // 
            this.outOfDateLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.outOfDateLabel.Location = new System.Drawing.Point(66, 210);
            this.outOfDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outOfDateLabel.Name = "outOfDateLabel";
            this.outOfDateLabel.Size = new System.Drawing.Size(128, 37);
            this.outOfDateLabel.TabIndex = 17;
            this.outOfDateLabel.Text = "Ngày hết hạn:";
            this.outOfDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idContractLabel
            // 
            this.idContractLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.idContractLabel.Location = new System.Drawing.Point(66, 82);
            this.idContractLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idContractLabel.Name = "idContractLabel";
            this.idContractLabel.Size = new System.Drawing.Size(128, 37);
            this.idContractLabel.TabIndex = 7;
            this.idContractLabel.Text = "Mã hợp đồng:";
            this.idContractLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveChanges.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveChanges.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveChanges.ForeColor = System.Drawing.Color.Black;
            this.btnSaveChanges.Location = new System.Drawing.Point(366, 304);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(136, 39);
            this.btnSaveChanges.TabIndex = 14;
            this.btnSaveChanges.Text = "Lưu thay đổi";
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpExpiryDate.Checked = true;
            this.dtpExpiryDate.FillColor = System.Drawing.Color.White;
            this.dtpExpiryDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpExpiryDate.Location = new System.Drawing.Point(223, 211);
            this.dtpExpiryDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpExpiryDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(250, 36);
            this.dtpExpiryDate.TabIndex = 13;
            this.dtpExpiryDate.Value = new System.DateTime(2024, 6, 29, 15, 58, 18, 787);
            // 
            // txtSignDate
            // 
            this.txtSignDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSignDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSignDate.DefaultText = "";
            this.txtSignDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSignDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSignDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSignDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSignDate.Enabled = false;
            this.txtSignDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSignDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSignDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSignDate.Location = new System.Drawing.Point(613, 148);
            this.txtSignDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSignDate.Name = "txtSignDate";
            this.txtSignDate.PasswordChar = '\0';
            this.txtSignDate.PlaceholderText = "";
            this.txtSignDate.SelectedText = "";
            this.txtSignDate.Size = new System.Drawing.Size(200, 36);
            this.txtSignDate.TabIndex = 10;
            // 
            // txtContractName
            // 
            this.txtContractName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContractName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContractName.DefaultText = "";
            this.txtContractName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContractName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContractName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContractName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContractName.Enabled = false;
            this.txtContractName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContractName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContractName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContractName.Location = new System.Drawing.Point(613, 81);
            this.txtContractName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContractName.Name = "txtContractName";
            this.txtContractName.PasswordChar = '\0';
            this.txtContractName.PlaceholderText = "";
            this.txtContractName.SelectedText = "";
            this.txtContractName.Size = new System.Drawing.Size(200, 36);
            this.txtContractName.TabIndex = 8;
            // 
            // txtContractCode
            // 
            this.txtContractCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContractCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContractCode.DefaultText = "";
            this.txtContractCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContractCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContractCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContractCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContractCode.Enabled = false;
            this.txtContractCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContractCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContractCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContractCode.Location = new System.Drawing.Point(223, 82);
            this.txtContractCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContractCode.Name = "txtContractCode";
            this.txtContractCode.PasswordChar = '\0';
            this.txtContractCode.PlaceholderText = "";
            this.txtContractCode.SelectedText = "";
            this.txtContractCode.Size = new System.Drawing.Size(200, 36);
            this.txtContractCode.TabIndex = 7;
            // 
            // ContractDetail_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infoContractPanel);
            this.Name = "ContractDetail_View";
            this.Size = new System.Drawing.Size(898, 554);
            this.infoContractPanel.ResumeLayout(false);
            this.routerPanel.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel infoContractPanel;
        private System.Windows.Forms.Panel routerPanel;
        private Guna.UI2.WinForms.Guna2Button infoRouteBtn;
        private Guna.UI2.WinForms.Guna2Button businessRouteBtn;
        private System.Windows.Forms.Label title;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private System.Windows.Forms.Label signDateLabel;
        private System.Windows.Forms.Label nameContractLabel;
        private System.Windows.Forms.Label outOfDateLabel;
        private System.Windows.Forms.Label idContractLabel;
        private Guna.UI2.WinForms.Guna2Button btnSaveChanges;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpExpiryDate;
        private Guna.UI2.WinForms.Guna2TextBox txtSignDate;
        private Guna.UI2.WinForms.Guna2TextBox txtContractName;
        private Guna.UI2.WinForms.Guna2TextBox txtContractCode;
        private System.Windows.Forms.Label idRecruimentFormLabel;
        private Guna.UI2.WinForms.Guna2TextBox txtIdRecruimentForm;
    }
}
