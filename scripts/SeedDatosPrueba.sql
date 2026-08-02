-- =============================================================================
-- SeedDatosPrueba.sql
-- Carga de datos de prueba para GestorInventarioDb, pensada para que las
-- capturas de pantalla del README salgan con la aplicación ya poblada.
--
-- Es seguro ejecutar este script varias veces: cada bloque valida si el dato
-- ya existe (por nombre/código/razón social/usuario) antes de insertarlo,
-- excepto el bloque de Movimientos, que se protege con un marcador único
-- ('[SEED-DEMO]' en Motivo) para no duplicarse en reejecuciones.
--
-- Requisito: correr las migraciones antes (dotnet ef database update) para
-- que las tablas ya existan.
-- =============================================================================

USE GestorInventarioDb;
GO

-- -----------------------------------------------------------------------------
-- 1. Categorías
-- -----------------------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM Categorias WHERE Nombre = N'Herramientas Manuales')
    INSERT INTO Categorias (Nombre, Descripcion) VALUES (N'Herramientas Manuales', N'Herramientas de mano para uso general y profesional');

IF NOT EXISTS (SELECT 1 FROM Categorias WHERE Nombre = N'Herramientas Eléctricas')
    INSERT INTO Categorias (Nombre, Descripcion) VALUES (N'Herramientas Eléctricas', N'Equipos y herramientas eléctricas portátiles');

IF NOT EXISTS (SELECT 1 FROM Categorias WHERE Nombre = N'Electricidad')
    INSERT INTO Categorias (Nombre, Descripcion) VALUES (N'Electricidad', N'Materiales e insumos eléctricos');

IF NOT EXISTS (SELECT 1 FROM Categorias WHERE Nombre = N'Plomería')
    INSERT INTO Categorias (Nombre, Descripcion) VALUES (N'Plomería', N'Caños, conexiones y accesorios sanitarios');

IF NOT EXISTS (SELECT 1 FROM Categorias WHERE Nombre = N'Pinturas y Accesorios')
    INSERT INTO Categorias (Nombre, Descripcion) VALUES (N'Pinturas y Accesorios', N'Pinturas, esmaltes y elementos de aplicación');
GO

-- -----------------------------------------------------------------------------
-- 2. Proveedores
-- -----------------------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM Proveedores WHERE RazonSocial = N'Ferretera del Sur S.A.')
    INSERT INTO Proveedores (RazonSocial, CUIT, Telefono, Email, Direccion, Activo)
    VALUES (N'Ferretera del Sur S.A.', N'30-71234567-8', N'011-4555-1234', N'ventas@ferreteradelsur.com.ar', N'Av. San Martín 1450, CABA', 1);

IF NOT EXISTS (SELECT 1 FROM Proveedores WHERE RazonSocial = N'Distribuidora Eléctrica Norte SRL')
    INSERT INTO Proveedores (RazonSocial, CUIT, Telefono, Email, Direccion, Activo)
    VALUES (N'Distribuidora Eléctrica Norte SRL', N'30-70988765-2', N'011-4678-9821', N'contacto@distrinorte.com.ar', N'Belgrano 875, San Martín', 1);

IF NOT EXISTS (SELECT 1 FROM Proveedores WHERE RazonSocial = N'Sanitarios del Plata S.A.')
    INSERT INTO Proveedores (RazonSocial, CUIT, Telefono, Email, Direccion, Activo)
    VALUES (N'Sanitarios del Plata S.A.', N'30-69887744-1', N'011-4321-5566', N'info@sanitariosdelplata.com', N'Ruta 8 Km 45, Pilar', 1);

IF NOT EXISTS (SELECT 1 FROM Proveedores WHERE RazonSocial = N'Pinturerías Color Total')
    INSERT INTO Proveedores (RazonSocial, CUIT, Telefono, Email, Direccion, Activo)
    VALUES (N'Pinturerías Color Total', N'30-65544332-9', N'011-4999-2211', N'contacto@colortotal.com.ar', N'Av. Rivadavia 3200, CABA', 0);
