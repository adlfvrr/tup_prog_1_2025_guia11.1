namespace ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static Servicio servicio = new Servicio();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(tbIngreso.Text);
            servicio.RegistrarValor(numero);
        }

        private void btnMaximoYMinimo_Click(object sender, EventArgs e)
        {
            lbMaximo.Text = servicio.Maximo.ToString();
            lbMinimo.Text = servicio.Minimo.ToString();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double prom = servicio.CalcularPromedio();
            lbPromedio.Text = prom.ToString();
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            lbCantidad.Text = servicio.Contador.ToString();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            servicio = new Servicio();
        }
    }
}
