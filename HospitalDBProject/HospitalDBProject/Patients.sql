
CREATE TABLE Patients(
	patientID	  INT			   NOT NULL,
    [email]       VARCHAR(320)     UNIQUE NOT NULL,
	pw			  VARCHAR(255)	   NOT NULL,
	primaryDoctor		  INT	   NULL,
    [firstName]       VARCHAR (150) NOT NULL,
    [lastName]        VARCHAR (150) DEFAULT 'Doe',
	birth				  DATE NULL,
	gender			  CHAR(1) NOT NULL,
	hospitalID		  INT	NOT NULL,
	
    PRIMARY KEY (patientID, hospitalID),
	CONSTRAINT ValidAge CHECK(dbo.isValidBirth(birth) = 1),
	--Replacing foriegn key with constraint cause not checking if NULL, cause if NUll then any doctor can work with them
	--FOREIGN KEY(primaryDoctor,hospitalID) REFERENCES Doctors(employeeID,employerID) ON UPDATE CASCADE

);

GO

--Triggers

CREATE TRIGGER AnonPatient ON Patients
AFTER INSERT
AS
BEGIN
	DECLARE @firstName VARCHAR(150);

	IF (SELECT firstName FROM inserted) = '' OR (SELECT lastName FROM inserted) = ''
	BEGIN

		IF (SELECT gender FROM inserted) = 'M'
			SET @firstName = 'John';
		ELSE
			SET @firstName = 'Jane';

		UPDATE Patients
		SET firstName = @firstName
		WHERE patientID = (SELECT patientID FROM inserted)
		AND hospitalID = (SELECT hospitalID FROM inserted);

	END

END

GO


