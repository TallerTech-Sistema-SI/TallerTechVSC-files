CREATE DATABASE TallerMecanico;
GO

USE TallerMecanico;
GO

CREATE TABLE Cliente (
    ID_Cliente INT IDENTITY(1,1) NOT NULL,
    DNI_RUC VARCHAR(20) NOT NULL,
    Nombre NVARCHAR(100) NOT NULL,
    Telefono VARCHAR(20) NULL,
    Direccion NVARCHAR(200) NULL,
    CreatedBy NVARCHAR(50) NULL,
    CreatedAt DATETIME NULL DEFAULT GETDATE(),
    ModifiedBy NVARCHAR(50) NULL,
    ModifiedAt DATETIME NULL,
    CONSTRAINT PK_Cliente PRIMARY KEY (ID_Cliente),
    CONSTRAINT UQ_Cliente_DNI_RUC UNIQUE (DNI_RUC)
);
GO

CREATE TABLE Vehiculo (
    ID_Vehiculo INT IDENTITY(1,1) NOT NULL,
    ID_Cliente INT NOT NULL,
    Placa VARCHAR(15) NOT NULL,
    Marca NVARCHAR(50) NOT NULL,
    Modelo NVARCHAR(50) NOT NULL,
    Anio INT NOT NULL,
    CreatedBy NVARCHAR(50) NULL,
    CreatedAt DATETIME NULL DEFAULT GETDATE(),
    ModifiedBy NVARCHAR(50) NULL,
    ModifiedAt DATETIME NULL,
    CONSTRAINT PK_Vehiculo PRIMARY KEY (ID_Vehiculo),
    CONSTRAINT UQ_Vehiculo_Placa UNIQUE (Placa),
    CONSTRAINT FK_Vehiculo_Cliente FOREIGN KEY (ID_Cliente) REFERENCES Cliente(ID_Cliente)
);
GO

CREATE TABLE Mecanico (
    ID_Mecanico INT IDENTITY(1,1) NOT NULL,
    Nombre NVARCHAR(100) NOT NULL,
    Especialidad NVARCHAR(80) NULL,
    Telefono VARCHAR(20) NULL,
    CreatedBy NVARCHAR(50) NULL,
    CreatedAt DATETIME NULL DEFAULT GETDATE(),
    ModifiedBy NVARCHAR(50) NULL,
    ModifiedAt DATETIME NULL,
    CONSTRAINT PK_Mecanico PRIMARY KEY (ID_Mecanico)
);
GO

CREATE TABLE OrdenServicio (
    ID_Orden INT IDENTITY(1,1) NOT NULL,
    ID_Vehiculo INT NOT NULL,
    ID_Mecanico INT NOT NULL,
    Fecha DATETIME NOT NULL DEFAULT GETDATE(),
    Descripcion NVARCHAR(500) NULL,
    Estado NVARCHAR(30) NOT NULL,
    ManoObra DECIMAL(10,2) NOT NULL DEFAULT 0,
    Total DECIMAL(10,2) NOT NULL DEFAULT 0,
    CreatedBy NVARCHAR(50) NULL,
    CreatedAt DATETIME NULL DEFAULT GETDATE(),
    ModifiedBy NVARCHAR(50) NULL,
    ModifiedAt DATETIME NULL,
    CONSTRAINT PK_OrdenServicio PRIMARY KEY (ID_Orden),
    CONSTRAINT FK_OrdenServicio_Vehiculo FOREIGN KEY (ID_Vehiculo) REFERENCES Vehiculo(ID_Vehiculo),
    CONSTRAINT FK_OrdenServicio_Mecanico FOREIGN KEY (ID_Mecanico) REFERENCES Mecanico(ID_Mecanico)
);
GO

CREATE TABLE Repuesto (
    ID_Repuesto INT IDENTITY(1,1) NOT NULL,
    Codigo VARCHAR(30) NOT NULL,
    Nombre NVARCHAR(100) NOT NULL,
    Marca NVARCHAR(50) NULL,
    Precio DECIMAL(10,2) NOT NULL DEFAULT 0,
    Stock INT NOT NULL DEFAULT 0,
    StockMinimo INT NOT NULL DEFAULT 0,
    CreatedBy NVARCHAR(50) NULL,
    CreatedAt DATETIME NULL DEFAULT GETDATE(),
    ModifiedBy NVARCHAR(50) NULL,
    ModifiedAt DATETIME NULL,
    CONSTRAINT PK_Repuesto PRIMARY KEY (ID_Repuesto),
    CONSTRAINT UQ_Repuesto_Codigo UNIQUE (Codigo)
);
GO

