
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
            this.Addsongbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.albumnametextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.typeofalbum = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Addsongbutton
            // 
            this.Addsongbutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Addsongbutton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addsongbutton.Location = new System.Drawing.Point(307, 303);
            this.Addsongbutton.Name = "Addsongbutton";
            this.Addsongbutton.Size = new System.Drawing.Size(139, 44);
            this.Addsongbutton.TabIndex = 31;
            this.Addsongbutton.Text = "Add Album";
            this.Addsongbutton.UseVisualStyleBackColor = false;
            this.Addsongbutton.Click += new System.EventHandler(this.Addsongbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Type of Album";
            // 
            // albumnametextbox
            // 
            this.albumnametextbox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumnametextbox.Location = new System.Drawing.Point(307, 129);
            this.albumnametextbox.Name = "albumnametextbox";
            this.albumnametextbox.Size = new System.Drawing.Size(287, 32);
            this.albumnametextbox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Album Name";
            // 
            // typeofalbum
            // 
            this.typeofalbum.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeofalbum.FormattingEnabled = true;
            this.typeofalbum.Location = new System.Drawing.Point(307, 196);
            this.typeofalbum.Name = "typeofalbum";
            this.typeofalbum.Size = new System.Drawing.Size(287, 32);
            this.typeofalbum.TabIndex = 33;
            // 
            // Addalbumform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.typeofalbum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Addsongbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.albumnametextbox);
            this.Name = "Addalbumform";
            this.Text = "Addalbumform";
            this.Load += new System.EventHandler(this.Addalbumform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addsongbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox albumnametextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typeofalbum;
    }
}