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
        public static string AID,albumname,ALID,COID;
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
            AID = login.AID;
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



            //getting concerts  
            OracleCommand cmd4 = new OracleCommand();
            cmd4.Connection = conn;
            cmd4.CommandText = "GET_CONCERTS";
            cmd4.CommandType = CommandType.StoredProcedure;
            cmd4.Parameters.Add("AID", Artist.AID);
            cmd4.Parameters.Add("concertname", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader r4 = cmd4.ExecuteReader();
            while (r4.Read())
            {
                concertslist.Items.Add(r4[0]);
            }
            r4.Close();
        }

        private void editbiobutton_Click(object sender, EventArgs e)
        {
            BioForm f = new BioForm();
            f.Show();
        }

        private void addconertbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            addconcertform obj = new addconcertform();
            obj.Show();
        }

        private void artistreportbutton_Click(object sender, EventArgs e)
        {
            Artistreportform obj = new Artistreportform();
            obj.Show();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            AID = null;
            songslist = null;
            concertslist = null;
            albumslist = null;
            artistName = null;
            artistBio = null;
            this.Hide();
            login obj = new login();
            obj.Show();
        }

        private void concertslist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string concert_name = concertslist.Text;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select eventid from Concerts  where ename=:concert_name";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("concert_name", concert_name);
            OracleDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                COID = r[0].ToString();
            }
            this.Hide();
            concertdetailsform obj = new concertdetailsform();
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
            this.Hide();
            songsofspecificalbumform obj = new songsofspecificalbumform();
            obj.Show();
        }
    }
}