CREATE TABLE Detalle_Repuesto (
    ID_Detalle INT IDENTITY(1,1) NOT NULL,
    ID_Orden INT NOT NULL,
    ID_Repuesto INT NOT NULL,
    Cantidad INT NOT NULL,
    Subtotal DECIMAL(10,2) NOT NULL DEFAULT 0,
    CreatedBy NVARCHAR(50) NULL,
    CreatedAt DATETIME NULL DEFAULT GETDATE(),
    ModifiedBy NVARCHAR(50) NULL,
    ModifiedAt DATETIME NULL,
    CONSTRAINT PK_Detalle_Repuesto PRIMARY KEY (ID_Detalle),
    CONSTRAINT FK_DetalleRepuesto_Orden FOREIGN KEY (ID_Orden) REFERENCES OrdenServicio(ID_Orden),
    CONSTRAINT FK_DetalleRepuesto_Repuesto FOREIGN KEY (ID_Repuesto) REFERENCES Repuesto(ID_Repuesto)
);
GO

CREATE TABLE Usuario (
    ID_Usuario INT IDENTITY(1,1) NOT NULL,
    NombreUsuario VARCHAR(50) NOT NULL,
    Contrasena VARCHAR(100) NOT NULL,
    Rol NVARCHAR(30) NOT NULL,
    NombreCompleto NVARCHAR(100) NOT NULL,
    CreatedBy NVARCHAR(50) NULL,
    CreatedAt DATETIME NULL DEFAULT GETDATE(),
    ModifiedBy NVARCHAR(50) NULL,
    ModifiedAt DATETIME NULL,
    CONSTRAINT PK_Usuario PRIMARY KEY (ID_Usuario),
    CONSTRAINT UQ_Usuario_NombreUsuario UNIQUE (NombreUsuario)
);
GO

INSERT INTO Usuario (NombreUsuario, Contrasena, Rol, NombreCompleto) VALUES
('admin', '123', 'Administrador', 'Administrador General'),
('recepcion', '123', 'Recepcionista', 'Recepcionista Taller');
GO

INSERT INTO Cliente (DNI_RUC, Nombre, Telefono, Direccion) VALUES
('45821934', 'Juan Carlos Quispe', '984512304', 'Av. Tomas Valle 420'),
('41908372', 'Rosa Maria Flores', '976234815', 'Jr. Huaylas 318'),
('72410956', 'Jorge Luis Mendoza', '991845203', 'Av. La Marina 1450'),
('47293018', 'Carmen Rosa Vargas', '955412980', 'Calle Los Pinos 215'),
('70384912', 'Pedro Antonio Castillo', '942781306', 'Av. Aviacion 2340');
GO

INSERT INTO Vehiculo (ID_Cliente, Placa, Marca, Modelo, Anio) VALUES
(1, 'A4B-312', 'Toyota', 'Yaris', 2016),
(2, 'F5K-849', 'Hyundai', 'Accent', 2019),
(3, 'B2M-604', 'Kia', 'Rio', 2018),
(4, 'C7T-195', 'Nissan', 'Sentra', 2017),
(5, 'D9P-427', 'Chevrolet', 'Sail', 2020),
(1, 'E3R-518', 'Toyota', 'Corolla', 2021);
GO

INSERT INTO Mecanico (Nombre, Especialidad, Telefono) VALUES
('Marco Antonio Paredes', 'Mecanica General', '981245670'),
('Segundo Torres', 'Frenos', '974512039'),
('Ricardo Huaman', 'Motor', '963201845'),
('Victor Hugo Salazar', 'Mecanica General', '958741230');
GO

INSERT INTO Repuesto (Codigo, Nombre, Marca, Precio, Stock, StockMinimo) VALUES
('REP-001', 'Filtro de aceite', 'Bosch', 35.00, 14, 5),
('REP-002', 'Pastillas de freno delanteras', 'Brembo', 95.00, 10, 4),
('REP-003', 'Bujias x4', 'NGK', 60.00, 3, 5),
('REP-004', 'Aceite sintetico 5W30', 'Castrol', 110.00, 8, 4),
('REP-005', 'Faja de alternador', 'Gates', 75.00, 2, 4),
('REP-006', 'Filtro de aire', 'Mann', 40.00, 12, 5);
GO

INSERT INTO OrdenServicio (ID_Vehiculo, ID_Mecanico, Fecha, Descripcion, Estado, ManoObra, Total) VALUES
(1, 1, '2026-11-04T09:30:00', 'Cambio de aceite y filtro de aceite', 'Entregado', 80.00, 225.00),
(2, 2, '2026-11-10T14:15:00', 'Cambio de pastillas de freno delanteras', 'Terminado', 100.00, 195.00),
(1, 3, '2026-11-18T11:00:00', 'Afinamiento de motor y cambio de bujias', 'Entregado', 140.00, 240.00),
(3, 4, '2026-11-22T16:00:00', 'Revision de sistema de carga y faja', 'En Proceso', 90.00, 165.00),
(4, 1, '2026-11-25T10:20:00', 'Diagnostico general de suspension', 'Pendiente', 70.00, 70.00);
GO

INSERT INTO Detalle_Repuesto (ID_Orden, ID_Repuesto, Cantidad, Subtotal) VALUES
(1, 1, 1, 35.00),
(1, 4, 1, 110.00),
(2, 2, 1, 95.00),
(3, 3, 1, 60.00),
(3, 6, 1, 40.00),
(4, 5, 1, 75.00);
GO

