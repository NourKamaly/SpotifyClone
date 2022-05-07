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

namespace spotiify
{
    public partial class Form4 : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        Dictionary<string, string> Songid = new Dictionary<string, string>();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string constr = "Data Source = orcl; User Id = scott; Password= tiger;";

            string cmdstr = @"select name,songid, firstname, lengthofsong
                               from songs s, artists z
                                where z.artistid = s.artistid";

            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Songid.Add(ds.Tables[0].Rows[i]["name"].ToString(), ds.Tables[0].Rows[i]["songid"].ToString());
                checkedListBox1.Items.Add(ds.Tables[0].Rows[i]["name"].ToString() + " - " + ds.Tables[0].Rows[i]["firstname"].ToString());
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string constr = "Data Source = orcl; User Id = scott; Password= tiger;";

            string cmdstr = @"select *
                                from Playlists";


            adapter = new OracleDataAdapter(cmdstr, constr);
            // adapter.SelectCommand.Parameters.Add("id", Login.id);
            ds = new DataSet();
            adapter.Fill(ds);

            int indx = ds.Tables[0].Rows.Count;

            Object[] v = new object[3];
            v[0] = indx + 1;
            v[1] = textBox1.Text;
            v[2] = checkedListBox1.CheckedItems.Count;

            ds.Tables[0].Rows.Add(v);

            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);


            string command = @"select * from playlistdetails WHERE listenerid=:id";


            adapter = new OracleDataAdapter(command, constr);
            adapter.SelectCommand.Parameters.Add("id", login.LID);
            ds = new DataSet();
            adapter.Fill(ds);

            foreach (object item in this.checkedListBox1.CheckedItems)
            {
                Object[] j = new object[3];
                String temp = Convert.ToString(item);
                string[] words = temp.Split(new[] { " - " }, StringSplitOptions.None);

                j[0] = login.LID;
                j[1] = indx + 1;
                j[2] = Songid[words[0]];

                ds.Tables[0].Rows.Add(j);

            }

            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);

            MessageBox.Show("Playlist Created Successfully!");



            // ds.Tables[0].Rows.Add(v);

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
