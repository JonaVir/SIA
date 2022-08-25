use SIA

if OBJECT_ID('CatPaises') is not null begin

	drop table CatPaises;

end

create table CatPaises(
id int identity,
ISOPais char(3),
nombrePais nvarchar(80),
);

alter table catPaises
add primary key (id)

alter table catPaises
add constraint UNI_ISOPais
unique (ISOPais)

alter table catPaises
add constraint UNI_NombrePais
unique (nombrePais)



