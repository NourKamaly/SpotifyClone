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
    public partial class Form6 : Form
    {
        string ordb = "Data Source = orcl; User Id = scott; Password= tiger;";
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;

        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cmdstr = "select * from listeners";

            adapter = new OracleDataAdapter(cmdstr, ordb);

            ds = new DataSet();
            adapter.Fill(ds);
            int indx = ds.Tables[0].Rows.Count;
            Object[] v = new object[5];
            v[0] = indx+1;
            v[1] = textBox3.Text;
            v[2] = textBox1.Text;
            v[3] = textBox4.Text;
            v[4] = textBox2.Text;
         
                
            ds.Tables[0].Rows.Add(v);

            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);

            MessageBox.Show("Account Created !");

            this.Close();

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
