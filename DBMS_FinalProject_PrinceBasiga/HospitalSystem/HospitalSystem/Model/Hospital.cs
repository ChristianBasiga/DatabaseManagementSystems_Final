using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace HospitalSystem.Model
{
    public partial class Hospital
    {
        struct Appointment
        {
            public DateTime apptSchedule;
            public Specialty reason;
            public Triage urgency;
            public string detailedReason;
            public Patient patient;

            public Appointment(DateTime schedule, Specialty reason, Triage urgency, Patient patient, string details)
            {
                apptSchedule = schedule;
                this.reason = reason;
                this.urgency = urgency;
                this.patient = patient;
                this.detailedReason = details;
            }
        }

        static int hospitalIDs;
        int id;
        private int numberOfOpenPositions;
        string hospitalName;
        //May be no buffer for appointments, just auto insert into db
       // List<Appointment> appointments;
        Address address;

        //Don't need to fill these up everytime load Hospital, this is mainly store in mainmemory new patients
        //Instead of automatically just adding it in database which would increase times read and write to disk.
        //It is Patient with password they want, not going to store in patient cause then would need to make a getter for it.
        //It also just makes more sense here, cause patient does not have single password, it differs per Hospital they in.
        Dictionary<Patient, string> patients;


        #region Hospital Methods
      
        public Hospital(string name, Address address, int budget, int payrate)
        {
            //I want it to basically match with hospital in DB as if loaded it in with id,
            patients = new Dictionary<Patient, string>();
            this.hospitalName = name;
            this.address = address;
          
            
          

            using (SqlConnection connection = new SqlConnection(DatabaseManager.ConnectionString("HospitalDB")))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                if (hospitalIDs == 0)
                {
                    command.CommandText = "SELECT MAX(hospitalID) FROM Hospital.dbo.Hospitals;";
                    object result = command.ExecuteScalar();
                    //If not null start at max.
                    if (result != null)
                    {
                       hospitalIDs = (int)result;
                       
                    }

                    //No matter what increment cause if was null, then we start at 1 anyway.
                    hospitalIDs += 1;
                    id = hospitalIDs;


                }


                command.CommandText = "INSERT INTO Hospital.dbo.Hospitals(hospitalID,name,street,state,city,hiringBudget,payrate)\n" +
                    "VALUES(@hospitalID,@name,@street,@state,@city,@hiringBudget,@payrate);";

                command.Parameters.AddRange(new SqlParameter[7]{
                    new SqlParameter("@hospitalID",id),
                    new SqlParameter("@name",hospitalName),
                    new SqlParameter("@street", address.street),
                    new SqlParameter("@state", address.state),
                    new SqlParameter("@city", address.city),
                    new SqlParameter("@hiringBudget",budget),
                    new SqlParameter("@payrate",payrate)
                });

                command.ExecuteNonQuery();

                numberOfOpenPositions = budget / payrate;

            }
        }

        //If pass in id then already existed and loaded from data base
        public Hospital(int id)
        {
            patients = new Dictionary<Patient, string>();
            //Add here query for hospital information
            //Should I automatically
            this.id = id;
            if (!hospitalExists())
            {
                throw new Exception("There is no hospital with that ID stored in our database");
            }
            else
            {
                //Otherwise get information for this hospital
                using (SqlConnection connection = new SqlConnection(DatabaseManager.ConnectionString("HospitalDB")))
                {

                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT name,state,city,street,hiringBudget,payRate FROM Hospital.dbo.hospitals WHERE hospitalID = @hospitalID;", connection);
                    command.Parameters.Add("@hospitalID", SqlDbType.Int);
                    command.Parameters["@hospitalID"].Value = id;

                    //Don't need cursor since not multiple values, so dataset fine
                    //Actually tbh, this way required me to make 1 more varaible than did with cursor. Oh well
                    //For now leaving as is.
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();
                    //Datatable would've been better for this tbh. Cause then could just key it.
                    Object[] tuple = new Object[reader.FieldCount];
                    reader.GetValues(tuple);
                    hospitalName = (string)tuple[0];
                    address = new Address((string)tuple[1], (string)tuple[2], (string)tuple[3]);

                    //Basically same thing the function in system does.
                    numberOfOpenPositions = (int)tuple[4] / (int)tuple[5];

 
                    reader.Close();

                }
            }
        }


        bool hospitalExists()
        {
            bool doesExist = true;
            SqlConnection connection = new SqlConnection(DatabaseManager.ConnectionString("HospitalDB"));
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open) {

                string commandStr = "SELECT Hospital.dbo.existingHospital(@hospitalID)";

                SqlCommand command = new SqlCommand(commandStr, connection);
                command.Parameters.Add(new SqlParameter("@hospitalID", System.Data.SqlDbType.Int));
                command.Parameters["@hospitalID"].Value = id;

                byte yo = ((byte)command.ExecuteScalar());
                doesExist = ((byte)command.ExecuteScalar()) == 1;

            }

            connection.Close();
            return doesExist;

        }
         

        //Methods, Moved to inside cosntructor as realize don't need payrate and budget in mainmemory
        //while that may change in main memory, all it's changes should be updated to DB, incase try to hire else where
        //And will deal with conflicts of deciding which employee to keep in the system itself, it will be a function there.
        //Tested and works fine
        /*private void WriteHospitalInformation()
        {
            using (SqlConnection connection = new SqlConnection(DatabaseManager.ConnectionString("HospitalDB")))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                string commandStr = String.Format("INSERT INTO Hospital.dbo.Hospitals(hospitalID,name,street,state,city,hiringBudget)\n" +
                    "VALUES({0},'{1}','{2}','{3}','{4}',{5});", id, hospitalName, address.street, address.state, address.city, budget);

                command.CommandText = commandStr;
                command.ExecuteNonQuery();

            }

        }*/

        #endregion

        #region Patient Methods

        private int RetrievePatientID(Patient patient)
        {
            int patientID = -1;
            if (patient == null)
            {
                throw new Exception("Please make sure a patient is logged into the hospital before being able to make\n Appointments");

            }
            using (SqlConnection connection = new SqlConnection(DatabaseManager.ConnectionString("HospitalDB")))
            {

                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        cmd.Connection = connection;
                        cmd.CommandText = "SELECT patientID FROM Hospital.dbo.Patients WHERE hospitalID = @hospitalID AND email = @email";
                        cmd.Parameters.AddWithValue("@hospitalID", id);
                        cmd.Parameters.AddWithValue("@email", patient.Email);


                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            patientID = (int)(result);
                        }

                    }
                }

            }

            return patientID;

        }

        public void WritePatientsInformation()
        {
            if (patients.Count > 0)
            {
                using (SqlConnection connection = new SqlConnection(DatabaseManager.ConnectionString("HospitalDB")))
                {
                    if (connection == null)
                    {
                        int x = 5;
                        return;
                    }
                    DatabaseManager.validateConnection(connection);

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    //Saving Patients
                    string commandString = "SELECT COUNT(patientID) FROM Hospital.dbo.Patients WHERE hospitalID = @hospitalID;";

                    command.CommandText = commandString;
                    command.Parameters.Add("@hospitalID", SqlDbType.Int);
                    command.Parameters["@hospitalID"].Value = id;
                    //Looked up, AND this is exactly what they say to do.
                    //so what up

                    int nextID = (int)command.ExecuteScalar() + 1;
                    commandString = "INSERT INTO Hospital.dbo.Patients(patientID, firstName,lastName,email,pw,gender,birth,hospitalID)";
                    string values = "VALUES(@patientID,@firstName, @lastName,@email,@pw,@gender,@birth,@hospitalID);";


                    command.CommandText = commandString + values;
                    command.Parameters.Add("@patientID", SqlDbType.Int);
                    command.Parameters.Add("@firstName", SqlDbType.VarChar, 150);
                    command.Parameters.Add("@lastName", SqlDbType.VarChar, 150);
                    command.Parameters.Add("@email", SqlDbType.VarChar, 320);
                    command.Parameters.Add("@pw", SqlDbType.VarChar, 255);
                    command.Parameters.Add("@gender", SqlDbType.Char, 1);
                    command.Parameters.Add("@birth", SqlDbType.Date);

                    foreach (KeyValuePair<Patient, string> pair in patients)
                    {
                        char gender = pair.Key.Gender == Gender.M ? 'M' : 'F';

                        //WIll take out one attribute at time to see which one is being truncated
                        command.Parameters["@patientID"].Value = nextID;
                        command.Parameters["@firstName"].Value = pair.Key.FirstName;
                        command.Parameters["@lastName"].Value = pair.Key.LastName;
                        command.Parameters["@email"].Value = pair.Key.Email;
                        command.Parameters["@pw"].Value = pair.Value;
                        command.Parameters["@gender"].Value = gender;
                        command.Parameters["@birth"].Value = pair.Key.DateofBirth.Date;
                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (Exception err)
                        {
                            throw new Exception("Failed to register");

                        }
                        nextID += 1;

                    }

                }//Disposable so the using automatically closes this.

            }

            //Clears the buffer to avoid reinserting already inserted patients
            patients.Clear();
        }

        public Patient retrievePatientInfo(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseManager.ConnectionString("HospitalDB")))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT firstName,lastName,gender,birth,patientID FROM Hospital.dbo.Patients WHERE email = @email AND pw = @password AND hospitalID = @hospitalID;";

                    command.Parameters.AddRange(new SqlParameter[3]
                    {
                        new SqlParameter("@email",email),
                        new SqlParameter("@password",password),
                        new SqlParameter("@hospitalID",id)

                    });

                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            object[] tuple = new object[reader.FieldCount];
                            reader.GetValues(tuple);

                            string firstName = (string)tuple[0];
                            string lastName = (string)tuple[1];
                            Gender gender = (Gender)Enum.Parse(typeof(Gender), (string)tuple[2]);
                            DateTime birthDate = (DateTime)tuple[3];
                            Patient patient = new Patient(firstName, lastName, email, gender, birthDate);
                            reader.Close();
                            return patient;
                        }
                    }
                    catch (Exception err)
                    {
                        //Will logg err message
                       
                    }
                   
                }
            }
            return null;
        }
        public void addPatient(Patient patient, string pw)
        {
            //Either patient in main memory or patient from DB, then it's valid putting in buffer
            //This way won't have to filter as I'm pushing the buffer.
            if (patients.ContainsKey(patient) || RetrievePatientID(patient) != -1)
                throw new Exception("Patient with that Email is already registered with this Hospital");

            //This is fine
            patients[patient] = pw;

            //Then to add here is check for size, then if buffer is above certain amount
            //then need to log all patients

        }


       
        #endregion



        #region Appointment Methods

        //CHange back to enum later
        public void AddAppointment(DateTime schedule, Specialty reason, string urgency, string detailedReason, Patient makingAppointment)
        {
            
            int patientID = RetrievePatientID(makingAppointment);
            using (SqlConnection connection = new SqlConnection(DatabaseManager.ConnectionString("HospitalDB")))
            {

                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        

                        command.Connection = connection;
                        command.CommandText = "INSERT INTO Hospital.dbo.Appointments(patientID,apptTime,apptDate,importance,reason,hospitalID)\n" +
                            "VALUES(@patientID,@apptTime,@apptDate,@importance,@reason,@hospitalID);";

                        command.Parameters.AddRange(new SqlParameter[6]
                        {

                            new SqlParameter("@patientID",patientID),
                            new SqlParameter("@apptTime", schedule.TimeOfDay),
                            new SqlParameter("@apptDate",schedule.Date),

                            new SqlParameter("@importance", urgency),

                            //Change all the stuff that use specialites now.
                            new SqlParameter("@reason",reason),
                            new SqlParameter("@hospitalID",id)




                        });


                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (SqlException err)
                        {
                            //Maybe throw something else in regards to it? Or just throw same exception regrdlesss
                            string message = err.Message;


                            //Tbh, the dates shouldn't even show the times that are no longer valid
                            //Will have to look into that, cause is frustrating to have to try, fail and then try another patient
                            //Will not worry about triage and sorting the appointmetn times based on that, that's up to actual users of this interface
                            //to decide.
                            throw new Exception("Failed to make an appointment, that time has already been booked by another Patient");
                        }


                    }
                }
            }
        
        }

        #endregion


        #region Properties
        public string Name
        {
            get
            {
                return hospitalName;
            }
        }
        public Address Address
        {
            get
            {
                return address;
            }
        }

        public bool IsHiring
        {
            get
            {
                return numberOfOpenPositions > 0;
            }

        }

        //Bad, really bad but quick just to get appointments list
        public int HospitalID
        {

            get
            {
                return id;
            }

        }
        #endregion
        #region Doctor Methods


#endregion 
    }
}
