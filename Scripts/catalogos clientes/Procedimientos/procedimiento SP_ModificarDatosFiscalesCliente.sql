use SIA

if object_id('SP_ModificarDatosFiscalesCliente') is not null
	drop procedure SP_ModificarDatosFiscalesCliente

go

create procedure SP_ModificarDatosFiscalesCliente(
@id int,
@RFC nvarchar(13),
@CURP nvarchar(18) = NULL,
@Pais int,
@Estado int,
@Municipio int,
@Colonia nvarchar(80),
@CodigoPostal nvarchar(10),
@Calle nvarchar(120),
@NumInterior nvarchar(10),
@NumExterior nvarchar(10)
)
as

update DatosFiscalesClientes set 
RFC = @RFC,
CURP = @CURP,
Pais = @Pais,
Estado = @Estado,
Municipio = @Municipio,
Colonia = @Colonia,
CodigoPostal = @CodigoPostal,
Calle = @Calle,
NumCalle = @NumExterior,
NumInterior = @NumInterior where idCliente = @id