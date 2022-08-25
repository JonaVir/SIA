use SIA

if OBJECT_ID('SP_ObtenerReferenciasBancariasCliente') is not null
	drop procedure SP_ObtenerReferenciasBancariasCliente

go

create procedure SP_ObtenerReferenciasBancariasCliente(@idCliente int)
as

select b.idCliente as 'No.',Banco,RazonSocial as 'Razon social',Sucursal,Cuenta,Contacto,Puesto,Telefono,Extension,Celular,p.nombrePais as pais,e.nombreEstado as estado,m.nombreMunicipio as municipio,Colonia,CodigoPostal as 'Codigo postal',Calle,NumExterior as 'No. Exterior',NumInterior as 'No. interior'from ReferenciasBancariasClientes as b
left join CatPaises as p on b.Pais = p.id
left join CatEstados as e on b.Estado = e.id 
left join CatMunicipios as m on b.municipio = m.id where idcliente = @idCliente
