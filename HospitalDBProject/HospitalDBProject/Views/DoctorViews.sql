CREATE VIEW ExperiencedSurgeons
	AS SELECT * FROM Doctors
	WHERE specialty = 'Surgery' AND experience > 2;

	
	