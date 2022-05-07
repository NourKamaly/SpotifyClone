
namespace spotiify
{
    partial class Artist
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
            this.artistName = new System.Windows.Forms.Label();
            this.artistBio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Addsongbutton = new System.Windows.Forms.Button();
            this.AddAlbumbutton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.songslist = new System.Windows.Forms.ListBox();
            this.editbiobutton = new System.Windows.Forms.Button();
            this.albumslist = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addconertbutton = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artist Name:";
            // 
            // artistName
            // 
            this.artistName.AutoSize = true;
            this.artistName.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistName.Location = new System.Drawing.Point(189, 25);
            this.artistName.Name = "artistName";
            this.artistName.Size = new System.Drawing.Size(47, 34);
            this.artistName.TabIndex = 1;
            this.artistName.Text = "....";
            // 
            // artistBio
            // 
            this.artistBio.AutoSize = true;
            this.artistBio.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistBio.Location = new System.Drawing.Point(189, 88);
            this.artistBio.Name = "artistBio";
            this.artistBio.Size = new System.Drawing.Size(47, 34);
            this.artistBio.TabIndex = 3;
            this.artistBio.Text = "....";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Artist Bio:";
            // 
            // Addsongbutton
            // 
            this.Addsongbutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Addsongbutton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addsongbutton.Location = new System.Drawing.Point(29, 191);
            this.Addsongbutton.Name = "Addsongbutton";
            this.Addsongbutton.Size = new System.Drawing.Size(139, 44);
            this.Addsongbutton.TabIndex = 4;
            this.Addsongbutton.Text = "Add Song";
            this.Addsongbutton.UseVisualStyleBackColor = false;
            this.Addsongbutton.Click += new System.EventHandler(this.Addsongbutton_Click);
            // 
            // AddAlbumbutton
            // 
            this.AddAlbumbutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddAlbumbutton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAlbumbutton.Location = new System.Drawing.Point(29, 256);
            this.AddAlbumbutton.Name = "AddAlbumbutton";
            this.AddAlbumbutton.Size = new System.Drawing.Size(139, 44);
            this.AddAlbumbutton.TabIndex = 5;
            this.AddAlbumbutton.Text = "Add Album";
            this.AddAlbumbutton.UseVisualStyleBackColor = false;
            this.AddAlbumbutton.Click += new System.EventHandler(this.AddAlbumbutton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.songslist);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(330, 298);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(486, 205);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Songs";
            // 
            // songslist
            // 
            this.songslist.FormattingEnabled = true;
            this.songslist.ItemHeight = 29;
            this.songslist.Location = new System.Drawing.Point(6, 42);
            this.songslist.Name = "songslist";
            this.songslist.Size = new System.Drawing.Size(474, 149);
            this.songslist.TabIndex = 28;
            // 
            // editbiobutton
            // 
            this.editbiobutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.editbiobutton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbiobutton.Location = new System.Drawing.Point(29, 403);
            this.editbiobutton.Name = "editbiobutton";
            this.editbiobutton.Size = new System.Drawing.Size(139, 44);
            this.editbiobutton.TabIndex = 26;
            this.editbiobutton.Text = "Edit Bio";
            this.editbiobutton.UseVisualStyleBackColor = false;
            this.editbiobutton.Click += new System.EventHandler(this.editbiobutton_Click);
            // 
            // albumslist
            // 
            this.albumslist.FormattingEnabled = true;
            this.albumslist.ItemHeight = 29;
            this.albumslist.Location = new System.Drawing.Point(6, 34);
            this.albumslist.Name = "albumslist";
            this.albumslist.Size = new System.Drawing.Size(474, 149);
            this.albumslist.TabIndex = 27;
            this.albumslist.SelectedIndexChanged += new System.EventHandler(this.albumslist_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.albumslist);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(330, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(486, 225);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Albums";
            // 
            // addconertbutton
            // 
            this.addconertbutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addconertbutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addconertbutton.Location = new System.Drawing.Point(29, 321);
            this.addconertbutton.Name = "addconertbutton";
            this.addconertbutton.Size = new System.Drawing.Size(139, 44);
            this.addconertbutton.TabIndex = 29;
            this.addconertbutton.Text = "Add Concert";
            this.addconertbutton.UseVisualStyleBackColor = false;
            this.addconertbutton.Click += new System.EventHandler(this.addconertbutton_Click);
            // 
            // Artist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 533);
            this.Controls.Add(this.addconertbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.editbiobutton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.AddAlbumbutton);
            this.Controls.Add(this.Addsongbutton);
            this.Controls.Add(this.artistBio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.artistName);
            this.Controls.Add(this.label1);
            this.Name = "Artist";
            this.Text = "Artist";
            this.Load += new System.EventHandler(this.Artist_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label artistName;
        private System.Windows.Forms.Label artistBio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Addsongbutton;
        private System.Windows.Forms.Button AddAlbumbutton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button editbiobutton;
        private System.Windows.Forms.ListBox albumslist;
        private System.Windows.Forms.ListBox songslist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addconertbutton;
    }
}