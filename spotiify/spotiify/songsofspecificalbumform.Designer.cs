
namespace spotiify
{
    partial class songsofspecificalbumform
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
            this.songsofalbumlist = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // songsofalbumlist
            // 
            this.songsofalbumlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.songsofalbumlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songsofalbumlist.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songsofalbumlist.ForeColor = System.Drawing.Color.White;
            this.songsofalbumlist.FormattingEnabled = true;
            this.songsofalbumlist.ItemHeight = 24;
            this.songsofalbumlist.Location = new System.Drawing.Point(528, 190);
            this.songsofalbumlist.Name = "songsofalbumlist";
            this.songsofalbumlist.Size = new System.Drawing.Size(463, 456);
            this.songsofalbumlist.TabIndex = 1;
            // 
            // songsofspecificalbumform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::spotiify.Properties.Resources.songsofspecificalbumimage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1520, 789);
            this.Controls.Add(this.songsofalbumlist);
            this.Name = "songsofspecificalbumform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "songsofspecificalbumform";
            this.Load += new System.EventHandler(this.songsofspecificalbumform_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox songsofalbumlist;
    }
}