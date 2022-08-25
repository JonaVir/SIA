use SIA

if object_id('SP_GuardarContactoCliente') is not null
	drop procedure SP_GuardarContactoCliente

go

create procedure SP_GuardarContactoCliente(
@idCliente int,
@Nombre nvarchar(200),
@Telefono nvarchar(20) = null,
@Extension nvarchar(7) = null,
@Celular nvarchar(20),
@Correo nvarchar(200),
@Puesto nvarchar(100)
)
as

declare @id int

select @id = isnull(max(id),0) + 1 from DatosContactoClientes where idCliente = @idCliente

insert into DatosContactoClientes values (@id,@idCliente,@Nombre,@Telefono,@Extension,@Celular,@Correo,@Puesto)

