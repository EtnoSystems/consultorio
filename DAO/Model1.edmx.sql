
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/04/2018 22:52:18
-- Generated from EDMX file: C:\Users\Jorge\Desktop\consultorios\consultorio\DAO\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [consultorios];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_direccionciudad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Direccion] DROP CONSTRAINT [FK_direccionciudad];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioCiudad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ciudad] DROP CONSTRAINT [FK_UsuarioCiudad];
GO
IF OBJECT_ID(N'[dbo].[FK_ConsultaObra_social]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consulta] DROP CONSTRAINT [FK_ConsultaObra_social];
GO
IF OBJECT_ID(N'[dbo].[FK_medicoconsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consulta] DROP CONSTRAINT [FK_medicoconsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonaConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consulta] DROP CONSTRAINT [FK_PersonaConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consulta] DROP CONSTRAINT [FK_UsuarioConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_personadatos_contacto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Datos_contacto] DROP CONSTRAINT [FK_personadatos_contacto];
GO
IF OBJECT_ID(N'[dbo].[FK_personadireccion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Persona] DROP CONSTRAINT [FK_personadireccion];
GO
IF OBJECT_ID(N'[dbo].[FK_Medicoespecialidad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Persona_medico] DROP CONSTRAINT [FK_Medicoespecialidad];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioEspecialidad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Especialidad] DROP CONSTRAINT [FK_UsuarioEspecialidad];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioFeriado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Feriado] DROP CONSTRAINT [FK_UsuarioFeriado];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioObra_social]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Obra_social] DROP CONSTRAINT [FK_UsuarioObra_social];
GO
IF OBJECT_ID(N'[dbo].[FK_medico_inherits_persona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Persona_medico] DROP CONSTRAINT [FK_medico_inherits_persona];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioPersona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Persona] DROP CONSTRAINT [FK_UsuarioPersona];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioPersona_medico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Persona_medico] DROP CONSTRAINT [FK_UsuarioPersona_medico];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioTipo_usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Usuario] DROP CONSTRAINT [FK_UsuarioTipo_usuario];
GO
IF OBJECT_ID(N'[dbo].[FK_Personaobra_social_Obra_social]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Personaobra_social] DROP CONSTRAINT [FK_Personaobra_social_Obra_social];
GO
IF OBJECT_ID(N'[dbo].[FK_Personaobra_social_Persona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Personaobra_social] DROP CONSTRAINT [FK_Personaobra_social_Persona];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Ciudad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ciudad];
GO
IF OBJECT_ID(N'[dbo].[Consulta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Consulta];
GO
IF OBJECT_ID(N'[dbo].[Datos_contacto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Datos_contacto];
GO
IF OBJECT_ID(N'[dbo].[Direccion]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Direccion];
GO
IF OBJECT_ID(N'[dbo].[Especialidad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Especialidad];
GO
IF OBJECT_ID(N'[dbo].[Feriado]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Feriado];
GO
IF OBJECT_ID(N'[dbo].[Obra_social]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Obra_social];
GO
IF OBJECT_ID(N'[dbo].[Persona]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Persona];
GO
IF OBJECT_ID(N'[dbo].[Persona_medico]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Persona_medico];
GO
IF OBJECT_ID(N'[dbo].[Tipo_usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tipo_usuario];
GO
IF OBJECT_ID(N'[dbo].[Usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuario];
GO
IF OBJECT_ID(N'[dbo].[Personaobra_social]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Personaobra_social];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Ciudad'
CREATE TABLE [dbo].[Ciudad] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Denominacion] varchar(200)  NOT NULL,
    [Editor_Id] int  NOT NULL
);
GO

-- Creating table 'Consulta'
CREATE TABLE [dbo].[Consulta] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Precio] decimal(6,2)  NULL,
    [Fecha] datetime  NOT NULL,
    [Medico_Id] int  NOT NULL,
    [Paciente_Id] int  NOT NULL,
    [Plus] decimal(6,2)  NOT NULL,
    [Retencion_medico] decimal(3,2)  NOT NULL,
    [Reintegro_por_orden] decimal(6,2)  NOT NULL,
    [Orden_presentada] bit  NOT NULL,
    [Obra_social_Id] int  NULL,
    [Editor_Id] int  NOT NULL,
    [Persona_Id] int  NOT NULL
);
GO

-- Creating table 'Datos_contacto'
CREATE TABLE [dbo].[Datos_contacto] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Email_primario] varchar(320)  NULL,
    [Email_secundario] varchar(320)  NULL,
    [Tel_celular] char(14)  NULL,
    [Tel_fijo] char(13)  NULL,
    [Persona_Id] int  NOT NULL
);
GO

-- Creating table 'Direccion'
CREATE TABLE [dbo].[Direccion] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Calle] varchar(100)  NULL,
    [Numero] varchar(6)  NULL,
    [Piso] varchar(3)  NULL,
    [Departamento] varchar(3)  NULL,
    [Ciudad_Id] int  NOT NULL
);
GO

-- Creating table 'Especialidad'
CREATE TABLE [dbo].[Especialidad] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Denominacion] varchar(40)  NOT NULL,
    [Editor_Id] int  NOT NULL
);
GO

-- Creating table 'Feriado'
CREATE TABLE [dbo].[Feriado] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Descripcion] nvarchar(100)  NOT NULL,
    [Editor_Id] int  NOT NULL
);
GO

-- Creating table 'Obra_social'
CREATE TABLE [dbo].[Obra_social] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Denominacion] varchar(150)  NOT NULL,
    [Plus] decimal(6,2)  NOT NULL,
    [Telefono] nvarchar(13)  NULL,
    [Direccion] nvarchar(300)  NULL,
    [Observaciones] nvarchar(max)  NULL,
    [Editor_Id] int  NOT NULL
);
GO

-- Creating table 'Persona'
CREATE TABLE [dbo].[Persona] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DNI] varchar(11)  NOT NULL,
    [Nombre] varchar(60)  NOT NULL,
    [Apellido] varchar(60)  NOT NULL,
    [Direccion_Id] int  NULL,
    [Sexo] char(1)  NULL,
    [Editor_Id] int  NOT NULL
);
GO

-- Creating table 'Persona_medico'
CREATE TABLE [dbo].[Persona_medico] (
    [Matricula] varchar(40)  NOT NULL,
    [Id] int  NOT NULL,
    [Valor_consulta] decimal(6,2)  NOT NULL,
    [Porcentaje_retencion] decimal(3,2)  NOT NULL,
    [Especialidad_Id] int  NOT NULL,
    [Editor_Id] int  NOT NULL
);
GO

-- Creating table 'Tipo_usuario'
CREATE TABLE [dbo].[Tipo_usuario] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Denominacion] varchar(50)  NOT NULL
);
GO

