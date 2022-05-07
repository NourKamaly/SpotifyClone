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

    public partial class Addalbumform : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        public Addalbumform()
        {
            InitializeComponent();
        }

        private void Addalbumform_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            typeofalbum.Items.Add("Rap");
            typeofalbum.Items.Add("Romantic");
            typeofalbum.Items.Add("Sad");
            typeofalbum.Items.Add("Quran");

        }

        private void Addalbumbutton_Click(object sender, EventArgs e)
        {
            int maxId, newId;
            OracleCommand cmr = new OracleCommand();
            cmr.Connection = conn;
            cmr.CommandText = "GET_ALBUM_ID";
            cmr.CommandType = CommandType.StoredProcedure;
            cmr.Parameters.Add("aalbum", OracleDbType.Int32, ParameterDirection.Output);
            cmr.ExecuteNonQuery();
            try
            {
                maxId = Convert.ToInt32(cmr.Parameters["aalbum"].Value.ToString());
                newId = maxId + 1;
            }
            catch
            {
                newId = 1;
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "ADD_ALBUM";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("aalbum", newId);
            cmd.Parameters.Add("atype", typeofalbum.Text);
            cmd.Parameters.Add("aaname", albumnametextbox.Text.ToString());
            cmd.Parameters.Add("sname", Artist.AID);
            OracleDataReader dr = cmd.ExecuteReader();
            this.Hide();
        }

        private void enteralbumtext(object sender, EventArgs e)
        {
            if(albumnametextbox.Text=="Album Name") 
            {
                albumnametextbox.Text = "";
            }
        }

        private void leavealbumtext(object sender, EventArgs e)
        {
            if (albumnametextbox.Text == "")
            {
                albumnametextbox.Text = "Album Name";
            }
        }
    }
}
