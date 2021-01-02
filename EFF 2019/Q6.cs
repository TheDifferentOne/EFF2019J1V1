using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFF_2019.DataSet1TableAdapters;

namespace EFF_2019
{
    public partial class Q6 : Form
    {
        public Q6()
        {
            InitializeComponent();
        }

        DataSet1 dataSet = new DataSet1();
        private void Q6_Load(object sender, EventArgs e)
        {
            //Fill Combo box
            DataSet1 dataSet = new DataSet1();

            AssociationTableTableAdapter adapter = new AssociationTableTableAdapter();
            adapter.Fill(dataSet.AssociationTable);
            comboBox1.DataSource = dataSet.AssociationTable;
            comboBox1.DisplayMember = "Nom_Ass";
            comboBox1.ValueMember = "Id_Ass";
        }

        private void afficherBtn_Click(object sender, EventArgs e)
        {
            StageTableAdapter adapter = new StageTableAdapter();
            adapter.Fill(dataSet.Stage);
            CrystalReport1 crystalReport = new CrystalReport1();
            crystalReport.SetDataSource(dataSet);
            crystalReport.SetParameterValue("selectedId", comboBox1.SelectedValue);
            crystalReportViewer1.ReportSource = crystalReport;

        }

    }
}
