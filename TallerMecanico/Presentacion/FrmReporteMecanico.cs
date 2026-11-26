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
    public partial class FrmReporteMecanico : Form
    {
        NMecanico objnegmecanico = new NMecanico();
        NOrdenServicio objnegorden = new NOrdenServicio();
        NVehiculo objnegvehiculo = new NVehiculo();

        public FrmReporteMecanico()
        {
            InitializeComponent();
        }

        void CargarCombos()
        {
            cboxmecanico.DataSource = null;
            cboxmecanico.DisplayMember = "Nombre";
            cboxmecanico.ValueMember = "ID_Mecanico";
            cboxmecanico.DataSource = objnegmecanico.Listarmecanicos();
            cboxmecanico.SelectedIndex = -1;

            cboxestado.Items.Clear();
            cboxestado.Items.Add("Todos");
            cboxestado.Items.Add("Pendiente");
            cboxestado.Items.Add("En Proceso");
            cboxestado.Items.Add("Terminado");
            cboxestado.Items.Add("Entregado");
            cboxestado.SelectedIndex = 0;
        }

        void CargarReporte(int idmecanico, string estado, DateTime fechainicio, DateTime fechafin)
        {
            List<OrdenServicio> ordenes = objnegorden.Listarordenespormecanico(idmecanico, estado, fechainicio, fechafin);
            List<Vehiculo> vehiculos = objnegvehiculo.Listarvehiculos();

            dgvordenes.AllowUserToAddRows = false;
            dgvordenes.DataSource = null;
            dgvordenes.Columns.Clear();
            dgvordenes.Columns.Add("Fecha", "Fecha");
            dgvordenes.Columns.Add("Vehiculo", "Vehiculo (Placa)");
            dgvordenes.Columns.Add("Descripcion", "Descripcion del Servicio");
            dgvordenes.Columns.Add("Estado", "Estado");
            dgvordenes.Columns.Add("Total", "Total");

            int concluidas = 0;
            decimal montototal = 0;

            foreach (OrdenServicio item in ordenes)
            {
                string placa = "";
                foreach (Vehiculo v in vehiculos)
                {
                    if (v.ID_Vehiculo == item.ID_Vehiculo)
                    {
                        placa = v.Placa;
                    }
                }

                if (item.Estado == "Terminado" || item.Estado == "Entregado")
                {
                    concluidas = concluidas + 1;
                    montototal = montototal + item.Total;
                }

                dgvordenes.Rows.Add(
                    item.Fecha.ToString("dd/MM/yyyy"),
                    placa,
                    item.Descripcion,
                    item.Estado,
                    item.Total);
            }

            lblresumen.Text = "Ordenes encontradas: " + ordenes.Count.ToString() + " | Terminadas/Entregadas: " + concluidas.ToString() + " | Monto total generado: S/. " + montototal.ToString();

            if (ordenes.Count == 0)
            {
                MessageBox.Show("El mecanico no tiene ordenes con los filtros seleccionados.");
            }
        }

        private void FrmReporteMecanico_Load(object sender, EventArgs e)
        {
            CargarCombos();
            dtpinicio.Value = DateTime.Today.AddMonths(-1);
            dtpfin.Value = DateTime.Today;
            dgvordenes.AllowUserToAddRows = false;
            lblresumen.Text = "Seleccione un mecanico y presione Filtrar.";
        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            if (cboxmecanico.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un mecanico de la lista.");
                return;
            }
            if (dtpinicio.Value.Date > dtpfin.Value.Date)
            {
                MessageBox.Show("La fecha inicio no puede ser mayor a la fecha fin.");
                return;
            }
            if (cboxestado.SelectedItem != null)
            {
                int idMecanico = Convert.ToInt32(cboxmecanico.SelectedValue);
                CargarReporte(idMecanico, cboxestado.SelectedItem.ToString(), dtpinicio.Value, dtpfin.Value);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
