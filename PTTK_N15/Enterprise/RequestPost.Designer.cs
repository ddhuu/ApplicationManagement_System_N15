namespace PTTK_N15.Enterprise
{
    partial class RequestPost
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
            this.lbVTTD = new System.Windows.Forms.Label();
            this.tbxPosition = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbSLCT = new System.Windows.Forms.Label();
            this.tbxQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDescript = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTypeAd = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnRequestPost = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lbVTTD
            // 
            this.lbVTTD.AutoSize = true;
            this.lbVTTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVTTD.Location = new System.Drawing.Point(21, 54);
            this.lbVTTD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVTTD.Name = "lbVTTD";
            this.lbVTTD.Size = new System.Drawing.Size(130, 20);
            this.lbVTTD.TabIndex = 1;
            this.lbVTTD.Text = "Vị trí tuyển dụng";
            // 
            // tbxPosition
            // 
            this.tbxPosition.BorderRadius = 5;
            this.tbxPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPosition.DefaultText = "";
            this.tbxPosition.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxPosition.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxPosition.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPosition.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPosition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxPosition.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxPosition.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxPosition.Location = new System.Drawing.Point(155, 44);
            this.tbxPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxPosition.Name = "tbxPosition";
            this.tbxPosition.PasswordChar = '\0';
            this.tbxPosition.PlaceholderText = "";
            this.tbxPosition.SelectedText = "";
            this.tbxPosition.Size = new System.Drawing.Size(228, 36);
            this.tbxPosition.TabIndex = 2;
            // 
            // lbSLCT
            // 
            this.lbSLCT.AutoSize = true;
            this.lbSLCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLCT.Location = new System.Drawing.Point(21, 117);
            this.lbSLCT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSLCT.Name = "lbSLCT";
            this.lbSLCT.Size = new System.Drawing.Size(151, 20);
            this.lbSLCT.TabIndex = 3;
            this.lbSLCT.Text = "Số lượng cần tuyển";
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.BorderRadius = 5;
            this.tbxQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxQuantity.DefaultText = "";
            this.tbxQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxQuantity.Location = new System.Drawing.Point(155, 107);
            this.tbxQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.PasswordChar = '\0';
            this.tbxQuantity.PlaceholderText = "";
            this.tbxQuantity.SelectedText = "";
            this.tbxQuantity.Size = new System.Drawing.Size(228, 35);
            this.tbxQuantity.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mô tả";
            // 
            // tbxDescript
            // 
            this.tbxDescript.BorderRadius = 5;
            this.tbxDescript.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxDescript.DefaultText = "";
            this.tbxDescript.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxDescript.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxDescript.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxDescript.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxDescript.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxDescript.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxDescript.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxDescript.Location = new System.Drawing.Point(25, 200);
            this.tbxDescript.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxDescript.Name = "tbxDescript";
            this.tbxDescript.PasswordChar = '\0';
            this.tbxDescript.PlaceholderText = "";
            this.tbxDescript.SelectedText = "";
            this.tbxDescript.Size = new System.Drawing.Size(358, 103);
            this.tbxDescript.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hình thức quảng cáo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Thời gian bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thời gian kết thúc";
            // 
            // cbxTypeAd
            // 
            this.cbxTypeAd.AllowDrop = true;
            this.cbxTypeAd.BackColor = System.Drawing.Color.Transparent;
            this.cbxTypeAd.BorderRadius = 5;
            this.cbxTypeAd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTypeAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeAd.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTypeAd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTypeAd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxTypeAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxTypeAd.FormattingEnabled = true;
            this.cbxTypeAd.IntegralHeight = false;
            this.cbxTypeAd.ItemHeight = 30;
            this.cbxTypeAd.Items.AddRange(new object[] {
            "Báo giấy",
            "Banner Quảng cáo",
            "Trang mạng"});
            this.cbxTypeAd.Location = new System.Drawing.Point(566, 47);
            this.cbxTypeAd.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTypeAd.Name = "cbxTypeAd";
            this.cbxTypeAd.Size = new System.Drawing.Size(189, 36);
            this.cbxTypeAd.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbxTypeAd.TabIndex = 12;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpStartDate.BorderRadius = 5;
            this.dtpStartDate.Checked = true;
            this.dtpStartDate.FillColor = System.Drawing.Color.White;
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStartDate.Location = new System.Drawing.Point(566, 107);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(188, 35);
            this.dtpStartDate.TabIndex = 15;
            this.dtpStartDate.Value = new System.DateTime(2024, 6, 30, 0, 12, 2, 862);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpEndDate.BorderRadius = 5;
            this.dtpEndDate.Checked = true;
            this.dtpEndDate.FillColor = System.Drawing.Color.White;
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEndDate.Location = new System.Drawing.Point(566, 162);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(188, 34);
            this.dtpEndDate.TabIndex = 16;
            this.dtpEndDate.Value = new System.DateTime(2024, 6, 30, 0, 12, 2, 862);
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // btnRequestPost
            // 
            this.btnRequestPost.BorderRadius = 5;
            this.btnRequestPost.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRequestPost.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRequestPost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRequestPost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRequestPost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(195)))), ((int)(((byte)(231)))));
            this.btnRequestPost.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRequestPost.ForeColor = System.Drawing.Color.Black;
            this.btnRequestPost.Location = new System.Drawing.Point(341, 362);
            this.btnRequestPost.Margin = new System.Windows.Forms.Padding(2);
            this.btnRequestPost.Name = "btnRequestPost";
            this.btnRequestPost.Size = new System.Drawing.Size(130, 41);
            this.btnRequestPost.TabIndex = 17;
            this.btnRequestPost.Text = "Yêu cầu";
            this.btnRequestPost.Click += new System.EventHandler(this.btnRequestPost_Click);
            // 
            // RequestPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 427);
            this.Controls.Add(this.btnRequestPost);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.cbxTypeAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDescript);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.lbSLCT);
            this.Controls.Add(this.tbxPosition);
            this.Controls.Add(this.lbVTTD);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RequestPost";
            this.Text = "RequestPost";
            this.Load += new System.EventHandler(this.RequestPost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVTTD;
        private Guna.UI2.WinForms.Guna2TextBox tbxPosition;
        private System.Windows.Forms.Label lbSLCT;
        private Guna.UI2.WinForms.Guna2TextBox tbxQuantity;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbxDescript;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbxTypeAd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private Guna.UI2.WinForms.Guna2Button btnRequestPost;
    }
}