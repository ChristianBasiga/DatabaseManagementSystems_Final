
CREATE FUNCTION isPatient(@hospital INT, @patientID INT) RETURNS TINYINT
BEGIN

	IF EXISTS( SELECT patientID FROM Patients
				WHERE patientID = @patientID AND hospitalID = @hospital)
		RETURN 1

	RETURN 0;
END

GO

CREATE TABLE [dbo].[InPatient]
(
	--Could've just been column but there are extra columns that InPatients have that OutPatients / general patient
	--information don't need.
	patientID INT NOT NULL,
	hospitalID INT NOT NULL,
	dateAdmitted	  DATE	 NOT NULL,
	reason VARCHAR(256) NOT NULL,
	status CHAR(100) FOREIGN KEY REFERENCES PatientStatus(status),
	CONSTRAINT VALIDPATIENT CHECK (dbo.isPatient(hospitalID,patientID) = 1),
	PRIMARY KEY(patientID,hospitalID)
)



