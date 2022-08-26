use SIA

if OBJECT_ID('SP_EliminarContactoProveedor') is not null
	drop procedure SP_EliminarContactoProveedor;

go

create procedure SP_EliminarContactoProveedor(@id int,@idProveedor int)
as

delete ContactosProveedores where IdProveedor = @idProveedor and id = @id