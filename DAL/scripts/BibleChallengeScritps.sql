﻿create table Participantes(
     ParticipanteId int identity(1,1) primary key,
	 EquipoId int References Equipos(EquipoId),
	 Nombres varchar(120),
	 Apodo varchar(40),
	 Genero int,
	 Fecha Date,
	 FechaNacimiento DateTime
)

go

Create table Equipos(

EquipoId int identity(1,1) primary key,
Descripcion varchar(70)
)
select * from Equipos