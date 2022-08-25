use SIA

if OBJECT_ID('SP_ModificarDatosFinancierosCliente') is not null
	drop procedure SP_ModificarDatosFinancierosCliente

go

create procedure SP_ModificarDatosFinancierosCliente(
@idCliente int,
@LimiteCredito money,
@moneda nvarchar(5),
@Bloqueo bit
)
as

update DatosFinacierosClientes set LimitedeCredito = @LimiteCredito, Moneda = @moneda, BloqueadoContabilidad = @Bloqueo where idCliente = @idCliente