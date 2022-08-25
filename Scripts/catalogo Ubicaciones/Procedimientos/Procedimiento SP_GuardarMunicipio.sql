use SIA

go

if object_id('SP_GuardarMunicipio') is not null begin

	drop procedure SP_GuardarMunicipio

end

go

create procedure SP_GuardarMunicipio(
@IdPais int,
@IdEstado int,
@clave nvarchar(4),
@nombre nvarchar(80))
as

insert into CatMunicipios values (@IdPais,@IdEstado,@clave,@nombre)