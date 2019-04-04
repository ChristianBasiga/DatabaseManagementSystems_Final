CREATE PROCEDURE AppointmentMet @hospitalID INT, @apptTime TIME, @apptDate DATE
--CREATE TRIGGER UpdateMet ON Appointments
--AFTER UPDATE
AS
BEGIN
	--I could just make this query in application but it's done enough that should be procedure in system.
	DELETE FROM  Appointments
	WHERE hospitalID = @hospitalID AND apptDate = @apptDate AND apptTime = @apptTime;
		
END
		
GO