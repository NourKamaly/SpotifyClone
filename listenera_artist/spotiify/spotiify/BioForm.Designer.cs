
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
            // BioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::spotiify.Properties.Resources.addbioimage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1538, 837);
            this.Controls.Add(this.Addbiobutton);
            this.Controls.Add(this.biotextbox);
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
    }
}