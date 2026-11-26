namespace Presentacion
{
    partial class FrmOrdenServicio
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblvehiculo = new System.Windows.Forms.Label();
            this.cboxvehiculo = new System.Windows.Forms.ComboBox();
            this.lblmecanico = new System.Windows.Forms.Label();
            this.cboxmecanico = new System.Windows.Forms.ComboBox();
            this.lblfecha = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.lblmanoobra = new System.Windows.Forms.Label();
            this.txtmanoobra = new System.Windows.Forms.TextBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.dgvordenes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbltitulo.Location = new System.Drawing.Point(20, 15);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(262, 32);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Registro de Ordenes de Servicio";
            // 
            // lblvehiculo
            // 
            this.lblvehiculo.AutoSize = true;
            this.lblvehiculo.Location = new System.Drawing.Point(25, 65);
            this.lblvehiculo.Name = "lblvehiculo";
            this.lblvehiculo.Size = new System.Drawing.Size(66, 17);
            this.lblvehiculo.TabIndex = 1;
            this.lblvehiculo.Text = "Vehiculo:";
            // 
            // cboxvehiculo
            // 
            this.cboxvehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxvehiculo.FormattingEnabled = true;
            this.cboxvehiculo.Location = new System.Drawing.Point(120, 62);
            this.cboxvehiculo.Name = "cboxvehiculo";
            this.cboxvehiculo.Size = new System.Drawing.Size(280, 24);
            this.cboxvehiculo.TabIndex = 2;
            // 
            // lblmecanico
            // 
            this.lblmecanico.AutoSize = true;
            this.lblmecanico.Location = new System.Drawing.Point(25, 100);
            this.lblmecanico.Name = "lblmecanico";
            this.lblmecanico.Size = new System.Drawing.Size(73, 17);
            this.lblmecanico.TabIndex = 3;
            this.lblmecanico.Text = "Mecanico:";
            // 
            // cboxmecanico
            // 
            this.cboxmecanico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxmecanico.FormattingEnabled = true;
            this.cboxmecanico.Location = new System.Drawing.Point(120, 97);
            this.cboxmecanico.Name = "cboxmecanico";
            this.cboxmecanico.Size = new System.Drawing.Size(280, 24);
            this.cboxmecanico.TabIndex = 4;
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(25, 135);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(86, 17);
            this.lbldescripcion.TabIndex = 5;
            this.lbldescripcion.Text = "Descripcion:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(120, 132);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(280, 60);
            this.txtdescripcion.TabIndex = 6;
            // 
            // lblmanoobra
            // 
            this.lblmanoobra.AutoSize = true;
            this.lblmanoobra.Location = new System.Drawing.Point(25, 210);
            this.lblmanoobra.Name = "lblmanoobra";
            this.lblmanoobra.Size = new System.Drawing.Size(87, 17);
            this.lblmanoobra.TabIndex = 7;
            this.lblmanoobra.Text = "Mano Obra:";
            // 
            // txtmanoobra
            // 
            this.txtmanoobra.Location = new System.Drawing.Point(120, 207);
            this.txtmanoobra.Name = "txtmanoobra";
            this.txtmanoobra.Size = new System.Drawing.Size(120, 22);
            this.txtmanoobra.TabIndex = 8;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(420, 65);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(51, 17);
            this.lblfecha.TabIndex = 9;
            this.lblfecha.Text = "Fecha:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(423, 90);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(720, 60);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(120, 32);
            this.btnregistrar.TabIndex = 11;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(720, 105);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(120, 32);
            this.btnlimpiar.TabIndex = 12;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(720, 150);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(120, 32);
            this.btnsalir.TabIndex = 13;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // dgvordenes
            // 
            this.dgvordenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvordenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvordenes.Location = new System.Drawing.Point(25, 280);
            this.dgvordenes.Name = "dgvordenes";
            this.dgvordenes.ReadOnly = true;
            this.dgvordenes.RowHeadersWidth = 51;
            this.dgvordenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvordenes.Size = new System.Drawing.Size(815, 230);
            this.dgvordenes.TabIndex = 14;
            // 
            // FrmOrdenServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 540);
            this.Controls.Add(this.dgvordenes);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.txtmanoobra);
            this.Controls.Add(this.lblmanoobra);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.cboxmecanico);
            this.Controls.Add(this.lblmecanico);
            this.Controls.Add(this.cboxvehiculo);
            this.Controls.Add(this.lblvehiculo);
            this.Controls.Add(this.lbltitulo);
            this.Name = "FrmOrdenServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo de Ordenes de Servicio - TallerTech";
            this.Load += new System.EventHandler(this.FrmOrdenServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblvehiculo;
        private System.Windows.Forms.ComboBox cboxvehiculo;
        private System.Windows.Forms.Label lblmecanico;
        private System.Windows.Forms.ComboBox cboxmecanico;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label lblmanoobra;
        private System.Windows.Forms.TextBox txtmanoobra;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DataGridView dgvordenes;
    }
}

