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
    public partial class Arreglos : Form
    {
        public Arreglos()
        {
            InitializeComponent();
        }

        private void Ejecutar_Click(object sender, EventArgs e)
        {
            //vectores
            int[] arreglo1 = new int[5];

            arreglo1[0] = 40;
            arreglo1[1] = 30;
            arreglo1[2] = 50;
            arreglo1[3] = 60;
            arreglo1[4] = 80;

            int[] arreglo2 = new int[6] { 41, 36, 57, 89, 14, 17};

            int[] arreglo3 = new int[] { 2, 5, 1, 3, 7, 6 };

            int[] arreglo4 = { 5, 6, 7, 8, 9, 10 };

            String[] arreglo5 = { "Kesha", "Spay", "Vaquita", "Lukitas", "Molly" };

            for(int i = 0; i < arreglo5.Length; i++)
            {
                Nombres.Items.Add(arreglo5[i]);
            }

            foreach (String item in arreglo5)
            {
                Nombres.Items.Add(item);
            }
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            int[,] matriz1 = new int[2, 3] { { 2, 4, 6 }, { 5, 7, 9 } };

            int[,] matriz2 = new int[3, 3];

            

            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    Matriz.Items.Add("La posicion " + i + "," + j + " es igual a: " + ((4 + i) * (2 + j)));
                }
            }
        }
    }
}
