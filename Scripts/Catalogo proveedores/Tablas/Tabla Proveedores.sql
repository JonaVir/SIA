use SIA

if object_id('Proveedores') is not null
	drop table Proveedores

create table Proveedores(
id int identity primary key,
Nombre nvarchar(200) NOT NULL,
Calle nvarchar(200),
NumeroInterior nvarchar(10),
NumeroExterior nvarchar(10),
Colonia nvarchar(200),
Municipio int,
Estado int,
Pais int,
CodigoPostal nvarchar(6),
Telefono nvarchar(14),
Web nvarchar(200),
RFC nvarchar(13),
CURP nvarchar(18),
Activo bit
)

alter table proveedores
add foreign key (Pais) references catPaises

alter table Proveedores
add foreign key (Estado) references catEstados

alter table Proveedores
add foreign key (Municipio) references catMunicipios

