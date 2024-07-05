namespace PTTK_N15.Leadership
{
    partial class DetailInfo_View
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
            this.detailInfoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // detailInfoPanel
            // 
            this.detailInfoPanel.Location = new System.Drawing.Point(2, 0);
            this.detailInfoPanel.Name = "detailInfoPanel";
            this.detailInfoPanel.Size = new System.Drawing.Size(898, 554);
            this.detailInfoPanel.TabIndex = 0;
            // 
            // DetailInfo_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 554);
            this.Controls.Add(this.detailInfoPanel);
            this.Name = "DetailInfo_View";
            this.Text = "DetailInfo_View";
            this.Load += new System.EventHandler(this.DetailInfo_View_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel detailInfoPanel;
    }
}