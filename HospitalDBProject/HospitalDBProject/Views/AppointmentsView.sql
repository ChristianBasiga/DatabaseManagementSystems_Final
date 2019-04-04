--Related to Appointments

CREATE VIEW HighPriorityAppointments
	AS
	SELECT * FROM Appointments
	WHERE importance = 1 OR importance = 2 OR importance = 3;
	
GO

CREATE VIEW LowPriorityAppointments
	AS 
	SELECT * FROM Appointments
	WHERE importance = 4 OR importance = 5;	

GO

