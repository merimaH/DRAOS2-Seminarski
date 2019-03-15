using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboticParkingSystem
{
    static class Program
    {
        public static int brojacUplata = 2;
        //funkcija za izvrsavanje sql naredbe u obliku stringa
        public static void izvrsiSql(string sqlNaredba)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RoboticParkingSystem.Properties.Settings.Database2ConnectionString"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                SqlCommand sqlCommand = new SqlCommand(sqlNaredba, cn);
                sqlCommand.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Random linija
        }
    }
}