GO

-- -----------------------------------------------------------------------------
-- 3. Usuarios de prueba (además del administrador que ya tenés)
--    Contraseña de ambos: empleado123 (hash PBKDF2 generado con el mismo
--    esquema que usa PasswordHasher.cs: SHA256, 100.000 iteraciones).
-- -----------------------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM Usuarios WHERE NombreUsuario = N'mlopez')
    INSERT INTO Usuarios (NombreUsuario, PasswordHash, NombreCompleto, Rol, Activo)
    VALUES (N'mlopez', N'100000.2rTInHvznnoLYouuMV3qpQ==.vYFZAUrhQFGDaw12cIMf+PJNrYppPOERDfGoL1lTEKs=', N'Marcela López', N'Empleado', 1);

IF NOT EXISTS (SELECT 1 FROM Usuarios WHERE NombreUsuario = N'jperez')
    INSERT INTO Usuarios (NombreUsuario, PasswordHash, NombreCompleto, Rol, Activo)
    VALUES (N'jperez', N'100000.bP94WiTDWb/ZRZCsDxt4Wg==.OvedKlDPDBCUBn4G+o6lDpYgnYm4mEAg/vsYNLgvAsQ=', N'Juan Pérez', N'Empleado', 1);
GO

-- -----------------------------------------------------------------------------
-- 4. Productos
-- -----------------------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM Productos WHERE Codigo = N'HM-001')
    INSERT INTO Productos (Codigo, Nombre, Descripcion, CategoriaId, ProveedorId, PrecioCosto, PrecioVenta, StockActual, StockMinimo, Activo, FechaCreacion)
    VALUES (N'HM-001', N'Martillo Carpintero 20oz', N'Mango de fibra de vidrio, cabeza forjada', (SELECT Id FROM Categorias WHERE Nombre = N'Herramientas Manuales'), (SELECT Id FROM Proveedores WHERE RazonSocial = N'Ferretera del Sur S.A.'), 3200, 5500, 45, 10, 1, DATEADD(DAY, -60, GETDATE()));

IF NOT EXISTS (SELECT 1 FROM Productos WHERE Codigo = N'HM-002')
    INSERT INTO Productos (Codigo, Nombre, Descripcion, CategoriaId, ProveedorId, PrecioCosto, PrecioVenta, StockActual, StockMinimo, Activo, FechaCreacion)
    VALUES (N'HM-002', N'Destornillador Phillips Nº2', N'Punta magnética, mango ergonómico', (SELECT Id FROM Categorias WHERE Nombre = N'Herramientas Manuales'), (SELECT Id FROM Proveedores WHERE RazonSocial = N'Ferretera del Sur S.A.'), 850, 1500, 120, 20, 1, DATEADD(DAY, -60, GETDATE()));

IF NOT EXISTS (SELECT 1 FROM Productos WHERE Codigo = N'HM-003')
    INSERT INTO Productos (Codigo, Nombre, Descripcion, CategoriaId, ProveedorId, PrecioCosto, PrecioVenta, StockActual, StockMinimo, Activo, FechaCreacion)
    VALUES (N'HM-003', N'Alicate Universal 8"', N'Aislación 1000V, corte incluido', (SELECT Id FROM Categorias WHERE Nombre = N'Herramientas Manuales'), (SELECT Id FROM Proveedores WHERE RazonSocial = N'Ferretera del Sur S.A.'), 2100, 3800, 8, 15, 1, DATEADD(DAY, -45, GETDATE()));

IF NOT EXISTS (SELECT 1 FROM Productos WHERE Codigo = N'HM-004')
    INSERT INTO Productos (Codigo, Nombre, Descripcion, CategoriaId, ProveedorId, PrecioCosto, PrecioVenta, StockActual, StockMinimo, Activo, FechaCreacion)
    VALUES (N'HM-004', N'Serrucho de Costilla', N'Discontinuado por el proveedor', (SELECT Id FROM Categorias WHERE Nombre = N'Herramientas Manuales'), (SELECT Id FROM Proveedores WHERE RazonSocial = N'Ferretera del Sur S.A.'), 3500, 6200, 0, 5, 0, DATEADD(DAY, -90, GETDATE()));

