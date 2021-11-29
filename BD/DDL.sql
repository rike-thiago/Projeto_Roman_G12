CREATE DATABASE ROMAN_G12
GO

USE ROMAN_G12
GO

CREATE TABLE TipoUsuario(
   IdTipoUsuario INT PRIMARY KEY IDENTITY(1,1),
   NomeTipoUsuario VARCHAR(40) NOT NULL,
);
GO

CREATE TABLE Usuario(
   IdUsuario INT PRIMARY KEY IDENTITY(1,1),
   IdTipoUsuario INT FOREIGN KEY REFERENCES TipoUsuario(IdTipoUsuario) NOT NULL,
   Email VARCHAR(200) NOT NULL UNIQUE,
   Senha VARCHAR(30) NOT NULL,
);
GO


CREATE TABLE Professor(
   IdProfessor INT PRIMARY KEY IDENTITY(1,1),
   IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario) NOT NULL,
   NomeProfessor CHAR(60) NOT NULL,

);
GO


CREATE TABLE Tema(
   IdTema INT PRIMARY KEY IDENTITY(1,1),
   NomeTema VARCHAR(40) NOT NULL UNIQUE,
);
GO


CREATE TABLE Projeto(

   IdProjeto INT PRIMARY KEY IDENTITY(1,1),
   IdTema INT FOREIGN KEY REFERENCES Tema(IdTema) NOT NULL,
   IdProfessor INT FOREIGN KEY REFERENCES Professor(IdProfessor) NOT NULL,
   NomeProjeto VARCHAR(40) NOT NULL UNIQUE,
   Descricao VARCHAR(300) NOT NULL,

);
GO

