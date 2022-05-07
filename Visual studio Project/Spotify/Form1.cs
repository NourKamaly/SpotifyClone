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
    public partial class Form1 : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string constr = "Data Source = orcl; User Id = scott; Password= scott;";

            string cmdstr = @"select sname, firstname, lengthofsong
                               from songs s, artists a
                                where a.artistid = s.artistid";

            adapter = new OracleDataAdapter(cmdstr, constr);
            
            ds = new DataSet();
            adapter.Fill(ds);



            
            for (int i =0; i<  ds.Tables[0].Rows.Count; i++)
            {
                string[] s = new string[3];
                s[0] = ds.Tables[0].Rows[i]["sname"].ToString();
                s[1] = ds.Tables[0].Rows[i]["firstname"].ToString();
                s[2] = ds.Tables[0].Rows[i]["lengthofsong"].ToString();

                ListViewItem ia = new ListViewItem(s);
                listView1.Items.Add(ia);

            }

            //Login objForm2 = new Login();
            //objForm2.ShowDialog();
          

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
