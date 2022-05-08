
namespace spotiify
{
    partial class AddsongForm
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
            this.lengthofsongtextbox = new System.Windows.Forms.TextBox();
            this.songnametextbox = new System.Windows.Forms.TextBox();
            this.typeofsong = new System.Windows.Forms.ComboBox();
            this.Addsongbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.statustext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lengthofsongtextbox
            // 
            this.lengthofsongtextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lengthofsongtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lengthofsongtextbox.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.lengthofsongtextbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lengthofsongtextbox.Location = new System.Drawing.Point(617, 388);
            this.lengthofsongtextbox.Name = "lengthofsongtextbox";
            this.lengthofsongtextbox.Size = new System.Drawing.Size(271, 21);
            this.lengthofsongtextbox.TabIndex = 20;
            this.lengthofsongtextbox.Text = "Length of Song";
            this.lengthofsongtextbox.Enter += new System.EventHandler(this.enterlengthtext);
            this.lengthofsongtextbox.Leave += new System.EventHandler(this.leavelengthtext);
            // 
            // songnametextbox
            // 
            this.songnametextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.songnametextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songnametextbox.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.songnametextbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.songnametextbox.Location = new System.Drawing.Point(617, 330);
            this.songnametextbox.Name = "songnametextbox";
            this.songnametextbox.Size = new System.Drawing.Size(271, 21);
            this.songnametextbox.TabIndex = 18;
            this.songnametextbox.Text = "Song Name";
            this.songnametextbox.Enter += new System.EventHandler(this.entersongnametext);
            this.songnametextbox.Leave += new System.EventHandler(this.leavesongnametext);
            // 
            // typeofsong
            // 
            this.typeofsong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.typeofsong.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.typeofsong.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.typeofsong.FormattingEnabled = true;
            this.typeofsong.Location = new System.Drawing.Point(604, 455);
            this.typeofsong.Name = "typeofsong";
            this.typeofsong.Size = new System.Drawing.Size(345, 29);
            this.typeofsong.TabIndex = 22;
            this.typeofsong.Text = "Album Type";
            // 
            // Addsongbutton
            // 
            this.Addsongbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.Addsongbutton.FlatAppearance.BorderSize = 0;
            this.Addsongbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addsongbutton.Font = new System.Drawing.Font("Tahoma", 12.8F);
            this.Addsongbutton.ForeColor = System.Drawing.Color.White;
            this.Addsongbutton.Location = new System.Drawing.Point(637, 629);
            this.Addsongbutton.Name = "Addsongbutton";
            this.Addsongbutton.Size = new System.Drawing.Size(292, 46);
            this.Addsongbutton.TabIndex = 24;
            this.Addsongbutton.Text = "Add Song";
            this.Addsongbutton.UseVisualStyleBackColor = false;
            this.Addsongbutton.Click += new System.EventHandler(this.Addsongbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.backbutton.BackgroundImage = global::spotiify.Properties.Resources.backbutton;
            this.backbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbutton.FlatAppearance.BorderSize = 0;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Location = new System.Drawing.Point(130, 40);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(40, 40);
            this.backbutton.TabIndex = 35;
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // statustext
            // 
            this.statustext.AutoSize = true;
            this.statustext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.statustext.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.statustext.Location = new System.Drawing.Point(709, 505);
            this.statustext.Name = "statustext";
            this.statustext.Size = new System.Drawing.Size(121, 17);
            this.statustext.TabIndex = 36;
            this.statustext.Text = "added successfully";
            // 
            // AddsongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BackgroundImage = global::spotiify.Properties.Resources.addsongimage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.statustext);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.Addsongbutton);
            this.Controls.Add(this.typeofsong);
            this.Controls.Add(this.lengthofsongtextbox);
            this.Controls.Add(this.songnametextbox);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddsongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddsongForm";
            this.Load += new System.EventHandler(this.AddsongForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox lengthofsongtextbox;
        private System.Windows.Forms.TextBox songnametextbox;
        private System.Windows.Forms.ComboBox typeofsong;
        private System.Windows.Forms.Button Addsongbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label statustext;
    }
}