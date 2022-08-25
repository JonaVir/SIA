use SIA

if object_id('SP_EliminarDatosBancariosProveedor') is not null
	drop procedure SP_EliminarDatosBancariosProveedor;

go

create procedure SP_EliminarDatosBancariosProveedor(@idProveedor int, @id int)
as

delete datosBancariosProveedor where id = @id and idProveedor = @idProveedor