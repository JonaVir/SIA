use SIA

if object_id('SP_ModificarContactoProveedor') is not null
	drop procedure SP_ModificarContactoProveedor;

go

create procedure SP_ModificarContactoProveedor(
@id int,
@idProveedor int,
@NombreCompleto nvarchar(85),
@Telefono nvarchar(15),
@Extension nvarchar(5),
@Celular nvarchar(15),
@Correo nvarchar(120),
@puesto nvarchar(80)
)

as

update ContactosProveedores set Nombre = @NombreCompleto, Telefono = @Telefono, Extension = @Extension, Celular = @Celular, Correo = @Correo, Puesto = @puesto where IdProveedor = @idProveedor and id = @id