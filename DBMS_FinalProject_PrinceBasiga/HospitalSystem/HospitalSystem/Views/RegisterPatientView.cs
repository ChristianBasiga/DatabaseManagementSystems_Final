using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using HospitalSystem.CustomUserControls;

namespace HospitalSystem
{
    public partial class RegisterPatientView : Form
    {
        private Homepage from;
        public RegisterPatientView(Homepage from)
        {
            this.from = from;
            InitializeComponent();
        }

        private string validateInput()
        {
            string result = null;


            string emailInput = email.Text;


            //Validating email
            //If doesn't contain any of these, then is auto invalid
            //Less than 4 cause with @.  need atleast 2 on both sides so total of 4 characters minimum
            if (!emailInput.Contains('@') || !emailInput.Contains('.') || emailInput.Length < 4)
            {
                result = "Invalid Email";
            }
            else if (generalRegisterControls.FirstName.Any((char element) => { return Char.IsDigit(element); }) || generalRegisterControls.LastName.Any((char element) => { return Char.IsDigit(element); })){
                result = "Invalid name";
            }

            return result;

        }


        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (validateInput() == null)
            {
                errorMessage.Text = "";
            }
            else
            {
                errorMessage.Text = validateInput();
                return;
            }


            if (generalRegisterControls.Gender == "")
            {
                errorMessage.Text = "There are required fields not filled in";
                return;

            }
            else
            {
                errorMessage.Visible = false;
            }


            Model.Gender gender = (generalRegisterControls.Gender == "Male") ? Model.Gender.M : Model.Gender.F;
            Model.Patient patient = new Model.Patient(generalRegisterControls.FirstName, generalRegisterControls.LastName, email.Text, gender, generalRegisterControls.DateofBirth);

            try
            {
                hospital.addPatient(patient, password.Text);
                bool redoAppointment = false;


                using (SuccessfulTransactionView result = new SuccessfulTransactionView("Register Another Patient", String.Format(" Patient Information:\n Name:{0} {1}\n Email:{2}", patient.FirstName, patient.LastName, patient.Email)))
                {
                    result.redoButton.Click += (object obj, EventArgs events) =>
                    {
                        redoAppointment = true;
                    };



                    result.ShowDialog();

                    if (redoAppointment)
                    {

                        ClearForm();

                    }
                    else
                    {
                       
                            hospital.WritePatientsInformation();

                            from.login(email.Text, password.Text);
                        
                        this.Close();
                    }
                    //After registering, auto login.
                }
            }
            catch (Exception err)
            {
                errorMessage.Text = err.Message;
            }

            
           
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

            hospital.WritePatientsInformation();
            this.Close();

        }

        private void RegisterPatientView_Load(object sender, EventArgs e)
        {
            if (sender is Homepage)
            {
                from = (Homepage)sender;
            }

        }

        private void ClearForm()
        {
            generalRegisterControls.clearForm();
            email.Text = "";
            password.Text = "";
            

        }

        private void generalRegisterControls_Load(object sender, EventArgs e)
        {

        }

        private void hospitalName_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
