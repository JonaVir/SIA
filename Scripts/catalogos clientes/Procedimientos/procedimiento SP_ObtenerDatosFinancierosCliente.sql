use SIA

if object_id('SP_ObtenerDatosFinancierosCliente') is not null
	drop procedure SP_ObtenerDatosFinancierosCliente

go

create procedure SP_ObtenerDatosFinancierosCliente(@IdCliente int)
as

select LimitedeCredito as 'Limite de credito',BloqueadoContabilidad as 'Bloqueo Contabilidad',Moneda from DatosFinacierosClientes where idcliente = @IdCliente