using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace HospitalSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //TODO:
            /*
             * Consider making views either User Controls or Modals.
             * Probably latter
             * 
             * 
             * 
             * 
             * 
             */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form hospitalSearchPage = new Form();
            // RegisterPatientView f = new RegisterPatientView();
            //MakeAppointmentView f = new MakeAppointmentView();
            Homepage f = new Homepage();

          
            //Registering this Registryform with his specific hospital, in complete version
            //will actually have user choose it
           // f.InHospital = hospital;
            
            Application.Run(f);
            
        }

      
    }

    //For general functions and for when we need to pull all of a relation
    static class DatabaseManager
    {
        public static string ConnectionString(string name)
        {
            string result = ConfigurationManager.ConnectionStrings[name].ConnectionString;


            return result;
        }

        public static void validateConnection(SqlConnection connection)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
        }

       /* Maybe just general stuff, cause really, atleasy rn  only homepage needs to pull ALL  the hospitals, and only need to do it on construction.
        * //Cause may overwrite it with filtered version later.
        * public static List<Model.Hospital> loadHospitals()
        {
            List<Model.Hospital> hospitals;


        }*/
    }
}
