use SIA

if object_id('SP_ModificarContactoCliente') is not null
	drop procedure SP_ModificarContactoCliente

go

create procedure SP_ModificarContactoCliente(
@id int,
@idcliente int,
@Nombre nvarchar(200),
@Telefono nvarchar(20) = null,
@Extension nvarchar(7) = null,
@Celular nvarchar(20),
@Correo nvarchar(200),
@Puesto nvarchar(100)
)
as

update DatosContactoClientes set 
Nombre = @Nombre,
Telefono = @Telefono,
Extension = @Extension,
Celular = @Celular,
CorreoElectronico = @Correo,
Puesto = @Puesto where id = @id and idCliente = @idcliente