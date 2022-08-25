use sia

if object_id('DatosBancariosProveedor') is not null
	drop table DatosBancariosProveedor;

go

create table DatosBancariosProveedor(
id int,
idProveedor int not null,
Banco nvarchar(80),
Clabe nvarchar(80),
Cuenta nvarchar(120),
sucursal nvarchar(80),
titular nvarchar(120),
predeterminada bit
)