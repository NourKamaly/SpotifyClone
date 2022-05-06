namespace Spotify
{
    partial class ListenerReportForm
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
            this.ReportButton = new System.Windows.Forms.Button();
            this.cmb1_ID = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReportButton
            // 
            this.ReportButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ReportButton.Location = new System.Drawing.Point(603, 12);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(130, 23);
            this.ReportButton.TabIndex = 0;
            this.ReportButton.Text = "Generate Report";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // cmb1_ID
            // 
            this.cmb1_ID.FormattingEnabled = true;
            this.cmb1_ID.Location = new System.Drawing.Point(283, 12);
            this.cmb1_ID.Name = "cmb1_ID";
            this.cmb1_ID.Size = new System.Drawing.Size(205, 21);
            this.cmb1_ID.TabIndex = 1;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 41);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(799, 357);
            this.crystalReportViewer1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Location = new System.Drawing.Point(39, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Return Home";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ListenerReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.cmb1_ID);
            this.Controls.Add(this.ReportButton);
            this.Name = "ListenerReportForm";
            this.Text = "ListenerReportForm";
            this.Load += new System.EventHandler(this.ListenerReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.ComboBox cmb1_ID;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button button1;
    }
}