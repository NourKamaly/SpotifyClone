
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
            this.nameofalbum = new System.Windows.Forms.Label();
            this.songsofalbumlist = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nameofalbum
            // 
            this.nameofalbum.AutoSize = true;
            this.nameofalbum.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameofalbum.Location = new System.Drawing.Point(166, 9);
            this.nameofalbum.Name = "nameofalbum";
            this.nameofalbum.Size = new System.Drawing.Size(206, 34);
            this.nameofalbum.TabIndex = 0;
            this.nameofalbum.Text = "Name of album";
            // 
            // songsofalbumlist
            // 
            this.songsofalbumlist.FormattingEnabled = true;
            this.songsofalbumlist.ItemHeight = 16;
            this.songsofalbumlist.Location = new System.Drawing.Point(45, 73);
            this.songsofalbumlist.Name = "songsofalbumlist";
            this.songsofalbumlist.Size = new System.Drawing.Size(497, 356);
            this.songsofalbumlist.TabIndex = 1;
            // 
            // songsofspecificalbumform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.songsofalbumlist);
            this.Controls.Add(this.nameofalbum);
            this.Name = "songsofspecificalbumform";
            this.Text = "songsofspecificalbumform";
            this.Load += new System.EventHandler(this.songsofspecificalbumform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameofalbum;
        private System.Windows.Forms.ListBox songsofalbumlist;
    }
}