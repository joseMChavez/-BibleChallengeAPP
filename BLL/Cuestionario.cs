using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Cuestionario : MasterClass
    {

        public int CuestionarioId { get; set; }
        public string Pregunta { get; set; }
        public string RepuestaBien { get; set; }
        public string RepuestaMalaA { get; set; }
        public string RepuestaMalaB { get; set; }
        public string RepuestaMalaC { get; set; }
        public int Tipo { get; set; }
        public int Etapa { get; set; }
        public Cuestionario()
        {
            CuestionarioId = 0;
            Pregunta = "";
            RepuestaBien = "";
            RepuestaMalaA = "";
            RepuestaMalaB = "";
            RepuestaMalaC = "";
            Tipo = 0;
            Etapa = 0;

        }
        public override bool Insertar()
        {
            ConexionDb con = new ConexionDb();
            try
            {
                return con.Ejecutar(string.Format("Insert Into Cuestionario(Pregunta,Repuesta,RepuestaMalaA,RepuestaMalaB,RepuestaMalaC,Tipo,Etapa) values('{0}','{1}','{2}','{3}','{4}',{5},{6})",this.Pregunta,this.RepuestaBien,this.RepuestaMalaA,this.RepuestaMalaB,this.RepuestaMalaC,this.Tipo,this.Etapa));
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public override bool Editar()
        {
            ConexionDb con = new ConexionDb();
            try
            {
                return con.Ejecutar(string.Format("update Cuestionario set Preguntas='{0}',Repuesta='{1}',RepuestaMalaA='{2}',RepuestaMalaB='{3}',RepuestaMalaC='{4}',Tipo={5},Etapa={6} where CuestionarioId={7}", this.Pregunta, this.RepuestaBien, this.RepuestaMalaA, this.RepuestaMalaB, this.RepuestaMalaC, this.Tipo, this.Etapa,this.CuestionarioId));
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public override bool Buscar(int IdBuscado)
        {
            throw new NotImplementedException();
        }

       

        public override bool Eliminar()
        {
            ConexionDb con = new ConexionDb();
            try
            {
                return con.Ejecutar(string.Format("delecte from Cuistionario where CuestionarioId={0}", this.CuestionarioId));
            }
            catch (Exception e)
            {

                throw e;
            }
        }

       

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }
    }
}
