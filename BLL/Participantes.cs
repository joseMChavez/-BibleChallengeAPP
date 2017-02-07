﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Participantes : MasterClass
    {
        public int ParticipanteId { get; set; }
        public int EquipoId{ get; set; }
        public string Nombres { get; set; }
        public string Apodo { get; set; }
        public int Genero { get; set; }
        public DateTime Fecha { get; set; }

        public Participantes()
        {
            this.ParticipanteId = 0;
            this.EquipoId = 0;
            this.Nombres = "";
            this.Apodo = "";
            this.Genero = 0;
            this.Fecha = new DateTime();
        }
       
        public override bool Insertar()
        {
            throw new NotImplementedException();
        }

        public override bool Editar()
        {
            throw new NotImplementedException();
        }

        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public override bool Buscar(int IdBuscado)
        {
            throw new NotImplementedException();
        }

 
        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }
    }
}
