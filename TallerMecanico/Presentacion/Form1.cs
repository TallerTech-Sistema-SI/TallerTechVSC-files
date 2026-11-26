using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public string rolusuario = "";
        public string nombreusuario = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void mnuRegistrarCliente_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.nombreusuario = nombreusuario;
            frm.ShowDialog();
        }

        private void mnuRegistrarVehiculo_Click(object sender, EventArgs e)
        {
            FrmVehiculo frm = new FrmVehiculo();
            frm.nombreusuario = nombreusuario;
            frm.ShowDialog();
        }

        private void mnuRegistrarMecanico_Click(object sender, EventArgs e)
        {
            FrmMecanico frm = new FrmMecanico();
            frm.nombreusuario = nombreusuario;
            frm.ShowDialog();
        }

        private void mnuRegistrarRepuesto_Click(object sender, EventArgs e)
        {
            FrmRepuesto frm = new FrmRepuesto();
            frm.nombreusuario = nombreusuario;
            frm.ShowDialog();
        }

        private void mnuNuevaOrden_Click(object sender, EventArgs e)
        {
            FrmOrdenServicio frm = new FrmOrdenServicio();
            frm.nombreusuario = nombreusuario;
            frm.ShowDialog();
        }

        private void mnuGestionOrden_Click(object sender, EventArgs e)
        {
            FrmGestionOrden frm = new FrmGestionOrden();
            frm.nombreusuario = nombreusuario;
            frm.ShowDialog();
        }

        private void mnuConsultaOrdenes_Click(object sender, EventArgs e)
        {
            FrmConsultaOrdenes frm = new FrmConsultaOrdenes();
            frm.ShowDialog();
        }

        private void mnuConsultaRepuestos_Click(object sender, EventArgs e)
        {
            FrmConsultaRepuestos frm = new FrmConsultaRepuestos();
            frm.ShowDialog();
        }

        private void mnuResumenIngresos_Click(object sender, EventArgs e)
        {
            FrmResumenIngresos frm = new FrmResumenIngresos();
            frm.ShowDialog();
        }

        private void mnuReporteMecanico_Click(object sender, EventArgs e)
        {
            FrmReporteMecanico frm = new FrmReporteMecanico();
            frm.ShowDialog();
        }

        private void mnuHistorialVehiculo_Click(object sender, EventArgs e)
        {
            FrmHistorialVehiculo frm = new FrmHistorialVehiculo();
            frm.ShowDialog();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuIngresos_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (rolusuario != "")
            {
                this.Text = "TallerTech - Sistema de Gestion de Talleres Mecanicos [" + nombreusuario + " - " + rolusuario + "]";
            }
            if (rolusuario == "Recepcionista")
            {
                mnuRegistrarMecanico.Enabled = false;
                mnuRegistrarRepuesto.Enabled = false;
                mnuResumenIngresos.Enabled = false;
                mnuReporteMecanico.Enabled = false;
            }
        }
    }
}

