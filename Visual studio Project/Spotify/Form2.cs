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
    public partial class Form2 : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            string constr = "Data Source = orcl; User Id = scott; Password= tiger;";

            string cmdstr = @"select name, firstname, lengthofsong from songs s, artists z where (z.artistid = s.artistid and s.name= :n) or (z.firstname = :n and z.artistid = s.artistid)";

            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("n", textBox1.Text.ToString());
            ds = new DataSet();
            adapter.Fill(ds);



            //dataGridView1.DataSource = ds.Tables[0];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string[] s = new string[3];
                s[0] = ds.Tables[0].Rows[i]["name"].ToString();
                s[1] = ds.Tables[0].Rows[i]["firstname"].ToString();
                s[2] = ds.Tables[0].Rows[i]["lengthofsong"].ToString();

                ListViewItem ia = new ListViewItem(s);
                listView2.Items.Add(ia);
            }
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
