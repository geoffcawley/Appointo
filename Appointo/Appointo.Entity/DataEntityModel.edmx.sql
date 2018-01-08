
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/08/2018 16:08:10
-- Generated from EDMX file: C:\Users\Bak\Documents\revature\Appointo\Appointo\Appointo\Appointo.Entity\DataEntityModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Appointo.Entity];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Patients'
CREATE TABLE [dbo].[Patients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [DateOfBirth] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [LoginId] int  NOT NULL
);
GO

-- Creating table 'Doctors'
CREATE TABLE [dbo].[Doctors] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LoginId] int  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Specialty] int  NOT NULL
);
GO

-- Creating table 'Receptionists'
CREATE TABLE [dbo].[Receptionists] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LoginId] int  NOT NULL
);
GO

-- Creating table 'PatientAppointments'
CREATE TABLE [dbo].[PatientAppointments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PatientId] int  NULL
);
GO

-- Creating table 'Appointments'
CREATE TABLE [dbo].[Appointments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [Duration] int  NOT NULL,
    [Reason] nvarchar(max)  NOT NULL,
    [DoctorId] int  NULL,
    [PatientId] int  NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'DoctorAppointments'
CREATE TABLE [dbo].[DoctorAppointments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DoctorId] int  NULL
);
GO

-- Creating table 'Logins'
CREATE TABLE [dbo].[Logins] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'LocationDoctor'
CREATE TABLE [dbo].[LocationDoctor] (
    [Locations_Id] int  NOT NULL,
    [Doctors_Id] int  NOT NULL
);
GO

