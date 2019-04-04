
GO
CREATE TABLE Doctors(

	--Both employeeID and employerID are redundant information but fuck it.
    [employeeID] INT           NOT NULL,
	employerID 	 INT		   NOT NULL,
	--experience is how long doctor has been at this specialty, if specialty null then 0 or if change specialty
	experience   SMALLINT	   DEFAULT 0,
    [specialty]  CHAR (100)    NULL,
    PRIMARY KEY NONCLUSTERED (employeeID,employerID),
	FOREIGN KEY ([specialty]) REFERENCES Specialties([name]) ON DELETE SET NULL ON UPDATE SET NULL,	
	--Using this constraint instead of foreign key but to get the same effect.
	CONSTRAINT EmployedDoctor CHECK(dbo.isEmployedDoctor(employeeID,employerID) = 1)
);

--Functions
GO
CREATE FUNCTION [dbo].[isEmployedDoctor]
(
	@doctorID int,
	@employerID int
)
RETURNS INT
AS
BEGIN
	
	IF EXISTS(
	
		SELECT * FROM Employees
		where employeeID = @doctorID AND Employees.employerID = @employerID
		
	) 
		return 1;
	return 0;
END


--Indexes
GO
--I'd prefer clustered on specialty then hospital, cause the application will be looking for specific Doctors
--good at needed operation. Experience is preference but cluster not needed.
CREATE CLUSTERED INDEX [IDX_Specialty]
    ON Doctors(specialty);

GO

CREATE NONCLUSTERED INDEX SpecificEmployer
	ON Doctors(employerID);
	
GO

