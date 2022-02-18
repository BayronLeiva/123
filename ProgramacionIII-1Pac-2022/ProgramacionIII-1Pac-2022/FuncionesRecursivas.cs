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
    public partial class FuncionesRecursivas : Form
    {
        public FuncionesRecursivas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecorrerDeUnoEnUno(10, 30);
        }

        private void RecorrerDeUnoEnUno(int valorI, int valorF)
        {
            listBox1.Items.Add(valorI);
            
            if(valorI < valorF)
            {
                RecorrerDeUnoEnUno(valorI + 1, valorF);
            }
        }
    }
}
