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
    public partial class FrmHistorialVehiculo : Form
    {
        NVehiculo objnegvehiculo = new NVehiculo();
        NOrdenServicio objnegorden = new NOrdenServicio();
        NDetalleRepuesto objnegdetalle = new NDetalleRepuesto();
        NRepuesto objnegrepuesto = new NRepuesto();
        NCliente objnegcliente = new NCliente();

        public FrmHistorialVehiculo()
        {
            InitializeComponent();
        }

        private void FrmHistorialVehiculo_Load(object sender, EventArgs e)
        {
            cboxvehiculos.DataSource = null;
            cboxvehiculos.DisplayMember = "Placa";
            cboxvehiculos.ValueMember = "ID_Vehiculo";
            cboxvehiculos.DataSource = objnegvehiculo.Listarvehiculos();
            cboxvehiculos.SelectedIndex = -1;
            dgvhistorial.AllowUserToAddRows = false;
            lblresumen.Text = "Seleccione un vehiculo para consultar su historial.";
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (cboxvehiculos.SelectedIndex != -1)
            {
                int idVehiculo = Convert.ToInt32(cboxvehiculos.SelectedValue);
                Vehiculo veh = objnegvehiculo.Buscarvehiculo(idVehiculo);
                Cliente cli = objnegcliente.Buscarcliente(veh.ID_Cliente);

                List<OrdenServicio> historial = objnegorden.Listarhistorialvehiculo(idVehiculo);
                List<Detalle_Repuesto> detalles = objnegdetalle.Listardetalles();
                List<Repuesto> repuestos = objnegrepuesto.Listarrepuestos();

                List<Vehiculo> vehiculoscliente = objnegvehiculo.Listarvehiculosporcliente(veh.ID_Cliente);
                List<OrdenServicio> todasordenes = objnegorden.Listarordenes();
                int visitascliente = 0;
                foreach (OrdenServicio o in todasordenes)
                {
                    foreach (Vehiculo vc in vehiculoscliente)
                    {
                        if (o.ID_Vehiculo == vc.ID_Vehiculo)
                        {
                            visitascliente = visitascliente + 1;
                        }
                    }
                }

                dgvhistorial.DataSource = null;
                dgvhistorial.Columns.Clear();
                dgvhistorial.Columns.Add("Fecha", "Fecha");
                dgvhistorial.Columns.Add("Descripcion", "Falla / Servicio");
                dgvhistorial.Columns.Add("Repuestos", "Repuestos Cambiados");
                dgvhistorial.Columns.Add("Estado", "Estado");
                dgvhistorial.Columns.Add("ManoObra", "Mano de Obra");
                dgvhistorial.Columns.Add("Total", "Total");

                decimal costoacumulado = 0;
                foreach (OrdenServicio item in historial)
                {
                    string repuestoscambiados = "";
                    foreach (Detalle_Repuesto d in detalles)
                    {
                        if (d.ID_Orden == item.ID_Orden)
                        {
                            string nombrerep = "";
                            foreach (Repuesto r in repuestos)
                            {
                                if (r.ID_Repuesto == d.ID_Repuesto)
                                {
                                    nombrerep = r.Nombre;
                                }
                            }
                            if (repuestoscambiados == "")
                            {
                                repuestoscambiados = nombrerep + " x" + d.Cantidad.ToString();
                            }
                            else
                            {
                                repuestoscambiados = repuestoscambiados + ", " + nombrerep + " x" + d.Cantidad.ToString();
                            }
                        }
                    }
                    if (repuestoscambiados == "")
                    {
                        repuestoscambiados = "Ninguno";
                    }

                    costoacumulado = costoacumulado + item.Total;
                    dgvhistorial.Rows.Add(
                        item.Fecha,
                        item.Descripcion,
                        repuestoscambiados,
                        item.Estado,
                        item.ManoObra,
                        item.Total);
                }

                string nombrecli = "";
                if (cli != null)
                {
                    nombrecli = cli.Nombre;
                }
                lblresumen.Text = "Cliente: " + nombrecli + " | Visitas cliente: " + visitascliente.ToString() + " | Costo acumulado: S/. " + costoacumulado.ToString();

                if (historial.Count == 0)
                {
                    MessageBox.Show("Este vehiculo no tiene ordenes registradas.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un vehiculo de la lista.");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
