USE SIA

if object_id('SP_GuardarDatosFiscalesClientes') is not null
	drop procedure SP_GuardarDatosFiscalesClientes

go

create procedure SP_GuardarDatosFiscalesClientes(
@id int,
@RFC nvarchar(13),
@CURP nvarchar(18) = null,
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

insert into DatosFiscalesClientes values(@id,@Calle,@NumExterior,@NumInterior,@Colonia,@Municipio,@Estado,@Pais,@CodigoPostal,@RFC,@CURP)
