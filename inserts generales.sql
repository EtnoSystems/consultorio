-- INSERTS DE LA TABLA TIPO_USUARIO
insert into dbo.tipo_usuario (denominacion) values ('administrador');
insert into dbo.tipo_usuario (denominacion) values ('usuario');


-- INSERTS DE LA TABLA USUARIO
insert into dbo.usuario (nombre,password,nombre_completo,tipo_usuario_Id) VALUES('jrobas','jrobas','Jorge Javier Robas',1);
insert into dbo.usuario (nombre,password,nombre_completo,tipo_usuario_Id) VALUES('mfabbro','mfabbro','Matias Fabbro',1);
insert into dbo.usuario (nombre,password,nombre_completo,tipo_usuario_Id) VALUES('jperez','jperez','Juan perez',2);

-- INSERTS DE LA TABLA CIUDAD

-- Departamento Villaguay
insert into dbo.ciudad (denominacion) values ('Villaguay');
insert into dbo.ciudad (denominacion) values ('Estación Raíces');
insert into dbo.ciudad (denominacion) values ('Ingeniero Miguel Sajaroff');
insert into dbo.ciudad (denominacion) values ('Jubileo');
insert into dbo.ciudad (denominacion) values ('Mojones Norte');
insert into dbo.ciudad (denominacion) values ('Mojones Sur');
insert into dbo.ciudad (denominacion) values ('Paso de la Laguna');
insert into dbo.ciudad (denominacion) values ('Villa Clara');
insert into dbo.ciudad (denominacion) values ('Villa Dominguez');
insert into dbo.ciudad (denominacion) values ('Lucas Sud');
insert into dbo.ciudad (denominacion) values ('Lucas Norte');
insert into dbo.ciudad (denominacion) values ('Zenon Roca');

-- Departamento San Salvador
insert into dbo.ciudad (denominacion) values ('San Salvador');
insert into dbo.ciudad (denominacion) values ('General Campos');

-- Departamento Colon
insert into dbo.ciudad (denominacion) values ('Arroyo Barú');
insert into dbo.ciudad (denominacion) values ('Colón');
insert into dbo.ciudad (denominacion) values ('Colonia Hugues');
insert into dbo.ciudad (denominacion) values ('El Brillante');
insert into dbo.ciudad (denominacion) values ('El colorado');
insert into dbo.ciudad (denominacion) values ('Hambis');
insert into dbo.ciudad (denominacion) values ('Hocker');
insert into dbo.ciudad (denominacion) values ('La Clarita');
insert into dbo.ciudad (denominacion) values ('Pueblo Cazes');
insert into dbo.ciudad (denominacion) values ('Pueblo Liebigs');
insert into dbo.ciudad (denominacion) values ('San José');
insert into dbo.ciudad (denominacion) values ('Ubajay');
insert into dbo.ciudad (denominacion) values ('Villa Elisa');

-- Departamento Concordia
insert into dbo.ciudad (denominacion) values ('Benito Legerén');
insert into dbo.ciudad (denominacion) values ('Calabacilla');
insert into dbo.ciudad (denominacion) values ('Clodomiro Ledesma');
insert into dbo.ciudad (denominacion) values ('Colonia Ayuí');
insert into dbo.ciudad (denominacion) values ('Colonia General Roca');
insert into dbo.ciudad (denominacion) values ('Colonia Yeruá');
insert into dbo.ciudad (denominacion) values ('Concordia');
insert into dbo.ciudad (denominacion) values ('Concordia');
insert into dbo.ciudad (denominacion) values ('El Redomón');
insert into dbo.ciudad (denominacion) values ('Estación Yeruá');
insert into dbo.ciudad (denominacion) values ('La Criolla');
insert into dbo.ciudad (denominacion) values ('Las Tejas');
insert into dbo.ciudad (denominacion) values ('Los Charrúas');
insert into dbo.ciudad (denominacion) values ('Nueva Escocia');
insert into dbo.ciudad (denominacion) values ('Osvaldo Magnasco');
insert into dbo.ciudad (denominacion) values ('Pedernal');
insert into dbo.ciudad (denominacion) values ('Puerto Yeruá');
insert into dbo.ciudad (denominacion) values ('Villa Adela');
insert into dbo.ciudad (denominacion) values ('Villa Zorraquín');

