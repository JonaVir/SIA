use SIA

if object_id('SP_ModificarCliente') is not null
	drop procedure SP_ModificarCliente

go

create procedure SP_ModificarCliente(
@id int,
@nombre nvarchar(120),
@calle nvarchar(120),
@NumExterior nvarchar(10),
@NumInterior nvarchar(10),
@Pais int,
@Estado int,
@Municipio int,
@Colonia nvarchar(80),
@CodigoPostal nvarchar(10),
@Telefono nvarchar(12),
@Web nvarchar(120),
@ClienteAAA bit,
@Bloqueo bit
)
as

update Clientes set 
Nombre = @nombre,
Calle = @calle, 
NumExterior = @NumExterior, 
NumInterior = @NumInterior, 
Pais = @Pais, 
Estado = @Estado, 
municipio = @Municipio,
Colonia = @Colonia,
CodigoPostal = @CodigoPostal,
Telefono = @Telefono,
PaginaWeb = @Web,
ClienteAAA = @ClienteAAA, 
bloqueo = @Bloqueo where id = @id



