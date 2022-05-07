using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace spotiify
{
    public partial class Artist : Form
    {
        public static string AID = login.AID;
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        public Artist()
        {
            InitializeComponent();
        }

        private void Addsongbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddsongForm obj = new AddsongForm();
            obj.Show();
        }
        private void Artist_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select firstname,bio from artists where artistid=:AID";
            cmd.Parameters.Add("AID", AID);
            OracleDataReader r=cmd.ExecuteReader();
            if (r.Read()) 
            {
                artistName.Text = r[0].ToString();
                if (r[1].ToString().Length == 0) 
                {
                    artistBio.Text = "No Bio";
                }
                else 
                {
                    artistBio.Text = r[1].ToString();
                }
            }
        }

        private void editbiobutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BioForm f = new BioForm();
            f.Show();
        }

        private void AddAlbumbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addalbumform obj = new Addalbumform();
            obj.Show();
        }
    }
}
