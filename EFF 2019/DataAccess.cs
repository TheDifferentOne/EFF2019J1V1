using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFF_2019
{
    public class DataAccess
    {
        //Connction String
        static string connectionString = @"Server=EH\EH;DATABASE=EFF_2019_J1_V1;Integrated Security=true";
        //Sql Connection
        static SqlConnection connectToServer = new SqlConnection(connectionString);
        static SqlDataReader dataReader;
        //GetData Function
        public static DataTable GetData(SqlCommand command)
        {
            DataTable dataTable = new DataTable();
            try
            {
                command.Connection = connectToServer;
                connectToServer.Open();
                dataReader = command.ExecuteReader();
                dataTable.Load(dataReader);

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
            finally
            {
                connectToServer.Close();
            }
            return dataTable;
        }
        //SetData Function
        public static bool SetData(SqlCommand command)
        {
            try
            {
                command.Connection = connectToServer;
                connectToServer.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
                return false;
            }
            finally
            {
                connectToServer.Close();
            }
            return true;
        }

    }
}
