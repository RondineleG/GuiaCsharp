using System;

namespace CalculoIMC
{
    internal class CalculaIMC
    {                            
        public Double Calcular(Double peso, Double altura)
        {
            return  ((peso) / (altura * altura));           
        }
        
        public String ClassificarIMC(Double imc)
        {
            if (imc < 16)
            {
                return "Magreza grave";
            }
            else if (imc >= 16 && imc < 17)
            {
                return "Magreza moderada";
            }
            else if (imc >= 17 && imc < 18.5)
            {
                return "Magreza leve";
            }
            else if (imc >= 18.5 && imc < 25)
            {
                return "Saudável";
            }
            else if (imc >= 25 && imc < 30)
            {
                return "Sobrepeso";
            }
            else if (imc >= 30 && imc < 35)
            {
                return "Obesidade Grau 1";
            }
            else if (imc >= 35 && imc < 40)
            {
                return "Obesidade Grau 2 (severa)";
            }
            else if (imc > 40)
            {
                return "Obesidade Grau 3 (mórbida)";
            }
            return "";

        }
                          
    }

}