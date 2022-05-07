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
    public partial class addconcertform : Form
    {
        public static string AID = login.AID, albumname, ALID;
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;

        private void addconcertbutton_Click(object sender, EventArgs e)
        {
            int maxId, newId;
            OracleCommand cmr = new OracleCommand();
            cmr.Connection = conn;
            cmr.CommandText = "GET_CONCERT_ID";
            cmr.CommandType = CommandType.StoredProcedure;
            cmr.Parameters.Add("eevent", OracleDbType.Int32, ParameterDirection.Output);
            cmr.ExecuteNonQuery();
            try
            {
                maxId = Convert.ToInt32(cmr.Parameters["eevent"].Value.ToString());
                newId = maxId + 1;
            }
            catch
            {
                newId = 1;
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "ADD_CONCERT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("eevent", newId);
            cmd.Parameters.Add("eename", concertnametextbox.Text);
            cmd.Parameters.Add("eelocation", concertlocationtextbox.Text);
            cmd.Parameters.Add("eprice", concertpricetextbox.Text);
            cmd.Parameters.Add("eedescription", concertdescriptiontextbox.Text);
            cmd.Parameters.Add("edate", concertdate.Value);
            cmd.Parameters.Add("eartistid", Artist.AID);
            OracleDataReader dr = cmd.ExecuteReader();
        }

        public addconcertform()
        {
            InitializeComponent();
        }

        private void addconcertform_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
    }
}
