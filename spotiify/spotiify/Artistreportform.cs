using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace spotiify
{
    public partial class Artistreportform : Form
    {
        Artistreport artist;
        public Artistreportform()
        {
            InitializeComponent();
            artist = new Artistreport();
            foreach (ParameterDiscreteValue value in artist.ParameterFields[0].DefaultValues)
            {
               comboBox1.Items.Add(value.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            artist.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = artist;
        }
    }
}
