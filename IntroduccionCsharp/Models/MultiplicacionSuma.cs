using System;

namespace IntroduccionCsharp.Models
{
    public class MultiplicacionSuma
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Res { get; set; }

        public void Multiplicar()
        {
            Res = 0;
            // for para hacer la multiplicacion con sumas
            for (int i = 0; i < Num2; i++)
            {
                Res += Num1;
            }
        }
    }
}