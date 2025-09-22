CREATE DATABASE Tematika;
GO

USE Tematika;
GO

-- Tabla: perfil
CREATE TABLE perfil (
    id_perfil INT IDENTITY(1,1),
    nombre_perfil NVARCHAR(50) NOT NULL,
    descripcion NVARCHAR(255),
    CONSTRAINT PK_Perfil PRIMARY KEY (id_perfil)
);

-- Tabla: usuario
CREATE TABLE usuario (
    id_usuario INT IDENTITY(1,1),
    dni INT NOT NULL,
    nombre NVARCHAR(100) NOT NULL,
    apellido NVARCHAR(100) NOT NULL,
    correo NVARCHAR(100) NOT NULL,
    fecha_registro DATETIME CONSTRAINT DF_Usuario_FechaRegistro DEFAULT (GETDATE()),
    id_perfil INT NOT NULL,
    contrasena_hash NVARCHAR(255) NOT NULL,
    sexo CHAR(1) NOT NULL,
    eliminado BIT CONSTRAINT DF_Usuario_Eliminado DEFAULT (0),
    CONSTRAINT PK_Usuario PRIMARY KEY (id_usuario),
    CONSTRAINT UQ_Usuario_dni UNIQUE (dni),
    CONSTRAINT UQ_Usuario_Correo UNIQUE (correo),
    CONSTRAINT FK_Usuario_Perfil FOREIGN KEY (id_perfil) REFERENCES perfil(id_perfil),
    CONSTRAINT CK_Usuario_Sexo CHECK (sexo IN ('f', 'm'))
);

-- Tabla: suscripcion
CREATE TABLE suscripcion (
    id_suscripcion INT IDENTITY(1,1),
    id_usuario INT NOT NULL,
    activa BIT NOT NULL,
    fecha_inicio DATETIME CONSTRAINT DF_Suscripcion_Fecha_Inicio DEFAULT (GETDATE()) NOT NULL,
    fecha_fin DATETIME,
    CONSTRAINT PK_Suscripcion PRIMARY KEY (id_suscripcion),
    CONSTRAINT FK_Suscripcion_Usuario FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario),
    CONSTRAINT CK_Suscripcion_Control_Fecha CHECK (fecha_fin IS NULL OR fecha_inicio <= fecha_fin)
);

-- Tabla: materia
CREATE TABLE materia (
    id_materia INT IDENTITY(1,1),
    nombre NVARCHAR(100) NOT NULL,
    nivel NVARCHAR(50),
    descripcion NVARCHAR(MAX),
    eliminado BIT CONSTRAINT DF_Materia_Eliminado DEFAULT (0),
    CONSTRAINT PK_Materia PRIMARY KEY (id_materia)
);

-- Tabla: tema
CREATE TABLE tema (
    id_tema INT IDENTITY(1,1),
    nombre NVARCHAR(100) NOT NULL,
    id_materia INT NOT NULL,
    eliminado BIT CONSTRAINT DF_Tema_Eliminado DEFAULT (0),
    CONSTRAINT PK_Tema PRIMARY KEY (id_tema),
    CONSTRAINT FK_Tema_Materia FOREIGN KEY (id_materia) REFERENCES materia(id_materia)
);

-- Tabla: evaluacion
CREATE TABLE evaluacion (
    id_evaluacion INT IDENTITY(1,1),
    id_tema INT NOT NULL,
    eliminado BIT CONSTRAINT DF_Evaluacion_Eliminado DEFAULT (0),
    CONSTRAINT PK_Evaluacion PRIMARY KEY (id_evaluacion),
    CONSTRAINT UQ_Evaluacion_IdTema UNIQUE (id_tema),
    CONSTRAINT FK_Evaluacion_Tema FOREIGN KEY (id_tema) REFERENCES tema(id_tema)
);

-- Tabla: pregunta
CREATE TABLE pregunta (
    id_pregunta INT IDENTITY(1,1),
    enunciado NVARCHAR(MAX) NOT NULL,
    opcion_correcta NVARCHAR(MAX) NOT NULL,
    id_evaluacion INT NOT NULL,
    CONSTRAINT PK_Pregunta PRIMARY KEY (id_pregunta),
    CONSTRAINT FK_Pregunta_Evaluacion FOREIGN KEY (id_evaluacion) REFERENCES evaluacion(id_evaluacion)
);

