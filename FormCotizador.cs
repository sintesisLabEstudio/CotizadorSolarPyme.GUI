using System;
using System.Globalization;
using System.Windows.Forms;

namespace CotizadorSolarPyme.GUI
{
    public partial class FormCotizador : Form
    {
        public FormCotizador()
        {
            InitializeComponent();
            ConfigurarEntornoInicial(); //add
        }
        private void ConfigurarEntornoInicial()
        {
            // Estandarizar formato de punto decimal (.) regional
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            // Cargar comunas de la Región del Biobío en el ComboBox
            cboComuna.Items.Clear();
            cboComuna.Items.Add("Concepción");
            cboComuna.Items.Add("Chillán");
            cboComuna.Items.Add("Los Ángeles");
            cboComuna.Items.Add("Coronel");
            cboComuna.Items.Add("Talcahuano");
            cboComuna.SelectedIndex = 0;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombrePyme.Clear();
            txtCantidadPaneles.Clear();
            txtPrecioPanel.Clear();
            chkDescuentoFomento.Checked = false;
            //add
            chkIncluirBaterias.Checked = false;
            lblValorSubTotal.Text = "0";
            lblValorTotalNeto.Text = "0";
            lblResultadoTotal.Text = "Sin calculos aún";
            txtNombrePyme.Focus();
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

        private void txtCantidadPaneles_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
