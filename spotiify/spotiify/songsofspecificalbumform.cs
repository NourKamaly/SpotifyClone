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
    public partial class songsofspecificalbumform : Form
    {
        public static string AID = login.AID, albumname;
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        public songsofspecificalbumform()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Artist obj = new Artist();
            obj.Show();
        }

        private void songsofspecificalbumform_Load(object sender, EventArgs e)
        {


            conn = new OracleConnection(ordb);
            conn.Open();

            //nameofalbum.Text = Artist.albumname;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GET_SONGS_OF_SPECIFIC_ALBUM";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ALID", Artist.ALID);
            cmd.Parameters.Add("ssongname", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                songsofalbumlist.Items.Add(r[0]);
            }
            r.Close();
        }
    }
}
