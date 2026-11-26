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
    public partial class FrmRepuesto : Form
    {
        public string nombreusuario = "admin";
        NRepuesto objnegrepuesto = new NRepuesto();

        public FrmRepuesto()
        {
            InitializeComponent();
        }

        void OcultarColumnas()
        {
            if (dgvrepuestos.Columns["ID_Repuesto"] != null)
            {
                dgvrepuestos.Columns["ID_Repuesto"].Visible = false;
            }
            if (dgvrepuestos.Columns["CreatedBy"] != null)
            {
                dgvrepuestos.Columns["CreatedBy"].Visible = false;
            }
            if (dgvrepuestos.Columns["CreatedAt"] != null)
            {
                dgvrepuestos.Columns["CreatedAt"].Visible = false;
            }
            if (dgvrepuestos.Columns["ModifiedBy"] != null)
            {
                dgvrepuestos.Columns["ModifiedBy"].Visible = false;
            }
            if (dgvrepuestos.Columns["ModifiedAt"] != null)
            {
                dgvrepuestos.Columns["ModifiedAt"].Visible = false;
            }
            if (dgvrepuestos.Columns["Detalle_Repuesto"] != null)
            {
                dgvrepuestos.Columns["Detalle_Repuesto"].Visible = false;
            }
        }

        void ActualizarDataGridView()
        {
            dgvrepuestos.DataSource = objnegrepuesto.Listarrepuestos();
            OcultarColumnas();
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
            txtbuscar.Text = "";
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtmarca.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";
            txtstockminimo.Text = "";
            txtcodigo.Focus();
        }

        private void FrmRepuesto_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text != "" && txtnombre.Text != "" && txtprecio.Text != "" && txtstock.Text != "" && txtstockminimo.Text != "")
            {
                decimal precio = 0;
                int stock = 0;
                int stockminimo = 0;
                if (decimal.TryParse(txtprecio.Text, out precio) == false || int.TryParse(txtstock.Text, out stock) == false || int.TryParse(txtstockminimo.Text, out stockminimo) == false)
                {
                    MessageBox.Show("Ingrese valores numericos validos para precio y stock.");
                    return;
                }
                Repuesto objrepuesto = new Repuesto();
                objrepuesto.Codigo = txtcodigo.Text;
                objrepuesto.Nombre = txtnombre.Text;
                objrepuesto.Marca = txtmarca.Text;
                objrepuesto.Precio = precio;
                objrepuesto.Stock = stock;
                objrepuesto.StockMinimo = stockminimo;
                objrepuesto.CreatedBy = nombreusuario;
                string mensaje = objnegrepuesto.Registrarrepuesto(objrepuesto);
                MessageBox.Show(mensaje);
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Complete campos obligatorios.");
            }
        }

        private void dgvrepuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow filaseleccionada = dgvrepuestos.Rows[e.RowIndex];
                if (filaseleccionada.Cells["Codigo"].Value != null)
                {
                    txtcodigo.Text = filaseleccionada.Cells["Codigo"].Value.ToString();
                }
                else
                {
                    txtcodigo.Text = "";
                }
                if (filaseleccionada.Cells["Nombre"].Value != null)
                {
                    txtnombre.Text = filaseleccionada.Cells["Nombre"].Value.ToString();
                }
                else
                {
                    txtnombre.Text = "";
                }
                if (filaseleccionada.Cells["Marca"].Value != null)
                {
                    txtmarca.Text = filaseleccionada.Cells["Marca"].Value.ToString();
                }
                else
                {
                    txtmarca.Text = "";
                }
                if (filaseleccionada.Cells["Precio"].Value != null)
                {
                    txtprecio.Text = filaseleccionada.Cells["Precio"].Value.ToString();
                }
                else
                {
                    txtprecio.Text = "";
                }
                if (filaseleccionada.Cells["Stock"].Value != null)
                {
                    txtstock.Text = filaseleccionada.Cells["Stock"].Value.ToString();
                }
                else
                {
                    txtstock.Text = "";
                }
                if (filaseleccionada.Cells["StockMinimo"].Value != null)
                {
                    txtstockminimo.Text = filaseleccionada.Cells["StockMinimo"].Value.ToString();
                }
                else
                {
                    txtstockminimo.Text = "";
                }
                btnmodificar.Enabled = true;
                btneliminar.Enabled = true;
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (dgvrepuestos.CurrentRow != null && txtcodigo.Text != "" && txtnombre.Text != "" && txtprecio.Text != "" && txtstock.Text != "" && txtstockminimo.Text != "")
            {
                decimal precio = 0;
                int stock = 0;
                int stockminimo = 0;
                if (decimal.TryParse(txtprecio.Text, out precio) == false || int.TryParse(txtstock.Text, out stock) == false || int.TryParse(txtstockminimo.Text, out stockminimo) == false)
                {
                    MessageBox.Show("Ingrese valores numericos validos para precio y stock.");
                    return;
                }
                int id = Convert.ToInt32(dgvrepuestos.CurrentRow.Cells["ID_Repuesto"].Value);
                Repuesto objrepuesto = new Repuesto();
                objrepuesto.ID_Repuesto = id;
                objrepuesto.Codigo = txtcodigo.Text;
                objrepuesto.Nombre = txtnombre.Text;
                objrepuesto.Marca = txtmarca.Text;
                objrepuesto.Precio = precio;
                objrepuesto.Stock = stock;
                objrepuesto.StockMinimo = stockminimo;
                objrepuesto.ModifiedBy = nombreusuario;
                objrepuesto.ModifiedAt = DateTime.Now;
                string mensaje = objnegrepuesto.Modificarrepuesto(objrepuesto);
                MessageBox.Show(mensaje);
                ActualizarDataGridView();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvrepuestos.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvrepuestos.CurrentRow.Cells["ID_Repuesto"].Value);
                string mensaje = objnegrepuesto.Eliminarrepuesto(id);
                MessageBox.Show(mensaje);
                ActualizarDataGridView();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtbuscar.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un nombre o codigo para buscar.");
                return;
            }
            List<Repuesto> encontrados = objnegrepuesto.Buscarrepuestos(txtbuscar.Text);
            dgvrepuestos.DataSource = encontrados;
            OcultarColumnas();
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
            if (encontrados.Count == 0)
            {
                MessageBox.Show("No se encontraron repuestos con ese nombre o codigo.");
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
