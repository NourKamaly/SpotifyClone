
namespace spotiify
{
    partial class addconcertform
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
            this.concertlocationtextbox = new System.Windows.Forms.TextBox();
            this.concertnametextbox = new System.Windows.Forms.TextBox();
            this.concertdescriptiontextbox = new System.Windows.Forms.TextBox();
            this.concertpricetextbox = new System.Windows.Forms.TextBox();
            this.concertdate = new System.Windows.Forms.DateTimePicker();
            this.addconcertbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // concertlocationtextbox
            // 
            this.concertlocationtextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.concertlocationtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.concertlocationtextbox.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.concertlocationtextbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.concertlocationtextbox.Location = new System.Drawing.Point(609, 369);
            this.concertlocationtextbox.Name = "concertlocationtextbox";
            this.concertlocationtextbox.Size = new System.Drawing.Size(271, 21);
            this.concertlocationtextbox.TabIndex = 20;
            this.concertlocationtextbox.Text = "Location";
            // 
            // concertnametextbox
            // 
            this.concertnametextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.concertnametextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.concertnametextbox.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.concertnametextbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.concertnametextbox.Location = new System.Drawing.Point(609, 309);
            this.concertnametextbox.Name = "concertnametextbox";
            this.concertnametextbox.Size = new System.Drawing.Size(271, 21);
            this.concertnametextbox.TabIndex = 18;
            this.concertnametextbox.Text = "Concert Name";
            // 
            // concertdescriptiontextbox
            // 
            this.concertdescriptiontextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.concertdescriptiontextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.concertdescriptiontextbox.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.concertdescriptiontextbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.concertdescriptiontextbox.Location = new System.Drawing.Point(609, 488);
            this.concertdescriptiontextbox.Name = "concertdescriptiontextbox";
            this.concertdescriptiontextbox.Size = new System.Drawing.Size(271, 21);
            this.concertdescriptiontextbox.TabIndex = 24;
            this.concertdescriptiontextbox.Text = "Description";
            // 
            // concertpricetextbox
            // 
            this.concertpricetextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.concertpricetextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.concertpricetextbox.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.concertpricetextbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.concertpricetextbox.Location = new System.Drawing.Point(609, 427);
            this.concertpricetextbox.Name = "concertpricetextbox";
            this.concertpricetextbox.Size = new System.Drawing.Size(271, 21);
            this.concertpricetextbox.TabIndex = 22;
            this.concertpricetextbox.Text = "Price";
            // 
            // concertdate
            // 
            this.concertdate.CalendarFont = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concertdate.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.concertdate.Location = new System.Drawing.Point(600, 538);
            this.concertdate.Name = "concertdate";
            this.concertdate.Size = new System.Drawing.Size(338, 28);
            this.concertdate.TabIndex = 28;
            // 
            // addconcertbutton
            // 
            this.addconcertbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addconcertbutton.FlatAppearance.BorderSize = 0;
            this.addconcertbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.addconcertbutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addconcertbutton.ForeColor = System.Drawing.Color.White;
            this.addconcertbutton.Location = new System.Drawing.Point(629, 593);
            this.addconcertbutton.Name = "addconcertbutton";
            this.addconcertbutton.Size = new System.Drawing.Size(287, 51);
            this.addconcertbutton.TabIndex = 30;
            this.addconcertbutton.Text = "Add Concert";
            this.addconcertbutton.UseVisualStyleBackColor = false;
            this.addconcertbutton.Click += new System.EventHandler(this.addconcertbutton_Click);
            // 
            // addconcertform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::spotiify.Properties.Resources.add_concert;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1538, 837);
            this.Controls.Add(this.addconcertbutton);
            this.Controls.Add(this.concertdate);
            this.Controls.Add(this.concertdescriptiontextbox);
            this.Controls.Add(this.concertpricetextbox);
            this.Controls.Add(this.concertlocationtextbox);
            this.Controls.Add(this.concertnametextbox);
            this.Name = "addconcertform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addconcertform";
            this.Load += new System.EventHandler(this.addconcertform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox concertlocationtextbox;
        private System.Windows.Forms.TextBox concertnametextbox;
        private System.Windows.Forms.TextBox concertdescriptiontextbox;
        private System.Windows.Forms.TextBox concertpricetextbox;
        private System.Windows.Forms.DateTimePicker concertdate;
        private System.Windows.Forms.Button addconcertbutton;
    }
}