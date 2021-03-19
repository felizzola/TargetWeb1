using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;            //Agregue este tercero

namespace TargetWeb1.Database
{
    public class ConectorBD
    {
        public static string servidor = "sistemastarget.myddns.me";
        public static string port = "3306";
        public static string usuario = "root";
        public static string pswd = "riachuelo";
        public static string MYSQLTIMEOUT = "300";
        //public static string DATABASE = "sistemastarget";
        public static string DATABASE = "sistemastargettest";

        public static string ararticu = DATABASE + ".xamarinararticu";
        public static string preciosml = DATABASE + ".xamarinpreciosml";
        public static string xamarinparamprecioml = DATABASE + ".xamarinparamprecioml";

        MySqlConnection Conexion = new MySqlConnection("server=" + servidor + ";port=" + port + ";database=" + DATABASE + ";" + "uid=" + usuario + ";" + "pwd=" + pswd + ";" + "default command timeout=" + MYSQLTIMEOUT + ";");
        private MySqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public DataTable dt = new DataTable();
        public MySqlDataAdapter da;
        public MySqlCommand comando;
        public bool conecto = false;
        public MySqlTransaction trans;

        public void Conectar()
        {
            try
            {
                Conexion.Open();
                //MessageBox.Show("Conectado al servidor");
                conecto = true;

            }
            catch (MySqlException ex)
            {
                //MessageBox.Show("No se ha podido conectar al servidor " + ex.ToString());
                conecto = false;
            }
            finally
            {
                Conexion.Close();
            }

        }

        public void consultasql(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new MySqlDataAdapter(sql, Conexion);
            cmb = new MySqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }
    }
}
