use sia
go

IF OBJECT_ID('SP_ModificarPais') is not null begin

	drop procedure SP_ModificarEstado

end

go

create procedure SP_ModificarPais(@id int,@ISOPais char(3),@Nombre nvarchar(80))
as

update CatPaises set ISOPais = @ISOPais, nombrePais = @Nombre where id = @id