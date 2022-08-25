use SIA

go

if object_id('SP_GuardarPais')is not null begin

	drop procedure SP_GuardarPais

end

go

create procedure SP_GuardarPais(@ISO CHAR(3),@nombre nvarchar(80))
as

insert into CatPaises values (@ISO,@nombre)