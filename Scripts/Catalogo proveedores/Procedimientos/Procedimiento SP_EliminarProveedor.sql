use SIA

if object_id('SP_EliminarProveedor') is not null
	drop procedure SP_EliminarProveedor;

go

create procedure SP_EliminarProveedor(@id int)
as

delete Proveedores where id = @id