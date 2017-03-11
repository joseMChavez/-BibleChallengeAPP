using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using MetroFramework.Forms;
using BLL;
using System.Windows.Forms;

namespace BibleChallengeAPP.Form
{
    public partial class rCuestionario : MetroForm
    {
        public rCuestionario()
        {
            InitializeComponent();
        }


        private void rCuestionario_Load(object sender, EventArgs e)
        {
            Utility.ActivarTbx(this, false);
            RegularRbt.Checked = true;
            ActivarCheck.Checked = true;
        }
        private void DespuesConsultaBotones(bool ok)
        {
            Modificarbutton.Enabled = ok;
            Eliminarbutton.Enabled = ok;

        }
        private void ActivarBotones(bool ok)
        {
            Cancelarbutton.Enabled = ok;
            Guardarbutton.Enabled = ok;

        }
        private void LlenarClase(Cuestionario cues)
        {
            cues.CuestionarioId = Utility.ConvierteEntero(IdTextBox.Text);
            cues.Pregunta = PreguntaTextBox.Text;
            cues.RepuestaBien = RepuestaBuenaTextBox.Text;
            cues.RepuestaMalaA = MalaATextBox.Text;
            cues.RepuestaMalaB = MalaBTextBox.Text;
            cues.RepuestaMalaC = MalaCTextBox.Text;

            if (ActivarCheck.Checked)
                cues.Tipo = 1;
            else
                cues.Tipo = 0;

            if (RegularRbt.Checked)
                cues.Etapa = 1;
            else if (SemiFinaRbtn.Checked)
                cues.Etapa = 2;
            else if (FinalRbtn.Checked)
                cues.Etapa = 3;

        }
        private void LlenarCampos(Cuestionario cues)
        {
            IdTextBox.Text = cues.CuestionarioId.ToString();
            PreguntaTextBox.Text = cues.Pregunta;
            RepuestaBuenaTextBox.Text = cues.RepuestaBien;
            MalaATextBox.Text = cues.RepuestaMalaA;
            MalaBTextBox.Text = cues.RepuestaMalaB;
            MalaCTextBox.Text = cues.RepuestaMalaC;
            if (cues.Tipo == 1)
                ActivarCheck.Checked = true;
            else
                ActivarCheck.Checked = false;

            if (cues.Etapa == 1)
                RegularRbt.Checked = true;
            else if (cues.Etapa == 2)
                SemiFinaRbtn.Checked = true;
            else if (cues.Etapa == 3)
                FinalRbtn.Checked = true;

        }


        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Utility.Limpiar(this);
            ActivarBotones(true);
            PreguntaTextBox.Focus();
            Utility.ActivarTbx(this, true);
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Utility.Limpiar(this);
            ActivarBotones(false);
            DespuesConsultaBotones(false);
            Utility.ActivarTbx(this, false);
        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            ActivarBotones(true);
            DespuesConsultaBotones(false);
            Utility.ActivarTbx(this, true);
            PreguntaTextBox.Focus();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Cuestionario cues = new Cuestionario();
            bool exito = false;
            Utility.Validar(PreguntaTextBox, errorProvider, "Campo Obligatorio!");
           
            LlenarClase(cues);

            try
            {
                if (Utility.ValidarTbx(IdTextBox).Equals(false))
                {
                    if (Utility.ValidarTbx(PreguntaTextBox))
                    {
                        exito = cues.Insertar();
                    }

                }
                else
                {
                    if (Utility.ValidarTbx(PreguntaTextBox))
                    {
                        exito = cues.Editar();
                    }
                }
                if (exito)
                {
                    Utility.Limpiar(this);
                    IdTextBox.Focus();
                    Utility.ActivarTbx(this, true);
                    Utility.Mensajes(this,1, "Dios te bendiga! \nBien Hecho!");
                }
            }
            catch (Exception ex)
            {
                Utility.Mensajes(this, 3, ex.Message);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Cuestionario cues = new Cuestionario();
            bool exito = false;
            DialogResult res;
            res = MessageBox.Show("¿Esta seguro que desea eliminar la Pregunta Numero " + IdTextBox.Text + "?", "C.B.OasisSFM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (res == DialogResult.Yes)
                {
                    cues.CuestionarioId = Utility.ConvierteEntero(IdTextBox.Text);
                    if (String.IsNullOrWhiteSpace(IdTextBox.Text).Equals(false))
                    {
                        exito = cues.Eliminar();
                    }

                    if (exito)
                    {
                        Utility.Limpiar(this);
                        DespuesConsultaBotones(false);
                        ActivarBotones(false);
                        Utility.ActivarTbx(this, false);
                        Utility.Mensajes(this, 1, "Se Elimino Corectamente!");
                    }
                }
            }
            catch (Exception ex)
            {

                Utility.Mensajes(this, 3, ex.Message);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Cuestionario cues = new Cuestionario();
            bool exito = false;
            int Id = 0;
            try
            {
                if (String.IsNullOrWhiteSpace(IdTextBox.Text).Equals(false))
                {
                    Id = Utility.ConvierteEntero(IdTextBox.Text);
                    exito = cues.Buscar(Id);
                }

                if (exito)
                {
                    LlenarCampos(cues);
                    DespuesConsultaBotones(true);
                    ActivarBotones(false);
                    Utility.ActivarTbx(this, false);

                }
                else
                {
                    Utility.Mensajes(this,1, "No existe!");
                    IdTextBox.Focus();
                }
            }
            catch (Exception ex)
            {

                Utility.Mensajes(this, 3, ex.Message);
            }
        }



        private void PreguntaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            Utility.Enter(e, RepuestaBuenaTextBox);
        }

        private void RepuestaBuenaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxEspecial(e);
            Utility.Enter(e, MalaATextBox);
        }

        private void MalaATextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxEspecial(e);
            Utility.Enter(e, MalaBTextBox);
        }

        private void MalaBTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxEspecial(e);
            Utility.Enter(e, MalaCTextBox);
        }

        private void MalaCTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxEspecial(e);
            Utility.Enter(e, PreguntaTextBox);
        }

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void PreguntaTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
