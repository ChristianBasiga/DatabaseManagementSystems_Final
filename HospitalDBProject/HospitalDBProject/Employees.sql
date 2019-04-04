

CREATE TABLE Employees (
	--Will keep ID cause more efficient to compare those than strings and
	--Easier to see if what they tried to login with was correct if email as key, but just having email
	--unique will help with that, don't need to be key.
    employeeID      INT           NOT NULL,
	--For Employees, so that doctors can log in to see their patients and everything
	email			VARCHAR(320)  UNIQUE NOT NULL,
	pw				VARCHAR(255)  NOT NULL,
    firstName       VARCHAR (255) NOT NULL,
    lastName        VARCHAR (255) NOT NULL,
	gender 			CHAR(1)		  NOT NULL,
    employerID 		INT			  NOT NULL,
    
    PRIMARY KEY (employerID,employeeID),
    FOREIGN KEY (employerID) REFERENCES Hospitals(hospitalID) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT VALIDGENDER CHECK(dbo.isValidGender(gender) = 1)
);

GO





