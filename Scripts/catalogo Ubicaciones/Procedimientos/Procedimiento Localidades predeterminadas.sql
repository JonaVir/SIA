use sia 

go

if OBJECT_ID('SP_UbicacionesPredeterminadas') is not null begin
	
	drop procedure SP_UbicacionesPredeterminadas

end

go

create procedure SP_UbicacionesPredeterminadas
as

declare @numPaises int,
		@numEstados int,
		@numMunicipios int

select @numPaises = count(*) from CatPaises
select @numEstados = count(*) from CatEstados
select @numMunicipios = count(*) from CatMunicipios

if @numPaises = 0 begin

	insert into CatPaises values ('MEX','Mexico');
	insert into CatPaises values ('USA','Estados Unidos de América');

end

if @numEstados = 0 begin

	insert into CatEstados values (1,'MX-AGU','Aguascalientes');
	insert into CatEstados values (1,'MX-BCN','Baja California');
	insert into CatEstados values (1,'MX-BCS','Baja California Sur');
	insert into CatEstados values (1,'MX-CAM','Campeche');
	insert into CatEstados values (1,'MX-CHP','Chiapas');
	insert into CatEstados values (1,'MX-CHH','Chihuahua');
	insert into CatEstados values (1,'MX-CMX','Ciudad de México');
	insert into CatEstados values (1,'MX-COA','Coahuila');
	insert into CatEstados values (1,'MX-COL','Colima');
	insert into CatEstados values (1,'MX-DUR','Durango');
	insert into CatEstados values (1,'MX-GUA','Guanajuato');
	insert into CatEstados values (1,'MX-GRO','Guerrero');
	insert into CatEstados values (1,'MX-HID','Hidalgo');
	insert into CatEstados values (1,'MX-JAL','Jalisco');
	insert into CatEstados values (1,'MX-MIC','Michoacan');
	insert into CatEstados values (1,'MX-MOR','Morelos');
	insert into CatEstados values (1,'MX-MEX','México');
	insert into CatEstados values (1,'MX-NAY','Nayarit');
	insert into CatEstados values (1,'MX-NLE','Nuevo León');
	insert into CatEstados values (1,'MX-OAX','Oaxaca');
	insert into CatEstados values (1,'MX-PUE','Puebla');
	insert into CatEstados values (1,'MX-QUE','Querétaro');
	insert into CatEstados values (1,'MX-ROO','Quintana Roo');
	insert into CatEstados values (1,'MX-SLP','San Luis Potosí');
	insert into CatEstados values (1,'MX-SIN','Sinaloa');
	insert into CatEstados values (1,'MX-SON','Sonora');
	insert into CatEstados values (1,'MX-TAB','Tabasco');
	insert into CatEstados values (1,'MX-TAM','Tamaulipas');
	insert into CatEstados values (1,'MX-TLA','Tlaxcala');
	insert into CatEstados values (1,'MX-VER','Veracruz');
	insert into CatEstados values (1,'MX-YUC','Yucatán');
	insert into CatEstados values (1,'MX-ZAC','Zacatecas');

end

