using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace alfa2_Sinergia
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument crystalrpt = new ReportDocument();
            crystalrpt.Load(@"C:\Users\Lahkrome\Desktop\alfa3_Sinergia\alfa2_Sinergia\CrystalReport.rpt");
            //crystalReportViewer1.ReportSource = crystalrpt;
            //crystalReportViewer1.Refresh();
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = textBox1.Text;
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["ProductName"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            crystalReportViewer1.ReportSource = crystalrpt;
            crystalReportViewer1.Refresh();

        }
    }
}
