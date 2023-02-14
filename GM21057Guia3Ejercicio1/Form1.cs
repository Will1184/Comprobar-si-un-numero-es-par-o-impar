namespace GM21057Guia3Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textIngreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textIngreso.Text);

            if (numero % 2 == 0)
            {
                textSalida.Text = "El numero ingresado es par";
            }
            else
            {
                textSalida.Text = "El numero ingresado es impar";
            }
        }

        private void clean_Click(object sender, EventArgs e)
        {
            textSalida.Clear();
            textIngreso.Clear();

        }
    }
}