-- Departamento Diamante
insert into dbo.ciudad (denominacion) values ('Aldea Brasilera');
insert into dbo.ciudad (denominacion) values ('Aldea Protestante');
insert into dbo.ciudad (denominacion) values ('Aldea Salto');
insert into dbo.ciudad (denominacion) values ('Aldea San Francisco');
insert into dbo.ciudad (denominacion) values ('Aldea Spatzenkutter');
insert into dbo.ciudad (denominacion) values ('Aldea Valle María');
insert into dbo.ciudad (denominacion) values ('Colonia Ensayo');
insert into dbo.ciudad (denominacion) values ('Diamante');
insert into dbo.ciudad (denominacion) values ('Diamante');
insert into dbo.ciudad (denominacion) values ('Estación Camps');
insert into dbo.ciudad (denominacion) values ('Estación Puíggari');
insert into dbo.ciudad (denominacion) values ('General Alvear');
insert into dbo.ciudad (denominacion) values ('General Racedo');
insert into dbo.ciudad (denominacion) values ('General Ramírez');
insert into dbo.ciudad (denominacion) values ('Paraje La Virgen');
insert into dbo.ciudad (denominacion) values ('Puerto Las Cuevas');
insert into dbo.ciudad (denominacion) values ('Strobel');
insert into dbo.ciudad (denominacion) values ('Villa Libertador San Martín');

-- Departamento Federacion
insert into dbo.ciudad (denominacion) values ('Chajarí');
insert into dbo.ciudad (denominacion) values ('Colonia Alemana');
insert into dbo.ciudad (denominacion) values ('Colonia Ensanche Sauce');
insert into dbo.ciudad (denominacion) values ('Colonia La Argentina');
insert into dbo.ciudad (denominacion) values ('Colonia Peña');
insert into dbo.ciudad (denominacion) values ('Colonia Santa María');
insert into dbo.ciudad (denominacion) values ('Federación');
insert into dbo.ciudad (denominacion) values ('Los Conquistadores');
insert into dbo.ciudad (denominacion) values ('San Jaime de la Frontera');
insert into dbo.ciudad (denominacion) values ('San Pedro');
insert into dbo.ciudad (denominacion) values ('Santa Ana');
insert into dbo.ciudad (denominacion) values ('Villa del Rosario');

-- Departamento Federal
insert into dbo.ciudad (denominacion) values ('Conscripto Bernardi');
insert into dbo.ciudad (denominacion) values ('El Cimarrón');
insert into dbo.ciudad (denominacion) values ('Federal');
insert into dbo.ciudad (denominacion) values ('Nueva Vizcaya');
insert into dbo.ciudad (denominacion) values ('Sauce de Luna');

-- Departamento Feliciano
insert into dbo.ciudad (denominacion) values ('San José de Feliciano');
insert into dbo.ciudad (denominacion) values ('San Víctor');

-- Departamento Gualeguay
insert into dbo.ciudad (denominacion) values ('Aldea Asunción');
insert into dbo.ciudad (denominacion) values ('Estación Lazo');
insert into dbo.ciudad (denominacion) values ('General Galarza');
insert into dbo.ciudad (denominacion) values ('Gualeguay');
insert into dbo.ciudad (denominacion) values ('Puerto Ruiz');

-- Departamento Gualeguaychú
insert into dbo.ciudad (denominacion) values ('Aldea San Antonio');
insert into dbo.ciudad (denominacion) values ('Aldea San Juan');
insert into dbo.ciudad (denominacion) values ('Enrique Carbó');
insert into dbo.ciudad (denominacion) values ('Faustino M. Parera');
insert into dbo.ciudad (denominacion) values ('General Almada');
insert into dbo.ciudad (denominacion) values ('Gilbert');
insert into dbo.ciudad (denominacion) values ('Gualeguaychú');
insert into dbo.ciudad (denominacion) values ('Irazusta');
insert into dbo.ciudad (denominacion) values ('Larroque');
insert into dbo.ciudad (denominacion) values ('Pueblo General Belgrano');
insert into dbo.ciudad (denominacion) values ('Urdinarrain');

-- Departamento Islas del Ibicuy
insert into dbo.ciudad (denominacion) values ('Arroyo Martínez');
insert into dbo.ciudad (denominacion) values ('Ñancay');
insert into dbo.ciudad (denominacion) values ('Ceibas');
insert into dbo.ciudad (denominacion) values ('Ibicuy');
insert into dbo.ciudad (denominacion) values ('Médanos');
insert into dbo.ciudad (denominacion) values ('Villa Paranacito');

-- Departamento La Paz
insert into dbo.ciudad (denominacion) values ('Bovril');
insert into dbo.ciudad (denominacion) values ('Colonia Avigdor');
insert into dbo.ciudad (denominacion) values ('El Solar');
insert into dbo.ciudad (denominacion) values ('La Paz');
insert into dbo.ciudad (denominacion) values ('Piedras Blancas');
insert into dbo.ciudad (denominacion) values ('Pueblo Arrúa');
insert into dbo.ciudad (denominacion) values ('San Gustavo');
insert into dbo.ciudad (denominacion) values ('Santa Elena');
insert into dbo.ciudad (denominacion) values ('Sir Leonard');

