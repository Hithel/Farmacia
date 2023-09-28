-- Datos ficticios para la tabla "cargo"
INSERT INTO `farmacia`.`cargo` (`cargo`) VALUES
  ('Gerente'),
  ('Farmacéutico'),
  ('Asistente de Ventas'),
  ('Recepcionista');

-- Datos ficticios para la tabla "categoria"
INSERT INTO `farmacia`.`categoria` (`nombre`) VALUES
  ('Analgésicos'),
  ('Antibióticos'),
  ('Antihistamínicos'),
  ('Vitaminas');

-- Datos ficticios para la tabla "pais"
INSERT INTO `farmacia`.`pais` (`nombre`) VALUES
  ('Estados Unidos'),
  ('Canadá'),
  ('México');

-- Datos ficticios para la tabla "departamento"
INSERT INTO `farmacia`.`departamento` (`Nombre`, `IdPaisFk`) VALUES
  ('California', 1),
  ('Ontario', 2),
  ('Jalisco', 3);

-- Datos ficticios para la tabla "ciudad"
INSERT INTO `farmacia`.`ciudad` (`nombre`, `IdDepartamentoFk`) VALUES
  ('Los Angeles', 1),
  ('Toronto', 2),
  ('Guadalajara', 3);

-- Datos ficticios para la tabla "tipodocumento"
INSERT INTO `farmacia`.`tipodocumento` (`Descripcion`) VALUES
  ('Cédula de Identidad'),
  ('Pasaporte'),
  ('Licencia de Conducir');

-- Datos ficticios para la tabla "tipopersona"
INSERT INTO `farmacia`.`tipopersona` (`Descripcion`) VALUES
  ('Natural'),
  ('Jurídica');

-- Datos ficticios para la tabla "proveedor"
INSERT INTO `farmacia`.`proveedor` (`Nombre`) VALUES
  ('Proveedor A'),
  ('Proveedor B'),
  ('Proveedor C');

-- Datos ficticios para la tabla "estado"
INSERT INTO `farmacia`.`estado` (`nombre`) VALUES
  ('Vigente'),
  ('Vencido'),
  ('Dañado');

-- Datos ficticios para la tabla "marca"
INSERT INTO `farmacia`.`marca` (`nombre`) VALUES
  ('Marca X'),
  ('Marca Y'),
  ('Marca Z');

-- Datos ficticios para la tabla "tipocontacto"
INSERT INTO `farmacia`.`tipocontacto` (`Descripcion`) VALUES
  ('Teléfono'),
  ('Correo Electrónico'),
  ('Fax');

-- Datos ficticios para la tabla "persona"
INSERT INTO `farmacia`.`persona` (`Nombre`, `FechaRegistro`, `IdTipoDocumentoFk`, `IdTipoPersonaFk`, `IdCargoFk`) VALUES
  ('Juan Pérez', NOW(), 1, 1, 2),
  ('María Rodríguez', NOW(), 2, 1, 3),
  ('Farmacia ABC', NOW(), 3, 2, 1);

-- Datos ficticios para la tabla "compraproveedor"
INSERT INTO `farmacia`.`compraproveedor` (`FechaCompra`, `IdProveedorFk`, `IdPersonaFk`) VALUES
  (NOW(), 1, 1),
  (NOW(), 2, 2),
  (NOW(), 3, 1);

-- Datos ficticios para la tabla "factura"
INSERT INTO `farmacia`.`factura` (`fecha`, `total`, `IdPersonaFk`, `IdDoctorFk`, `PersonaDoctorId`) VALUES
  (NOW(), 100.50, 1, 2, NULL),
  (NOW(), 75.25, 2, 1, 1),
  (NOW(), 120.00, 3, NULL, NULL);

-- Datos ficticios para la tabla "medicamento"
INSERT INTO `farmacia`.`medicamento` (`nombre`, `precio`, `stock`, `fechavencimiento`, `IdEstadoFK`, `EstadoReceta`, `IdCategoriaFK`, `IdMarcaFk`, `MedicamentoCompradoId`, `Presentacion`) VALUES
  ('Ibuprofeno', 10.00, 500, NOW(), 1, 0, 1, 1, NULL, 'Tabletas'),
  ('Amoxicilina', 15.50, 300, NOW(), 1, 0, 2, 2, NULL, 'Cápsulas'),
  ('Vitamina C', 5.75, 1000, NOW(), 1, 0, 4, 3, NULL, 'Tabletas efervescentes');

-- Datos ficticios para la tabla "medicamentocomprado"
INSERT INTO `farmacia`.`medicamentocomprado` (`IdCompraProveedorFk`, `IdMedicamentoFk`, `Cantidad`, `PrecioCompra`) VALUES
  (1, 1, 200, 8.50),
  (2, 2, 150, 12.00),
  (3, 3, 500, 4.50);

-- Datos ficticios para la tabla "receta"
INSERT INTO `farmacia`.`receta` (`IdDoctorFK`, `IdPacienteFK`, `FechaCrecion`, `FechaExpiracion`, `Descripcion`) VALUES
  (2, 1, NOW(), DATE_ADD(NOW(), INTERVAL 30 DAY), 'Dolor de cabeza'),
  (1, 2, NOW(), DATE_ADD(NOW(), INTERVAL 15 DAY), 'Infección respiratoria'),
  (NULL, 3, NOW(), DATE_ADD(NOW(), INTERVAL 45 DAY), 'Suplemento de vitaminas');

-- Datos ficticios para la tabla "medicamentovendido"
INSERT INTO `farmacia`.`medicamentovendido` (`IdMedicamentoFk`, `IdRecetaFk`, `IdFacturaFK`) VALUES
  (1, 1, 1),
  (2, 2, 1),
  (3, 3, 2);

-- Datos ficticios para la tabla "personacontacto"
INSERT INTO `farmacia`.`personacontacto` (`Contacto`, `IdPersonaFk`, `IdTipoContactoFk`) VALUES
  ('555-123-4567', 1, 1),
  ('juan.perez@example.com', 1, 2),
  ('416-789-1234', 2, 1);

-- Datos ficticios para la tabla "personadireccion"
INSERT INTO `farmacia`.`personadireccion` (`Descripcion`, `IdPersonaFk`, `IdCiudadFk`) VALUES
  ('Calle 123, Colonia ABC', 1, 1),
  ('Avenida XYZ #456', 2, 2),
  ('Av. Principal #789', 3, 3);

-- Datos ficticios para la tabla "proveedorcontacto"
INSERT INTO `farmacia`.`proveedorcontacto` (`Contacto`, `IdProveedorFk`, `IdTipoContactoFk`) VALUES
  ('800-987-6543', 1, 1),
  ('info@proveedorb.com', 
