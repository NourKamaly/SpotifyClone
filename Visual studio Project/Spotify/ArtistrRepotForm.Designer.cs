namespace Spotify
{
    partial class ArtistrRepotForm
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
            this.GenerateReportButton = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb1_ID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // GenerateReportButton
            // 
            this.GenerateReportButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.GenerateReportButton.Location = new System.Drawing.Point(624, 12);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(130, 23);
            this.GenerateReportButton.TabIndex = 6;
            this.GenerateReportButton.Text = "Generate Report";
            this.GenerateReportButton.UseVisualStyleBackColor = true;
            this.GenerateReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 53);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(799, 398);
            this.crystalReportViewer1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(206, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Artist Name";
            // 
            // cmb1_ID
            // 
            this.cmb1_ID.FormattingEnabled = true;
            this.cmb1_ID.Location = new System.Drawing.Point(302, 15);
            this.cmb1_ID.Name = "cmb1_ID";
            this.cmb1_ID.Size = new System.Drawing.Size(205, 21);
            this.cmb1_ID.TabIndex = 10;
            this.cmb1_ID.SelectedIndexChanged += new System.EventHandler(this.cmb1_ID_SelectedIndexChanged);
            // 
            // ArtistrRepotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb1_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.GenerateReportButton);
            this.Name = "ArtistrRepotForm";
            this.Text = "ArtistrRepotForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GenerateReportButton;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb1_ID;
    }
}