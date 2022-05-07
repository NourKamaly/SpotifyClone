using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace Spotify
{
    public partial class Login : Form
    {
        string ordb = "Data Source = orcl; User Id = scott; Password= scott;";
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;

        public static string id;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cmdstr = @"select * from listeners
                                where listeners.email= :a and listeners.pass= :p";

            adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("a", textBox1.Text.ToString());
            adapter.SelectCommand.Parameters.Add("p", textBox2.Text.ToString());
            ds = new DataSet();
            adapter.Fill(ds);

            if (ds.Tables[0].Rows.Count==0)
            {
                MessageBox.Show("Wrong Email or password !");
            }
            else if (ds.Tables[0].Rows.Count > 0)
            {
                string name = ds.Tables[0].Rows[0]["firstname"].ToString();
                id = ds.Tables[0].Rows[0]["listenerid"].ToString();
                MessageBox.Show("Welcome !"+name);

                Form1 frm1 = new Form1();
                frm1.Show();

             //   this.Close();
            }





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
