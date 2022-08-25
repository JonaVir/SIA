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
	insert into CatPaises values ('USA','Estados Unidos de Am�rica');

end

if @numEstados = 0 begin

	insert into CatEstados values (1,'MX-AGU','Aguascalientes');
	insert into CatEstados values (1,'MX-BCN','Baja California');
	insert into CatEstados values (1,'MX-BCS','Baja California Sur');
	insert into CatEstados values (1,'MX-CAM','Campeche');
	insert into CatEstados values (1,'MX-CHP','Chiapas');
	insert into CatEstados values (1,'MX-CHH','Chihuahua');
	insert into CatEstados values (1,'MX-CMX','Ciudad de M�xico');
	insert into CatEstados values (1,'MX-COA','Coahuila');
	insert into CatEstados values (1,'MX-COL','Colima');
	insert into CatEstados values (1,'MX-DUR','Durango');
	insert into CatEstados values (1,'MX-GUA','Guanajuato');
	insert into CatEstados values (1,'MX-GRO','Guerrero');
	insert into CatEstados values (1,'MX-HID','Hidalgo');
	insert into CatEstados values (1,'MX-JAL','Jalisco');
	insert into CatEstados values (1,'MX-MIC','Michoacan');
	insert into CatEstados values (1,'MX-MOR','Morelos');
	insert into CatEstados values (1,'MX-MEX','M�xico');
	insert into CatEstados values (1,'MX-NAY','Nayarit');
	insert into CatEstados values (1,'MX-NLE','Nuevo Le�n');
	insert into CatEstados values (1,'MX-OAX','Oaxaca');
	insert into CatEstados values (1,'MX-PUE','Puebla');
	insert into CatEstados values (1,'MX-QUE','Quer�taro');
	insert into CatEstados values (1,'MX-ROO','Quintana Roo');
	insert into CatEstados values (1,'MX-SLP','San Luis Potos�');
	insert into CatEstados values (1,'MX-SIN','Sinaloa');
	insert into CatEstados values (1,'MX-SON','Sonora');
	insert into CatEstados values (1,'MX-TAB','Tabasco');
	insert into CatEstados values (1,'MX-TAM','Tamaulipas');
	insert into CatEstados values (1,'MX-TLA','Tlaxcala');
	insert into CatEstados values (1,'MX-VER','Veracruz');
	insert into CatEstados values (1,'MX-YUC','Yucat�n');
	insert into CatEstados values (1,'MX-ZAC','Zacatecas');

end

