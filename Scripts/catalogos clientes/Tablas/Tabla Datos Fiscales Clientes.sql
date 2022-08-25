use SIA

if object_id('DatosFiscalesClientes') is not null begin
	
	drop table DatosFiscalesClientes

end

	create table DatosFiscalesClientes(
	idCliente int,
	Calle nvarchar(120),
	NumCalle nvarchar(10),
	NumInterior nvarchar(10),
	Colonia nvarchar(80),
	Municipio int,
	Estado int,
	Pais int,
	CodigoPostal nvarchar(10),
	RFC nvarchar(13),
	CURP nvarchar(18)
	)

	alter table DatosFiscalesClientes
	add foreign key (idCliente) references clientes
