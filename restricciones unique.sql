alter table dbo.usuario with check
add constraint UC_Usuario unique (nombre)

alter table dbo.tipo_usuario with check
add constraint UC_Tipo_usuario unique (denominacion)

alter table dbo.especialidad with check
add constraint UC_Especialidad unique (denominacion)

alter table dbo.obra_social with check
add constraint UC_obra_social unique (denominacion)

alter table dbo.persona_medico with check
add constraint UC_persona_medico unique (matricula)

