use SIA

if object_id('SP_ReporteClientes') is not null begin

	drop procedure SP_ReporteClientes

end

go

Create procedure SP_ReporteClientes
as
select id,Nombre,telefono,concat(calle,' #',NumExterior,', Col. ',Colonia,',',municipio,',',Estado,',',Pais) as domicilio,Telefono,PaginaWeb from clientes;