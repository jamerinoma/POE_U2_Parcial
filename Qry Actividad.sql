CREATE DATABASE RegistroNotasPOE;
GO

USE RegistroNotasPOE;
GO

CREATE TABLE dbo.Estudiante
(
    Id INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Estudiante PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    Codigo NVARCHAR(30) NOT NULL,
    Laboratorio DECIMAL(4,2) NOT NULL,
    Parcial DECIMAL(4,2) NOT NULL,
    Asistencia DECIMAL(4,2) NOT NULL,
    NotaFinal DECIMAL(4,2) NOT NULL,
    CONSTRAINT UQ_Estudiante_Codigo UNIQUE (Codigo),
    CONSTRAINT CK_Estudiante_Laboratorio CHECK (Laboratorio BETWEEN 0 AND 10),
    CONSTRAINT CK_Estudiante_Parcial CHECK (Parcial BETWEEN 0 AND 10),
    CONSTRAINT CK_Estudiante_Asistencia CHECK (Asistencia BETWEEN 0 AND 10),
    CONSTRAINT CK_Estudiante_Final CHECK (NotaFinal BETWEEN 0 AND 10)
);
GO

SELECT TOP 20 * FROM dbo.Estudiante ORDER BY Id DESC;
GO
