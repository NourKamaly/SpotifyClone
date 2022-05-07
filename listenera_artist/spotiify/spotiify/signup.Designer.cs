
namespace spotiify
{
    partial class signup
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
            this.emailtextbox = new System.Windows.Forms.TextBox();
            this.Signupbutton = new System.Windows.Forms.Button();
            this.Passwordtextbox = new System.Windows.Forms.TextBox();
            this.secondNametextbox = new System.Windows.Forms.TextBox();
            this.signupName = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailtextbox
            // 
            this.emailtextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.emailtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailtextbox.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.emailtextbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.emailtextbox.Location = new System.Drawing.Point(521, 391);
            this.emailtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.Size = new System.Drawing.Size(232, 17);
            this.emailtextbox.TabIndex = 41;
            this.emailtextbox.Text = "Email";
            this.emailtextbox.Enter += new System.EventHandler(this.enteremailtext);
            this.emailtextbox.Leave += new System.EventHandler(this.leaveemailtext);
            // 
            // Signupbutton
            // 
            this.Signupbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.Signupbutton.FlatAppearance.BorderSize = 0;
            this.Signupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signupbutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signupbutton.ForeColor = System.Drawing.Color.White;
            this.Signupbutton.Location = new System.Drawing.Point(532, 483);
            this.Signupbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Signupbutton.Name = "Signupbutton";
            this.Signupbutton.Size = new System.Drawing.Size(260, 39);
            this.Signupbutton.TabIndex = 38;
            this.Signupbutton.Text = "Sign Up";
            this.Signupbutton.UseVisualStyleBackColor = false;
            this.Signupbutton.Click += new System.EventHandler(this.Signupbutton_Click);
            // 
            // Passwordtextbox
            // 
            this.Passwordtextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Passwordtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passwordtextbox.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.Passwordtextbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Passwordtextbox.Location = new System.Drawing.Point(521, 345);
            this.Passwordtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Passwordtextbox.Name = "Passwordtextbox";
            this.Passwordtextbox.Size = new System.Drawing.Size(232, 17);
            this.Passwordtextbox.TabIndex = 36;
            this.Passwordtextbox.Text = "Password";
            this.Passwordtextbox.Enter += new System.EventHandler(this.enterpasswordtext);
            this.Passwordtextbox.Leave += new System.EventHandler(this.leavepasswordtext);
            // 
            // secondNametextbox
            // 
            this.secondNametextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.secondNametextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondNametextbox.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.secondNametextbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.secondNametextbox.Location = new System.Drawing.Point(521, 300);
            this.secondNametextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondNametextbox.Name = "secondNametextbox";
            this.secondNametextbox.Size = new System.Drawing.Size(232, 17);
            this.secondNametextbox.TabIndex = 34;
            this.secondNametextbox.Text = "Second Name";
            this.secondNametextbox.Enter += new System.EventHandler(this.entersecondnametext);
            this.secondNametextbox.Leave += new System.EventHandler(this.leavesecondnametext);
            // 
            // signupName
            // 
            this.signupName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.signupName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signupName.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.signupName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.signupName.Location = new System.Drawing.Point(521, 253);
            this.signupName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signupName.Name = "signupName";
            this.signupName.Size = new System.Drawing.Size(232, 17);
            this.signupName.TabIndex = 32;
            this.signupName.Text = "First Name";
            this.signupName.Enter += new System.EventHandler(this.enterfirstnametext);
            this.signupName.Leave += new System.EventHandler(this.leavefirstnametext);
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.type.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.type.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(516, 437);
            this.type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(289, 25);
            this.type.TabIndex = 43;
            this.type.Text = "Type";
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.loginbutton.FlatAppearance.BorderSize = 0;
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.Color.White;
            this.loginbutton.Location = new System.Drawing.Point(532, 571);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(260, 36);
            this.loginbutton.TabIndex = 46;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::spotiify.Properties.Resources.signupimage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1318, 680);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.type);
            this.Controls.Add(this.emailtextbox);
            this.Controls.Add(this.Signupbutton);
            this.Controls.Add(this.Passwordtextbox);
            this.Controls.Add(this.secondNametextbox);
            this.Controls.Add(this.signupName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signup";
            this.Load += new System.EventHandler(this.signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox emailtextbox;
        private System.Windows.Forms.Button Signupbutton;
        private System.Windows.Forms.TextBox Passwordtextbox;
        private System.Windows.Forms.TextBox secondNametextbox;
        private System.Windows.Forms.TextBox signupName;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Button loginbutton;
    }
}