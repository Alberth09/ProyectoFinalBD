DROP DATABASE IF EXISTS clubAjedrez;
CREATE DATABASE clubAjedrez;
USE clubAjedrez;

CREATE TABLE pais(
idPais INT PRIMARY KEY,
nombre VARCHAR(50),
noClubes INT,
representa INT,
FOREIGN KEY(representa) REFERENCES pais(idpais) ON DELETE CASCADE);

CREATE TABLE participante(
idParticipante INT,
nombre VARCHAR(50),
direccion VARCHAR(50),
telefono VARCHAR(50),
campeonato VARCHAR(50),
tipo ENUM('Jugador','Árbitro'),
nivel VARCHAR(2),
fkidPais INT,
FOREIGN KEY(fkidPais) REFERENCES pais(idPais),
PRIMARY KEY(idParticipante,campeonato));

CREATE TABLE hotel(
idHotel INT PRIMARY KEY,
nombre VARCHAR(50),
direccion VARCHAR(50),
telefono VARCHAR(50));

CREATE TABLE hospedaje(
idHospedaje INT PRIMARY KEY,
fkidParticipante INT,
fkcampeonato VARCHAR(50),
fkidHotel INT,
fechaEntrada date,
fechaSalida date,
FOREIGN KEY(fkidParticipante,fkcampeonato) REFERENCES participante(idParticipante,campeonato),
FOREIGN KEY(fkidHotel) REFERENCES hotel(idHotel));

CREATE TABLE sala(
idSala INT PRIMARY KEY,
fkidHotel INT,
codigoSala VARCHAR(50),
capacidad INT,
medios VARCHAR(200),
FOREIGN KEY(fkidHotel) REFERENCES hotel(idHotel) ON DELETE CASCADE);

CREATE TABLE partida(
idPartida INT,
codigoPartida VARCHAR(50),
jornada date,
fkidArbitro INT,
fkidSala INT,
entradas INT,
FOREIGN KEY(fkidArbitro) REFERENCES participante(idParticipante),
FOREIGN KEY(fkidSala) REFERENCES sala(idSala),
PRIMARY KEY(idPartida,jornada));

CREATE TABLE rol(
fkidPartida INT,
fkjornada DATE,
fkidParticipante INT,
color ENUM('Blancas','Negras'),
FOREIGN KEY(fkidParticipante) REFERENCES participante(idParticipante),
FOREIGN KEY(fkidPartida,fkjornada) REFERENCES partida(idPartida,jornada),
PRIMARY KEY(fkidPartida,fkjornada,color));

CREATE TABLE movimiento(
idMovimiento INT, 
fkidPartida INT, 
fkjornada DATE,
movimiento VARCHAR(50),
jugada VARCHAR(50),
comentario VARCHAR(100),
FOREIGN KEY(fkidPartida,fkjornada) REFERENCES partida(idPartida,jornada) ON DELETE CASCADE,
PRIMARY KEY (idMovimiento,fkidPartida,fkjornada));
