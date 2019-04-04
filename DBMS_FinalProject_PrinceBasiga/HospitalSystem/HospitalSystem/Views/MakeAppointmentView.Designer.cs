using System.Collections.Generic;

namespace HospitalSystem
{
    partial class MakeAppointmentView : Interfaces.IHospitalInteractor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.apptDateTime = new System.Windows.Forms.Label();
            this.schedulePicker = new System.Windows.Forms.DateTimePicker();
            this.detailedReason = new System.Windows.Forms.TextBox();
            this.detailedReasonLabel = new System.Windows.Forms.Label();
            this.triageLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.reasonList = new System.Windows.Forms.ComboBox();
            this.reasonForVisitLabel = new System.Windows.Forms.Label();
            this.loggedInLabel = new System.Windows.Forms.Label();
            this.patientLoggedIn = new System.Windows.Forms.Label();
            this.triage = new System.Windows.Forms.ComboBox();
            this.errorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // apptDateTime
            // 
            this.apptDateTime.AutoSize = true;
            this.apptDateTime.Location = new System.Drawing.Point(12, 97);
            this.apptDateTime.Name = "apptDateTime";
            this.apptDateTime.Size = new System.Drawing.Size(184, 17);
            this.apptDateTime.TabIndex = 0;
            this.apptDateTime.Text = "Appointment Date and Time";
            // 
            // schedulePicker
            // 
            this.schedulePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.schedulePicker.Location = new System.Drawing.Point(202, 97);
            this.schedulePicker.Name = "schedulePicker";
            this.schedulePicker.Size = new System.Drawing.Size(195, 22);
            this.schedulePicker.TabIndex = 1;
            this.schedulePicker.Value = new System.DateTime(2017, 12, 4, 22, 28, 0, 0);
            // 
            // detailedReason
            // 
            this.detailedReason.Location = new System.Drawing.Point(15, 233);
            this.detailedReason.Multiline = true;
            this.detailedReason.Name = "detailedReason";
            this.detailedReason.Size = new System.Drawing.Size(482, 162);
            this.detailedReason.TabIndex = 4;
            // 
            // detailedReasonLabel
            // 
            this.detailedReasonLabel.AutoSize = true;
            this.detailedReasonLabel.Location = new System.Drawing.Point(12, 191);
            this.detailedReasonLabel.Name = "detailedReasonLabel";
            this.detailedReasonLabel.Size = new System.Drawing.Size(262, 17);
            this.detailedReasonLabel.TabIndex = 5;
            this.detailedReasonLabel.Text = "Reason for Visit in More Detail(Optional)";
            // 
            // triageLabel
            // 
            this.triageLabel.AutoSize = true;
            this.triageLabel.Location = new System.Drawing.Point(12, 155);
            this.triageLabel.Name = "triageLabel";
            this.triageLabel.Size = new System.Drawing.Size(115, 17);
            this.triageLabel.TabIndex = 7;
            this.triageLabel.Text = "Level of Urgency";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(568, 242);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(153, 51);
            this.confirmButton.TabIndex = 8;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(568, 333);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(153, 51);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.titleLabel.Location = new System.Drawing.Point(15, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(60, 24);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "label1";
            // 
            // reasonList
            // 
            this.reasonList.FormattingEnabled = true;
            this.reasonList.Location = new System.Drawing.Point(407, 154);
            this.reasonList.Name = "reasonList";
            this.reasonList.Size = new System.Drawing.Size(159, 24);
            this.reasonList.TabIndex = 11;
            this.reasonList.Text = "Choose";
            // 
            // reasonForVisitLabel
            // 
            this.reasonForVisitLabel.AutoSize = true;
            this.reasonForVisitLabel.Location = new System.Drawing.Point(294, 156);
            this.reasonForVisitLabel.Name = "reasonForVisitLabel";
            this.reasonForVisitLabel.Size = new System.Drawing.Size(108, 17);
            this.reasonForVisitLabel.TabIndex = 12;
            this.reasonForVisitLabel.Text = "Reason for Visit";
            // 
            // loggedInLabel
            // 
            this.loggedInLabel.AutoSize = true;
            this.loggedInLabel.Location = new System.Drawing.Point(565, 20);
            this.loggedInLabel.Name = "loggedInLabel";
            this.loggedInLabel.Size = new System.Drawing.Size(94, 17);
            this.loggedInLabel.TabIndex = 13;
            this.loggedInLabel.Text = "Logged in as:";
            // 
            // patientLoggedIn
            // 
            this.patientLoggedIn.AutoSize = true;
            this.patientLoggedIn.Location = new System.Drawing.Point(666, 20);
            this.patientLoggedIn.Name = "patientLoggedIn";
            this.patientLoggedIn.Size = new System.Drawing.Size(124, 17);
            this.patientLoggedIn.TabIndex = 14;
            this.patientLoggedIn.Text = "Insert Patient here";
            // 
            // triage
            // 
            this.triage.Location = new System.Drawing.Point(133, 152);
            this.triage.MaxDropDownItems = 5;
            this.triage.Name = "triage";
            this.triage.Size = new System.Drawing.Size(149, 24);
            this.triage.TabIndex = 6;
            this.triage.Text = "Choose";
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Location = new System.Drawing.Point(568, 205);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(46, 17);
            this.errorMessage.TabIndex = 15;
            this.errorMessage.Text = "label1";
            this.errorMessage.Visible = false;
            // 
            // MakeAppointmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 407);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.patientLoggedIn);
            this.Controls.Add(this.loggedInLabel);
            this.Controls.Add(this.reasonForVisitLabel);
            this.Controls.Add(this.reasonList);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.triageLabel);
            this.Controls.Add(this.triage);
            this.Controls.Add(this.detailedReasonLabel);
            this.Controls.Add(this.detailedReason);
            this.Controls.Add(this.schedulePicker);
            this.Controls.Add(this.apptDateTime);
            this.Name = "MakeAppointmentView";
            this.Text = "MakeAppointmentView";
            this.Load += new System.EventHandler(this.MakeAppointmentView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label apptDateTime;
        private System.Windows.Forms.DateTimePicker schedulePicker;
        private System.Windows.Forms.TextBox detailedReason;
        private System.Windows.Forms.Label detailedReasonLabel;
        private System.Windows.Forms.Label triageLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private Model.Hospital appointmentIn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox reasonList;
        private System.Windows.Forms.Label reasonForVisitLabel;
        private System.Windows.Forms.Label loggedInLabel;

        private System.Windows.Forms.Label patientLoggedIn;
        private Model.Patient patient;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.ComboBox triage;

        public Model.Hospital InHospital
        {

            set
            {
                appointmentIn = value;
                titleLabel.Text = appointmentIn.Name;
            }
        }

        public Model.Patient LoggedInPatient
        {
            set
            {
                patient = value;
                patientLoggedIn.Text = patient.FirstName + " " + patient.LastName;
            }
        }
    }
}