-- Departamento Nogoyá
insert into dbo.ciudad (denominacion) values ('Aranguren');
insert into dbo.ciudad (denominacion) values ('Betbeder');
insert into dbo.ciudad (denominacion) values ('Don Cristóbal');
insert into dbo.ciudad (denominacion) values ('Febré');
insert into dbo.ciudad (denominacion) values ('Hernández');
insert into dbo.ciudad (denominacion) values ('Lucas González');
insert into dbo.ciudad (denominacion) values ('Nogoyá');
insert into dbo.ciudad (denominacion) values ('XX de Setiembre');

-- Departamento Paraná
insert into dbo.ciudad (denominacion) values ('Aldea María Luisa');
insert into dbo.ciudad (denominacion) values ('Aldea San Rafael');
insert into dbo.ciudad (denominacion) values ('Aldea Santa María');
insert into dbo.ciudad (denominacion) values ('Aldea Santa Rosa');
insert into dbo.ciudad (denominacion) values ('Cerrito');
insert into dbo.ciudad (denominacion) values ('Cerrito');
insert into dbo.ciudad (denominacion) values ('Colonia Avellaneda');
insert into dbo.ciudad (denominacion) values ('Crespo');
insert into dbo.ciudad (denominacion) values ('El Palenque');
insert into dbo.ciudad (denominacion) values ('El Pingo');
insert into dbo.ciudad (denominacion) values ('Hasenkamp');
insert into dbo.ciudad (denominacion) values ('Hernandarias');
insert into dbo.ciudad (denominacion) values ('La Picada');
insert into dbo.ciudad (denominacion) values ('Las Tunas');
insert into dbo.ciudad (denominacion) values ('María Grande');
insert into dbo.ciudad (denominacion) values ('Oro Verde');
insert into dbo.ciudad (denominacion) values ('Paraná');
insert into dbo.ciudad (denominacion) values ('Pueblo Bellocq (Est. Las Garzas)');
insert into dbo.ciudad (denominacion) values ('Pueblo Brugo');
insert into dbo.ciudad (denominacion) values ('Pueblo General San Martín');
insert into dbo.ciudad (denominacion) values ('Pueblo Moreno');
insert into dbo.ciudad (denominacion) values ('San Benito');
insert into dbo.ciudad (denominacion) values ('Sauce Montrull');
insert into dbo.ciudad (denominacion) values ('Sauce Pinto');
insert into dbo.ciudad (denominacion) values ('Seguí');
insert into dbo.ciudad (denominacion) values ('Sosa');
insert into dbo.ciudad (denominacion) values ('Tabossi');
insert into dbo.ciudad (denominacion) values ('Tezanos Pinto');
insert into dbo.ciudad (denominacion) values ('Viale');
insert into dbo.ciudad (denominacion) values ('Villa Fontana');
insert into dbo.ciudad (denominacion) values ('Villa Gdor. Luis F. Etchevehere');
insert into dbo.ciudad (denominacion) values ('Villa Urquiza');

-- Departamento Rosario del Tala
insert into dbo.ciudad (denominacion) values ('Altamirano Sur');
insert into dbo.ciudad (denominacion) values ('Durazno');
insert into dbo.ciudad (denominacion) values ('Estación Arroyo Clé');
insert into dbo.ciudad (denominacion) values ('Gobernador Echagüe');
insert into dbo.ciudad (denominacion) values ('Gobernador Mansilla');
insert into dbo.ciudad (denominacion) values ('Gobernador Solá');
insert into dbo.ciudad (denominacion) values ('Guardamonte');
insert into dbo.ciudad (denominacion) values ('Las Guachas');
insert into dbo.ciudad (denominacion) values ('Maciá');
insert into dbo.ciudad (denominacion) values ('Rosario del Tala');

-- Departamento Concepcion del Urugu
insert into dbo.ciudad (denominacion) values ('1º de Mayo');
insert into dbo.ciudad (denominacion) values ('Basavilbaso');
insert into dbo.ciudad (denominacion) values ('Caseros');
insert into dbo.ciudad (denominacion) values ('Colonia Elía');
insert into dbo.ciudad (denominacion) values ('Concepción del Uruguay');
insert into dbo.ciudad (denominacion) values ('Estancia San Pedro');
insert into dbo.ciudad (denominacion) values ('Herrera');
insert into dbo.ciudad (denominacion) values ('Las Moscas');
insert into dbo.ciudad (denominacion) values ('Líbaros');
insert into dbo.ciudad (denominacion) values ('Pronunciamiento');
insert into dbo.ciudad (denominacion) values ('Rocamora');
insert into dbo.ciudad (denominacion) values ('Santa Anita');
insert into dbo.ciudad (denominacion) values ('Villa Mantero');
insert into dbo.ciudad (denominacion) values ('Villa San Justo');
insert into dbo.ciudad (denominacion) values ('Villa San Marcial (Est. Gobernador Urquiza)');

