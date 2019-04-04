using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HospitalSystem.CustomUserControls
{
    public partial class SuccessfulTransactionView : Form
    {
        public SuccessfulTransactionView(string transactionName, string transactionDesc)
        {
            InitializeComponent();
            this.redoButton.Text = transactionName;
            //IN this case will be patient info
            this.transactionDescription.Text = transactionDesc;
        }


        

        private void SuccessfulTransactionView_Load(object sender, EventArgs e)
        {


        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
