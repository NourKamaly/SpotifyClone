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

        private void getLastId(string type) 
        {

  

        }
        private void Signupbutton_Click(object sender, EventArgs e)
        {

            int maxId, newId;
            OracleCommand cmr = new OracleCommand();
            cmr.Connection = conn;
            if (type.Text == "Artist") 
            {
                cmr.CommandText = "get_artist_id";
            }
            else 
            {
                cmr.CommandText = "get_listener_id";
            }
            cmr.CommandType = CommandType.StoredProcedure;
            cmr.Parameters.Add("AID", OracleDbType.Int32, ParameterDirection.Output);
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
                cmd.Parameters.Add("email", emailtextbox.Text);
                cmd.Parameters.Add("pass", Passwordtextbox.Text);
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
                cmd.Parameters.Add("email", emailtextbox.Text);
                cmd.Parameters.Add("pass", Passwordtextbox.Text);
                OracleDataReader dr = cmd.ExecuteReader();
            }

        }

        private void enterfirstnametext(object sender, EventArgs e)
        {
            if (signupName.Text == "First Name")
            {
                signupName.Text = "";
            }
        }

        private void leavefirstnametext(object sender, EventArgs e)
        {
            if (signupName.Text == "")
            {
                signupName.Text = "First Name";
            }
        }

        private void entersecondnametext(object sender, EventArgs e)
        {

            if (secondNametextbox.Text == "Second Name")
            {
                secondNametextbox.Text = "";
            }
        }

        private void leavesecondnametext(object sender, EventArgs e)
        {
            if (secondNametextbox.Text == "")
            {
                secondNametextbox.Text = "Second Name";
            }
        }

        private void enterpasswordtext(object sender, EventArgs e)
        {
            if (Passwordtextbox.Text == "Password")
            {
                Passwordtextbox.Text = "";
                Passwordtextbox.PasswordChar = '*';
            }
        }

        private void leavepasswordtext(object sender, EventArgs e)
        {

            if (Passwordtextbox.Text == "")
            {
                Passwordtextbox.PasswordChar = '\0';
                Passwordtextbox.Text = "Password";

            }
        }

        private void enteremailtext(object sender, EventArgs e)
        {
            if (emailtextbox.Text == "Email")
            {
                emailtextbox.Text = "";
            }
        }

        private void leaveemailtext(object sender, EventArgs e)
        {
            if (emailtextbox.Text == "")
            {
                emailtextbox.Text = "Email";
            }
        }
    }
}
