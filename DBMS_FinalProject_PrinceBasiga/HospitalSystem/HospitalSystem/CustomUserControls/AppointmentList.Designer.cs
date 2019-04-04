namespace HospitalSystem.CustomUserControls
{
    partial class AppointmentList
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
            this.AppointmentsTable = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // AppointmentsTable
            // 
            this.AppointmentsTable.ColumnCount = 4;
            this.AppointmentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AppointmentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AppointmentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.AppointmentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.AppointmentsTable.Location = new System.Drawing.Point(86, 89);
            this.AppointmentsTable.Name = "AppointmentsTable";
            this.AppointmentsTable.RowCount = 3;
            this.AppointmentsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.14286F));
            this.AppointmentsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.85714F));
            this.AppointmentsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.AppointmentsTable.Size = new System.Drawing.Size(449, 115);
            this.AppointmentsTable.TabIndex = 0;
            // 
            // AppointmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 253);
            this.Controls.Add(this.AppointmentsTable);
            this.Name = "AppointmentList";
            this.Text = "AppointmentList";
            this.Load += new System.EventHandler(this.AppointmentList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AppointmentsTable;
    }
}