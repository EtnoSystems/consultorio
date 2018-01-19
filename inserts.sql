-- INSERTS DE LA TABLA TIPO_USUARIO

insert into dbo.tipo_usuario (denominacion) values ('administrador');
insert into dbo.tipo_usuario (denominacion) values ('usuario');

-- INSERTS DE LA TABLA USUARIO
insert into dbo.usuario (nombre,password,tipo_usuario,tipo_usuario1_Id) VALUES('jrobas','jrobas','admin',1);
insert into dbo.usuario (nombre,password,tipo_usuario,tipo_usuario1_Id) VALUES('mfabbro','mfabbro','admin',1);
insert into dbo.usuario (nombre,password,tipo_usuario,tipo_usuario1_Id) VALUES('jperez','jperez','user',2);

select * from [dbo].[usuarios];

