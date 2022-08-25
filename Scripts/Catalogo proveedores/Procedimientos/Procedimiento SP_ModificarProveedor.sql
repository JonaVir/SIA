use SIA

if OBJECT_ID('SP_ModificarProveedor') is not null
	drop procedure SP_ModificarProveedor;

go

create procedure SP_ModificarProveedor(
@Id int,
@Nombre nvarchar(200),
@Calle nvarchar(200),
@NumeroInterior nvarchar(10),
@NumeroExterior nvarchar(10),
@Colonia nvarchar(200),
@Municipio int,
@Estado int,
@Pais int,
@CodigoPostal nvarchar(6),
@Telefono nvarchar(14),
@Web nvarchar(200),
@RFC nvarchar(13),
@CURP nvarchar(18),
@activo bit
)
as

update Proveedores set Nombre = @Nombre, Calle = @Calle, NumeroInterior = @NumeroInterior, 
NumeroExterior = @NumeroExterior, Colonia = @Colonia, Municipio= @Municipio, Estado = @Estado, Pais = @Pais, CodigoPostal = @CodigoPostal,
Telefono = @Telefono, Web = @Web, RFC = @RFC, CURP = @CURP, Activo = @activo where id = @Id