--Departamento Victoria
insert into dbo.ciudad (denominacion) values ('Antelo');
insert into dbo.ciudad (denominacion) values ('Charigüé');
insert into dbo.ciudad (denominacion) values ('Laguna del Pescado');
insert into dbo.ciudad (denominacion) values ('Molino Doll');
insert into dbo.ciudad (denominacion) values ('Rincón de Nogoyá');
insert into dbo.ciudad (denominacion) values ('Victoria');


-- INSERTS DE LA TABLA ESPECILIADES MEDICAS
insert into dbo.especialidad (denominacion) values ('Alergia e inmunología');
insert into dbo.especialidad (denominacion) values ('Alergia e inmunología pediátrica');
insert into dbo.especialidad (denominacion) values ('Anatomía patológica');
insert into dbo.especialidad (denominacion) values ('Anestesiólogía');
insert into dbo.especialidad (denominacion) values ('Angiología general y hemodinamia');
insert into dbo.especialidad (denominacion) values ('Bioquímica hematológica y hemostasia');
insert into dbo.especialidad (denominacion) values ('Bioquímica inmunológica');
insert into dbo.especialidad (denominacion) values ('Bioquímica microbiológica');
insert into dbo.especialidad (denominacion) values ('Bioquímica');
insert into dbo.especialidad (denominacion) values ('Cardiólogo');
insert into dbo.especialidad (denominacion) values ('Cardiólogo infantil');
insert into dbo.especialidad (denominacion) values ('Cirugía general');
insert into dbo.especialidad (denominacion) values ('Cirugía infantil');
insert into dbo.especialidad (denominacion) values ('Cirugía pediátrica');
insert into dbo.especialidad (denominacion) values ('Cirujano cardiovascular');
insert into dbo.especialidad (denominacion) values ('Cirujano cardiovascular pediátrica');
insert into dbo.especialidad (denominacion) values ('Cirugía vascular periférica');
insert into dbo.especialidad (denominacion) values ('Cirugía plástica y reparadora');
insert into dbo.especialidad (denominacion) values ('Cirugía de cabeza y cuello');
insert into dbo.especialidad (denominacion) values ('Cirugía de tórax');
insert into dbo.especialidad (denominacion) values ('Cirugía y traumatología buco máxilofacial');
insert into dbo.especialidad (denominacion) values ('Clinica médica');
insert into dbo.especialidad (denominacion) values ('Coloproctología');
insert into dbo.especialidad (denominacion) values ('Dermatología');
insert into dbo.especialidad (denominacion) values ('Dermatología pediátrica');
insert into dbo.especialidad (denominacion) values ('Diágnóstico por imágen');
insert into dbo.especialidad (denominacion) values ('Diágnóstico por imágen buco máxilofacial');
insert into dbo.especialidad (denominacion) values ('Electro fiosiología cardiaca');
insert into dbo.especialidad (denominacion) values ('Emergentología');
insert into dbo.especialidad (denominacion) values ('Endocrinólogía');
insert into dbo.especialidad (denominacion) values ('Endocrinólogía infantil');
insert into dbo.especialidad (denominacion) values ('Endodoncia');
insert into dbo.especialidad (denominacion) values ('Ecografista');
insert into dbo.especialidad (denominacion) values ('Farmacología clínica');
insert into dbo.especialidad (denominacion) values ('Fisiatría (medicina física y rehabilitación)');
insert into dbo.especialidad (denominacion) values ('Fonoaudiología');
insert into dbo.especialidad (denominacion) values ('Gastroenterología');
insert into dbo.especialidad (denominacion) values ('Gastroenterólogo infantil');
insert into dbo.especialidad (denominacion) values ('Genética médica');
insert into dbo.especialidad (denominacion) values ('Geriatría');
insert into dbo.especialidad (denominacion) values ('Ginecólogía');
insert into dbo.especialidad (denominacion) values ('Hematólogo infantil');
insert into dbo.especialidad (denominacion) values ('Hemoterapia e inmunohematología');
insert into dbo.especialidad (denominacion) values ('Hepatología');
insert into dbo.especialidad (denominacion) values ('Hepatología pediátrica');
insert into dbo.especialidad (denominacion) values ('Implantes y prótesis dentobucomaxilar');
insert into dbo.especialidad (denominacion) values ('Infectología');
insert into dbo.especialidad (denominacion) values ('Kinesiólogo');
insert into dbo.especialidad (denominacion) values ('Mastología');
insert into dbo.especialidad (denominacion) values ('Medicina del deporte');
insert into dbo.especialidad (denominacion) values ('Medicina del trabajo');
insert into dbo.especialidad (denominacion) values ('Medicina general y/o medicina de familia');
insert into dbo.especialidad (denominacion) values ('Medicina legal');
insert into dbo.especialidad (denominacion) values ('Medicina nuclear');
insert into dbo.especialidad (denominacion) values ('Medicina paliativa');
insert into dbo.especialidad (denominacion) values ('Medico clínico');
insert into dbo.especialidad (denominacion) values ('Nefrología');
insert into dbo.especialidad (denominacion) values ('Nefrólogo infantil');
insert into dbo.especialidad (denominacion) values ('Neonatología');
insert into dbo.especialidad (denominacion) values ('Neumonología');
insert into dbo.especialidad (denominacion) values ('Neumonólogo infantil');
insert into dbo.especialidad (denominacion) values ('Neurólogo');
insert into dbo.especialidad (denominacion) values ('Neurólogo infantil');
insert into dbo.especialidad (denominacion) values ('Nutrición');
insert into dbo.especialidad (denominacion) values ('Obstetricia');
insert into dbo.especialidad (denominacion) values ('Odontología general');
insert into dbo.especialidad (denominacion) values ('Odontopediatría');
insert into dbo.especialidad (denominacion) values ('Oftalmología');
insert into dbo.especialidad (denominacion) values ('Oncología');
insert into dbo.especialidad (denominacion) values ('Oncólogo infantil');
insert into dbo.especialidad (denominacion) values ('Ortodoncia y ortopedia maxilar');
insert into dbo.especialidad (denominacion) values ('Otorrinolaringología');
insert into dbo.especialidad (denominacion) values ('Pediatría');
insert into dbo.especialidad (denominacion) values ('Periodoncia');
insert into dbo.especialidad (denominacion) values ('Psicología');
insert into dbo.especialidad (denominacion) values ('Psicomotricidad');
insert into dbo.especialidad (denominacion) values ('Psicopedagogía');
insert into dbo.especialidad (denominacion) values ('Psiquiatría');
insert into dbo.especialidad (denominacion) values ('Psiquiatría infanto juvenil');
insert into dbo.especialidad (denominacion) values ('Radioterapia o terapia radiante');
insert into dbo.especialidad (denominacion) values ('Reumatología');
insert into dbo.especialidad (denominacion) values ('Reumatólogo infantil');
insert into dbo.especialidad (denominacion) values ('Terapia intensiva');
insert into dbo.especialidad (denominacion) values ('Terapia ocupacional');
insert into dbo.especialidad (denominacion) values ('Terapista intensivo infantil');
insert into dbo.especialidad (denominacion) values ('Tocoginecología');
insert into dbo.especialidad (denominacion) values ('Toxicología');
insert into dbo.especialidad (denominacion) values ('Traumatología');
insert into dbo.especialidad (denominacion) values ('Traumatología y ortopedia');
insert into dbo.especialidad (denominacion) values ('Traumatología y ortopedia infantil');
insert into dbo.especialidad (denominacion) values ('Urología');

