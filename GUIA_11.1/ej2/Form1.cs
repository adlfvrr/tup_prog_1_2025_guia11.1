using System.Drawing.Text;

namespace ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static Servicio servicio = new Servicio();
        private void btnRegistrarMonto_Click(object sender, EventArgs e)
        {
            double monto = Convert.ToDouble(tbMonto.Text);
            servicio.RegistrarMontoARepartir(monto);
            tbMonto.Clear();
        }

        private void btnRegistrarEdades_Click(object sender, EventArgs e)
        {
            int edad1 = Convert.ToInt32(tbEdad1.Text);
            int edad2 = Convert.ToInt32(tbEdad2.Text);
            int edad3 = Convert.ToInt32(tbEdad3.Text);
            int edad4 = Convert.ToInt32(tbEdad4.Text);
            servicio.RegistrarEdad(edad1, 1);
            servicio.RegistrarEdad(edad2, 2);
            servicio.RegistrarEdad(edad3, 3);
            servicio.RegistrarEdad(edad4, 4);
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            servicio.CalcularMontosYPorcentajesARepartir();
            lsbResultado.Items.Add($"Niña 1 ({servicio.Edad0}), Porcentaje: {servicio.Porcentaje0:f2}%, Monto ${servicio.Monto0:f2}");
            lsbResultado.Items.Add($"Niña 2 ({servicio.Edad1}), Porcentaje: {servicio.Porcentaje1:f2}%, Monto ${servicio.Monto1:f2}");
            lsbResultado.Items.Add($"Niña 3 ({servicio.Edad2}), Porcentaje: {servicio.Porcentaje2:f2}%, Monto ${servicio.Monto2:f2}");
            lsbResultado.Items.Add($"Niña 4 ({servicio.Edad3}), Porcentaje: {servicio.Porcentaje3:f2}%, Monto ${servicio.Monto3:f2}");
        }
    }
}
