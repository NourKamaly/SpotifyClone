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
        public static string AID = login.AID,albumname,ALID;
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        public Artist()
        {
            InitializeComponent();
        }

        private void Addsongbutton_Click(object sender, EventArgs e)
        {
            //this.Hide();
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



            //getting single songs 
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "GET_SINGLE_SONGS";
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("AID", Artist.AID);
            cmd2.Parameters.Add("ssongname", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader r2 = cmd2.ExecuteReader();
            while (r2.Read())
            {
                songslist.Items.Add(r2[0]);
            }
            r2.Close();


            //getting albums
            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = conn;
            cmd3.CommandText = "GET_ALL_ALBUMS";
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.Add("AID", Artist.AID);
            cmd3.Parameters.Add("albumname", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader r3 = cmd3.ExecuteReader();
            while (r3.Read())
            {
                albumslist.Items.Add(r3[0]);
            }
            r3.Close();
        }

        private void editbiobutton_Click(object sender, EventArgs e)
        {
            BioForm f = new BioForm();
            f.Show();
        }

        private void addconertbutton_Click(object sender, EventArgs e)
        {
            addconcertform obj = new addconcertform();
            obj.Show();
        }

        private void AddAlbumbutton_Click(object sender, EventArgs e)
        {
            Addalbumform obj = new Addalbumform();
            obj.Show();
        }

        private void albumslist_SelectedIndexChanged(object sender, EventArgs e)
        {
            albumname = albumslist.Text;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select albumid from albums  where aname=:alname";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("alname", albumname);
            OracleDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                ALID = r[0].ToString();
            }

            songsofspecificalbumform obj = new songsofspecificalbumform();
            obj.Show();
        }
    }
}
