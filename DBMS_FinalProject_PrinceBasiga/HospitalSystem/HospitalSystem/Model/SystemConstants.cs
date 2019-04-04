using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalSystem.Model
{
   
        public enum Gender: byte
        {
            M,
            F
        };
        
        public enum Triage
        {
            RESUSCITATION = 1,
            EMERGENT = 2,
            URGENT = 3,
            LESS_URGENT = 4,
            NON_URGENT = 5
        };

        public enum PatientStatus
        {
            IN_RECOVERY,
            IN_OPERATION,
            IN_PREP
        };

       
        public enum Specialty
        {
            SURGERY,
            CHIROPRACTOR

        };


    public struct Address
        {
            public Address(string state, string city, string street)
            {
                this.state = state;
                this.city = city;
                this.street = street;

            }
            public string state;
            public string city;
            public string street;

        };

}
