using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        #region Atributos/Propiedades

        protected string nombre;
        protected double precio;
        protected int codigo;
        protected int stock;
        protected bool stock_SI_NO;


        public abstract string Nombre { get; set; }
        public abstract double Precio { get; set; }
        public abstract int Codigo { get; set; }
        public virtual int Stock { get; set; }
        public virtual bool Stock_SI_NO { get; set; }

        #endregion


        #region Constructor

        public Producto()
        { }

        public Producto(string nombre,int codigo) :this (nombre,0,codigo)
        {}

        public Producto(string nombre, double precio, int codigo) : this (nombre,precio,codigo,0,false)
        {}

        public Producto(string nombre, double precio, int codigo, int stock, bool stock_SI_NO)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.codigo = codigo;
            this.stock = stock;
            this.stock_SI_NO = stock_SI_NO;
        }

        #endregion



        #region Override/Sobrecargas


        public static List<Producto> operator -(List<Producto> lp, Producto p)
        {
            if (p is not null && lp is not null)
            {

                foreach (Producto item in lp)
                {
                    if (p == item)
                    {
                        lp.Remove(item);
                        break;
                    }
                }
            }

            return lp;
        }

        public static List<ProductoSeleccionado> operator -(List<ProductoSeleccionado> lp, Producto p)
        {
            if (p is not null && lp is not null)
            {

                foreach (ProductoSeleccionado item in lp)
                {
                    if (p == item)
                    {
                        lp.Remove(item);
                        break;
                    }
                }
            }

            return lp;
        }



        public static bool operator ==(Producto p1, Producto p2)
        {
            bool rta = false;

            if (!(p1 is null) && !(p2 is null) && p1.codigo == p2.codigo)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator !=(Producto p1, Producto p2)
        { return !(p1 == p2); }
        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Codigo: {this.codigo}");
            sb.AppendLine($"Stock: {this.stock}");

            return sb.ToString();
        }

        public static bool operator ==(Producto p1, int codigo)
        {
            bool rta = false;

            if (!(p1 is null) && p1.codigo == codigo)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator !=(Producto p1, int codigo)
        { return !(p1 == codigo); }

        #endregion


    }
}
