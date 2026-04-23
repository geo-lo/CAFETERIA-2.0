--Creamos la base de datos

CREATE DATABASE CafeteriaDB;
GO

--Seleccionamos la database a utilizar
USE CafeteriaDB;
GO

--Creamos las tablas necesarias para guardar los datos

--Tabla para almacenar los productos disponibles en la cafetería
CREATE TABLE Inventario (
IdProducto INT PRIMARY KEY IDENTITY(1,1),
NombreProducto	NVARCHAR(100) NOT NULL,
CantidadActual INT NOT NULL DEFAULT 0,
StockMinimo INT NOT NULL DEFAULT 5, --Alerta cuando queden pocos productos
PrecioUnitario DECIMAL(10,2) NOT NULL,
UltimaActualizacion DATETIME DEFAULT GETDATE()
);   
GO

--Tabla para almacenar los pedidos realizados por los clientes
CREATE TABLE Pedidos (
IdPedido INT PRIMARY KEY IDENTITY(1,1),
FechaRegisto DATETIME DEFAULT GETDATE(),
Estado NVARCHAR(50) NOT NULL DEFAULT 'Pendiente', --Pendiente, Completado
TotalPedido DECIMAL(10,2) NOT NULL DEFAULT 0.00
);
GO

--Tabla que conecta los pedidos con los productos de inventario, permitiendo registrar qué productos se han pedido y en qué cantidad
CREATE TABLE DetallesPedido (
IdDetalle INT PRIMARY KEY IDENTITY(1,1),
IdPedido INT FOREIGN KEY REFERENCES Pedidos(IdPedido),
IdProducto INT FOREIGN KEY REFERENCES Inventario(IdProducto),
Cantidad INT NOT NULL
);
GO

--Falta tabla para llevar control de ventas


--TRIGGERS
CREATE TRIGGER                   --Obtiene la fecha actual cada vez que se actualice el stock
trg_ActualizarFechaStock         --Sirve para mantener un registro de cuándo se actualizó por última vez el stock de un producto
ON Inventario
AFTER UPDATE
AS
BEGIN
    UPDATE Inventario
    SET UltimaActualizacion = GETDATE()
    FROM Inventario
    INNER JOIN inserted ON Inventario.IdProducto = inserted.IdProducto;
    END;
GO
