using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoNoCongelado<T> : Producto where T : Enum
    {
        #region Atributos/Propiedades

        T categoria;

        public override string Nombre
        {
            get
            { return this.nombre; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {

                    this.nombre = value;
                }
            }
        }
        public override double Precio
        {
            get
            { return this.precio; }
            set
            {
                if (!double.IsNaN(value))
                {
                    this.precio = value;
                }
            }
        }
        public override int Codigo
        {
            get
            { return this.codigo; }
            set
            {
                if (value > 0)
                {
                    this.codigo = value;
                }
            }
        }
        public override int Stock
        {
            get
            { return this.stock; }
            set
            {
                if (value > 0)
                {
                    this.stock = value;
                }
            }
        }
        public override bool Stock_SI_NO
        {
            get
            { return this.stock_SI_NO; }
            set
            { this.stock_SI_NO = value; }
        }

        public T Categoria
        {
            get
            { return this.categoria; }
            set
            {
                if (value is not null)
                {
                    this.categoria = value;
                }
            }
        }
        #endregion



        #region Constructores


        public ProductoNoCongelado()
        { }

        public ProductoNoCongelado(string nombre, int codigo) : base(nombre, 0, codigo)
        { }

        public ProductoNoCongelado(string nombre, double precio, int codigo, int stock, bool stock_SI_NO, T categoria)
        : base(nombre, precio, codigo, stock, stock_SI_NO)
        {
            this.Categoria = categoria;
        }

        #endregion


        #region Metodos


        /// <summary>
        /// Filtra los productos de una lista generica de productos , en una lista especica de tipo T : Enum
        /// </summary>
        /// <param name="lProductos1"></param>
        /// <returns></returns>
        public static List<ProductoNoCongelado<T>> FiltrarLista(List<Producto> lProductos1)
        {
            List<ProductoNoCongelado<T>> listaGenericaT = new List<ProductoNoCongelado<T>>();

            try
            {
                if (lProductos1 is not null)
                {
                    foreach (Producto item in lProductos1)
                    {
                        if (item is ProductoNoCongelado<T>)
                        {
                            listaGenericaT.Add((ProductoNoCongelado<T>)item);
                        }
                    }
                }

            }
            catch (Exception)
            {

            }

            return listaGenericaT;
        }


        #endregion

    }
}
