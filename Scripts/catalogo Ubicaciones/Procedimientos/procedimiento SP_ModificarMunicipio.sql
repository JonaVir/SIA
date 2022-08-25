use sia

go

if object_id('SP_ModificarMunicipio') is not null begin

	drop procedure SP_ModificarMunicipio

end

go

create procedure SP_ModificarMunicipio(
@Id int,
@clave nvarchar(4),
@nombre nvarchar(80))
as
update CatMunicipios set clave = @clave, nombreMunicipio = @nombre where id = @Id