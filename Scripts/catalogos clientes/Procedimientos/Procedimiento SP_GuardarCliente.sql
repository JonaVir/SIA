use sia

if object_ID('SP_GuardarCliente') is  not null begin

	drop procedure SP_GuardarCliente;

end

go

create procedure SP_GuardarCliente(
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

insert into Clientes values (@nombre,@calle,@NumExterior,@NumInterior,@Colonia,@Municipio,@Estado,@Pais,@CodigoPostal,@Telefono,@Web,@ClienteAAA,@Bloqueo)
select max(id) from Clientes
select * from clientes
	
