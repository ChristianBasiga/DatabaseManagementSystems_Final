CREATE TABLE Hospitals (

	hospitalID INT NOT NULL,
    name   CHAR (100)    NOT NULL,
    street VARCHAR (255) NOT NULL,
	state	CHAR(2)		NOT NULL,
	city	VARCHAR(255) NOT NULL,
	hiringBudget INT DEFAULT 1000, 
	payRate INT DEFAULT 80,
	ranking INT,
   PRIMARY KEY NONCLUSTERED(hospitalID),
	--PRIMARY KEY NONCLUSTERED (hospitalID),
 --nOT PRIMARY cause want to clsuter on state, not id.
	UNIQUE (name,street,city,state)
);
GO
CREATE NONCLUSTERED INDEX SpecificHospital
    ON Hospitals(hospitalID);


GO 
CREATE CLUSTERED INDEX HospitalInArea
	ON Hospitals(state,city);

GO

