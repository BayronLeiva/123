using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionIII_1Pac_2022
{
    public partial class FuncionesTexto : Form
    {
        public FuncionesTexto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BotonProcesar_Click(object sender, EventArgs e)
        {
            string cadena = CadenatextB.Text;

            TextbLongitud.Text = cadena.Length.ToString();

            textBoxPrimerCaracter.Text = cadena.Substring(0,1);

            textBoxUltimoCaracter.Text = cadena.Substring(cadena.Length - 1, 1);

            textBoxRango.Text = cadena.Substring(12, 20);

            textBoxMayuscula.Text = cadena.ToUpper();

            textBoxMinuscula.Text = cadena.ToLower();

            textBoxRemplazo.Text = cadena.Replace(" ", "");
        }
    }
}
