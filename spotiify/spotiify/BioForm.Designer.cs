
namespace spotiify
{
    partial class BioForm
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
            this.biotextbox = new System.Windows.Forms.TextBox();
            this.Addbiobutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.statustext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // biotextbox
            // 
            this.biotextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.biotextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.biotextbox.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.biotextbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.biotextbox.Location = new System.Drawing.Point(610, 311);
            this.biotextbox.Name = "biotextbox";
            this.biotextbox.Size = new System.Drawing.Size(271, 21);
            this.biotextbox.TabIndex = 0;
            // 
            // Addbiobutton
            // 
            this.Addbiobutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.Addbiobutton.FlatAppearance.BorderSize = 0;
            this.Addbiobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbiobutton.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Addbiobutton.ForeColor = System.Drawing.Color.White;
            this.Addbiobutton.Location = new System.Drawing.Point(628, 593);
            this.Addbiobutton.Name = "Addbiobutton";
            this.Addbiobutton.Size = new System.Drawing.Size(290, 51);
            this.Addbiobutton.TabIndex = 5;
            this.Addbiobutton.Text = "Add Bio";
            this.Addbiobutton.UseVisualStyleBackColor = false;
            this.Addbiobutton.Click += new System.EventHandler(this.Addbiobutton_Click);
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
            this.backbutton.TabIndex = 36;
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // statustext
            // 
            this.statustext.AutoSize = true;
            this.statustext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.statustext.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.statustext.Location = new System.Drawing.Point(701, 378);
            this.statustext.Name = "statustext";
            this.statustext.Size = new System.Drawing.Size(121, 17);
            this.statustext.TabIndex = 37;
            this.statustext.Text = "added successfully";
            // 
            // BioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::spotiify.Properties.Resources.addbioimage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1538, 837);
            this.Controls.Add(this.statustext);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.Addbiobutton);
            this.Controls.Add(this.biotextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BioForm";
            this.Load += new System.EventHandler(this.BioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox biotextbox;
        private System.Windows.Forms.Button Addbiobutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label statustext;
    }
}