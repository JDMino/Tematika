
--USAR CON SQL SERVER

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

-- Tabla: opcion_pregunta
CREATE TABLE opcion_pregunta (
    id_opcion INT IDENTITY(1,1),
    texto NVARCHAR(MAX) NOT NULL,
    es_correcta BIT NOT NULL DEFAULT 0,
    id_pregunta INT NOT NULL,
    CONSTRAINT PK_OpcionPregunta PRIMARY KEY (id_opcion),
    CONSTRAINT FK_OpcionPregunta_Pregunta FOREIGN KEY (id_pregunta) REFERENCES pregunta(id_pregunta)
);


-- Tabla: recurso
CREATE TABLE recurso (
    id_recurso INT IDENTITY(1,1),
    titulo NVARCHAR(255) NOT NULL,
    texto NVARCHAR(MAX),
    ruta NVARCHAR(255),
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


INSERT INTO materia (nombre, nivel, descripcion, eliminado)
VALUES
-- PRIMER AÑO
('Algoritmos y Estructuras de Datos I', 'Primer año', 'Fundamentos de programación y estructuras básicas', 0),
('Álgebra', 'Primer año', 'Operaciones algebraicas y estructuras matemáticas', 0),
('Algoritmos y Estructuras de Datos II', 'Primer año', 'Algoritmos avanzados y estructuras dinámicas', 0),
('Lógica y Matemática Computacional', 'Primer año', 'Formalización lógica y razonamiento computacional', 0),
('Sistemas y Organizaciones', 'Primer año', 'Introducción a sistemas organizacionales', 0),

-- SEGUNDO AÑO
('Paradigmas y Lenguajes', 'Segundo año', 'Estudio de paradigmas de programación', 0),
('Arquitectura y Organización de Computadoras', 'Segundo año', 'Estructura interna y funcionamiento de computadoras', 0),
('Cálculo Diferencial e Integral', 'Segundo año', 'Funciones, derivadas e integrales', 0),
('Programación Orientada a Objetos', 'Segundo año', 'Principios de POO y diseño orientado a objetos', 0),
('Sistemas Operativos', 'Segundo año', 'Gestión de recursos y procesos en sistemas operativos', 0),
('Administración y Gestión de Organizaciones', 'Segundo año', 'Teoría organizacional y gestión empresarial', 0),

-- TERCER AÑO
('Taller de Programación I', 'Tercer año', 'Desarrollo práctico de aplicaciones', 0),
('Comunicaciones de Datos', 'Tercer año', 'Protocolos y redes de comunicación', 0),
('Ingeniería de Software I', 'Tercer año', 'Modelado y ciclo de vida del software', 0),
('Taller de Programación II', 'Tercer año', 'Aplicaciones avanzadas y frameworks', 0),
('Probabilidad y Estadística', 'Tercer año', 'Análisis estadístico y probabilístico', 0),
('Bases de Datos I', 'Tercer año', 'Modelado relacional y consultas SQL', 0),
('Inglés Técnico Informático', 'Tercer año', 'Lectura y comprensión de textos técnicos en inglés', 0),

-- CUARTO AÑO
('Ingeniería de Software II', 'Cuarto año', 'Gestión de proyectos y calidad de software', 0),
('Economía Aplicada', 'Cuarto año', 'Principios económicos aplicados a sistemas', 0),
('Teoría de la Computación', 'Cuarto año', 'Lenguajes formales y autómatas', 0),
('Redes de Datos', 'Cuarto año', 'Diseño y administración de redes informáticas', 0),
('Bases de Datos II', 'Cuarto año', 'Optimización, transacciones y seguridad en BD', 0),
('Métodos Computacionales', 'Cuarto año', 'Algoritmos numéricos y simulación', 0),

-- QUINTO AÑO
('Proyecto Final de Carrera', 'Quinto año', 'Desarrollo e implementación de un proyecto integrador', 0),
('Auditoría y Seguridad Informática', 'Quinto año', 'Evaluación de sistemas y protección de la información', 0);

-- Primer Año
INSERT INTO tema (nombre, id_materia, eliminado) VALUES
('Variables y Tipos de Datos', 1, 0),
('Estructuras Secuenciales y Condicionales', 1, 0),
('Matrices y Determinantes', 2, 0),
('Espacios Vectoriales', 2, 0),
('Listas Enlazadas', 3, 0),
('Recursividad', 3, 0),
('Tablas de Verdad', 4, 0),
('Álgebra de Boole', 4, 0),
('Tipos de Sistemas', 5, 0),
('Estructura Organizacional', 5, 0);

-- Segundo Año
INSERT INTO tema (nombre, id_materia, eliminado) VALUES
('Paradigmas Imperativos', 6, 0),
('Paradigmas Funcionales', 6, 0),
('Unidad Central de Procesamiento', 7, 0),
('Memoria y Periféricos', 7, 0),
('Límites y Derivadas', 8, 0),
('Integrales Definidas', 8, 0),
('Encapsulamiento y Herencia', 9, 0),
('Interfaces y Polimorfismo', 9, 0),
('Gestión de Procesos', 10, 0),
('Sistemas de Archivos', 10, 0),
('Teoría Organizacional', 11, 0),
('Gestión Estratégica', 11, 0);

-- Tercer Año
INSERT INTO tema (nombre, id_materia, eliminado) VALUES
('Aplicaciones de Escritorio', 12, 0),
('Aplicaciones Web', 12, 0),
('Protocolos de Comunicación', 13, 0),
('Topologías de Red', 13, 0),
('Modelos de Desarrollo', 14, 0),
('Diagramas UML', 14, 0),
('Frameworks y Librerías', 15, 0),
('Patrones de Diseño', 15, 0),
('Distribuciones de Probabilidad', 16, 0),
('Inferencia Estadística', 16, 0),
('Modelo Relacional', 17, 0),
('Consultas SQL', 17, 0),
('Lectura Técnica', 18, 0),
('Traducción de Documentación', 18, 0);

-- Cuarto Año
INSERT INTO tema (nombre, id_materia, eliminado) VALUES
('Gestión de Proyectos', 19, 0),
('Control de Calidad', 19, 0),
('Microeconomía', 20, 0),
('Macroeconomía', 20, 0),
('Lenguajes Formales', 21, 0),
('Autómatas Finitos', 21, 0),
('Protocolos TCP/IP', 22, 0),
('Configuración de Redes', 22, 0),
('Normalización de Bases', 23, 0),
('Transacciones y Seguridad', 23, 0),
('Métodos Numéricos', 24, 0),
('Simulación Computacional', 24, 0);

-- Quinto Año
INSERT INTO tema (nombre, id_materia, eliminado) VALUES
('Definición del Proyecto', 25, 0),
('Implementación y Evaluación', 25, 0),
('Auditoría de Sistemas', 26, 0),
('Seguridad Informática', 26, 0);
