using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EFF_2019
{
    public partial class Q3 : Form
    {
        public Q3()
        {
            InitializeComponent();
        }

        //Biding Source
        BindingSource binding = new BindingSource();

        private void MAJAssForm_Load(object sender, EventArgs e)
        {
            //Fill ville Combo box
            string villeQuery = "SELECT * From Ville";
            SqlCommand villeCommand = new SqlCommand(villeQuery);
            idVilleCmbBx.DataSource = DataAccess.GetData(villeCommand);
            idVilleCmbBx.DisplayMember = "nom_ville";
            idVilleCmbBx.ValueMember = "id_ville";

            //Bindin Data
            string assQuery = "SELECT A.*,V.Nom_Ville FROM Association A " +
                              "JOIN Ville V On A.Id_Ville = V.Id_Ville";
            SqlCommand assCommand = new SqlCommand(assQuery);
            binding.DataSource = DataAccess.GetData(assCommand);
            assIdTxtBx.DataBindings.Add("Text", binding, "Id_Ass");
            adrTxtBx.DataBindings.Add("Text", binding, "Adresse");
            telTxtBx.DataBindings.Add("Text", binding, "Telephone");
            idVilleCmbBx.DataBindings.Add("SelectedValue", binding, "id_ville");
            nomAssTxtBx.DataBindings.Add("Text", binding, "Nom_Ass");
            rsTxtBx.DataBindings.Add("Text", binding, "RaisonSocial");

        }

        private void ajtBtn_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Association VALUES (@idAss,@nomAss,@RS,@Adr,@tel,@idVille) ";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddRange(new SqlParameter[]
            {
                new SqlParameter("@idAss",assIdTxtBx.Text),
                new SqlParameter("@nomAss",nomAssTxtBx.Text),
                new SqlParameter("@RS",rsTxtBx.Text),
                new SqlParameter("@Adr",adrTxtBx.Text),
                new SqlParameter("@tel",telTxtBx.Text),
                new SqlParameter("@idVille",idVilleCmbBx.SelectedValue),
            });
            if (DataAccess.SetData(command))
                MessageBox.Show("One association have been added", "info");
            else
                MessageBox.Show("Something wrong happend, please check the information you entered");
        }


        private void modBtn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Association " +
                                "SET Nom_Ass = @nomAss, RaisonSocial = @rs, Adresse = @adr, Telephone = @tel, Id_Ville = @villeId " +
                                "WHERE Id_Ass = @idAss";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddRange(new SqlParameter[]
            {
                new SqlParameter("@idAss",assIdTxtBx.Text),
                new SqlParameter("@nomAss",nomAssTxtBx.Text),
                new SqlParameter("@RS",rsTxtBx.Text),
                new SqlParameter("@Adr",adrTxtBx.Text),
                new SqlParameter("@tel",telTxtBx.Text),
                new SqlParameter("@villeId",idVilleCmbBx.SelectedValue)
            });
            if (DataAccess.SetData(command))
                MessageBox.Show("One assoctiaion have been modified", "info");
            else
                MessageBox.Show("Something wrong happend, please check the information you entered");

        }
        //Search Button
        private void rechBtn_Click(object sender, EventArgs e)
        {
            binding.Position = int.Parse(idSearchTxtBx.Text) - 1;
        }

        private void idSearchTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
