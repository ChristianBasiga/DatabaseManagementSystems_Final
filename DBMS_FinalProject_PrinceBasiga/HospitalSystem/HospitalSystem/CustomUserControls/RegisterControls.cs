using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HospitalSystem
{
    public partial class RegisterControls : UserControl
    {
        private void RegisterControls_Load(object sender, EventArgs e)
        {
            birthDate.MaxDate = DateTime.Today;
            birthDate.MinDate = new DateTime(DateTime.Today.Year - 120, DateTime.Today.Month, DateTime.Today.Day);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}