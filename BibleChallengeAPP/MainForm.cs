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
        int etapas, contador, min = 1, seg = 30;
        bool Visibles = false;
        public MainForm()
        {
            contador = 0;
            //Thread t = new Thread(new ThreadStart(SplashUno));
            //t.Start();
            etapas = 0;
            InitializeComponent();
            RepuestaLb.Visible = false;
            Eliminarbutton.Visible = false;
            //string s = string.Empty;

            //for (int i = 0; i < 110000; i++)
            //{
            //    s += i.ToString();
            //}

            //t.Abort();
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
        void LLenarCombo()
        {

            EquiposComboBox.DataSource = Utility.ListadoGenerico("Equipos", "1=1", "EquipoId");
            EquiposComboBox.ValueMember = "EquipoId";
            EquiposComboBox.DisplayMember = "Descripcion";
        }
        void LlenarCampos(Cuestionario c)
        {
            IdTextBox.Text = c.CuestionarioId.ToString();
            RepuestaLb.ForeColor = Color.Green;
            pregunta.Text = c.Pregunta;
            RepuestaLb.Text = "Repuesta Correcta: \n" + c.RepuestaBien;

            if (!string.IsNullOrWhiteSpace(c.RepuestaBien) && !string.IsNullOrWhiteSpace(c.RepuestaMalaA))
            {
                string[] array = Utility.Aleatorio(c.RepuestaBien, c.RepuestaMalaA, c.RepuestaMalaB, c.RepuestaMalaC);
                AradioButton.Text = array[1];
                BradioBtn.Text = array[0];
                CradioBtn.Text = array[2];
                DradioBtn.Text = array[3];
            }
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
            if (string.IsNullOrWhiteSpace(c.RepuestaMalaA) && string.IsNullOrWhiteSpace(c.RepuestaMalaB) && string.IsNullOrWhiteSpace(c.RepuestaMalaC))
            {
                Aceptarbutton.Visible = true;
                Eliminarbutton.Visible = true;
                Visibles = true;
            }
            else
            {
                Aceptarbutton.Visible = false;
                Eliminarbutton.Visible = false;
                Visibles = false;
            }
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
            RepuestaLb.Text = "";
            Aceptarbutton.Visible = false;
            IdTextBox.Focus();
        }
        void Buscar(Cuestionario cue)
        {

            MinLabel.Text = cue.BuscarId().ToString();
            MaxLabel.Text = cue.BuscarIdMayor().ToString();
            if (!string.IsNullOrWhiteSpace(IdTextBox.Text))
            {
                int idD = Utility.ConvierteEntero(IdTextBox.Text);
                if (cue.BuscarPregunta(idD))
                {
                    RepuestaLb.Visible = false;
                    LlenarCampos(cue);
                }
                else
                {
                    Utility.Mensajes(this, 1, "Esta Pregunta ya fue Realizada!");
                    Limpiar();
                }
            }
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
                Cuestionario.DesactivarPregunta(id);
                Limpiar();
                contador = 0;
            }
            else
            {
                if (cues.BuscarRespuesta(id, etapas, item.Text))
                {
                    Utility.Mensajes(this, 1, "Respondieron Bien Equipo " + EquiposComboBox.Text);
                    tab.AgregarPuntosAEquipo(equipo, id, 1000);
                    Cuestionario.DesactivarPregunta(id);
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
            Limpiar();
            LLenarCombo();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            min = 1;
            seg = 30;
            RepuestaLb.Visible = true;
            Cuestionario cue = new Cuestionario();
            int id = cue.BuscarId();
            int valor = id;
            IdTextBox.Text = valor.ToString();
            try
            {
                Cronotimer.Start();
                Cronoslabel.Visible = true;
                Cronoslabel.ForeColor = Color.Green;
                Buscar(cue);
            }
            catch (Exception ex)
            {
                Utility.Mensajes(this, 2, "Habla con Jose \n" + ex.Message);
            }


        }
        void Aceptar()
        {
           
            Tablero tab = new Tablero();
            Cronoslabel.Text = "00:00";
            Cronoslabel.Visible = false;
            min = 1;
            seg = 30;

            DialogResult res;
            int equipo = Utility.ConvierteEntero(EquiposComboBox.SelectedValue.ToString());
            int id = Utility.ConvierteEntero(IdTextBox.Text);
            if (contador == 2)
            {
                MetroFramework.MetroMessageBox.Show(this, "se ha excedido el Limite de fallo en Repuesta!", "C.B.OasisSFM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cuestionario.DesactivarPregunta(id);
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
                    Cuestionario.DesactivarPregunta(id);
                    RepuestaLb.Visible = true;
                    contador = 0;
                }
                else
                {
                    Utility.Mensajes(this, 2, "Incorrecto");
                    Cuestionario.DesactivarPregunta(id);
                    Aceptarbutton.Visible = false;
                    Eliminarbutton.Visible = false;
                    Visibles = false;
                    RepuestaLb.Visible = true;
                    contador = 0;
                }
            }

        }
        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            Aceptar();
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
            Cronotimer.Stop();
            
            min = 1;
            seg = 30;
            Cronoslabel.Text = "00:00";
            Cronoslabel.Visible = false;
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Cronotimer_Tick(object sender, EventArgs e)
        {

            seg -= 1;

            string minutos = min.ToString();
            string segundos = seg.ToString();

            if (min < 10)
            {
                minutos = "0" + min.ToString();
            }
            if (min < 10)
            {
                segundos = "0" + seg.ToString();
            }

            if (seg == 0 && min > 0)
            {
                min -= 1;
                seg = 59;
            }
            
            if (seg == 0 && min == 0)
            {
                if (Visibles)
                {
                    Cronotimer.Stop();
                    Cronoslabel.ForeColor = Color.Red;
                    Aceptar();
                }
                else
                {
                    Cronotimer.Stop();
                    Utility.Mensajes(this, 2, "Incorrecto");
                    Cuestionario.DesactivarPregunta(Utility.ConvierteEntero(IdTextBox.Text));
                    Aceptarbutton.Visible = false;
                    Eliminarbutton.Visible = false;
                    Visibles = false;
                    RepuestaLb.Visible = true;
                    contador = 0;
                }
                
            }
            
            Cronoslabel.Text = minutos + ":" + seg;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Limpiar();
            Cronotimer.Stop();
            Cronoslabel.Text = "00:00";
            min = 1;
            seg = 30;

            Cronoslabel.Visible = false;
            int id = Utility.ConvierteEntero(IdTextBox.Text);
            Cuestionario.DesactivarPregunta(id);
            Utility.Mensajes(this, 1, "Se a Eliminado del Listado!\n Tienen otra Oportumidad Equipo " + EquiposComboBox.Text);
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Consulta.cPreguntas p = new Consulta.cPreguntas();
            p.Show(this);
        }

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cuestionario cue = new Cuestionario();
            Utility.TextBoxNuemericos(e);
            if (e.KeyChar == (int)Keys.Enter)
            {
                Buscar(cue);
                Cronotimer.Start();
                min = 1;
                seg = 30;

                Cronoslabel.ForeColor = Color.Green;
                Cronoslabel.Visible = true;
            }
        }

        private void IdTextBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
