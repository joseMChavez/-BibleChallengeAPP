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

namespace BibleChallengeAPP.Form
{
    public partial class rParticipantes : MetroForm
    {
        public rParticipantes()
        {
            InitializeComponent();
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
        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {

        }

        private void rParticipantes_Load(object sender, EventArgs e)
        {

        }
    }
}
