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

namespace BibleChallengeAPP.Form
{
    public partial class rParticipantes : MetroForm
    {
        public rParticipantes()
        {
            InitializeComponent();
        }
        private void rParticipantes_Load(object sender, EventArgs e)
        {
            CargarComoboBox();
            Utility.ActivarTbx(this, false);
           
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

        void CargarComoboBox()
        {
            EquiposCbox.DataSource = Utility.ListadoGenerico("Equipos", "1=1", "EquipoId");
            EquiposCbox.ValueMember = "EquipoId";
            EquiposCbox.DisplayMember = "Descripcion";
        }

        private void LlenarClase(Participantes p)
        {
            p.ParticipanteId = Utility.ConvierteEntero(IdTextBox.Text);
            p.Nombres = NombreCTextBox4.Text;
            if (MasculinoRadioBtn.Checked)
            {
                p.Genero = 1;
            }
            else
            {
                p.Genero = 0;
            }
            p.Fecha = FechaDateTime.Text;
            p.Apodo = ApodoTextBox.Text;
            p.EquipoId = Utility.ConvierteEntero(EquiposCbox.SelectedValue.ToString());
        }
        private void LlenarCampos(Participantes p)
        {
            IdTextBox.Text = p.ParticipanteId.ToString();
            NombreCTextBox4.Text = p.Nombres;
            ApodoTextBox.Text = p.Apodo;
            if (p.Genero == 1)
            {
                MasculinoRadioBtn.Checked = true;
            }
            else
            {
                FemeninoRadioBtn.Checked = true;
            }
            FechaDateTime.Text = p.Fecha;
            EquiposCbox.SelectedValue = p.EquipoId.ToString();
        }
        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Participantes part = new Participantes();
            bool exito = false;
            DialogResult res;
            res =MetroFramework.MetroMessageBox.Show(this,"¿Esta seguro que desea eliminar el participante " + NombreCTextBox4.Text + "?", "C.B.OasisSFM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (res == DialogResult.Yes)
                {
                    part.ParticipanteId = Utility.ConvierteEntero(IdTextBox.Text);
                    if (String.IsNullOrWhiteSpace(IdTextBox.Text).Equals(false))
                    {
                        exito = part.Eliminar();
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

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            ActivarBotones(false);
            Utility.ActivarTbx(this, false);
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Participantes participantes = new Participantes();
            bool exito = false;
            Utility.Validar(NombreCTextBox4, ErrorProvider, "Campo Obligatorio!");
            Utility.Validar(ApodoTextBox, ErrorProvider, "Campo Obligatorio!");
            LlenarClase(participantes);

            try
            {
                if (Utility.ValidarTbx(IdTextBox)==false)
                {
                    if (Utility.ValidarTbx(NombreCTextBox4) && Utility.ValidarTbx(ApodoTextBox))
                    {
                        exito = participantes.Insertar();
                    }
                    
                }
                else
                {
                    if (Utility.ValidarTbx(NombreCTextBox4) && Utility.ValidarTbx(ApodoTextBox))
                    {
                        exito = participantes.Editar();
                    }
                }
                if (exito)
                {
                    Utility.Limpiar(this);
                    Utility.ActivarTbx(this, false);
                    Utility.Mensajes(this, 1, "Dios te bendiga! \nBien Hecho!");
                }
            }
            catch (Exception ex)
            {
                Utility.Mensajes(this, 3, ex.Message);
            }
        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            ActivarBotones(true);
            DespuesConsultaBotones(false);
            Utility.ActivarTbx(this, true);
            NombreCTextBox4.Focus();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {

            if (EquiposCbox.MaxDropDownItems>=2)
            {
                Utility.Limpiar(this);
                ActivarBotones(true);
                Utility.ActivarTbx(this, true);
                NombreCTextBox4.Focus();
            }
            else
            {
                Utility.MensajesDos(1, "Debe de Registrar Por lo Menos Dos Equipos");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Participantes part = new Participantes();
            bool exito = false;
            int Id = 0;
            try
            {
                if (String.IsNullOrWhiteSpace(IdTextBox.Text).Equals(false))
                {
                    Id = Utility.ConvierteEntero(IdTextBox.Text);
                    exito = part.Buscar(Id);
                }

                if (exito)
                {
                    LlenarCampos(part);
                    DespuesConsultaBotones(true);
                    ActivarBotones(false);
                    Utility.ActivarTbx(this, false);

                }
                else
                {
                    Utility.Mensajes(this, 1, "No existe!");
                    IdTextBox.Focus();
                }
            }
            catch (Exception ex)
            {

                Utility.Mensajes(this, 3, ex.Message);
            }
        }

        private void NombreCTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxSoloTexto(e);
            Utility.Enter(e, ApodoTextBox);
        }

        private void ApodoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxSoloTexto(e);
            Utility.Enter(e, NombreCTextBox4);
        }

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxNuemericos(e);
            Utility.Enter(e, NombreCTextBox4);
        }
    }
}
