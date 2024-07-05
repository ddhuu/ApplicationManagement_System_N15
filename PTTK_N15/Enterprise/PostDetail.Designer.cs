namespace PTTK_N15.Enterprise
{
    partial class PostDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostDetail));
            this.btnRequestPost = new Guna.UI2.WinForms.Guna2Button();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbxPaymentType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxPaymentKind = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDescript = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbSLCT = new System.Windows.Forms.Label();
            this.tbxPosition = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbVTTD = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnGoBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.tbxTypeAd = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.tbxTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // btnRequestPost
            // 
            this.btnRequestPost.BorderRadius = 5;
            this.btnRequestPost.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRequestPost.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRequestPost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRequestPost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRequestPost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(216)))));
            this.btnRequestPost.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRequestPost.ForeColor = System.Drawing.Color.Black;
            this.btnRequestPost.Location = new System.Drawing.Point(573, 462);
            this.btnRequestPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRequestPost.Name = "btnRequestPost";
            this.btnRequestPost.Size = new System.Drawing.Size(205, 50);
            this.btnRequestPost.TabIndex = 34;
            this.btnRequestPost.Text = "Thanh toán";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpEndDate.BorderRadius = 5;
            this.dtpEndDate.Checked = true;
            this.dtpEndDate.FillColor = System.Drawing.Color.White;
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEndDate.Location = new System.Drawing.Point(767, 187);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(251, 42);
            this.dtpEndDate.TabIndex = 33;
            this.dtpEndDate.Value = new System.DateTime(2024, 6, 30, 0, 12, 2, 862);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpStartDate.BorderRadius = 5;
            this.dtpStartDate.Checked = true;
            this.dtpStartDate.FillColor = System.Drawing.Color.White;
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStartDate.Location = new System.Drawing.Point(767, 119);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(251, 43);
            this.dtpStartDate.TabIndex = 32;
            this.dtpStartDate.Value = new System.DateTime(2024, 6, 30, 0, 12, 2, 862);
            // 
            // cbxPaymentType
            // 
            this.cbxPaymentType.BackColor = System.Drawing.Color.Transparent;
            this.cbxPaymentType.BorderRadius = 5;
            this.cbxPaymentType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaymentType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxPaymentType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxPaymentType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxPaymentType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxPaymentType.ItemHeight = 30;
            this.cbxPaymentType.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản"});
            this.cbxPaymentType.Location = new System.Drawing.Point(767, 326);
            this.cbxPaymentType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxPaymentType.Name = "cbxPaymentType";
            this.cbxPaymentType.Size = new System.Drawing.Size(251, 36);
            this.cbxPaymentType.TabIndex = 31;
            // 
            // cbxPaymentKind
            // 
            this.cbxPaymentKind.BackColor = System.Drawing.Color.Transparent;
            this.cbxPaymentKind.BorderRadius = 5;
            this.cbxPaymentKind.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxPaymentKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaymentKind.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxPaymentKind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxPaymentKind.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxPaymentKind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxPaymentKind.ItemHeight = 30;
            this.cbxPaymentKind.Items.AddRange(new object[] {
            "Theo đợt",
            "Toàn bộ"});
            this.cbxPaymentKind.Location = new System.Drawing.Point(767, 251);
            this.cbxPaymentKind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxPaymentKind.Name = "cbxPaymentKind";
            this.cbxPaymentKind.Size = new System.Drawing.Size(251, 36);
            this.cbxPaymentKind.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(575, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Hình thức thanh toán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(575, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Loại hình thanh toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(575, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Thời gian kết thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(568, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Thời gian bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(568, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Hình thức quảng cáo";
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
            this.tbxDescript.Location = new System.Drawing.Point(45, 234);
            this.tbxDescript.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxDescript.Name = "tbxDescript";
            this.tbxDescript.PasswordChar = '\0';
            this.tbxDescript.PlaceholderText = "";
            this.tbxDescript.SelectedText = "";
            this.tbxDescript.Size = new System.Drawing.Size(477, 241);
            this.tbxDescript.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mô tả";
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
            this.tbxQuantity.Location = new System.Drawing.Point(219, 119);
            this.tbxQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.PasswordChar = '\0';
            this.tbxQuantity.PlaceholderText = "";
            this.tbxQuantity.SelectedText = "";
            this.tbxQuantity.Size = new System.Drawing.Size(304, 43);
            this.tbxQuantity.TabIndex = 21;
            // 
            // lbSLCT
            // 
            this.lbSLCT.AutoSize = true;
            this.lbSLCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLCT.Location = new System.Drawing.Point(40, 132);
            this.lbSLCT.Name = "lbSLCT";
            this.lbSLCT.Size = new System.Drawing.Size(151, 20);
            this.lbSLCT.TabIndex = 20;
            this.lbSLCT.Text = "Số lượng cần tuyển";
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
            this.tbxPosition.Location = new System.Drawing.Point(220, 65);
            this.tbxPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxPosition.Name = "tbxPosition";
            this.tbxPosition.PasswordChar = '\0';
            this.tbxPosition.PlaceholderText = "";
            this.tbxPosition.SelectedText = "";
            this.tbxPosition.Size = new System.Drawing.Size(304, 44);
            this.tbxPosition.TabIndex = 19;
            // 
            // lbVTTD
            // 
            this.lbVTTD.AutoSize = true;
            this.lbVTTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVTTD.Location = new System.Drawing.Point(40, 79);
            this.lbVTTD.Name = "lbVTTD";
            this.lbVTTD.Size = new System.Drawing.Size(130, 20);
            this.lbVTTD.TabIndex = 18;
            this.lbVTTD.Text = "Vị trí tuyển dụng";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(195)))), ((int)(((byte)(231)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(821, 462);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(219, 50);
            this.guna2Button1.TabIndex = 35;
            this.guna2Button1.Text = "Hiệu chỉnh";
            // 
            // btnGoBack
            // 
            this.btnGoBack.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnGoBack.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnGoBack.Image = ((System.Drawing.Image)(resources.GetObject("btnGoBack.Image")));
            this.btnGoBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnGoBack.ImageRotate = 0F;
            this.btnGoBack.Location = new System.Drawing.Point(36, 15);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnGoBack.Size = new System.Drawing.Size(45, 27);
            this.btnGoBack.TabIndex = 36;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // tbxTypeAd
            // 
            this.tbxTypeAd.BorderRadius = 5;
            this.tbxTypeAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxTypeAd.DefaultText = "";
            this.tbxTypeAd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxTypeAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxTypeAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxTypeAd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxTypeAd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxTypeAd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxTypeAd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxTypeAd.Location = new System.Drawing.Point(767, 59);
            this.tbxTypeAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxTypeAd.Name = "tbxTypeAd";
            this.tbxTypeAd.PasswordChar = '\0';
            this.tbxTypeAd.PlaceholderText = "";
            this.tbxTypeAd.SelectedText = "";
            this.tbxTypeAd.Size = new System.Drawing.Size(252, 44);
            this.tbxTypeAd.TabIndex = 37;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(575, 404);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(78, 20);
            this.lblTotalPrice.TabIndex = 38;
            this.lblTotalPrice.Text = "Tổng tiền";
            // 
            // tbxTotalPrice
            // 
            this.tbxTotalPrice.BorderRadius = 5;
            this.tbxTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxTotalPrice.DefaultText = "";
            this.tbxTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxTotalPrice.Location = new System.Drawing.Point(765, 384);
            this.tbxTotalPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxTotalPrice.Name = "tbxTotalPrice";
            this.tbxTotalPrice.PasswordChar = '\0';
            this.tbxTotalPrice.PlaceholderText = "";
            this.tbxTotalPrice.SelectedText = "";
            this.tbxTotalPrice.Size = new System.Drawing.Size(252, 44);
            this.tbxTotalPrice.TabIndex = 39;
            // 
            // PostDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 526);
            this.Controls.Add(this.tbxTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.tbxTypeAd);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnRequestPost);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.cbxPaymentType);
            this.Controls.Add(this.cbxPaymentKind);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDescript);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.lbSLCT);
            this.Controls.Add(this.tbxPosition);
            this.Controls.Add(this.lbVTTD);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PostDetail";
            this.Text = "PostDetail";
            this.Load += new System.EventHandler(this.PostDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnRequestPost;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Guna.UI2.WinForms.Guna2ComboBox cbxPaymentType;
        private Guna.UI2.WinForms.Guna2ComboBox cbxPaymentKind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbxDescript;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbxQuantity;
        private System.Windows.Forms.Label lbSLCT;
        private Guna.UI2.WinForms.Guna2TextBox tbxPosition;
        private System.Windows.Forms.Label lbVTTD;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ImageButton btnGoBack;
        private Guna.UI2.WinForms.Guna2TextBox tbxTypeAd;
        private System.Windows.Forms.Label lblTotalPrice;
        private Guna.UI2.WinForms.Guna2TextBox tbxTotalPrice;
    }
}