IF NOT EXISTS (SELECT 1 FROM Productos WHERE Codigo = N'HE-001')
    INSERT INTO Productos (Codigo, Nombre, Descripcion, CategoriaId, ProveedorId, PrecioCosto, PrecioVenta, StockActual, StockMinimo, Activo, FechaCreacion)
    VALUES (N'HE-001', N'Taladro Percutor 1/2" 650W', N'Incluye maletín y 2 mandriles', (SELECT Id FROM Categorias WHERE Nombre = N'Herramientas Eléctricas'), (SELECT Id FROM Proveedores WHERE RazonSocial = N'Ferretera del Sur S.A.'), 28000, 45000, 12, 5, 1, DATEADD(DAY, -50, GETDATE()));

IF NOT EXISTS (SELECT 1 FROM Productos WHERE Codigo = N'HE-002')
    INSERT INTO Productos (Codigo, Nombre, Descripcion, CategoriaId, ProveedorId, PrecioCosto, PrecioVenta, StockActual, StockMinimo, Activo, FechaCreacion)
    VALUES (N'HE-002', N'Amoladora Angular 4.5" 750W', N'Disco de corte incluido', (SELECT Id FROM Categorias WHERE Nombre = N'Herramientas Eléctricas'), (SELECT Id FROM Proveedores WHERE RazonSocial = N'Ferretera del Sur S.A.'), 22000, 36000, 3, 5, 1, DATEADD(DAY, -50, GETDATE()));

IF NOT EXISTS (SELECT 1 FROM Productos WHERE Codigo = N'EL-001')
    INSERT INTO Productos (Codigo, Nombre, Descripcion, CategoriaId, ProveedorId, PrecioCosto, PrecioVenta, StockActual, StockMinimo, Activo, FechaCreacion)
    VALUES (N'EL-001', N'Cable Unipolar 2.5mm x100m', N'Normalizado IRAM', (SELECT Id FROM Categorias WHERE Nombre = N'Electricidad'), (SELECT Id FROM Proveedores WHERE RazonSocial = N'Distribuidora Eléctrica Norte SRL'), 45000, 68000, 25, 8, 1, DATEADD(DAY, -40, GETDATE()));

IF NOT EXISTS (SELECT 1 FROM Productos WHERE Codigo = N'EL-002')
    INSERT INTO Productos (Codigo, Nombre, Descripcion, CategoriaId, ProveedorId, PrecioCosto, PrecioVenta, StockActual, StockMinimo, Activo, FechaCreacion)
    VALUES (N'EL-002', N'Llave Térmica 25A', N'Curva C, riel DIN', (SELECT Id FROM Categorias WHERE Nombre = N'Electricidad'), (SELECT Id FROM Proveedores WHERE RazonSocial = N'Distribuidora Eléctrica Norte SRL'), 6500, 11000, 40, 10, 1, DATEADD(DAY, -40, GETDATE()));

IF NOT EXISTS (SELECT 1 FROM Productos WHERE Codigo = N'EL-003')
    INSERT INTO Productos (Codigo, Nombre, Descripcion, CategoriaId, ProveedorId, PrecioCosto, PrecioVenta, StockActual, StockMinimo, Activo, FechaCreacion)
    VALUES (N'EL-003', N'Toma Corriente Doble c/Tierra', N'Línea 10A, color blanco', (SELECT Id FROM Categorias WHERE Nombre = N'Electricidad'), (SELECT Id FROM Proveedores WHERE RazonSocial = N'Distribuidora Eléctrica Norte SRL'), 1200, 2400, 90, 20, 1, DATEADD(DAY, -40, GETDATE()));