if @numMunicipios = 0 begin
	
	insert into CatMunicipios values (1,14,'001','Acatic');
	insert into CatMunicipios values (1,14,'002','Acatl�n de Ju�rez');
	insert into CatMunicipios values (1,14,'003','Ahualulco de Mercado');
	insert into CatMunicipios values (1,14,'004','Amacueca');
	insert into CatMunicipios values (1,14,'005','Amatit�n');
	insert into CatMunicipios values (1,14,'006','Ameca');
	insert into CatMunicipios values (1,14,'007','San Juanito de Escobedo');
	insert into CatMunicipios values (1,14,'008','Arandas');
	insert into CatMunicipios values (1,14,'009','El Arenal');
	insert into CatMunicipios values (1,14,'010','Atemajac de Brizuela');
	insert into CatMunicipios values (1,14,'011','Atengo');
	insert into CatMunicipios values (1,14,'012','Atenguillo');
	insert into CatMunicipios values (1,14,'013','Atotonilco el Alto');
	insert into CatMunicipios values (1,14,'014','Atoyac');
	insert into CatMunicipios values (1,14,'015','Autl�n de Navarro');
	insert into CatMunicipios values (1,14,'016','Ayotl�n');
	insert into CatMunicipios values (1,14,'017','Ayutla');
	insert into CatMunicipios values (1,14,'018','La Barca');
	insert into CatMunicipios values (1,14,'019','Bola�os');
	insert into CatMunicipios values (1,14,'020','Cabo Corrientes');
	insert into CatMunicipios values (1,14,'021','Casimiro Castillo');
	insert into CatMunicipios values (1,14,'022','Cihuatl�n');
	insert into CatMunicipios values (1,14,'023','Zapotl�n el Grande');
	insert into CatMunicipios values (1,14,'024','Cocula');
	insert into CatMunicipios values (1,14,'025','Colotlan');
	insert into CatMunicipios values (1,14,'026','Concepci�n de Buenos Aires');
	insert into CatMunicipios values (1,14,'027','Cuautitl�n de Garc�a Barrag�n');
	insert into CatMunicipios values (1,14,'028','Cuautla');
	insert into CatMunicipios values (1,14,'029','Cuqu�o');
	insert into CatMunicipios values (1,14,'030','Chapala');
	insert into CatMunicipios values (1,14,'031','Chimaltit�n');
	insert into CatMunicipios values (1,14,'032','Chiquilistl�n');
	insert into CatMunicipios values (1,14,'033','Degollado');
	insert into CatMunicipios values (1,14,'034','Ejutla');
	insert into CatMunicipios values (1,14,'035','Encarnaci�n de D�az');
	insert into CatMunicipios values (1,14,'036','Etzatl�n');
	insert into CatMunicipios values (1,14,'037','El Grullo');
	insert into CatMunicipios values (1,14,'038','Guachinango');
	insert into CatMunicipios values (1,14,'039','Guadalajara');
	insert into CatMunicipios values (1,14,'040','Hostotipaquillo');
	insert into CatMunicipios values (1,14,'041','Huej�car');
	insert into CatMunicipios values (1,14,'042','Huejuquilla el Alto');
	insert into CatMunicipios values (1,14,'043','La Huerta');
	insert into CatMunicipios values (1,14,'044','Ixtlahuac�n de los Membrillos');
	insert into CatMunicipios values (1,14,'045','Ixtlahuac�n del R�o');
	insert into CatMunicipios values (1,14,'046','Jalostotitl�n');
	insert into CatMunicipios values (1,14,'047','Jamay');
	insert into CatMunicipios values (1,14,'048','Jes�s Mar�a');
	insert into CatMunicipios values (1,14,'049','Jilotl�n de los Dolores');
	insert into CatMunicipios values (1,14,'050','Jocotepec');
	insert into CatMunicipios values (1,14,'051','Juanacatl�n');
	insert into CatMunicipios values (1,14,'052','Juchitl�n');
	insert into CatMunicipios values (1,14,'053','Lagos de Moreno');
	insert into CatMunicipios values (1,14,'054','El Lim�n');
	insert into CatMunicipios values (1,14,'055','Magdalena');
	insert into CatMunicipios values (1,14,'056','Santa Mar�a del Oro');
	insert into CatMunicipios values (1,14,'057','La Manzanilla de la Paz');
	insert into CatMunicipios values (1,14,'058','Mascota');
	insert into CatMunicipios values (1,14,'059','Mazamitla');
	insert into CatMunicipios values (1,14,'060','Mexticac�n');
	insert into CatMunicipios values (1,14,'061','Mezquitic');
	insert into CatMunicipios values (1,14,'062','Mixtl�n');
	insert into CatMunicipios values (1,14,'063','Ocotl�n');
	insert into CatMunicipios values (1,14,'064','Ojuelos de Jalisco');
	insert into CatMunicipios values (1,14,'065','Pihuamo');
	insert into CatMunicipios values (1,14,'066','Poncitl�n');
	insert into CatMunicipios values (1,14,'067','Puerto Vallarta');
	insert into CatMunicipios values (1,14,'068','Villa Purificaci�n');
	insert into CatMunicipios values (1,14,'069','Quitupan');
	insert into CatMunicipios values (1,14,'070','El Salto');
	insert into CatMunicipios values (1,14,'071','San Crist�bal de la Barranca');
	insert into CatMunicipios values (1,14,'072','San Diego de Alejandr�a');
	insert into CatMunicipios values (1,14,'073','San Juan de los Lagos');
	insert into CatMunicipios values (1,14,'074','San Juli�n');
	insert into CatMunicipios values (1,14,'075','San Marcos');
	insert into CatMunicipios values (1,14,'076','San Mart�n de Bola�os');
	insert into CatMunicipios values (1,14,'077','San Mart�n Hidalgo');
	insert into CatMunicipios values (1,14,'078','San Miguel el Alto');
	insert into CatMunicipios values (1,14,'079','G�mez Far�as');
	insert into CatMunicipios values (1,14,'080','San Sebasti�n del Oeste');
	insert into CatMunicipios values (1,14,'081','Santa Mar�a de los �ngeles');
	insert into CatMunicipios values (1,14,'082','Sayula');
	insert into CatMunicipios values (1,14,'083','Tala');
	insert into CatMunicipios values (1,14,'084','Talpa de Allende');
	insert into CatMunicipios values (1,14,'085','Tamazula de Gordiano');
	insert into CatMunicipios values (1,14,'086','Tapalpa');
	insert into CatMunicipios values (1,14,'087','Tecalitl�n');
	insert into CatMunicipios values (1,14,'088','Techaluta de Montenegro');
	insert into CatMunicipios values (1,14,'089','Tecolotl�n');
	insert into CatMunicipios values (1,14,'090','Tenamaxtl�n');
	insert into CatMunicipios values (1,14,'091','Teocaltiche');
	insert into CatMunicipios values (1,14,'092','Teocuitatl�n de Corona');
	insert into CatMunicipios values (1,14,'093','Tepatitl�n de Morelos');
	insert into CatMunicipios values (1,14,'094','Tequila');
	insert into CatMunicipios values (1,14,'095','Teuchitl�n');
	insert into CatMunicipios values (1,14,'096','Tizap�n el Alto');
	insert into CatMunicipios values (1,14,'097','Tlajomulco de Z��iga');
	insert into CatMunicipios values (1,14,'098','San Pedro Tlaquepaque');
	insert into CatMunicipios values (1,14,'099','Tolim�n');
	insert into CatMunicipios values (1,14,'100','Tomatl�n');
	insert into CatMunicipios values (1,14,'101','Tonal�');
	insert into CatMunicipios values (1,14,'102','Tonaya');
	insert into CatMunicipios values (1,14,'103','Tonila');
	insert into CatMunicipios values (1,14,'104','Totatiche');
	insert into CatMunicipios values (1,14,'105','Tototl�n');
	insert into CatMunicipios values (1,14,'106','Tuxcacuesco');
	insert into CatMunicipios values (1,14,'107','Tuxcueca');
	insert into CatMunicipios values (1,14,'108','Tuxpan');
	insert into CatMunicipios values (1,14,'109','Uni�n de San Antonio');
	insert into CatMunicipios values (1,14,'110','Uni�n de Tula');
	insert into CatMunicipios values (1,14,'111','Valle de Guadalupe');
	insert into CatMunicipios values (1,14,'112','Valle de Ju�rez');
	insert into CatMunicipios values (1,14,'113','San Gabriel');
	insert into CatMunicipios values (1,14,'114','Villa Corona');
	insert into CatMunicipios values (1,14,'115','Villa Guerrero');
	insert into CatMunicipios values (1,14,'116','Villa Hidalgo');
	insert into CatMunicipios values (1,14,'117','Ca�adas de Obreg�n');
	insert into CatMunicipios values (1,14,'118','Yahualica de Gonz�lez Gallo');
	insert into CatMunicipios values (1,14,'119','Zacoalco de Torres');
	insert into CatMunicipios values (1,14,'120','Zapopan');
	insert into CatMunicipios values (1,14,'121','Zapotiltic');
	insert into CatMunicipios values (1,14,'122','Zapotitl�n de Vadillo');
	insert into CatMunicipios values (1,14,'123','Zapotl�n del Rey');
	insert into CatMunicipios values (1,14,'124','Zapotlanejo');
	insert into CatMunicipios values (1,14,'125','San Ignacio Cerro Gordo');

end