using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {

        private double numero;

        #region Constructores

        public Operando() : this(0)
        {}

        public Operando(double numero)
        {
            this.Numero = numero.ToString();
        }

        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        #endregion



        #region Propiedades

        private string Numero
        {
            set
            {
                double auxNumerothis = ValidarOperando(value.ToString());

                if (auxNumerothis !=0)
                {
                    this.numero = auxNumerothis;
                }
            }
        }

        #endregion



        #region Metodos


        /// <summary>
        /// Combienrte un string de un numero bienario a un string con un nuemro entero
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            double numero = 0;
            string auxBinario = "Valor invalido";
            int exponente = (binario.Length - 1);


            if (this.EsBinario(binario))
            {
                foreach (char i in binario)
                {
                    if (i == '1')
                    {
                        numero += Math.Pow(2, exponente);
                    }

                    exponente--;
                }
                auxBinario = numero.ToString();
            }

            return auxBinario;
        }

        
        /// <summary>
        /// combienrte un numero doble en un string en su formato bienario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            string strNumero = "Valor invalido";
            double auxNumero = 0;

            if (numero >= 0)
            {
                auxNumero = this.DecimalBinario(numero.ToString());
                
                if (auxNumero == -1)
                {
                    strNumero = auxNumero.ToString();
                }
            }

            return strNumero;
        }


        /// <summary>
        /// Combienrte un numero a su formato binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public double DecimalBinario(string numero)
        {
            double auxNumero;
            string numeroBinario = "";

            if (double.TryParse(numero, out auxNumero))
            {

                do
                {
                    if (auxNumero == 0)
                    {
                        numeroBinario = string.Format($"0{numeroBinario}");
                        return double.Parse(numeroBinario);
                    }
                    else if (auxNumero == 1)
                    {
                        numeroBinario = string.Format($"1{numeroBinario}");
                        return double.Parse(numeroBinario);
                    }


                    if (auxNumero % 2 == 0)
                    {
                        numeroBinario = string.Format($"0{numeroBinario}");
                    }
                    else
                    {
                        numeroBinario = string.Format($"1{numeroBinario}");
                    }

                    auxNumero = (int)(auxNumero / 2);


                } while (true); ;

            }

            return -1;
        }


        /// <summary>
        /// Verifiva si es un string solo con "0" y "1"
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private bool EsBinario(string binario)
        {
            bool esBinario = false;

            if (!(binario is null))
            {
                foreach (char item in binario)
                {
                    if (item != '1' && item != '0')
                    {
                        return esBinario;
                    }
                }

                esBinario = true;
            }

            return esBinario;
        }

        /// <summary>
        /// Valida que el string ingresado sea un numero.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarOperando(string strNumero)
        {
            double auxNumero = 0;

            if (!(strNumero is null) && double.TryParse(strNumero, out auxNumero))
            { }

            return auxNumero;
        }

        #endregion



        #region Sobrecargas

        public static double operator +(Operando n1, Operando n2)
        { return n1.numero + n2.numero; }
        public static double operator -(Operando n1, Operando n2)
        { return n1.numero - n2.numero; }
        public static double operator *(Operando n1, Operando n2)
        { return n1.numero * n2.numero; }
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero > 0)
            {
                return n1.numero / n2.numero;
            }
            return double.MinValue;
        }


        #endregion



    }
}
