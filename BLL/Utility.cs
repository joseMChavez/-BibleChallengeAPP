using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data;
using DAL;
using MetroFramework.Controls;


namespace BLL
{
    public static class Utility
    {
        public static DataTable ListadoGenerico(string View, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Order BY  " + Orden;
            return conexion.ObtenerDatos("Select * From " + View + " Where " + Condicion + ordenFinal);
        }
        public static void Limpiar(Control c)
        {
            foreach (Control item in c.Controls)
            {
                if (item is MetroTextBox)
                {
                    item.Text = "";
                }
                else if (item is TextBox)
                {
                    item.Text = "";
                }

            }
        }
        // Regex esta función permite mediante un patrón verificar si una cadena cumple con ese patrón 
        public static bool ComprobarFormatoEmail(string sEmailAComprobar)
        {
            if (!Regex.Match(sEmailAComprobar, @"\A(\w+\.?\w*\@\w+.)(com)\z").Success)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Este metodo es para Validar los Textbox
        //1 Informacion...2 Error....3 Cuidado.
        public static void Mensajes(IWin32Window t, int selec, string mensaje)
        {
            switch (selec)
            {
                case 1:
                    MetroFramework.MetroMessageBox.Show(t, mensaje, "C.B.OasisSFM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 150);
                    break;
                case 2:
                    MetroFramework.MetroMessageBox.Show(t, mensaje, "C.B.OasisSFM", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
                    break;
                case 3:
                    MetroFramework.MetroMessageBox.Show(t, mensaje, "C.B.OasisSFM", MessageBoxButtons.OK, MessageBoxIcon.Warning, 200);
                    break;
                default:
                    break;
            }
        }
        public static void MensajesDos(int selec, string mensaje)
        {
            switch (selec)
            {
                case 1:
                    MessageBox.Show(mensaje, "C.B.OasisSFM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case 2:
                    MessageBox.Show(mensaje, "C.B.OasisSFM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    MessageBox.Show(mensaje, "C.B.OasisSFM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    break;
            }
        }
        public static int ConvierteEntero(string s)
        {
            int id = 0;
            int.TryParse(s, out id);
            return id;
        }
        public static float ConvierteFloat(string s)
        {
            float id = 0;
            float.TryParse(s, out id);
            return id;
        }
        // Estos metodos reciven un evento cuando se presiona una tecla en el textbox para Validarlos
        public static void TextBoxNuemericos(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;


        }

        public static void TextboxAlfaNumerico(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 32) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 160 && e.KeyChar <= 165))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
        public static void TextBoxEspecial(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 44 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 32) || (e.KeyChar == 33) || (e.KeyChar == 95) || (e.KeyChar >= 63 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 160 && e.KeyChar <= 165))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
        public static void TextBoxSoloTexto(KeyPressEventArgs e)
        {
            if ((e.KeyChar == 8) || (e.KeyChar == 32) || (e.KeyChar == 33) || (e.KeyChar == 95) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 160 && e.KeyChar <= 165) || (e.KeyChar >= 129 && e.KeyChar <= 130))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
        // Este metodo en especial recibe un control con el fin de poder dar Focus a Cuarquier Componente de la clase Control.
        public static void Enter(KeyPressEventArgs e, Control control)
        {
            if (e.KeyChar == 13)
            {
                control.Focus();
            }
        }
        /// Fin Metodos de Seguridad en los texbox o mejor dicho cuando se realiza el evento cuando se presiona una tecla.
        public static void Validar(Control tb, ErrorProvider e, string mensaje)
        {

            if (tb.Text.Equals(""))
            {
                e.SetError(tb, mensaje);
                tb.Focus();

            }
            else
            {
                e.Clear();

            }

        }
        public static void ActivarTbx( Control ct,bool act)
        {
            foreach (Control  c in ct.Controls)
            {
                if (c is MetroTextBox || c is TextBox)
                {
                    c.Enabled = act;
                }
               
            }
        }
        public static bool ValidarTbx(Control tbUno)
        {
            return !string.IsNullOrWhiteSpace(tbUno.Text);
        }

    }
}
