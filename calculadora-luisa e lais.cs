namespace calculadora
{
    public partial class Form1 : Form
    {
        double número1, número2, resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            número1 = Convert.ToDouble(textBoxnúmero1.Text);
            número2 = Convert.ToDouble(textBoxnúmero2.Text);

            resultado = número1 + número2;

            labelResultado.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            número1 = Convert.ToDouble(textBoxnúmero1.Text);
            número2 = Convert.ToDouble(textBoxnúmero2.Text);

            resultado = número1 - número2;

            labelResultado.Text = resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            número1 = Convert.ToDouble(textBoxnúmero1.Text);
            número2 = Convert.ToDouble(textBoxnúmero2.Text);

            resultado = número1 / número2;

            labelResultado.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            número1 = Convert.ToDouble(textBoxnúmero1.Text);
            número2 = Convert.ToDouble(textBoxnúmero2.Text);

            resultado = número1 * número2;

            labelResultado.Text = resultado.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            número1 = Convert.ToDouble(textBoxnúmero1.Text);
            número2 = Convert.ToDouble(textBoxnúmero2.Text);

            resultado = Math.Pow(número1, número2);

            labelResultado.Text = resultado.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resultado = Math.Log(número1, número2);
        }
    }
}
