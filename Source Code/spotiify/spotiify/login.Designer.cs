
namespace spotiify
{
    partial class login
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
            this.signupbutton = new System.Windows.Forms.Button();
            this.loginbutton = new System.Windows.Forms.Button();
            this.Passwordtextbox = new System.Windows.Forms.TextBox();
            this.emailtextbox = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // signupbutton
            // 
            this.signupbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.signupbutton.FlatAppearance.BorderSize = 0;
            this.signupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupbutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbutton.ForeColor = System.Drawing.SystemColors.Window;
            this.signupbutton.Location = new System.Drawing.Point(629, 625);
            this.signupbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(295, 44);
            this.signupbutton.TabIndex = 19;
            this.signupbutton.Text = "Signup";
            this.signupbutton.UseVisualStyleBackColor = false;
            this.signupbutton.Click += new System.EventHandler(this.signupbutton_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.White;
            this.loginbutton.FlatAppearance.BorderSize = 0;
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginbutton.Location = new System.Drawing.Point(629, 505);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(295, 53);
            this.loginbutton.TabIndex = 18;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // Passwordtextbox
            // 
            this.Passwordtextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Passwordtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passwordtextbox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtextbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Passwordtextbox.Location = new System.Drawing.Point(616, 389);
            this.Passwordtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Passwordtextbox.Name = "Passwordtextbox";
            this.Passwordtextbox.Size = new System.Drawing.Size(271, 21);
            this.Passwordtextbox.TabIndex = 16;
            this.Passwordtextbox.Text = "Password";
            this.Passwordtextbox.Enter += new System.EventHandler(this.passowrdtextenter);
            this.Passwordtextbox.Leave += new System.EventHandler(this.passwordtextleave);
            // 
            // emailtextbox
            // 
            this.emailtextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.emailtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailtextbox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtextbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.emailtextbox.Location = new System.Drawing.Point(616, 329);
            this.emailtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.Size = new System.Drawing.Size(271, 21);
            this.emailtextbox.TabIndex = 14;
            this.emailtextbox.Text = "Email";
            this.emailtextbox.Enter += new System.EventHandler(this.emailtextenter);
            this.emailtextbox.Leave += new System.EventHandler(this.emailtextleave);
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.type.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(607, 442);
            this.type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(340, 29);
            this.type.TabIndex = 21;
            this.type.Text = "Type";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::spotiify.Properties.Resources.loginimage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.type);
            this.Controls.Add(this.signupbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.Passwordtextbox);
            this.Controls.Add(this.emailtextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button signupbutton;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TextBox Passwordtextbox;
        private System.Windows.Forms.TextBox emailtextbox;
        private System.Windows.Forms.ComboBox type;
    }
}