-- Creating table 'Usuario'
CREATE TABLE [dbo].[Usuario] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(35)  NOT NULL,
    [Password] varchar(60)  NOT NULL,
    [Nombre_completo] varchar(70)  NOT NULL,
    [Tipo_usuario_Id] int  NOT NULL
);
GO

-- Creating table 'Personaobra_social'
CREATE TABLE [dbo].[Personaobra_social] (
    [Obra_social_Id] int  NOT NULL,
    [Persona_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Ciudad'
ALTER TABLE [dbo].[Ciudad]
ADD CONSTRAINT [PK_Ciudad]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [PK_Consulta]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Datos_contacto'
ALTER TABLE [dbo].[Datos_contacto]
ADD CONSTRAINT [PK_Datos_contacto]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Direccion'
ALTER TABLE [dbo].[Direccion]
ADD CONSTRAINT [PK_Direccion]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Especialidad'
ALTER TABLE [dbo].[Especialidad]
ADD CONSTRAINT [PK_Especialidad]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Feriado'
ALTER TABLE [dbo].[Feriado]
ADD CONSTRAINT [PK_Feriado]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Obra_social'
ALTER TABLE [dbo].[Obra_social]
ADD CONSTRAINT [PK_Obra_social]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Persona'
ALTER TABLE [dbo].[Persona]
ADD CONSTRAINT [PK_Persona]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Persona_medico'
ALTER TABLE [dbo].[Persona_medico]
ADD CONSTRAINT [PK_Persona_medico]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tipo_usuario'
ALTER TABLE [dbo].[Tipo_usuario]
ADD CONSTRAINT [PK_Tipo_usuario]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Usuario'
ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT [PK_Usuario]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Obra_social_Id], [Persona_Id] in table 'Personaobra_social'
ALTER TABLE [dbo].[Personaobra_social]
ADD CONSTRAINT [PK_Personaobra_social]
    PRIMARY KEY CLUSTERED ([Obra_social_Id], [Persona_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Ciudad_Id] in table 'Direccion'
ALTER TABLE [dbo].[Direccion]
ADD CONSTRAINT [FK_direccionciudad]
    FOREIGN KEY ([Ciudad_Id])
    REFERENCES [dbo].[Ciudad]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_direccionciudad'
CREATE INDEX [IX_FK_direccionciudad]
ON [dbo].[Direccion]
    ([Ciudad_Id]);
GO

-- Creating foreign key on [Editor_Id] in table 'Ciudad'
ALTER TABLE [dbo].[Ciudad]
ADD CONSTRAINT [FK_UsuarioCiudad]
    FOREIGN KEY ([Editor_Id])
    REFERENCES [dbo].[Usuario]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioCiudad'
CREATE INDEX [IX_FK_UsuarioCiudad]
ON [dbo].[Ciudad]
    ([Editor_Id]);
GO

-- Creating foreign key on [Obra_social_Id] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [FK_ConsultaObra_social]
    FOREIGN KEY ([Obra_social_Id])
    REFERENCES [dbo].[Obra_social]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultaObra_social'
CREATE INDEX [IX_FK_ConsultaObra_social]
ON [dbo].[Consulta]
    ([Obra_social_Id]);
GO

-- Creating foreign key on [Medico_Id] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [FK_medicoconsulta]
    FOREIGN KEY ([Medico_Id])
    REFERENCES [dbo].[Persona_medico]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_medicoconsulta'
CREATE INDEX [IX_FK_medicoconsulta]
ON [dbo].[Consulta]
    ([Medico_Id]);
GO

-- Creating foreign key on [Persona_Id] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [FK_PersonaConsulta]
    FOREIGN KEY ([Persona_Id])
    REFERENCES [dbo].[Persona]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaConsulta'
CREATE INDEX [IX_FK_PersonaConsulta]
ON [dbo].[Consulta]
    ([Persona_Id]);
GO

-- Creating foreign key on [Editor_Id] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [FK_UsuarioConsulta]
    FOREIGN KEY ([Editor_Id])
    REFERENCES [dbo].[Usuario]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioConsulta'
CREATE INDEX [IX_FK_UsuarioConsulta]
ON [dbo].[Consulta]
    ([Editor_Id]);
GO

-- Creating foreign key on [Persona_Id] in table 'Datos_contacto'
ALTER TABLE [dbo].[Datos_contacto]
ADD CONSTRAINT [FK_personadatos_contacto]
    FOREIGN KEY ([Persona_Id])
    REFERENCES [dbo].[Persona]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_personadatos_contacto'
CREATE INDEX [IX_FK_personadatos_contacto]
ON [dbo].[Datos_contacto]
    ([Persona_Id]);
GO

-- Creating foreign key on [Direccion_Id] in table 'Persona'
ALTER TABLE [dbo].[Persona]
ADD CONSTRAINT [FK_personadireccion]
    FOREIGN KEY ([Direccion_Id])
    REFERENCES [dbo].[Direccion]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_personadireccion'
CREATE INDEX [IX_FK_personadireccion]
ON [dbo].[Persona]
    ([Direccion_Id]);
GO

-- Creating foreign key on [Especialidad_Id] in table 'Persona_medico'
ALTER TABLE [dbo].[Persona_medico]
ADD CONSTRAINT [FK_Medicoespecialidad]
    FOREIGN KEY ([Especialidad_Id])
    REFERENCES [dbo].[Especialidad]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Medicoespecialidad'
CREATE INDEX [IX_FK_Medicoespecialidad]
ON [dbo].[Persona_medico]
    ([Especialidad_Id]);
GO

-- Creating foreign key on [Editor_Id] in table 'Especialidad'
ALTER TABLE [dbo].[Especialidad]
ADD CONSTRAINT [FK_UsuarioEspecialidad]
    FOREIGN KEY ([Editor_Id])
    REFERENCES [dbo].[Usuario]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioEspecialidad'
CREATE INDEX [IX_FK_UsuarioEspecialidad]
ON [dbo].[Especialidad]
    ([Editor_Id]);
GO

-- Creating foreign key on [Editor_Id] in table 'Feriado'
ALTER TABLE [dbo].[Feriado]
ADD CONSTRAINT [FK_UsuarioFeriado]
    FOREIGN KEY ([Editor_Id])
    REFERENCES [dbo].[Usuario]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioFeriado'
CREATE INDEX [IX_FK_UsuarioFeriado]
ON [dbo].[Feriado]
    ([Editor_Id]);
GO

-- Creating foreign key on [Editor_Id] in table 'Obra_social'
ALTER TABLE [dbo].[Obra_social]
ADD CONSTRAINT [FK_UsuarioObra_social]
    FOREIGN KEY ([Editor_Id])
    REFERENCES [dbo].[Usuario]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioObra_social'
CREATE INDEX [IX_FK_UsuarioObra_social]
ON [dbo].[Obra_social]
    ([Editor_Id]);
GO

-- Creating foreign key on [Id] in table 'Persona_medico'
ALTER TABLE [dbo].[Persona_medico]
ADD CONSTRAINT [FK_medico_inherits_persona]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Persona]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Editor_Id] in table 'Persona'
ALTER TABLE [dbo].[Persona]
ADD CONSTRAINT [FK_UsuarioPersona]
    FOREIGN KEY ([Editor_Id])
    REFERENCES [dbo].[Usuario]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioPersona'
