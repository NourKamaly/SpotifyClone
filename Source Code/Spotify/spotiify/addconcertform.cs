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
            bool check = true;
            try
            {
                OracleDataReader dr = cmd.ExecuteReader();
            }
            catch
            {
                check = false;
            }
            if (check)
            {
                statustext.Text = "Added Successfully!";
            }
            else 
            {
                statustext.Text = "Unfortunately Not Added!";
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Artist obj = new Artist();
            obj.Show();
        }

        private void enterconcertnametext(object sender, EventArgs e)
        {
            if (concertnametextbox.Text == "Concert Name")
            {
                concertnametextbox.Text = "";
            }
        }

        private void leaveconcertnametext(object sender, EventArgs e)
        {
            if (concertnametextbox.Text == "")
            {
                concertnametextbox.Text = "Concert Name";
            }
        }

        private void enterlocationtext(object sender, EventArgs e)
        {
            if (concertlocationtextbox.Text == "Location")
            {
                concertlocationtextbox.Text = "";
            }
        }

        private void leavelocationtext(object sender, EventArgs e)
        {
            if (concertlocationtextbox.Text == "")
            {
                concertlocationtextbox.Text = "Location";
            }
        }

        private void enterpricetext(object sender, EventArgs e)
        {
            if (concertpricetextbox.Text == "Price")
            {
                concertpricetextbox.Text = "";
            }
        }

        private void leavepricetext(object sender, EventArgs e)
        {
            if (concertpricetextbox.Text == "")
            {
                concertpricetextbox.Text = "Price";
            }
        }

        private void enterdescritpiontext(object sender, EventArgs e)
        {
            if (concertdescriptiontextbox.Text == "Description")
            {
                concertdescriptiontextbox.Text = "";
            }
        }

        private void leavedescriptiontext(object sender, EventArgs e)
        {
            if (concertdescriptiontextbox.Text == "")
            {
                concertdescriptiontextbox.Text = "Description";
            }
        }

        public addconcertform()
        {
            InitializeComponent();
        }

        private void addconcertform_Load(object sender, EventArgs e)
        {
            statustext.Text = "";
            conn = new OracleConnection(ordb);
            conn.Open();
        }
    }
}