-- INSERTS DE LA TABLA FERIADOS
insert into dbo.feriado (fecha,descripcion) values ('2018-03-24','Día nacional por la memoria, la verdad y la justicia');
insert into dbo.feriado (fecha,descripcion) values ('2018-03-29','Jueves santo');
insert into dbo.feriado (fecha,descripcion) values ('2018-03-30','Viernes santo');
insert into dbo.feriado (fecha,descripcion) values ('2018-04-02','Día del veterano y de los caídos en la guerra de Malvinas');
insert into dbo.feriado (fecha,descripcion) values ('2018-04-30','Feriado puente turístico');
insert into dbo.feriado (fecha,descripcion) values ('2018-05-01','Día del trabajador');
insert into dbo.feriado (fecha,descripcion) values ('2018-05-25','Día de la revolución de mayo');
insert into dbo.feriado (fecha,descripcion) values ('2018-06-20','Paso a la inmortalidad del Gral Manuel Belgrano');
insert into dbo.feriado (fecha,descripcion) values ('2018-07-03','Día de la independencia');
insert into dbo.feriado (fecha,descripcion) values ('2018-08-20','Paso a la inmortalidad del Gral José de San Martín');
insert into dbo.feriado (fecha,descripcion) values ('2018-10-15','Dia del respeto a la diversidad cultural');
insert into dbo.feriado (fecha,descripcion) values ('2018-11-19','Día de la soberanía nacional');
insert into dbo.feriado (fecha,descripcion) values ('2018-12-08','Inmaculada concepción de María');
insert into dbo.feriado (fecha,descripcion) values ('2018-12-24','Feriado puente turístico');
insert into dbo.feriado (fecha,descripcion) values ('2018-12-25','Navidad');
insert into dbo.feriado (fecha,descripcion) values ('2018-12-31','Feriado puente turísitco');