CREATE INDEX [IX_FK_UsuarioPersona]
ON [dbo].[Persona]
    ([Editor_Id]);
GO

-- Creating foreign key on [Editor_Id] in table 'Persona_medico'
ALTER TABLE [dbo].[Persona_medico]
ADD CONSTRAINT [FK_UsuarioPersona_medico]
    FOREIGN KEY ([Editor_Id])
    REFERENCES [dbo].[Usuario]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioPersona_medico'
CREATE INDEX [IX_FK_UsuarioPersona_medico]
ON [dbo].[Persona_medico]
    ([Editor_Id]);
GO

-- Creating foreign key on [Tipo_usuario_Id] in table 'Usuario'
ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT [FK_UsuarioTipo_usuario]
    FOREIGN KEY ([Tipo_usuario_Id])
    REFERENCES [dbo].[Tipo_usuario]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioTipo_usuario'
CREATE INDEX [IX_FK_UsuarioTipo_usuario]
ON [dbo].[Usuario]
    ([Tipo_usuario_Id]);
GO

-- Creating foreign key on [Obra_social_Id] in table 'Personaobra_social'
ALTER TABLE [dbo].[Personaobra_social]
ADD CONSTRAINT [FK_Personaobra_social_Obra_social]
    FOREIGN KEY ([Obra_social_Id])
    REFERENCES [dbo].[Obra_social]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Persona_Id] in table 'Personaobra_social'
ALTER TABLE [dbo].[Personaobra_social]
ADD CONSTRAINT [FK_Personaobra_social_Persona]
    FOREIGN KEY ([Persona_Id])
    REFERENCES [dbo].[Persona]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Personaobra_social_Persona'
CREATE INDEX [IX_FK_Personaobra_social_Persona]
ON [dbo].[Personaobra_social]
    ([Persona_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------