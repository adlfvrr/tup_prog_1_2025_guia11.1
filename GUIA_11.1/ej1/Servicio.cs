using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1
{
    internal class Servicio
    {
        private int acumulador;
        public int Contador;
        public int Maximo;
        public int Minimo;
        public Servicio()
        {
            acumulador = 0;
            Contador = 0;
            Maximo = 0;
            Minimo = 0;
        }   
        public double CalcularPromedio()
        {
            double prom = 0;
            if (Contador > 0)
            {
                prom = 1.0*(acumulador / (double)Contador);
            }
            return prom;
        }
        public void RegistrarValor(int valor)
        {
            acumulador += valor;
            Contador++;
            if (Maximo == 0)
            {
                Maximo = valor;
            }
            else
            {
                if(valor > Maximo)
                {
                    Maximo = valor;
                }
            }
            if (Minimo == 0)
            {
                Minimo = valor;
            }
            else
            {
                if (valor < Minimo)
                {
                    Minimo = valor;
                }
            }
        }
    }
}
