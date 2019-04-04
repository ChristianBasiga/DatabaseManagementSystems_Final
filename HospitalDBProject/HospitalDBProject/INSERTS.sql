/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/




INSERT INTO Triage(emergencyLevel)
VALUES
	('RESUSCITATION'),
	('EMERGENT'),
	('URGENT'),
	('LESS_URGENT'),
	('NON_URGENT');
	
GO

INSERT INTO Specialties(name)
VALUES
	('Surgery'),
	('Chiropractor')
GO

INSERT INTO Hospitals(hospitalID,name,street,city,state,hiringBudget,payRate,ranking)
VALUES
	(2,'Medicare','sjStreet','San Jose','CA',1200,80,5),
	(3,'SuperHospital','gopher','Los Angeles','CA',1500,23,1),
	(4,'SuperDuper','bleh','SomeCity','NV',1500,100,2)
	

