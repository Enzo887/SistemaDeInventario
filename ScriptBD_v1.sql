CREATE DATABASE S_Inventario
GO
USE S_Inventario
GO

CREATE TABLE Categoria(
	IdCategoria INT PRIMARY KEY IDENTITY(1,1),
	NombreCategoria VARCHAR(20)
)
GO
CREATE TABLE Producto(
	IdProducto INT PRIMARY KEY IDENTITY(1,1),
	NombreProducto VARCHAR(20),
	Precio DECIMAL(10,2),
	Cantidad INT,
	IdCategoria INT,
	FechaIngreso DATETIME,
	FechaVencimiento DATETIME,
	Activo BIT DEFAULT 1
	FOREIGN KEY (IdCategoria) REFERENCES Categoria(IdCategoria)
)
GO

CREATE TABLE Venta(
	IdVenta INT PRIMARY KEY IDENTITY(1,1),
	PrecioTotal DECIMAL(10,2),
	FechaVenta DATETIME,
	MetodoPago VARCHAR(20)
)
GO


CREATE TABLE DetalleVenta(
	IdDetalleVenta INT PRIMARY KEY IDENTITY(1,1),
	IdProducto INT,
	IdVenta INT,
	Cantidad INT,
	PrecioSubtotal DECIMAL(10,2)
	FOREIGN KEY (IdProducto) REFERENCES Producto(IdProducto),
	FOREIGN KEY (IdVenta) REFERENCES Venta(IdVenta)
)
GO
------------------------------------------------------------------
--STORE PROCEDURES
CREATE PROC SP_AgregarProductos
@NombreProducto VARCHAR(20),
@Precio DECIMAL(10,2),
@Cantidad INT,
@IdCategoria INT,
@FechaIngreso DATETIME,
@FechaVencimiento DATETIME
AS
BEGIN
	INSERT INTO Producto(NombreProducto,Precio,Cantidad,IdCategoria,FechaIngreso,FechaVencimiento)
	VALUES(@NombreProducto,@Precio,@Cantidad,@IdCategoria,@FechaIngreso,@FechaVencimiento);
END
GO

CREATE PROC SP_AgregarCategoria
@NombreCategoria VARCHAR(20)
AS
BEGIN
	INSERT INTO Categoria(NombreCategoria)
	VALUES(@NombreCategoria);
END
GO

CREATE PROC SP_BuscarCategoriaDuplicada
@NombreCategoria VARCHAR(20)
AS
BEGIN
	SELECT NombreCategoria FROM Categoria
	WHERE Categoria.NombreCategoria = @NombreCategoria;
END
GO

CREATE PROC SP_ActualizarCategoria
@NombreCategoria VARCHAR(20),
@IdCategoria INT
AS
BEGIN
	UPDATE Categoria SET NombreCategoria = @NombreCategoria
	WHERE IdCategoria = @IdCategoria;
END
GO

CREATE PROC SP_EliminarCategoria
@IdCategoria INT
AS
BEGIN
	DELETE FROM Categoria WHERE IdCategoria = @IdCategoria; 
END
GO

CREATE PROC SP_RegistrarVenta
@PrecioTotal DECIMAL(10,2),
@FechaVenta DATETIME,
@MetodoPago VARCHAR(20),
@Venta_ID INT OUTPUT
AS
BEGIN
	INSERT INTO Venta(PrecioTotal,FechaVenta,MetodoPago) VALUES(@PrecioTotal,@FechaVenta,@MetodoPago);
	SET @Venta_ID = SCOPE_IDENTITY();
END
GO

CREATE PROC SP_GuardarDetalleVenta
@IdProducto INT,
@IdVenta INT,
@Cantidad INT,
@PrecioSubtotal DECIMAL(10,2)
AS
BEGIN
	INSERT INTO DetalleVenta(IdProducto,IdVenta,Cantidad,PrecioSubtotal) VALUES (@IdProducto,@IdVenta,@Cantidad,@PrecioSubtotal)
END
GO

CREATE PROC SP_CategoriaTieneProducto
@idCategoria VARCHAR(20)
AS
BEGIN
	SELECT IdProducto,NombreProducto,Precio,Cantidad,c.NombreCategoria AS NombreCategoria, c.IdCategoria AS IdCategoria,FechaVencimiento FROM Producto p
	JOIN Categoria c
	ON c.IdCategoria = p.IdCategoria
	WHERE C.IdCategoria = @idCategoria;
END
GO

CREATE PROC SP_EliminarProducto
@IdProducto INT
AS
BEGIN
	UPDATE Producto SET Activo = 0 WHERE IdProducto = @IdProducto;
END
GO

CREATE PROC SP_BuscarProductoDuplicado
@NombreProducto VARCHAR(20)
AS
BEGIN
	SELECT NombreProducto FROM Producto
	WHERE Producto.NombreProducto = @NombreProducto;
END
GO

CREATE PROC SP_ActualizarProducto
@idProducto INT,
@NombreProducto VARCHAR(20),
@Precio DECIMAL(10,2),
@Cantidad INT,
@idCategoria INT,
@FechaVencimiento DATETIME,
@Activo BIT
AS
BEGIN
	UPDATE Producto SET NombreProducto = @NombreProducto, Precio = @Precio, Cantidad = @Cantidad,IdCategoria = @idCategoria, FechaVencimiento = @FechaVencimiento, Activo = @Activo
	WHERE IdProducto = @idProducto;
END
GO

CREATE PROCEDURE SP_ObtenerProductos
@incluirEliminados BIT
AS
BEGIN
    SELECT 
        p.IdProducto,
        p.NombreProducto,
        p.Precio,
        p.Cantidad,
        c.NombreCategoria AS NombreCategoria,
        c.IdCategoria,
        p.FechaVencimiento,
        p.Activo
    FROM Producto p
    JOIN Categoria c ON c.IdCategoria = p.IdCategoria
    WHERE (@incluirEliminados = 1 OR p.Activo = 1);
END
GO

CREATE PROC SP_BuscarFechaDia
@fechaBuscada DATETIME
AS
BEGIN
	SELECT * FROM Venta WHERE CAST(FechaVenta AS DATE) = CAST(@fechaBuscada AS DATE);
END
GO

CREATE PROC SP_BuscarDetalleVenta
@ventaID INT
AS
BEGIN
	SELECT 
		IdDetalleVenta,
		p.NombreProducto AS NombreProducto,
		p.Precio AS PrecioProducto,
		dv.Cantidad AS CantidadProducto,		
		dv.PrecioSubtotal AS PrecioSubtotal 
	FROM DetalleVenta dv 
	JOIN Producto p ON dv.IdProducto = p.IdProducto
	WHERE dv.IdVenta = @ventaID;
END
GO
------------------------------------------------------------------
--VISTAS

CREATE VIEW V_ObtenerCategorias
AS
	SELECT * FROM Categoria;
GO

CREATE VIEW V_ObtenerVentas
AS
	SELECT * FROM Venta;
GO

