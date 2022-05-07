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
    public partial class concertdetailsform : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        public concertdetailsform()
        {
            InitializeComponent();
        }

        private void concertdetailsform_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select ename,elocation,price,description,dateofevent from concerts where eventid=:COID";
            cmd.Parameters.Add("COID", Artist.COID);
            OracleDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                concertnamelabel.Text = r[0].ToString();
                concertlocationlabel.Text= r[1].ToString();
                concertpricelabel.Text= r[2].ToString();
                concertdescriptionlabel.Text = r[3].ToString();
                concertdatelabel.Text = r[4].ToString();

            }
        }
    }
}
