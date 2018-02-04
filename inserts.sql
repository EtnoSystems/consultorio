-- INSERTS DE LA TABLA TIPO_USUARIO

insert into dbo.tipo_usuario (denominacion) values ('administrador');
insert into dbo.tipo_usuario (denominacion) values ('usuario');

-- INSERTS DE LA TABLA USUARIO
insert into dbo.usuario (nombre,password,nombre_completo,tipo_usuario_Id) VALUES('jrobas','jrobas','Jorge Javier Robas',1);
insert into dbo.usuario (nombre,password,nombre_completo,tipo_usuario_Id) VALUES('mfabbro','mfabbro','Matias Fabbro',1);
insert into dbo.usuario (nombre,password,nombre_completo,tipo_usuario_Id) VALUES('jperez','jperez','Juan perez',2);

select * from [dbo].[usuarios];

