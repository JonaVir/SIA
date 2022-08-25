use SIA

if object_id('SP_GuardarDatosBancariosProveedor') is not null
	drop procedure SP_GuardarDatosBancariosProveedor;

go

create procedure SP_GuardarDatosBancariosProveedor(
@idProveedor int,
@Banco nvarchar(80),
@Clabe nvarchar(80),
@Cuenta nvarchar(120),
@sucursal nvarchar(80),
@titular nvarchar(120),
@predeterminada bit
)
as

declare @id int
select @id = count(*) + 1 from DatosBancariosProveedor where idProveedor = @idProveedor

if @predeterminada = 1 begin

	update datosbancariosProveedor set predeterminada = 0

end

insert into DatosBancariosProveedor values (@id,@idProveedor,@Banco,@Clabe,@Cuenta,@sucursal,@titular,@predeterminada)

