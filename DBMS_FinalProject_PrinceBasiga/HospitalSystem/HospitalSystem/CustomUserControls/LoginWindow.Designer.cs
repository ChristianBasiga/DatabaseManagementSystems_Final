namespace HospitalSystem.CustomUserControls
{
    partial class LoginWindow: Interfaces.IHospitalInteractor
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

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.email = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.HospitalLabel = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(94, 63);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(126, 22);
            this.email.TabIndex = 0;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(28, 65);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(271, 63);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(357, 61);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(126, 22);
            this.password.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(380, 121);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(471, 121);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // HospitalLabel
            // 
            this.HospitalLabel.AutoSize = true;
            this.HospitalLabel.Location = new System.Drawing.Point(31, 13);
            this.HospitalLabel.Name = "HospitalLabel";
            this.HospitalLabel.Size = new System.Drawing.Size(135, 17);
            this.HospitalLabel.TabIndex = 7;
            this.HospitalLabel.Text = "HospitalLoggingINto";
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Location = new System.Drawing.Point(28, 121);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(127, 17);
            this.errorMessage.TabIndex = 8;
            this.errorMessage.Text = "errorMessageHere";
            this.errorMessage.Visible = false;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 172);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.HospitalLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.email);
            this.Name = "LoginWindow";
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox password;
        public System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button cancelButton;
        private Model.Hospital hospital;
        private System.Windows.Forms.Label HospitalLabel;
        private System.Windows.Forms.Label errorMessage;

        public Model.Hospital InHospital
        {
            set
            {
                hospital = value;
                HospitalLabel.Text = hospital.Name;
            }
        }
    }
}
