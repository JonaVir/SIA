use sia

if OBJECT_ID('SP_ObtenerDatosFiscalesCliente') is not null 
	drop procedure SP_ObtenerDatosFiscalesCliente

go

create procedure SP_ObtenerDatosFiscalesCliente(@idCliente int)
as


select f.Calle,f.NumCalle as 'Numero Exterior',f.NumInterior as 'Numero Interior',p.nombrePais as pais,e.nombreEstado as Estado,m.nombreMunicipio as municipio,f.Colonia,f.CodigoPostal as 'Codigo Postal',f.RFC,f.CURP from DatosFiscalesClientes as f left join CatPaises as p on f.Pais = p.id 
left join CatEstados as e on e.id = f.Estado 
left join CatMunicipios as m on m.id = f.Municipio where idCliente = @idCliente

