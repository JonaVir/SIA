use SIA

if object_id('Clientes') is not null begin

	drop table Clientes;

end

create table Clientes(
id int identity,
Nombre nvarchar(120),
Calle nvarchar(120),
NumExterior nvarchar(10),
NumInterior nvarchar(10),
Colonia nvarchar(80),
municipio int,
Estado int,
Pais int,
CodigoPostal nvarchar(10),
Telefono nvarchar(15),
PaginaWeb nvarchar(200),
ClienteAAA bit,
bloqueo bit
) ;

alter table Clientes
add primary key (id)

alter table Clientes
add foreign key (Pais) references CatPaises

alter table Clientes
add foreign key (Estado) references CatEstados

alter table Clientes
add foreign key (municipio) references CatMunicipios


