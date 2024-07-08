using Guna.UI2.WinForms;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.userController = new Guna.UI2.WinForms.Guna2Panel();
            this.reloadBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.contractCount = new System.Windows.Forms.Label();
            this.searchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.contractList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idContractCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameContractCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extendAmountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outOfDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractList)).BeginInit();
            this.SuspendLayout();
            // 
            // userController
            // 
            this.userController.Controls.Add(this.reloadBtn);
            this.userController.Controls.Add(this.contractCount);
            this.userController.Controls.Add(this.searchBar);
            this.userController.Controls.Add(this.contractList);
            this.userController.Location = new System.Drawing.Point(-1, -1);
            this.userController.Name = "userController";
            this.userController.Size = new System.Drawing.Size(891, 505);
            this.userController.TabIndex = 0;
            // 
            // reloadBtn
            // 
            this.reloadBtn.BackColor = System.Drawing.Color.Transparent;
            this.reloadBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.reloadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadBtn.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.reloadBtn.Image = global::PTTK_N15.Properties.Resources.reload_icon;
            this.reloadBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.reloadBtn.ImageRotate = 0F;
            this.reloadBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.reloadBtn.Location = new System.Drawing.Point(128, 24);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.reloadBtn.Size = new System.Drawing.Size(44, 55);
            this.reloadBtn.TabIndex = 8;
            this.reloadBtn.UseTransparentBackground = true;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // contractCount
            // 
            this.contractCount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractCount.Location = new System.Drawing.Point(14, 32);
            this.contractCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contractCount.Name = "contractCount";
            this.contractCount.Size = new System.Drawing.Size(267, 37);
            this.contractCount.TabIndex = 7;
            this.contractCount.Text = "9 hợp đồng";
            this.contractCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.searchBar.Location = new System.Drawing.Point(556, 32);
            this.searchBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBar.Name = "searchBar";
            this.searchBar.PasswordChar = '\0';
            this.searchBar.PlaceholderText = "Search...";
            this.searchBar.SelectedText = "";
            this.searchBar.Size = new System.Drawing.Size(317, 37);
            this.searchBar.TabIndex = 6;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // contractList
            // 
            this.contractList.AllowUserToAddRows = false;
            this.contractList.AllowUserToDeleteRows = false;
            this.contractList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.contractList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.contractList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contractList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.contractList.ColumnHeadersHeight = 42;
            this.contractList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.contractList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idContractCol,
            this.nameContractCol,
            this.extendAmountCol,
            this.signDateCol,
            this.outOfDateCol});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.contractList.DefaultCellStyle = dataGridViewCellStyle4;
            this.contractList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.contractList.Location = new System.Drawing.Point(18, 98);
            this.contractList.Margin = new System.Windows.Forms.Padding(4);
            this.contractList.Name = "contractList";
            this.contractList.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contractList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.contractList.RowHeadersVisible = false;
            this.contractList.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.contractList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.contractList.Size = new System.Drawing.Size(859, 378);
            this.contractList.TabIndex = 5;
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
            this.contractList.ThemeStyle.HeaderStyle.Height = 42;
            this.contractList.ThemeStyle.ReadOnly = true;
            this.contractList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.contractList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.contractList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.contractList.ThemeStyle.RowsStyle.Height = 22;
            this.contractList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.contractList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idContractCol
            // 
            this.idContractCol.DataPropertyName = "idContract";
            this.idContractCol.HeaderText = "#";
            this.idContractCol.MinimumWidth = 6;
            this.idContractCol.Name = "idContractCol";
            this.idContractCol.ReadOnly = true;
            // 
            // nameContractCol
            // 
            this.nameContractCol.DataPropertyName = "nameContract";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.nameContractCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.nameContractCol.HeaderText = "TÊN HỢP ĐỒNG";
            this.nameContractCol.MinimumWidth = 6;
            this.nameContractCol.Name = "nameContractCol";
            this.nameContractCol.ReadOnly = true;
            // 
            // extendAmountCol
            // 
            this.extendAmountCol.DataPropertyName = "extendAmount";
            this.extendAmountCol.HeaderText = "LẦN GIA HẠN";
            this.extendAmountCol.MinimumWidth = 6;
            this.extendAmountCol.Name = "extendAmountCol";
            this.extendAmountCol.ReadOnly = true;
            // 
            // signDateCol
            // 
            this.signDateCol.DataPropertyName = "signDate";
            this.signDateCol.HeaderText = "NGÀY KÍ";
            this.signDateCol.MinimumWidth = 6;
            this.signDateCol.Name = "signDateCol";
            this.signDateCol.ReadOnly = true;
            // 
            // outOfDateCol
            // 
            this.outOfDateCol.DataPropertyName = "outOfDate";
            this.outOfDateCol.HeaderText = "NGÀY HẾT HẠN";
            this.outOfDateCol.MinimumWidth = 6;
            this.outOfDateCol.Name = "outOfDateCol";
            this.outOfDateCol.ReadOnly = true;
            // 
            // ContractList_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 503);
            this.Controls.Add(this.userController);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContractList_View";
            this.Text = "Danh sách hợp đồng";
            this.userController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contractList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel userController;
        private Label contractCount;
        private Guna.UI2.WinForms.Guna2TextBox searchBar;
        private Guna.UI2.WinForms.Guna2DataGridView contractList;
        private Guna2ImageButton reloadBtn;
        private DataGridViewTextBoxColumn idContractCol;
        private DataGridViewTextBoxColumn nameContractCol;
        private DataGridViewTextBoxColumn extendAmountCol;
        private DataGridViewTextBoxColumn signDateCol;
        private DataGridViewTextBoxColumn outOfDateCol;
    }
}
