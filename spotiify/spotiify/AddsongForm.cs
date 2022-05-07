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
    public partial class AddsongForm : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        public AddsongForm()
        {
            InitializeComponent();
        }

        private void AddsongForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GET_ALL_ALBUMS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("AID", Artist.AID);
            cmd.Parameters.Add("albumname", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                typeofsong.Items.Add(r[0]);
            }
            r.Close();
            typeofsong.Items.Add("Single");
        }

        private void Addsongbutton_Click(object sender, EventArgs e)
        {
            int maxId, newId;
            OracleCommand cmr = new OracleCommand();
            cmr.Connection = conn;
            cmr.CommandText = "GET_SONG_ID";
            cmr.CommandType = CommandType.StoredProcedure;
            cmr.Parameters.Add("ssongid", OracleDbType.Int32, ParameterDirection.Output);
            cmr.ExecuteNonQuery();
            try
            {
                maxId = Convert.ToInt32(cmr.Parameters["ssongid"].Value.ToString());
                newId = maxId + 1;
            }
            catch
            {
                newId = 1;
            }

              OracleCommand cmd = new OracleCommand();
              cmd.Connection = conn;
              cmd.CommandText = "ADD_SONG";
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.Add("ssongid", newId);
              cmd.Parameters.Add("sname", songnametextbox.Text);
              if (typeofsong.Text == "Single") 
              {
                cmd.Parameters.Add("ssingle", "1");
                cmd.Parameters.Add("slengthofsong", lengthofsongtextbox.Text);
                cmd.Parameters.Add("sartistid", Artist.AID);
                cmd.Parameters.Add("salbumid","");
              }
              else 
              {

                cmd.Parameters.Add("ssingle", "0");
                cmd.Parameters.Add("slengthofsong", lengthofsongtextbox.Text);
                cmd.Parameters.Add("sartistid", Artist.AID);

                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "select albumid from albums where aname=:albname";
                cmd2.Parameters.Add("albname", typeofsong.Text);
                OracleDataReader r = cmd2.ExecuteReader();
                if (r.Read()) 
                {
                    string albumid = r[0].ToString();
                    cmd.Parameters.Add("salbumid", albumid);
                }
                else 
                {
                    MessageBox.Show("Album Not Found");
                }
                
            }
            OracleDataReader dr = cmd.ExecuteReader();
            this.Hide();

         }

        private void entersongnametext(object sender, EventArgs e)
        {
            if (songnametextbox.Text == "Song Name")
            {
                songnametextbox.Text = "";
            }
        }

        private void leavesongnametext(object sender, EventArgs e)
        {
            if (songnametextbox.Text == "")
            {
                songnametextbox.Text = "Song Name";
            }
        }

        private void enterlengthtext(object sender, EventArgs e)
        {
            if (lengthofsongtextbox.Text == "Length of Song")
            {
                lengthofsongtextbox.Text = "";
            }
        }

        private void leavelengthtext(object sender, EventArgs e)
        {
            if (lengthofsongtextbox.Text == "")
            {
                lengthofsongtextbox.Text = "Length of Song";
            }
        }
    }
}
