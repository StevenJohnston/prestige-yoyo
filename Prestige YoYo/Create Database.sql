/*
	Name: Matthew Warren Steven johnston
	Date: 3/18/2016
	Description: Creates the database needed to store information about yoyos
*/
USE [master]
GO

/****** Object:  Database [Prestige YoYo]    Script Date: 3/17/2016 8:36:52 PM ******/
CREATE DATABASE [Prestige YoYo]
 CONTAINMENT = NONE
 ON  PRIMARY
( NAME = N'Prestige YoYo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.LOCAL\MSSQL\DATA\Prestige YoYo.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON
( NAME = N'Prestige YoYo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.LOCAL\MSSQL\DATA\Prestige YoYo_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [Prestige YoYo] SET COMPATIBILITY_LEVEL = 110
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Prestige YoYo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Prestige YoYo] SET ANSI_NULL_DEFAULT OFF
GO

ALTER DATABASE [Prestige YoYo] SET ANSI_NULLS OFF
GO

ALTER DATABASE [Prestige YoYo] SET ANSI_PADDING OFF
GO

ALTER DATABASE [Prestige YoYo] SET ANSI_WARNINGS OFF
GO

ALTER DATABASE [Prestige YoYo] SET ARITHABORT OFF
GO

ALTER DATABASE [Prestige YoYo] SET AUTO_CLOSE OFF
GO

ALTER DATABASE [Prestige YoYo] SET AUTO_CREATE_STATISTICS ON
GO

ALTER DATABASE [Prestige YoYo] SET AUTO_SHRINK OFF
GO

ALTER DATABASE [Prestige YoYo] SET AUTO_UPDATE_STATISTICS ON
GO

ALTER DATABASE [Prestige YoYo] SET CURSOR_CLOSE_ON_COMMIT OFF
GO

ALTER DATABASE [Prestige YoYo] SET CURSOR_DEFAULT  GLOBAL
GO

ALTER DATABASE [Prestige YoYo] SET CONCAT_NULL_YIELDS_NULL OFF
GO

ALTER DATABASE [Prestige YoYo] SET NUMERIC_ROUNDABORT OFF
GO

ALTER DATABASE [Prestige YoYo] SET QUOTED_IDENTIFIER OFF
GO

ALTER DATABASE [Prestige YoYo] SET RECURSIVE_TRIGGERS OFF
GO

ALTER DATABASE [Prestige YoYo] SET  DISABLE_BROKER
GO

ALTER DATABASE [Prestige YoYo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO

ALTER DATABASE [Prestige YoYo] SET DATE_CORRELATION_OPTIMIZATION OFF
GO

ALTER DATABASE [Prestige YoYo] SET TRUSTWORTHY OFF
GO

ALTER DATABASE [Prestige YoYo] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO

ALTER DATABASE [Prestige YoYo] SET PARAMETERIZATION SIMPLE
GO

ALTER DATABASE [Prestige YoYo] SET READ_COMMITTED_SNAPSHOT OFF
GO

ALTER DATABASE [Prestige YoYo] SET HONOR_BROKER_PRIORITY OFF
GO

ALTER DATABASE [Prestige YoYo] SET RECOVERY SIMPLE
GO

ALTER DATABASE [Prestige YoYo] SET  MULTI_USER
GO

ALTER DATABASE [Prestige YoYo] SET PAGE_VERIFY CHECKSUM
GO

ALTER DATABASE [Prestige YoYo] SET DB_CHAINING OFF
GO

ALTER DATABASE [Prestige YoYo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF )
GO

ALTER DATABASE [Prestige YoYo] SET TARGET_RECOVERY_TIME = 0 SECONDS
GO

ALTER DATABASE [Prestige YoYo] SET  READ_WRITE
GO


use [Prestige YoYo]

CREATE TABLE [dbo].[Error]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY ,
    [machineID] INT NOT NULL,
    [reworkReject] NCHAR(10) NOT NULL,
    [reason] NCHAR(64) NOT NULL
)
INSERT INTO [dbo].[Error] VALUES (1, 'Reject', 'Inconsistent thickness');
INSERT INTO [dbo].[Error] VALUES (1, 'Reject', 'Pitting');
INSERT INTO [dbo].[Error] VALUES (1, 'Reject', 'Warping');
INSERT INTO [dbo].[Error] VALUES (2, 'Reject', 'Primer Defect');
INSERT INTO [dbo].[Error] VALUES (2, 'Rework', 'Drip mark');
INSERT INTO [dbo].[Error] VALUES (2, 'Rework', 'Final Coat flaw');
INSERT INTO [dbo].[Error] VALUES (3, 'Reject', 'Broken shell');
INSERT INTO [dbo].[Error] VALUES (3, 'Rework', 'Broken Axle');
INSERT INTO [dbo].[Error] VALUES (3, 'Rework', 'Tangled String');
INSERT INTO [dbo].[Error] VALUES (3, 'Rework', 'Final Coat flaw');


CREATE TABLE [dbo].[Factory]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [name] NCHAR(64) NOT NULL
)


