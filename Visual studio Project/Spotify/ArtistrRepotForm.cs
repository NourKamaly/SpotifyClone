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


namespace Spotify
{
    
    public partial class ArtistrRepotForm : Form
    {
        Artist artist ;
        public ArtistrRepotForm()
        {
            artist = new Artist();

            InitializeComponent();
            foreach (ParameterDiscreteValue value in artist.ParameterFields[0].DefaultValues)
            {
                cmb1_ID.Items.Add(value.Value);
            }

        }


        private void ReportButton_Click(object sender, EventArgs e)
        {
            artist.SetParameterValue(0, cmb1_ID.Text);
            crystalReportViewer1.ReportSource = artist;
        }

        private void cmb1_ID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
