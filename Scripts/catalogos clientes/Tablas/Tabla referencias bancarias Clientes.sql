use SIA

if OBJECT_ID('ReferenciasBancariasClientes') is not null begin
	
	drop table ReferenciasBancariasClientes

end

	create table ReferenciasBancariasClientes(
	id int not null,
	idCliente int,
	Banco nvarchar(30),
	Sucursal nvarchar(30),
	Cuenta nvarchar(30),
	Telefono nvarchar(10) ,
	Extension nvarchar(7),
	Celular nvarchar(10),
	Contacto nvarchar(80),
	Puesto nvarchar(40),
	RazonSocial nvarchar(200),
	Calle nvarchar(200) ,
	NumInterior nvarchar(7),
	NumExterior nvarchar(7) ,
	Colonia nvarchar(200),
	CodigoPostal nvarchar(10),
	Pais int,
	Estado int,
	Municipio int,
	);

	alter table ReferenciasBancariasClientes
	add foreign key (idCliente) references clientes

	alter table ReferenciasBancariasClientes
	add foreign key (pais) references CatPaises

	alter table ReferenciasBancariasClientes
	add foreign key (Estado) references CatEstados

	alter table ReferenciasBancariasClientes
	add foreign key (Municipio) references CatMunicipios
