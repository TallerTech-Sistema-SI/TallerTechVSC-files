using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos;

namespace Presentacion
{
    public partial class FrmResumenIngresos : Form
    {
        NOrdenServicio objnegorden = new NOrdenServicio();

        public FrmResumenIngresos()
        {
            InitializeComponent();
        }

        void CargarResumen(string estado, DateTime fechainicio, DateTime fechafin)
        {
            List<OrdenServicio> ordenesconcluidas = objnegorden.Listarordenesconcluidas(estado, fechainicio, fechafin);
            decimal totalmanoobra = 0;
            decimal totalrepuestos = 0;
            decimal ingresos = 0;

            List<string> meses = new List<string>();
            List<decimal> montosmes = new List<decimal>();

            foreach (OrdenServicio item in ordenesconcluidas)
            {
                ingresos = ingresos + item.Total;
                totalmanoobra = totalmanoobra + item.ManoObra;
                totalrepuestos = totalrepuestos + (item.Total - item.ManoObra);

                string mes = item.Fecha.ToString("MM/yyyy");
                bool encontrado = false;
                for (int i = 0; i < meses.Count; i++)
                {
                    if (meses[i] == mes)
                    {
                        montosmes[i] = montosmes[i] + item.Total;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    meses.Add(mes);
                    montosmes.Add(item.Total);
                }
            }

            lblingresos.Text = "Ingresos Totales: S/. " + ingresos.ToString() + " (Mano de Obra: S/. " + totalmanoobra.ToString() + " | Repuestos: S/. " + totalrepuestos.ToString() + ")";

            dgvconcluidas.AllowUserToAddRows = false;
            dgvconcluidas.DataSource = null;
            dgvconcluidas.DataSource = ordenesconcluidas;

            if (dgvconcluidas.Columns["ID_Orden"] != null)
            {
                dgvconcluidas.Columns["ID_Orden"].Visible = false;
            }
            if (dgvconcluidas.Columns["ID_Vehiculo"] != null)
            {
                dgvconcluidas.Columns["ID_Vehiculo"].Visible = false;
            }
            if (dgvconcluidas.Columns["ID_Mecanico"] != null)
            {
                dgvconcluidas.Columns["ID_Mecanico"].Visible = false;
            }
            if (dgvconcluidas.Columns["CreatedBy"] != null)
            {
                dgvconcluidas.Columns["CreatedBy"].Visible = false;
            }
            if (dgvconcluidas.Columns["CreatedAt"] != null)
            {
                dgvconcluidas.Columns["CreatedAt"].Visible = false;
            }
            if (dgvconcluidas.Columns["ModifiedBy"] != null)
            {
                dgvconcluidas.Columns["ModifiedBy"].Visible = false;
            }
            if (dgvconcluidas.Columns["ModifiedAt"] != null)
            {
                dgvconcluidas.Columns["ModifiedAt"].Visible = false;
            }
            if (dgvconcluidas.Columns["Mecanico"] != null)
            {
                dgvconcluidas.Columns["Mecanico"].Visible = false;
            }
            if (dgvconcluidas.Columns["Vehiculo"] != null)
            {
                dgvconcluidas.Columns["Vehiculo"].Visible = false;
            }
            if (dgvconcluidas.Columns["Detalle_Repuesto"] != null)
            {
                dgvconcluidas.Columns["Detalle_Repuesto"].Visible = false;
            }

            chartbarras.Series["FacturadoMes"].Points.Clear();
            for (int i = 0; i < meses.Count; i++)
            {
                chartbarras.Series["FacturadoMes"].Points.AddXY(meses[i], montosmes[i]);
            }

            chartingresos.Series["Ingresos"].Points.Clear();
            if (totalmanoobra > 0)
            {
                chartingresos.Series["Ingresos"].Points.AddXY("Mano de Obra", totalmanoobra);
            }
            if (totalrepuestos > 0)
            {
                chartingresos.Series["Ingresos"].Points.AddXY("Repuestos", totalrepuestos);
            }
        }

        private void FrmResumenIngresos_Load(object sender, EventArgs e)
        {
            cboxestado.Items.Clear();
            cboxestado.Items.Add("Todos");
            cboxestado.Items.Add("Terminado");
            cboxestado.Items.Add("Entregado");
            cboxestado.SelectedIndex = 0;

            dtpinicio.Value = DateTime.Today.AddMonths(-1);
            dtpfin.Value = DateTime.Today;

            CargarResumen("Todos", dtpinicio.Value, dtpfin.Value);
        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            if (dtpinicio.Value.Date > dtpfin.Value.Date)
            {
                MessageBox.Show("La fecha inicio no puede ser mayor a la fecha fin.");
                return;
            }
            if (cboxestado.SelectedItem != null)
            {
                CargarResumen(cboxestado.SelectedItem.ToString(), dtpinicio.Value, dtpfin.Value);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
