namespace Presentacion
{
    partial class FrmHistorialVehiculo
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
            this.cboxvehiculos = new System.Windows.Forms.ComboBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblresumen = new System.Windows.Forms.Label();
            this.dgvhistorial = new System.Windows.Forms.DataGridView();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(30, 20);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(211, 24);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Historial por Vehiculo";
            // 
            // lblvehiculo
            // 
            this.lblvehiculo.AutoSize = true;
            this.lblvehiculo.Location = new System.Drawing.Point(30, 70);
            this.lblvehiculo.Name = "lblvehiculo";
            this.lblvehiculo.Size = new System.Drawing.Size(111, 13);
            this.lblvehiculo.TabIndex = 1;
            this.lblvehiculo.Text = "Seleccione Vehiculo:";
            // 
            // cboxvehiculos
            // 
            this.cboxvehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxvehiculos.FormattingEnabled = true;
            this.cboxvehiculos.Location = new System.Drawing.Point(150, 67);
            this.cboxvehiculos.Name = "cboxvehiculos";
            this.cboxvehiculos.Size = new System.Drawing.Size(340, 21);
            this.cboxvehiculos.TabIndex = 2;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(510, 65);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(100, 25);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lblresumen
            // 
            this.lblresumen.AutoSize = true;
            this.lblresumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresumen.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblresumen.Location = new System.Drawing.Point(30, 105);
            this.lblresumen.Name = "lblresumen";
            this.lblresumen.Size = new System.Drawing.Size(14, 16);
            this.lblresumen.TabIndex = 4;
            this.lblresumen.Text = "-";
            // 
            // dgvhistorial
            // 
            this.dgvhistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhistorial.Location = new System.Drawing.Point(30, 135);
            this.dgvhistorial.Name = "dgvhistorial";
            this.dgvhistorial.ReadOnly = true;
            this.dgvhistorial.Size = new System.Drawing.Size(690, 235);
            this.dgvhistorial.TabIndex = 5;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(620, 385);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(100, 30);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FrmHistorialVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 435);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.dgvhistorial);
            this.Controls.Add(this.lblresumen);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.cboxvehiculos);
            this.Controls.Add(this.lblvehiculo);
            this.Controls.Add(this.lbltitulo);
            this.Name = "FrmHistorialVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Vehiculo";
            this.Load += new System.EventHandler(this.FrmHistorialVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblvehiculo;
        private System.Windows.Forms.ComboBox cboxvehiculos;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblresumen;
        private System.Windows.Forms.DataGridView dgvhistorial;
        private System.Windows.Forms.Button btnsalir;
    }
}
