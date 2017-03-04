using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using System.Threading.Tasks;

namespace BLL
{
    public class Tablero
    {
        public int TableroId { get; set; }
        public int EquipoId { get; set; }
        public int CuestionarioId { get; set; }
        public int Puntos { get; set; }

        public Tablero()
        {
            TableroId = 0;
            EquipoId = 0;
            CuestionarioId = 0;
            Puntos = 0;

        }

        public void LimpiarPuntos(int equipo)
        {
            ConexionDb con = new ConexionDb();
            try
            {
                con.Ejecutar(string.Format("update Tablero set Puntos=0 there EquipoId={0}", equipo));
            }
            catch (Exception ex) { throw ex; }

        }
        public string[] GetSeries()
        {
            DataTable tb = new DataTable();
            ConexionDb db = new ConexionDb();
            List<string> lista = new List<string>();
            tb = db.ObtenerDatos("select * from Equipos");
            string[] array = new string[tb.Rows.Count];
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                lista.Add(tb.Rows[i]["Descripcion"].ToString());
            }
            array = lista.ToArray();

            return array;
        }
        public int[] GetPuntos()
        {
            DataTable tb = new DataTable();
            ConexionDb db = new ConexionDb();
            List<int> lista = new List<int>();
            tb = db.ObtenerDatos("select * from Tablero");
            int[] array = new int[tb.Rows.Count];
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                lista.Add((int)tb.Rows[i]["Puntos"]);
            }
            array = lista.ToArray();

            return array;
        }
        public void AgregarPuntosAEquipo(int equipo, int cuestionario, int punto)
        {
            ConexionDb con = new ConexionDb();
            try
            {
                con.Ejecutar(string.Format("insert into Tablero(EquipoId,CuestionarioId,Puntos) values({0},{1},{2})", equipo, cuestionario, punto));
            }
            catch (Exception ex) { throw ex; }

        }
        public DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb db = new ConexionDb();
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Order BY  " + Orden;
            return db.ObtenerDatos("select " + Campos + " from Tablero where " + Condicion + ordenFinal);
        }
    }
}
