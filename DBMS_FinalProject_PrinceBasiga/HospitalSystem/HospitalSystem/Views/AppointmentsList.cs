using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HospitalSystem.Views
{
    public partial class AppointmentsList : Form
    {

        //Do I actually need this?
        List<Model.Appointment> appointments;


        public AppointmentsList(Model.Patient patient, Model.Hospital hospitalIn)
        {
            

            InitializeComponent();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT apptTime, apptDate, importance, reason FROM Hospital.dbo.Appointments" +
                        "\n WHERE patientID = @patientID AND hospitalID = @hospitalID;";

                    SqlDataReader cursor = command.ExecuteReader();

                    if (cursor.Read())
                    {
                        object[] tuple = new object[cursor.FieldCount];

                        cursor.GetValues(tuple);
                        DateTime date = (DateTime)tuple[0];
                        DateTime time = (DateTime)tuple[1];
                        DateTime schedule = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second, DateTimeKind.Local);

                        Model.Triage importance = (Model.Triage)Enum.Parse(typeof(Model.Triage), (string)tuple[2]);
                        Model.Specialty specialty = (Model.Specialty)Enum.Parse(typeof(Model.Specialty), (string)tuple[3]);



                    }
                }
            }
           
        }

        private void AppointmentsList_Load(object sender, EventArgs e)
        {

        }
    }
}
