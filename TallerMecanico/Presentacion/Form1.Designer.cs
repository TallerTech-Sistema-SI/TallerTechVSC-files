namespace Presentacion
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuIngresos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistrarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistrarVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistrarMecanico = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistrarRepuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNuevaOrden = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGestionOrden = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultaOrdenes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultaRepuestos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResumenIngresos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHistorialVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReporteMecanico = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuIngresos,
            this.mnuProcesos,
            this.mnuConsultas,
            this.mnuSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuIngresos
            // 
            this.mnuIngresos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegistrarCliente,
            this.mnuRegistrarVehiculo,
            this.mnuRegistrarMecanico,
            this.mnuRegistrarRepuesto,
            this.mnuNuevaOrden});
            this.mnuIngresos.Name = "mnuIngresos";
            this.mnuIngresos.Size = new System.Drawing.Size(63, 20);
            this.mnuIngresos.Text = "Ingresos";
            this.mnuIngresos.Click += new System.EventHandler(this.mnuIngresos_Click);
            // 
            // mnuRegistrarCliente
            // 
            this.mnuRegistrarCliente.Name = "mnuRegistrarCliente";
            this.mnuRegistrarCliente.Size = new System.Drawing.Size(204, 22);
            this.mnuRegistrarCliente.Text = "Registrar Cliente";
            this.mnuRegistrarCliente.Click += new System.EventHandler(this.mnuRegistrarCliente_Click);
            // 
            // mnuRegistrarVehiculo
            // 
            this.mnuRegistrarVehiculo.Name = "mnuRegistrarVehiculo";
            this.mnuRegistrarVehiculo.Size = new System.Drawing.Size(204, 22);
            this.mnuRegistrarVehiculo.Text = "Registrar Vehiculo";
            this.mnuRegistrarVehiculo.Click += new System.EventHandler(this.mnuRegistrarVehiculo_Click);
            // 
            // mnuRegistrarMecanico
            // 
            this.mnuRegistrarMecanico.Name = "mnuRegistrarMecanico";
            this.mnuRegistrarMecanico.Size = new System.Drawing.Size(204, 22);
            this.mnuRegistrarMecanico.Text = "Registrar Mecanico";
            this.mnuRegistrarMecanico.Click += new System.EventHandler(this.mnuRegistrarMecanico_Click);
            // 
            // mnuRegistrarRepuesto
            // 
            this.mnuRegistrarRepuesto.Name = "mnuRegistrarRepuesto";
            this.mnuRegistrarRepuesto.Size = new System.Drawing.Size(204, 22);
            this.mnuRegistrarRepuesto.Text = "Registrar Repuesto";
            this.mnuRegistrarRepuesto.Click += new System.EventHandler(this.mnuRegistrarRepuesto_Click);
            // 
            // mnuNuevaOrden
            // 
            this.mnuNuevaOrden.Name = "mnuNuevaOrden";
            this.mnuNuevaOrden.Size = new System.Drawing.Size(204, 22);
            this.mnuNuevaOrden.Text = "Nueva Orden de Servicio";
            this.mnuNuevaOrden.Click += new System.EventHandler(this.mnuNuevaOrden_Click);
            // 
            // mnuProcesos
            // 
            this.mnuProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGestionOrden});
            this.mnuProcesos.Name = "mnuProcesos";
            this.mnuProcesos.Size = new System.Drawing.Size(66, 20);
            this.mnuProcesos.Text = "Procesos";
            // 
            // mnuGestionOrden
            // 
            this.mnuGestionOrden.Name = "mnuGestionOrden";
            this.mnuGestionOrden.Size = new System.Drawing.Size(232, 22);
            this.mnuGestionOrden.Text = "Gestion de Orden y Repuestos";
            this.mnuGestionOrden.Click += new System.EventHandler(this.mnuGestionOrden_Click);
            // 
            // mnuConsultas
            // 
            this.mnuConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConsultaOrdenes,
            this.mnuConsultaRepuestos,
            this.mnuResumenIngresos,
            this.mnuHistorialVehiculo,
            this.mnuReporteMecanico});
            this.mnuConsultas.Name = "mnuConsultas";
            this.mnuConsultas.Size = new System.Drawing.Size(71, 20);
            this.mnuConsultas.Text = "Consultas";
            // 
            // mnuConsultaOrdenes
            // 
            this.mnuConsultaOrdenes.Name = "mnuConsultaOrdenes";
            this.mnuConsultaOrdenes.Size = new System.Drawing.Size(243, 22);
            this.mnuConsultaOrdenes.Text = "Consulta de Ordenes por Estado";
            this.mnuConsultaOrdenes.Click += new System.EventHandler(this.mnuConsultaOrdenes_Click);
            // 
            // mnuConsultaRepuestos
            // 
            this.mnuConsultaRepuestos.Name = "mnuConsultaRepuestos";
            this.mnuConsultaRepuestos.Size = new System.Drawing.Size(243, 22);
            this.mnuConsultaRepuestos.Text = "Control de Stock de Repuestos";
            this.mnuConsultaRepuestos.Click += new System.EventHandler(this.mnuConsultaRepuestos_Click);
            // 
            // mnuResumenIngresos
            // 
            this.mnuResumenIngresos.Name = "mnuResumenIngresos";
            this.mnuResumenIngresos.Size = new System.Drawing.Size(243, 22);
            this.mnuResumenIngresos.Text = "Resumen de Ingresos";
            this.mnuResumenIngresos.Click += new System.EventHandler(this.mnuResumenIngresos_Click);
            // 
            // mnuHistorialVehiculo
            // 
            this.mnuHistorialVehiculo.Name = "mnuHistorialVehiculo";
            this.mnuHistorialVehiculo.Size = new System.Drawing.Size(243, 22);
            this.mnuHistorialVehiculo.Text = "Historial de Vehiculo";
            this.mnuHistorialVehiculo.Click += new System.EventHandler(this.mnuHistorialVehiculo_Click);
            // 
            // mnuReporteMecanico
            // 
            this.mnuReporteMecanico.Name = "mnuReporteMecanico";
            this.mnuReporteMecanico.Size = new System.Drawing.Size(243, 22);
            this.mnuReporteMecanico.Text = "Reporte de Ordenes por Mecanico";
            this.mnuReporteMecanico.Click += new System.EventHandler(this.mnuReporteMecanico_Click);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(41, 20);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TallerTech - Sistema de Gestion de Talleres Mecanicos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuIngresos;
        private System.Windows.Forms.ToolStripMenuItem mnuRegistrarCliente;
        private System.Windows.Forms.ToolStripMenuItem mnuRegistrarVehiculo;
        private System.Windows.Forms.ToolStripMenuItem mnuRegistrarMecanico;
        private System.Windows.Forms.ToolStripMenuItem mnuRegistrarRepuesto;
        private System.Windows.Forms.ToolStripMenuItem mnuNuevaOrden;
        private System.Windows.Forms.ToolStripMenuItem mnuProcesos;
        private System.Windows.Forms.ToolStripMenuItem mnuGestionOrden;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultas;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaOrdenes;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaRepuestos;
        private System.Windows.Forms.ToolStripMenuItem mnuResumenIngresos;
        private System.Windows.Forms.ToolStripMenuItem mnuHistorialVehiculo;
        private System.Windows.Forms.ToolStripMenuItem mnuReporteMecanico;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
    }
}

