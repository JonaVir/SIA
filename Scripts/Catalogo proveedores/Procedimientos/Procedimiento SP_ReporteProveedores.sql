use SIA

if object_id('SP_ReporteProveedores') is not null
	drop procedure SP_ReporteProveedores;

go

create procedure SP_ReporteProveedores
as

select pr.id,Nombre,Telefono,concat('Calle ',calle,' #',NumeroExterior,', Col. ',Colonia,',',m.nombreMunicipio,',',e.nombreEstado,',',P.nombrePais) as domicilio from Proveedores as pr
left join CatPaises as p on pr.Pais = p.id
left join CatEstados as e on pr.Estado = e.id
left join CatMunicipios as m on pr.Municipio = m.id