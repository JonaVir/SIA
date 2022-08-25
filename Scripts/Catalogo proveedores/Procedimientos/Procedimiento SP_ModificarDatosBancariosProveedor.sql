use SIA

if object_id('SP_ModificarDatosBancariosProveedor') is not null
	drop procedure SP_ModificarDatosBancariosProveedor;

go

create procedure SP_ModificarDatosBancariosProveedor(
@id int,
@idProveedor int,
@Banco nvarchar(80),
@Clabe nvarchar(80),
@Cuenta nvarchar(120),
@sucursal nvarchar(80),
@titular nvarchar(120),
@predeterminada bit
)
as

update DatosBancariosProveedor set Banco = @Banco,Clabe = @Clabe,Cuenta = @Cuenta,Sucursal = @sucursal, titular = @titular,predeterminada = @predeterminada where id = @id and idproveedor = @idProveedor

