use SIA

if object_id('ContactosProveedores') is not null
	drop table ContactosProveedores

create table ContactosProveedores(
id int,
IdProveedor int,
Nombre nvarchar(200) NOT NULL,
Telefono nvarchar(14),
Extension nvarchar(7),
Celular nvarchar(20),
Correo nvarchar(80),
Puesto nvarchar(80),
primary key(IdProveedor,Nombre,Celular)
)

alter table ContactosProveedores
add foreign key (IdProveedor) references Proveedores
