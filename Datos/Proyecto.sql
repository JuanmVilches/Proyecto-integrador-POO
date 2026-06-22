DROP DATABASE IF EXISTS Proyecto;
CREATE DATABASE Proyecto;
USE Proyecto;

CREATE TABLE Alumno (
    identificador INT PRIMARY KEY AUTO_INCREMENT,
    documento INT unique NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    esSocio BOOLEAN NOT NULL DEFAULT FALSE,
    apto_fisico BOOLEAN,
    actividad VARCHAR(30)
);

CREATE TABLE Pago (
    id_pago INT PRIMARY KEY AUTO_INCREMENT,
    periodoInicio DATE NOT NULL,
    periodoFin DATE NOT NULL,
    identificadorAlumno INT NOT NULL,
    FOREIGN KEY (identificadorAlumno) REFERENCES Alumno(identificador)
);

CREATE TABLE Usuario (
    identificador INT PRIMARY KEY AUTO_INCREMENT,
    usuario VARCHAR(50) NOT NULL UNIQUE,
    clave VARCHAR(50) NOT NULL
);

-- Usuario elemplo
INSERT INTO Usuario (usuario, clave) VALUES
('usuario', '123456');

-- Alumno de ejemplo
INSERT INTO Alumno (documento, nombre, apellido, esSocio, apto_fisico, actividad) VALUES
(11001001, "Pedro", "Martinez", 0, 1, "Futbol"),
(12002002, "Marta", "Pérez", 1, 1, "Basquet"),
(13003003, "Joaquín", "Gomez", 0, 1, "Gimnasio"),
(14004004, "Juan", "Fernandez", 1, 1, "Natacion");

-- Pagos de ejemplo
INSERT INTO Pago (periodoInicio, periodoFin, identificadorAlumno) VALUES
(CURDATE(),CURDATE(),1),
(CURDATE(),CURDATE(),2);

-- INICIO STORED PROCEDURES --
DELIMITER $

-- Validar un usuario contra la base de datos
CREATE PROCEDURE Ingresar(in p_usuario varchar(50),in p_clave varchar(50))
BEGIN
	SELECT usuario FROM Usuario u WHERE u.usuario = p_usuario AND u.clave = p_clave;
END$

--- Leer la lista de alumnos (socios + no-socios)
CREATE PROCEDURE LeerAlumnos()
BEGIN
    SELECT a.documento, a.identificador, a.nombre, a.apellido, a.esSocio, a.apto_fisico, a.actividad,
           (SELECT MAX(p.periodoFin) FROM Pago p WHERE p.identificadorAlumno = a.identificador) AS vencimiento
    FROM Alumno a;
END$

-- Agregar un nuevo alumno
CREATE PROCEDURE CrearAlumno(
    in p_documento int,
    in p_nombre VARCHAR(100),
    in p_apellido VARCHAR(100),
    in p_esSocio BOOLEAN,
    in p_apto_fisico BOOLEAN,
    in p_actividad VARCHAR(30)
)
BEGIN
    INSERT INTO Alumno (documento, nombre, apellido, esSocio, apto_fisico, actividad)
    VALUES (p_documento, p_nombre, p_apellido, p_esSocio, p_apto_fisico, p_actividad);
    SELECT LAST_INSERT_ID() AS identificador;
END$

-- Agregar un nuevo pago
CREATE PROCEDURE RegistrarPago(IN p_inicio DATE, IN p_fin DATE, IN p_alumno INT)
BEGIN
	INSERT INTO Pago(periodoInicio, periodoFin, identificadorAlumno)
    VALUES(p_inicio, p_fin, p_alumno);
END$

-- Leer vencimientos de hoy
CREATE PROCEDURE LeerVencimientosHoy()
BEGIN
    SELECT
        a.identificador,
        a.documento,
        a.nombre,
        a.apellido,
        a.actividad,
        MAX(p.periodoFin) AS vencimiento
    FROM Alumno a
    INNER JOIN Pago p
        ON a.identificador = p.identificadorAlumno
	WHERE a.esSocio = true
    GROUP BY
        a.identificador,
        a.documento,
        a.nombre,
        a.apellido,
        a.actividad
    HAVING DATE(MAX(p.periodoFin)) = CURDATE();
END$

--- FIN STORED PROCEDURES ---
DELIMITER ;
