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
    public partial class FrmConsultaRepuestos : Form
    {
        NRepuesto objnegrepuesto = new NRepuesto();
        NDetalleRepuesto objnegdetalle = new NDetalleRepuesto();

        public FrmConsultaRepuestos()
        {
            InitializeComponent();
        }

        void CargarGrilla(List<Repuesto> lista, string mensaje)
        {
            List<Detalle_Repuesto> detalles = objnegdetalle.Listardetalles();
            decimal costototalreabastecimiento = 0;

            dgvrepuestos.AllowUserToAddRows = false;
            dgvrepuestos.DataSource = null;
            dgvrepuestos.Columns.Clear();
            dgvrepuestos.Columns.Add("Codigo", "Codigo");
            dgvrepuestos.Columns.Add("Nombre", "Nombre");
            dgvrepuestos.Columns.Add("Marca", "Marca");
            dgvrepuestos.Columns.Add("Precio", "Precio");
            dgvrepuestos.Columns.Add("Stock", "Stock");
            dgvrepuestos.Columns.Add("StockMinimo", "Stock Minimo");
            dgvrepuestos.Columns.Add("Rotacion", "Rotacion");
            dgvrepuestos.Columns.Add("Estado", "Estado");
            dgvrepuestos.Columns.Add("CostoReabastecimiento", "Costo Reponer");

            foreach (Repuesto r in lista)
            {
                int usados = 0;
                foreach (Detalle_Repuesto d in detalles)
                {
                    if (d.ID_Repuesto == r.ID_Repuesto)
                    {
                        usados = usados + d.Cantidad;
                    }
                }

                string nivel = "Baja";
                if (usados >= 3)
                {
                    nivel = "Alta";
                }
                else
                {
                    if (usados >= 1)
                    {
                        nivel = "Media";
                    }
                }
                string rotacion = usados.ToString() + " (" + nivel + ")";

                string estado = "Normal";
                decimal costoreponer = 0;
                if (r.Stock <= r.StockMinimo)
                {
                    estado = "Critico";
                    int faltante = (r.StockMinimo * 2) - r.Stock;
                    costoreponer = faltante * r.Precio;
                    costototalreabastecimiento = costototalreabastecimiento + costoreponer;
                }

                int fila = dgvrepuestos.Rows.Add(
                    r.Codigo,
                    r.Nombre,
                    r.Marca,
                    r.Precio,
                    r.Stock,
                    r.StockMinimo,
                    rotacion,
                    estado,
                    costoreponer);

                if (r.Stock <= r.StockMinimo)
                {
                    dgvrepuestos.Rows[fila].DefaultCellStyle.BackColor = Color.MistyRose;
                    dgvrepuestos.Rows[fila].DefaultCellStyle.ForeColor = Color.DarkRed;
                }
            }

            lblmensaje.Text = mensaje + " | Costo estimado reabastecimiento: S/. " + costototalreabastecimiento.ToString();
        }

        private void FrmConsultaRepuestos_Load(object sender, EventArgs e)
        {
            CargarGrilla(objnegrepuesto.Listarrepuestos(), "Mostrando todo el inventario");
        }

        private void btnvercriticos_Click(object sender, EventArgs e)
        {
            CargarGrilla(objnegrepuesto.Listarrepuestoscriticos(), "Stock bajo (Stock <= Stock Minimo)");
        }

        private void btnvertodos_Click(object sender, EventArgs e)
        {
            CargarGrilla(objnegrepuesto.Listarrepuestos(), "Mostrando todo el inventario");
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
