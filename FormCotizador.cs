using System;
using System.Globalization;
using System.Reflection.Emit;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Drawing; // Necesario para la propiedad Color

//IPVG
//Ramo: Construcción de software
//profesor: Gastón González
//Estudiante: jorge a vera videla


namespace CotizadorSolarPyme.GUI
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class FormCotizador : Form
    {
        public FormCotizador()
        {
            InitializeComponent();
            // Evitar ejecutar lógica que modifica el entorno en tiempo de diseño
            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Runtime)
            {
                ConfigurarEntornoInicial(); //add
            }
        }
        private void ConfigurarEntornoInicial()
        {
            // Estandarizar formato de punto decimal (.) regional
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            // Cargar comunas de la Región del Biobío en el ComboBox
            cboComuna.Items.Clear();
            cboComuna.Items.Add("Seleccione comuna");
            cboComuna.Items.Add("Concepción");
            cboComuna.Items.Add("Chillán");
            cboComuna.Items.Add("San pedro de la Paz");
            cboComuna.Items.Add("Los Ángeles");
            cboComuna.Items.Add("Coronel");
            cboComuna.Items.Add("Lota");
            cboComuna.Items.Add("Talcahuano");
            cboComuna.Items.Add("Chillán");
            cboComuna.SelectedIndex = 0;
        }

        private void LimpiarFormulario()
        {
            //INPUTS
            txtNombrePyme.Clear();
            txtPaneles.Clear();
            txtTarifaPanel.Clear();
            chkFomento.Checked = false;
            chkIncluirBaterias.Checked = false;
            txtPresupuesto.Clear();
            //RESULTADOS
            lblValorSubTotal.Text = "0";
            lblValorTotalNeto.Text = "0";
            lblResultadoTotal.Text = "Sin calculos aún";
            //REENFOQUE
            txtNombrePyme.Focus();
            cboComuna.SelectedIndex = 0; //selecciona ier utem del cmbo
            txtPaneles.Clear();
            txtTarifaPanel.Clear();
            txtInversor.Clear();
            chkFomento.Checked = false;
            //Resetear labels de resultados
            lblValorSubTotal.Text = "$ 0.00 USD";
            lblValorIVA.Text = "$ 0.00 USD";
            lblResultadoTotal.Text = "$ 0.00 USD";
            lblResultadoTotal.ForeColor = Color.DarkGray;
            lblResViabilidad.Text = "PENDIENTE";
            //desabilita grupo resultados
            grpResultados.Enabled = false;
            //enfoca el primer campo del formulario
            txtNombrePyme.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void FormCotizador_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void FormCotizador_Load_1(object sender, EventArgs e)
        {
        }

        private void btnCalcularCotizacion_Click(object sender, EventArgs e)
        {
            // Recolección de datos de entrada (se normaliza trim para evitar espacios)
            string pyme = txtNombrePyme.Text.Trim();
            string comuna = cboComuna.SelectedItem?.ToString() ?? string.Empty;
            //VALIDACIONES INPUT TEXTOS
            if (string.IsNullOrEmpty(pyme))
            {
                MessageBox.Show("Ingrese el nombre de la PYME.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombrePyme.Focus();
                return;
            }
            if (string.IsNullOrEmpty(comuna))
            {
                MessageBox.Show("Ingrese el nombre de la comuna.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboComuna.Focus();
                return;
            }
            if (comuna=="Seleccione comuna")
            {
                MessageBox.Show("Ingrese una comuna de la lista", "validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboComuna.Focus();
                cboComuna.DroppedDown = true; // Abre automáticamente la lista desplegable
                return;
            }
            // necesitamos numeros
            string panelesInput = txtPaneles.Text.Trim();
            string tarifaInput = txtTarifaPanel.Text.Trim();
            string inversorInput = txtInversor.Text.Trim();
            string presupuestoInput = txtPresupuesto.Text.Trim();
            //pareseo de los valores numéricos
            bool parsePaneles = int.TryParse(panelesInput, out int cantidadPaneles);
            bool parseTarifa = double.TryParse(tarifaInput, out double tarifaPanel);
            bool parseInversor = double.TryParse(inversorInput, out double valorInversor);
            bool parsePresupuesto = double.TryParse(presupuestoInput, out double presupuestoCliente);

            //VALIDACIONES
            //vatidad de paneles
            if (!parsePaneles || cantidadPaneles <= 0)
            {
                MessageBox.Show("Ingrese una cantidad de paneles válida (entero mayor que 0).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPaneles.Focus();
                return;
            }
            //tarifa por panel valida
            if (!parseTarifa || tarifaPanel < 50 || tarifaPanel > 1500)
            {
                MessageBox.Show("Ingrese una tarifa por panel válida (mayor que 50 U$ y menor que 500 U$).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTarifaPanel.Focus();
                txtTarifaPanel.SelectAll();
                return;
            }
            //inversor valido
            if (!parseInversor || valorInversor < 100 || valorInversor > 10000)
            {
                MessageBox.Show("Ingrese una valor de Inversor valido (mayor que 100 U$ y menor que 10000 U$).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInversor.Focus();
                txtInversor.SelectAll();
                return;
            }
            //monto disponible valido   
            if (!parsePresupuesto || presupuestoCliente < 0)
            {
                MessageBox.Show("Ingrese un presupuesto válido (mayor o igual a 0 U$).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPresupuesto.Focus();
                txtPresupuesto.SelectAll();
                return;
            }
            // Cálculo simple de cotización
            double subtotal = cantidadPaneles * tarifaPanel;
            // Incluir inversor si se proporcionó un valor válido
            subtotal += valorInversor;
            //// Añadir costo estimado por baterías si el usuario lo solicita
            if (chkIncluirBaterias.Checked)
            {
                // Valor por defecto histórico: 500.0 USD
                subtotal += 500.0;
                string entradaBaterias = Interaction.InputBox("Ingrese el valor total de las baterías (USD):", "Valor baterías", "500");
                if (!string.IsNullOrWhiteSpace(entradaBaterias))
                {
                    if (double.TryParse(entradaBaterias.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out double valorBaterias) && valorBaterias >= 0)
                    {
                        subtotal += valorBaterias;
                    }
                    else
                    {
                        MessageBox.Show("Valor de baterías inválido. Operación cancelada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    // Si no ingresa valor, preguntar si desea mantener la inclusión sin valor
                    var r = MessageBox.Show("No ingresó un valor para las baterías. ¿Desea cancelar su inclusión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        chkIncluirBaterias.Checked = false;
                    }
                }
            }
            // Aplicar descuento por fomento si corresponde (10% en este ejemplo)
            if (chkFomento.Checked)
            {
                subtotal *= 0.90;
            }
            // Calcular IVA y total
            const double IVA_RATE = 0.19; // 19% ejemplo
            double iva = Math.Round(subtotal * IVA_RATE, 2);
            double totalNeto = Math.Round(subtotal + iva, 2);
            //Mostrar resultados en UI (utiliza la cultura ya configurada)
            lblValorSubTotal.Text = subtotal.ToString("C", CultureInfo.CurrentCulture);
            lblValorIVA.Text = iva.ToString("C", CultureInfo.CurrentCulture);
            lblValorTotalNeto.Text = totalNeto.ToString("C", CultureInfo.CurrentCulture);
            lblResultadoTotal.Text = totalNeto.ToString("C", CultureInfo.CurrentCulture);
            grpResultados.Enabled = true;
            // Evaluación simple de viabilidad según presupuesto ingresado
            if (parsePresupuesto && presupuestoCliente > 0)
            {
                bool viable = totalNeto <= presupuestoCliente;
                lblResViabilidad.Text = viable ? "Viable" : "No viable";
                lblResViabilidad.ForeColor = viable ? Color.DarkGreen : Color.DarkRed;
            }
            else
            {
                lblResViabilidad.Text = "No evaluado";
                lblResViabilidad.ForeColor = Color.DarkGray;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtPresupuesto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombrePyme_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTarifaPanel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPaneles_TextChanged(object sender, EventArgs e)
        {
            // Manejador vacío: conservar para futuras validaciones de entrada
        }

        private void cboComuna_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpResultados_Enter(object sender, EventArgs e)
        {

        }

        private void lblResultadoTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
