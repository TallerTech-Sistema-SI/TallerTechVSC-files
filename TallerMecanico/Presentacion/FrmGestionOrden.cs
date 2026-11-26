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
    public partial class FrmGestionOrden : Form
    {
        public string nombreusuario = "admin";
        NOrdenServicio objnegorden = new NOrdenServicio();
        NRepuesto objnegrepuesto = new NRepuesto();
        NDetalleRepuesto objnegdetalle = new NDetalleRepuesto();

        public FrmGestionOrden()
        {
            InitializeComponent();
        }

        void CargarCombos()
        {
            int idactual = -1;
            if (cboxordenes.SelectedIndex != -1)
            {
                idactual = Convert.ToInt32(cboxordenes.SelectedValue);
            }
            cboxordenes.DataSource = null;
            cboxordenes.DisplayMember = "ID_Orden";
            cboxordenes.ValueMember = "ID_Orden";
            cboxordenes.DataSource = objnegorden.Listarordenes();
            if (idactual != -1)
            {
                cboxordenes.SelectedValue = idactual;
            }
            else
            {
                cboxordenes.SelectedIndex = -1;
            }

            cboxrepuesto.DataSource = null;
            cboxrepuesto.DisplayMember = "Nombre";
            cboxrepuesto.ValueMember = "ID_Repuesto";
            cboxrepuesto.DataSource = objnegrepuesto.Listarrepuestos();
            cboxrepuesto.SelectedIndex = -1;
        }

        void CargarEstados()
        {
            cboxnuevoestado.Items.Clear();
            cboxnuevoestado.Items.Add("Pendiente");
            cboxnuevoestado.Items.Add("En Proceso");
            cboxnuevoestado.Items.Add("Terminado");
            cboxnuevoestado.Items.Add("Entregado");
        }

        private void FrmGestionOrden_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarEstados();
        }

        private void cboxordenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxordenes.SelectedIndex != -1)
            {
                int idOrden = Convert.ToInt32(cboxordenes.SelectedValue);
                OrdenServicio orden = objnegorden.Buscarorden(idOrden);
                if (orden != null)
                {
                    lblestadoactual.Text = "Estado actual: " + orden.Estado;
                    lbltotal.Text = "Total de Orden: S/. " + orden.Total.ToString();

                    bool sepuedeeditarestado = false;
                    if (orden.Estado != "Entregado")
                    {
                        sepuedeeditarestado = true;
                    }
                    cboxnuevoestado.Enabled = sepuedeeditarestado;
                    btncambiarestado.Enabled = sepuedeeditarestado;

                    bool sepuedeagregarrepuestos = false;
                    if (orden.Estado != "Entregado" && orden.Estado != "Terminado")
                    {
                        sepuedeagregarrepuestos = true;
                    }
                    cboxrepuesto.Enabled = sepuedeagregarrepuestos;
                    txtcantidad.Enabled = sepuedeagregarrepuestos;
                    btnagregarrepuesto.Enabled = sepuedeagregarrepuestos;

                    dgvdetalles.AllowUserToAddRows = false;
                    dgvdetalles.DataSource = null;
                    dgvdetalles.DataSource = objnegdetalle.Listardetallesorden(idOrden);
                    if (dgvdetalles.Columns["ID_Detalle"] != null)
                    {
                        dgvdetalles.Columns["ID_Detalle"].Visible = false;
                    }
                    if (dgvdetalles.Columns["ID_Orden"] != null)
                    {
                        dgvdetalles.Columns["ID_Orden"].Visible = false;
                    }
                    if (dgvdetalles.Columns["ID_Repuesto"] != null)
                    {
                        dgvdetalles.Columns["ID_Repuesto"].Visible = false;
                    }
                    if (dgvdetalles.Columns["CreatedBy"] != null)
                    {
                        dgvdetalles.Columns["CreatedBy"].Visible = false;
                    }
                    if (dgvdetalles.Columns["CreatedAt"] != null)
                    {
                        dgvdetalles.Columns["CreatedAt"].Visible = false;
                    }
                    if (dgvdetalles.Columns["ModifiedBy"] != null)
                    {
                        dgvdetalles.Columns["ModifiedBy"].Visible = false;
                    }
                    if (dgvdetalles.Columns["ModifiedAt"] != null)
                    {
                        dgvdetalles.Columns["ModifiedAt"].Visible = false;
                    }
                    if (dgvdetalles.Columns["OrdenServicio"] != null)
                    {
                        dgvdetalles.Columns["OrdenServicio"].Visible = false;
                    }
                    if (dgvdetalles.Columns["Repuesto"] != null)
                    {
                        dgvdetalles.Columns["Repuesto"].Visible = false;
                    }
                }
            }
        }

        private void btnagregarrepuesto_Click(object sender, EventArgs e)
        {
            if (cboxordenes.SelectedIndex != -1 && cboxrepuesto.SelectedIndex != -1 && txtcantidad.Text != "")
            {
                int idOrden = Convert.ToInt32(cboxordenes.SelectedValue);
                int idRepuesto = Convert.ToInt32(cboxrepuesto.SelectedValue);
                int cantidad = 0;

                if (int.TryParse(txtcantidad.Text, out cantidad) && cantidad > 0)
                {
                    string mensaje = objnegdetalle.Agregardetalleorden(idOrden, idRepuesto, cantidad, nombreusuario);
                    MessageBox.Show(mensaje);
                    cboxordenes_SelectedIndexChanged(null, null);
                    CargarCombos();
                    txtcantidad.Text = "";
                }
                else
                {
                    MessageBox.Show("La cantidad debe ser un numero entero mayor a cero.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una orden, un repuesto y la cantidad a utilizar.");
            }
        }

        private void btncambiarestado_Click(object sender, EventArgs e)
        {
            if (cboxordenes.SelectedIndex != -1 && cboxnuevoestado.SelectedIndex != -1)
            {
                int idOrden = Convert.ToInt32(cboxordenes.SelectedValue);
                string nuevoEstado = cboxnuevoestado.SelectedItem.ToString();
                string mensaje = objnegorden.Cambiarestadoorden(idOrden, nuevoEstado, nombreusuario);
                MessageBox.Show(mensaje);
                cboxordenes_SelectedIndexChanged(null, null);
                CargarCombos();
            }
            else
            {
                MessageBox.Show("Seleccione una orden y el nuevo estado.");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblestadoactual_Click(object sender, EventArgs e)
        {

        }
    }
}

