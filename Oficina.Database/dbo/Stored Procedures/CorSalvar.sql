CREATE PROC CorSalvar
	@nome nvarchar(200)
as
INSERT Cor (Nome)
OUTPUT inserted.Id
VALUES (@nome)