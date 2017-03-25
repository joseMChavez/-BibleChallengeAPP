using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using BLL;
using Microsoft.Reporting.WinForms;

namespace BibleChallengeAPP.Consulta
{
    public partial class Reportes : MetroForm
    {
        public string Ruta { get; set; }
        public string DataSetReporte { get; set; }
        public DataTable Listado { get; set; }
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Preguntas_view' table. You can move, or remove it, as needed.
            //this.preguntas_viewTableAdapter.Fill(this.dataSet.Preguntas_view);
            Utility.ConfigurarReporte(reportViewer1, Ruta,DataSetReporte, Listado);  
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.LocalReport.DataSources.Clear();
            //this.reportViewer1.ProcessingMode = ProcessingMode.Local;


            //this.reportViewer1.LocalReport.ReportPath = Ruta;
            //ReportDataSource sourse = new ReportDataSource(DataSetReporte, Listado);

            //this.reportViewer1.LocalReport.DataSources.Add(sourse);
            //this.reportViewer1.RefreshReport();
           
        }
    }
}
