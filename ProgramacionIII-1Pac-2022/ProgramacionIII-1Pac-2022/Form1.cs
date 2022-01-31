namespace ProgramacionIII_1Pac_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SumarBoton_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(Numero1tb.Text);
            int num2 = Convert.ToInt32(Numero2tb.Text);

            Sumar(num1, num2);

            Resultadotb.Text = Sumar(num1, num2).ToString();
        }

        private int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        private void MostrarMensaje()
        {
            MessageBox.Show("Este es un mensaje");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarMensaje();
        }

        //Variables
        //Procedimientos
        //Funciones
    }
}