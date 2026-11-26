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
    public partial class FrmConsultaOrdenes : Form
    {
        NOrdenServicio objnegorden = new NOrdenServicio();

        public FrmConsultaOrdenes()
        {
            InitializeComponent();
        }

        void CargarFiltros()
        {
            cboxfiltroestado.Items.Clear();
            cboxfiltroestado.Items.Add("Todos");
            cboxfiltroestado.Items.Add("Pendiente");
            cboxfiltroestado.Items.Add("En Proceso");
            cboxfiltroestado.Items.Add("Terminado");
            cboxfiltroestado.Items.Add("Entregado");
            cboxfiltroestado.SelectedIndex = 0;
        }

        void BuscarOrdenes(string estado)
        {
            List<OrdenServicio> lista = null;
            if (chkfechas.Checked)
            {
                lista = objnegorden.Listarordenesporestadoyfechas(estado, dtpdesde.Value, dtphasta.Value);
            }
            else
            {
                if (estado == "Todos")
                {
                    lista = objnegorden.Listarordenes();
                }
                else
                {
                    lista = objnegorden.Listarordenesporestado(estado);
                }
            }

            dgvordenes.AllowUserToAddRows = false;
            dgvordenes.DataSource = null;
            dgvordenes.DataSource = lista;

            if (dgvordenes.Columns["ID_Orden"] != null)
            {
                dgvordenes.Columns["ID_Orden"].Visible = false;
            }
            if (dgvordenes.Columns["ID_Vehiculo"] != null)
            {
                dgvordenes.Columns["ID_Vehiculo"].Visible = false;
            }
            if (dgvordenes.Columns["ID_Mecanico"] != null)
            {
                dgvordenes.Columns["ID_Mecanico"].Visible = false;
            }
            if (dgvordenes.Columns["CreatedBy"] != null)
            {
                dgvordenes.Columns["CreatedBy"].Visible = false;
            }
            if (dgvordenes.Columns["CreatedAt"] != null)
            {
                dgvordenes.Columns["CreatedAt"].Visible = false;
            }
            if (dgvordenes.Columns["ModifiedBy"] != null)
            {
                dgvordenes.Columns["ModifiedBy"].Visible = false;
            }
            if (dgvordenes.Columns["ModifiedAt"] != null)
            {
                dgvordenes.Columns["ModifiedAt"].Visible = false;
            }
            if (dgvordenes.Columns["Mecanico"] != null)
            {
                dgvordenes.Columns["Mecanico"].Visible = false;
            }
            if (dgvordenes.Columns["Vehiculo"] != null)
            {
                dgvordenes.Columns["Vehiculo"].Visible = false;
            }
            if (dgvordenes.Columns["Detalle_Repuesto"] != null)
            {
                dgvordenes.Columns["Detalle_Repuesto"].Visible = false;
            }

            lbltotalordenes.Text = "Cantidad de Ordenes encontradas: " + lista.Count.ToString();
        }

        private void FrmConsultaOrdenes_Load(object sender, EventArgs e)
        {
            CargarFiltros();
            dtpdesde.Value = DateTime.Today.AddMonths(-1);
            dtphasta.Value = DateTime.Today;
            dtpdesde.Enabled = false;
            dtphasta.Enabled = false;
            BuscarOrdenes("Todos");
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (chkfechas.Checked && dtpdesde.Value.Date > dtphasta.Value.Date)
            {
                MessageBox.Show("La fecha desde no puede ser mayor a la fecha hasta.");
                return;
            }
            if (cboxfiltroestado.SelectedItem != null)
            {
                BuscarOrdenes(cboxfiltroestado.SelectedItem.ToString());
            }
        }

        private void chkfechas_CheckedChanged(object sender, EventArgs e)
        {
            dtpdesde.Enabled = chkfechas.Checked;
            dtphasta.Enabled = chkfechas.Checked;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblfiltro_Click(object sender, EventArgs e)
        {

        }

        private void dgvordenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

