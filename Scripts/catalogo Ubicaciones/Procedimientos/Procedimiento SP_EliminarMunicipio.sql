use sia

if object_id('SP_EliminarMunicipio') is not null
	drop procedure SP_EliminarMunicipio

go

create procedure SP_EliminarMunicipio(@id int)
as

if @id  > 125 begin

	delete CatMunicipios where id = @id

end
