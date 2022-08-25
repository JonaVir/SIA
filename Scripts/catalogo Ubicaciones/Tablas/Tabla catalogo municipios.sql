use SIA

if OBJECT_ID('CatMunicipios') is not null begin

	drop table CatMunicipios;

end

create table CatMunicipios(
id int identity not null,
idPais int,
idEstado int,
clave nvarchar(4) not null,
nombreMunicipio nvarchar(80) not null
);

alter table CatMunicipios
add primary key (id)

alter table CatMunicipios
add foreign key (idEstado) references CatEstados




