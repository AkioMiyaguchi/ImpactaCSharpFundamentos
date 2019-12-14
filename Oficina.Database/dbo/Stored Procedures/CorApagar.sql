CREATE PROC CorApagar
	@id int
AS
DELETE Cor
WHERE Id = @id