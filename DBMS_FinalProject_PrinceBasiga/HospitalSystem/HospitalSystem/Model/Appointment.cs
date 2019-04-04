using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalSystem.Model
{
    public struct Appointment
    {

        DateTime schedule;
        string reasonDesc;
        Triage urgency;
        Specialty reason;


        public Appointment(DateTime schedule, Triage urgency, Specialty reason, string reasonDesc)
        {

            this.schedule = schedule;
            this.urgency = urgency;
            this.reason = reason;
            this.reasonDesc = reasonDesc;


        }

        public override string ToString()
        {

            string urgencyString = urgency.ToString();
            string stringified = String.Format("{0} {1} {2} {3} {4}", schedule.ToShortDateString(), schedule.ToShortTimeString(), urgency.ToString(), reason.ToString(), reasonDesc);

            return stringified;
        }

    }
}
