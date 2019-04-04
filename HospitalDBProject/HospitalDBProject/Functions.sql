CREATE FUNCTION numDoctorsHospitalCanHire( @hospital INT) RETURNS INT
AS
BEGIN
	DECLARE @hospitalBudget INT;
	DECLARE @hospitalPayRate INT;
	DECLARE @newEmployeeCapacity INT;
	
	SELECT @hospitalBudget = hiringBudget, @hospitalPayRate = payRate
	FROM Hospitals
	WHERE (hospitalID = @hospital)
	
	
	--Because how many times can divide budget into Pay Rate will be how many employees can have
	SET @newEmployeeCapacity = @hospitalBudget / @hospitalPayRate;
	
	return @newEmployeeCapacity;
	
END

GO

CREATE FUNCTION [dbo].[isValidGender]
(
	@gender CHAR(1)
)
RETURNS TINYINT
AS
BEGIN
	IF  @gender = 'M' OR @gender = 'F'
		RETURN 1;
	RETURN 0;
END

GO

--Functions
CREATE FUNCTION dbo.isValidBirth (@birth Date) RETURNS TINYINT
AS
BEGIN
	--Because equal 0 if don't know
	IF (@birth > GetDate()) 
		RETURN 0;
	RETURN 1;
	
END

GO

CREATE FUNCTION existingHospital(@hospitalID INT)
RETURNS TINYINT
AS 
BEGIN
	IF EXISTS( SELECT hospitalID FROM Hospitals WHERE  hospitalID = @hospitalID)
		RETURN 1

	RETURN 0
END;

GO


CREATE FUNCTION isPastAppointment(


	@apptDate DATE
)
RETURNS TINYINT
AS
BEGIN
	IF (@apptDate < GETDATE()) 
		return 1;

	return 0;

END

GO