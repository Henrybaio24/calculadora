using System;

namespace Calculadora
{
    public class Calculadora
    {
        private double Num1;
        private double Num2;
 
        public double Numero1
        {
            get { return Num1; }
            set { Num1 = value; }
        }
 
        public double Numero2
        {
            get { return Num2; }
            set { Num2 = value; }
        }
 
        public double Sumar()
        {
            return Numero1 + Numero2;
        }
        public double Restar()
        {
            return Numero1 - Numero2;
        }
        public double Multiplicar()
        {
            return Numero1 * Numero2;
        }
        public object Dividir()
        {
            if (Numero2 != 0)
            {
                return Numero1 / Numero2;
            }
            else
            {
                return "No se puede dividir entre 0";
            }
        }
            public double Raiz()
            {
            return Math.Sqrt(Numero1);
            }
    }
}