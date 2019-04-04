namespace HospitalSystem
{
    partial class Homepage
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
            this.hospitalGroup = new System.Windows.Forms.GroupBox();
            this.hospitalPanel = new System.Windows.Forms.Panel();
            this.selectedHospitalName = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.isHiring = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.appointmentButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.filterGroup = new System.Windows.Forms.GroupBox();
            this.clearFilterBUtton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cities = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.states = new System.Windows.Forms.ComboBox();
            this.loggedInLabel = new System.Windows.Forms.Label();
            this.loggedInEmail = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.showAppointments = new System.Windows.Forms.Button();
            this.hospitalGroup.SuspendLayout();
            this.filterGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // hospitalGroup
            // 
            this.hospitalGroup.Controls.Add(this.hospitalPanel);
            this.hospitalGroup.Location = new System.Drawing.Point(183, 35);
            this.hospitalGroup.Name = "hospitalGroup";
            this.hospitalGroup.Size = new System.Drawing.Size(257, 287);
            this.hospitalGroup.TabIndex = 2;
            this.hospitalGroup.TabStop = false;
            this.hospitalGroup.Text = "Hopitals";
            // 
            // hospitalPanel
            // 
            this.hospitalPanel.AutoScroll = true;
            this.hospitalPanel.AutoSize = true;
            this.hospitalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hospitalPanel.Location = new System.Drawing.Point(3, 18);
            this.hospitalPanel.Name = "hospitalPanel";
            this.hospitalPanel.Size = new System.Drawing.Size(251, 266);
            this.hospitalPanel.TabIndex = 0;
            // 
            // selectedHospitalName
            // 
            this.selectedHospitalName.AutoSize = true;
            this.selectedHospitalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectedHospitalName.Location = new System.Drawing.Point(458, 102);
            this.selectedHospitalName.Name = "selectedHospitalName";
            this.selectedHospitalName.Size = new System.Drawing.Size(181, 25);
            this.selectedHospitalName.TabIndex = 3;
            this.selectedHospitalName.Text = "insertHospitalName";
            // 
            // street
            // 
            this.street.AutoSize = true;
            this.street.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.street.Location = new System.Drawing.Point(461, 143);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(51, 18);
            this.street.TabIndex = 5;
            this.street.Text = "Street:";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.city.Location = new System.Drawing.Point(461, 176);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(37, 18);
            this.city.TabIndex = 6;
            this.city.Text = "City:";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.state.Location = new System.Drawing.Point(616, 176);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(46, 18);
            this.state.TabIndex = 7;
            this.state.Text = "State:";
            // 
            // isHiring
            // 
            this.isHiring.AutoSize = true;
            this.isHiring.Location = new System.Drawing.Point(512, 214);
            this.isHiring.Name = "isHiring";
            this.isHiring.Size = new System.Drawing.Size(32, 17);
            this.isHiring.TabIndex = 8;
            this.isHiring.Text = "Yes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hiring:";
            // 
            // appointmentButton
            // 
            this.appointmentButton.Location = new System.Drawing.Point(463, 242);
            this.appointmentButton.Name = "appointmentButton";
            this.appointmentButton.Size = new System.Drawing.Size(207, 49);
            this.appointmentButton.TabIndex = 10;
            this.appointmentButton.Text = "Make Appointment";
            this.appointmentButton.UseVisualStyleBackColor = true;
            this.appointmentButton.Click += new System.EventHandler(this.appointmentButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(463, 297);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(88, 37);
            this.registerButton.TabIndex = 11;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(564, 297);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(106, 37);
            this.loginButton.TabIndex = 12;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // filterGroup
            // 
            this.filterGroup.Controls.Add(this.clearFilterBUtton);
            this.filterGroup.Controls.Add(this.filterButton);
            this.filterGroup.Controls.Add(this.label4);
            this.filterGroup.Controls.Add(this.cities);
            this.filterGroup.Controls.Add(this.label3);
            this.filterGroup.Controls.Add(this.states);
            this.filterGroup.Location = new System.Drawing.Point(-2, 35);
            this.filterGroup.Name = "filterGroup";
            this.filterGroup.Size = new System.Drawing.Size(179, 336);
            this.filterGroup.TabIndex = 14;
            this.filterGroup.TabStop = false;
            this.filterGroup.Text = "Filter";
            // 
            // clearFilterBUtton
            // 
            this.clearFilterBUtton.Location = new System.Drawing.Point(15, 253);
            this.clearFilterBUtton.Name = "clearFilterBUtton";
            this.clearFilterBUtton.Size = new System.Drawing.Size(121, 34);
            this.clearFilterBUtton.TabIndex = 10;
            this.clearFilterBUtton.Text = "Clear Filter";
            this.clearFilterBUtton.UseVisualStyleBackColor = true;
            this.clearFilterBUtton.Click += new System.EventHandler(this.clearFilterBUtton_Click);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(15, 213);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(121, 34);
            this.filterButton.TabIndex = 9;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "City";
            // 
            // cities
            // 
            this.cities.FormattingEnabled = true;
            this.cities.Location = new System.Drawing.Point(15, 99);
            this.cities.Name = "cities";
            this.cities.Size = new System.Drawing.Size(121, 24);
            this.cities.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "State";
            // 
            // states
            // 
            this.states.FormattingEnabled = true;
            this.states.Location = new System.Drawing.Point(15, 49);
            this.states.Name = "states";
            this.states.Size = new System.Drawing.Size(121, 24);
            this.states.TabIndex = 3;
            // 
            // loggedInLabel
            // 
            this.loggedInLabel.AutoSize = true;
            this.loggedInLabel.Location = new System.Drawing.Point(463, 10);
            this.loggedInLabel.Name = "loggedInLabel";
            this.loggedInLabel.Size = new System.Drawing.Size(94, 17);
            this.loggedInLabel.TabIndex = 17;
            this.loggedInLabel.Text = "Logged in as:";
            this.loggedInLabel.Visible = false;
            // 
            // loggedInEmail
            // 
            this.loggedInEmail.AutoSize = true;
            this.loggedInEmail.Location = new System.Drawing.Point(564, 13);
            this.loggedInEmail.Name = "loggedInEmail";
            this.loggedInEmail.Size = new System.Drawing.Size(135, 17);
            this.loggedInEmail.TabIndex = 18;
            this.loggedInEmail.Text = "Patient/Doctor email";
            this.loggedInEmail.Visible = false;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(463, 297);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(207, 37);
            this.logoutButton.TabIndex = 19;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Visible = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // showAppointments
            // 
            this.showAppointments.Location = new System.Drawing.Point(464, 341);
            this.showAppointments.Name = "showAppointments";
            this.showAppointments.Size = new System.Drawing.Size(206, 37);
            this.showAppointments.TabIndex = 20;
            this.showAppointments.Text = "See Your Appointments";
            this.showAppointments.UseVisualStyleBackColor = true;
            this.showAppointments.Click += new System.EventHandler(this.showAppointments_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 408);
            this.Controls.Add(this.showAppointments);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.loggedInEmail);
            this.Controls.Add(this.loggedInLabel);
            this.Controls.Add(this.filterGroup);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.appointmentButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isHiring);
            this.Controls.Add(this.state);
            this.Controls.Add(this.city);
            this.Controls.Add(this.street);
            this.Controls.Add(this.selectedHospitalName);
            this.Controls.Add(this.hospitalGroup);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.hospitalGroup.ResumeLayout(false);
            this.hospitalGroup.PerformLayout();
            this.filterGroup.ResumeLayout(false);
            this.filterGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox hospitalGroup;
        private System.Windows.Forms.Panel hospitalPanel;
        private System.Windows.Forms.Label selectedHospitalName;
        private System.Windows.Forms.Label street;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label isHiring;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button appointmentButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.GroupBox filterGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox states;
        private System.Windows.Forms.Label loggedInLabel;
        private System.Windows.Forms.Label loggedInEmail;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ComboBox cities;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearFilterBUtton;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button showAppointments;
    }
}