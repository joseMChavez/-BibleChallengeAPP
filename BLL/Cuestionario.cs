﻿using System;
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
                return con.Ejecutar(string.Format("Insert Into Cuestionario(Pregunta,Repuesta,RepuestaMalaA,RepuestaMalaB,RepuestaMalaC,Tipo,Etapa) values('{0}','{1}','{2}','{3}','{4}',{5},{6})", this.Pregunta,this.RepuestaBien,this.RepuestaMalaA,this.RepuestaMalaB,this.RepuestaMalaC,this.Tipo,this.Etapa));
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
            DataTable dt = new DataTable();
            ConexionDb con = new ConexionDb();
            try
            {
                dt = con.ObtenerDatos("select * from Cuestionario where CuestionarioId=" + IdBuscado);
                if (dt.Rows.Count > 0)
                {
                    this.CuestionarioId = (int)dt.Rows[0]["CuestionarioId"];
                    this.Pregunta = dt.Rows[0]["Pregunta"].ToString();
                    this.RepuestaBien = dt.Rows[0]["Repuesta"].ToString();
                    this.RepuestaMalaA = dt.Rows[0]["RepuestaMalaA"].ToString();
                    this.RepuestaMalaB = dt.Rows[0]["RepuestaMalaB"].ToString();
                    this.RepuestaMalaC = dt.Rows[0]["RepuestaMalaC"].ToString();
                    this.Tipo = (int)dt.Rows[0]["Tipo"];
                    this.Etapa = (int)dt.Rows[0]["Etapa"];
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt.Rows.Count > 0;
        }

       

        public override bool Eliminar()
        {
            ConexionDb con = new ConexionDb();
            try
            {
                return con.Ejecutar(string.Format("delecte from Cuestionario where CuestionarioId={0}", this.CuestionarioId));
            }
            catch (Exception e)
            {

                throw e;
            }
        }

       

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb db = new ConexionDb();
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Order BY  " + Orden;
            return  db.ObtenerDatos("select " + Campos + " from Cuestionario where " + Condicion+ordenFinal);
        }
    }
}
