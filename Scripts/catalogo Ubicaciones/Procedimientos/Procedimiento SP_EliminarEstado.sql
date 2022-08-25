use SIA

go

if object_id('SP_EliminarEstado') is not null
	drop procedure SP_EliminarEstado

go

create procedure SP_EliminarEstado(@Id int)
as

if @Id > 32 begin

	delete CatEstados where id = @Id

end


	