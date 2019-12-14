CREATE PROC CorLer
	@id int
as
Select id, nome from Cor where Id = @id