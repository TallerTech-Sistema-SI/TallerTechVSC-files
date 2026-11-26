namespace Presentacion
{
    partial class FrmGestionOrden
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
            this.lblorden = new System.Windows.Forms.Label();
            this.cboxordenes = new System.Windows.Forms.ComboBox();
            this.lblestadoactual = new System.Windows.Forms.Label();
            this.lblnuevoestado = new System.Windows.Forms.Label();
            this.cboxnuevoestado = new System.Windows.Forms.ComboBox();
            this.btncambiarestado = new System.Windows.Forms.Button();
            this.lblrepuesto = new System.Windows.Forms.Label();
            this.cboxrepuesto = new System.Windows.Forms.ComboBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.btnagregarrepuesto = new System.Windows.Forms.Button();
            this.dgvdetalles = new System.Windows.Forms.DataGridView();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbltitulo.Location = new System.Drawing.Point(15, 12);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(186, 25);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Gestion de Ordenes";
            // 
            // lblorden
            // 
            this.lblorden.AutoSize = true;
            this.lblorden.Location = new System.Drawing.Point(19, 53);
            this.lblorden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblorden.Name = "lblorden";
            this.lblorden.Size = new System.Drawing.Size(98, 13);
            this.lblorden.TabIndex = 1;
            this.lblorden.Text = "Seleccionar Orden:";
            // 
            // cboxordenes
            // 
            this.cboxordenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxordenes.FormattingEnabled = true;
            this.cboxordenes.Location = new System.Drawing.Point(120, 50);
            this.cboxordenes.Margin = new System.Windows.Forms.Padding(2);
            this.cboxordenes.Name = "cboxordenes";
            this.cboxordenes.Size = new System.Drawing.Size(301, 21);
            this.cboxordenes.TabIndex = 2;
            this.cboxordenes.SelectedIndexChanged += new System.EventHandler(this.cboxordenes_SelectedIndexChanged);
            // 
            // lblestadoactual
            // 
            this.lblestadoactual.AutoSize = true;
            this.lblestadoactual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestadoactual.Location = new System.Drawing.Point(435, 53);
            this.lblestadoactual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblestadoactual.Name = "lblestadoactual";
            this.lblestadoactual.Size = new System.Drawing.Size(97, 13);
            this.lblestadoactual.TabIndex = 3;
            this.lblestadoactual.Text = "Estado actual: -";
            // 
            // lblnuevoestado
            // 
            this.lblnuevoestado.AutoSize = true;
            this.lblnuevoestado.Location = new System.Drawing.Point(19, 89);
            this.lblnuevoestado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnuevoestado.Name = "lblnuevoestado";
            this.lblnuevoestado.Size = new System.Drawing.Size(78, 13);
            this.lblnuevoestado.TabIndex = 4;
            this.lblnuevoestado.Text = "Nuevo Estado:";
            // 
            // cboxnuevoestado
            // 
            this.cboxnuevoestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxnuevoestado.FormattingEnabled = true;
            this.cboxnuevoestado.Location = new System.Drawing.Point(120, 87);
            this.cboxnuevoestado.Margin = new System.Windows.Forms.Padding(2);
            this.cboxnuevoestado.Name = "cboxnuevoestado";
            this.cboxnuevoestado.Size = new System.Drawing.Size(151, 21);
            this.cboxnuevoestado.TabIndex = 5;
            // 
            // btncambiarestado
            // 
            this.btncambiarestado.Location = new System.Drawing.Point(285, 85);
            this.btncambiarestado.Margin = new System.Windows.Forms.Padding(2);
            this.btncambiarestado.Name = "btncambiarestado";
            this.btncambiarestado.Size = new System.Drawing.Size(112, 26);
            this.btncambiarestado.TabIndex = 6;
            this.btncambiarestado.Text = "Actualizar Estado";
            this.btncambiarestado.UseVisualStyleBackColor = true;
            this.btncambiarestado.Click += new System.EventHandler(this.btncambiarestado_Click);
            // 
            // lblrepuesto
            // 
            this.lblrepuesto.AutoSize = true;
            this.lblrepuesto.Location = new System.Drawing.Point(19, 130);
            this.lblrepuesto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblrepuesto.Name = "lblrepuesto";
            this.lblrepuesto.Size = new System.Drawing.Size(96, 13);
            this.lblrepuesto.TabIndex = 7;
            this.lblrepuesto.Text = "Agregar Repuesto:";
            // 
            // cboxrepuesto
            // 
            this.cboxrepuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxrepuesto.FormattingEnabled = true;
            this.cboxrepuesto.Location = new System.Drawing.Point(120, 128);
            this.cboxrepuesto.Margin = new System.Windows.Forms.Padding(2);
            this.cboxrepuesto.Name = "cboxrepuesto";
            this.cboxrepuesto.Size = new System.Drawing.Size(226, 21);
            this.cboxrepuesto.TabIndex = 8;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(352, 130);
            this.lblcantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(52, 13);
            this.lblcantidad.TabIndex = 9;
            this.lblcantidad.Text = "Cantidad:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(412, 128);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(61, 20);
            this.txtcantidad.TabIndex = 10;
            // 
            // btnagregarrepuesto
            // 
            this.btnagregarrepuesto.Location = new System.Drawing.Point(488, 126);
            this.btnagregarrepuesto.Margin = new System.Windows.Forms.Padding(2);
            this.btnagregarrepuesto.Name = "btnagregarrepuesto";
            this.btnagregarrepuesto.Size = new System.Drawing.Size(90, 26);
            this.btnagregarrepuesto.TabIndex = 11;
            this.btnagregarrepuesto.Text = "Agregar";
            this.btnagregarrepuesto.UseVisualStyleBackColor = true;
            this.btnagregarrepuesto.Click += new System.EventHandler(this.btnagregarrepuesto_Click);
            // 
            // dgvdetalles
            // 
            this.dgvdetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalles.Location = new System.Drawing.Point(19, 171);
            this.dgvdetalles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvdetalles.Name = "dgvdetalles";
            this.dgvdetalles.ReadOnly = true;
            this.dgvdetalles.RowHeadersWidth = 51;
            this.dgvdetalles.Size = new System.Drawing.Size(562, 162);
            this.dgvdetalles.TabIndex = 12;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbltotal.Location = new System.Drawing.Point(19, 349);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(185, 21);
            this.lbltotal.TabIndex = 13;
            this.lbltotal.Text = "Total de Orden: S/. 0.00";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(488, 349);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(90, 26);
            this.btnsalir.TabIndex = 14;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FrmGestionOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 390);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.dgvdetalles);
            this.Controls.Add(this.btnagregarrepuesto);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.cboxrepuesto);
            this.Controls.Add(this.lblrepuesto);
            this.Controls.Add(this.btncambiarestado);
            this.Controls.Add(this.cboxnuevoestado);
            this.Controls.Add(this.lblnuevoestado);
            this.Controls.Add(this.lblestadoactual);
            this.Controls.Add(this.cboxordenes);
            this.Controls.Add(this.lblorden);
            this.Controls.Add(this.lbltitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmGestionOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Ordenes y Repuestos - TallerTech";
            this.Load += new System.EventHandler(this.FrmGestionOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblorden;
        private System.Windows.Forms.ComboBox cboxordenes;
        private System.Windows.Forms.Label lblestadoactual;
        private System.Windows.Forms.Label lblnuevoestado;
        private System.Windows.Forms.ComboBox cboxnuevoestado;
        private System.Windows.Forms.Button btncambiarestado;
        private System.Windows.Forms.Label lblrepuesto;
        private System.Windows.Forms.ComboBox cboxrepuesto;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button btnagregarrepuesto;
        private System.Windows.Forms.DataGridView dgvdetalles;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btnsalir;
    }
}