--INSERTS PARA LAS OBRAS SOCIALES
insert into dbo.obra_social (denominacion,nombre_largo,plus,activa) values ('AMUR','Asociación Mutual Ruralista',250,'TRUE');
insert into dbo.obra_social (denominacion,nombre_largo,plus,activa) values ('DASUTEN','Dirección de Acción Social de la UTN',300,'TRUE');
insert into dbo.obra_social (denominacion,nombre_largo,plus,activa) values ('Federada Salud',null,0,'TRUE');
insert into dbo.obra_social (denominacion,nombre_largo,plus,activa) values ('Galeno',null,250,'TRUE');
insert into dbo.obra_social (denominacion,nombre_largo,plus,activa) values ('IOSE','Instituto de Obra Social del Ejercito',250,'TRUE');
insert into dbo.obra_social (denominacion,nombre_largo,plus,activa) values ('IOSPER','Instituto de Obra Social de la Provincia de Entre Ríos',250,'TRUE');
insert into dbo.obra_social (denominacion,nombre_largo,plus,activa) values ('OSBA','Obra Social de la Ciudad de Buenos Aires',250,'TRUE');
insert into dbo.obra_social (denominacion,nombre_largo,plus,activa) values ('OSDE Binario',null,250,'TRUE');
insert into dbo.obra_social (denominacion,nombre_largo,plus,activa) values ('OSFATLyF','Obra Social de la Federación Argentina de Trabajadores de Luz y Fuerza',250,'TRUE');
insert into dbo.obra_social (denominacion,nombre_largo,plus,activa) values ('OSPE','Obra Social de Petroleros',250,'TRUE');
insert into dbo.obra_social (denominacion,nombre_largo,plus,activa) values ('OSECAC','Obra Social de Empleados de Comercio y Actividades Civiles',250,'TRUE');
insert into dbo.obra_social (denominacion,nombre_largo,plus,activa) values ('OSPRERA','Obra Social de los Trabajadores Rurales y Estibadores de la República Argentina',300,'TRUE');
insert into dbo.obra_social (denominacion,nombre_largo,plus,activa) values ('Panaderos',null,0,'FALSE');
insert into dbo.obra_social (denominacion,nombre_largo,plus,activa) values ('Jerarquicos Salud',null,0,'TRUE');
insert into dbo.obra_social (denominacion,nombre_largo,plus,activa) values ('Sancor Salud',null,150,'TRUE');
insert into dbo.obra_social (denominacion,nombre_largo,plus,activa) values ('SMEBER','Sociedad Mutual de Empleados del Banco de Entre Ríos',300,'TRUE');
insert into dbo.obra_social (denominacion,nombre_largo,plus,activa) values ('Swiss Medical',null,250,'TRUE');
insert into dbo.obra_social (denominacion,nombre_largo,plus,activa) values ('Union Personal',null,0,'TRUE');


-- INSERTS PARA CREAR UN PACIENTE	
insert into dbo.direccion (calle,numero,piso,departamento,barrio,ciudad_id) values ('chile',157,null,null,'obras sanitarias',1);
insert into dbo.persona (DNI,Nombre,Apellido,Direccion_id,Sexo,Fecha_nacimiento) values ('34116494','jorge javier','robas',1,'M','03-03-1989');
insert into dbo.datos_contacto (email,tel_celular,tel_fijo,persona_id) values ('javier_robas@hotmail.com','+5493455430130','+543455420313',1);

insert into dbo.direccion (calle,numero,piso,departamento,barrio,ciudad_id) values ('leopoldo herrera',1015,null,null,null,1);
insert into dbo.persona (DNI,Nombre,Apellido,Direccion_id,Sexo,Fecha_nacimiento) values ('34369093','julio matias sebastian','flores fabbro',2,'M','07-04-1989');
insert into dbo.datos_contacto (email,tel_celular,tel_fijo,persona_id) values ('matybienalto@gmail.com','+5493455510599',null,2);

insert into dbo.direccion (calle,numero,piso,departamento,barrio,ciudad_id) values ('juan herrero',100,null,null,null,1);
insert into dbo.persona (DNI,Nombre,Apellido,Direccion_id,Sexo,Fecha_nacimiento) values ('16328437','maria elena','bielinis',3,'F','07-07-1963');
insert into dbo.datos_contacto (email,tel_celular,tel_fijo,persona_id) values ('bielinismariaelena@gmail.com','+5493455527719',null,3);

insert into dbo.direccion (calle,numero,piso,departamento,barrio,ciudad_id) values ('publica',940,null,null,'barrio evita',1);
insert into dbo.persona (DNI,Nombre,Apellido,Direccion_id,Sexo,Fecha_nacimiento) values ('48201594','gimena daiana','robas',4,'F','12-25-2007');
--insert into dbo.datos_contacto (email,tel_celular,tel_fijo,persona_id) values (null,null,null,4);

