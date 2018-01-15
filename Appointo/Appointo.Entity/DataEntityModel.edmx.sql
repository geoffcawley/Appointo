
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/14/2018 22:48:03
-- Generated from EDMX file: C:\Appointo\Appointo\Appointo.Entity\DataEntityModel.edmx
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

IF OBJECT_ID(N'[dbo].[FK_LoginReceptionist]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Receptionists] DROP CONSTRAINT [FK_LoginReceptionist];
GO
IF OBJECT_ID(N'[dbo].[FK_LocationDoctor_Location]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LocationDoctor] DROP CONSTRAINT [FK_LocationDoctor_Location];
GO
IF OBJECT_ID(N'[dbo].[FK_LocationDoctor_Doctor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LocationDoctor] DROP CONSTRAINT [FK_LocationDoctor_Doctor];
GO
IF OBJECT_ID(N'[dbo].[FK_AppointmentReceptionist_Appointment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AppointmentReceptionist] DROP CONSTRAINT [FK_AppointmentReceptionist_Appointment];
GO
IF OBJECT_ID(N'[dbo].[FK_AppointmentReceptionist_Receptionist]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AppointmentReceptionist] DROP CONSTRAINT [FK_AppointmentReceptionist_Receptionist];
GO
IF OBJECT_ID(N'[dbo].[FK_DoctorDoctorPatientAppointment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DoctorPatientAppointments] DROP CONSTRAINT [FK_DoctorDoctorPatientAppointment];
GO
IF OBJECT_ID(N'[dbo].[FK_PatientDoctorPatientAppointment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DoctorPatientAppointments] DROP CONSTRAINT [FK_PatientDoctorPatientAppointment];
GO
IF OBJECT_ID(N'[dbo].[FK_DoctorPatientAppointmentAppointment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DoctorPatientAppointments] DROP CONSTRAINT [FK_DoctorPatientAppointmentAppointment];
GO
IF OBJECT_ID(N'[dbo].[FK_AddressPatient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Patients] DROP CONSTRAINT [FK_AddressPatient];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Patients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Patients];
GO
IF OBJECT_ID(N'[dbo].[Doctors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Doctors];
GO
IF OBJECT_ID(N'[dbo].[Receptionists]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Receptionists];
GO
IF OBJECT_ID(N'[dbo].[Appointments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Appointments];
GO
IF OBJECT_ID(N'[dbo].[Locations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Locations];
GO
IF OBJECT_ID(N'[dbo].[Logins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Logins];
GO
IF OBJECT_ID(N'[dbo].[DoctorPatientAppointments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DoctorPatientAppointments];
GO
IF OBJECT_ID(N'[dbo].[Addresses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Addresses];
GO
IF OBJECT_ID(N'[dbo].[LocationDoctor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LocationDoctor];
GO
IF OBJECT_ID(N'[dbo].[AppointmentReceptionist]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AppointmentReceptionist];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Patients'
CREATE TABLE [dbo].[Patients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [DateOfBirth] nvarchar(max)  NOT NULL,
    [LoginId] int  NOT NULL,
    [AddressId] int  NOT NULL
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
    [LoginId] int  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Appointments'
CREATE TABLE [dbo].[Appointments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [Duration] int  NOT NULL,
    [Reason] nvarchar(max)  NOT NULL,
    [DoctorPatientAppointmentId] int  NOT NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RoomNumber] int  NOT NULL
);
GO

-- Creating table 'Logins'
CREATE TABLE [dbo].[Logins] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LoginID] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DoctorPatientAppointments'
CREATE TABLE [dbo].[DoctorPatientAppointments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DoctorId] int  NOT NULL,
    [PatientId] int  NOT NULL,
    [AppointmentId] int  NOT NULL
);
GO

-- Creating table 'Addresses'
CREATE TABLE [dbo].[Addresses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AddressLine1] nvarchar(max)  NOT NULL,
    [AddressLine2] nvarchar(max)  NOT NULL,
    [City] nvarchar(max)  NOT NULL,
    [State] nvarchar(max)  NOT NULL,
    [ZipCode] nvarchar(max)  NOT NULL
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

-- Creating primary key on [Id] in table 'Logins'
ALTER TABLE [dbo].[Logins]
ADD CONSTRAINT [PK_Logins]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DoctorPatientAppointments'
ALTER TABLE [dbo].[DoctorPatientAppointments]
ADD CONSTRAINT [PK_DoctorPatientAppointments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Addresses'
ALTER TABLE [dbo].[Addresses]
ADD CONSTRAINT [PK_Addresses]
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

-- Creating foreign key on [DoctorId] in table 'DoctorPatientAppointments'
ALTER TABLE [dbo].[DoctorPatientAppointments]
ADD CONSTRAINT [FK_DoctorDoctorPatientAppointment]
    FOREIGN KEY ([DoctorId])
    REFERENCES [dbo].[Doctors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DoctorDoctorPatientAppointment'
CREATE INDEX [IX_FK_DoctorDoctorPatientAppointment]
ON [dbo].[DoctorPatientAppointments]
    ([DoctorId]);
GO

-- Creating foreign key on [PatientId] in table 'DoctorPatientAppointments'
ALTER TABLE [dbo].[DoctorPatientAppointments]
ADD CONSTRAINT [FK_PatientDoctorPatientAppointment]
    FOREIGN KEY ([PatientId])
    REFERENCES [dbo].[Patients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientDoctorPatientAppointment'
CREATE INDEX [IX_FK_PatientDoctorPatientAppointment]
ON [dbo].[DoctorPatientAppointments]
    ([PatientId]);
GO

-- Creating foreign key on [AddressId] in table 'Patients'
ALTER TABLE [dbo].[Patients]
ADD CONSTRAINT [FK_AddressPatient]
    FOREIGN KEY ([AddressId])
    REFERENCES [dbo].[Addresses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AddressPatient'
CREATE INDEX [IX_FK_AddressPatient]
ON [dbo].[Patients]
    ([AddressId]);
GO

-- Creating foreign key on [AppointmentId] in table 'DoctorPatientAppointments'
ALTER TABLE [dbo].[DoctorPatientAppointments]
ADD CONSTRAINT [FK_DoctorPatientAppointmentAppointment]
    FOREIGN KEY ([AppointmentId])
    REFERENCES [dbo].[Appointments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DoctorPatientAppointmentAppointment'
CREATE INDEX [IX_FK_DoctorPatientAppointmentAppointment]
ON [dbo].[DoctorPatientAppointments]
    ([AppointmentId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------