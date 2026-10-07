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
            components = new System.ComponentModel.Container();
            grpDatosClientes = new GroupBox();
            lblComuna = new Label();
            cboComuna = new ComboBox();
            txtNombrePyme = new TextBox();
            lblPyme = new Label();
            lblPaneles = new Label();
            btnCalcular = new Button();
            chkIncluirBaterias = new CheckBox();
            txtTarifaPanel = new TextBox();
            lblTarifaPanel = new Label();
            grpDimensionamiento = new GroupBox();
            lblPresupuesto = new Label();
            txtPresupuesto = new TextBox();
            txtInversor = new TextBox();
            lblInversor = new Label();
            chkFomento = new CheckBox();
            txtPaneles = new TextBox();
            btnLimpiar = new Button();
            grpResultados = new GroupBox();
            lblResViabilidad = new Label();
            label1 = new Label();
            lblResultadoTotal = new Label();
            lblTituloResultado = new Label();
            lblValorTotalNeto = new Label();
            lblValorIVA = new Label();
            lblValorSubTotal = new Label();
            lblTotalNeto = new Label();
            lblIva = new Label();
            lblSubTotal = new Label();
            btnSalir = new Button();
            toolTip1 = new ToolTip(components);
            bindingSource1 = new BindingSource(components);
            grpDatosClientes.SuspendLayout();
            grpDimensionamiento.SuspendLayout();
            grpResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // grpDatosClientes
            // 
            grpDatosClientes.Controls.Add(lblComuna);
            grpDatosClientes.Controls.Add(cboComuna);
            grpDatosClientes.Controls.Add(txtNombrePyme);
            grpDatosClientes.Controls.Add(lblPyme);
            grpDatosClientes.Location = new Point(12, 11);
            grpDatosClientes.Margin = new Padding(3, 2, 3, 2);
            grpDatosClientes.Name = "grpDatosClientes";
            grpDatosClientes.Padding = new Padding(3, 2, 3, 2);
            grpDatosClientes.Size = new Size(403, 84);
            grpDatosClientes.TabIndex = 0;
            grpDatosClientes.TabStop = false;
            grpDatosClientes.Text = "Datos de la PYME Cliente";
            // 
            // lblComuna
            // 
            lblComuna.AutoSize = true;
            lblComuna.Location = new Point(259, 29);
            lblComuna.Name = "lblComuna";
            lblComuna.Size = new Size(53, 15);
            lblComuna.TabIndex = 3;
            lblComuna.Text = "Comuna";
            // 
            // cboComuna
            // 
            cboComuna.DropDownStyle = ComboBoxStyle.DropDownList;
            cboComuna.FormattingEnabled = true;
            cboComuna.Location = new Point(226, 46);
            cboComuna.Margin = new Padding(3, 2, 3, 2);
            cboComuna.Name = "cboComuna";
            cboComuna.Size = new Size(133, 23);
            cboComuna.TabIndex = 1;
            cboComuna.SelectedIndexChanged += cboComuna_SelectedIndexChanged;
            // 
            // txtNombrePyme
            // 
            txtNombrePyme.Location = new Point(50, 46);
            txtNombrePyme.Margin = new Padding(3, 2, 3, 2);
            txtNombrePyme.Name = "txtNombrePyme";
            txtNombrePyme.PlaceholderText = "Ej: Agrícola El Roble Ltda.";
            txtNombrePyme.Size = new Size(110, 23);
            txtNombrePyme.TabIndex = 0;
            txtNombrePyme.TextChanged += txtNombrePyme_TextChanged;
            // 
            // lblPyme
            // 
            lblPyme.AutoSize = true;
            lblPyme.Location = new Point(50, 29);
            lblPyme.Name = "lblPyme";
            lblPyme.Size = new Size(112, 15);
            lblPyme.TabIndex = 0;
            lblPyme.Text = "Nombre de la Pyme";
            lblPyme.Click += label1_Click;
            // 
            // lblPaneles
            // 
            lblPaneles.AutoSize = true;
            lblPaneles.Location = new Point(15, 19);
            lblPaneles.Name = "lblPaneles";
            lblPaneles.Size = new Size(114, 15);
            lblPaneles.TabIndex = 5;
            lblPaneles.Text = "Cantidad de paneles";
            lblPaneles.Click += label3_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(0, 47, 108);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(12, 432);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(133, 28);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "\U0001f9ee Calcular Cotización";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcularCotizacion_Click;
            // 
            // chkIncluirBaterias
            // 
            chkIncluirBaterias.AutoSize = true;
            chkIncluirBaterias.Location = new Point(19, 100);
            chkIncluirBaterias.Name = "chkIncluirBaterias";
            chkIncluirBaterias.Size = new Size(100, 19);
            chkIncluirBaterias.TabIndex = 2;
            chkIncluirBaterias.Text = "IncluirBaterias";
            chkIncluirBaterias.UseVisualStyleBackColor = true;
            // 
            // txtTarifaPanel
            // 
            txtTarifaPanel.Location = new Point(135, 36);
            txtTarifaPanel.Name = "txtTarifaPanel";
            txtTarifaPanel.PlaceholderText = "50.0 - 1500.0 USD";
            txtTarifaPanel.Size = new Size(100, 23);
            txtTarifaPanel.TabIndex = 3;
            txtTarifaPanel.TextChanged += txtTarifaPanel_TextChanged;
            // 
            // lblTarifaPanel
            // 
            lblTarifaPanel.AutoSize = true;
            lblTarifaPanel.Location = new Point(140, 19);
            lblTarifaPanel.Name = "lblTarifaPanel";
            lblTarifaPanel.Size = new Size(93, 15);
            lblTarifaPanel.TabIndex = 7;
            lblTarifaPanel.Text = "Precio por Panel";
            // 
            // grpDimensionamiento
            // 
            grpDimensionamiento.Controls.Add(lblPresupuesto);
            grpDimensionamiento.Controls.Add(txtPresupuesto);
            grpDimensionamiento.Controls.Add(txtInversor);
            grpDimensionamiento.Controls.Add(lblInversor);
            grpDimensionamiento.Controls.Add(chkFomento);
            grpDimensionamiento.Controls.Add(lblTarifaPanel);
            grpDimensionamiento.Controls.Add(chkIncluirBaterias);
            grpDimensionamiento.Controls.Add(txtTarifaPanel);
            grpDimensionamiento.Controls.Add(txtPaneles);
            grpDimensionamiento.Controls.Add(lblPaneles);
            grpDimensionamiento.Location = new Point(12, 100);
            grpDimensionamiento.Name = "grpDimensionamiento";
            grpDimensionamiento.Size = new Size(403, 170);
            grpDimensionamiento.TabIndex = 8;
            grpDimensionamiento.TabStop = false;
            grpDimensionamiento.Text = "Dimensionamiento Técnico";
            // 
            // lblPresupuesto
            // 
            lblPresupuesto.AutoSize = true;
            lblPresupuesto.Location = new Point(250, 100);
            lblPresupuesto.Name = "lblPresupuesto";
            lblPresupuesto.Size = new Size(72, 15);
            lblPresupuesto.TabIndex = 13;
            lblPresupuesto.Text = "Presupuesto";
            // 
            // txtPresupuesto
            // 
            txtPresupuesto.Location = new Point(235, 130);
            txtPresupuesto.Margin = new Padding(3, 2, 3, 2);
            txtPresupuesto.Name = "txtPresupuesto";
            txtPresupuesto.PlaceholderText = "500.0 - 100000.0 USD";
            txtPresupuesto.Size = new Size(110, 23);
            txtPresupuesto.TabIndex = 6;
            txtPresupuesto.TextChanged += txtPresupuesto_TextChanged;
            // 
            // txtInversor
            // 
            txtInversor.Location = new Point(246, 36);
            txtInversor.Name = "txtInversor";
            txtInversor.PlaceholderText = "100.0 - 10000.0 USD";
            txtInversor.Size = new Size(113, 23);
            txtInversor.TabIndex = 4;
            // 
            // lblInversor
            // 
            lblInversor.AutoSize = true;
            lblInversor.Location = new Point(261, 19);
            lblInversor.Name = "lblInversor";
            lblInversor.Size = new Size(49, 15);
            lblInversor.TabIndex = 10;
            lblInversor.Text = "Inversor";
            // 
            // chkFomento
            // 
            chkFomento.AutoSize = true;
            chkFomento.Location = new Point(19, 75);
            chkFomento.Name = "chkFomento";
            chkFomento.Size = new Size(303, 19);
            chkFomento.TabIndex = 5;
            chkFomento.Text = "Aplicar Descuento Estatal por Generación Distribuida";
            toolTip1.SetToolTip(chkFomento, "Aplica un 10% de descuento directo sobre el total neto según la Ley 20.571");
            chkFomento.UseVisualStyleBackColor = true;
            // 
            // txtPaneles
            // 
            txtPaneles.Location = new Point(19, 36);
            txtPaneles.Margin = new Padding(3, 2, 3, 2);
            txtPaneles.Name = "txtPaneles";
            txtPaneles.PlaceholderText = "1 - 200";
            txtPaneles.Size = new Size(110, 23);
            txtPaneles.TabIndex = 2;
            txtPaneles.TextChanged += txtPaneles_TextChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(100, 116, 139);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(144, 432);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(137, 28);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "\U0001f9f9 Limpiar Formulario";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // grpResultados
            // 
            grpResultados.Controls.Add(lblResViabilidad);
            grpResultados.Controls.Add(label1);
            grpResultados.Controls.Add(lblResultadoTotal);
            grpResultados.Controls.Add(lblTituloResultado);
            grpResultados.Controls.Add(lblValorTotalNeto);
            grpResultados.Controls.Add(lblValorIVA);
            grpResultados.Controls.Add(lblValorSubTotal);
            grpResultados.Controls.Add(lblTotalNeto);
            grpResultados.Controls.Add(lblIva);
            grpResultados.Controls.Add(lblSubTotal);
            grpResultados.Enabled = false;
            grpResultados.Location = new Point(16, 271);
            grpResultados.Name = "grpResultados";
            grpResultados.Size = new Size(399, 153);
            grpResultados.TabIndex = 9;
            grpResultados.TabStop = false;
            grpResultados.Text = "Resultados";
            grpResultados.Enter += grpResultados_Enter;
            // 
            // lblResViabilidad
            // 
            lblResViabilidad.AutoSize = true;
            lblResViabilidad.Location = new Point(208, 116);
            lblResViabilidad.Name = "lblResViabilidad";
            lblResViabilidad.Size = new Size(74, 15);
            lblResViabilidad.TabIndex = 9;
            lblResViabilidad.Text = "No evaluado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 89);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 8;
            label1.Text = "Viabilidad técnica";
            // 
            // lblResultadoTotal
            // 
            lblResultadoTotal.AutoSize = true;
            lblResultadoTotal.Location = new Point(43, 116);
            lblResultadoTotal.Name = "lblResultadoTotal";
            lblResultadoTotal.Size = new Size(52, 15);
            lblResultadoTotal.TabIndex = 7;
            lblResultadoTotal.Text = "_________";
            lblResultadoTotal.Click += lblResultadoTotal_Click;
            // 
            // lblTituloResultado
            // 
            lblTituloResultado.AutoSize = true;
            lblTituloResultado.Location = new Point(43, 89);
            lblTituloResultado.Name = "lblTituloResultado";
            lblTituloResultado.Size = new Size(86, 15);
            lblTituloResultado.TabIndex = 6;
            lblTituloResultado.Text = "Resultado total";
            // 
            // lblValorTotalNeto
            // 
            lblValorTotalNeto.AutoSize = true;
            lblValorTotalNeto.Location = new Point(257, 57);
            lblValorTotalNeto.Name = "lblValorTotalNeto";
            lblValorTotalNeto.Size = new Size(37, 15);
            lblValorTotalNeto.TabIndex = 5;
            lblValorTotalNeto.Text = "______";
            // 
            // lblValorIVA
            // 
            lblValorIVA.AutoSize = true;
            lblValorIVA.Location = new Point(151, 57);
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
            lblTotalNeto.Location = new Point(255, 30);
            lblTotalNeto.Name = "lblTotalNeto";
            lblTotalNeto.Size = new Size(61, 15);
            lblTotalNeto.TabIndex = 2;
            lblTotalNeto.Text = "Total Neto";
            // 
            // lblIva
            // 
            lblIva.AutoSize = true;
            lblIva.Location = new Point(159, 30);
            lblIva.Name = "lblIva";
            lblIva.Size = new Size(24, 15);
            lblIva.TabIndex = 1;
            lblIva.Text = "IVA";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(28, 30);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(55, 15);
            lblSubTotal.TabIndex = 0;
            lblSubTotal.Text = "Sub Total";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(220, 38, 38);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(278, 432);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(137, 28);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "❌ Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormCotizador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(449, 472);
            Controls.Add(btnSalir);
            Controls.Add(grpResultados);
            Controls.Add(btnLimpiar);
            Controls.Add(grpDimensionamiento);
            Controls.Add(grpDatosClientes);
            Controls.Add(btnCalcular);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCotizador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Cotización Solar - IPVG2026";
            Load += FormCotizador_Load_1;
            grpDatosClientes.ResumeLayout(false);
            grpDatosClientes.PerformLayout();
            grpDimensionamiento.ResumeLayout(false);
            grpDimensionamiento.PerformLayout();
            grpResultados.ResumeLayout(false);
            grpResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatosClientes;
        private Label lblPyme;
        private TextBox txtNombrePyme;
        private Label lblPaneles;
        private Label lblComuna;
        private ComboBox cboComuna;
        private Button btnCalcular;
        private CheckBox chkIncluirBaterias;
        private TextBox txtTarifaPanel;
        private Label lblTarifaPanel;
        private GroupBox grpDimensionamiento;
        private CheckBox chkFomento;
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
        private TextBox txtInversor;
        private Label lblInversor;
        private Label lblPresupuesto;
        private TextBox txtPresupuesto;
        private Button btnSalir;
        private ToolTip toolTip1;
        private BindingSource bindingSource1;
        private TextBox txtPaneles;
        private Label lblResViabilidad;
        private Label label1;
    }
}
