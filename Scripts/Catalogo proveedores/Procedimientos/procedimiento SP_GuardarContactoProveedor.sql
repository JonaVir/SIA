use SIA

if object_id('SP_GuardarContactoProveedor') is not null
	drop procedure SP_GuardarContactoProveedor;

go

create procedure SP_GuardarContactoProveedor(
@idProveedor int,
@NombreCompleto nvarchar(85),
@Telefono nvarchar(15),
@Extension nvarchar(5),
@Celular nvarchar(15),
@Correo nvarchar(120),
@puesto nvarchar(80)
)
as

declare @id int

select @id = count(*) + 1 from ContactosProveedores where IdProveedor = @idProveedor

insert into ContactosProveedores values (@id,@idProveedor,@NombreCompleto,@Telefono,@Extension,@Celular,@Correo,@puesto)