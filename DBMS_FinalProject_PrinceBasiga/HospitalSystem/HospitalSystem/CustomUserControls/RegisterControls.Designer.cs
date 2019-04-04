using System;
using System.Windows.Forms;
namespace HospitalSystem
{
    partial class RegisterControls : UserControl
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
        

        #region Component Designer generated code
        public RegisterControls()
        {
           
            InitializeComponent();
        }
    
    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
        {
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.GroupBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(20, 27);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(306, 32);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(103, 27);
            this.firstName.MaxLength = 150;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(179, 22);
            this.firstName.TabIndex = 2;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(389, 29);
            this.lastName.MaxLength = 150;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(209, 22);
            this.lastName.TabIndex = 3;
            // 
            // gender
            // 
            this.gender.Controls.Add(this.female);
            this.gender.Controls.Add(this.male);
            this.gender.Location = new System.Drawing.Point(23, 74);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(141, 47);
            this.gender.TabIndex = 4;
            this.gender.TabStop = false;
            this.gender.Text = "Gender";
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(72, 22);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(75, 21);
            this.female.TabIndex = 1;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(7, 22);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(59, 21);
            this.male.TabIndex = 0;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(389, 104);
            this.birthDate.MaxDate = new System.DateTime(2017, 12, 3, 0, 0, 0, 0);
            this.birthDate.MinDate = new System.DateTime(1917, 12, 3, 0, 0, 0, 0);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(243, 22);
            this.birthDate.TabIndex = 5;
            this.birthDate.Value = new System.DateTime(2017, 12, 3, 0, 0, 0, 0);
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(295, 109);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(87, 17);
            this.birthDateLabel.TabIndex = 6;
            this.birthDateLabel.Text = "Date of Birth";
            // 
            // RegisterControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "RegisterControls";
            this.Size = new System.Drawing.Size(725, 294);
            this.Load += new System.EventHandler(this.RegisterControls_Load);
            this.gender.ResumeLayout(false);
            this.gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private TextBox firstName;
        private TextBox lastName;
        private GroupBox gender;
        private RadioButton female;
        private RadioButton male;
        private DateTimePicker birthDate;
        private Label birthDateLabel;


        public void clearForm()
        {
            firstName.Text = "";
            lastName.Text = "";
            foreach (RadioButton button in gender.Controls)
            {
                button.Checked = false;
            }
            birthDate.Value = DateTime.Today;

        }


        public string FirstName
        {

            get
            {
                return firstName.Text;
            }
        }

        public string LastName
        {
            get
            {
                return lastName.Text;
            }
        }
         
        //This is bad, yes need password, but think I'ma just generate one for Employees, but patients get to choose, cause this is bad. Then since in Higher level, only it needs it
      
        public string Gender
        {
            get
            {
                string chosenGender = "";
                foreach (Control button in gender.Controls)
                {
                    RadioButton rb = button as RadioButton;
                    if (rb.Checked)
                    {
                        chosenGender = rb.Name;
                        break;
                    }
                }

                return chosenGender;
            }
        }

        public DateTime DateofBirth
        {
            get
            {
                return birthDate.Value;
            }
        }

      
    }


}
    