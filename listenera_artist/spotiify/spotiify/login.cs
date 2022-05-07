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
        public static string AID,LID;
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
                cmd.CommandText = "select email,pass,artistid from artists  where email=:e_mail and pass=:passs";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("e_mail", emailtextbox.Text);
                cmd.Parameters.Add("passs", Passwordtextbox.Text);
                OracleDataReader r = cmd.ExecuteReader();
                if (r.Read()) 
                {

                    AID = r[2].ToString();
                    this.Hide();
                    Artist s = new Artist();
                    s.Show();
                }
                else 
                {
                    MessageBox.Show("not valid");
                }
                r.Close();


            }
            else 
            {

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select email,pass listenerid from listeners where email=:e_mail and pass=:passs";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("e_mail", emailtextbox.Text);
                cmd.Parameters.Add("passs", Passwordtextbox.Text);
                OracleDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    LID = r[2].ToString();
                    MessageBox.Show("Listener Form");
                }
                else
                {
                    MessageBox.Show("not valid");
                }
                r.Close();
            }

           
        }

        private void emailtextenter(object sender, EventArgs e)
        {
            if (emailtextbox.Text == "Email") 
            {
                emailtextbox.Text = "";
            }
        }

        private void emailtextleave(object sender, EventArgs e)
        {
            if (emailtextbox.Text == "") 
            {
                emailtextbox.Text = "Email";
            }
        }

        private void passowrdtextenter(object sender, EventArgs e)
        {
            if (Passwordtextbox.Text == "Password") 
            {
                Passwordtextbox.Text = "";
                Passwordtextbox.PasswordChar = '*';
            }

        }

        private void passwordtextleave(object sender, EventArgs e)
        {
            if (Passwordtextbox.Text=="") 
            {
                Passwordtextbox.PasswordChar= '\0';
                Passwordtextbox.Text = "Password";
             
            }
        }


        private void NameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
