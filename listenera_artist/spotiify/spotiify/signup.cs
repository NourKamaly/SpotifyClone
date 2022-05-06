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
    public partial class signup : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        public signup()
        {
            InitializeComponent();
        }

        private void signup_Load(object sender, EventArgs e)
        {
            type.Items.Add("Artist");
            type.Items.Add("Listener");
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();
        }

        private void Signupbutton_Click(object sender, EventArgs e)
        {

         
            int maxId, newId;
            OracleCommand cmr = new OracleCommand();
            cmr.Connection = conn;
            cmr.CommandText = "getartist";
            cmr.CommandType = CommandType.StoredProcedure;
            cmr.Parameters.Add("AID", OracleDbType.Int32,ParameterDirection.Output);
            cmr.ExecuteNonQuery();
            try 
            {
                maxId = Convert.ToInt32(cmr.Parameters["AID"].Value.ToString());
                newId = maxId + 1;
            }
            catch 
            {
                newId = 1;
            }


            if (type.Text == "Artist") 
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert_artist";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("newid", newId);
                cmd.Parameters.Add("fname", signupName.Text);
                cmd.Parameters.Add("lname", secondNametextbox.Text);
                cmd.Parameters.Add("pass", Passwordtextbox.Text);
                cmd.Parameters.Add("email", emailtextbox.Text);
                cmd.Parameters.Add("dateofbirth", Convert.ToDateTime(dateofbirth.Text));
                OracleDataReader dr = cmd.ExecuteReader();
            }
            else 
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert_listener";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("newid", newId);
                cmd.Parameters.Add("fname", signupName.Text);
                cmd.Parameters.Add("lname", secondNametextbox.Text);
                cmd.Parameters.Add("pass", Passwordtextbox.Text);
                cmd.Parameters.Add("email", emailtextbox.Text);
                cmd.Parameters.Add("dateofbirth", Convert.ToDateTime(dateofbirth.Text));
                OracleDataReader dr = cmd.ExecuteReader();
            }

        }
    }
}
