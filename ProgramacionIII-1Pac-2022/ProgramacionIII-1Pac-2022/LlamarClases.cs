using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases_libreria;

namespace ProgramacionIII_1Pac_2022
{
    public partial class LlamarClases : Form
    {
        public LlamarClases()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coche coche = new Coche(10, "Toyota");

            coche.Modelo = "Hilux";
            coche.Precio = Convert.ToDecimal(500000.00);
            coche.Km = 150000;

            MessageBox.Show(coche.DevolverDatosCoche());

        }
    }
}
