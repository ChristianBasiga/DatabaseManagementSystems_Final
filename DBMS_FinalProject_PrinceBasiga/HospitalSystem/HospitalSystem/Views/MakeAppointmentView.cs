using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HospitalSystem.CustomUserControls;

namespace HospitalSystem
{
    public partial class MakeAppointmentView : Form
    {
        public MakeAppointmentView()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (((String)triage.SelectedItem) == "" || ((String)reasonList.SelectedItem) == "")
            {
                errorMessage.Visible = true;
                errorMessage.Text = "Please fill all fields";
                return;
            }

            Model.Triage urgency = (Model.Triage)Enum.Parse(typeof(Model.Triage), (string)triage.SelectedItem);
            Model.Specialty reason =  (Model.Specialty)Enum.Parse(typeof(Model.Specialty), (string)reasonList.SelectedItem);
            try
            {
                appointmentIn.AddAppointment(schedulePicker.Value, reason, triage.SelectedItem.ToString(), detailedReason.Text, patient);
                //If successfull, hide error message.
                errorMessage.Visible = false;
               

            }
            catch (Exception err)
            {
                errorMessage.Text = err.Message;
                errorMessage.Visible = true;
            }

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MakeAppointmentView_Load(object sender, EventArgs e)
        {

            foreach (string reason in Enum.GetNames(typeof(Model.Specialty))) {
                this.reasonList.Items.Add(reason);
            }


            foreach (string urgencyLevel in Enum.GetNames(typeof(Model.Triage)))
            {
                this.triage.Items.Add(urgencyLevel);
            }

            schedulePicker.MinDate = DateTime.Today;
            
        }
    }
}
