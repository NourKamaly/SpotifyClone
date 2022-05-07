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
    public partial class BioForm : Form
    {
        public static string AID = Artist.AID;
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        public BioForm()
        {
            InitializeComponent();
        }

        private void BioForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void Addbiobutton_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update artists set bio=:bioo where artistid=:AID";
            cmd.Parameters.Add("bioo", biotextbox.Text);
            cmd.Parameters.Add("AID", AID);
            int r = cmd.ExecuteNonQuery();
            this.Hide();
            Artist obj = new Artist();
            this.Hide();
            obj.Show();
        }
    }
}
