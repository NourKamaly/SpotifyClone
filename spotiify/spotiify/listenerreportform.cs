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
    public partial class listenerreportform : Form
    {
        Listener listener;
        public listenerreportform()
        {
            listener = new Listener();
            InitializeComponent();
            foreach (ParameterDiscreteValue value in listener.ParameterFields[0].DefaultValues)
            {
                comboBox1.Items.Add(value.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listener.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = listener;
        }
    }
}
