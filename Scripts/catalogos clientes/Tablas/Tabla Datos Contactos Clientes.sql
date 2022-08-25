use SIA

if object_id('DatosContactoClientes') is not null begin

	drop table DatosContactoClientes

end

	create table DatosContactoClientes(
	id int not null,
	idCliente int not null,
	Nombre nvarchar(200) not null,
	Telefono nvarchar(20),
	Extension nvarchar(7),
	Celular nvarchar(20) not null,
	CorreoElectronico nvarchar(200) not null,
	Puesto nvarchar(100)
	);

	alter table DatosContactoClientes
	add primary key(idCliente,Nombre,Celular,CorreoElectronico);

	alter table DatosContactoClientes
	add foreign key (idCliente) references Clientes;