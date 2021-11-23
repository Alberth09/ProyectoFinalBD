create database CampeonatoAje;

create table Pais(
Pais varchar(50) primary key,
NombreP varchar(50),
N_Clubes int,
FkPais varchar(50),
foreign key (FkPais) references Pais (Pais));

create table Participantes(
ID int primary key,
Nombre varchar(50),
Direccion varchar(50),
Telefono varchar(50),
Tipo enum('jugador','arbitro'),
Campeonato varchar(50),
fkPais varchar(50),
foreign key (fkPais) references Pais (Pais)
);

create table Turno(
Tipo enum('jugador','arbitro'),
fkID int,
fkMov int,
foreign key (fkID) references Participantes (ID),
foreign key (fkMov) references Movimiento (IDMov)
);

create table Jugada(
fkID int, 
Movimiento varchar(50),
Color varchar(50),
foreign key (fkID) references Participantes (ID)
);

create table Partida(
CodPart int primary key,
Fecha date,
Jornada varchar(50),
fkNombreH varchar(50),
foreign key (fkNombreH) references Hotel (NombreH)
);

create table Movimiento(
IDMov int, 
IDPar int, 
Movimientos varchar(50),
Comentarios varchar(50),
Jugada varchar(50),
Primary key (IDMov,IDPar)
);

create table Hotel(
NombreH varchar(50) primary key,
DireccionH varchar(50),
TelefonoH varchar(50),
Entrada date,
Salida date,
fkID int,
foreign key (FkID) references Participantes (ID)
);

create table Sala(
ID int primary key auto_increment,
Medios varchar(50),
Capacidad int,
Entradas varchar(50),
FkNombreH varchar(50),
foreign key (FkNombreH) references Hotel (NombreH));
