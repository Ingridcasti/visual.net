SELECT * FROM `empleados` LIMIT 1000;
INSERT INTO `empleados` (`nombre`, `apellido`, `foto`) VALUES ('Ingrid', 'Castillo', 'Foto');
UPDATE `empleados` SET `nombre`='INGRID', `apellido`='CASTILLO' WHERE  `id`=1;
DELETE FROM `empleados` WHERE  `id`=1;
