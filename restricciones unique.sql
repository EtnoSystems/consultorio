alter table dbo.usuario with check
add constraint UC_Usuario unique (nombre)

alter table dbo.tipo_usuario with check
add constraint UC_Tipo_usuario unique (denominacion)

alter table dbo.especialidad with check
add constraint UC_Especialidad unique (denominacion)

alter table dbo.obra_social with check
add constraint UC_obra_social unique (denominacion)

-- alter table dbo.persona with check
-- add constraint UC_persona_matricula unique (matricula)
-- ESTA INDICE NO SE PUDO CREAR PORQUE RECONOCIA LOS VALORE NULL COMO DUPLICADOS, POR ESO SE SOLUCIONA COMO ESTÁ ABAJO:

CREATE UNIQUE NONCLUSTERED INDEX UC_persona_matricula
ON dbo.Persona(Matricula)
WHERE Matricula IS NOT NULL;

