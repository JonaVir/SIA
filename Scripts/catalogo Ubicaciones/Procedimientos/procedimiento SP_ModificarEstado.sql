use sia

go

if object_id('SP_ModificarEstado') is not null begin

	drop procedure SP_ModificarEstado

end

go

create procedure SP_ModificarEstado(@ISOEstado nvarchar(6),@nombre nvarchar(80),@id int)
as

update CatEstados set ISOEstado = @ISOEstado, nombreEstado = @nombre where id = @id