CREATE TABLE [dbo].[Line]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [name] NCHAR(64) NOT NULL,
    [factoryID] INT NOT NULL,
    CONSTRAINT [FK_Line_Factory] FOREIGN KEY ([factoryID]) REFERENCES [Factory]([id])
)

CREATE TABLE [dbo].[Machine]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [name] NCHAR(64) NOT NULL,
    [lineID] INT NOT NULL,
    CONSTRAINT [FK_Machine_Line] FOREIGN KEY ([lineID]) REFERENCES [Line]([id])
)







CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [serial] NCHAR(64) NOT NULL
)





CREATE TABLE [dbo].[Specification]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [SKU] NCHAR(64) NOT NULL,
    [description] NCHAR(64) NOT NULL,
    [colour] NCHAR(64) NOT NULL
)
INSERT INTO [dbo].[Specification] VALUES ('Y001-1', 'Prestige', 'Classic Red');
INSERT INTO [dbo].[Specification] VALUES ('Y001-2', 'Prestige', 'Classic Blue');
INSERT INTO [dbo].[Specification] VALUES ('Y001-3', 'Prestige', 'Classic Green');
INSERT INTO [dbo].[Specification] VALUES ('Y002-0', 'Clear', 'Plastic Clear');
INSERT INTO [dbo].[Specification] VALUES ('Y005-1', 'Whistler', 'Red');
INSERT INTO [dbo].[Specification] VALUES ('Y005-2', 'Whistler', 'Blue');
INSERT INTO [dbo].[Specification] VALUES ('Y005-3', 'Whistler', 'Green');

CREATE TABLE [dbo].[Schedule]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [specificationID] INT NOT NULL,
    [date] DATE NOT NULL,
    [startTime] TIME NULL,
    [endTime] TIME NULL,
    CONSTRAINT [FK_Schedule_Colour] FOREIGN KEY ([specificationID]) REFERENCES [Specification]([id])
)

CREATE TABLE [dbo].[Status]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [state] NCHAR(64) NOT NULL,
    [description] NCHAR(64) NOT NULL
)

INSERT INTO [dbo].[Status] VALUES ('MOLD', 'In the Mold process');
INSERT INTO [dbo].[Status] VALUES ('QUEUE_INSPECTION_1', 'On the conveyor to inspection station 1');
INSERT INTO [dbo].[Status] VALUES ('INSPECTION_1', 'At inspection station 1');
INSERT INTO [dbo].[Status] VALUES ('INSPECTION_1_SCRAP', 'In scrap (end of process for that particular yoyo)');
INSERT INTO [dbo].[Status] VALUES ('QUEUE_PAINT', 'On the conveyor to the paint process');
INSERT INTO [dbo].[Status] VALUES ('PAINT', 'In the paint process');
INSERT INTO [dbo].[Status] VALUES ('QUEUE_INSPECTION_2', 'On the conveyor to inspection station 2');
INSERT INTO [dbo].[Status] VALUES ('INSPECTION_2', 'At inspection station 2');
INSERT INTO [dbo].[Status] VALUES ('INSPECTION_2_REWORK', 'Being reworked and sent back to paint');
INSERT INTO [dbo].[Status] VALUES ('INSPECTION_2_SCRAP', 'In scrap (end of process for that particular yoyo)');
INSERT INTO [dbo].[Status] VALUES ('QUEUE_ASSEMBLY', 'On the conveyor to the assembly process');
INSERT INTO [dbo].[Status] VALUES ('ASSEMBLY', 'In the assembly process');
INSERT INTO [dbo].[Status] VALUES ('QUEUE_INSPECTION_3', 'On the conveyor to inspection station 3');
INSERT INTO [dbo].[Status] VALUES ('INSPECTION_3', 'At inspection station 3');
INSERT INTO [dbo].[Status] VALUES ('INSPECTION_3_REWORK', 'Being reworked and sent back to assembly');
INSERT INTO [dbo].[Status] VALUES ('INSPECTION_3_SCRAP', 'In scrap (end of process for that particular yoyo)');
INSERT INTO [dbo].[Status] VALUES ('PACKAGE', 'In package (end of process for a good yoyo');


CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [name] NCHAR(64) NOT NULL,
    [password] NCHAR(64) NOT NULL,
    [type] NCHAR(64) NOT NULL
)
CREATE TABLE [dbo].[Log]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [machineID] INT NOT NULL,
    [statusID] INT NOT NULL,
    [productID] INT NOT NULL,
    [time] DATETIME NOT NULL,
    [errorID] INT NULL,
    CONSTRAINT [FK_Log_Machine] FOREIGN KEY ([machineID]) REFERENCES [Machine]([id]),
    CONSTRAINT [FK_Log_Status] FOREIGN KEY ([statusID]) REFERENCES [Status]([id]),
    CONSTRAINT [FK_Log_Error] FOREIGN KEY ([errorID]) REFERENCES [Error]([id]),
    CONSTRAINT [FK_Log_Product] FOREIGN KEY ([productID]) REFERENCES [Product]([id])
)