-- Creating table 'AppointmentReceptionist'
CREATE TABLE [dbo].[AppointmentReceptionist] (
    [Appointments_Id] int  NOT NULL,
    [Receptionists_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Patients'
ALTER TABLE [dbo].[Patients]
ADD CONSTRAINT [PK_Patients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Doctors'
ALTER TABLE [dbo].[Doctors]
ADD CONSTRAINT [PK_Doctors]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Receptionists'
ALTER TABLE [dbo].[Receptionists]
ADD CONSTRAINT [PK_Receptionists]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PatientAppointments'
ALTER TABLE [dbo].[PatientAppointments]
ADD CONSTRAINT [PK_PatientAppointments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Appointments'
ALTER TABLE [dbo].[Appointments]
ADD CONSTRAINT [PK_Appointments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [PK_Locations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DoctorAppointments'
ALTER TABLE [dbo].[DoctorAppointments]
ADD CONSTRAINT [PK_DoctorAppointments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Logins'
ALTER TABLE [dbo].[Logins]
ADD CONSTRAINT [PK_Logins]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Locations_Id], [Doctors_Id] in table 'LocationDoctor'
ALTER TABLE [dbo].[LocationDoctor]
ADD CONSTRAINT [PK_LocationDoctor]
    PRIMARY KEY CLUSTERED ([Locations_Id], [Doctors_Id] ASC);
GO

-- Creating primary key on [Appointments_Id], [Receptionists_Id] in table 'AppointmentReceptionist'
ALTER TABLE [dbo].[AppointmentReceptionist]
ADD CONSTRAINT [PK_AppointmentReceptionist]
    PRIMARY KEY CLUSTERED ([Appointments_Id], [Receptionists_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [LoginId] in table 'Patients'
ALTER TABLE [dbo].[Patients]
ADD CONSTRAINT [FK_LoginPatient]
    FOREIGN KEY ([LoginId])
    REFERENCES [dbo].[Logins]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LoginPatient'
CREATE INDEX [IX_FK_LoginPatient]
ON [dbo].[Patients]
    ([LoginId]);
GO

-- Creating foreign key on [LoginId] in table 'Doctors'
ALTER TABLE [dbo].[Doctors]
ADD CONSTRAINT [FK_LoginDoctor]
    FOREIGN KEY ([LoginId])
    REFERENCES [dbo].[Logins]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LoginDoctor'
CREATE INDEX [IX_FK_LoginDoctor]
ON [dbo].[Doctors]
    ([LoginId]);
GO

-- Creating foreign key on [LoginId] in table 'Receptionists'
ALTER TABLE [dbo].[Receptionists]
ADD CONSTRAINT [FK_LoginReceptionist]
    FOREIGN KEY ([LoginId])
    REFERENCES [dbo].[Logins]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LoginReceptionist'
CREATE INDEX [IX_FK_LoginReceptionist]
ON [dbo].[Receptionists]
    ([LoginId]);
GO

-- Creating foreign key on [DoctorId] in table 'DoctorAppointments'
ALTER TABLE [dbo].[DoctorAppointments]
ADD CONSTRAINT [FK_DoctorAppointmentDoctor]
    FOREIGN KEY ([DoctorId])
    REFERENCES [dbo].[Doctors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DoctorAppointmentDoctor'
CREATE INDEX [IX_FK_DoctorAppointmentDoctor]
ON [dbo].[DoctorAppointments]
    ([DoctorId]);
GO

-- Creating foreign key on [Locations_Id] in table 'LocationDoctor'
ALTER TABLE [dbo].[LocationDoctor]
ADD CONSTRAINT [FK_LocationDoctor_Location]
    FOREIGN KEY ([Locations_Id])
    REFERENCES [dbo].[Locations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Doctors_Id] in table 'LocationDoctor'
ALTER TABLE [dbo].[LocationDoctor]
ADD CONSTRAINT [FK_LocationDoctor_Doctor]
    FOREIGN KEY ([Doctors_Id])
    REFERENCES [dbo].[Doctors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LocationDoctor_Doctor'
CREATE INDEX [IX_FK_LocationDoctor_Doctor]
ON [dbo].[LocationDoctor]
    ([Doctors_Id]);
GO

-- Creating foreign key on [DoctorId] in table 'Appointments'
ALTER TABLE [dbo].[Appointments]
ADD CONSTRAINT [FK_AppointmentDoctor]
    FOREIGN KEY ([DoctorId])
    REFERENCES [dbo].[Doctors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AppointmentDoctor'
CREATE INDEX [IX_FK_AppointmentDoctor]
ON [dbo].[Appointments]
    ([DoctorId]);
GO

-- Creating foreign key on [PatientId] in table 'Appointments'
ALTER TABLE [dbo].[Appointments]
ADD CONSTRAINT [FK_AppointmentPatient]
    FOREIGN KEY ([PatientId])
    REFERENCES [dbo].[Patients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AppointmentPatient'
CREATE INDEX [IX_FK_AppointmentPatient]
ON [dbo].[Appointments]
    ([PatientId]);
GO

-- Creating foreign key on [Appointments_Id] in table 'AppointmentReceptionist'
ALTER TABLE [dbo].[AppointmentReceptionist]
ADD CONSTRAINT [FK_AppointmentReceptionist_Appointment]
    FOREIGN KEY ([Appointments_Id])
    REFERENCES [dbo].[Appointments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Receptionists_Id] in table 'AppointmentReceptionist'
ALTER TABLE [dbo].[AppointmentReceptionist]
ADD CONSTRAINT [FK_AppointmentReceptionist_Receptionist]
    FOREIGN KEY ([Receptionists_Id])
    REFERENCES [dbo].[Receptionists]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AppointmentReceptionist_Receptionist'
CREATE INDEX [IX_FK_AppointmentReceptionist_Receptionist]
ON [dbo].[AppointmentReceptionist]
    ([Receptionists_Id]);
GO

-- Creating foreign key on [PatientId] in table 'PatientAppointments'
ALTER TABLE [dbo].[PatientAppointments]
ADD CONSTRAINT [FK_PatientAppointmentPatient]
    FOREIGN KEY ([PatientId])
    REFERENCES [dbo].[Patients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientAppointmentPatient'
CREATE INDEX [IX_FK_PatientAppointmentPatient]
ON [dbo].[PatientAppointments]
    ([PatientId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------