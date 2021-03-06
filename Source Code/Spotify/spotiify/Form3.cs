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
    public partial class Form3 : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        Dictionary<string, KeyValuePair<string, string>> Songid = new Dictionary<string, KeyValuePair<string, string>>();
        public Form3()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {


            string constr = "Data Source = orcl; User Id = scott; Password= tiger;";

            string k = @"select songid ,name , firstname from songs , artists  where songs.artistid= artists.artistid";

            adapter = new OracleDataAdapter(k, constr);

            ds = new DataSet();
            adapter.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Songid.Add(ds.Tables[0].Rows[i]["songid"].ToString(), new KeyValuePair<string, string>(ds.Tables[0].Rows[i]["name"].ToString(), ds.Tables[0].Rows[i]["firstname"].ToString()));
            }
            foreach (KeyValuePair<string, KeyValuePair<string, string>> entry in Songid)
            {
                string[] s = new string[3];
                s[0] = entry.Key;
                s[1] = entry.Value.Key;
                s[2] = entry.Value.Value;

                ListViewItem ia = new ListViewItem(s);
                //listView1.Items.Add(ia);

            }


            //-------------------------------------------------------------------------------------------------------------
            string cmdstr = @"select *
                               from listeners
                                where listenerid =: id";

            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("id", login.LID);
            ds = new DataSet();
            adapter.Fill(ds);
            label1.Text = ds.Tables[0].Rows[0]["firstname"].ToString() + "\n" + ds.Tables[0].Rows[0]["lastname"].ToString();

            //--------------------------------------------------------------------------------------------------------------
            string command = @"select p.playlistid, pd.songid, p.pname, p.numofsongs
                                from PlaylistDetails pd, Playlists p
                                where pd.playlistid = p.playlistid and pd.listenerid =:id";

            adapter = new OracleDataAdapter(command, constr);
            adapter.SelectCommand.Parameters.Add("id", login.LID);
            ds = new DataSet();
            adapter.Fill(ds);

            Label[] label4 = new Label[ds.Tables[0].Rows.Count];
            ListView[] listView = new ListView[ds.Tables[0].Rows.Count];
            ColumnHeader[] songName = new ColumnHeader[ds.Tables[0].Rows.Count];
            ColumnHeader[] artistName = new ColumnHeader[ds.Tables[0].Rows.Count];
          

            int indices = 0; int a = 1;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (i == 0)
                {


                    label4[indices] = new Label();
                    label4[indices].AutoSize = true;
                    label4[indices].BackColor = Color.FromArgb(51,51,51);
                    label4[indices].Font = new Font("HP Simplified Hans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label4[indices].Location = new Point(120, 64);
                    //label4[indices].Top = a * 70;

                    label4[indices].Size = new Size(128, 22);

                    label4[indices].Text = ds.Tables[0].Rows[i]["pname"].ToString();
                    panel1.Controls.Add(label4[indices]);
                  

                    a++;

                    //Listview 
                    listView[indices] = new ListView();
                    listView[indices].Font = new Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    listView[indices].HideSelection = false;
                    listView[indices].Location = new Point(120, 92);

                    listView[indices].Size = new Size(400, 166);
                    listView[indices].TabIndex = 14;
                    listView[indices].UseCompatibleStateImageBehavior = false;
                    listView[indices].View = View.Details;
                    //listView[indices].Top = a * 100;


                    songName[indices] = new ColumnHeader();
                    songName[indices].Text = "Song Name";
                    songName[indices].Width = 121;

                    artistName[indices] = new ColumnHeader();
                    artistName[indices].Text = "Artist Name";
                    artistName[indices].Width = 181;


                    listView[indices].Columns.Add(songName[indices]);
                    listView[indices].Columns.Add(artistName[indices]);

                    panel1.Controls.Add(listView[indices]);

                    string[] s = new string[2];
                    s[0] = Songid[ds.Tables[0].Rows[i]["songid"].ToString()].Key;
                    s[1] = Songid[ds.Tables[0].Rows[i]["songid"].ToString()].Value;


                    ListViewItem ia = new ListViewItem(s);
                    listView[indices].Items.Add(ia);


                }
                else
                {
                    if (ds.Tables[0].Rows[i]["playlistid"].ToString() == ds.Tables[0].Rows[i - 1]["playlistid"].ToString())
                    {
                        string[] s = new string[2];
                        s[0] = Songid[ds.Tables[0].Rows[i]["songid"].ToString()].Key;
                        s[1] = Songid[ds.Tables[0].Rows[i]["songid"].ToString()].Value;


                        ListViewItem ia = new ListViewItem(s);
                        listView[indices].Items.Add(ia);
                    }
                    else if (ds.Tables[0].Rows[i]["playlistid"].ToString() != ds.Tables[0].Rows[i - 1]["playlistid"].ToString())
                    {
                        indices++;


                        label4[indices] = new Label();
                        label4[indices].AutoSize = true;
                        label4[indices].BackColor = Color.FromArgb(51, 51, 51);
                        label4[indices].Font = new Font("HP Simplified Hans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        label4[indices].Location = new Point(120, 64);
                        label4[indices].Top = a * (135 + a * i) + i;

                        label4[indices].Size = new Size(128, 22);

                        label4[indices].Text = ds.Tables[0].Rows[i]["pname"].ToString();
                        panel1.Controls.Add(label4[indices]);


                        //listview
                        listView[indices] = new ListView();
                        listView[indices].Font = new Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        listView[indices].HideSelection = false;
                        listView[indices].Location = new Point(120, 92);
                        listView[indices].Size = new Size(400, 166);
                        listView[indices].TabIndex = 14;
                        listView[indices].UseCompatibleStateImageBehavior = false;
                        listView[indices].View = View.Details;
                        listView[indices].Top = a * (150 + a * i);



                        songName[indices] = new ColumnHeader();
                        songName[indices].Text = "Song Name";
                        songName[indices].Width = 121;

                        artistName[indices] = new ColumnHeader();
                        artistName[indices].Text = "Artist Name";
                        artistName[indices].Width = 181;


                        listView[indices].Columns.Add(songName[indices]);
                        listView[indices].Columns.Add(artistName[indices]);

                        panel1.Controls.Add(listView[indices]);
                        a++;
                        string[] s = new string[2];
                        s[0] = Songid[ds.Tables[0].Rows[i]["songid"].ToString()].Key;
                        s[1] = Songid[ds.Tables[0].Rows[i]["songid"].ToString()].Value;


                        ListViewItem ia = new ListViewItem(s);
                        listView[indices].Items.Add(ia);
                    }

                }
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void shipdbutton_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(29,152,72);
        }

        private void hoverbtn(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(29, 152, 72);
        }

        private void shipdbutton_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(29, 185, 84);
        }

        private void leavebtn(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(29, 185, 84);
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }
    }
}
