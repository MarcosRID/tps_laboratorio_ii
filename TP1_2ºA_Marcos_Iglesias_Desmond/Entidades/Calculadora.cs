using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {

        public static double Operador(Operando num1, Operando num2, char operador)
        {
            double rta = 0;

            if (!(num1 is null) && !(num2 is null) && Calculadora.ValidarOperador(operador) == operador)
            {
                switch (operador)
                {
                    case '+':

                        rta = num1 + num2;

                        break;

                    case '*':

                        rta = num1 * num2;

                        break;

                    case '-':

                        rta = num1 - num2;

                        break;
                    case '/':

                        rta = num1 / num2;

                        break;
                   
                }
            }

            return rta;
        }

        private static char ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '*' || operador == '-' || operador == '/')
            {
                return operador;
            }

            return '+';
        }
    }
}
