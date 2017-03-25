using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using BLL;

namespace BibleChallengeAPP.Consulta
{
    public partial class cPreguntas : MetroForm
    {
        public cPreguntas()
        {
            InitializeComponent();
        }
       string Mostrar(Cuestionario cues)
        {
            string filtro = "1=1";
            
            string filtrado= " like '%" + FiltroTextBox.Text + "%'";
            int select = FiltroComboBox.SelectedIndex;
            
            if (!string.IsNullOrWhiteSpace(FiltroTextBox.Text))
            {
                switch (select)
                {
                    case 0:
                        filtro = "Numero"+filtrado; 
                        break;
                    case 1:
                        filtro = "Pregunta" + filtrado;
                        break;
                    case 2:
                        filtro = "Repuesta" + filtrado;
                        break;
                   
                    default:
                        break;
                }
            }
            else
            {
                if (Activos.Checked==true)
                {
                    filtro = "Estado='No Realizada'";
                }
            }
            PreguntasGrid.DataSource = Utility.ListadoGenerico("Preguntas_view", filtro, "");
            TotalTextBox.Text = PreguntasGrid.RowCount.ToString();
            return filtro;
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Cuestionario Cuest = new Cuestionario();
            Mostrar(Cuest);    
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            Reportes rep = new Reportes();
            Cuestionario c = new Cuestionario();
            rep.Ruta = @"\Users\jose\Desktop\Aplicada II\BibleChallengeAPP\BibleChallengeAPP\Consulta\PreguntasReport.rdlc";
            rep.DataSetReporte = "preguntas";
            rep.Listado= Utility.ListadoGenerico("Preguntas_view",Mostrar(c), "");
            rep.ShowDialog();
        }
    }
}