-- INSERTS PARA CREAR UN MEDICO
insert into dbo.direccion (calle,numero,piso,departamento,barrio,ciudad_id) values ('san martin',1114,1,4,null,1);
insert into dbo.persona (DNI,Nombre,Apellido,Direccion_id,Sexo,Fecha_nacimiento,Matricula,Valor_consulta,Porcentaje_retencion) values ('34195888','johanna natalia','buiatti',5,'F','01-26-1989',400,'0001',0);
insert into dbo.datos_contacto (email,tel_celular,tel_fijo,persona_id) values ('johanna_buiatti@hotmail.com','+5493455406811','+543455420282',5);
insert into dbo.especialidadPersona(especialidad_id,persona_id) values (73,5);

insert into dbo.direccion (calle,numero,piso,departamento,barrio,ciudad_id) values ('juan j. passo',562,null,null,null,1);
insert into dbo.persona (DNI,Nombre,Apellido,Direccion_id,Sexo,Matricula,Valor_consulta,Porcentaje_retencion) values ('23539783','sergio julian','leissa',6,'M',500,'0001',0);
insert into dbo.especialidadPersona(especialidad_id,persona_id) values (22,6);
insert into dbo.especialidadPersona(especialidad_id,persona_id) values (40,6);

-- SIGO CON PACIENTES
insert into dbo.direccion (calle,numero,piso,departamento,barrio,ciudad_id) values ('juan herrero',100,null,null,'buen pastor',1);
insert into dbo.persona (DNI,Nombre,Apellido,Direccion_id,Sexo,Fecha_nacimiento) values ('37543358','maria silvia','robas',7,'F','09-02-1993');
insert into dbo.datos_contacto (email,tel_celular,tel_fijo,persona_id) values ('mariasilviarobas@gmail.com','+5493424297885',null,7);

insert into dbo.direccion (calle,numero,piso,departamento,barrio,ciudad_id) values ('chile',367,null,null,'obras sanitarias',1);
insert into dbo.persona (DNI,Nombre,Apellido,Direccion_id,Sexo,Fecha_nacimiento) values ('46926611','maximo','noguera bielinis',8,'M','10-29-2005');
insert into dbo.datos_contacto (email,tel_celular,tel_fijo,persona_id) values ('maximonoguera1@gmail.com',null,+543455421743,8);

insert into dbo.direccion (calle,numero,piso,departamento,barrio,ciudad_id) values ('publica',940,null,null,'barrio evita',1);
insert into dbo.persona (DNI,Nombre,Apellido,Direccion_id,Sexo,Fecha_nacimiento) values ('47410341','pilar','robas',9,'F','08-04-2006');
--insert into dbo.datos_contacto (email,tel_celular,tel_fijo,persona_id) values (null,null,null,8);

insert into dbo.direccion (calle,numero,piso,departamento,barrio,ciudad_id) values ('chile',157,null,null,'obras sanitarias',1);
insert into dbo.persona (DNI,Nombre,Apellido,Direccion_id,Sexo,Fecha_nacimiento) values ('24488758','maria cecilia','bielinis',10,'F','12-22-1975');
insert into dbo.datos_contacto (email,tel_celular,tel_fijo,persona_id) values ('ceciliabielinis@hotmail.com','+5493455444505','+543455420313',10);

insert into dbo.direccion (calle,numero,piso,departamento,barrio,ciudad_id) values ('estrada',257,null,null,'club policial',1);
insert into dbo.persona (DNI,Nombre,Apellido,Direccion_id,Sexo,Fecha_nacimiento) values ('10974598','hector ariel','robas',11,'M','10-20-1953');
insert into dbo.datos_contacto (email,tel_celular,tel_fijo,persona_id) values ('ariel.robas@hotmail.com','+5493455624442',null,11);

insert into dbo.direccion (calle,numero,piso,departamento,barrio,ciudad_id) values ('san martin',1114,1,4,null,1);
insert into dbo.persona (DNI,Nombre,Apellido,Direccion_id,Sexo,Fecha_nacimiento) values ('34904841','diego emanuel','buiatti',12,'M','08-01-1990');
insert into dbo.datos_contacto (email,tel_celular,tel_fijo,persona_id) values ('diegobuiatti25@gmail.com','+5493455466227',null,12);

insert into dbo.direccion (calle,numero,piso,departamento,barrio,ciudad_id) values ('juan herrero',100,null,null,null,1);
insert into dbo.persona (DNI,Nombre,Apellido,Direccion_id,Sexo,Fecha_nacimiento) values ('41866660','juan ignacio','robas',13,'M','09-18-1999');
insert into dbo.datos_contacto (email,tel_celular,tel_fijo,persona_id) values ('juanrobas@hotmail.com.ar',null,null,13);

insert into dbo.direccion (calle,numero,piso,departamento,barrio,ciudad_id) values ('balcarce',543,null,null,null,1);
insert into dbo.persona (DNI,Nombre,Apellido,Direccion_id,Sexo,Fecha_nacimiento) values ('20259469','gabriela raquel','decurnex',14,'F','03-06-1969');
insert into dbo.datos_contacto (email,tel_celular,tel_fijo,persona_id) values ('gabrielardecurnex@gmail.com','+5493455418524','+543455420282',14);