IF NOT EXISTS (SELECT 1 FROM Productos WHERE Codigo = N'PL-001')
    INSERT INTO Productos (Codigo, Nombre, Descripcion, CategoriaId, ProveedorId, PrecioCosto, PrecioVenta, StockActual, StockMinimo, Activo, FechaCreacion)
    VALUES (N'PL-001', N'Caño PVC 110mm x3m', N'Uso cloacal', (SELECT Id FROM Categorias WHERE Nombre = N'Plomería'), (SELECT Id FROM Proveedores WHERE RazonSocial = N'Sanitarios del Plata S.A.'), 8500, 14000, 30, 10, 1, DATEADD(DAY, -35, GETDATE()));

IF NOT EXISTS (SELECT 1 FROM Productos WHERE Codigo = N'PL-002')
    INSERT INTO Productos (Codigo, Nombre, Descripcion, CategoriaId, ProveedorId, PrecioCosto, PrecioVenta, StockActual, StockMinimo, Activo, FechaCreacion)
    VALUES (N'PL-002', N'Codo PVC 90° 110mm', N'Uso cloacal', (SELECT Id FROM Categorias WHERE Nombre = N'Plomería'), (SELECT Id FROM Proveedores WHERE RazonSocial = N'Sanitarios del Plata S.A.'), 900, 1800, 60, 15, 1, DATEADD(DAY, -35, GETDATE()));

IF NOT EXISTS (SELECT 1 FROM Productos WHERE Codigo = N'PL-003')
    INSERT INTO Productos (Codigo, Nombre, Descripcion, CategoriaId, ProveedorId, PrecioCosto, PrecioVenta, StockActual, StockMinimo, Activo, FechaCreacion)
    VALUES (N'PL-003', N'Grifería Monocomando Cocina', N'Cromada, con rociador extraíble', (SELECT Id FROM Categorias WHERE Nombre = N'Plomería'), (SELECT Id FROM Proveedores WHERE RazonSocial = N'Sanitarios del Plata S.A.'), 32000, 52000, 6, 5, 1, DATEADD(DAY, -30, GETDATE()));

IF NOT EXISTS (SELECT 1 FROM Productos WHERE Codigo = N'PT-001')
    INSERT INTO Productos (Codigo, Nombre, Descripcion, CategoriaId, ProveedorId, PrecioCosto, PrecioVenta, StockActual, StockMinimo, Activo, FechaCreacion)
    VALUES (N'PT-001', N'Pintura Látex Interior 20L Blanco', N'Sin proveedor fijo asignado', (SELECT Id FROM Categorias WHERE Nombre = N'Pinturas y Accesorios'), NULL, 45000, 72000, 14, 6, 1, DATEADD(DAY, -25, GETDATE()));

IF NOT EXISTS (SELECT 1 FROM Productos WHERE Codigo = N'PT-002')
    INSERT INTO Productos (Codigo, Nombre, Descripcion, CategoriaId, ProveedorId, PrecioCosto, PrecioVenta, StockActual, StockMinimo, Activo, FechaCreacion)
    VALUES (N'PT-002', N'Rodillo de Lana 22cm', N'Pelo corto, para esmalte', (SELECT Id FROM Categorias WHERE Nombre = N'Pinturas y Accesorios'), NULL, 2200, 4000, 50, 15, 1, DATEADD(DAY, -25, GETDATE()));
GO

