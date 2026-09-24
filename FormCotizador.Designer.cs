namespace CotizadorSolarPyme.GUI
{
    partial class FormCotizador
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
            grpDatosClientes = new GroupBox();
            lblNombreComuna = new Label();
            cboComuna = new ComboBox();
            txtNombrePyme = new TextBox();
            lblNombrePyme = new Label();
            label3 = new Label();
            txtCantidadPaneles = new TextBox();
            btnCalcularCotizacion = new Button();
            chkIncluirBaterias = new CheckBox();
            txtPrecioPanel = new TextBox();
            lblTituloPrecio = new Label();
            grpEspecificaciones = new GroupBox();
            chkDescuentoFomento = new CheckBox();
            btnLimpiar = new Button();
            grpResultados = new GroupBox();
            lblResultadoTotal = new Label();
            lblTituloResultado = new Label();
            lblValorTotalNeto = new Label();
            lblValorIVA = new Label();
            lblValorSubTotal = new Label();
            lblTotalNeto = new Label();
            lblIva = new Label();
            lblSubTotal = new Label();
            grpDatosClientes.SuspendLayout();
            grpEspecificaciones.SuspendLayout();
            grpResultados.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatosClientes
            // 
            grpDatosClientes.Controls.Add(lblNombreComuna);
            grpDatosClientes.Controls.Add(cboComuna);
            grpDatosClientes.Controls.Add(txtNombrePyme);
            grpDatosClientes.Controls.Add(lblNombrePyme);
            grpDatosClientes.Location = new Point(12, 11);
            grpDatosClientes.Margin = new Padding(3, 2, 3, 2);
            grpDatosClientes.Name = "grpDatosClientes";
            grpDatosClientes.Padding = new Padding(3, 2, 3, 2);
            grpDatosClientes.Size = new Size(350, 138);
            grpDatosClientes.TabIndex = 0;
            grpDatosClientes.TabStop = false;
            grpDatosClientes.Text = "Datos de la PYME Cliente";
            // 
            // lblNombreComuna
            // 
            lblNombreComuna.AutoSize = true;
            lblNombreComuna.Location = new Point(179, 29);
            lblNombreComuna.Name = "lblNombreComuna";
            lblNombreComuna.Size = new Size(53, 15);
            lblNombreComuna.TabIndex = 3;
            lblNombreComuna.Text = "Comuna";
            // 
            // cboComuna
            // 
            cboComuna.FormattingEnabled = true;
            cboComuna.Location = new Point(149, 58);
            cboComuna.Margin = new Padding(3, 2, 3, 2);
            cboComuna.Name = "cboComuna";
            cboComuna.Size = new Size(133, 23);
            cboComuna.TabIndex = 2;
            // 
            // txtNombrePyme
            // 
            txtNombrePyme.Location = new Point(19, 58);
            txtNombrePyme.Margin = new Padding(3, 2, 3, 2);
            txtNombrePyme.Name = "txtNombrePyme";
            txtNombrePyme.Size = new Size(110, 23);
            txtNombrePyme.TabIndex = 1;
            // 
            // lblNombrePyme
            // 
            lblNombrePyme.AutoSize = true;
            lblNombrePyme.Location = new Point(23, 29);
            lblNombrePyme.Name = "lblNombrePyme";
            lblNombrePyme.Size = new Size(112, 15);
            lblNombrePyme.TabIndex = 0;
            lblNombrePyme.Text = "Nombre de la Pyme";
            lblNombrePyme.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 29);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 5;
            label3.Text = "Cantidad de paneles";
            label3.Click += label3_Click;
            // 
            // txtCantidadPaneles
            // 
            txtCantidadPaneles.Location = new Point(19, 46);
            txtCantidadPaneles.Margin = new Padding(3, 2, 3, 2);
            txtCantidadPaneles.Name = "txtCantidadPaneles";
            txtCantidadPaneles.Size = new Size(110, 23);
            txtCantidadPaneles.TabIndex = 4;
            txtCantidadPaneles.TextChanged += txtCantidadPaneles_TextChanged;
            // 
            // btnCalcularCotizacion
            // 
            btnCalcularCotizacion.Location = new Point(149, 107);
            btnCalcularCotizacion.Name = "btnCalcularCotizacion";
            btnCalcularCotizacion.Size = new Size(133, 23);
            btnCalcularCotizacion.TabIndex = 1;
            btnCalcularCotizacion.Text = "Calcular Cotizacion";
            btnCalcularCotizacion.UseVisualStyleBackColor = true;
            // 
            // chkIncluirBaterias
            // 
            chkIncluirBaterias.AutoSize = true;
            chkIncluirBaterias.Location = new Point(19, 107);
            chkIncluirBaterias.Name = "chkIncluirBaterias";
            chkIncluirBaterias.Size = new Size(100, 19);
            chkIncluirBaterias.TabIndex = 2;
            chkIncluirBaterias.Text = "IncluirBaterias";
            chkIncluirBaterias.UseVisualStyleBackColor = true;
            // 
            // txtPrecioPanel
            // 
            txtPrecioPanel.Location = new Point(167, 46);
            txtPrecioPanel.Name = "txtPrecioPanel";
            txtPrecioPanel.Size = new Size(100, 23);
            txtPrecioPanel.TabIndex = 6;
            // 
            // lblTituloPrecio
            // 
            lblTituloPrecio.AutoSize = true;
            lblTituloPrecio.Location = new Point(174, 28);
            lblTituloPrecio.Name = "lblTituloPrecio";
            lblTituloPrecio.Size = new Size(93, 15);
            lblTituloPrecio.TabIndex = 7;
            lblTituloPrecio.Text = "Precio por Panel";
            // 
            // grpEspecificaciones
            // 
            grpEspecificaciones.Controls.Add(chkDescuentoFomento);
            grpEspecificaciones.Controls.Add(btnCalcularCotizacion);
            grpEspecificaciones.Controls.Add(lblTituloPrecio);
            grpEspecificaciones.Controls.Add(chkIncluirBaterias);
            grpEspecificaciones.Controls.Add(txtPrecioPanel);
            grpEspecificaciones.Controls.Add(txtCantidadPaneles);
            grpEspecificaciones.Controls.Add(label3);
            grpEspecificaciones.Location = new Point(12, 154);
            grpEspecificaciones.Name = "grpEspecificaciones";
            grpEspecificaciones.Size = new Size(350, 146);
            grpEspecificaciones.TabIndex = 8;
            grpEspecificaciones.TabStop = false;
            grpEspecificaciones.Text = "\"Dimensionamiento Técnico";
            // 
            // chkDescuentoFomento
            // 
            chkDescuentoFomento.AutoSize = true;
            chkDescuentoFomento.Location = new Point(19, 82);
            chkDescuentoFomento.Name = "chkDescuentoFomento";
            chkDescuentoFomento.Size = new Size(303, 19);
            chkDescuentoFomento.TabIndex = 9;
            chkDescuentoFomento.Text = "Aplicar Descuento Estatal por Generación Distribuida";
            chkDescuentoFomento.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(107, 474);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(137, 23);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar Formulario";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // grpResultados
            // 
            grpResultados.Controls.Add(lblResultadoTotal);
            grpResultados.Controls.Add(lblTituloResultado);
            grpResultados.Controls.Add(lblValorTotalNeto);
            grpResultados.Controls.Add(lblValorIVA);
            grpResultados.Controls.Add(lblValorSubTotal);
            grpResultados.Controls.Add(lblTotalNeto);
            grpResultados.Controls.Add(lblIva);
            grpResultados.Controls.Add(lblSubTotal);
            grpResultados.Location = new Point(12, 306);
            grpResultados.Name = "grpResultados";
            grpResultados.Size = new Size(350, 153);
            grpResultados.TabIndex = 9;
            grpResultados.TabStop = false;
            grpResultados.Text = "Resultados";
            // 
            // lblResultadoTotal
            // 
            lblResultadoTotal.AutoSize = true;
            lblResultadoTotal.Location = new Point(122, 118);
            lblResultadoTotal.Name = "lblResultadoTotal";
            lblResultadoTotal.Size = new Size(52, 15);
            lblResultadoTotal.TabIndex = 7;
            lblResultadoTotal.Text = "_________";
            // 
            // lblTituloResultado
            // 
            lblTituloResultado.AutoSize = true;
            lblTituloResultado.Location = new Point(109, 83);
            lblTituloResultado.Name = "lblTituloResultado";
            lblTituloResultado.Size = new Size(86, 15);
            lblTituloResultado.TabIndex = 6;
            lblTituloResultado.Text = "Resultado total";
            // 
            // lblValorTotalNeto
            // 
            lblValorTotalNeto.AutoSize = true;
            lblValorTotalNeto.Location = new Point(212, 57);
            lblValorTotalNeto.Name = "lblValorTotalNeto";
            lblValorTotalNeto.Size = new Size(37, 15);
            lblValorTotalNeto.TabIndex = 5;
            lblValorTotalNeto.Text = "______";
            // 
            // lblValorIVA
            // 
            lblValorIVA.AutoSize = true;
            lblValorIVA.Location = new Point(136, 57);
            lblValorIVA.Name = "lblValorIVA";
            lblValorIVA.Size = new Size(37, 15);
            lblValorIVA.TabIndex = 4;
            lblValorIVA.Text = "______";
            // 
            // lblValorSubTotal
            // 
            lblValorSubTotal.AutoSize = true;
            lblValorSubTotal.Location = new Point(46, 57);
            lblValorSubTotal.Name = "lblValorSubTotal";
            lblValorSubTotal.Size = new Size(37, 15);
            lblValorSubTotal.TabIndex = 3;
            lblValorSubTotal.Text = "______";
            // 
            // lblTotalNeto
            // 
            lblTotalNeto.AutoSize = true;
            lblTotalNeto.Location = new Point(206, 30);
            lblTotalNeto.Name = "lblTotalNeto";
            lblTotalNeto.Size = new Size(61, 15);
            lblTotalNeto.TabIndex = 2;
            lblTotalNeto.Text = "Total Neto";
            // 
            // lblIva
            // 
            lblIva.AutoSize = true;
            lblIva.Location = new Point(136, 30);
            lblIva.Name = "lblIva";
            lblIva.Size = new Size(24, 15);
            lblIva.TabIndex = 1;
            lblIva.Text = "IVA";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(46, 30);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(55, 15);
            lblSubTotal.TabIndex = 0;
            lblSubTotal.Text = "Sub Total";
            // 
            // FormCotizador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(407, 540);
            Controls.Add(grpResultados);
            Controls.Add(btnLimpiar);
            Controls.Add(grpEspecificaciones);
            Controls.Add(grpDatosClientes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCotizador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Cotización Solar - IPVG2026";
            Load += FormCotizador_Load_1;
            grpDatosClientes.ResumeLayout(false);
            grpDatosClientes.PerformLayout();
            grpEspecificaciones.ResumeLayout(false);
            grpEspecificaciones.PerformLayout();
            grpResultados.ResumeLayout(false);
            grpResultados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatosClientes;
        private Label lblNombrePyme;
        private TextBox txtNombrePyme;
        private Label label3;
        private TextBox txtCantidadPaneles;
        private Label lblNombreComuna;
        private ComboBox cboComuna;
        private Button btnCalcularCotizacion;
        private CheckBox chkIncluirBaterias;
        private TextBox txtPrecioPanel;
        private Label lblTituloPrecio;
        private GroupBox grpEspecificaciones;
        private CheckBox chkDescuentoFomento;
        private Button btnLimpiar;
        private GroupBox grpResultados;
        private Label lblTotalNeto;
        private Label lblIva;
        private Label lblSubTotal;
        private Label lblValorSubTotal;
        private Label lblValorIVA;
        private Label lblValorTotalNeto;
        private Label lblResultadoTotal;
        private Label lblTituloResultado;
    }
}
