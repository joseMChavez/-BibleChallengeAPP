create table Participantes(
     ParticipanteId int identity(1,1) primary key,
	 EquipoId int References Equipos(EquipoId),
	 Nombres varchar(120),
	 Apodo varchar(40),
	 Genero int,
	 Fecha varchar(20)
	 
)
drop table Participantes
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
	  select * from Tablero_view
	  --create view Tablero_view as
	  --select e.Descripcion as Equipos, SUM(t.Puntos) as Puntuacion from Tablero t inner join Equipos e on t.EquipoId=e.EquipoId group by e.Descripcion 
	  --ALter view Preguntas_view as
	  --select CuestionarioId As Numero, Pregunta,Repuesta,Estado =case WHEN Tipo =1 then 'No Realizada' else 'Realizada'  end from Cuestionario
	  --insert into Tablero(EquipoId,CuestionarioId,Puntos) values(1,1,3000)
	  --insert into Tablero(EquipoId,CuestionarioId,Puntos) values(2,2,3000)
	  --insert into Tablero(EquipoId,CuestionarioId,Puntos) values(3,3,1000)