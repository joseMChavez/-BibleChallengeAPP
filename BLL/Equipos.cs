using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Equipos : MasterClass
    {
        public int EquiposId { get; set; }
        public string Descripcion { get; set; }


        public Equipos()
        {
            this.EquiposId = 0;
            this.Descripcion = string.Empty;
        }

        public override bool Insertar()
        {
            ConexionDb con = new ConexionDb();
            try
            {
                return con.Ejecutar(string.Format(" Insert Into Equipos(EquipoId,Descripcion) Values({0},'{1}')", this.EquiposId, this.Descripcion));
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
                return con.Ejecutar(string.Format(" Update  Equipos set  Descripcion='{0}' where EquipoId = {1}", this.Descripcion, this.EquiposId));
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public override bool Eliminar()
        {
            ConexionDb con = new ConexionDb();
            try
            {
                return con.Ejecutar(string.Format(" Delete from Equipos where EquipoId = {1}", this.EquiposId));
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
                dt = con.ObtenerDatos(string.Format("select * from Equipos where EquipoId= {0}", IdBuscado));
                if (dt.Rows.Count > 0)
                {
                    this.EquiposId = (int)dt.Rows[0]["EquipoId"];
                    this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
                }
            }
            catch (Exception e)
            {

                throw e;
            }

            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            DataTable dt = new DataTable();
            ConexionDb con = new ConexionDb();
            string orderby = string.Empty;
            if (Orden.Equals(""))
            {
                orderby = " order by ";
            }
            return dt = con.ObtenerDatos("select " + Campos + " Equipos where " + Condicion + orderby);
        }
    }
}
