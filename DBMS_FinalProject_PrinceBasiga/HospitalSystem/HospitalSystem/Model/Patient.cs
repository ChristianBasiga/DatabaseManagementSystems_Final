using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalSystem.Model
{
    public class Patient
    {
        //Don't think really need this here tbh, as I'm writing into disk just need to get count, toherwise just keep making 
        //patients cause ID only really matters in the Database not in main memory.
        // int patientID;
        string firstName;
        string lastName;
        string email;
        Gender gender;
        DateTime birthDate;

        //If negative then not va

       
        public Patient(string firstName, string lastName, string email, Gender gender, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.gender = gender;
            this.birthDate = birthDate;
        }

        public string FirstName{
            get
            {
                return firstName;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
        }

        public Gender Gender
        {
            get
            {
                return gender;
            }
        }

        public DateTime DateofBirth
        {
            get
            {
                return birthDate;
            }
        }


        public override int GetHashCode()
        {
            return email.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.email == (obj as Patient).email;
        }

    }
}
