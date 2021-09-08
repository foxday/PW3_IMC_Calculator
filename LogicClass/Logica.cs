using System;
using System.Diagnostics;

namespace LogicClass
{
    public class Logica
    {
        public static double CalculateIMC(int weight, double heigth)
        {
            double imc = Math.Round(weight / Math.Pow(heigth / 100, 2), 2); 
            return imc;
        }

        public static string ShowIMCDetails(double imc)
        {
            string IMCdescription = "";
            switch (imc)
            {
                case double n when n <16.00:
                    IMCdescription = "Bajo peso - Delgadez severa (<16.00)";
                    break;
                case double n when n >= 16.00 && n<=16.99:
                    IMCdescription = "Bajo peso - Delgadez moderada (16.00 - 16.99)";
                    break;
                case double n when n >= 17.00 && n <= 18.49:
                    IMCdescription = "Bajo peso - Delgadez leve (17.00 - 18.49)";
                    break;
                case double n when n >= 18.50 && n <= 24.99:
                    IMCdescription = "Normal (18.5 - 24.99)";
                    break;
                case double n when n >= 25.00 && n <= 29.99:
                    IMCdescription = "Sobrepeso - Preobesidad (25.00 - 29.99)";
                    break;
                case double n when n >= 30.00 && n <= 34.99:
                    IMCdescription = "Obesidad - Obesidad leve (30.00 - 34.99)";
                    break;
                case double n when n >= 35.00 && n <= 39.99:
                    IMCdescription = "Obesidad - Obesidad media (35.00 - 39.99)";
                    break;
                case double n when n >= 40.00:
                    IMCdescription = "Obesidad - Obesidad mórbida (≥40.00)";
                    break;
                default:
                    IMCdescription = "Out of range.";
                    break;
            }
            return IMCdescription;
        }
    }
}


