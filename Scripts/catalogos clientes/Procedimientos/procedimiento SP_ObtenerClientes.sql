use SIA

if OBJECT_ID('SP_ObtenerClientes') is not null
	drop procedure SP_ObtenerClientes

go

create procedure SP_ObtenerClientes
as

declare @result table(
id int,
Nombre nvarchar(120),
Calle nvarchar(120),
NumExterior nvarchar(10),
NumInterior nvarchar(10),
Pais nvarchar(120),
Estado nvarchar(120),
Municipio nvarchar(120),
Colonia nvarchar(80),
CodigoPostal nvarchar(10),
Telefono nvarchar(12),
PaginaWeb nvarchar(120),
ClienteAAA bit,
Bloqueo  bit
)

declare @id int,
		@Nombre nvarchar(120),
		@Calle nvarchar(120),
		@NumExterior nvarchar(10),
		@NumInterior nvarchar(10),
		@Pais int,
		@Estado int,
		@Municipio int,
		@PaisS nvarchar(120),
		@EstadoS nvarchar(120),
		@MunicipioS nvarchar(120),
		@Colonia nvarchar(80),
		@CodigoPostal nvarchar(10),
		@Telefono nvarchar(12),
		@PaginaWeb nvarchar(120),
		@ClienteAAA bit,
		@Bloqueo  bit


declare cursorClientes cursor local static for select * from Clientes

open cursorClientes

while 1=1 begin

	fetch CursorClientes into @id,@Nombre,@Calle,@NumExterior,@NumInterior,@Colonia,@Municipio,@Estado,@Pais,@CodigoPostal,@Telefono,@PaginaWeb,@ClienteAAA,@Bloqueo

	if @@FETCH_STATUS <> 0 break

	select @PaisS = NombrePais from CatPaises where id = @Pais
	select @EstadoS = NombreEstado from CatEstados where id = @Estado
	select @MunicipioS = NombreMunicipio from CatMunicipios where id = @Municipio

	insert into @result values (@id,@Nombre,@Calle,@NumExterior,@NumInterior,@PaisS,@EstadoS,@MunicipioS,@Colonia,@CodigoPostal,@Telefono,@PaginaWeb,@ClienteAAA,@Bloqueo)

end

close CursorClientes
deallocate CursorClientes

select * from @result