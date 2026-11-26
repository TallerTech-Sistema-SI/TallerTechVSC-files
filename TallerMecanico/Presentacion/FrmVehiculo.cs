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
    public partial class FrmVehiculo : Form
    {
        public string nombreusuario = "admin";
        NVehiculo objnegvehiculo = new NVehiculo();
        NCliente objnegcliente = new NCliente();

        public FrmVehiculo()
        {
            InitializeComponent();
        }

        void CargarComboCliente()
        {
            cboxcliente.DataSource = null;
            cboxcliente.DisplayMember = "Nombre";
            cboxcliente.ValueMember = "ID_Cliente";
            cboxcliente.DataSource = objnegcliente.Listarclientes();
            cboxcliente.SelectedIndex = -1;
        }

        void OcultarColumnas()
        {
            if (dgvvehiculos.Columns["ID_Vehiculo"] != null)
            {
                dgvvehiculos.Columns["ID_Vehiculo"].Visible = false;
            }
            if (dgvvehiculos.Columns["ID_Cliente"] != null)
            {
                dgvvehiculos.Columns["ID_Cliente"].Visible = false;
            }
            if (dgvvehiculos.Columns["CreatedBy"] != null)
            {
                dgvvehiculos.Columns["CreatedBy"].Visible = false;
            }
            if (dgvvehiculos.Columns["CreatedAt"] != null)
            {
                dgvvehiculos.Columns["CreatedAt"].Visible = false;
            }
            if (dgvvehiculos.Columns["ModifiedBy"] != null)
            {
                dgvvehiculos.Columns["ModifiedBy"].Visible = false;
            }
            if (dgvvehiculos.Columns["ModifiedAt"] != null)
            {
                dgvvehiculos.Columns["ModifiedAt"].Visible = false;
            }
            if (dgvvehiculos.Columns["Cliente"] != null)
            {
                dgvvehiculos.Columns["Cliente"].Visible = false;
            }
            if (dgvvehiculos.Columns["OrdenServicio"] != null)
            {
                dgvvehiculos.Columns["OrdenServicio"].Visible = false;
            }
        }

        void ActualizarDataGridView()
        {
            dgvvehiculos.DataSource = objnegvehiculo.Listarvehiculos();
            OcultarColumnas();
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
            txtbuscar.Text = "";
            cboxcliente.SelectedIndex = -1;
            txtplaca.Text = "";
            txtmarca.Text = "";
            txtmodelo.Text = "";
            txtanio.Text = "";
            txtplaca.Focus();
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            CargarComboCliente();
            ActualizarDataGridView();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (cboxcliente.SelectedIndex != -1 && txtplaca.Text != "" && txtmarca.Text != "" && txtmodelo.Text != "" && txtanio.Text != "")
            {
                string placa = txtplaca.Text.ToUpper();
                if (placa.Length < 6 || placa.Length > 8 || placa.Contains("-") == false)
                {
                    MessageBox.Show("Ingrese una placa valida (ejemplo: A4B-312).");
                    return;
                }
                int anio = 0;
                if (int.TryParse(txtanio.Text, out anio) == false || anio < 1950 || anio > DateTime.Now.Year + 1)
                {
                    MessageBox.Show("Ingrese un anio valido.");
                    return;
                }
                Vehiculo objvehiculo = new Vehiculo();
                objvehiculo.ID_Cliente = Convert.ToInt32(cboxcliente.SelectedValue);
                objvehiculo.Placa = placa;
                objvehiculo.Marca = txtmarca.Text;
                objvehiculo.Modelo = txtmodelo.Text;
                objvehiculo.Anio = anio;
                objvehiculo.CreatedBy = nombreusuario;
                string mensaje = objnegvehiculo.Registrarvehiculo(objvehiculo);
                MessageBox.Show(mensaje);
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Complete campos obligatorios.");
            }
        }

        private void dgvvehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow filaseleccionada = dgvvehiculos.Rows[e.RowIndex];
                if (filaseleccionada.Cells["ID_Cliente"].Value != null)
                {
                    cboxcliente.SelectedValue = Convert.ToInt32(filaseleccionada.Cells["ID_Cliente"].Value);
                }
                if (filaseleccionada.Cells["Placa"].Value != null)
                {
                    txtplaca.Text = filaseleccionada.Cells["Placa"].Value.ToString();
                }
                else
                {
                    txtplaca.Text = "";
                }
                if (filaseleccionada.Cells["Marca"].Value != null)
                {
                    txtmarca.Text = filaseleccionada.Cells["Marca"].Value.ToString();
                }
                else
                {
                    txtmarca.Text = "";
                }
                if (filaseleccionada.Cells["Modelo"].Value != null)
                {
                    txtmodelo.Text = filaseleccionada.Cells["Modelo"].Value.ToString();
                }
                else
                {
                    txtmodelo.Text = "";
                }
                if (filaseleccionada.Cells["Anio"].Value != null)
                {
                    txtanio.Text = filaseleccionada.Cells["Anio"].Value.ToString();
                }
                else
                {
                    txtanio.Text = "";
                }
                btnmodificar.Enabled = true;
                btneliminar.Enabled = true;
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (dgvvehiculos.CurrentRow != null && cboxcliente.SelectedIndex != -1 && txtplaca.Text != "" && txtmarca.Text != "" && txtmodelo.Text != "" && txtanio.Text != "")
            {
                string placa = txtplaca.Text.ToUpper();
                if (placa.Length < 6 || placa.Length > 8 || placa.Contains("-") == false)
                {
                    MessageBox.Show("Ingrese una placa valida (ejemplo: A4B-312).");
                    return;
                }
                int anio = 0;
                if (int.TryParse(txtanio.Text, out anio) == false || anio < 1950 || anio > DateTime.Now.Year + 1)
                {
                    MessageBox.Show("Ingrese un anio valido.");
                    return;
                }
                int id = Convert.ToInt32(dgvvehiculos.CurrentRow.Cells["ID_Vehiculo"].Value);
                Vehiculo objvehiculo = new Vehiculo();
                objvehiculo.ID_Vehiculo = id;
                objvehiculo.ID_Cliente = Convert.ToInt32(cboxcliente.SelectedValue);
                objvehiculo.Placa = placa;
                objvehiculo.Marca = txtmarca.Text;
                objvehiculo.Modelo = txtmodelo.Text;
                objvehiculo.Anio = anio;
                objvehiculo.ModifiedBy = nombreusuario;
                objvehiculo.ModifiedAt = DateTime.Now;
                string mensaje = objnegvehiculo.Modificarvehiculo(objvehiculo);
                MessageBox.Show(mensaje);
                ActualizarDataGridView();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvvehiculos.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvvehiculos.CurrentRow.Cells["ID_Vehiculo"].Value);
                string mensaje = objnegvehiculo.Eliminarvehiculo(id);
                MessageBox.Show(mensaje);
                ActualizarDataGridView();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtbuscar.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese una placa para buscar.");
                return;
            }
            List<Vehiculo> encontrados = objnegvehiculo.Buscarvehiculosporplaca(txtbuscar.Text);
            dgvvehiculos.DataSource = encontrados;
            OcultarColumnas();
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
            if (encontrados.Count == 0)
            {
                MessageBox.Show("No se encontraron vehiculos con esa placa.");
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
