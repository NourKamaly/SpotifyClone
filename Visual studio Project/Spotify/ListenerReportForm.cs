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
    public partial class ListenerReportForm : Form
    {
        Listener listenerReport;
        public ListenerReportForm()
        {
            InitializeComponent();
        }

        private void ListenerReportForm_Load(object sender, EventArgs e)
        {
            listenerReport = new Listener();
            foreach(ParameterDiscreteValue value in listenerReport.ParameterFields[0].DefaultValues)
            {
                cmb1_ID.Items.Add(value.Value);
            }
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            listenerReport.SetParameterValue(0, cmb1_ID.Text);
            crystalReportViewer1.ReportSource = listenerReport;
        }
    }
}
