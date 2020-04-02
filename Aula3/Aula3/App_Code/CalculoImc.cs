
using System;

namespace Aula3.App_Code
{
    public class CalculoImc
    {
        public string Nome { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }

        public float Imc
        {
            get { return (float) (Peso / Math.Pow(Altura,2)); }
        }
    }
}