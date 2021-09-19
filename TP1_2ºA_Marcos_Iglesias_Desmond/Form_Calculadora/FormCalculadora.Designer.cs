
namespace Form_Calculadora
{
    partial class FormCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Operar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Convertir_a_Binario = new System.Windows.Forms.Button();
            this.btn_Convertir_a_Decimal = new System.Windows.Forms.Button();
            this.cbx_Operador = new System.Windows.Forms.ComboBox();
            this.txt_Numero1 = new System.Windows.Forms.TextBox();
            this.txt_Numero2 = new System.Windows.Forms.TextBox();
            this.lst_Operaciones = new System.Windows.Forms.ListBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Operar
            // 
            this.btn_Operar.Location = new System.Drawing.Point(25, 119);
            this.btn_Operar.Name = "btn_Operar";
            this.btn_Operar.Size = new System.Drawing.Size(75, 23);
            this.btn_Operar.TabIndex = 4;
            this.btn_Operar.Text = "Operar";
            this.btn_Operar.UseVisualStyleBackColor = true;
            this.btn_Operar.Click += new System.EventHandler(this.btn_Operar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(140, 119);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 5;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(257, 119);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cerrar.TabIndex = 6;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Convertir_a_Binario
            // 
            this.btn_Convertir_a_Binario.Location = new System.Drawing.Point(25, 181);
            this.btn_Convertir_a_Binario.Name = "btn_Convertir_a_Binario";
            this.btn_Convertir_a_Binario.Size = new System.Drawing.Size(139, 46);
            this.btn_Convertir_a_Binario.TabIndex = 7;
            this.btn_Convertir_a_Binario.Text = "Convertir a Binario";
            this.btn_Convertir_a_Binario.UseVisualStyleBackColor = true;
            this.btn_Convertir_a_Binario.Click += new System.EventHandler(this.btn_Convertir_a_Binario_Click);
            // 
            // btn_Convertir_a_Decimal
            // 
            this.btn_Convertir_a_Decimal.Location = new System.Drawing.Point(193, 181);
            this.btn_Convertir_a_Decimal.Name = "btn_Convertir_a_Decimal";
            this.btn_Convertir_a_Decimal.Size = new System.Drawing.Size(139, 46);
            this.btn_Convertir_a_Decimal.TabIndex = 8;
            this.btn_Convertir_a_Decimal.Text = "Convertir a Decimal";
            this.btn_Convertir_a_Decimal.UseVisualStyleBackColor = true;
            this.btn_Convertir_a_Decimal.Click += new System.EventHandler(this.btn_Convertir_a_Decimal_Click);
            // 
            // cbx_Operador
            // 
            this.cbx_Operador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Operador.FormattingEnabled = true;
            this.cbx_Operador.Location = new System.Drawing.Point(153, 54);
            this.cbx_Operador.Name = "cbx_Operador";
            this.cbx_Operador.Size = new System.Drawing.Size(48, 23);
            this.cbx_Operador.TabIndex = 2;
            // 
            // txt_Numero1
            // 
            this.txt_Numero1.Location = new System.Drawing.Point(25, 54);
            this.txt_Numero1.Name = "txt_Numero1";
            this.txt_Numero1.Size = new System.Drawing.Size(100, 23);
            this.txt_Numero1.TabIndex = 1;
            this.txt_Numero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Numero2
            // 
            this.txt_Numero2.Location = new System.Drawing.Point(232, 54);
            this.txt_Numero2.Name = "txt_Numero2";
            this.txt_Numero2.Size = new System.Drawing.Size(100, 23);
            this.txt_Numero2.TabIndex = 3;
            this.txt_Numero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lst_Operaciones
            // 
            this.lst_Operaciones.FormattingEnabled = true;
            this.lst_Operaciones.ItemHeight = 15;
            this.lst_Operaciones.Location = new System.Drawing.Point(371, 21);
            this.lst_Operaciones.Name = "lst_Operaciones";
            this.lst_Operaciones.Size = new System.Drawing.Size(181, 214);
            this.lst_Operaciones.TabIndex = 9;
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Resultado.Location = new System.Drawing.Point(183, 10);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Resultado.Size = new System.Drawing.Size(182, 36);
            this.lbl_Resultado.TabIndex = 10;
            this.lbl_Resultado.Text = "0";
            this.lbl_Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 249);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.lst_Operaciones);
            this.Controls.Add(this.txt_Numero2);
            this.Controls.Add(this.txt_Numero1);
            this.Controls.Add(this.cbx_Operador);
            this.Controls.Add(this.btn_Convertir_a_Decimal);
            this.Controls.Add(this.btn_Convertir_a_Binario);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Operar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Marcos Ruben Iglesias Desmond del curso  2ºA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btn_Operar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Convertir_a_Binario;
        private System.Windows.Forms.Button btn_Convertir_a_Decimal;
        private System.Windows.Forms.ComboBox cbx_Operador;
        private System.Windows.Forms.TextBox txt_Numero1;
        private System.Windows.Forms.TextBox txt_Numero2;
        private System.Windows.Forms.ListBox lst_Operaciones;

        #endregion

        private System.Windows.Forms.Label lbl_Resultado;
    }
}

