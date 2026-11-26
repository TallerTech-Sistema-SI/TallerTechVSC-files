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
    public partial class FrmCliente : Form
    {
        public string nombreusuario = "admin";
        NCliente objnegcliente = new NCliente();

        public FrmCliente()
        {
            InitializeComponent();
        }

        bool EsSoloDigitos(string texto)
        {
            if (texto == "")
            {
                return false;
            }
            foreach (char c in texto)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }

        void OcultarColumnas()
        {
            if (dgvclientes.Columns["ID_Cliente"] != null)
            {
                dgvclientes.Columns["ID_Cliente"].Visible = false;
            }
            if (dgvclientes.Columns["CreatedBy"] != null)
            {
                dgvclientes.Columns["CreatedBy"].Visible = false;
            }
            if (dgvclientes.Columns["CreatedAt"] != null)
            {
                dgvclientes.Columns["CreatedAt"].Visible = false;
            }
            if (dgvclientes.Columns["ModifiedBy"] != null)
            {
                dgvclientes.Columns["ModifiedBy"].Visible = false;
            }
            if (dgvclientes.Columns["ModifiedAt"] != null)
            {
                dgvclientes.Columns["ModifiedAt"].Visible = false;
            }
            if (dgvclientes.Columns["Vehiculo"] != null)
            {
                dgvclientes.Columns["Vehiculo"].Visible = false;
            }
        }

        void ActualizarDataGridView()
        {
            dgvclientes.DataSource = objnegcliente.Listarclientes();
            OcultarColumnas();
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
            txtbuscar.Text = "";
            txtdniruc.Text = "";
            txtnombre.Text = "";
            txttelefono.Text = "";
            txtdireccion.Text = "";
            txtdniruc.Focus();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtdniruc.Text != "" && txtnombre.Text != "")
            {
                if ((txtdniruc.Text.Length != 8 && txtdniruc.Text.Length != 11) || EsSoloDigitos(txtdniruc.Text) == false)
                {
                    MessageBox.Show("El DNI debe tener 8 digitos o el RUC 11 digitos.");
                    return;
                }
                if (txttelefono.Text != "" && (txttelefono.Text.Length < 7 || EsSoloDigitos(txttelefono.Text) == false))
                {
                    MessageBox.Show("El telefono debe contener al menos 7 digitos numericos.");
                    return;
                }
                Cliente objcliente = new Cliente();
                objcliente.DNI_RUC = txtdniruc.Text;
                objcliente.Nombre = txtnombre.Text;
                objcliente.Telefono = txttelefono.Text;
                objcliente.Direccion = txtdireccion.Text;
                objcliente.CreatedBy = nombreusuario;
                string mensaje = objnegcliente.Registrarcliente(objcliente);
                MessageBox.Show(mensaje);
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Complete campos obligatorios.");
            }
        }

        private void dgvclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow filaseleccionada = dgvclientes.Rows[e.RowIndex];
                if (filaseleccionada.Cells["DNI_RUC"].Value != null)
                {
                    txtdniruc.Text = filaseleccionada.Cells["DNI_RUC"].Value.ToString();
                }
                else
                {
                    txtdniruc.Text = "";
                }
                if (filaseleccionada.Cells["Nombre"].Value != null)
                {
                    txtnombre.Text = filaseleccionada.Cells["Nombre"].Value.ToString();
                }
                else
                {
                    txtnombre.Text = "";
                }
                if (filaseleccionada.Cells["Telefono"].Value != null)
                {
                    txttelefono.Text = filaseleccionada.Cells["Telefono"].Value.ToString();
                }
                else
                {
                    txttelefono.Text = "";
                }
                if (filaseleccionada.Cells["Direccion"].Value != null)
                {
                    txtdireccion.Text = filaseleccionada.Cells["Direccion"].Value.ToString();
                }
                else
                {
                    txtdireccion.Text = "";
                }
                btnmodificar.Enabled = true;
                btneliminar.Enabled = true;
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (dgvclientes.CurrentRow != null && txtdniruc.Text != "" && txtnombre.Text != "")
            {
                if ((txtdniruc.Text.Length != 8 && txtdniruc.Text.Length != 11) || EsSoloDigitos(txtdniruc.Text) == false)
                {
                    MessageBox.Show("El DNI debe tener 8 digitos o el RUC 11 digitos.");
                    return;
                }
                if (txttelefono.Text != "" && (txttelefono.Text.Length < 7 || EsSoloDigitos(txttelefono.Text) == false))
                {
                    MessageBox.Show("El telefono debe contener al menos 7 digitos numericos.");
                    return;
                }
                int id = Convert.ToInt32(dgvclientes.CurrentRow.Cells["ID_Cliente"].Value);
                Cliente objcliente = new Cliente();
                objcliente.ID_Cliente = id;
                objcliente.DNI_RUC = txtdniruc.Text;
                objcliente.Nombre = txtnombre.Text;
                objcliente.Telefono = txttelefono.Text;
                objcliente.Direccion = txtdireccion.Text;
                objcliente.ModifiedBy = nombreusuario;
                objcliente.ModifiedAt = DateTime.Now;
                string mensaje = objnegcliente.Modificarcliente(objcliente);
                MessageBox.Show(mensaje);
                ActualizarDataGridView();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvclientes.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvclientes.CurrentRow.Cells["ID_Cliente"].Value);
                string mensaje = objnegcliente.Eliminarcliente(id);
                MessageBox.Show(mensaje);
                ActualizarDataGridView();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtbuscar.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un DNI/RUC o un nombre para buscar.");
                return;
            }
            List<Cliente> encontrados = objnegcliente.Buscarclientes(txtbuscar.Text);
            dgvclientes.DataSource = encontrados;
            OcultarColumnas();
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
            if (encontrados.Count == 0)
            {
                MessageBox.Show("No se encontraron clientes con ese DNI/RUC o nombre.");
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
