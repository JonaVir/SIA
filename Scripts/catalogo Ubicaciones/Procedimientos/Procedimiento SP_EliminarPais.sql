use sia

go

if object_id('SP_EliminarPais') is not null
	drop procedure SP_EliminarPais

go

create procedure SP_EliminarPais(@Id int)
as

if @Id <> 1 and @Id <> 2 begin

	delete CatPaises where id = @Id;

end