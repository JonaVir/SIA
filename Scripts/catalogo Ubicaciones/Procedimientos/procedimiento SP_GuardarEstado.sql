use sia

go

if OBJECT_ID('SP_GuardarEstado') is not null begin

	drop procedure SP_GuardarEstado

end

go

create procedure SP_GuardarEstado(@idPais int,@ISO char(6),@Nombre nvarchar(80))
as

insert into CatEstados values (@idPais,@ISO,@Nombre)