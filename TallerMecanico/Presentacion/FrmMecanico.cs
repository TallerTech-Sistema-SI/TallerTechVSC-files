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
    public partial class FrmMecanico : Form
    {
        public string nombreusuario = "admin";
        NMecanico objnegmecanico = new NMecanico();

        public FrmMecanico()
        {
            InitializeComponent();
        }

        void ActualizarDataGridView()
        {
            dgvmecanicos.DataSource = objnegmecanico.Listarmecanicos();
            if (dgvmecanicos.Columns["ID_Mecanico"] != null)
            {
                dgvmecanicos.Columns["ID_Mecanico"].Visible = false;
            }
            if (dgvmecanicos.Columns["CreatedBy"] != null)
            {
                dgvmecanicos.Columns["CreatedBy"].Visible = false;
            }
            if (dgvmecanicos.Columns["CreatedAt"] != null)
            {
                dgvmecanicos.Columns["CreatedAt"].Visible = false;
            }
            if (dgvmecanicos.Columns["ModifiedBy"] != null)
            {
                dgvmecanicos.Columns["ModifiedBy"].Visible = false;
            }
            if (dgvmecanicos.Columns["ModifiedAt"] != null)
            {
                dgvmecanicos.Columns["ModifiedAt"].Visible = false;
            }
            if (dgvmecanicos.Columns["OrdenServicio"] != null)
            {
                dgvmecanicos.Columns["OrdenServicio"].Visible = false;
            }
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
            txtnombre.Text = "";
            txttelefono.Text = "";
            cboxespecialidad.SelectedIndex = -1;
            txtnombre.Focus();
        }

        private void FrmMecanico_Load(object sender, EventArgs e)
        {
            cboxespecialidad.Items.Clear();
            cboxespecialidad.Items.Add("Mecanica General");
            cboxespecialidad.Items.Add("Frenos");
            cboxespecialidad.Items.Add("Motor");
            ActualizarDataGridView();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text != "" && cboxespecialidad.SelectedIndex != -1)
            {
                Mecanico objmecanico = new Mecanico();
                objmecanico.Nombre = txtnombre.Text;
                objmecanico.Especialidad = cboxespecialidad.SelectedItem.ToString();
                objmecanico.Telefono = txttelefono.Text;
                objmecanico.CreatedBy = nombreusuario;
                string mensaje = objnegmecanico.Registrarmecanico(objmecanico);
                MessageBox.Show(mensaje);
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Complete campos obligatorios.");
            }
        }

        private void dgvmecanicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow filaseleccionada = dgvmecanicos.Rows[e.RowIndex];
                if (filaseleccionada.Cells["Nombre"].Value != null)
                {
                    txtnombre.Text = filaseleccionada.Cells["Nombre"].Value.ToString();
                }
                else
                {
                    txtnombre.Text = "";
                }
                if (filaseleccionada.Cells["Especialidad"].Value != null)
                {
                    cboxespecialidad.SelectedItem = filaseleccionada.Cells["Especialidad"].Value.ToString();
                }
                if (filaseleccionada.Cells["Telefono"].Value != null)
                {
                    txttelefono.Text = filaseleccionada.Cells["Telefono"].Value.ToString();
                }
                else
                {
                    txttelefono.Text = "";
                }
                btnmodificar.Enabled = true;
                btneliminar.Enabled = true;
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (dgvmecanicos.CurrentRow != null && txtnombre.Text != "" && cboxespecialidad.SelectedIndex != -1)
            {
                int id = Convert.ToInt32(dgvmecanicos.CurrentRow.Cells["ID_Mecanico"].Value);
                Mecanico objmecanico = new Mecanico();
                objmecanico.ID_Mecanico = id;
                objmecanico.Nombre = txtnombre.Text;
                objmecanico.Especialidad = cboxespecialidad.SelectedItem.ToString();
                objmecanico.Telefono = txttelefono.Text;
                objmecanico.ModifiedBy = nombreusuario;
                objmecanico.ModifiedAt = DateTime.Now;
                string mensaje = objnegmecanico.Modificarmecanico(objmecanico);
                MessageBox.Show(mensaje);
                ActualizarDataGridView();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvmecanicos.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvmecanicos.CurrentRow.Cells["ID_Mecanico"].Value);
                string mensaje = objnegmecanico.Eliminarmecanico(id);
                MessageBox.Show(mensaje);
                ActualizarDataGridView();
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

