use SIA

If object_id('SP_GuardarProveedor') is not null begin

	drop procedure SP_GuardarProveedor

end

go

create procedure SP_GuardarProveedor(
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
@CURP nvarchar(18)
)
as

insert into Proveedores values (@Nombre,@calle,@NumeroInterior,@NumeroExterior,@Colonia,@Municipio,@Estado,@Pais,@CodigoPostal,@Telefono,@Web,@rfc,@CURP,1)

select max(id) from Proveedores