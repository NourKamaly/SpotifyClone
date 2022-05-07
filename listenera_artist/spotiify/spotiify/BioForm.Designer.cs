
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
            this.biotextbox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biotextbox.Location = new System.Drawing.Point(56, 87);
            this.biotextbox.Name = "biotextbox";
            this.biotextbox.Size = new System.Drawing.Size(478, 32);
            this.biotextbox.TabIndex = 0;
            // 
            // Addbiobutton
            // 
            this.Addbiobutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Addbiobutton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbiobutton.Location = new System.Drawing.Point(232, 168);
            this.Addbiobutton.Name = "Addbiobutton";
            this.Addbiobutton.Size = new System.Drawing.Size(103, 43);
            this.Addbiobutton.TabIndex = 5;
            this.Addbiobutton.Text = "Add Bio";
            this.Addbiobutton.UseVisualStyleBackColor = false;
            this.Addbiobutton.Click += new System.EventHandler(this.Addbiobutton_Click);
            // 
            // BioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 258);
            this.Controls.Add(this.Addbiobutton);
            this.Controls.Add(this.biotextbox);
            this.Name = "BioForm";
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