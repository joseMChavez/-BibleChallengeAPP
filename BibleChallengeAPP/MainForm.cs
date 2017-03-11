using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using MetroFramework.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MetroFramework.Controls;
using BLL;

namespace BibleChallengeAPP
{
    public partial class MainForm : MetroForm
    {
        int etapas;
        int contador;
        
        public MainForm()
        {
            contador = 0;
            Thread t = new Thread(new ThreadStart(SplashUno));
            t.Start();
            etapas = 0;
            InitializeComponent();

            string s = string.Empty;

            for (int i = 0; i < 110000; i++)
            {
                s += i.ToString();
            }

            t.Abort();
        }

        void SplashUno()
        {
            SplashScreen.SplashForm splashSc = new SplashScreen.SplashForm();
            splashSc.BackColor = Color.White;
            splashSc.ForeColor = Color.Aquamarine;
            splashSc.AppName = "C.B.OasisSFM 1.0.0";

            //splashSc.BackgroundImage = Image.FromFile(@"C:\Users\jose\Desktop\Aplicada II\BibleChallengeAPP\icon\Iglesia.png");
            Application.Run(splashSc);

        }
        private void LLenarCombo()
        {

            EquiposComboBox.DataSource = Utility.ListadoGenerico("Equipos", "1=1", "EquipoId");
            EquiposComboBox.ValueMember = "EquipoId";
            EquiposComboBox.DisplayMember = "Descripcion";
        }
        public void LlenarCampos(Cuestionario c)
        {
            IdTextBox.Text = c.CuestionarioId.ToString();
            pregunta.Text = c.Pregunta;
            string[] array = Utility.Aleatorio(c.RepuestaBien, c.RepuestaMalaA, c.RepuestaMalaB, c.RepuestaMalaC);
            AradioButton.Text = array[1];
            BradioBtn.Text = array[0];
            CradioBtn.Text = array[2];
            DradioBtn.Text = array[3];
            if (c.Etapa == 1 && c.VerificarActivos(1))
            {
                EtapaL.Text = "Regular";
                etapas = c.Etapa;
            }
            else if (c.Etapa == 2 && c.VerificarActivos(2))
            {
                EtapaL.Text = "Semi Final";
                etapas = c.Etapa;
            }
            else if (c.Etapa == 3 && c.VerificarActivos(3))
            {
                EtapaL.Text = "Final";
                etapas = c.Etapa;
            }
            if (string.IsNullOrWhiteSpace(c.RepuestaBien) && string.IsNullOrWhiteSpace(c.RepuestaMalaA) && string.IsNullOrWhiteSpace(c.RepuestaMalaB) && string.IsNullOrWhiteSpace(c.RepuestaMalaC))
            {
                Aceptarbutton.Visible = true;
            }
            else
                Aceptarbutton.Visible = false;
        }
        public void ValidarRepuesta(MetroRadioButton item)
        {
            Cuestionario cues = new Cuestionario();
            Tablero tab = new Tablero();
           
   
            int equipo = Utility.ConvierteEntero(EquiposComboBox.SelectedValue.ToString());
            int id = Utility.ConvierteEntero(IdTextBox.Text);
            
            if (contador == 2)
            {
                MetroFramework.MetroMessageBox.Show(this, "se ha excedido el Limite de fallo en Repuesta!", "C.B.OasisSFM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cues.DesactivarPregunta(id);
                Limpiar();
                contador = 0;
            }
            else
            {
                if (cues.BuscarRespuesta(id, etapas, item.Text))
                {
                    Utility.Mensajes(this, 1, "Respondieron Bien Equipo " + EquiposComboBox.Text);
                    tab.AgregarPuntosAEquipo(equipo, id, 1000);
                    cues.DesactivarPregunta(id);
                    Limpiar();
                    contador = 0;
                }
                else
                {
                    Utility.Mensajes(this, 2, "Incorrecto");
                    contador += 1;
                }
            }
        }
        private void metroTile1_Click(object sender, EventArgs e)
        {

            Form.rParticipantes rp = new Form.rParticipantes();

            rp.Show(this);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Form.rEquipos Eq = new Form.rEquipos();
            Eq.Show(this);
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Form.rCuestionario cues = new Form.rCuestionario();
            cues.Show(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Cuestionario cue = new Cuestionario();
           
            MinLabel.Text = cue.BuscarId().ToString();
            MaxLabel.Text = cue.BuscarIdMayor().ToString();
            Refrescar();
            LLenarCombo();
        }
        void Refrescar()
        {

            chart1.Series["Equipos"].XValueMember = "Equipos";

            chart1.Series["Equipos"].YValueMembers = "Puntuacion";
            if (etapas == 1)
            {
                chart1.Series["Equipos"].Color = Color.Green;
            }
            else if (etapas == 2)
            {
                chart1.Series["Equipos"].Color = Color.Yellow;
            }
            else if (etapas == 3)
            {
                chart1.Series["Equipos"].Color = Color.Red;
            }
            chart1.DataSource = Utility.ListadoGenerico("Tablero_view", "1=1", "Puntuacion desc");
            chart1.DataBind();
        }
        void Limpiar()
        {
            IdTextBox.Clear();
            pregunta.Text = "";
            AradioButton.Text = "";
            BradioBtn.Text = "";
            CradioBtn.Text = "";
            DradioBtn.Text = "";
            IdTextBox.Focus();
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            Cuestionario cue = new Cuestionario();
            //int id = cue.BuscarId();
            //int valor = id;
            //IdTextBox.Text = valor.ToString();
            MinLabel.Text = cue.BuscarId().ToString();
            MaxLabel.Text = cue.BuscarIdMayor().ToString();
            if (!string.IsNullOrWhiteSpace(IdTextBox.Text))
            {
                int idD = Utility.ConvierteEntero(IdTextBox.Text);
                if (cue.BuscarPregunta(idD))
                {
                    LlenarCampos(cue);
                }
                else
                {
                    Utility.Mensajes(this, 1, "Esta Pregunta ya fue Realizada!");
                    Limpiar();
                }
            }

        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            Cuestionario cues = new Cuestionario();
            Tablero tab = new Tablero();
          
            DialogResult res;
            int equipo = Utility.ConvierteEntero(EquiposComboBox.SelectedValue.ToString());
            int id = Utility.ConvierteEntero(IdTextBox.Text);
            if (contador == 2)
            {
                MetroFramework.MetroMessageBox.Show(this, "se ha excedido el Limite de fallo en Repuesta!", "C.B.OasisSFM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cues.DesactivarPregunta(id);
                Limpiar();
                contador = 0;
            }
            else
            {
                res = MetroFramework.MetroMessageBox.Show(this, "\a¿Juez es Correcto? ", "C.B.OasisSFM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    Utility.Mensajes(this, 1, "Respondieron Bien Equipo " + EquiposComboBox.Text);
                    tab.AgregarPuntosAEquipo(equipo, id, 1000);
                    cues.DesactivarPregunta(id);
                    Limpiar();
                    contador = 0;
                }
                else
                {
                    Utility.Mensajes(this, 2, "Incorrecto");
                    contador += 1;
                }
            }

        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Consulta.Resultados r = new Consulta.Resultados();
            r.ShowDialog(this);
        }

        private void freshButton_Click(object sender, EventArgs e)
        {
            Cuestionario cue = new Cuestionario();
            MinLabel.Text = cue.BuscarId().ToString();
            MaxLabel.Text = cue.BuscarIdMayor().ToString();
            Refrescar();
            Limpiar();
            LLenarCombo();
        }

        private void AradioButton_CheckedChanged(object sender, EventArgs e)
        {

                ValidarRepuesta(AradioButton);

        }

        private void BradioBtn_CheckedChanged(object sender, EventArgs e)
        {

                ValidarRepuesta(BradioBtn);
            
        }

        private void CradioBtn_CheckedChanged(object sender, EventArgs e)
        {
                ValidarRepuesta(CradioBtn);  
        }

        private void DradioBtn_CheckedChanged(object sender, EventArgs e)
        {

                ValidarRepuesta(DradioBtn);
            
        }

        private void IdTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
