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
    public partial class FrmOrdenServicio : Form
    {
        public string nombreusuario = "admin";
        NOrdenServicio objnegorden = new NOrdenServicio();
        NVehiculo objnegvehiculo = new NVehiculo();
        NMecanico objnegmecanico = new NMecanico();

        public FrmOrdenServicio()
        {
            InitializeComponent();
        }

        void CargarCombos()
        {
            cboxvehiculo.DataSource = null;
            cboxvehiculo.DisplayMember = "Placa";
            cboxvehiculo.ValueMember = "ID_Vehiculo";
            cboxvehiculo.DataSource = objnegvehiculo.Listarvehiculos();
            cboxvehiculo.SelectedIndex = -1;

            cboxmecanico.DataSource = null;
            cboxmecanico.DisplayMember = "Nombre";
            cboxmecanico.ValueMember = "ID_Mecanico";
            cboxmecanico.DataSource = objnegmecanico.Listarmecanicos();
            cboxmecanico.SelectedIndex = -1;
        }

        void ActualizarDataGridView()
        {
            dgvordenes.DataSource = objnegorden.Listarordenes();
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
            if (dgvordenes.Columns["Detalle_Repuesto"] != null)
            {
                dgvordenes.Columns["Detalle_Repuesto"].Visible = false;
            }
            if (dgvordenes.Columns["Mecanico"] != null)
            {
                dgvordenes.Columns["Mecanico"].Visible = false;
            }
            if (dgvordenes.Columns["Vehiculo"] != null)
            {
                dgvordenes.Columns["Vehiculo"].Visible = false;
            }
            cboxvehiculo.SelectedIndex = -1;
            cboxmecanico.SelectedIndex = -1;
            monthCalendar1.SetDate(DateTime.Now);
            txtdescripcion.Text = "";
            txtmanoobra.Text = "";
            cboxvehiculo.Focus();
        }

        private void FrmOrdenServicio_Load(object sender, EventArgs e)
        {
            CargarCombos();
            ActualizarDataGridView();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (cboxvehiculo.SelectedIndex != -1 && cboxmecanico.SelectedIndex != -1 && txtdescripcion.Text != "" && txtmanoobra.Text != "")
            {
                decimal manoobra = 0;
                if (decimal.TryParse(txtmanoobra.Text, out manoobra) == false || manoobra < 0)
                {
                    MessageBox.Show("Ingrese un monto valido para mano de obra.");
                    return;
                }
                OrdenServicio objorden = new OrdenServicio();
                objorden.ID_Vehiculo = Convert.ToInt32(cboxvehiculo.SelectedValue);
                objorden.ID_Mecanico = Convert.ToInt32(cboxmecanico.SelectedValue);
                objorden.Fecha = monthCalendar1.SelectionStart;
                objorden.Descripcion = txtdescripcion.Text;
                objorden.ManoObra = manoobra;
                objorden.Total = manoobra;
                objorden.Estado = "Pendiente";
                objorden.CreatedBy = nombreusuario;
                string mensaje = objnegorden.Registrarorden(objorden);
                MessageBox.Show(mensaje);
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Complete campos obligatorios.");
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

