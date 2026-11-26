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
        NCliente objnegcliente = new NCliente();

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

        Panel Crearcarta(string titulo, string valor, Color color, int x)
        {
            Panel carta = new Panel();
            carta.BackColor = Color.White;
            carta.Location = new Point(x, 85);
            carta.Size = new Size(190, 90);

            Panel franja = new Panel();
            franja.BackColor = color;
            franja.Dock = DockStyle.Left;
            franja.Width = 6;

            Label lbltit = new Label();
            lbltit.Text = titulo;
            lbltit.Font = new Font("Segoe UI", 9F);
            lbltit.ForeColor = Color.FromArgb(108, 117, 125);
            lbltit.Location = new Point(16, 12);
            lbltit.AutoSize = true;

            Label lblval = new Label();
            lblval.Text = valor;
            lblval.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblval.ForeColor = color;
            lblval.Location = new Point(14, 36);
            lblval.AutoSize = true;

            carta.Controls.Add(lblval);
            carta.Controls.Add(lbltit);
            carta.Controls.Add(franja);
            return carta;
        }

        void Mostrarescritorio()
        {
            Limpiarcontenido();
            Marcarboton(btnescritorio);

            pnlescritorio = new Panel();
            pnlescritorio.Dock = DockStyle.Fill;
            pnlescritorio.BackColor = Tema.Fondo;

            Label lblbienvenida = new Label();
            lblbienvenida.Text = "Bienvenido, " + nombreusuario;
            lblbienvenida.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblbienvenida.ForeColor = Tema.Azul;
            lblbienvenida.Location = new Point(28, 18);
            lblbienvenida.AutoSize = true;
            pnlescritorio.Controls.Add(lblbienvenida);

            Label lblfecha = new Label();
            lblfecha.Text = "Rol: " + rolusuario + "   |   " + DateTime.Today.ToString("dd/MM/yyyy");
            lblfecha.Font = new Font("Segoe UI", 10F);
            lblfecha.ForeColor = Color.FromArgb(108, 117, 125);
            lblfecha.Location = new Point(30, 52);
            lblfecha.AutoSize = true;
            pnlescritorio.Controls.Add(lblfecha);

            List<OrdenServicio> ordenes = objnegorden.Listarordenes();
            int pendientes = 0;
            foreach (OrdenServicio o in ordenes)
            {
                if (o.Estado == "Pendiente" || o.Estado == "En Proceso")
                {
                    pendientes = pendientes + 1;
                }
            }
            int criticos = objnegrepuesto.Listarrepuestoscriticos().Count;
            int totalclientes = objnegcliente.Listarclientes().Count;

            int x = 30;
            pnlescritorio.Controls.Add(Crearcarta("Ordenes pendientes", pendientes.ToString(), Tema.AzulClaro, x));
            x = x + 205;
            pnlescritorio.Controls.Add(Crearcarta("Repuestos con stock critico", criticos.ToString(), Tema.Rojo, x));
            x = x + 205;
            pnlescritorio.Controls.Add(Crearcarta("Clientes registrados", totalclientes.ToString(), Tema.Verde, x));
            x = x + 205;
            if (rolusuario != "Recepcionista")
            {
                decimal ingresosmes = 0;
                DateTime inicio = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                List<OrdenServicio> concluidas = objnegorden.Listarordenesconcluidas("Todos", inicio, DateTime.Today);
                foreach (OrdenServicio c in concluidas)
                {
                    ingresosmes = ingresosmes + c.Total;
                }
                pnlescritorio.Controls.Add(Crearcarta("Ingresos del mes", "S/. " + ingresosmes.ToString("0.00"), Color.FromArgb(255, 153, 0), x));
            }

            Label lblultimas = new Label();
            lblultimas.Text = "Ultimas ordenes de servicio";
            lblultimas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblultimas.ForeColor = Color.FromArgb(73, 80, 87);
            lblultimas.Location = new Point(28, 200);
            lblultimas.AutoSize = true;
            pnlescritorio.Controls.Add(lblultimas);

            DataGridView dgvultimas = new DataGridView();
            dgvultimas.Location = new Point(30, 230);
            dgvultimas.Size = new Size(pnlcontenido.ClientSize.Width - 60, 300);
            dgvultimas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dgvultimas.ReadOnly = true;
            dgvultimas.AllowUserToAddRows = false;
            dgvultimas.AllowUserToResizeRows = false;
            dgvultimas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvultimas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvultimas.Columns.Add("Orden", "N Orden");
            dgvultimas.Columns.Add("Fecha", "Fecha");
            dgvultimas.Columns.Add("Descripcion", "Falla / Servicio");
            dgvultimas.Columns.Add("Estado", "Estado");
            dgvultimas.Columns.Add("Total", "Total");
            Tema.Estilargrilla(dgvultimas);

            int mostradas = 0;
            for (int i = ordenes.Count - 1; i >= 0; i--)
            {
                if (mostradas < 8)
                {
                    OrdenServicio item = ordenes[i];
                    dgvultimas.Rows.Add(item.ID_Orden, item.Fecha.ToString("dd/MM/yyyy"), item.Descripcion, item.Estado, "S/. " + item.Total.ToString("0.00"));
                    mostradas = mostradas + 1;
                }
            }
            pnlescritorio.Controls.Add(dgvultimas);
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
