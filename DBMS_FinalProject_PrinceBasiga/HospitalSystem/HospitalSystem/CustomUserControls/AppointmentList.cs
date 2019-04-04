using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HospitalSystem.CustomUserControls
{
    public partial class AppointmentList : Form
    {
       
        public List<Model.Appointment> appointments;
        public AppointmentList()
        {
            InitializeComponent();
            appointments = new List<Model.Appointment>();
        }

        private void AppointmentList_Load(object sender, EventArgs e)
        {

        }
    }
}
