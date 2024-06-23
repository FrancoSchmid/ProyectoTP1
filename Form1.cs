using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryTP1
{
    public partial class frmPrincipal : Form
    {
        // Precios y dimensiones
        private const double PrecioMetroDepto = 1921.0;
        private const double PrecioMetroCochera = 1235.0;
        private const double MetrosDeptoA = 85.0;
        private const double MetrosCocheraA = 21.0;
        private const double MetrosDeptoB = 52.0;
        private const double MetrosDeptoC = 35.0;

        // Precios por tipo de piso
        private const double PrecioPorcelanato = 32.0;
        private const double PrecioFlotante = 26.50;
        private const double PrecioAlisado = 21.21;

        // Precios por tipo de aberturas
        private const double PrecioAluminio = 25.0;
        private const double PrecioMadera = 46.0;

        // Recargos por piso
        private const double Recargo1Al3 = 0.07;
        private const double Recargo4Al9 = 0.05;

        // Otros costos
        private const double RecargoCocheraTecho = 0.18;

        // Auxiliares donde guardo los valores
        char tipoDepto;
        string tipoPiso;
        string tipoAbertura;
        double totalDepto;
        double totalPrecioMetro;
        double montoTotal;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Inicializar valores
            int n = dgvCarrito.Rows.Add();  // Agrega una nueva fila al DataGridView
            double totalPrecioMetro = PrecioMetroDepto;
            double metrosDepto = 0;
            double precioCochera = 0;
            double metrosCochera = 0;
            double Escritura = 0;
            double Iva = 0;
            double Rentas = 0;
            double totalRecargo = 0;

            // Determinar el tipo de departamento seleccionado
            if (rbDeptoA.Checked)
            {
                tipoDepto = 'A';
                metrosDepto = MetrosDeptoA;
                precioCochera = PrecioMetroCochera;
                metrosCochera = MetrosCocheraA;
            }
            else if (rbDeptoB.Checked)
            {
                tipoDepto = 'B';
                metrosDepto = MetrosDeptoB;
            }
            else if (rbDeptoC.Checked)
            {
                tipoDepto = 'C';
                metrosDepto = MetrosDeptoC;
            }

            // Determinar el tipo de piso seleccionado
            if (rbPorcelanato.Checked)
            {
                tipoPiso = "Porcelanato";
                totalPrecioMetro += PrecioPorcelanato;
            }
            else if (rbFlotante.Checked)
            {
                tipoPiso = "Flotante";
                totalPrecioMetro += PrecioFlotante;
            }
            else if (rbAlisado.Checked)
            {
                tipoPiso = "Alisado";
                totalPrecioMetro += PrecioAlisado;
            }

            // Determinar el tipo de abertura seleccionado
            if (rbMadera.Checked)
            {
                tipoAbertura = "Madera";
                totalPrecioMetro += PrecioMadera;
            }
            else if (rbAluminio.Checked)
            {
                tipoAbertura = "Aluminio";
                totalPrecioMetro += PrecioAluminio;
            }

            // Calcular el total del departamento
            totalDepto = (totalPrecioMetro * metrosDepto) + (precioCochera * metrosCochera);

            // Aplicar recargos según el piso seleccionado
            if (cmbNroPiso.SelectedItem != null)
            {
                string selectedPiso = cmbNroPiso.SelectedItem.ToString();
                int numeroPiso;

                // Convertir el número de piso seleccionado a entero
                if (int.TryParse(selectedPiso, out numeroPiso))
                {
                    // Realizar diferentes acciones según el número de piso seleccionado
                    if (numeroPiso < 4)
                    {
                        totalRecargo = totalDepto * Recargo1Al3;
                        if (numeroPiso == 1 && tipoDepto == 'A')
                        {
                            totalRecargo += totalDepto * RecargoCocheraTecho;
                        }
                    }
                    else
                    {
                        totalRecargo = totalDepto * Recargo4Al9;
                    }
                }
            }

            // Calcular los gastos adicionales
            Escritura = totalDepto * 0.09;
            Iva = totalDepto * 0.105;
            Rentas = totalDepto * 0.021;
            montoTotal = totalDepto + totalRecargo + Escritura + Iva + Rentas;

            // Mostrar los gastos en los TextBoxes
            txtboxEscritura.Text = Escritura.ToString("F2");
            txtboxIVA.Text = Iva.ToString("F2");
            txtboxRentas.Text = Rentas.ToString("F2");
            txtboxRecargo.Text = totalRecargo.ToString("F2");

            // Agregar los valores seleccionados al DataGridView
            dgvCarrito.Rows[n].Cells[0].Value = cmbNroPiso.SelectedItem;  // Selecciona el elemento del ComboBox
            dgvCarrito.Rows[n].Cells[1].Value = tipoDepto;
            dgvCarrito.Rows[n].Cells[2].Value = tipoPiso;
            dgvCarrito.Rows[n].Cells[3].Value = tipoAbertura;

            // Deseleccionar todos los RadioButton
            rbDeptoA.Checked = false;
            rbDeptoB.Checked = false;
            rbDeptoC.Checked = false;
            rbPorcelanato.Checked = false;
            rbFlotante.Checked = false;
            rbAlisado.Checked = false;
            rbMadera.Checked = false;
            rbAluminio.Checked = false;

            // Deseleccionar ComboBox
            cmbNroPiso.SelectedIndex = -1;
        }

    }
}

        
