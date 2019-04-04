using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalSystem
{
    public partial class Homepage : Form
    {
        private Model.Hospital selectedHospital = null;
        Model.Patient loggedIn = null;
      

        CustomUserControls.LoginWindow loginView;

        public Homepage() : this(null)
        {
            loginView = new CustomUserControls.LoginWindow(this);

        }

        public Homepage(Model.Patient loggedIn)
        {
            this.loggedIn = loggedIn;
            InitializeComponent();
        }

        private void updateFields()
        {
            if (loggedIn != null)
            {
                loggedInLabel.Visible = true;
                loggedInEmail.Visible = true;
                loggedInEmail.Text = loggedIn.Email;
                registerButton.Visible = false;
                loginButton.Visible = false;
                logoutButton.Visible = true;
                showAppointments.Visible = true;
            }
            else
            {
                loggedInLabel.Visible = false;
                loggedInEmail.Text = "";
                showAppointments.Visible = true;
                registerButton.Visible = true;
                loginButton.Visible = true;
                logoutButton.Visible = false;
                showAppointments.Visible = false;


            }
        }

      

        private void Homepage_Load(object sender, EventArgs e)
        {
           
            updateFields();


            LoadHospitals(null);


        }

     


        //Called by EventHandler when button clicked.
        private void LoadHospitalDescription(int hospitalID)
        {

           selectedHospital = new Model.Hospital(hospitalID);


            selectedHospitalName.Text = selectedHospital.Name;
            street.Text = selectedHospital.Address.street;
            city.Text = selectedHospital.Address.city;
            state.Text = selectedHospital.Address.state;
            isHiring.Text = (selectedHospital.IsHiring) ? "Yes" : "No";


          
        
        }
        private void addFilter(string filterCategory, string filter)
        {
            if (filterCategory == "City") {
                
                if (!cities.Items.Contains(filter))
                {
                    cities.Items.Add(filter);
                }
            }
            else if (filterCategory == "State")
            {
                if (!states.Items.Contains(filter))
                {
                    states.Items.Add(filter);
                }
            }
        }

        //Loads list with all hospitals from Database.

        private void LoadHospitals(Dictionary<String,String> conditions)
        {
            while (hospitalPanel.Controls.Count > 0)
            {
                hospitalPanel.Controls.RemoveAt(0);
            }
            
            //Works, populates hopsital list
            using (SqlConnection connection = new SqlConnection(DatabaseManager.ConnectionString("HospitalDB")))
            {

                connection.Open();

                Point offset = new Point(10, 10);
                if (connection.State == ConnectionState.Open)
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        //Only name and address to show in list, then i they click will show more.
                        command.CommandText = "SELECT name,state,city,street,hospitalID FROM Hospital.dbo.Hospitals";

                        if (conditions != null && conditions.Count > 0)
                        {
                            command.CommandText += " WHERE";


                            foreach (KeyValuePair<String, String> condition in conditions)
                            {
                                command.CommandText += " " + condition.Key + " = @" + condition.Key;
                                command.Parameters.AddWithValue("@" + condition.Key, condition.Value);
                                command.CommandText += " AND";
                            }

                            string temp = "";
                            for (int i = command.CommandText.Length - 4; i < command.CommandText.Length; ++i)
                            {

                                temp += command.CommandText[i];

                            }

                            if (temp == " AND")
                            {

                                command.CommandText = command.CommandText.Remove(command.CommandText.Length - 4, 4);
                            }
                        }


                     
                        SqlDataReader cursor = command.ExecuteReader();

                        Object[] tuple = new Object[cursor.FieldCount];
                        int timesRead = 0;
                        while (cursor.Read())
                        {
                            timesRead += 1;

                            cursor.GetValues(tuple);

                            string hospitalListELement = String.Format("{0}, {1}, {2}, {3}", ((string)tuple[0]).Trim(), ((string)tuple[1]).Trim(),
                                ((string)tuple[2]).Trim(), ((string)tuple[3]).Trim());

                            addFilter("State", (string)tuple[1]);
                            addFilter("City", (string)tuple[2]);



                            //Okay so it just doesn't show the second input and fucked up test input;
                            //hospitalList.Items.Add(hospitalListELement);
                            RadioButton newButton = new RadioButton()
                            {
                                Text = hospitalListELement,
                                AutoSize = true
                            };

                            //I see what's happening here it's capturing references of the tuple, so always last
                            //so needed to just create local copy.
                            int hospitalID = (int)tuple[4];
                            newButton.Click += (object obj, EventArgs e) =>
                            {
                                //Each button will pass itself to upate hospital information function
                                RadioButton clicked = (RadioButton)obj;

                                LoadHospitalDescription(hospitalID);

                                foreach (RadioButton rb in hospitalPanel.Controls)
                                {
                                    rb.BackColor = Color.Empty;
                                }
                                clicked.BackColor = Color.Blue;


                            };

                            hospitalPanel.Controls.Add(newButton);
                            newButton.Location = offset;
                            offset.Y += 20;

                            int x = hospitalPanel.Controls.Count;
                            newButton.Show();
                            hospitalPanel.Dock = DockStyle.Fill;
                            //Fuck, of course has to be in position =  

                        }

                        cursor.Close();

                    }
                }

            }
            hospitalPanel.Controls[0].Select();

        }

        private void appointmentButton_Click(object sender, EventArgs e)
        {

            if (selectedHospital != null)
            {
                if (loggedIn == null)
                {
                    loginButton_Click(sender, e);
                }


                if (loggedIn != null)
                {
                    MakeAppointmentView view = new MakeAppointmentView();

                    view.LoggedInPatient = loggedIn;
                    view.InHospital = selectedHospital;
                    view.ShowDialog();
                }
            }



        }

        #region Account Relaed methods
        private void registerButton_Click(object sender, EventArgs e)
        {
            if (selectedHospital != null)
            {

                RegisterPatientView registerView = new RegisterPatientView(this);
                registerView.InHospital = selectedHospital;


                registerView.ShowDialog();
                this.Activate();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if (selectedHospital != null)
            {
                

                loginView.InHospital = selectedHospital;

                loginView.ShowDialog();

                updateFields();
            }            
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            loggedIn = null;

            updateFields();
           
        }

        public void login(string email, string password)
        {
            loggedIn = selectedHospital.retrievePatientInfo(email, password);
            if (loggedIn == null)
            {
                throw new Exception("User account does not exist");
            }

            updateFields();

        }


        #endregion

        private void filterButton_Click(object sender, EventArgs e)
        {
            //We'll see if auto filters or errors

            Dictionary<String, String> conditions = new Dictionary<string, string>();
            //Minus 2 for buttons and plus 2 each time to skip labels
            for (int i = filterGroup.Controls.Count - 1;  i > 1; i -= 2)
            {
               
                ComboBox box = filterGroup.Controls[i] as ComboBox;
                if (box != null)
                {
                    if (box.SelectedItem != null)
                    {
                        conditions[(filterGroup.Controls[i - 1] as Label).Text.ToLower()] =(String)box.SelectedItem;
                    }
                }
            }

            LoadHospitals(conditions);
           
        }

        private void clearFilterBUtton_Click(object sender, EventArgs e)
        {
            for (int i = filterGroup.Controls.Count - 1; i > 1; i -= 2)
            {
              
                ComboBox box = filterGroup.Controls[i] as ComboBox;
                if (box != null)
                {
                    box.SelectedItem = null;
                }
            }

            LoadHospitals(null);
        }

        //Right now the entity managing all this
        private void showAppointments_Click(object sender, EventArgs e)
        {
            Console.WriteLine("dssf");
            using (SqlConnection connection = new SqlConnection(DatabaseManager.ConnectionString("HospitalDB")))
            {
                connection.Open();
                
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT apptTime, apptDate, reason, importance FROM Appointments WHERE" +
                        " patientID = @patientID AND hospitalID = @hospitalID;";


                  /*
                    command.Parameters.AddRange(new SqlParameter[2]{

                        new SqlParameter("@patientID",loggedIn.patientID),
                        new SqlParameter("@hospitalID",selectedHospital.HospitalID)
                    });
                    */
                    SqlDataReader reader = command.ExecuteReader();
                    

                    //I know what to add but no time, turning in and will resubmit later.
                    /*
                    if (reader.Read())
                    {
                        Object[] tuples = new Object[reader.FieldCount];

                        reader.GetValues(tuples);


                        Model.Appointment appointment = new Model.Appointment()

                        
                    }*/
                }
            }
            //No need to check null because this button cannot be clicked if patient is not null
        }
    }
}
