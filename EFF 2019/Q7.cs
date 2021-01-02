using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFF_2019.DataSet1TableAdapters;

namespace EFF_2019
{
    public partial class Q7 : Form
    {
        public Q7()
        {
            InitializeComponent();
        }

        private void Q7_Load(object sender, EventArgs e)
        {
            DataSet1 dataSet = new DataSet1();
            AssociationTableAdapter adapter = new AssociationTableAdapter();
            adapter.Fill(dataSet.Association);
            CrystalReport2 crystalReport = new CrystalReport2();
            crystalReport.SetDataSource(dataSet);
            crystalReportViewer1.ReportSource = crystalReport;
        }
    }
}
