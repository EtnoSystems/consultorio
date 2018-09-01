
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/30/2018 01:36:01
-- Generated from EDMX file: C:\Users\Jorge\Desktop\Proyecto\consultorio\BD\Model1.edmx
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
IF OBJECT_ID(N'[dbo].[FK_EspecialidadPersona_Especialidad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EspecialidadPersona] DROP CONSTRAINT [FK_EspecialidadPersona_Especialidad];
GO
IF OBJECT_ID(N'[dbo].[FK_EspecialidadPersona_Persona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EspecialidadPersona] DROP CONSTRAINT [FK_EspecialidadPersona_Persona];
GO
IF OBJECT_ID(N'[dbo].[FK_Obra_socialConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consulta] DROP CONSTRAINT [FK_Obra_socialConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_Obra_socialPersona_Obra_social]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Obra_socialPersona] DROP CONSTRAINT [FK_Obra_socialPersona_Obra_social];
GO
IF OBJECT_ID(N'[dbo].[FK_Obra_socialPersona_Persona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Obra_socialPersona] DROP CONSTRAINT [FK_Obra_socialPersona_Persona];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonaConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consulta] DROP CONSTRAINT [FK_PersonaConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonaConsulta1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consulta] DROP CONSTRAINT [FK_PersonaConsulta1];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonaDatos_contacto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Datos_contacto] DROP CONSTRAINT [FK_PersonaDatos_contacto];
GO
IF OBJECT_ID(N'[dbo].[FK_personadireccion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Persona] DROP CONSTRAINT [FK_personadireccion];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioTipo_usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Usuario] DROP CONSTRAINT [FK_UsuarioTipo_usuario];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Auditoria]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Auditoria];
GO
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
IF OBJECT_ID(N'[dbo].[EspecialidadPersona]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EspecialidadPersona];
GO
IF OBJECT_ID(N'[dbo].[Feriado]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Feriado];
GO
IF OBJECT_ID(N'[dbo].[Obra_social]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Obra_social];
GO
IF OBJECT_ID(N'[dbo].[Obra_socialPersona]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Obra_socialPersona];
GO
IF OBJECT_ID(N'[dbo].[Persona]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Persona];
GO
IF OBJECT_ID(N'[dbo].[Tipo_usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tipo_usuario];
GO
IF OBJECT_ID(N'[dbo].[Usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuario];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Auditoria'
CREATE TABLE [dbo].[Auditoria] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [fecha] nvarchar(max)  NOT NULL,
    [Usuario] nvarchar(max)  NOT NULL,
    [Tabla] nvarchar(max)  NOT NULL,
    [Elemento] nvarchar(max)  NOT NULL,
    [Accion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Ciudad'
CREATE TABLE [dbo].[Ciudad] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Denominacion] varchar(200)  NOT NULL
);
GO

-- Creating table 'Consulta'
CREATE TABLE [dbo].[Consulta] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Precio] decimal(6,2)  NULL,
    [Fecha] datetime  NOT NULL,
    [Plus] decimal(6,2)  NOT NULL,
    [Retencion_medico] decimal(3,2)  NOT NULL,
    [Reintegro_por_orden] decimal(6,2)  NOT NULL,
    [Orden_presentada] bit  NOT NULL,
    [Obra_social_Id] int  NULL,
    [Persona_medico_Id] int  NOT NULL,
    [Persona_paciente_Id] int  NOT NULL
);
GO

-- Creating table 'Datos_contacto'
CREATE TABLE [dbo].[Datos_contacto] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Email] varchar(320)  NULL,
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
    [Denominacion] varchar(60)  NOT NULL
);
GO

-- Creating table 'Feriado'
CREATE TABLE [dbo].[Feriado] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Descripcion] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'Obra_social'
CREATE TABLE [dbo].[Obra_social] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Denominacion] varchar(75)  NOT NULL,
    [Plus] decimal(6,2)  NOT NULL,
    [Telefono] nvarchar(13)  NULL,
    [Direccion] nvarchar(300)  NULL,
    [Observaciones] nvarchar(max)  NULL,
    [Activa] bit  NOT NULL,
    [Nombre_largo] nvarchar(200)  NULL
);
GO

-- Creating table 'Persona'
CREATE TABLE [dbo].[Persona] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DNI] varchar(11)  NOT NULL,
    [Nombre] varchar(60)  NOT NULL,
    [Apellido] varchar(60)  NOT NULL,
    [Sexo] char(1)  NOT NULL,
    [Direccion_Id] int  NULL,
    [Matricula] nvarchar(12)  NULL,
    [Valor_consulta] decimal(6,2)  NULL,
    [Porcentaje_retencion] decimal(3,2)  NULL,
    [Fecha_nacimiento] datetime  NULL
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

-- Creating table 'EspecialidadPersona'
CREATE TABLE [dbo].[EspecialidadPersona] (
    [Especialidad_Id] int  NOT NULL,
    [Persona_Id] int  NOT NULL
);
GO

-- Creating table 'Obra_socialPersona'
CREATE TABLE [dbo].[Obra_socialPersona] (
    [Obra_social_Id] int  NOT NULL,
    [Persona_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Auditoria'
ALTER TABLE [dbo].[Auditoria]
ADD CONSTRAINT [PK_Auditoria]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

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

-- Creating primary key on [Especialidad_Id], [Persona_Id] in table 'EspecialidadPersona'
ALTER TABLE [dbo].[EspecialidadPersona]
ADD CONSTRAINT [PK_EspecialidadPersona]
    PRIMARY KEY CLUSTERED ([Especialidad_Id], [Persona_Id] ASC);
GO

-- Creating primary key on [Obra_social_Id], [Persona_Id] in table 'Obra_socialPersona'
ALTER TABLE [dbo].[Obra_socialPersona]
ADD CONSTRAINT [PK_Obra_socialPersona]
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

-- Creating foreign key on [Obra_social_Id] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [FK_Obra_socialConsulta]
    FOREIGN KEY ([Obra_social_Id])
    REFERENCES [dbo].[Obra_social]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Obra_socialConsulta'
CREATE INDEX [IX_FK_Obra_socialConsulta]
ON [dbo].[Consulta]
    ([Obra_social_Id]);
GO

-- Creating foreign key on [Persona_medico_Id] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [FK_PersonaConsulta]
    FOREIGN KEY ([Persona_medico_Id])
    REFERENCES [dbo].[Persona]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaConsulta'
CREATE INDEX [IX_FK_PersonaConsulta]
ON [dbo].[Consulta]
    ([Persona_medico_Id]);
GO

-- Creating foreign key on [Persona_paciente_Id] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [FK_PersonaConsulta1]
    FOREIGN KEY ([Persona_paciente_Id])
    REFERENCES [dbo].[Persona]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaConsulta1'
CREATE INDEX [IX_FK_PersonaConsulta1]
ON [dbo].[Consulta]
    ([Persona_paciente_Id]);
GO

-- Creating foreign key on [Persona_Id] in table 'Datos_contacto'
ALTER TABLE [dbo].[Datos_contacto]
ADD CONSTRAINT [FK_PersonaDatos_contacto]
    FOREIGN KEY ([Persona_Id])
    REFERENCES [dbo].[Persona]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaDatos_contacto'
CREATE INDEX [IX_FK_PersonaDatos_contacto]
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

-- Creating foreign key on [Especialidad_Id] in table 'EspecialidadPersona'
ALTER TABLE [dbo].[EspecialidadPersona]
ADD CONSTRAINT [FK_EspecialidadPersona_Especialidad]
    FOREIGN KEY ([Especialidad_Id])
    REFERENCES [dbo].[Especialidad]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Persona_Id] in table 'EspecialidadPersona'
ALTER TABLE [dbo].[EspecialidadPersona]
ADD CONSTRAINT [FK_EspecialidadPersona_Persona]
    FOREIGN KEY ([Persona_Id])
    REFERENCES [dbo].[Persona]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EspecialidadPersona_Persona'
CREATE INDEX [IX_FK_EspecialidadPersona_Persona]
ON [dbo].[EspecialidadPersona]
    ([Persona_Id]);
GO

-- Creating foreign key on [Obra_social_Id] in table 'Obra_socialPersona'
ALTER TABLE [dbo].[Obra_socialPersona]
ADD CONSTRAINT [FK_Obra_socialPersona_Obra_social]
    FOREIGN KEY ([Obra_social_Id])
    REFERENCES [dbo].[Obra_social]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Persona_Id] in table 'Obra_socialPersona'
ALTER TABLE [dbo].[Obra_socialPersona]
ADD CONSTRAINT [FK_Obra_socialPersona_Persona]
    FOREIGN KEY ([Persona_Id])
    REFERENCES [dbo].[Persona]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Obra_socialPersona_Persona'
CREATE INDEX [IX_FK_Obra_socialPersona_Persona]
ON [dbo].[Obra_socialPersona]
    ([Persona_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------