-- Tabla: recurso
CREATE TABLE recurso (
    id_recurso INT IDENTITY(1,1),
    titulo NVARCHAR(255) NOT NULL,
    texto NVARCHAR(MAX),
    imagen_ruta NVARCHAR(255),
    url NVARCHAR(MAX),
    tipo NVARCHAR(50) NOT NULL,
    fecha_creacion DATETIME CONSTRAINT DF_Recurso_FechaCreacion DEFAULT (GETDATE()),
    fecha_modificacion DATETIME CONSTRAINT DF_Recurso_FechaModificacion DEFAULT (GETDATE()),
    id_tema INT NOT NULL,
    eliminado BIT CONSTRAINT DF_Recurso_Eliminado DEFAULT (0),
    CONSTRAINT PK_Recurso PRIMARY KEY (id_recurso),
    CONSTRAINT FK_Recurso_Tema FOREIGN KEY (id_tema) REFERENCES tema(id_tema)
);

-- Tabla: nota
CREATE TABLE nota (
    id_nota INT IDENTITY(1,1),
    texto NVARCHAR(MAX) NOT NULL,
    fecha DATETIME CONSTRAINT DF_Nota_Fecha DEFAULT (GETDATE()),
    id_usuario INT NOT NULL,
    id_recurso INT NOT NULL,
    eliminado BIT CONSTRAINT DF_Nota_Eliminado DEFAULT (0),
    CONSTRAINT PK_Nota PRIMARY KEY (id_nota),
    CONSTRAINT FK_Nota_Usuario FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario),
    CONSTRAINT FK_Nota_Recurso FOREIGN KEY (id_recurso) REFERENCES recurso(id_recurso)
);

-- Tabla: favorito
CREATE TABLE favorito (
    id_favorito INT IDENTITY(1,1),
    fecha_marcado DATETIME CONSTRAINT DF_Favorito_FechaMarcado DEFAULT (GETDATE()),
    id_usuario INT NOT NULL,
    id_recurso INT NOT NULL,
    eliminado BIT CONSTRAINT DF_Favorito_Eliminado DEFAULT (0),
    CONSTRAINT PK_Favorito PRIMARY KEY (id_favorito),
    CONSTRAINT FK_Favorito_Usuario FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario),
    CONSTRAINT FK_Favorito_Recurso FOREIGN KEY (id_recurso) REFERENCES recurso(id_recurso)
);

-- Tabla: visita_recurso
CREATE TABLE visita_recurso (
    id_visita INT IDENTITY(1,1),
    fecha_hora DATETIME CONSTRAINT DF_VisitaRecurso_FechaHora DEFAULT (GETDATE()),
    id_usuario INT NOT NULL,
    id_recurso INT NOT NULL,
    CONSTRAINT PK_VisitaRecurso PRIMARY KEY (id_visita),
    CONSTRAINT FK_VisitaRecurso_Usuario FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario),
    CONSTRAINT FK_VisitaRecurso_Recurso FOREIGN KEY (id_recurso) REFERENCES recurso(id_recurso)
);

-- Tabla: valoracion
CREATE TABLE valoracion (
    id_valoracion INT IDENTITY(1,1),
    puntuacion INT NOT NULL CONSTRAINT CK_Valoracion_Puntuacion CHECK (puntuacion >= 1 AND puntuacion <= 5),
    fecha DATETIME CONSTRAINT DF_Valoracion_Fecha DEFAULT (GETDATE()),
    id_usuario INT NOT NULL,
    id_recurso INT NOT NULL,
    CONSTRAINT PK_Valoracion PRIMARY KEY (id_valoracion),
    CONSTRAINT FK_Valoracion_Usuario FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario),
    CONSTRAINT FK_Valoracion_Recurso FOREIGN KEY (id_recurso) REFERENCES recurso(id_recurso)
);

