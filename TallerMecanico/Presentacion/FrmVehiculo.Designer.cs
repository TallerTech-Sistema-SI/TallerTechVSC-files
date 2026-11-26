namespace Presentacion
{
    partial class FrmVehiculo
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
            this.lblcliente = new System.Windows.Forms.Label();
            this.cboxcliente = new System.Windows.Forms.ComboBox();
            this.lblplaca = new System.Windows.Forms.Label();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.lblmarca = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.lblmodelo = new System.Windows.Forms.Label();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.lblanio = new System.Windows.Forms.Label();
            this.txtanio = new System.Windows.Forms.TextBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.dgvvehiculos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvehiculos)).BeginInit();
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
            this.lbltitulo.Text = "Registro de Vehiculos";
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Location = new System.Drawing.Point(25, 65);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(125, 17);
            this.lblcliente.TabIndex = 1;
            this.lblcliente.Text = "Cliente Propietario:";
            // 
            // cboxcliente
            // 
            this.cboxcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxcliente.FormattingEnabled = true;
            this.cboxcliente.Location = new System.Drawing.Point(160, 62);
            this.cboxcliente.Name = "cboxcliente";
            this.cboxcliente.Size = new System.Drawing.Size(280, 24);
            this.cboxcliente.TabIndex = 2;
            // 
            // lblplaca
            // 
            this.lblplaca.AutoSize = true;
            this.lblplaca.Location = new System.Drawing.Point(25, 100);
            this.lblplaca.Name = "lblplaca";
            this.lblplaca.Size = new System.Drawing.Size(47, 17);
            this.lblplaca.TabIndex = 3;
            this.lblplaca.Text = "Placa:";
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(160, 97);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(150, 22);
            this.txtplaca.TabIndex = 4;
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(25, 135);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(51, 17);
            this.lblmarca.TabIndex = 5;
            this.lblmarca.Text = "Marca:";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(160, 132);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(200, 22);
            this.txtmarca.TabIndex = 6;
            // 
            // lblmodelo
            // 
            this.lblmodelo.AutoSize = true;
            this.lblmodelo.Location = new System.Drawing.Point(25, 170);
            this.lblmodelo.Name = "lblmodelo";
            this.lblmodelo.Size = new System.Drawing.Size(58, 17);
            this.lblmodelo.TabIndex = 7;
            this.lblmodelo.Text = "Modelo:";
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(160, 167);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(200, 22);
            this.txtmodelo.TabIndex = 8;
            // 
            // lblanio
            // 
            this.lblanio.AutoSize = true;
            this.lblanio.Location = new System.Drawing.Point(25, 205);
            this.lblanio.Name = "lblanio";
            this.lblanio.Size = new System.Drawing.Size(37, 17);
            this.lblanio.TabIndex = 9;
            this.lblanio.Text = "Ano:";
            // 
            // txtanio
            // 
            this.txtanio.Location = new System.Drawing.Point(160, 202);
            this.txtanio.Name = "txtanio";
            this.txtanio.Size = new System.Drawing.Size(100, 22);
            this.txtanio.TabIndex = 10;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(470, 50);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(120, 28);
            this.btnregistrar.TabIndex = 11;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(470, 85);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(120, 28);
            this.btnmodificar.TabIndex = 12;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(470, 120);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(120, 28);
            this.btneliminar.TabIndex = 13;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(470, 155);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(120, 28);
            this.btnlimpiar.TabIndex = 14;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(470, 190);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(120, 28);
            this.btnsalir.TabIndex = 15;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // dgvvehiculos
            // 
            this.dgvvehiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvvehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvehiculos.Location = new System.Drawing.Point(25, 245);
            this.dgvvehiculos.Name = "dgvvehiculos";
            this.dgvvehiculos.ReadOnly = true;
            this.dgvvehiculos.RowHeadersWidth = 51;
            this.dgvvehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvvehiculos.Size = new System.Drawing.Size(650, 235);
            this.dgvvehiculos.TabIndex = 16;
            this.dgvvehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvehiculos_CellClick);
            // 
            // FrmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.dgvvehiculos);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.txtanio);
            this.Controls.Add(this.lblanio);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.lblmodelo);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.lblplaca);
            this.Controls.Add(this.cboxcliente);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.lbltitulo);
            this.Name = "FrmVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo de Vehiculos - TallerTech";
            this.Load += new System.EventHandler(this.FrmVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.ComboBox cboxcliente;
        private System.Windows.Forms.Label lblplaca;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label lblmodelo;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.Label lblanio;
        private System.Windows.Forms.TextBox txtanio;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DataGridView dgvvehiculos;
    }
}

