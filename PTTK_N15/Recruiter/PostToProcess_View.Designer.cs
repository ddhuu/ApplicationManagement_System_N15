namespace PTTK_N15.Recruiter
{
    partial class PostToProcess_View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PostToProcess = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PostIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OccupationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostToProcessPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PostToProcess)).BeginInit();
            this.PostToProcessPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PostToProcess
            // 
            this.PostToProcess.AllowUserToAddRows = false;
            this.PostToProcess.AllowUserToDeleteRows = false;
            this.PostToProcess.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.PostToProcess.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PostToProcess.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PostToProcess.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PostToProcess.ColumnHeadersHeight = 42;
            this.PostToProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PostToProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PostIDCol,
            this.OccupationCol,
            this.AmountCol,
            this.DescriptionCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PostToProcess.DefaultCellStyle = dataGridViewCellStyle3;
            this.PostToProcess.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PostToProcess.Location = new System.Drawing.Point(22, 98);
            this.PostToProcess.Margin = new System.Windows.Forms.Padding(4);
            this.PostToProcess.Name = "PostToProcess";
            this.PostToProcess.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PostToProcess.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PostToProcess.RowHeadersVisible = false;
            this.PostToProcess.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.PostToProcess.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.PostToProcess.Size = new System.Drawing.Size(830, 307);
            this.PostToProcess.TabIndex = 42;
            this.PostToProcess.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PostToProcess.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PostToProcess.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PostToProcess.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PostToProcess.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PostToProcess.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PostToProcess.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PostToProcess.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PostToProcess.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PostToProcess.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostToProcess.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PostToProcess.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PostToProcess.ThemeStyle.HeaderStyle.Height = 42;
            this.PostToProcess.ThemeStyle.ReadOnly = true;
            this.PostToProcess.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PostToProcess.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PostToProcess.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostToProcess.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PostToProcess.ThemeStyle.RowsStyle.Height = 22;
            this.PostToProcess.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PostToProcess.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PostToProcess.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PostToProcess_CellContentClick);
            // 
            // PostIDCol
            // 
            this.PostIDCol.DataPropertyName = "PostID";
            this.PostIDCol.HeaderText = "#";
            this.PostIDCol.MinimumWidth = 6;
            this.PostIDCol.Name = "PostIDCol";
            this.PostIDCol.ReadOnly = true;
            // 
            // OccupationCol
            // 
            this.OccupationCol.DataPropertyName = "Occupation";
            this.OccupationCol.HeaderText = "VỊ TRÍ";
            this.OccupationCol.MinimumWidth = 6;
            this.OccupationCol.Name = "OccupationCol";
            this.OccupationCol.ReadOnly = true;
            // 
            // AmountCol
            // 
            this.AmountCol.DataPropertyName = "Amount";
            this.AmountCol.HeaderText = "SỐ LƯỢNG";
            this.AmountCol.MinimumWidth = 6;
            this.AmountCol.Name = "AmountCol";
            this.AmountCol.ReadOnly = true;
            // 
            // DescriptionCol
            // 
            this.DescriptionCol.DataPropertyName = "Description";
            this.DescriptionCol.HeaderText = "MÔ TẢ";
            this.DescriptionCol.MinimumWidth = 6;
            this.DescriptionCol.Name = "DescriptionCol";
            this.DescriptionCol.ReadOnly = true;
            // 
            // PostToProcessPanel
            // 
            this.PostToProcessPanel.Controls.Add(this.label1);
            this.PostToProcessPanel.Controls.Add(this.PostToProcess);
            this.PostToProcessPanel.Location = new System.Drawing.Point(6, 2);
            this.PostToProcessPanel.Name = "PostToProcessPanel";
            this.PostToProcessPanel.Size = new System.Drawing.Size(886, 466);
            this.PostToProcessPanel.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Không có bài đăng tuyển dụng nào";
            // 
            // PostToProcess_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 468);
            this.Controls.Add(this.PostToProcessPanel);
            this.Name = "PostToProcess_View";
            this.Text = "PostToProcess_View";
            this.Load += new System.EventHandler(this.PostToProcess_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PostToProcess)).EndInit();
            this.PostToProcessPanel.ResumeLayout(false);
            this.PostToProcessPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView PostToProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn OccupationCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionCol;
        private Guna.UI2.WinForms.Guna2Panel PostToProcessPanel;
        private System.Windows.Forms.Label label1;
    }
}