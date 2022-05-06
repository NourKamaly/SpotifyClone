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
    public partial class login : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        public login()
        {
            InitializeComponent();
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup s = new signup();
            s.Show();
        }

        private void login_Load(object sender, EventArgs e)
        {
            type.Items.Add("Artist");
            type.Items.Add("Listener");
            conn = new OracleConnection(ordb);
            conn.Open();

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            
            if (type.Text == "Artist") 
            {

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select email,pass,artistId from artists  where email:=e_mail, pass:=passs";
                cmd.Parameters.Add("e_mail", emailtextbox.Text);
                cmd.Parameters.Add("passs", Passwordtextbox.Text);

                int r = cmd.ExecuteNonQuery();
                if (r != -1) 
                {
                    MessageBox.Show("not valid");
                }

            }
            else 
            {

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select email,pass from listeners where email:=e_mail, pass:=passs";
                cmd.Parameters.Add("e_mail", emailtextbox.Text);
                cmd.Parameters.Add("passs", Passwordtextbox.Text);

                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("not valid");
                }
            }

           
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
