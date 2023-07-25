USE dbms
GO

BEGIN TRANSACTION
	SELECT * FROM dbms.dbo.donors 
	WHERE birth_date BETWEEN '01-JAN-1980' AND '01-JAN-1986'

	WAITFOR DELAY '00:00:05'

	SELECT * FROM dbms.dbo.donors  
	WHERE birth_date BETWEEN '01-JAN-1980' AND '01-JAN-1986'
COMMIT TRANSACTION