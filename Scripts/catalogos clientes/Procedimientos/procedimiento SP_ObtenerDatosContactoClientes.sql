use sia

if object_id('SP_ObtenerDatosContactoClientes') is not null
	drop procedure SP_ObtenerDatosContactoClientes

go

create procedure SP_ObtenerDatosContactoClientes(@IdCliente int)
as

select id as 'No.',Nombre,Telefono,Extension,Celular,CorreoElectronico as 'Correo electronico',Puesto from DatosContactoClientes where idcliente = @IdCliente order by id