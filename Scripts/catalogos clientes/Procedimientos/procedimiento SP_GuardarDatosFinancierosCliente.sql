use SIA

if OBJECT_ID('SP_GuardarDatosFinancierosCliente') is not null
	drop procedure SP_GuardarDatosFinancierosCliente

go

create procedure SP_GuardarDatosFinancierosCliente(
@idCliente int,
@LimiteCredito money,
@moneda nvarchar(5),
@Bloqueo bit
)
as

insert into DatosFinacierosClientes values (@idCliente,@LimiteCredito,@Bloqueo,@moneda)

