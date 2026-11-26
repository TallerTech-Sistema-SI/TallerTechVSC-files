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
            this.pnltop = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblusuarioinfo = new System.Windows.Forms.Label();
            this.pnlmenu = new System.Windows.Forms.Panel();
            this.pnlcontenido = new System.Windows.Forms.Panel();
            this.btnescritorio = new System.Windows.Forms.Button();
            this.lblseccion1 = new System.Windows.Forms.Label();
            this.btnclientes = new System.Windows.Forms.Button();
            this.btnvehiculos = new System.Windows.Forms.Button();
            this.btnmecanicos = new System.Windows.Forms.Button();
            this.btnrepuestos = new System.Windows.Forms.Button();
            this.lblseccion2 = new System.Windows.Forms.Label();
            this.btnnuevaorden = new System.Windows.Forms.Button();
            this.btngestionorden = new System.Windows.Forms.Button();
            this.lblseccion3 = new System.Windows.Forms.Label();
            this.btnconsultaordenes = new System.Windows.Forms.Button();
            this.btnconsultarepuestos = new System.Windows.Forms.Button();
            this.btnhistorialvehiculo = new System.Windows.Forms.Button();
            this.btnresumeningresos = new System.Windows.Forms.Button();
            this.btnreportemecanico = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.pnltop.SuspendLayout();
            this.pnlmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(0, 90, 156);
            this.pnltop.Controls.Add(this.lblusuarioinfo);
            this.pnltop.Controls.Add(this.lbltitulo);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1100, 55);
            this.pnltop.TabIndex = 0;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(18, 14);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(300, 25);
            this.lbltitulo.Text = "TallerTech - Sistema de Gestion";
            // 
            // lblusuarioinfo
            // 
            this.lblusuarioinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblusuarioinfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblusuarioinfo.ForeColor = System.Drawing.Color.White;
            this.lblusuarioinfo.Location = new System.Drawing.Point(700, 17);
            this.lblusuarioinfo.Name = "lblusuarioinfo";
            this.lblusuarioinfo.Size = new System.Drawing.Size(380, 22);
            this.lblusuarioinfo.Text = "Usuario";
            this.lblusuarioinfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlmenu
            // 
            this.pnlmenu.AutoScroll = true;
            this.pnlmenu.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.pnlmenu.Controls.Add(this.btnescritorio);
            this.pnlmenu.Controls.Add(this.lblseccion1);
            this.pnlmenu.Controls.Add(this.btnclientes);
            this.pnlmenu.Controls.Add(this.btnvehiculos);
            this.pnlmenu.Controls.Add(this.btnmecanicos);
            this.pnlmenu.Controls.Add(this.btnrepuestos);
            this.pnlmenu.Controls.Add(this.lblseccion2);
            this.pnlmenu.Controls.Add(this.btnnuevaorden);
            this.pnlmenu.Controls.Add(this.btngestionorden);
            this.pnlmenu.Controls.Add(this.lblseccion3);
            this.pnlmenu.Controls.Add(this.btnconsultaordenes);
            this.pnlmenu.Controls.Add(this.btnconsultarepuestos);
            this.pnlmenu.Controls.Add(this.btnhistorialvehiculo);
            this.pnlmenu.Controls.Add(this.btnresumeningresos);
            this.pnlmenu.Controls.Add(this.btnreportemecanico);
            this.pnlmenu.Controls.Add(this.btnsalir);
            this.pnlmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlmenu.Location = new System.Drawing.Point(0, 55);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(230, 665);
            this.pnlmenu.TabIndex = 1;
            // 
            // pnlcontenido
            // 
            this.pnlcontenido.AutoScroll = true;
            this.pnlcontenido.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.pnlcontenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcontenido.Location = new System.Drawing.Point(230, 55);
            this.pnlcontenido.Name = "pnlcontenido";
            this.pnlcontenido.Size = new System.Drawing.Size(870, 665);
            this.pnlcontenido.TabIndex = 2;
            this.pnlcontenido.Resize += new System.EventHandler(this.pnlcontenido_Resize);
            // 
            // btnescritorio
            // 
            this.btnescritorio.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.btnescritorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnescritorio.FlatAppearance.BorderSize = 0;
            this.btnescritorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnescritorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnescritorio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnescritorio.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.btnescritorio.Location = new System.Drawing.Point(0, 8);
            this.btnescritorio.Name = "btnescritorio";
            this.btnescritorio.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnescritorio.Size = new System.Drawing.Size(230, 38);
            this.btnescritorio.Text = "\U0001F3E0  Escritorio";
            this.btnescritorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnescritorio.UseVisualStyleBackColor = false;
            this.btnescritorio.Click += new System.EventHandler(this.btnescritorio_Click);
            // 
            // lblseccion1
            // 
            this.lblseccion1.AutoSize = true;
            this.lblseccion1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblseccion1.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblseccion1.Location = new System.Drawing.Point(16, 56);
            this.lblseccion1.Name = "lblseccion1";
            this.lblseccion1.Size = new System.Drawing.Size(60, 13);
            this.lblseccion1.Text = "REGISTROS";
            // 
            // btnclientes
            // 
            this.btnclientes.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.btnclientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclientes.FlatAppearance.BorderSize = 0;
            this.btnclientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnclientes.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.btnclientes.Location = new System.Drawing.Point(0, 82);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnclientes.Size = new System.Drawing.Size(230, 38);
            this.btnclientes.Text = "\U0001F465  Clientes";
            this.btnclientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.UseVisualStyleBackColor = false;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // btnvehiculos
            // 
            this.btnvehiculos.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.btnvehiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvehiculos.FlatAppearance.BorderSize = 0;
            this.btnvehiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnvehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvehiculos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnvehiculos.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.btnvehiculos.Location = new System.Drawing.Point(0, 122);
            this.btnvehiculos.Name = "btnvehiculos";
            this.btnvehiculos.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnvehiculos.Size = new System.Drawing.Size(230, 38);
            this.btnvehiculos.Text = "\U0001F697  Vehiculos";
            this.btnvehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvehiculos.UseVisualStyleBackColor = false;
            this.btnvehiculos.Click += new System.EventHandler(this.btnvehiculos_Click);
            // 
            // btnmecanicos
            // 
            this.btnmecanicos.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.btnmecanicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmecanicos.FlatAppearance.BorderSize = 0;
            this.btnmecanicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnmecanicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmecanicos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnmecanicos.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.btnmecanicos.Location = new System.Drawing.Point(0, 162);
            this.btnmecanicos.Name = "btnmecanicos";
            this.btnmecanicos.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnmecanicos.Size = new System.Drawing.Size(230, 38);
            this.btnmecanicos.Text = "\U0001F527  Mecanicos";
            this.btnmecanicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmecanicos.UseVisualStyleBackColor = false;
            this.btnmecanicos.Click += new System.EventHandler(this.btnmecanicos_Click);
            // 
            // btnrepuestos
            // 
            this.btnrepuestos.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.btnrepuestos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrepuestos.FlatAppearance.BorderSize = 0;
            this.btnrepuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnrepuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrepuestos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnrepuestos.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.btnrepuestos.Location = new System.Drawing.Point(0, 202);
            this.btnrepuestos.Name = "btnrepuestos";
            this.btnrepuestos.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnrepuestos.Size = new System.Drawing.Size(230, 38);
            this.btnrepuestos.Text = "\U0001F4E6  Repuestos";
            this.btnrepuestos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrepuestos.UseVisualStyleBackColor = false;
            this.btnrepuestos.Click += new System.EventHandler(this.btnrepuestos_Click);
            // 
            // lblseccion2
            // 
            this.lblseccion2.AutoSize = true;
            this.lblseccion2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblseccion2.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblseccion2.Location = new System.Drawing.Point(16, 250);
            this.lblseccion2.Name = "lblseccion2";
            this.lblseccion2.Size = new System.Drawing.Size(60, 13);
            this.lblseccion2.Text = "PROCESOS";
            // 
            // btnnuevaorden
            // 
            this.btnnuevaorden.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.btnnuevaorden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevaorden.FlatAppearance.BorderSize = 0;
            this.btnnuevaorden.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnnuevaorden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevaorden.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnnuevaorden.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.btnnuevaorden.Location = new System.Drawing.Point(0, 276);
            this.btnnuevaorden.Name = "btnnuevaorden";
            this.btnnuevaorden.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnnuevaorden.Size = new System.Drawing.Size(230, 38);
            this.btnnuevaorden.Text = "\U0001F4DD  Nueva Orden";
            this.btnnuevaorden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevaorden.UseVisualStyleBackColor = false;
            this.btnnuevaorden.Click += new System.EventHandler(this.btnnuevaorden_Click);
            // 
            // btngestionorden
            // 
            this.btngestionorden.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.btngestionorden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngestionorden.FlatAppearance.BorderSize = 0;
            this.btngestionorden.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btngestionorden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngestionorden.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btngestionorden.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.btngestionorden.Location = new System.Drawing.Point(0, 316);
            this.btngestionorden.Name = "btngestionorden";
            this.btngestionorden.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btngestionorden.Size = new System.Drawing.Size(230, 38);
            this.btngestionorden.Text = "\U0001F4CB  Gestion de Ordenes";
            this.btngestionorden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngestionorden.UseVisualStyleBackColor = false;
            this.btngestionorden.Click += new System.EventHandler(this.btngestionorden_Click);
            // 
            // lblseccion3
            // 
            this.lblseccion3.AutoSize = true;
            this.lblseccion3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblseccion3.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblseccion3.Location = new System.Drawing.Point(16, 364);
            this.lblseccion3.Name = "lblseccion3";
            this.lblseccion3.Size = new System.Drawing.Size(60, 13);
            this.lblseccion3.Text = "CONSULTAS Y REPORTES";
            // 
            // btnconsultaordenes
            // 
            this.btnconsultaordenes.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.btnconsultaordenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconsultaordenes.FlatAppearance.BorderSize = 0;
            this.btnconsultaordenes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnconsultaordenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsultaordenes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnconsultaordenes.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.btnconsultaordenes.Location = new System.Drawing.Point(0, 390);
            this.btnconsultaordenes.Name = "btnconsultaordenes";
            this.btnconsultaordenes.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnconsultaordenes.Size = new System.Drawing.Size(230, 38);
            this.btnconsultaordenes.Text = "\U0001F50D  Consulta de Ordenes";
            this.btnconsultaordenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconsultaordenes.UseVisualStyleBackColor = false;
            this.btnconsultaordenes.Click += new System.EventHandler(this.btnconsultaordenes_Click);
            // 
            // btnconsultarepuestos
            // 
            this.btnconsultarepuestos.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.btnconsultarepuestos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconsultarepuestos.FlatAppearance.BorderSize = 0;
            this.btnconsultarepuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnconsultarepuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsultarepuestos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnconsultarepuestos.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.btnconsultarepuestos.Location = new System.Drawing.Point(0, 430);
            this.btnconsultarepuestos.Name = "btnconsultarepuestos";
            this.btnconsultarepuestos.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnconsultarepuestos.Size = new System.Drawing.Size(230, 38);
            this.btnconsultarepuestos.Text = "\U0001F50E  Consulta de Repuestos";
            this.btnconsultarepuestos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconsultarepuestos.UseVisualStyleBackColor = false;
            this.btnconsultarepuestos.Click += new System.EventHandler(this.btnconsultarepuestos_Click);
            // 
            // btnhistorialvehiculo
            // 
            this.btnhistorialvehiculo.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.btnhistorialvehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhistorialvehiculo.FlatAppearance.BorderSize = 0;
            this.btnhistorialvehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnhistorialvehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhistorialvehiculo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnhistorialvehiculo.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.btnhistorialvehiculo.Location = new System.Drawing.Point(0, 470);
            this.btnhistorialvehiculo.Name = "btnhistorialvehiculo";
            this.btnhistorialvehiculo.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnhistorialvehiculo.Size = new System.Drawing.Size(230, 38);
            this.btnhistorialvehiculo.Text = "\U0001F4D6  Historial de Vehiculo";
            this.btnhistorialvehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhistorialvehiculo.UseVisualStyleBackColor = false;
            this.btnhistorialvehiculo.Click += new System.EventHandler(this.btnhistorialvehiculo_Click);
            // 
            // btnresumeningresos
            // 
            this.btnresumeningresos.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.btnresumeningresos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnresumeningresos.FlatAppearance.BorderSize = 0;
            this.btnresumeningresos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnresumeningresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresumeningresos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnresumeningresos.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.btnresumeningresos.Location = new System.Drawing.Point(0, 510);
            this.btnresumeningresos.Name = "btnresumeningresos";
            this.btnresumeningresos.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnresumeningresos.Size = new System.Drawing.Size(230, 38);
            this.btnresumeningresos.Text = "\U0001F4C8  Resumen de Ingresos";
            this.btnresumeningresos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnresumeningresos.UseVisualStyleBackColor = false;
            this.btnresumeningresos.Click += new System.EventHandler(this.btnresumeningresos_Click);
            // 
            // btnreportemecanico
            // 
            this.btnreportemecanico.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.btnreportemecanico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreportemecanico.FlatAppearance.BorderSize = 0;
            this.btnreportemecanico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnreportemecanico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreportemecanico.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnreportemecanico.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.btnreportemecanico.Location = new System.Drawing.Point(0, 550);
            this.btnreportemecanico.Name = "btnreportemecanico";
            this.btnreportemecanico.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnreportemecanico.Size = new System.Drawing.Size(230, 38);
            this.btnreportemecanico.Text = "\U0001F477  Reporte por Mecanico";
            this.btnreportemecanico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreportemecanico.UseVisualStyleBackColor = false;
            this.btnreportemecanico.Click += new System.EventHandler(this.btnreportemecanico_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnsalir.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.btnsalir.Location = new System.Drawing.Point(0, 598);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnsalir.Size = new System.Drawing.Size(230, 38);
            this.btnsalir.Text = "\U0001F6AA  Salir";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.Controls.Add(this.pnlcontenido);
            this.Controls.Add(this.pnlmenu);
            this.Controls.Add(this.pnltop);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TallerTech - Sistema de Gestion de Talleres Mecanicos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.pnlmenu.ResumeLayout(false);
            this.pnlmenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblusuarioinfo;
        private System.Windows.Forms.Panel pnlmenu;
        private System.Windows.Forms.Panel pnlcontenido;
        private System.Windows.Forms.Button btnescritorio;
        private System.Windows.Forms.Label lblseccion1;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btnvehiculos;
        private System.Windows.Forms.Button btnmecanicos;
        private System.Windows.Forms.Button btnrepuestos;
        private System.Windows.Forms.Label lblseccion2;
        private System.Windows.Forms.Button btnnuevaorden;
        private System.Windows.Forms.Button btngestionorden;
        private System.Windows.Forms.Label lblseccion3;
        private System.Windows.Forms.Button btnconsultaordenes;
        private System.Windows.Forms.Button btnconsultarepuestos;
        private System.Windows.Forms.Button btnhistorialvehiculo;
        private System.Windows.Forms.Button btnresumeningresos;
        private System.Windows.Forms.Button btnreportemecanico;
        private System.Windows.Forms.Button btnsalir;
    }
}
