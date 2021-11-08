using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class ProductoSeleccionado : Producto
    {
        #region Propiedades / Atributos

        private int cantidad;

        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            { 
                this.cantidad = value;    
            }
        }
        public override string Nombre
        {
            get
            {
                return this.nombre;
            }
            set{ }
        }
        public override double Precio
        {
            get
            {
                return this.precio;
            }
            set{ }
        }
        public override int Codigo
        {
            get
            {
                return this.codigo;
            }
            set{ }
        }
        #endregion


        #region Constructores

        public ProductoSeleccionado()
        {}

        public ProductoSeleccionado(Producto producto ,int cantidad) : base (producto.Nombre,producto.Precio,producto.Codigo)
        {
            this.cantidad = cantidad;
        }

        #endregion


        #region Sobrecarga / Override

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{this.Nombre,-25}{this.Cantidad} X ${this.Precio,-5}");
            sb.Append($"| ### {this.Codigo} ###\n");

            return sb.ToString();
        }

        #endregion

    }
}
