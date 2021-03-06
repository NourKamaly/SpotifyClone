
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
            this.artistName = new System.Windows.Forms.Label();
            this.artistBio = new System.Windows.Forms.Label();
            this.Addsongbutton = new System.Windows.Forms.Button();
            this.AddAlbumbutton = new System.Windows.Forms.Button();
            this.songslist = new System.Windows.Forms.ListBox();
            this.editbiobutton = new System.Windows.Forms.Button();
            this.albumslist = new System.Windows.Forms.ListBox();
            this.addconertbutton = new System.Windows.Forms.Button();
            this.concertslist = new System.Windows.Forms.ListBox();
            this.artistreportbutton = new System.Windows.Forms.Button();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // artistName
            // 
            this.artistName.AutoSize = true;
            this.artistName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.artistName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistName.ForeColor = System.Drawing.Color.White;
            this.artistName.Location = new System.Drawing.Point(589, 165);
            this.artistName.Name = "artistName";
            this.artistName.Size = new System.Drawing.Size(51, 36);
            this.artistName.TabIndex = 1;
            this.artistName.Text = "....";
            // 
            // artistBio
            // 
            this.artistBio.AutoSize = true;
            this.artistBio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.artistBio.Font = new System.Drawing.Font("Tahoma", 15F);
            this.artistBio.ForeColor = System.Drawing.Color.White;
            this.artistBio.Location = new System.Drawing.Point(550, 268);
            this.artistBio.Name = "artistBio";
            this.artistBio.Size = new System.Drawing.Size(45, 30);
            this.artistBio.TabIndex = 3;
            this.artistBio.Text = "....";
            // 
            // Addsongbutton
            // 
            this.Addsongbutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Addsongbutton.BackgroundImage = global::spotiify.Properties.Resources.saliba;
            this.Addsongbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Addsongbutton.FlatAppearance.BorderSize = 0;
            this.Addsongbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addsongbutton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addsongbutton.Location = new System.Drawing.Point(29, 121);
            this.Addsongbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Addsongbutton.Name = "Addsongbutton";
            this.Addsongbutton.Size = new System.Drawing.Size(23, 23);
            this.Addsongbutton.TabIndex = 4;
            this.Addsongbutton.UseVisualStyleBackColor = false;
            this.Addsongbutton.Click += new System.EventHandler(this.Addsongbutton_Click);
            // 
            // AddAlbumbutton
            // 
            this.AddAlbumbutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddAlbumbutton.BackgroundImage = global::spotiify.Properties.Resources.saliba;
            this.AddAlbumbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddAlbumbutton.FlatAppearance.BorderSize = 0;
            this.AddAlbumbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAlbumbutton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAlbumbutton.Location = new System.Drawing.Point(29, 62);
            this.AddAlbumbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddAlbumbutton.Name = "AddAlbumbutton";
            this.AddAlbumbutton.Size = new System.Drawing.Size(23, 23);
            this.AddAlbumbutton.TabIndex = 5;
            this.AddAlbumbutton.UseVisualStyleBackColor = false;
            this.AddAlbumbutton.Click += new System.EventHandler(this.AddAlbumbutton_Click);
            // 
            // songslist
            // 
            this.songslist.BackColor = System.Drawing.Color.Black;
            this.songslist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songslist.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songslist.ForeColor = System.Drawing.Color.White;
            this.songslist.FormattingEnabled = true;
            this.songslist.ItemHeight = 24;
            this.songslist.Location = new System.Drawing.Point(1281, 126);
            this.songslist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.songslist.Name = "songslist";
            this.songslist.Size = new System.Drawing.Size(245, 408);
            this.songslist.TabIndex = 28;
            // 
            // editbiobutton
            // 
            this.editbiobutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.editbiobutton.BackgroundImage = global::spotiify.Properties.Resources.saliba;
            this.editbiobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editbiobutton.FlatAppearance.BorderSize = 0;
            this.editbiobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbiobutton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbiobutton.Location = new System.Drawing.Point(29, 234);
            this.editbiobutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editbiobutton.Name = "editbiobutton";
            this.editbiobutton.Size = new System.Drawing.Size(23, 23);
            this.editbiobutton.TabIndex = 26;
            this.editbiobutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.editbiobutton.UseVisualStyleBackColor = false;
            this.editbiobutton.Click += new System.EventHandler(this.editbiobutton_Click);
            // 
            // albumslist
            // 
            this.albumslist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.albumslist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.albumslist.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumslist.ForeColor = System.Drawing.Color.White;
            this.albumslist.FormattingEnabled = true;
            this.albumslist.ItemHeight = 24;
            this.albumslist.Location = new System.Drawing.Point(265, 447);
            this.albumslist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.albumslist.Name = "albumslist";
            this.albumslist.Size = new System.Drawing.Size(482, 240);
            this.albumslist.TabIndex = 27;
            this.albumslist.SelectedIndexChanged += new System.EventHandler(this.albumslist_SelectedIndexChanged);
            // 
            // addconertbutton
            // 
            this.addconertbutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addconertbutton.BackgroundImage = global::spotiify.Properties.Resources.saliba;
            this.addconertbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addconertbutton.FlatAppearance.BorderSize = 0;
            this.addconertbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addconertbutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addconertbutton.Location = new System.Drawing.Point(29, 178);
            this.addconertbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addconertbutton.Name = "addconertbutton";
            this.addconertbutton.Size = new System.Drawing.Size(23, 23);
            this.addconertbutton.TabIndex = 29;
            this.addconertbutton.UseVisualStyleBackColor = false;
            this.addconertbutton.Click += new System.EventHandler(this.addconertbutton_Click);
            // 
            // concertslist
            // 
            this.concertslist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.concertslist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.concertslist.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concertslist.ForeColor = System.Drawing.Color.White;
            this.concertslist.FormattingEnabled = true;
            this.concertslist.ItemHeight = 24;
            this.concertslist.Location = new System.Drawing.Point(793, 447);
            this.concertslist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.concertslist.Name = "concertslist";
            this.concertslist.Size = new System.Drawing.Size(466, 240);
            this.concertslist.TabIndex = 30;
            this.concertslist.SelectedIndexChanged += new System.EventHandler(this.concertslist_SelectedIndexChanged);
            // 
            // artistreportbutton
            // 
            this.artistreportbutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.artistreportbutton.BackgroundImage = global::spotiify.Properties.Resources.saliba;
            this.artistreportbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.artistreportbutton.FlatAppearance.BorderSize = 0;
            this.artistreportbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artistreportbutton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistreportbutton.Location = new System.Drawing.Point(29, 317);
            this.artistreportbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.artistreportbutton.Name = "artistreportbutton";
            this.artistreportbutton.Size = new System.Drawing.Size(23, 23);
            this.artistreportbutton.TabIndex = 31;
            this.artistreportbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.artistreportbutton.UseVisualStyleBackColor = false;
            this.artistreportbutton.Click += new System.EventHandler(this.artistreportbutton_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.logoutbutton.BackgroundImage = global::spotiify.Properties.Resources.saliba;
            this.logoutbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutbutton.FlatAppearance.BorderSize = 0;
            this.logoutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbutton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbutton.Location = new System.Drawing.Point(29, 369);
            this.logoutbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(23, 23);
            this.logoutbutton.TabIndex = 32;
            this.logoutbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logoutbutton.UseVisualStyleBackColor = false;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // Artist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::spotiify.Properties.Resources.artistimage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1538, 836);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.artistreportbutton);
            this.Controls.Add(this.concertslist);
            this.Controls.Add(this.albumslist);
            this.Controls.Add(this.songslist);
            this.Controls.Add(this.addconertbutton);
            this.Controls.Add(this.editbiobutton);
            this.Controls.Add(this.AddAlbumbutton);
            this.Controls.Add(this.Addsongbutton);
            this.Controls.Add(this.artistBio);
            this.Controls.Add(this.artistName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Artist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artist";
            this.Load += new System.EventHandler(this.Artist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label artistName;
        private System.Windows.Forms.Label artistBio;
        private System.Windows.Forms.Button Addsongbutton;
        private System.Windows.Forms.Button AddAlbumbutton;
        private System.Windows.Forms.Button editbiobutton;
        private System.Windows.Forms.ListBox albumslist;
        private System.Windows.Forms.ListBox songslist;
        private System.Windows.Forms.Button addconertbutton;
        private System.Windows.Forms.ListBox concertslist;
        private System.Windows.Forms.Button artistreportbutton;
        private System.Windows.Forms.Button logoutbutton;
    }
}