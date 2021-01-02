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

namespace EFF_2019
{
    public partial class Q4 : Form
    {
        public Q4()
        {
            InitializeComponent();
        }

        private void Q4_Load(object sender, EventArgs e)
        {
            //Load DGVs
            string stagesQuery = "SELECT * FROM Stage";
            SqlCommand stagesCommand = new SqlCommand(stagesQuery);
            string demandesQuery = "SELECT * FROM Demande_Inscription";
            SqlCommand demandesCommand = new SqlCommand(demandesQuery);
            stagesDgv.DataSource = DataAccess.GetData(stagesCommand);
            demandesDgv.DataSource = DataAccess.GetData(demandesCommand);
            //Load Combo box
            string nomAssQuery = "SELECT * FROM Association";
            SqlCommand nomAssCommand = new SqlCommand(nomAssQuery);
            nomAssCmbBx.DataSource = DataAccess.GetData(nomAssCommand);
            nomAssCmbBx.DisplayMember = "Nom_Ass";
            nomAssCmbBx.ValueMember = "id_ass";
        }


        private void stagesDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string demandesQuery = "SELECT * FROM Demande_Inscription WHERE Id_Stage=@selectedID";
            SqlCommand demandesCommand = new SqlCommand(demandesQuery);
            demandesCommand.Parameters.AddWithValue("@selectedID", stagesDgv.SelectedRows[0].Cells["id_stage"].Value);
            demandesDgv.DataSource = DataAccess.GetData(demandesCommand);

        }

        private void afiicherBtn_Click(object sender, EventArgs e)
        {
            demandesDgv.DataSource = null;
            if (parAssRadioBtn.Checked)
            {
                string query = "SELECT * From stage WHERE Id_Ass=@selectedID ";
                SqlCommand command = new SqlCommand(query);
                command.Parameters.AddWithValue("@selectedID", nomAssCmbBx.SelectedValue);
                stagesDgv.DataSource = DataAccess.GetData(command);
            }
            else if (parPeriodeRadioBtn.Checked)
            {
                if (string.IsNullOrEmpty(dateDebutTxtBx.Text) || string.IsNullOrEmpty(dateFinTxtBx.Text))
                    MessageBox.Show("Fill everything and try again");
                else
                {
                    string query = "SELECT * From stage  WHERE Date_Debut >=@dateDebut AND Date_fin<=@dateFin ";
                    SqlCommand command = new SqlCommand(query);
                    command.Parameters.AddWithValue("@dateDebut", dateDebutTxtBx.Text);
                    command.Parameters.AddWithValue("@dateFin", dateFinTxtBx.Text);
                    stagesDgv.DataSource = DataAccess.GetData(command);
                }

            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = (DataTable)stagesDgv.DataSource;
            dataTable.TableName = "Stages List";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.InitialDirectory = @"c:\Documents";
            saveFileDialog.FileName = "La liste des stages";
            saveFileDialog.Filter = "XML File (*.XML)| *.XML";
            saveFileDialog.Title = "XML Export";
            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    dataTable.WriteXml(saveFileDialog.FileName);
                    MessageBox.Show("The data have been exported successfull","Info");
                }
                catch (Exception Error)
                {
                    MessageBox.Show("The following error occured: "+Error.Message);
                    return;
                }          
            }

        }
    }
}
