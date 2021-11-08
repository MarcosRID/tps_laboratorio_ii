using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo { CuatroPuertas, CincoPuertas }
        
        ETipo tipo;
        ETamanio tamanio;

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : this( marca, chasis , color, ETipo.CuatroPuertas)
        { }
        
        public Sedan(EMarca marca, string chasis, ConsoleColor color,ETipo auxTipo)
            : base(chasis, marca, color)
        {
            this.tipo = auxTipo;
            this.tamanio = ETamanio.Mediano;
        }



        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        public override ETamanio Tamanio
        {
            get
            {
                return this.tamanio;
            }
        }
        public  ETipo Tipo
        {
            get
            {
                return this.tipo;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.Append($"TAMAÑO : { this.Tamanio} ");
            sb.AppendLine($"TIPO : {this.tipo}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
