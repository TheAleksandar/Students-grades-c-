
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/30/2020 10:16:45
-- Generated from EDMX file: C:\Users\aleksandarp\Downloads\ace\AplikacijaOcenki\AplikacijaOcenki\Model2.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Students];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Table]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Table];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Tables'
CREATE TABLE [dbo].[Tables] (
    [LoginId] int IDENTITY(1,1) NOT NULL,
    [UserName] nchar(50)  NULL,
    [Password] nchar(50)  NULL,
    [ProfIme] nchar(50)  NULL,
    [ProfPrezime] nchar(50)  NULL,
    [PredmetIme] nchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [LoginId] in table 'Tables'
ALTER TABLE [dbo].[Tables]
ADD CONSTRAINT [PK_Tables]
    PRIMARY KEY CLUSTERED ([LoginId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------