namespace PTTK_N15.Leadership
{
    partial class BusinessDetail_View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.infoBusinessPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.routerPanel = new System.Windows.Forms.Panel();
            this.infoRouteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.businessRouteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.title = new System.Windows.Forms.Label();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.strategyCombobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.strategyLabel = new System.Windows.Forms.Label();
            this.potentialCombobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.positionList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.orderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentativeLabel = new System.Windows.Forms.Label();
            this.nameEnterpriseLabel = new System.Windows.Forms.Label();
            this.potentialLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.idEnterpriseLabel = new System.Windows.Forms.Label();
            this.btnSaveChanges = new Guna.UI2.WinForms.Guna2Button();
            this.txtRepresentative = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEnterpriseName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEnterpriseCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.infoBusinessPanel.SuspendLayout();
            this.routerPanel.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionList)).BeginInit();
            this.SuspendLayout();
            // 
            // infoBusinessPanel
            // 
            this.infoBusinessPanel.Controls.Add(this.routerPanel);
            this.infoBusinessPanel.Controls.Add(this.title);
            this.infoBusinessPanel.Controls.Add(this.panelMain);
            this.infoBusinessPanel.Location = new System.Drawing.Point(0, 0);
            this.infoBusinessPanel.Name = "infoBusinessPanel";
            this.infoBusinessPanel.Size = new System.Drawing.Size(898, 554);
            this.infoBusinessPanel.TabIndex = 15;
            // 
            // routerPanel
            // 
            this.routerPanel.Controls.Add(this.infoRouteBtn);
            this.routerPanel.Controls.Add(this.businessRouteBtn);
            this.routerPanel.Location = new System.Drawing.Point(12, 71);
            this.routerPanel.Name = "routerPanel";
            this.routerPanel.Size = new System.Drawing.Size(870, 40);
            this.routerPanel.TabIndex = 13;
            // 
            // infoRouteBtn
            // 
            this.infoRouteBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infoRouteBtn.FillColor = System.Drawing.Color.LightSkyBlue;
            this.infoRouteBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.infoRouteBtn.ForeColor = System.Drawing.Color.Black;
            this.infoRouteBtn.Location = new System.Drawing.Point(274, 4);
            this.infoRouteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.infoRouteBtn.Name = "infoRouteBtn";
            this.infoRouteBtn.Size = new System.Drawing.Size(136, 30);
            this.infoRouteBtn.TabIndex = 16;
            this.infoRouteBtn.Text = "Thông tin";
            this.infoRouteBtn.Click += new System.EventHandler(this.infoRouteBtn_Click);
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
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.Control;
            this.title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.title.Location = new System.Drawing.Point(12, 5);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(873, 37);
            this.title.TabIndex = 12;
            this.title.Text = "Thông tin doanh nghiệp";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMain.Controls.Add(this.strategyCombobox);
            this.panelMain.Controls.Add(this.strategyLabel);
            this.panelMain.Controls.Add(this.potentialCombobox);
            this.panelMain.Controls.Add(this.positionList);
            this.panelMain.Controls.Add(this.presentativeLabel);
            this.panelMain.Controls.Add(this.nameEnterpriseLabel);
            this.panelMain.Controls.Add(this.potentialLabel);
            this.panelMain.Controls.Add(this.emailLabel);
            this.panelMain.Controls.Add(this.idEnterpriseLabel);
            this.panelMain.Controls.Add(this.btnSaveChanges);
            this.panelMain.Controls.Add(this.txtRepresentative);
            this.panelMain.Controls.Add(this.txtEmail);
            this.panelMain.Controls.Add(this.txtEnterpriseName);
            this.panelMain.Controls.Add(this.txtEnterpriseCode);
            this.panelMain.Location = new System.Drawing.Point(14, 129);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(873, 417);
            this.panelMain.TabIndex = 11;
            // 
            // strategyCombobox
            // 
            this.strategyCombobox.BackColor = System.Drawing.Color.Silver;
            this.strategyCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.strategyCombobox.DropDownHeight = 110;
            this.strategyCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.strategyCombobox.DropDownWidth = 200;
            this.strategyCombobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.strategyCombobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.strategyCombobox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.strategyCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.strategyCombobox.IntegralHeight = false;
            this.strategyCombobox.ItemHeight = 30;
            this.strategyCombobox.Location = new System.Drawing.Point(599, 137);
            this.strategyCombobox.Name = "strategyCombobox";
            this.strategyCombobox.Size = new System.Drawing.Size(258, 36);
            this.strategyCombobox.TabIndex = 23;
            // 
            // strategyLabel
            // 
            this.strategyLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.strategyLabel.Location = new System.Drawing.Point(464, 137);
            this.strategyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.strategyLabel.Name = "strategyLabel";
            this.strategyLabel.Size = new System.Drawing.Size(128, 37);
            this.strategyLabel.TabIndex = 22;
            this.strategyLabel.Text = "Chiến lược:";
            this.strategyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // potentialCombobox
            // 
            this.potentialCombobox.BackColor = System.Drawing.Color.Silver;
            this.potentialCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.potentialCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.potentialCombobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.potentialCombobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.potentialCombobox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.potentialCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.potentialCombobox.ItemHeight = 30;
            this.potentialCombobox.Items.AddRange(new object[] {
            "Tiềm năng",
            "Không có",
            "Tiềm năng lớn"});
            this.potentialCombobox.Location = new System.Drawing.Point(182, 138);
            this.potentialCombobox.Name = "potentialCombobox";
            this.potentialCombobox.Size = new System.Drawing.Size(200, 36);
            this.potentialCombobox.TabIndex = 21;
            // 
            // positionList
            // 
            this.positionList.AllowUserToAddRows = false;
            this.positionList.AllowUserToDeleteRows = false;
            this.positionList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.positionList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.positionList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.positionList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.positionList.ColumnHeadersHeight = 34;
            this.positionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.positionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderCol,
            this.positionCol,
            this.amountCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.positionList.DefaultCellStyle = dataGridViewCellStyle3;
            this.positionList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.positionList.Location = new System.Drawing.Point(51, 200);
            this.positionList.Margin = new System.Windows.Forms.Padding(4);
            this.positionList.Name = "positionList";
            this.positionList.ReadOnly = true;
            this.positionList.RowHeadersVisible = false;
            this.positionList.RowHeadersWidth = 51;
            this.positionList.Size = new System.Drawing.Size(806, 120);
            this.positionList.TabIndex = 20;
            this.positionList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.positionList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.positionList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.positionList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.positionList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.positionList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.positionList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.positionList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.positionList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.positionList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.positionList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.positionList.ThemeStyle.HeaderStyle.Height = 34;
            this.positionList.ThemeStyle.ReadOnly = true;
            this.positionList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.positionList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.positionList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.positionList.ThemeStyle.RowsStyle.Height = 22;
            this.positionList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.positionList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // orderCol
            // 
            this.orderCol.HeaderText = "#";
            this.orderCol.MinimumWidth = 6;
            this.orderCol.Name = "orderCol";
            this.orderCol.ReadOnly = true;
            // 
            // positionCol
            // 
            this.positionCol.DataPropertyName = "position";
            this.positionCol.HeaderText = "VỊ TRÍ";
            this.positionCol.MinimumWidth = 6;
            this.positionCol.Name = "positionCol";
            this.positionCol.ReadOnly = true;
            // 
            // amountCol
            // 
            this.amountCol.DataPropertyName = "amount";
            this.amountCol.HeaderText = "SỐ LƯỢNG";
            this.amountCol.MinimumWidth = 6;
            this.amountCol.Name = "amountCol";
            this.amountCol.ReadOnly = true;
            // 
            // presentativeLabel
            // 
            this.presentativeLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.presentativeLabel.Location = new System.Drawing.Point(456, 76);
            this.presentativeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.presentativeLabel.Name = "presentativeLabel";
            this.presentativeLabel.Size = new System.Drawing.Size(136, 37);
            this.presentativeLabel.TabIndex = 19;
            this.presentativeLabel.Text = "Người đại diện:";
            this.presentativeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameEnterpriseLabel
            // 
            this.nameEnterpriseLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nameEnterpriseLabel.Location = new System.Drawing.Point(423, 21);
            this.nameEnterpriseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameEnterpriseLabel.Name = "nameEnterpriseLabel";
            this.nameEnterpriseLabel.Size = new System.Drawing.Size(169, 37);
            this.nameEnterpriseLabel.TabIndex = 18;
            this.nameEnterpriseLabel.Text = "Tên doanh nghiệp:";
            this.nameEnterpriseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // potentialLabel
            // 
            this.potentialLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.potentialLabel.Location = new System.Drawing.Point(47, 138);
            this.potentialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.potentialLabel.Name = "potentialLabel";
            this.potentialLabel.Size = new System.Drawing.Size(128, 37);
            this.potentialLabel.TabIndex = 17;
            this.potentialLabel.Text = "Tiềm năng:";
            this.potentialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // emailLabel
            // 
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.emailLabel.Location = new System.Drawing.Point(47, 75);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(128, 37);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "Email:";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idEnterpriseLabel
            // 
            this.idEnterpriseLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.idEnterpriseLabel.Location = new System.Drawing.Point(4, 21);
            this.idEnterpriseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idEnterpriseLabel.Name = "idEnterpriseLabel";
            this.idEnterpriseLabel.Size = new System.Drawing.Size(171, 37);
            this.idEnterpriseLabel.TabIndex = 7;
            this.idEnterpriseLabel.Text = "Mã doanh nghiệp:";
            this.idEnterpriseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveChanges.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveChanges.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveChanges.ForeColor = System.Drawing.Color.Black;
            this.btnSaveChanges.Location = new System.Drawing.Point(377, 351);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(136, 39);
            this.btnSaveChanges.TabIndex = 14;
            this.btnSaveChanges.Text = "Lưu thay đổi";
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtRepresentative
            // 
            this.txtRepresentative.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRepresentative.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRepresentative.DefaultText = "";
            this.txtRepresentative.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRepresentative.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRepresentative.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRepresentative.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRepresentative.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRepresentative.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRepresentative.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRepresentative.Location = new System.Drawing.Point(599, 77);
            this.txtRepresentative.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRepresentative.Name = "txtRepresentative";
            this.txtRepresentative.PasswordChar = '\0';
            this.txtRepresentative.PlaceholderText = "";
            this.txtRepresentative.SelectedText = "";
            this.txtRepresentative.Size = new System.Drawing.Size(258, 36);
            this.txtRepresentative.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(182, 76);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(200, 36);
            this.txtEmail.TabIndex = 9;
            // 
            // txtEnterpriseName
            // 
            this.txtEnterpriseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEnterpriseName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnterpriseName.DefaultText = "";
            this.txtEnterpriseName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEnterpriseName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEnterpriseName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnterpriseName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnterpriseName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnterpriseName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEnterpriseName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnterpriseName.Location = new System.Drawing.Point(599, 21);
            this.txtEnterpriseName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEnterpriseName.Name = "txtEnterpriseName";
            this.txtEnterpriseName.PasswordChar = '\0';
            this.txtEnterpriseName.PlaceholderText = "";
            this.txtEnterpriseName.SelectedText = "";
            this.txtEnterpriseName.Size = new System.Drawing.Size(258, 36);
            this.txtEnterpriseName.TabIndex = 8;
            // 
            // txtEnterpriseCode
            // 
            this.txtEnterpriseCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEnterpriseCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnterpriseCode.DefaultText = "";
            this.txtEnterpriseCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEnterpriseCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEnterpriseCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnterpriseCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnterpriseCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnterpriseCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEnterpriseCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnterpriseCode.Location = new System.Drawing.Point(182, 22);
            this.txtEnterpriseCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEnterpriseCode.Name = "txtEnterpriseCode";
            this.txtEnterpriseCode.PasswordChar = '\0';
            this.txtEnterpriseCode.PlaceholderText = "";
            this.txtEnterpriseCode.SelectedText = "";
            this.txtEnterpriseCode.Size = new System.Drawing.Size(200, 36);
            this.txtEnterpriseCode.TabIndex = 7;
            // 
            // BusinessDetail_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infoBusinessPanel);
            this.Name = "BusinessDetail_View";
            this.Size = new System.Drawing.Size(898, 554);
            this.infoBusinessPanel.ResumeLayout(false);
            this.routerPanel.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.positionList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel infoBusinessPanel;
        private System.Windows.Forms.Panel routerPanel;
        private Guna.UI2.WinForms.Guna2Button infoRouteBtn;
        private Guna.UI2.WinForms.Guna2Button businessRouteBtn;
        private System.Windows.Forms.Label title;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2ComboBox strategyCombobox;
        private System.Windows.Forms.Label strategyLabel;
        private Guna.UI2.WinForms.Guna2ComboBox potentialCombobox;
        private Guna.UI2.WinForms.Guna2DataGridView positionList;
        private System.Windows.Forms.Label presentativeLabel;
        private System.Windows.Forms.Label nameEnterpriseLabel;
        private System.Windows.Forms.Label potentialLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label idEnterpriseLabel;
        private Guna.UI2.WinForms.Guna2Button btnSaveChanges;
        private Guna.UI2.WinForms.Guna2TextBox txtRepresentative;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtEnterpriseName;
        private Guna.UI2.WinForms.Guna2TextBox txtEnterpriseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountCol;
    }
}