-- Tabla: comentario
CREATE TABLE comentario (
    id_comentario INT IDENTITY(1,1),
    texto NVARCHAR(MAX) NOT NULL,
    fecha DATETIME CONSTRAINT DF_Comentario_Fecha DEFAULT (GETDATE()),
    id_usuario INT NOT NULL,
    id_recurso INT NOT NULL,
    CONSTRAINT PK_Comentario PRIMARY KEY (id_comentario),
    CONSTRAINT FK_Comentario_Usuario FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario),
    CONSTRAINT FK_Comentario_Recurso FOREIGN KEY (id_recurso) REFERENCES recurso(id_recurso)
);

-- Tabla: intento
CREATE TABLE intento (
    id_intento INT IDENTITY(1,1),
    fecha DATETIME CONSTRAINT DF_Intento_Fecha DEFAULT (GETDATE()),
    respuesta NVARCHAR(MAX) NOT NULL,
    correcta BIT NOT NULL,
    id_usuario INT NOT NULL,
    id_pregunta INT NOT NULL,
    CONSTRAINT PK_Intento PRIMARY KEY (id_intento),
    CONSTRAINT FK_Intento_Usuario FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario),
    CONSTRAINT FK_Intento_Pregunta FOREIGN KEY (id_pregunta) REFERENCES pregunta(id_pregunta)
);

-- Tabla: log_accion
CREATE TABLE log_accion (
    id_log INT IDENTITY(1,1),
    fecha_hora DATETIME CONSTRAINT DF_LogAccion_FechaHora DEFAULT (GETDATE()),
    id_usuario INT,
    tipo_accion NVARCHAR(100) NOT NULL,
    entidad NVARCHAR(100),
    id_entidad INT,
    CONSTRAINT PK_LogAccion PRIMARY KEY (id_log),
    CONSTRAINT FK_LogAccion_Usuario FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario)
);

-- Tabla: docente_materia
CREATE TABLE docente_materia (
    id_docente_materia INT IDENTITY(1,1),
    id_usuario INT NOT NULL,
    id_materia INT NOT NULL,
    CONSTRAINT PK_DocenteMateria PRIMARY KEY (id_docente_materia),
    CONSTRAINT FK_DocenteMateria_Usuario FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario),
    CONSTRAINT FK_DocenteMateria_Materia FOREIGN KEY (id_materia) REFERENCES materia(id_materia)
);

-- Datos iniciales en perfil
INSERT INTO perfil (nombre_perfil, descripcion)
VALUES
    ('admin', 'Perfil con acceso total al sistema: gestión de usuarios, materias, recursos y trazabilidad.'),
    ('docente', 'Perfil para docentes: permite gestionar materias, temas, recursos y evaluaciones.'),
    ('estudiante', 'Perfil para estudiantes: acceso a materias, temas, recursos, evaluaciones y participación académica.'),
    --('invitado', 'Perfil de invitado: acceso limitado a recursos, sin participación ni personalización.'),
    ('superadmin', 'Perfil con privilegios máximos: puede gestionar y modificar cualquier usuario, incluyendo administradores.');

-- Usuario principal superadmin
INSERT INTO usuario (
    dni,
    nombre,
    apellido,
    correo,
    id_perfil,
    contrasena_hash,
    sexo,
    eliminado
)
VALUES (
    99999999,
    'Super',
    'Admin',
    'superadmin@gmail.com',
    4,
    'A6xnQhbz4Vx2HuGl4lXwZ5U2I8iziLRFnhP5eNfIRvQ=',
    'm',
    0
);

-- Usuarios adicionales por rol
INSERT INTO usuario (
    dni,
    nombre,
    apellido,
    correo,
    id_perfil,
    contrasena_hash,
    sexo,
    eliminado
)
VALUES
(46460672, 'Luana', 'Lopez', 'luana@gmail.com', 1, 'A6xnQhbz4Vx2HuGl4lXwZ5U2I8iziLRFnhP5eNfIRvQ=', 'f', 0),
(43234234, 'Ignacio', 'Navarro', 'ignacio@gmail.com', 2, 'A6xnQhbz4Vx2HuGl4lXwZ5U2I8iziLRFnhP5eNfIRvQ=', 'm', 0),
(38963397, 'Juan', 'Miño', 'juan@gmail.com', 3, 'A6xnQhbz4Vx2HuGl4lXwZ5U2I8iziLRFnhP5eNfIRvQ=', 'm', 0);
