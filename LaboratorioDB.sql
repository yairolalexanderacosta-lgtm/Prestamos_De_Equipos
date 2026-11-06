CREATE DATABASE LaboratorioDB;
GO

USE LaboratorioDB;
GO

CREATE TABLE Equipo (
    IdEquipo INT IDENTITY(1,1) NOT NULL,
    Codigo   VARCHAR(20)  NOT NULL,
    Nombre   VARCHAR(100) NOT NULL,
    Estado   VARCHAR(20)  NOT NULL CONSTRAINT DF_Equipo_Estado DEFAULT 'Disponible',
    CONSTRAINT PK_Equipo PRIMARY KEY (IdEquipo),
    CONSTRAINT UQ_Equipo_Codigo UNIQUE (Codigo),
    CONSTRAINT CK_Equipo_Estado CHECK (Estado IN ('Disponible', 'Prestado'))
);
GO

CREATE TABLE Prestamo (
    IdPrestamo      INT IDENTITY(1,1) NOT NULL,
    IdEquipo        INT          NOT NULL,
    Solicitante     VARCHAR(100) NOT NULL,
    FechaPrestamo   DATETIME     NOT NULL,
    FechaDevolucion DATETIME     NULL,
    CONSTRAINT PK_Prestamo PRIMARY KEY (IdPrestamo),
    CONSTRAINT FK_Prestamo_Equipo FOREIGN KEY (IdEquipo) REFERENCES Equipo (IdEquipo)
);
GO

INSERT INTO Equipo (Codigo, Nombre, Estado) VALUES
('EQ-001', 'Microscopio óptico',   'Disponible'),
('EQ-002', 'Proyector Epson',      'Prestado'),
('EQ-003', 'Osciloscopio digital', 'Disponible'),
('EQ-004', 'Multímetro Fluke',     'Prestado'),
('EQ-005', 'Laptop Dell Latitude', 'Disponible'),
('EQ-006', 'Kit Arduino Uno',      'Disponible');
GO

INSERT INTO Prestamo (IdEquipo, Solicitante, FechaPrestamo, FechaDevolucion) VALUES
(1, 'Carlos Méndez',     '2026-10-20 08:30', '2026-10-21 10:00'),
(3, 'Prof. Ana Reyes',   '2026-10-22 14:00', '2026-10-24 09:15'),
(5, 'María Santana',     '2026-10-27 11:00', '2026-10-28 16:45'),
(2, 'Prof. Luis García', '2026-11-02 09:00', NULL),
(4, 'Pedro Martínez',    '2026-11-03 08:00', NULL);
GO

