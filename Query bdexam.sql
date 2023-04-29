CREATE DATABASE Veterinaria;

USE Veterinaria;

CREATE TABLE Mae_Usuarios (
    Login_Usuario varchar(50) PRIMARY KEY,
    Clave_Usuario varchar(50) NOT NULL,
    Nombre_Usuario varchar(50) NOT NULL
);

INSERT INTO Mae_Usuarios (Login_Usuario, Clave_Usuario, Nombre_Usuario)
VALUES 
('Lmiguel', '120193', 'Luis Miguel'),
('Ccastro', '101214', 'Cristian Castro'),
('Jlopez', '151212', 'Jenifer Lopez');

CREATE TABLE Mae_Mascotas (
    ID_Mascota int PRIMARY KEY IDENTITY(1,1),
    Nombre_Mascota varchar(50) UNIQUE,
    Tipo_Mascota varchar(50),
    Comida_Favorita varchar(50)
);

INSERT INTO Mae_Mascotas (Nombre_Mascota, Tipo_Mascota, Comida_Favorita)
VALUES 
('Piolin', 'Ave', 'Semillas'),
('Nemo', 'Acuaticos', 'Planton'),
('Beethoven', 'Perro', 'Super Perro'),
('Silvester', 'Felino', 'Felino'),
('Rene', 'Rana', 'Rana'),
('Dory', 'Acuatico', 'Acuatico');

CREATE TABLE Control_Citas (
    ID_Cita int PRIMARY KEY IDENTITY(1,1),
    ID_Mascota int FOREIGN KEY REFERENCES Mae_Mascotas(ID_Mascota),
    Proxima_Fecha date,
    Medico_Asignado varchar(50)
);

INSERT INTO Control_Citas (ID_Mascota, Proxima_Fecha, Medico_Asignado)
VALUES 
(1, '2016-06-25', 'Dr. Ricardo Perez'),
(2, '2016-07-01', 'Dra. Flora'),
(3, '2016-06-24', 'Dra. Karla Moralez'),
(4, '2016-06-17', 'Dr. Carlos Castro'),
(5, '2016-07-30', 'Dra. Flora'),
(6, '2016-06-23', 'Dra. Maria Jose Aguilar');


CREATE PROCEDURE InsertarUsuario
    @loginUsuario varchar(50),
    @claveUsuario varchar(50),
    @nombreUsuario varchar(50)
AS
BEGIN
    INSERT INTO Mae_Usuarios (Login_Usuario, Clave_Usuario, Nombre_Usuario)
    VALUES (@loginUsuario, @claveUsuario, @nombreUsuario);
END

CREATE PROCEDURE ActualizarNombreUsuario
    @loginUsuario varchar(50),
    @nuevoNombreUsuario varchar(50)
AS
BEGIN
    UPDATE Mae_Usuarios
    SET Nombre_Usuario = @nuevoNombreUsuario
    WHERE Login_Usuario = @loginUsuario;
END

CREATE PROCEDURE ActualizarClaveUsuario
    @loginUsuario varchar(50),
    @nuevaClaveUsuario varchar(50)
AS
BEGIN
    UPDATE Mae_Usuarios
    SET Clave_Usuario = @nuevaClaveUsuario
    WHERE Login_Usuario = @loginUsuario;
END

CREATE PROCEDURE EliminarUsuario
    @loginUsuario varchar(50)
AS
BEGIN
    DELETE FROM Mae_Usuarios
    WHERE Login_Usuario = @loginUsuario;
END

CREATE PROCEDURE BuscarUsuarioPorLogin
    @loginUsuario varchar(50)
AS
BEGIN
    SELECT Login_Usuario, Clave_Usuario, Nombre_Usuario
    FROM Mae_Usuarios
    WHERE Login_Usuario = @loginUsuario;
END

CREATE PROCEDURE ValidarLogin
  @Email varchar(100) = '',
  @Password varchar(100) = ''
AS
BEGIN
  SELECT Email, Password
  FROM USERS
  WHERE Email = @Email AND Password = @Password
END

CREATE PROCEDURE VALIDAR_USUARIO
  @Email varchar(100) = '',
  @Password varchar(100) = ''
AS
BEGIN
  SELECT Email, Password
  FROM USERS
  WHERE Email = @Email AND Password = @Password
END