if @numMunicipios = 0 begin
	
	insert into CatMunicipios values (1,14,'001','Acatic');
	insert into CatMunicipios values (1,14,'002','Acatlán de Juárez');
	insert into CatMunicipios values (1,14,'003','Ahualulco de Mercado');
	insert into CatMunicipios values (1,14,'004','Amacueca');
	insert into CatMunicipios values (1,14,'005','Amatitán');
	insert into CatMunicipios values (1,14,'006','Ameca');
	insert into CatMunicipios values (1,14,'007','San Juanito de Escobedo');
	insert into CatMunicipios values (1,14,'008','Arandas');
	insert into CatMunicipios values (1,14,'009','El Arenal');
	insert into CatMunicipios values (1,14,'010','Atemajac de Brizuela');
	insert into CatMunicipios values (1,14,'011','Atengo');
	insert into CatMunicipios values (1,14,'012','Atenguillo');
	insert into CatMunicipios values (1,14,'013','Atotonilco el Alto');
	insert into CatMunicipios values (1,14,'014','Atoyac');
	insert into CatMunicipios values (1,14,'015','Autlán de Navarro');
	insert into CatMunicipios values (1,14,'016','Ayotlán');
	insert into CatMunicipios values (1,14,'017','Ayutla');
	insert into CatMunicipios values (1,14,'018','La Barca');
	insert into CatMunicipios values (1,14,'019','Bolaños');
	insert into CatMunicipios values (1,14,'020','Cabo Corrientes');
	insert into CatMunicipios values (1,14,'021','Casimiro Castillo');
	insert into CatMunicipios values (1,14,'022','Cihuatlán');
	insert into CatMunicipios values (1,14,'023','Zapotlán el Grande');
	insert into CatMunicipios values (1,14,'024','Cocula');
	insert into CatMunicipios values (1,14,'025','Colotlan');
	insert into CatMunicipios values (1,14,'026','Concepción de Buenos Aires');
	insert into CatMunicipios values (1,14,'027','Cuautitlán de García Barragán');
	insert into CatMunicipios values (1,14,'028','Cuautla');
	insert into CatMunicipios values (1,14,'029','Cuquío');
	insert into CatMunicipios values (1,14,'030','Chapala');
	insert into CatMunicipios values (1,14,'031','Chimaltitán');
	insert into CatMunicipios values (1,14,'032','Chiquilistlán');
	insert into CatMunicipios values (1,14,'033','Degollado');
	insert into CatMunicipios values (1,14,'034','Ejutla');
	insert into CatMunicipios values (1,14,'035','Encarnación de Díaz');
	insert into CatMunicipios values (1,14,'036','Etzatlán');
	insert into CatMunicipios values (1,14,'037','El Grullo');
	insert into CatMunicipios values (1,14,'038','Guachinango');
	insert into CatMunicipios values (1,14,'039','Guadalajara');
	insert into CatMunicipios values (1,14,'040','Hostotipaquillo');
	insert into CatMunicipios values (1,14,'041','Huejúcar');
	insert into CatMunicipios values (1,14,'042','Huejuquilla el Alto');
	insert into CatMunicipios values (1,14,'043','La Huerta');
	insert into CatMunicipios values (1,14,'044','Ixtlahuacán de los Membrillos');
	insert into CatMunicipios values (1,14,'045','Ixtlahuacán del Río');
	insert into CatMunicipios values (1,14,'046','Jalostotitlán');
	insert into CatMunicipios values (1,14,'047','Jamay');
	insert into CatMunicipios values (1,14,'048','Jesús María');
	insert into CatMunicipios values (1,14,'049','Jilotlán de los Dolores');
	insert into CatMunicipios values (1,14,'050','Jocotepec');
	insert into CatMunicipios values (1,14,'051','Juanacatlán');
	insert into CatMunicipios values (1,14,'052','Juchitlán');
	insert into CatMunicipios values (1,14,'053','Lagos de Moreno');
	insert into CatMunicipios values (1,14,'054','El Limón');
	insert into CatMunicipios values (1,14,'055','Magdalena');
	insert into CatMunicipios values (1,14,'056','Santa María del Oro');
	insert into CatMunicipios values (1,14,'057','La Manzanilla de la Paz');
	insert into CatMunicipios values (1,14,'058','Mascota');
	insert into CatMunicipios values (1,14,'059','Mazamitla');
	insert into CatMunicipios values (1,14,'060','Mexticacán');
	insert into CatMunicipios values (1,14,'061','Mezquitic');
	insert into CatMunicipios values (1,14,'062','Mixtlán');
	insert into CatMunicipios values (1,14,'063','Ocotlán');
	insert into CatMunicipios values (1,14,'064','Ojuelos de Jalisco');
	insert into CatMunicipios values (1,14,'065','Pihuamo');
	insert into CatMunicipios values (1,14,'066','Poncitlán');
	insert into CatMunicipios values (1,14,'067','Puerto Vallarta');
	insert into CatMunicipios values (1,14,'068','Villa Purificación');
	insert into CatMunicipios values (1,14,'069','Quitupan');
	insert into CatMunicipios values (1,14,'070','El Salto');
	insert into CatMunicipios values (1,14,'071','San Cristóbal de la Barranca');
	insert into CatMunicipios values (1,14,'072','San Diego de Alejandría');
	insert into CatMunicipios values (1,14,'073','San Juan de los Lagos');
	insert into CatMunicipios values (1,14,'074','San Julián');
	insert into CatMunicipios values (1,14,'075','San Marcos');
	insert into CatMunicipios values (1,14,'076','San Martín de Bolaños');
	insert into CatMunicipios values (1,14,'077','San Martín Hidalgo');
	insert into CatMunicipios values (1,14,'078','San Miguel el Alto');
	insert into CatMunicipios values (1,14,'079','Gómez Farías');
	insert into CatMunicipios values (1,14,'080','San Sebastián del Oeste');
	insert into CatMunicipios values (1,14,'081','Santa María de los ángeles');
	insert into CatMunicipios values (1,14,'082','Sayula');
	insert into CatMunicipios values (1,14,'083','Tala');
	insert into CatMunicipios values (1,14,'084','Talpa de Allende');
	insert into CatMunicipios values (1,14,'085','Tamazula de Gordiano');
	insert into CatMunicipios values (1,14,'086','Tapalpa');
	insert into CatMunicipios values (1,14,'087','Tecalitlán');
	insert into CatMunicipios values (1,14,'088','Techaluta de Montenegro');
	insert into CatMunicipios values (1,14,'089','Tecolotlán');
	insert into CatMunicipios values (1,14,'090','Tenamaxtlán');
	insert into CatMunicipios values (1,14,'091','Teocaltiche');
	insert into CatMunicipios values (1,14,'092','Teocuitatlán de Corona');
	insert into CatMunicipios values (1,14,'093','Tepatitlán de Morelos');
	insert into CatMunicipios values (1,14,'094','Tequila');
	insert into CatMunicipios values (1,14,'095','Teuchitlán');
	insert into CatMunicipios values (1,14,'096','Tizapán el Alto');
	insert into CatMunicipios values (1,14,'097','Tlajomulco de Zúñiga');
	insert into CatMunicipios values (1,14,'098','San Pedro Tlaquepaque');
	insert into CatMunicipios values (1,14,'099','Tolimán');
	insert into CatMunicipios values (1,14,'100','Tomatlán');
	insert into CatMunicipios values (1,14,'101','Tonalá');
	insert into CatMunicipios values (1,14,'102','Tonaya');
	insert into CatMunicipios values (1,14,'103','Tonila');
	insert into CatMunicipios values (1,14,'104','Totatiche');
	insert into CatMunicipios values (1,14,'105','Tototlán');
	insert into CatMunicipios values (1,14,'106','Tuxcacuesco');
	insert into CatMunicipios values (1,14,'107','Tuxcueca');
	insert into CatMunicipios values (1,14,'108','Tuxpan');
	insert into CatMunicipios values (1,14,'109','Unión de San Antonio');
	insert into CatMunicipios values (1,14,'110','Unión de Tula');
	insert into CatMunicipios values (1,14,'111','Valle de Guadalupe');
	insert into CatMunicipios values (1,14,'112','Valle de Juárez');
	insert into CatMunicipios values (1,14,'113','San Gabriel');
	insert into CatMunicipios values (1,14,'114','Villa Corona');
	insert into CatMunicipios values (1,14,'115','Villa Guerrero');
	insert into CatMunicipios values (1,14,'116','Villa Hidalgo');
	insert into CatMunicipios values (1,14,'117','Cañadas de Obregón');
	insert into CatMunicipios values (1,14,'118','Yahualica de González Gallo');
	insert into CatMunicipios values (1,14,'119','Zacoalco de Torres');
	insert into CatMunicipios values (1,14,'120','Zapopan');
	insert into CatMunicipios values (1,14,'121','Zapotiltic');
	insert into CatMunicipios values (1,14,'122','Zapotitlán de Vadillo');
	insert into CatMunicipios values (1,14,'123','Zapotlán del Rey');
	insert into CatMunicipios values (1,14,'124','Zapotlanejo');
	insert into CatMunicipios values (1,14,'125','San Ignacio Cerro Gordo');

end