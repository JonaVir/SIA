use SIA

if OBJECT_ID('SP_GuardarReferenciasBancariasCliente') is not null
	drop procedure SP_GuardarReferenciasBancariasCliente


go

create procedure SP_GuardarReferenciasBancariasCliente(
@idCliente int,
@Banco nvarchar(30),
@Sucursal nvarchar(30),
@Cuenta nvarchar(30),
@Telefono nvarchar(10) ,
@Extension nvarchar(7),
@Celular nvarchar(10),
@Contacto nvarchar(80),
@Puesto nvarchar(40),
@RazonSocial nvarchar(200),
@Calle nvarchar(200) ,
@NumInterior nvarchar(7),
@NumExterior nvarchar(7) ,
@Colonia nvarchar(200),
@CodigoPostal nvarchar(10),
@Pais int,
@Estado int,
@Municipio int
)
as

declare @id int

select @id = isnull(max(id),0) + 1 from ReferenciasBancariasClientes where idCliente = @idCliente

insert into ReferenciasBancariasClientes values (@id,@idCliente,@Banco,@Sucursal,@Cuenta,@Telefono,@Extension,@Celular,@Contacto,@Puesto,@RazonSocial,@Calle,@NumInterior,@NumExterior,@Colonia,@CodigoPostal,@Pais,@Estado,@Municipio)