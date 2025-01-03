BASE DE DATOS 
CREATE DATABASE GestorBD;
USE GestorBD;
CREATE TABLE Usuarios (
    idUsuario INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    correo VARCHAR(100) UNIQUE NOT NULL,
    telefono VARCHAR(15),
    contrasena VARCHAR(255) NOT NULL,
    estado ENUM('Activo', 'Inactivo') DEFAULT 'Activo',
    fechaRegistro TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
CREATE TABLE Roles (
    idRol INT AUTO_INCREMENT PRIMARY KEY,
    nombreRol VARCHAR(50) NOT NULL
);
CREATE TABLE UsuariosRoles (
    idUsuario INT,
    idRol INT,
    PRIMARY KEY (idUsuario, idRol),
    FOREIGN KEY (idUsuario) REFERENCES Usuarios(idUsuario) ON DELETE CASCADE,
    FOREIGN KEY (idRol) REFERENCES Roles(idRol) ON DELETE CASCADE
);
