IF NOT EXISTS (SELECT 1 FROM dbo.[User])
BEGIN
	INSERT INTO dbo.[User] (FirstName,LastName)
	VALUES ('Akash', 'Khan'),
	('Mehedi', 'Hasam')

END
 