use SIA

if OBJECT_ID('CatEstados') is not null begin

	drop table CatEstados;

end

create table CatEstados(
id int identity,
idPais int, 
ISOEstado nvarchar(6),
nombreEstado nvarchar(80)
);

alter table CatEstados
add primary key (id)

alter table CatEstados
add constraint UNI_ISOEstado
unique (ISOEstado)

alter table CatEstados
add constraint UNI_NombreEstado
unique (nombreEstado)

alter table CatEstados
add foreign key (idPais) references CatPaises


