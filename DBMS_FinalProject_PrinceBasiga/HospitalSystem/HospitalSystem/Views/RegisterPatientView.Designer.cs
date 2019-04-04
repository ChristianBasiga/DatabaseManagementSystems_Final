using System.Windows.Forms;

namespace HospitalSystem
{
    partial class RegisterPatientView : Interfaces.IHospitalInteractor
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
            this.emailLabel = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.hospitalName = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.errorMessage = new System.Windows.Forms.Label();
            this.generalRegisterControls = new HospitalSystem.RegisterControls();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(325, 246);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(373, 246);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(212, 22);
            this.email.TabIndex = 2;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(607, 355);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(130, 30);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(607, 407);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(130, 30);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // hospitalName
            // 
            this.hospitalName.AutoSize = true;
            this.hospitalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.hospitalName.Location = new System.Drawing.Point(88, 9);
            this.hospitalName.Name = "hospitalName";
            this.hospitalName.Size = new System.Drawing.Size(235, 29);
            this.hospitalName.TabIndex = 5;
            this.hospitalName.Text = "InsertHospitalName";
            this.hospitalName.Click += new System.EventHandler(this.hospitalName_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(41, 241);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(116, 241);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(190, 22);
            this.password.TabIndex = 7;
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(93, 299);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 17);
            this.errorMessage.TabIndex = 8;
            // 
            // generalRegisterControls
            // 
            this.generalRegisterControls.Location = new System.Drawing.Point(27, 82);
            this.generalRegisterControls.Name = "generalRegisterControls";
            this.generalRegisterControls.Size = new System.Drawing.Size(727, 176);
            this.generalRegisterControls.TabIndex = 0;
            this.generalRegisterControls.Load += new System.EventHandler(this.generalRegisterControls_Load);
            // 
            // RegisterPatientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 449);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.hospitalName);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.email);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.generalRegisterControls);
            this.Name = "RegisterPatientView";
            this.Text = "RegisterView";
            this.Load += new System.EventHandler(this.RegisterPatientView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RegisterControls generalRegisterControls;
        private Label emailLabel;
        private TextBox email;
        private Button confirmButton;
        private Button cancelButton;
        private Label hospitalName;
        private Model.Hospital hospital;
        private Label passwordLabel;
        private TextBox password;
        private Label errorMessage;

        public Model.Hospital InHospital
        {
            set
            {
                hospital = value;
                hospitalName.Text = hospital.Name;
            }
          
        }
    }
}