Guía de Laboratorio 10
Fecha de entrega No hay fecha de entrega Puntos 0
Del Modo Consola a la Interfaz Gráfica (GUI)
Tras consolidar los fundamentos de programación estructurada en la Unidad I, 
iniciamos la Unidad II transitando desde aplicaciones de consola secuenciales 
hacia sistemas interactivos de ventana con Interfaz Gráfica de Usuario (GUI) 
en C# con .NET 10 y Visual Studio 2026.

Concepto Clave: El Formulario (Form)

En el desarrollo de escritorio de .NET, un Formulario (Form) 
es el contenedor visual principal sobre el cual se construyen 
las ventanas de la aplicación. 
Actúa como el lienzo donde los ingenieros de software 
organizan controles para que el usuario 
ingrese, seleccione y visualice la información.

Anatomía de un Proyecto GUI en Visual Studio 2026:
`Program.cs`: 
    Contiene el punto de entrada principal static void Main() 
    que configura la aplicación e invoca Application.Run(new FormPrincipal()).
`FormPrincipal.cs`: 
    Código fuente C# (*Code-Behind*) donde se escribe 
    la lógica de negocio y las respuestas del formulario.
`FormPrincipal.Designer.cs`: 
    Código generado automáticamente por el Diseñador Visual de VS 2026 
    que inicializa componentes, dimensiones, colores y posiciones.
Catálogo de Controles de Interfaz y Estándar de Nomenclatura
Para mantener un código limpio y mantenible, todo control agregado al formulario debe renombrarse inmediatamente utilizando un prefijo estándar de tres letras en formato camelCase:

Control	Prefijo	Ejemplo de `Name`	Propósito y Uso Principal
Label	



lbl	lblNombreCliente	Muestra texto estático, títulos e instrucciones en la ventana.
TextBox	txt	txtCantidadPaneles	Campo de entrada donde el usuario escribe textos o números.
Button	btn	btnCalcularCotizacion	Botón interactivo que desencadena acciones al hacer clic.
ComboBox	cbo	cboComunaBiobio	Lista desplegable de opciones predefinidas.
CheckBox	chk	chkIncluirBaterias	Casilla de verificación de selección binaria (`bool`).
GroupBox / Panel	grp / pnl	grpDatosCliente	Contenedores visuales para agrupar controles relacionados.
Actividad Guiada: Formulario del Cotizador Solar para PYMES
Construiremos la interfaz gráfica inicial para la cotización de energía solar del proyecto del curso.

Crear el Proyecto: En Visual Studio 2026, crea un nuevo proyecto de Aplicación de Windows Forms (.NET 10) asignándole el nombre CotizadorSolarPyme.GUI.
Configurar el Formulario Principal:
Selecciona el formulario y en la ventana de Propiedades asigna:
• (Name): FormCotizador
• Text: Sistema de Cotización Solar - IPVG 2026
• StartPosition: CenterScreen
• FormBorderStyle: FixedSingle (para evitar deformaciones de diseño).
Diseñar las Secciones Visuales:
Agrega un GroupBox llamado grpDatosCliente ("Datos de la PYME Cliente") y otro grpEspecificaciones ("Dimensionamiento Técnico").
Insertar Controles de Captura:
• Agrega Labels y TextBoxes para Nombre de la PYME (txtNombrePyme), Cantidad de Paneles (txtCantidadPaneles) y Precio por Panel (txtPrecioPanel).
• Agrega un ComboBox cboComuna con las comunas de la Región del Biobío.
• Agrega un CheckBox chkDescuentoFomento ("Aplicar Descuento Estatal por Generación Distribuida").
Agregar Controles de Salida y Acción:
• Agrega un Botón btnCalcular ("Calcular Cotización") y un Botón btnLimpiar ("Limpiar Formulario").
• Agrega un Panel o GroupBox de resultados con Labels descriptivos para Subtotal, IVA y Total Neto.
Estructura del Código en C# (Code-Behind)
A continuación se presenta el esqueleto estructural C# del archivo FormCotizador.cs con métodos de inicialización y eventos básicos:

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
            ConfigurarEntornoInicial();
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
            lblResultadoTotal.Text = "$0.00 USD";
            txtNombrePyme.Focus();
        }
    }
}
        
