CREATE TABLE Appointments (

	patientID	INT			  NOT NULL,
    [apptTime]  TIME (7)      NOT NULL,
    [apptDate]  DATE          NOT NULL,
	[hospitalID]	INT		  NOT NULL,
    importance    CHAR(100)   FOREIGN KEY REFERENCES Triage(emergencyLevel),
	reason		  CHAR(100) FOREIGN KEY REFERENCES Specialties(name),	

    PRIMARY KEY NONCLUSTERED (hospitalID, [apptTime], [apptDate]),
	FOREIGN KEY(hospitalID) REFERENCES Hospitals(hospitalID),
	CONSTRAINT Registered CHECK( dbo.isPatient(hospitalID,patientID) = 1),   
	CONSTRAINT NotExpiredAppointment CHECK( dbo.isPastAppointment(apptDate) = 0),
);


GO
--Depending on who we have available, will want to check this often
--either this or importance will be clustered. Though it makes sense for priority to be
--be grouped, think reason is more importance to be clustered.
CREATE CLUSTERED INDEX ReasonForVisit
	ON Appointments(reason)

GO

CREATE NONCLUSTERED INDEX Priority
	ON Appointments(importance);

GO
