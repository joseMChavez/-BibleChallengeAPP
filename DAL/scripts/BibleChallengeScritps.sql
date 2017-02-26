create table Participantes(
     ParticipanteId int identity(1,1) primary key,
	 EquipoId int References Equipos(EquipoId),
	 Nombres varchar(120),
	 Apodo varchar(40),
	 Genero int,
	 Fecha varchar(20)
	 
)
select * from Participantes
go

Create table Equipos(

EquipoId int identity(1,1) primary key,
Descripcion varchar(70)
)
go
create table Cuestionario( 
      CuestionarioId int identity(1,1) primary key,
	  Pregunta varchar(max),
	  Repuesta varchar(max),
	  RepuestaMalaA varchar(max),
	  RepuestaMalaB varchar(max),
	  RepuestaMalaC varchar(max),
	  Tipo int,
	  Etapa int
)go
create Table Tablero(
      TabletoId int identity(1,1) primary key,
	  EquipoId int references Equipos(EquipoId),
	  CuestionarioId int references Cuestionario(CuestionarioId),
	  Puntos int
	  )
	  select * from Cuestionario where Tipo=0 and Etapa=1
	  select * from Cuestionario