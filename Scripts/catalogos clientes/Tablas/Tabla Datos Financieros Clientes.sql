use SIA

if OBJECT_ID('DatosFinacierosClientes')is not null begin
	
	drop table DatosFinacierosClientes

end

create table DatosFinacierosClientes(
idCliente int primary key not null,
LimitedeCredito money,
BloqueadoContabilidad bit,
Moneda nvarchar(3),
);

alter table DatosFinacierosClientes
add foreign key (idCliente) references Clientes