insert into dbo.direccion (calle,numero,piso,departamento,barrio,ciudad_id) values ('belgrano',1549,null,null,null,1);
insert into dbo.persona (DNI,Nombre,Apellido,Direccion_id,Sexo,Fecha_nacimiento) values ('34945837','jonatan','paccor',15,'M','01-11-1990');
insert into dbo.datos_contacto (email,tel_celular,tel_fijo,persona_id) values ('jonatanpaccor86@gmail.com','+5493455435195',null,15);

insert into dbo.direccion (calle,numero,piso,departamento,barrio,ciudad_id) values ('ituzaingo',188,null,null,null,185);
insert into dbo.persona (DNI,Nombre,Apellido,Direccion_id,Sexo,Fecha_nacimiento) values ('35442564','josé luís','zapata',16,'M','11-02-1990');
insert into dbo.datos_contacto (email,tel_celular,tel_fijo,persona_id) values ('harryelchachy@gmail.com','+5493435444373',null,16);

insert into dbo.direccion (calle,numero,piso,departamento,barrio,ciudad_id) values ('parodi',188,null,null,null,164);
insert into dbo.persona (DNI,Nombre,Apellido,Direccion_id,Sexo,Fecha_nacimiento) values ('5865416','pablo joel','decurnex',17,'M','11-02-1990');
insert into dbo.datos_contacto (email,tel_celular,tel_fijo,persona_id) values ('pablojoeldecurnex@hotmail.com','+5493445406616','+543445423333',17);

insert into dbo.direccion (calle,numero,piso,departamento,barrio,ciudad_id) values ('parodi',188,null,null,null,164);
insert into dbo.persona (DNI,Nombre,Apellido,Direccion_id,Sexo,Fecha_nacimiento) values ('4959956','angelita','cabral',18,'F','05-19-1945');
insert into dbo.datos_contacto (email,tel_celular,tel_fijo,persona_id) values ('angelitacabraldecurnex@hotmail.com','+5493445473234','+543445423333',18);

insert into dbo.direccion (calle,numero,piso,departamento,barrio,ciudad_id) values ('velez sarsfield',145,null,null,null,1);
insert into dbo.persona (DNI,Nombre,Apellido,Direccion_id,Sexo,Fecha_nacimiento) values ('25243271','mauro ceferino','pereyra',19,'M','02-04-1977');
insert into dbo.datos_contacto (email,tel_celular,tel_fijo,persona_id) values ('mauro.pereyra@hotmail.com','+5493455407452',null,19);

insert into dbo.direccion (calle,numero,piso,departamento,barrio,ciudad_id) values ('chile',157,null,null,'obras sanitarias',1);
insert into dbo.persona (DNI,Nombre,Apellido,Direccion_id,Sexo,Fecha_nacimiento) values ('5928106','julio manuel','bielinis',20,'M','06-17-1937');
insert into dbo.datos_contacto (email,tel_celular,tel_fijo,persona_id) values ('juliobielinis@live.com','+5493442556401','+543455420313',20);

insert into dbo.direccion (calle,numero,piso,departamento,barrio,ciudad_id) values ('belgrano',1549,null,null,null,1);
insert into dbo.persona (DNI,Nombre,Apellido,Direccion_id,Sexo,Fecha_nacimiento) values ('35713736','magalí','kerps',21,'F','04-07-1991');
insert into dbo.datos_contacto (email,tel_celular,tel_fijo,persona_id) values ('magakerps@gmail.com','+5493455456268',null,21);

--insert into dbo.direccion (calle,numero,piso,departamento,barrio,ciudad_id) values ('belgrano',1549,null,null,null,1);
--insert into dbo.persona (DNI,Nombre,Apellido,Direccion_id,Sexo,Fecha_nacimiento) values ('5928106','ciro','paccor',21,'M','05-07-2018');
--insert into dbo.datos_contacto (email,tel_celular,tel_fijo,persona_id) values ('jonatanpaccor86@gmail.com','+5493455435195',null,21);

-- INSERTS DE LA TABLA PACIENTE-OBRA SOCIALES
insert into dbo.obra_socialPersona (Obra_social_Id,Persona_Id) values (14,1);
insert into dbo.obra_socialPersona (Obra_social_Id,Persona_Id) values (16,1);
insert into dbo.obra_socialPersona (Obra_social_Id,Persona_Id) values (11,2);


-- INSERTS DE LA TABLA CONSULTA MEDICA
insert into dbo.consulta (precio,fecha,plus,retencion_medico,reintegro_por_orden,orden_presentada,obra_social_id,persona_medico_id,persona_paciente_id) values (500,'2018-02-28',250,0,0,'FALSE',1,6,1);


