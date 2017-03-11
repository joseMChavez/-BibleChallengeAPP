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
using BLL;

namespace BibleChallengeAPP.Form
{
    public partial class rEquipos :MetroFramework.Forms.MetroForm
    {
        public rEquipos()
        {
            InitializeComponent();
        }

        private void rEquipos_Load(object sender, EventArgs e)
        {

        }
        private void ActivarBotones(bool ok)
        {
            Cancelarbutton.Enabled = ok;
            Guardarbutton.Enabled = ok;
            
        }
        private void LLenarClase(Equipos eq)
        {
            eq.EquiposId = Utility.ConvierteEntero(IdtextBox.Text);
            eq.Descripcion = DesctextBox.Text;
        }
        private void LlenarCampos(Equipos eq)
        {
            IdtextBox.Text = eq.EquiposId.ToString();
            DesctextBox.Text = eq.Descripcion;
        }
        private void DespuesConsultaBotones(bool ok) {
            Modificarbutton.Enabled = ok;
            Eliminarbutton.Enabled = ok;
           
        }
        void Limpiar()
        {
            IdtextBox.Clear();
            DesctextBox.Clear();
            DesctextBox.Focus();
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
           
            Limpiar();
            ActivarBotones(true);
            Nuevobutton.Enabled = false;
            DespuesConsultaBotones(false);

        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Utility.Limpiar(this);
            Utility.ActivarTbx(this, false);
            ActivarBotones(false);
            DespuesConsultaBotones(false);
            Nuevobutton.Enabled = true;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Equipos grupo = new Equipos();
            bool ok = false;
            try
            {
                Utility.Validar(DesctextBox, EquiposErrorProvider, "Pon Un Nombre al Equipo");
                LLenarClase(grupo);
                if (string.IsNullOrWhiteSpace(IdtextBox.Text))
                {
                    
                    ok = grupo.Insertar();
                }
                else
                {
                    ok = grupo.Editar();
                }
                if (ok)
                {
                    Limpiar();
                    Utility.Mensajes(this, 1, "Dios te Bendiga! \n Bien Hecho!");
                }
                   
            }
            catch (Exception ex)
            {

                Utility.Mensajes(this, 3,ex.Message);
            }
        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            
            Utility.ActivarTbx(this, true);
            ActivarBotones(true);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Equipos grupo = new Equipos();
            bool ok = false;
            DialogResult res;
            res = MetroFramework.MetroMessageBox.Show(this ,"¿Esta seguro que desea eliminar este el Equipo " + DesctextBox.Text + "?", "C.B.OasisSFM",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            try
            {
                grupo.EquiposId = Utility.ConvierteEntero(IdtextBox.Text);
                if (!string.IsNullOrWhiteSpace(IdtextBox.Text))
                {
                    if (res == DialogResult.Yes)
                    {
                        ok = grupo.Eliminar();
                    }
                }
                if (ok)
                {
                    Limpiar();
                    Utility.Mensajes(this, 1, "Equipo Eliminado Correctamente!");
                }

            }
            catch (Exception ex)
            {

                Utility.Mensajes(this, 3, "Comunicate con Jose Chavez. \n" + ex.Message);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Equipos eq = new Equipos();
            bool exito = false;
            int Id = 0;
            try 
            {
                if (String.IsNullOrWhiteSpace(IdtextBox.Text).Equals(false))
                {
                    Id = Utility.ConvierteEntero(IdtextBox.Text);
                    exito = eq.Buscar(Id);
                }

                if (exito)
                {
                    LlenarCampos(eq);
                    DespuesConsultaBotones(true);
                    ActivarBotones(false);
                    Utility.ActivarTbx(this, false);

                }
                else
                {
                    Utility.Mensajes(this, 1, "No existe!");
                    IdtextBox.Focus();
                }
            }
            catch (Exception ex)
            {

                Utility.Mensajes(this, 3, ex.Message);
            }
        }
    }
}
