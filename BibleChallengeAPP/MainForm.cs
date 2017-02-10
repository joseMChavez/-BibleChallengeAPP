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
using MetroFramework.Controls;

namespace BibleChallengeAPP
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            Thread t = new Thread(new ThreadStart(SplashUno));
            t.Start();
            InitializeComponent();

            string s = string.Empty;

            for (int i = 0; i < 100000; i++)
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
            splashSc.AppName = "Compencia Biblica...";

            //splashSc.BackgroundImage = Image.FromFile(@"C:\Users\jose\Desktop\Aplicada II\BibleChallengeAPP\icon\Iglesia.png");
            Application.Run(splashSc);


        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
           
            MetroFramework.MetroMessageBox.Show( this, "hola", "Saludo", MessageBoxButtons.OK, MessageBoxIcon.Warning,200);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Form.rEquipos Eq = new Form.rEquipos();
            Eq.Show();
        }
    }
}
