use SIA

if object_id('SP_ReporteClientes') is not null begin

	drop procedure SP_ReporteClientes

end

go

Create procedure SP_ReporteClientes
as
select c.id,Nombre,telefono,concat(calle,' #',NumExterior,', Col. ',Colonia,',',m.nombreMunicipio,',',e.nombreEstado,',',P.nombrePais) as domicilio,PaginaWeb from clientes as c
left join CatPaises as p on p.id = c.Pais
left join CatEstados as e on e.id = c.Estado
left join CatMunicipios as m on m.id = c.municipio;