using System.Windows.Forms;

namespace PTTK_N15.Leadership
{
    partial class ContractList_View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">bool</param>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.categorySection = new Guna.UI2.WinForms.Guna2Panel();
            this.roleLabel = new System.Windows.Forms.Label();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.avatarBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.contractList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameContractCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSignCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outOfDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.contractCount = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            // Initialize the DataGridView
            

            this.categorySection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractList)).BeginInit();
            this.SuspendLayout();
            // 
            // categorySection
            // 
            this.categorySection.BackColor = System.Drawing.Color.LightSkyBlue;
            this.categorySection.Controls.Add(this.roleLabel);
            this.categorySection.Controls.Add(this.btnLogout);
            this.categorySection.Controls.Add(this.avatarBox);
            this.categorySection.Dock = System.Windows.Forms.DockStyle.Left;
            this.categorySection.Location = new System.Drawing.Point(0, 0);
            this.categorySection.Margin = new System.Windows.Forms.Padding(4);
            this.categorySection.Name = "categorySection";
            this.categorySection.Size = new System.Drawing.Size(168, 554);
            this.categorySection.TabIndex = 0;
            // 
            // roleLabel
            // 
            this.roleLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.roleLabel.Location = new System.Drawing.Point(4, 156);
            this.roleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(160, 37);
            this.roleLabel.TabIndex = 6;
            this.roleLabel.Text = "Ban lãnh đạo";
            this.roleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(13, 500);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(136, 39);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Đăng xuất";
            // 
            // avatarBox
            // 
            this.avatarBox.ImageRotate = 0F;
            this.avatarBox.Location = new System.Drawing.Point(16, 15);
            this.avatarBox.Margin = new System.Windows.Forms.Padding(4);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(133, 123);
            this.avatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarBox.TabIndex = 0;
            this.avatarBox.TabStop = false;
            // 
            // contractList
            // 
            this.contractList.AllowUserToAddRows = false;
            this.contractList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.contractList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contractList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.contractList.ColumnHeadersHeight = 34;
            this.contractList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.contractList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.nameContractCol,
            this.statusCol,
            this.dateSignCol,
            this.outOfDateCol,
            this.actionsCol});

            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.contractList.DefaultCellStyle = dataGridViewCellStyle3;
            this.contractList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.contractList.Location = new System.Drawing.Point(176, 123);
            this.contractList.Margin = new System.Windows.Forms.Padding(4);
            this.contractList.Name = "contractList";
            this.contractList.ReadOnly = true;
            this.contractList.RowHeadersVisible = false;
            this.contractList.RowHeadersWidth = 51;
            this.contractList.Size = new System.Drawing.Size(875, 416);
            this.contractList.TabIndex = 2;
            this.contractList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.contractList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.contractList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.contractList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.contractList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.contractList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.contractList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.contractList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.contractList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.contractList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.contractList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.contractList.ThemeStyle.HeaderStyle.Height = 34;
            this.contractList.ThemeStyle.ReadOnly = true;
            this.contractList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.contractList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.contractList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.contractList.ThemeStyle.RowsStyle.Height = 22;
            this.contractList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.contractList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idCol
            // 
            this.idCol.HeaderText = "#";
            this.idCol.MinimumWidth = 6;
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Width = 50;
            // 
            // nameContractCol
            // 
            this.nameContractCol.HeaderText = "TÊN DOANH NGHIỆP";
            this.nameContractCol.MinimumWidth = 6;
            this.nameContractCol.Name = "nameContractCol";
            this.nameContractCol.ReadOnly = true;
            // 
            // statusCol
            // 
            this.statusCol.HeaderText = "TRẠNG THÁI";
            this.statusCol.MinimumWidth = 6;
            this.statusCol.Name = "statusCol";
            this.statusCol.ReadOnly = true;
            // 
            // dateSignCol
            // 
            this.dateSignCol.HeaderText = "NGÀY KÍ";
            this.dateSignCol.MinimumWidth = 6;
            this.dateSignCol.Name = "dateSignCol";
            this.dateSignCol.ReadOnly = true;
            // 
            // outOfDateCol
            // 
            this.outOfDateCol.HeaderText = "NGÀY HẾT HẠN";
            this.outOfDateCol.MinimumWidth = 6;
            this.outOfDateCol.Name = "outOfDateCol";
            this.outOfDateCol.ReadOnly = true;
            // 
            // actionsCol
            // 
            this.actionsCol.HeaderText = "ACTIONS";
            this.actionsCol.MinimumWidth = 6;
            this.actionsCol.Name = "actionsCol";
            this.actionsCol.ReadOnly = true;
            // 
            // searchBar
            // 
            this.searchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBar.DefaultText = "";
            this.searchBar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBar.Location = new System.Drawing.Point(733, 74);
            this.searchBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBar.Name = "searchBar";
            this.searchBar.PasswordChar = '\0';
            this.searchBar.PlaceholderText = "Search...";
            this.searchBar.SelectedText = "";
            this.searchBar.Size = new System.Drawing.Size(317, 37);
            this.searchBar.TabIndex = 3;
            // 
            // contractCount
            // 
            this.contractCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contractCount.Location = new System.Drawing.Point(176, 74);
            this.contractCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contractCount.Name = "contractCount";
            this.contractCount.Size = new System.Drawing.Size(267, 37);
            this.contractCount.TabIndex = 4;
            this.contractCount.Text = "9 hợp đồng";
            this.contractCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.Control;
            this.title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.title.Location = new System.Drawing.Point(176, 25);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(875, 37);
            this.title.TabIndex = 5;
            this.title.Text = "Danh sách hợp đồng";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContractList_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.title);
            this.Controls.Add(this.contractCount);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.contractList);
            this.Controls.Add(this.categorySection);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContractList_View";
            this.Text = "Danh sách hợp đồng";
            this.Load += new System.EventHandler(this.ContractList_View_Load);
            this.categorySection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel categorySection;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2PictureBox avatarBox;
        private Guna.UI2.WinForms.Guna2DataGridView contractList;
        private Guna.UI2.WinForms.Guna2TextBox searchBar;
        private System.Windows.Forms.Label contractCount;
        private System.Windows.Forms.Label title;
        private Label roleLabel;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn nameContractCol;
        private DataGridViewTextBoxColumn statusCol;
        private DataGridViewTextBoxColumn dateSignCol;
        private DataGridViewTextBoxColumn outOfDateCol;
        private DataGridViewTextBoxColumn actionsCol;
    }
}
