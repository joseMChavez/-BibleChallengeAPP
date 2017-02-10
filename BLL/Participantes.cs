using System;
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
            ConexionDb con = new ConexionDb();
            try
            {
                return con.Ejecutar(string.Format(" Insert Into Participantes(ParticipanteId,EquipoId,Nombres,Apodo,Genero,Fecha) Values({0},{1},'{2}','{3}',{4},'{5}')", this.ParticipanteId,this.EquipoId,this.Nombres,this.Apodo,this.Genero,this.Fecha));
            }
            catch (Exception e){ throw e; }

        }

        public override bool Editar()
        {
            ConexionDb con = new ConexionDb();
            try
            {
                return con.Ejecutar(string.Format("update Participantes set EquipoId={0},Nombres='{1}',Apodo='{2}',Genero={3},Fecha='{4}' where ParticipanteId={5}",  this.EquipoId, this.Nombres, this.Apodo, this.Genero, this.Fecha, this.ParticipanteId));
            }
            catch (Exception e) { throw e; }
        }

        public override bool Eliminar()
        {

            ConexionDb con = new ConexionDb();
            try
            {
                return con.Ejecutar(string.Format("delete from Participantes where ParticipanteId={0}", this.ParticipanteId));
            }
            catch (Exception e) { throw e; }
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();
            ConexionDb con = new ConexionDb();
            try
            {
                dt = con.ObtenerDatos("select * from Participantes where ParticipanteId=" + IdBuscado);
                if (dt.Rows.Count > 0)
                {
                    this.ParticipanteId = (int)dt.Rows[0]["ParticipanteId"];
                    this.EquipoId = (int)dt.Rows[0]["EquipoId"];
                    this.Nombres = dt.Rows[0]["Nombres"].ToString();
                    this.Apodo = dt.Rows[0]["Apodo"].ToString();
                    this.Genero = (int)dt.Rows[0]["Genero"];
                    this.Fecha = (DateTime)dt.Rows[0]["Fecha"];

                }
            }
            catch (Exception e) { throw e; };
            return dt.Rows.Count > 0;
        }

 
        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }
    }
}
