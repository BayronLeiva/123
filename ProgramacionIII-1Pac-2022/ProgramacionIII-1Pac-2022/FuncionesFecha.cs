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
    public partial class FuncionesFecha : Form
    {
        public FuncionesFecha()
        {
            InitializeComponent();
        }

        private void Procesar_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;

            textBoxDia.Text = fecha.Day.ToString();

            textBoxMes.Text = fecha.Month.ToString();

            textBoxAño.Text = fecha.Year.ToString();

            textBoxDiaLetras.Text = fecha.ToString("dddd");

            textBoxMesenletras.Text = fecha.ToString("MMMM");

            textBoxSuma.Text = fecha.AddDays(25).ToShortDateString();

            textBoxEdad.Text = DevolverEdad(fecha).ToString();
        }

        private int DevolverEdad(DateTime _fechaNacimiento)
        {
            DateTime fechaNacimiento = _fechaNacimiento;
            DateTime fechaActual = DateTime.Now;
            int edad = 0;

            if (fechaNacimiento > fechaActual)
            {
                MessageBox.Show("La fecha de nacimiento es mayor a la fecha actual");
                return 0;
            }
            {
                edad = fechaActual.Year - fechaNacimiento.Year;
                if(fechaNacimiento.Month > fechaActual.Month)
                {
                    --edad;
                }
            }
            return edad;
        }
    }
}
