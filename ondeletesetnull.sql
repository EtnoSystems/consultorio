ALTER TABLE dbo.Datos_contacto
alter column Persona_Id int null

ALTER TABLE dbo.Datos_contacto
drop constraint FK_PersonaDatos_contacto

ALTER TABLE dbo.Datos_contacto
add constraint FK_PersonaDatos_contacto
foreign key (Persona_id) references dbo.Persona(ID) on delete set null