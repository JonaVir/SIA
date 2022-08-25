use SIA

if OBJECT_ID('SP_ModificarReferenciaBancariaCliente') is not null
	drop database SP_ModificarReferenciaBancariaCliente

go

create procedure SP_ModificarReferenciaBancariaCliente(
@id int,
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

update ReferenciasBancariasClientes set 
Banco = @Banco,
Sucursal = @Sucursal,
cuenta = @Cuenta,
Telefono = @Telefono,
Extension = @Extension,
Celular = @Celular,
Contacto = @Contacto,
Puesto = @Puesto,
RazonSocial = @RazonSocial,
Calle = @Calle,
NumInterior = @NumInterior,
NumExterior = @NumExterior,
Colonia = @Colonia,
CodigoPostal = @CodigoPostal,
Pais = @Pais,
Estado = @Estado,
Municipio = @Municipio where id = @id and idCliente = @idCliente