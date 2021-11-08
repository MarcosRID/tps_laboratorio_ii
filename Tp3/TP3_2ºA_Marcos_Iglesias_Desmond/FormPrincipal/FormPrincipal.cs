using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;


namespace Mercado
{
    public partial class FormPrincipal : Form
    {
        public Supermercado supermercado;
        public Queue<Cliente> listaClientes;
        public Distribuidor distribuidor;

        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            supermercado = new Supermercado(001, "Coto");
            listaClientes = new Queue<Cliente>();
            distribuidor = new Distribuidor();

            this.btnBalanceDelMes.Enabled = false;

            #region Lista Clente Harcodeada
            distribuidor.harcodearDatos();
            supermercado.harcodearDatos();
            List<ProductoSeleccionado> listaProductoSeleccionados1 = new List<ProductoSeleccionado>();

            listaProductoSeleccionados1.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[0], 3));
            listaProductoSeleccionados1.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[3], 3));
            listaProductoSeleccionados1.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[5], 10));
            listaProductoSeleccionados1.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[7], 1));
            listaProductoSeleccionados1.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[8], 2));
            listaProductoSeleccionados1.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[10], 1));

            List<ProductoSeleccionado> listaProductoSeleccionados2 = new List<ProductoSeleccionado>();

            listaProductoSeleccionados2.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[11], 13));
            listaProductoSeleccionados2.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[12], 3));
            listaProductoSeleccionados2.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[13], 1));
            listaProductoSeleccionados2.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[7], 1));
            listaProductoSeleccionados2.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[16], 2));
            listaProductoSeleccionados2.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[22], 1));

            List<ProductoSeleccionado> listaProductoSeleccionados3 = new List<ProductoSeleccionado>();

            listaProductoSeleccionados3.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[0], 3));
            listaProductoSeleccionados3.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[3], 3));
            listaProductoSeleccionados3.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[5], 11));
            listaProductoSeleccionados3.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[10], 1));

            listaClientes.Enqueue(new Cliente(listaProductoSeleccionados1, "Usuario : 0 (Prurba)"));
            listaClientes.Enqueue(new Cliente(listaProductoSeleccionados2, "Usuario : 1 (Prurba)"));
            listaClientes.Enqueue(new Cliente(listaProductoSeleccionados3, "Usuario : 2 (Prurba)"));

            #endregion
        }

        private void btnAtenderCaja_Click(object sender, EventArgs e)
        {

            try
            {
                FormCaja formCaja = new FormCaja(this);

                formCaja.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FormClienteRealizaCompra formClienteRealizaCompra = new FormClienteRealizaCompra(this);

                formClienteRealizaCompra.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnRenovarSotck_Click(object sender, EventArgs e)
        {
            try
            {
                formRenovarStock formRenovarStock = new formRenovarStock(this);

                formRenovarStock.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnBalanceDelMes_Click(object sender, EventArgs e)
        {

        }
    }
}
