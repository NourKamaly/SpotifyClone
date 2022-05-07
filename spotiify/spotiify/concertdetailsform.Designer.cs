
namespace spotiify
{
    partial class concertdetailsform
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
            this.concertnamelabel = new System.Windows.Forms.Label();
            this.concertlocationlabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.concertdescriptionlabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.concertpricelabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.concertdatelabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Concert Name";
            // 
            // concertnamelabel
            // 
            this.concertnamelabel.AutoSize = true;
            this.concertnamelabel.Font = new System.Drawing.Font("Tahoma", 8F);
            this.concertnamelabel.Location = new System.Drawing.Point(809, 244);
            this.concertnamelabel.Name = "concertnamelabel";
            this.concertnamelabel.Size = new System.Drawing.Size(59, 17);
            this.concertnamelabel.TabIndex = 1;
            this.concertnamelabel.Text = "Name....";
            // 
            // concertlocationlabel
            // 
            this.concertlocationlabel.AutoSize = true;
            this.concertlocationlabel.Location = new System.Drawing.Point(809, 329);
            this.concertlocationlabel.Name = "concertlocationlabel";
            this.concertlocationlabel.Size = new System.Drawing.Size(59, 17);
            this.concertlocationlabel.TabIndex = 3;
            this.concertlocationlabel.Text = "Name....";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Concert Location";
            // 
            // concertdescriptionlabel
            // 
            this.concertdescriptionlabel.AutoSize = true;
            this.concertdescriptionlabel.Location = new System.Drawing.Point(809, 514);
            this.concertdescriptionlabel.Name = "concertdescriptionlabel";
            this.concertdescriptionlabel.Size = new System.Drawing.Size(59, 17);
            this.concertdescriptionlabel.TabIndex = 5;
            this.concertdescriptionlabel.Text = "Name....";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Concert Description";
            // 
            // concertpricelabel
            // 
            this.concertpricelabel.AutoSize = true;
            this.concertpricelabel.Location = new System.Drawing.Point(809, 470);
            this.concertpricelabel.Name = "concertpricelabel";
            this.concertpricelabel.Size = new System.Drawing.Size(59, 17);
            this.concertpricelabel.TabIndex = 7;
            this.concertpricelabel.Text = "Name....";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(631, 470);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Concert Price";
            // 
            // concertdatelabel
            // 
            this.concertdatelabel.AutoSize = true;
            this.concertdatelabel.Location = new System.Drawing.Point(809, 568);
            this.concertdatelabel.Name = "concertdatelabel";
            this.concertdatelabel.Size = new System.Drawing.Size(59, 17);
            this.concertdatelabel.TabIndex = 9;
            this.concertdatelabel.Text = "Name....";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(631, 568);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Concert Date";
            // 
            // concertdetailsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::spotiify.Properties.Resources.concertdetailsimage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1520, 789);
            this.Controls.Add(this.concertdatelabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.concertpricelabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.concertdescriptionlabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.concertlocationlabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.concertnamelabel);
            this.Controls.Add(this.label1);
            this.Name = "concertdetailsform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "concertdetailsform";
            this.Load += new System.EventHandler(this.concertdetailsform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label concertnamelabel;
        private System.Windows.Forms.Label concertlocationlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label concertdescriptionlabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label concertpricelabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label concertdatelabel;
        private System.Windows.Forms.Label label10;
    }
}