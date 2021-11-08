using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;

namespace Mercado
{
    public partial class FormTicket : Form
    {
        FormPrincipal formPrincipalPadre;

        public FormTicket(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            formPrincipalPadre = formPrincipal;
        }

        private void FormTicket_Load(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = formPrincipalPadre.listaClientes.Dequeue();

                Ticket ticket = new Ticket(cliente.ListaProducto,'B');
                formPrincipalPadre.supermercado.Historial_de_venta.Add(ticket);

                this.lsbTicket.DataSource = (List<string>)ticket;
            }
            catch (Exception)
            {}
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                path += @"\Historial_Ventas";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                Archivos<List<Ticket>>.Serializar( this.formPrincipalPadre.supermercado.Historial_de_venta ,path + @"\Tickes.xml");
                this.btnCerrar_Click(sender,e);

            }
            catch (Exception)
            {
            }

        }
    }
}
