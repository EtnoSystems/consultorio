alter table dbo.usuario
alter column Nombre varchar(450) not null


alter table dbo.usuario with check
add constraint UC_Usuario unique (nombre)

alter table dbo.usuario
drop constraint UC_Usuario

delete from dbo.usuario
where id between 7 and 10

select * from dbo.usuario