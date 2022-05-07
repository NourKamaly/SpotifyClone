
namespace spotiify
{
    partial class Addalbumform
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
            this.Addalbumbutton = new System.Windows.Forms.Button();
            this.albumnametextbox = new System.Windows.Forms.TextBox();
            this.typeofalbum = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Addalbumbutton
            // 
            this.Addalbumbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.Addalbumbutton.FlatAppearance.BorderSize = 0;
            this.Addalbumbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addalbumbutton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Addalbumbutton.ForeColor = System.Drawing.Color.White;
            this.Addalbumbutton.Location = new System.Drawing.Point(632, 593);
            this.Addalbumbutton.Name = "Addalbumbutton";
            this.Addalbumbutton.Size = new System.Drawing.Size(288, 50);
            this.Addalbumbutton.TabIndex = 31;
            this.Addalbumbutton.Text = "Add Album";
            this.Addalbumbutton.UseVisualStyleBackColor = false;
            this.Addalbumbutton.Click += new System.EventHandler(this.Addalbumbutton_Click);
            // 
            // albumnametextbox
            // 
            this.albumnametextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.albumnametextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.albumnametextbox.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.albumnametextbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.albumnametextbox.Location = new System.Drawing.Point(610, 311);
            this.albumnametextbox.Name = "albumnametextbox";
            this.albumnametextbox.Size = new System.Drawing.Size(271, 21);
            this.albumnametextbox.TabIndex = 25;
            this.albumnametextbox.Text = "Album Name";
            this.albumnametextbox.Enter += new System.EventHandler(this.enteralbumtext);
            this.albumnametextbox.Leave += new System.EventHandler(this.leavealbumtext);
            // 
            // typeofalbum
            // 
            this.typeofalbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.typeofalbum.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.typeofalbum.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.typeofalbum.FormattingEnabled = true;
            this.typeofalbum.Location = new System.Drawing.Point(596, 378);
            this.typeofalbum.Name = "typeofalbum";
            this.typeofalbum.Size = new System.Drawing.Size(344, 29);
            this.typeofalbum.TabIndex = 33;
            this.typeofalbum.Text = "Type of Album";
            // 
            // Addalbumform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::spotiify.Properties.Resources.addalbumimage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1538, 837);
            this.Controls.Add(this.typeofalbum);
            this.Controls.Add(this.Addalbumbutton);
            this.Controls.Add(this.albumnametextbox);
            this.Name = "Addalbumform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Addalbumform";
            this.Load += new System.EventHandler(this.Addalbumform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addalbumbutton;
        private System.Windows.Forms.TextBox albumnametextbox;
        private System.Windows.Forms.ComboBox typeofalbum;
    }
}