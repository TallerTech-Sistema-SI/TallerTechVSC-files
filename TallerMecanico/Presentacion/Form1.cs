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
    public partial class Form1 : Form
    {
        public string rolusuario = "";
        public string nombreusuario = "";

        Form formactual = null;
        Panel pnlescritorio = null;
        Button botonactivo = null;

        NOrdenServicio objnegorden = new NOrdenServicio();
        NRepuesto objnegrepuesto = new NRepuesto();

        public Form1()
        {
            InitializeComponent();
        }

        // ---------- Manejo del contenido ----------

        void Marcarboton(Button boton)
        {
            if (botonactivo != null)
            {
                botonactivo.BackColor = Color.FromArgb(233, 236, 239);
                botonactivo.ForeColor = Color.FromArgb(51, 51, 51);
            }
            botonactivo = boton;
            if (botonactivo != null)
            {
                botonactivo.BackColor = Tema.Azul;
                botonactivo.ForeColor = Color.White;
            }
        }

        void Limpiarcontenido()
        {
            if (formactual != null)
            {
                formactual.FormClosed -= new FormClosedEventHandler(Formularioembebidocerrado);
                formactual.Close();
                pnlcontenido.Controls.Remove(formactual);
                formactual = null;
            }
            if (pnlescritorio != null)
            {
                pnlcontenido.Controls.Remove(pnlescritorio);
                pnlescritorio.Dispose();
                pnlescritorio = null;
            }
        }

        void Centrarformulario()
        {
            if (formactual != null)
            {
                int x = (pnlcontenido.ClientSize.Width - formactual.Width) / 2;
                int y = (pnlcontenido.ClientSize.Height - formactual.Height) / 2;
                if (x < 0)
                {
                    x = 0;
                }
                if (y < 15)
                {
                    y = 15;
                }
                formactual.Location = new Point(x, y);
            }
        }

        void Abrirformulario(Form frm, Button boton)
        {
            Limpiarcontenido();
            formactual = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;
            Tema.Aplicar(frm);
            pnlcontenido.Controls.Add(frm);
            frm.FormClosed += new FormClosedEventHandler(Formularioembebidocerrado);
            Centrarformulario();
            frm.Show();
            Marcarboton(boton);
        }

        void Formularioembebidocerrado(object sender, FormClosedEventArgs e)
        {
            formactual = null;
            Mostrarescritorio();
        }

        private void pnlcontenido_Resize(object sender, EventArgs e)
        {
            Centrarformulario();
        }

        // ---------- Escritorio ----------

        Label Crearetiqueta(string texto, float tam, FontStyle estilo, Color color, int x, int y)
        {
            Label lbl = new Label();
            lbl.Text = texto;
            lbl.Font = new Font("Segoe UI", tam, estilo);
            lbl.ForeColor = color;
            lbl.Location = new Point(x, y);
            lbl.AutoSize = true;
            return lbl;
        }

        DataGridView Creargrilla()
        {
            DataGridView dgv = new DataGridView();
            dgv.Dock = DockStyle.Fill;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Margin = new Padding(0, 6, 20, 0);
            return dgv;
        }

        void Mostrarescritorio()
        {
            Limpiarcontenido();
            Marcarboton(btnescritorio);

            pnlescritorio = new Panel();
            pnlescritorio.Dock = DockStyle.Fill;
            pnlescritorio.BackColor = Tema.Fondo;
            pnlescritorio.Padding = new Padding(32, 0, 12, 24);

            List<OrdenServicio> ordenes = objnegorden.Listarordenes();
            List<OrdenServicio> poratender = new List<OrdenServicio>();
            foreach (OrdenServicio o in ordenes)
            {
                if (o.Estado == "Pendiente" || o.Estado == "En Proceso")
                {
                    poratender.Add(o);
                }
            }
            List<Repuesto> criticos = objnegrepuesto.Listarrepuestoscriticos();

            Panel cabecera = new Panel();
            cabecera.Dock = DockStyle.Top;
            cabecera.Height = 130;
            cabecera.Controls.Add(Crearetiqueta("Buen dia, " + nombreusuario, 18F, FontStyle.Bold, Tema.Texto, 0, 28));
            string resumen = "Hay " + poratender.Count.ToString() + " ordenes por atender y " + criticos.Count.ToString() + " repuestos con stock critico.";
            cabecera.Controls.Add(Crearetiqueta(resumen, 11F, FontStyle.Regular, Tema.Texto, 2, 68));
            if (rolusuario != "Recepcionista")
            {
                decimal ingresosmes = 0;
                DateTime inicio = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                List<OrdenServicio> concluidas = objnegorden.Listarordenesconcluidas("Todos", inicio, DateTime.Today);
                foreach (OrdenServicio c in concluidas)
                {
                    ingresosmes = ingresosmes + c.Total;
                }
                cabecera.Controls.Add(Crearetiqueta("Ingresos del mes: S/. " + ingresosmes.ToString("0.00"), 11F, FontStyle.Regular, Tema.Texto, 2, 94));
            }

            TableLayoutPanel tabla = new TableLayoutPanel();
            tabla.Dock = DockStyle.Fill;
            tabla.ColumnCount = 2;
            tabla.RowCount = 2;
            tabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
            tabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            tabla.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tabla.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tabla.Controls.Add(Crearetiqueta("Ordenes por atender", 11F, FontStyle.Bold, Tema.Texto, 0, 0), 0, 0);
            tabla.Controls.Add(Crearetiqueta("Repuestos por reponer", 11F, FontStyle.Bold, Tema.Texto, 0, 0), 1, 0);

            DataGridView dgvordenes = Creargrilla();
            dgvordenes.Columns.Add("Orden", "N");
            dgvordenes.Columns.Add("Fecha", "Fecha");
            dgvordenes.Columns.Add("Descripcion", "Falla / Servicio");
            dgvordenes.Columns.Add("Estado", "Estado");
            dgvordenes.Columns["Orden"].FillWeight = 20;
            dgvordenes.Columns["Fecha"].FillWeight = 40;
            dgvordenes.Columns["Descripcion"].FillWeight = 100;
            dgvordenes.Columns["Estado"].FillWeight = 50;
            Tema.Estilargrilla(dgvordenes);
            foreach (OrdenServicio item in poratender)
            {
                dgvordenes.Rows.Add(item.ID_Orden, item.Fecha.ToString("dd/MM/yyyy"), item.Descripcion, item.Estado);
            }
            tabla.Controls.Add(dgvordenes, 0, 1);

            DataGridView dgvrepuestos = Creargrilla();
            dgvrepuestos.Margin = new Padding(0, 6, 0, 0);
            dgvrepuestos.Columns.Add("Nombre", "Repuesto");
            dgvrepuestos.Columns.Add("Stock", "Stock");
            dgvrepuestos.Columns.Add("Minimo", "Minimo");
            dgvrepuestos.Columns["Nombre"].FillWeight = 100;
            dgvrepuestos.Columns["Stock"].FillWeight = 30;
            dgvrepuestos.Columns["Minimo"].FillWeight = 30;
            Tema.Estilargrilla(dgvrepuestos);
            foreach (Repuesto r in criticos)
            {
                dgvrepuestos.Rows.Add(r.Nombre, r.Stock, r.StockMinimo);
            }
            tabla.Controls.Add(dgvrepuestos, 1, 1);

            pnlescritorio.Controls.Add(tabla);
            pnlescritorio.Controls.Add(cabecera);
            pnlcontenido.Controls.Add(pnlescritorio);
        }

        // ---------- Menu lateral ----------

        private void btnescritorio_Click(object sender, EventArgs e)
        {
            Mostrarescritorio();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.nombreusuario = nombreusuario;
            Abrirformulario(frm, btnclientes);
        }

        private void btnvehiculos_Click(object sender, EventArgs e)
        {
            FrmVehiculo frm = new FrmVehiculo();
            frm.nombreusuario = nombreusuario;
            Abrirformulario(frm, btnvehiculos);
        }

        private void btnmecanicos_Click(object sender, EventArgs e)
        {
            FrmMecanico frm = new FrmMecanico();
            frm.nombreusuario = nombreusuario;
            Abrirformulario(frm, btnmecanicos);
        }

        private void btnrepuestos_Click(object sender, EventArgs e)
        {
            FrmRepuesto frm = new FrmRepuesto();
            frm.nombreusuario = nombreusuario;
            Abrirformulario(frm, btnrepuestos);
        }

        private void btnnuevaorden_Click(object sender, EventArgs e)
        {
            FrmOrdenServicio frm = new FrmOrdenServicio();
            frm.nombreusuario = nombreusuario;
            Abrirformulario(frm, btnnuevaorden);
        }

        private void btngestionorden_Click(object sender, EventArgs e)
        {
            FrmGestionOrden frm = new FrmGestionOrden();
            frm.nombreusuario = nombreusuario;
            Abrirformulario(frm, btngestionorden);
        }

        private void btnconsultaordenes_Click(object sender, EventArgs e)
        {
            Abrirformulario(new FrmConsultaOrdenes(), btnconsultaordenes);
        }

        private void btnconsultarepuestos_Click(object sender, EventArgs e)
        {
            Abrirformulario(new FrmConsultaRepuestos(), btnconsultarepuestos);
        }

        private void btnhistorialvehiculo_Click(object sender, EventArgs e)
        {
            Abrirformulario(new FrmHistorialVehiculo(), btnhistorialvehiculo);
        }

        private void btnresumeningresos_Click(object sender, EventArgs e)
        {
            Abrirformulario(new FrmResumenIngresos(), btnresumeningresos);
        }

        private void btnreportemecanico_Click(object sender, EventArgs e)
        {
            Abrirformulario(new FrmReporteMecanico(), btnreportemecanico);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (rolusuario != "")
            {
                this.Text = "TallerTech - Sistema de Gestion de Talleres Mecanicos [" + nombreusuario + " - " + rolusuario + "]";
            }
            lblusuarioinfo.Text = nombreusuario + "  (" + rolusuario + ")";
            if (rolusuario == "Recepcionista")
            {
                btnmecanicos.Enabled = false;
                btnrepuestos.Enabled = false;
                btnresumeningresos.Enabled = false;
                btnreportemecanico.Enabled = false;
            }
            Mostrarescritorio();
        }
    }
}
