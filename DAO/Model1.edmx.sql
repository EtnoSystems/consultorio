
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/18/2018 22:46:08
-- Generated from EDMX file: C:\Users\Jorge\Desktop\consultorios\consultorios\DAO\Model1.edmx
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
    ALTER TABLE [dbo].[direccion] DROP CONSTRAINT [FK_direccionciudad];
GO
IF OBJECT_ID(N'[dbo].[FK_medico_inherits_persona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[persona_medico] DROP CONSTRAINT [FK_medico_inherits_persona];
GO
IF OBJECT_ID(N'[dbo].[FK_medicoconsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[consulta] DROP CONSTRAINT [FK_medicoconsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_medicoespecialidad_especialidad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[medicoespecialidad] DROP CONSTRAINT [FK_medicoespecialidad_especialidad];
GO
IF OBJECT_ID(N'[dbo].[FK_medicoespecialidad_persona_medico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[medicoespecialidad] DROP CONSTRAINT [FK_medicoespecialidad_persona_medico];
GO
IF OBJECT_ID(N'[dbo].[FK_paciente_inherits_persona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[persona_paciente] DROP CONSTRAINT [FK_paciente_inherits_persona];
GO
IF OBJECT_ID(N'[dbo].[FK_pacienteconsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[consulta] DROP CONSTRAINT [FK_pacienteconsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_personadatos_contacto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[datos_contacto] DROP CONSTRAINT [FK_personadatos_contacto];
GO
IF OBJECT_ID(N'[dbo].[FK_personadireccion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[persona] DROP CONSTRAINT [FK_personadireccion];
GO
IF OBJECT_ID(N'[dbo].[FK_personaobra_social_obra_social]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[personaobra_social] DROP CONSTRAINT [FK_personaobra_social_obra_social];
GO
IF OBJECT_ID(N'[dbo].[FK_personaobra_social_persona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[personaobra_social] DROP CONSTRAINT [FK_personaobra_social_persona];
GO
IF OBJECT_ID(N'[dbo].[FK_tipo_consultaconsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[consulta] DROP CONSTRAINT [FK_tipo_consultaconsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_usuariotipo_usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [FK_usuariotipo_usuario];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ciudad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ciudad];
GO
IF OBJECT_ID(N'[dbo].[consulta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[consulta];
GO
IF OBJECT_ID(N'[dbo].[datos_contacto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[datos_contacto];
GO
IF OBJECT_ID(N'[dbo].[direccion]', 'U') IS NOT NULL
    DROP TABLE [dbo].[direccion];
GO
IF OBJECT_ID(N'[dbo].[especialidad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[especialidad];
GO
IF OBJECT_ID(N'[dbo].[medicoespecialidad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[medicoespecialidad];
GO
IF OBJECT_ID(N'[dbo].[obra_social]', 'U') IS NOT NULL
    DROP TABLE [dbo].[obra_social];
GO
IF OBJECT_ID(N'[dbo].[persona]', 'U') IS NOT NULL
    DROP TABLE [dbo].[persona];
GO
IF OBJECT_ID(N'[dbo].[persona_medico]', 'U') IS NOT NULL
    DROP TABLE [dbo].[persona_medico];
GO
IF OBJECT_ID(N'[dbo].[persona_paciente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[persona_paciente];
GO
IF OBJECT_ID(N'[dbo].[personaobra_social]', 'U') IS NOT NULL
    DROP TABLE [dbo].[personaobra_social];
GO
IF OBJECT_ID(N'[dbo].[tipo_consulta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tipo_consulta];
GO
IF OBJECT_ID(N'[dbo].[tipo_usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tipo_usuario];
GO
IF OBJECT_ID(N'[dbo].[usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[usuario];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ciudad'
CREATE TABLE [dbo].[ciudad] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [denominacion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'consulta'
CREATE TABLE [dbo].[consulta] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [precio] decimal(6,2)  NULL,
    [fecha] datetime  NOT NULL,
    [medico_Id] int  NOT NULL,
    [tipo_consulta_Id] int  NOT NULL,
    [paciente_Id] int  NOT NULL,
    [pagada] bit  NOT NULL
);
GO

-- Creating table 'datos_contacto'
CREATE TABLE [dbo].[datos_contacto] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [email_primario] nvarchar(max)  NOT NULL,
    [email_secundario] nvarchar(max)  NOT NULL,
    [tel_celular] nvarchar(max)  NOT NULL,
    [tel_fijo] nvarchar(max)  NOT NULL,
    [persona_Id] int  NOT NULL
);
GO

-- Creating table 'direccion'
CREATE TABLE [dbo].[direccion] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [calle] nvarchar(max)  NOT NULL,
    [numero] smallint  NULL,
    [piso] nvarchar(max)  NULL,
    [dpto] smallint  NULL,
    [ciudad_Id] int  NOT NULL
);
GO

-- Creating table 'especialidad'
CREATE TABLE [dbo].[especialidad] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [denominacion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'obra_social'
CREATE TABLE [dbo].[obra_social] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [denominacion] nvarchar(max)  NOT NULL,
    [plus] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'persona'
CREATE TABLE [dbo].[persona] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [dni] int  NOT NULL,
    [nombre] nvarchar(max)  NOT NULL,
    [apellido] nvarchar(max)  NOT NULL,
    [direccion_Id] int  NULL
);
GO

-- Creating table 'persona_medico'
CREATE TABLE [dbo].[persona_medico] (
    [matricula] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'persona_paciente'
CREATE TABLE [dbo].[persona_paciente] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'personaobra_social'
CREATE TABLE [dbo].[personaobra_social] (
    [obra_social_Id] int  NOT NULL,
    [persona_Id] int  NOT NULL,
    [orden_OS] bit  NULL,
    [fecha_vencimiento] datetime  NULL
);
GO

-- Creating table 'tipo_consulta'
CREATE TABLE [dbo].[tipo_consulta] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [descripcion] nvarchar(max)  NOT NULL,
    [precio] decimal(6,2)  NULL
);
GO

-- Creating table 'tipo_usuario'
CREATE TABLE [dbo].[tipo_usuario] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [denominacion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'usuario'
CREATE TABLE [dbo].[usuario] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [tipo_usuario] nvarchar(max)  NOT NULL,
    [tipo_usuario1_Id] int  NOT NULL
);
GO

-- Creating table 'medicoespecialidad'
CREATE TABLE [dbo].[medicoespecialidad] (
    [especialidad_Id] int  NOT NULL,
    [persona_medico_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ciudad'
ALTER TABLE [dbo].[ciudad]
ADD CONSTRAINT [PK_ciudad]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'consulta'
ALTER TABLE [dbo].[consulta]
ADD CONSTRAINT [PK_consulta]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'datos_contacto'
ALTER TABLE [dbo].[datos_contacto]
ADD CONSTRAINT [PK_datos_contacto]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'direccion'
ALTER TABLE [dbo].[direccion]
ADD CONSTRAINT [PK_direccion]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'especialidad'
ALTER TABLE [dbo].[especialidad]
ADD CONSTRAINT [PK_especialidad]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'obra_social'
ALTER TABLE [dbo].[obra_social]
ADD CONSTRAINT [PK_obra_social]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'persona'
ALTER TABLE [dbo].[persona]
ADD CONSTRAINT [PK_persona]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'persona_medico'
ALTER TABLE [dbo].[persona_medico]
ADD CONSTRAINT [PK_persona_medico]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'persona_paciente'
ALTER TABLE [dbo].[persona_paciente]
ADD CONSTRAINT [PK_persona_paciente]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [obra_social_Id], [persona_Id] in table 'personaobra_social'
ALTER TABLE [dbo].[personaobra_social]
ADD CONSTRAINT [PK_personaobra_social]
    PRIMARY KEY CLUSTERED ([obra_social_Id], [persona_Id] ASC);
GO

-- Creating primary key on [Id] in table 'tipo_consulta'
ALTER TABLE [dbo].[tipo_consulta]
ADD CONSTRAINT [PK_tipo_consulta]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tipo_usuario'
ALTER TABLE [dbo].[tipo_usuario]
ADD CONSTRAINT [PK_tipo_usuario]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'usuario'
ALTER TABLE [dbo].[usuario]
ADD CONSTRAINT [PK_usuario]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [especialidad_Id], [persona_medico_Id] in table 'medicoespecialidad'
ALTER TABLE [dbo].[medicoespecialidad]
ADD CONSTRAINT [PK_medicoespecialidad]
    PRIMARY KEY CLUSTERED ([especialidad_Id], [persona_medico_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ciudad_Id] in table 'direccion'
ALTER TABLE [dbo].[direccion]
ADD CONSTRAINT [FK_direccionciudad]
    FOREIGN KEY ([ciudad_Id])
    REFERENCES [dbo].[ciudad]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_direccionciudad'
CREATE INDEX [IX_FK_direccionciudad]
ON [dbo].[direccion]
    ([ciudad_Id]);
GO

-- Creating foreign key on [medico_Id] in table 'consulta'
ALTER TABLE [dbo].[consulta]
ADD CONSTRAINT [FK_medicoconsulta]
    FOREIGN KEY ([medico_Id])
    REFERENCES [dbo].[persona_medico]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_medicoconsulta'
CREATE INDEX [IX_FK_medicoconsulta]
ON [dbo].[consulta]
    ([medico_Id]);
GO

-- Creating foreign key on [paciente_Id] in table 'consulta'
ALTER TABLE [dbo].[consulta]
ADD CONSTRAINT [FK_pacienteconsulta]
    FOREIGN KEY ([paciente_Id])
    REFERENCES [dbo].[persona_paciente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_pacienteconsulta'
CREATE INDEX [IX_FK_pacienteconsulta]
ON [dbo].[consulta]
    ([paciente_Id]);
GO

-- Creating foreign key on [tipo_consulta_Id] in table 'consulta'
ALTER TABLE [dbo].[consulta]
ADD CONSTRAINT [FK_tipo_consultaconsulta]
    FOREIGN KEY ([tipo_consulta_Id])
    REFERENCES [dbo].[tipo_consulta]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tipo_consultaconsulta'
CREATE INDEX [IX_FK_tipo_consultaconsulta]
ON [dbo].[consulta]
    ([tipo_consulta_Id]);
GO

-- Creating foreign key on [persona_Id] in table 'datos_contacto'
ALTER TABLE [dbo].[datos_contacto]
ADD CONSTRAINT [FK_personadatos_contacto]
    FOREIGN KEY ([persona_Id])
    REFERENCES [dbo].[persona]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_personadatos_contacto'
CREATE INDEX [IX_FK_personadatos_contacto]
ON [dbo].[datos_contacto]
    ([persona_Id]);
GO

-- Creating foreign key on [direccion_Id] in table 'persona'
ALTER TABLE [dbo].[persona]
ADD CONSTRAINT [FK_personadireccion]
    FOREIGN KEY ([direccion_Id])
    REFERENCES [dbo].[direccion]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_personadireccion'
CREATE INDEX [IX_FK_personadireccion]
ON [dbo].[persona]
    ([direccion_Id]);
GO

-- Creating foreign key on [obra_social_Id] in table 'personaobra_social'
ALTER TABLE [dbo].[personaobra_social]
ADD CONSTRAINT [FK_personaobra_social_obra_social]
    FOREIGN KEY ([obra_social_Id])
    REFERENCES [dbo].[obra_social]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'persona_medico'
ALTER TABLE [dbo].[persona_medico]
ADD CONSTRAINT [FK_medico_inherits_persona]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[persona]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'persona_paciente'
ALTER TABLE [dbo].[persona_paciente]
ADD CONSTRAINT [FK_paciente_inherits_persona]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[persona]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [persona_Id] in table 'personaobra_social'
ALTER TABLE [dbo].[personaobra_social]
ADD CONSTRAINT [FK_personaobra_social_persona]
    FOREIGN KEY ([persona_Id])
    REFERENCES [dbo].[persona]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_personaobra_social_persona'
CREATE INDEX [IX_FK_personaobra_social_persona]
ON [dbo].[personaobra_social]
    ([persona_Id]);
GO

-- Creating foreign key on [tipo_usuario1_Id] in table 'usuario'
ALTER TABLE [dbo].[usuario]
ADD CONSTRAINT [FK_usuariotipo_usuario]
    FOREIGN KEY ([tipo_usuario1_Id])
    REFERENCES [dbo].[tipo_usuario]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_usuariotipo_usuario'
CREATE INDEX [IX_FK_usuariotipo_usuario]
ON [dbo].[usuario]
    ([tipo_usuario1_Id]);
GO

-- Creating foreign key on [especialidad_Id] in table 'medicoespecialidad'
ALTER TABLE [dbo].[medicoespecialidad]
ADD CONSTRAINT [FK_medicoespecialidad_especialidad]
    FOREIGN KEY ([especialidad_Id])
    REFERENCES [dbo].[especialidad]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [persona_medico_Id] in table 'medicoespecialidad'
ALTER TABLE [dbo].[medicoespecialidad]
ADD CONSTRAINT [FK_medicoespecialidad_persona_medico]
    FOREIGN KEY ([persona_medico_Id])
    REFERENCES [dbo].[persona_medico]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_medicoespecialidad_persona_medico'
CREATE INDEX [IX_FK_medicoespecialidad_persona_medico]
ON [dbo].[medicoespecialidad]
    ([persona_medico_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------