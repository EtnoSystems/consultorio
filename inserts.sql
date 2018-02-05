-- INSERTS DE LA TABLA TIPO_USUARIO
insert into dbo.tipo_usuario (denominacion) values ('administrador');
insert into dbo.tipo_usuario (denominacion) values ('usuario');

-- INSERTS DE LA TABLA USUARIO
insert into dbo.usuario (nombre,password,nombre_completo,tipo_usuario_Id) VALUES('jrobas','jrobas','Jorge Javier Robas',1);
insert into dbo.usuario (nombre,password,nombre_completo,tipo_usuario_Id) VALUES('mfabbro','mfabbro','Matias Fabbro',1);
insert into dbo.usuario (nombre,password,nombre_completo,tipo_usuario_Id) VALUES('jperez','jperez','Juan perez',2);

-- INSERTS DE LA TABLA CIUDAD
-- aca deben ejecutarse los inserts del archivo "inserts ciudades.sql"
-- INSERTS DE LA TABLA CIUDAD

-- Departamento Villaguay
insert into dbo.ciudad (denominacion,Editor_id) values ('Villaguay',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Estación Raíces',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Ingeniero Miguel Sajaroff',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Jubileo',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Mojones Norte',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Mojones Sur',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Paso de la Laguna',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Villa Clara',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Villa Dominguez',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Lucas Sud',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Lucas Norte',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Zenon Roca',1);

-- Departamento San Salvador
insert into dbo.ciudad (denominacion,Editor_id) values ('San Salvador',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('General Campos',1);

-- Departamento Colon
insert into dbo.ciudad (denominacion,Editor_id) values ('Arroyo Barú',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Colón',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Colonia Hugues',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('El Brillante',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('El colorado',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Hambis',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Hocker',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('La Clarita',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Pueblo Cazes',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Pueblo Liebigs',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('San José',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Ubajay',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Villa Elisa',1);

-- Departamento Concordia
insert into dbo.ciudad (denominacion,Editor_id) values ('Benito Legerén',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Calabacilla',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Clodomiro Ledesma',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Colonia Ayuí',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Colonia General Roca',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Colonia Yeruá',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Concordia',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Concordia',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('El Redomón',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Estación Yeruá',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('La Criolla',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Las Tejas',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Los Charrúas',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Nueva Escocia',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Osvaldo Magnasco',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Pedernal',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Puerto Yeruá',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Villa Adela',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Villa Zorraquín',1);

-- Departamento Diamante
insert into dbo.ciudad (denominacion,Editor_id) values ('Aldea Brasilera',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Aldea Protestante',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Aldea Salto',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Aldea San Francisco',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Aldea Spatzenkutter',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Aldea Valle María',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Colonia Ensayo',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Diamante',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Diamante',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Estación Camps',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Estación Puíggari',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('General Alvear',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('General Racedo',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('General Ramírez',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Paraje La Virgen',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Puerto Las Cuevas',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Strobel',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Villa Libertador San Martín',1);

-- Departamento Federacion
insert into dbo.ciudad (denominacion,Editor_id) values ('Chajarí',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Colonia Alemana',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Colonia Ensanche Sauce',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Colonia La Argentina',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Colonia Peña',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Colonia Santa María',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Federación',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Los Conquistadores',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('San Jaime de la Frontera',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('San Pedro',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Santa Ana',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Villa del Rosario',1);

-- Departamento Federal
insert into dbo.ciudad (denominacion,Editor_id) values ('Conscripto Bernardi',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('El Cimarrón',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Federal',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Nueva Vizcaya',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Sauce de Luna',1);

-- Departamento Feliciano
insert into dbo.ciudad (denominacion,Editor_id) values ('San José de Feliciano',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('San Víctor',1);

-- Departamento Gualeguay
insert into dbo.ciudad (denominacion,Editor_id) values ('Aldea Asunción',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Estación Lazo',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('General Galarza',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Gualeguay',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Puerto Ruiz',1);

-- Departamento Gualeguaychú
insert into dbo.ciudad (denominacion,Editor_id) values ('Aldea San Antonio',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Aldea San Juan',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Enrique Carbó',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Faustino M. Parera',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('General Almada',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Gilbert',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Gualeguaychú',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Irazusta',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Larroque',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Pueblo General Belgrano',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Urdinarrain',1);

-- Departamento Islas del Ibicuy
insert into dbo.ciudad (denominacion,Editor_id) values ('Arroyo Martínez',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Ñancay',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Ceibas',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Ibicuy',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Médanos',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Villa Paranacito',1);

-- Departamento La Paz
insert into dbo.ciudad (denominacion,Editor_id) values ('Bovril',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Colonia Avigdor',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('El Solar',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('La Paz',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Piedras Blancas',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Pueblo Arrúa',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('San Gustavo',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Santa Elena',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Sir Leonard',1);

-- Departamento Nogoyá
insert into dbo.ciudad (denominacion,Editor_id) values ('Aranguren',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Betbeder',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Don Cristóbal',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Febré',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Hernández',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Lucas González',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Nogoyá',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('XX de Setiembre',1);

-- Departamento Paraná
insert into dbo.ciudad (denominacion,Editor_id) values ('Aldea María Luisa',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Aldea San Rafael',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Aldea Santa María',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Aldea Santa Rosa',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Cerrito',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Cerrito',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Colonia Avellaneda',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Crespo',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('El Palenque',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('El Pingo',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Hasenkamp',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Hernandarias',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('La Picada',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Las Tunas',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('María Grande',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Oro Verde',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Paraná',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Pueblo Bellocq (Est. Las Garzas)',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Pueblo Brugo',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Pueblo General San Martín',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Pueblo Moreno',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('San Benito',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Sauce Montrull',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Sauce Pinto',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Seguí',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Sosa',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Tabossi',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Tezanos Pinto',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Viale',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Villa Fontana',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Villa Gdor. Luis F. Etchevehere',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Villa Urquiza',1);

-- Departamento Rosario del Tala
insert into dbo.ciudad (denominacion,Editor_id) values ('Altamirano Sur',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Durazno',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Estación Arroyo Clé',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Gobernador Echagüe',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Gobernador Mansilla',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Gobernador Solá',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Guardamonte',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Las Guachas',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Maciá',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Rosario del Tala',1);

-- Departamento Concepcion del Uruguay
insert into dbo.ciudad (denominacion,Editor_id) values ('1º de Mayo',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Basavilbaso',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Caseros',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Colonia Elía',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Concepción del Uruguay',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Estancia San Pedro',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Herrera',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Las Moscas',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Líbaros',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Pronunciamiento',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Rocamora',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Santa Anita',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Villa Mantero',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Villa San Justo',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Villa San Marcial (Est. Gobernador Urquiza)',1);

--Departamento Victoria
insert into dbo.ciudad (denominacion,Editor_id) values ('Antelo',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Charigüé',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Laguna del Pescado',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Molino Doll',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Rincón de Nogoyá',1);
insert into dbo.ciudad (denominacion,Editor_id) values ('Victoria',1);




-- INSERTS PARA CREAR UN PACIENTE
insert into dbo.direccion (calle,numero,piso,departamento,ciudad_id) values ('chile',157,null,null,1)
insert into dbo.persona (DNI,Nombre,Apellido,Direccion_id,Sexo,Editor_id) values (34116494,'jorge javier','robas',1,'M',1);
insert into dbo.datos_contacto (email_primario,email_secundario,tel_celular,tel_fijo,persona_id) values ('javier_robas@hotmail.com','jorgerobas@gmail.com','+5493455430130','+543455420313',1);