-- -----------------------------------------------------------------------------
-- 5. Movimientos de stock (historial de demo, protegido con marcador único)
-- -----------------------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM MovimientosStock WHERE Motivo LIKE N'%[SEED-DEMO]%')
BEGIN
    DECLARE @usuarioId INT = (SELECT TOP 1 Id FROM Usuarios WHERE NombreUsuario = N'mlopez');
    DECLARE @usuarioId2 INT = (SELECT TOP 1 Id FROM Usuarios WHERE NombreUsuario = N'jperez');

    INSERT INTO MovimientosStock (ProductoId, Tipo, Cantidad, Motivo, UsuarioId, Fecha) VALUES
    ((SELECT Id FROM Productos WHERE Codigo = N'HM-001'), N'Entrada', 50, N'Compra inicial [SEED-DEMO]', @usuarioId, DATEADD(DAY, -60, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'HM-001'), N'Salida', 5, N'Venta mostrador [SEED-DEMO]', @usuarioId2, DATEADD(DAY, -20, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'HM-002'), N'Entrada', 150, N'Compra a proveedor [SEED-DEMO]', @usuarioId, DATEADD(DAY, -60, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'HM-002'), N'Salida', 30, N'Venta mostrador [SEED-DEMO]', @usuarioId2, DATEADD(DAY, -15, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'HM-003'), N'Entrada', 20, N'Compra inicial [SEED-DEMO]', @usuarioId, DATEADD(DAY, -45, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'HM-003'), N'Salida', 12, N'Venta por mayor [SEED-DEMO]', @usuarioId2, DATEADD(DAY, -10, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'HM-004'), N'Entrada', 10, N'Compra inicial [SEED-DEMO]', @usuarioId, DATEADD(DAY, -90, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'HM-004'), N'Salida', 10, N'Liquidación por discontinuación [SEED-DEMO]', @usuarioId2, DATEADD(DAY, -80, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'HE-001'), N'Entrada', 15, N'Compra inicial [SEED-DEMO]', @usuarioId, DATEADD(DAY, -50, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'HE-001'), N'Salida', 3, N'Venta mostrador [SEED-DEMO]', @usuarioId2, DATEADD(DAY, -12, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'HE-002'), N'Entrada', 8, N'Compra inicial [SEED-DEMO]', @usuarioId, DATEADD(DAY, -50, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'HE-002'), N'Salida', 5, N'Venta mostrador [SEED-DEMO]', @usuarioId2, DATEADD(DAY, -8, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'EL-001'), N'Entrada', 30, N'Compra inicial [SEED-DEMO]', @usuarioId, DATEADD(DAY, -40, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'EL-001'), N'Salida', 5, N'Venta por mayor [SEED-DEMO]', @usuarioId2, DATEADD(DAY, -14, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'EL-002'), N'Entrada', 50, N'Compra inicial [SEED-DEMO]', @usuarioId, DATEADD(DAY, -40, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'EL-002'), N'Salida', 10, N'Venta mostrador [SEED-DEMO]', @usuarioId2, DATEADD(DAY, -9, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'EL-003'), N'Entrada', 100, N'Compra inicial [SEED-DEMO]', @usuarioId, DATEADD(DAY, -40, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'EL-003'), N'Salida', 10, N'Venta mostrador [SEED-DEMO]', @usuarioId2, DATEADD(DAY, -6, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'PL-001'), N'Entrada', 35, N'Compra inicial [SEED-DEMO]', @usuarioId, DATEADD(DAY, -35, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'PL-001'), N'Salida', 5, N'Venta mostrador [SEED-DEMO]', @usuarioId2, DATEADD(DAY, -5, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'PL-003'), N'Entrada', 10, N'Compra inicial [SEED-DEMO]', @usuarioId, DATEADD(DAY, -30, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'PL-003'), N'Salida', 4, N'Venta mostrador [SEED-DEMO]', @usuarioId2, DATEADD(DAY, -4, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'PT-001'), N'Entrada', 20, N'Compra inicial [SEED-DEMO]', @usuarioId, DATEADD(DAY, -25, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'PT-001'), N'Ajuste', 14, N'Ajuste por inventario físico [SEED-DEMO]', @usuarioId2, DATEADD(DAY, -2, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'PT-002'), N'Entrada', 55, N'Compra inicial [SEED-DEMO]', @usuarioId, DATEADD(DAY, -25, GETDATE())),
    ((SELECT Id FROM Productos WHERE Codigo = N'PT-002'), N'Salida', 5, N'Venta mostrador [SEED-DEMO]', @usuarioId2, DATEADD(DAY, -1, GETDATE()));
END
GO

PRINT N'Carga de datos de prueba finalizada.';
