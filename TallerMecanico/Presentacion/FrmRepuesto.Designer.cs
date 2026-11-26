namespace Presentacion
{
    partial class FrmRepuesto
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
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblmarca = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.lblstock = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.lblstockminimo = new System.Windows.Forms.Label();
            this.txtstockminimo = new System.Windows.Forms.TextBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.dgvrepuestos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrepuestos)).BeginInit();
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
            this.lbltitulo.Text = "Registro de Repuestos";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(25, 65);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(56, 17);
            this.lblcodigo.TabIndex = 1;
            this.lblcodigo.Text = "Codigo:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(120, 62);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(120, 22);
            this.txtcodigo.TabIndex = 2;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(25, 100);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(62, 17);
            this.lblnombre.TabIndex = 3;
            this.lblnombre.Text = "Nombre:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(120, 97);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(280, 22);
            this.txtnombre.TabIndex = 4;
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
            this.txtmarca.Location = new System.Drawing.Point(120, 132);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(200, 22);
            this.txtmarca.TabIndex = 6;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(25, 170);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(52, 17);
            this.lblprecio.TabIndex = 7;
            this.lblprecio.Text = "Precio:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(120, 167);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 22);
            this.txtprecio.TabIndex = 8;
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.Location = new System.Drawing.Point(25, 205);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(47, 17);
            this.lblstock.TabIndex = 9;
            this.lblstock.Text = "Stock:";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(120, 202);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(100, 22);
            this.txtstock.TabIndex = 10;
            // 
            // lblstockminimo
            // 
            this.lblstockminimo.AutoSize = true;
            this.lblstockminimo.Location = new System.Drawing.Point(235, 205);
            this.lblstockminimo.Name = "lblstockminimo";
            this.lblstockminimo.Size = new System.Drawing.Size(95, 17);
            this.lblstockminimo.TabIndex = 11;
            this.lblstockminimo.Text = "Stock Minimo:";
            // 
            // txtstockminimo
            // 
            this.txtstockminimo.Location = new System.Drawing.Point(340, 202);
            this.txtstockminimo.Name = "txtstockminimo";
            this.txtstockminimo.Size = new System.Drawing.Size(100, 22);
            this.txtstockminimo.TabIndex = 12;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(520, 50);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(120, 28);
            this.btnregistrar.TabIndex = 13;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(520, 85);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(120, 28);
            this.btnmodificar.TabIndex = 14;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(520, 120);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(120, 28);
            this.btneliminar.TabIndex = 15;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(520, 155);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(120, 28);
            this.btnlimpiar.TabIndex = 16;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(520, 190);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(120, 28);
            this.btnsalir.TabIndex = 17;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // dgvrepuestos
            // 
            this.dgvrepuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvrepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrepuestos.Location = new System.Drawing.Point(25, 245);
            this.dgvrepuestos.Name = "dgvrepuestos";
            this.dgvrepuestos.ReadOnly = true;
            this.dgvrepuestos.RowHeadersWidth = 51;
            this.dgvrepuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrepuestos.Size = new System.Drawing.Size(700, 235);
            this.dgvrepuestos.TabIndex = 18;
            this.dgvrepuestos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrepuestos_CellClick);
            // 
            // FrmRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.dgvrepuestos);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.txtstockminimo);
            this.Controls.Add(this.lblstockminimo);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.lblstock);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.lbltitulo);
            this.Name = "FrmRepuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo de Repuestos e Inventario - TallerTech";
            this.Load += new System.EventHandler(this.FrmRepuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrepuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label lblstock;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label lblstockminimo;
        private System.Windows.Forms.TextBox txtstockminimo;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DataGridView dgvrepuestos;
    }
}

