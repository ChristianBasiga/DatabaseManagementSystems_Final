namespace HospitalSystem.CustomUserControls
{
    partial class SuccessfulTransactionView
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
            this.redoButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.transactionDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // redoButton
            // 
            this.redoButton.AutoSize = true;
            this.redoButton.Location = new System.Drawing.Point(200, 230);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(165, 27);
            this.redoButton.TabIndex = 0;
            this.redoButton.Text = "button1";
            this.redoButton.UseVisualStyleBackColor = true;
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.AutoSize = true;
            this.homeButton.Location = new System.Drawing.Point(214, 263);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(122, 27);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Done";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // transactionDescription
            // 
            this.transactionDescription.Location = new System.Drawing.Point(42, 56);
            this.transactionDescription.Multiline = true;
            this.transactionDescription.Name = "transactionDescription";
            this.transactionDescription.Size = new System.Drawing.Size(482, 145);
            this.transactionDescription.TabIndex = 2;
            // 
            // SuccessfulTransactionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 310);
            this.Controls.Add(this.transactionDescription);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.redoButton);
            this.Name = "SuccessfulTransactionView";
            this.Load += new System.EventHandler(this.SuccessfulTransactionView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button redoButton;
        public System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.TextBox transactionDescription;
    }
}
