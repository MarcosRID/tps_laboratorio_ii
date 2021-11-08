using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Form_Calculadora
{
    public partial class FormCalculadora : Form
    {
        #region Atributos

        private Operando operador1;
        private Operando operador2;
        private double ultimoResultado;
        string resultadoBinario;
        bool estadoBinario = false;
        string numeroAtenroir1 = string.Empty;
        string numeroAtenroir2 = string.Empty;
        string operadorAterior = string.Empty;

        #endregion


        public FormCalculadora()
        {
            InitializeComponent();
        }


        #region Metodos


        /// <summary>
        /// Cargo  todos los datos antes de ser visible el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            char[] arrayOperadores = new char[4] { '+', '*', '-', '/' };

            foreach (char item in arrayOperadores)
            {
                cbx_Operador.Items.Add(item);
            }

            this.btn_Limpiar_Click(sender, e);
        }


        /// <summary>
        /// Llama al metodo Operar para realizar la operacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Operar_Click(object sender, EventArgs e)
        {
            string numero1 = txt_Numero1.Text;
            string numero2 = txt_Numero2.Text;
            string operador = string.Empty;
            double validarNumero;


            if (!string.IsNullOrEmpty(numero1) && !string.IsNullOrEmpty(numero2) && !string.IsNullOrWhiteSpace(numero1) && !string.IsNullOrWhiteSpace(numero2) && !(cbx_Operador.SelectedItem is null)
                && double.TryParse(numero1, out validarNumero) && double.TryParse(numero2, out validarNumero))
            {
                operador = cbx_Operador.SelectedItem.ToString();
                
                if (!this.EsIgual(numero1, numeroAtenroir1, numero2, numeroAtenroir2, operador, operadorAterior))
                {
                    lst_Operaciones.Items.Add($"{numero1} {operador} {numero2} = {this.Operar(numero1, numero2, operador)} ");

                    this.estadoBinario = false;
                    numeroAtenroir1 = numero1;
                    numeroAtenroir2 = numero2;
                    operadorAterior = operador;
                }
            }
        }


        /// <summary>
        /// Realiza la operacion aritmetica espevificada.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private double Operar(string numero1, string numero2, string operador)
        {
            operador1 = new Operando(numero1);
            operador2 = new Operando(numero2);

            double resultado = Calculadora.Operador(operador1, operador2, operador[0]);

            this.ultimoResultado = resultado;
            this.lbl_Resultado.Text = resultado.ToString();

            return resultado;
        }


        /// <summary>
        /// Liempia los componentes de la calculadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Numero1.Text = string.Empty;
            txt_Numero2.Text = string.Empty;
            resultadoBinario = string.Empty;
            estadoBinario = false;
            cbx_Operador.SelectedItem = null;
            lbl_Resultado.Text = null;
            ultimoResultado = 0;
        }




        /// <summary>
        /// Convierte un nuemro decimal a binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Convertir_a_Binario_Click(object sender, EventArgs e)
        {
            if (!this.estadoBinario)
            {
                this.ultimoResultado = this.operador1.DecimalBinario(this.ultimoResultado.ToString());
                this.lbl_Resultado.Text = ultimoResultado.ToString();
                this.estadoBinario = true;
            }
        }

        /// <summary>
        /// Convierte un numero binario a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Convertir_a_Decimal_Click(object sender, EventArgs e)
        {
            if (this.estadoBinario)
            {
                this.resultadoBinario = this.operador1.BinarioDecimal(this.ultimoResultado.ToString());
                double.TryParse(resultadoBinario, out ultimoResultado);

                this.lbl_Resultado.Text = ultimoResultado.ToString();
                this.estadoBinario = false;
            }
        }


        /// <summary>
        /// Cierra el form, con confirmacion del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Desea salir?", "Saliendo", MessageBoxButtons.YesNo);

            if (rta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Cierra el form, con confirmacion del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Desea salir?", "Saliendo", MessageBoxButtons.YesNo);

            if (rta == DialogResult.Yes)
            {
                this.Dispose();
            }
        }


        /// <summary>
        /// Verifica si los datos de la operacion anterior es igual a la actual.
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        /// <param name="operador1"></param>
        /// <param name="operador2"></param>
        /// <returns></returns>
        private bool EsIgual(string a1, string a2, string b1, string b2, string operador1, string operador2)
        {
            return (a1 == a2 && b1 == b2 && operador1 == operador2);
        }

        #endregion

    }
}
