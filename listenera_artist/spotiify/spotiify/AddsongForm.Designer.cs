
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
            this.label1 = new System.Windows.Forms.Label();
            this.lengthofsongtextbox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.songnametextbox = new System.Windows.Forms.TextBox();
            this.typeofsong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Addsongbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Length of Song";
            // 
            // lengthofsongtextbox
            // 
            this.lengthofsongtextbox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthofsongtextbox.Location = new System.Drawing.Point(333, 142);
            this.lengthofsongtextbox.Name = "lengthofsongtextbox";
            this.lengthofsongtextbox.Size = new System.Drawing.Size(287, 32);
            this.lengthofsongtextbox.TabIndex = 20;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(199, 88);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(112, 24);
            this.NameLabel.TabIndex = 19;
            this.NameLabel.Text = "Song Name";
            // 
            // songnametextbox
            // 
            this.songnametextbox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songnametextbox.Location = new System.Drawing.Point(333, 80);
            this.songnametextbox.Name = "songnametextbox";
            this.songnametextbox.Size = new System.Drawing.Size(287, 32);
            this.songnametextbox.TabIndex = 18;
            // 
            // typeofsong
            // 
            this.typeofsong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeofsong.FormattingEnabled = true;
            this.typeofsong.Location = new System.Drawing.Point(333, 199);
            this.typeofsong.Name = "typeofsong";
            this.typeofsong.Size = new System.Drawing.Size(287, 32);
            this.typeofsong.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Type of Song";
            // 
            // Addsongbutton
            // 
            this.Addsongbutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Addsongbutton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addsongbutton.Location = new System.Drawing.Point(333, 325);
            this.Addsongbutton.Name = "Addsongbutton";
            this.Addsongbutton.Size = new System.Drawing.Size(139, 44);
            this.Addsongbutton.TabIndex = 24;
            this.Addsongbutton.Text = "Add Song";
            this.Addsongbutton.UseVisualStyleBackColor = false;
            this.Addsongbutton.Click += new System.EventHandler(this.Addsongbutton_Click);
            // 
            // AddsongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Addsongbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeofsong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lengthofsongtextbox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.songnametextbox);
            this.Name = "AddsongForm";
            this.Text = "AddsongForm";
            this.Load += new System.EventHandler(this.AddsongForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lengthofsongtextbox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox songnametextbox;
        private System.Windows.Forms.ComboBox typeofsong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Addsongbutton;
    }
}