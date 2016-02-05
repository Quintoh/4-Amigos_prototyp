
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/05/2016 11:55:10
-- Generated from EDMX file: C:\Users\Admin\Documents\Development\NyTavlor4Life\WebApplication7\WebApplication7\KonstverkModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Konstverk];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Konstverk]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Konstverk];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Konstverk'
CREATE TABLE [dbo].[Konstverk] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] varchar(50)  NULL,
    [Date] datetime  NULL,
    [Artist] varchar(50)  NULL,
    [Type] varchar(50)  NULL,
    [Location] varchar(50)  NULL,
    [Description] varchar(100)  NULL,
    [Image] varbinary(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Konstverk'
ALTER TABLE [dbo].[Konstverk]
ADD CONSTRAINT [PK_Konstverk]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------