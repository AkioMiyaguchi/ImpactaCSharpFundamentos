CREATE PROC CorAtualizar
	@id int,
	@nome nvarchar(200)
AS
UPDATE Cor
SET Nome = @nome
WHERE Id = @id