namespace PTTK_N15.NVThanhToan
{
    partial class payForm
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
            this.txbSoTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.hinhThucCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.lbHinhThuc = new System.Windows.Forms.Label();
            this.lbSoTienCon = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbMaPhieu = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lbLanTT = new System.Windows.Forms.Label();
            this.lbDotTT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbSoTien
            // 
            this.txbSoTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSoTien.DefaultText = "";
            this.txbSoTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSoTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSoTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSoTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSoTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSoTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbSoTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSoTien.Location = new System.Drawing.Point(512, 359);
            this.txbSoTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbSoTien.Name = "txbSoTien";
            this.txbSoTien.PasswordChar = '\0';
            this.txbSoTien.PlaceholderText = "";
            this.txbSoTien.SelectedText = "";
            this.txbSoTien.Size = new System.Drawing.Size(310, 36);
            this.txbSoTien.TabIndex = 45;
            // 
            // lbSoTien
            // 
            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTien.Location = new System.Drawing.Point(402, 359);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(66, 20);
            this.lbSoTien.TabIndex = 44;
            this.lbSoTien.Text = "Số tiền:";
            // 
            // hinhThucCB
            // 
            this.hinhThucCB.BackColor = System.Drawing.Color.Transparent;
            this.hinhThucCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hinhThucCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hinhThucCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hinhThucCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hinhThucCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.hinhThucCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.hinhThucCB.ItemHeight = 30;
            this.hinhThucCB.Items.AddRange(new object[] {
            "Thanh toán bằng tiền mặt",
            "Thanh toán bằng thẻ"});
            this.hinhThucCB.Location = new System.Drawing.Point(512, 282);
            this.hinhThucCB.Name = "hinhThucCB";
            this.hinhThucCB.Size = new System.Drawing.Size(310, 36);
            this.hinhThucCB.StartIndex = 0;
            this.hinhThucCB.TabIndex = 43;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BorderRadius = 5;
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(195)))), ((int)(((byte)(231)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btnThanhToan.Location = new System.Drawing.Point(602, 453);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(174, 51);
            this.btnThanhToan.TabIndex = 42;
            this.btnThanhToan.Text = "Đăng tuyển";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lbHinhThuc
            // 
            this.lbHinhThuc.AutoSize = true;
            this.lbHinhThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHinhThuc.Location = new System.Drawing.Point(295, 282);
            this.lbHinhThuc.Name = "lbHinhThuc";
            this.lbHinhThuc.Size = new System.Drawing.Size(174, 20);
            this.lbHinhThuc.TabIndex = 41;
            this.lbHinhThuc.Text = "Hình thức thanh toán: ";
            // 
            // lbSoTienCon
            // 
            this.lbSoTienCon.AutoSize = true;
            this.lbSoTienCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTienCon.Location = new System.Drawing.Point(325, 222);
            this.lbSoTienCon.Name = "lbSoTienCon";
            this.lbSoTienCon.Size = new System.Drawing.Size(144, 20);
            this.lbSoTienCon.TabIndex = 40;
            this.lbSoTienCon.Text = "Số tiền còn thiếu: ";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(380, 72);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(88, 20);
            this.lbTongTien.TabIndex = 39;
            this.lbTongTien.Text = "Tổng tiền: ";
            // 
            // lbMaPhieu
            // 
            this.lbMaPhieu.AutoSize = true;
            this.lbMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhieu.Location = new System.Drawing.Point(296, 26);
            this.lbMaPhieu.Name = "lbMaPhieu";
            this.lbMaPhieu.Size = new System.Drawing.Size(173, 20);
            this.lbMaPhieu.TabIndex = 38;
            this.lbMaPhieu.Text = "Mã phiếu đăng tuyển: ";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lbLanTT
            // 
            this.lbLanTT.AutoSize = true;
            this.lbLanTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLanTT.Location = new System.Drawing.Point(338, 117);
            this.lbLanTT.Name = "lbLanTT";
            this.lbLanTT.Size = new System.Drawing.Size(130, 20);
            this.lbLanTT.TabIndex = 46;
            this.lbLanTT.Text = "Lần thanh toán: ";
            // 
            // lbDotTT
            // 
            this.lbDotTT.AutoSize = true;
            this.lbDotTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDotTT.Location = new System.Drawing.Point(338, 167);
            this.lbDotTT.Name = "lbDotTT";
            this.lbDotTT.Size = new System.Drawing.Size(128, 20);
            this.lbDotTT.TabIndex = 47;
            this.lbDotTT.Text = "Đợt thanh toán: ";
            // 
            // payForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 564);
            this.Controls.Add(this.lbDotTT);
            this.Controls.Add(this.lbLanTT);
            this.Controls.Add(this.txbSoTien);
            this.Controls.Add(this.lbSoTien);
            this.Controls.Add(this.hinhThucCB);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lbHinhThuc);
            this.Controls.Add(this.lbSoTienCon);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.lbMaPhieu);
            this.Name = "payForm";
            this.Text = "payForm";
            this.Load += new System.EventHandler(this.payForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txbSoTien;
        private System.Windows.Forms.Label lbSoTien;
        private Guna.UI2.WinForms.Guna2ComboBox hinhThucCB;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private System.Windows.Forms.Label lbHinhThuc;
        private System.Windows.Forms.Label lbSoTienCon;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbMaPhieu;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lbDotTT;
        private System.Windows.Forms.Label lbLanTT;
    }
}