
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/30/2020 10:12:15
-- Generated from EDMX file: C:\Users\aleksandarp\Downloads\ace\AplikacijaOcenki\AplikacijaOcenki\Model1.edmx
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

IF OBJECT_ID(N'[dbo].[Studenti]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Studenti];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Studentis'
CREATE TABLE [dbo].[Studentis] (
    [StudentId] int IDENTITY(1,1) NOT NULL,
    [StudentIme] nchar(50)  NULL,
    [StudentPrezime] nchar(50)  NULL,
    [StudentIndex] nchar(10)  NULL,
    [PredmetIme] nchar(50)  NULL,
    [Ocena] nchar(10)  NULL,
    [RedovnostPoeni] nchar(10)  NULL,
    [KolokviumPrvPoeni] nchar(10)  NULL,
    [KolokviumVtorPoeni] nchar(10)  NULL,
    [IspitPoeni] nchar(10)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [StudentId] in table 'Studentis'
ALTER TABLE [dbo].[Studentis]
ADD CONSTRAINT [PK_Studentis]
    PRIMARY KEY CLUSTERED ([StudentId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------