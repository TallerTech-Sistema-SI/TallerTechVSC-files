namespace Presentacion
{
    partial class FrmConsultaOrdenes
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
            this.lblfiltro = new System.Windows.Forms.Label();
            this.cboxfiltroestado = new System.Windows.Forms.ComboBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.chkfechas = new System.Windows.Forms.CheckBox();
            this.lbldesde = new System.Windows.Forms.Label();
            this.dtpdesde = new System.Windows.Forms.DateTimePicker();
            this.lblhasta = new System.Windows.Forms.Label();
            this.dtphasta = new System.Windows.Forms.DateTimePicker();
            this.dgvordenes = new System.Windows.Forms.DataGridView();
            this.lbltotalordenes = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbltitulo.Location = new System.Drawing.Point(15, 12);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(196, 25);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Consulta de Ordenes";
            // 
            // lblfiltro
            // 
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.Location = new System.Drawing.Point(19, 57);
            this.lblfiltro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(89, 13);
            this.lblfiltro.TabIndex = 1;
            this.lblfiltro.Text = "Filtrar por Estado:";
            this.lblfiltro.Click += new System.EventHandler(this.lblfiltro_Click);
            // 
            // cboxfiltroestado
            // 
            this.cboxfiltroestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxfiltroestado.FormattingEnabled = true;
            this.cboxfiltroestado.Location = new System.Drawing.Point(120, 54);
            this.cboxfiltroestado.Margin = new System.Windows.Forms.Padding(2);
            this.cboxfiltroestado.Name = "cboxfiltroestado";
            this.cboxfiltroestado.Size = new System.Drawing.Size(151, 21);
            this.cboxfiltroestado.TabIndex = 2;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(285, 50);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(90, 26);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // chkfechas
            // 
            this.chkfechas.AutoSize = true;
            this.chkfechas.Location = new System.Drawing.Point(19, 88);
            this.chkfechas.Margin = new System.Windows.Forms.Padding(2);
            this.chkfechas.Name = "chkfechas";
            this.chkfechas.Size = new System.Drawing.Size(106, 17);
            this.chkfechas.TabIndex = 7;
            this.chkfechas.Text = "Filtrar por fechas";
            this.chkfechas.UseVisualStyleBackColor = true;
            this.chkfechas.CheckedChanged += new System.EventHandler(this.chkfechas_CheckedChanged);
            // 
            // lbldesde
            // 
            this.lbldesde.AutoSize = true;
            this.lbldesde.Location = new System.Drawing.Point(150, 90);
            this.lbldesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldesde.Name = "lbldesde";
            this.lbldesde.Size = new System.Drawing.Size(38, 13);
            this.lbldesde.TabIndex = 8;
            this.lbldesde.Text = "Desde:";
            // 
            // dtpdesde
            // 
            this.dtpdesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdesde.Location = new System.Drawing.Point(195, 86);
            this.dtpdesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtpdesde.Name = "dtpdesde";
            this.dtpdesde.Size = new System.Drawing.Size(95, 20);
            this.dtpdesde.TabIndex = 9;
            // 
            // lblhasta
            // 
            this.lblhasta.AutoSize = true;
            this.lblhasta.Location = new System.Drawing.Point(305, 90);
            this.lblhasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhasta.Name = "lblhasta";
            this.lblhasta.Size = new System.Drawing.Size(35, 13);
            this.lblhasta.TabIndex = 10;
            this.lblhasta.Text = "Hasta:";
            // 
            // dtphasta
            // 
            this.dtphasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtphasta.Location = new System.Drawing.Point(345, 86);
            this.dtphasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtphasta.Name = "dtphasta";
            this.dtphasta.Size = new System.Drawing.Size(95, 20);
            this.dtphasta.TabIndex = 11;
            // 
            // dgvordenes
            // 
            this.dgvordenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvordenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvordenes.Location = new System.Drawing.Point(19, 120);
            this.dgvordenes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvordenes.Name = "dgvordenes";
            this.dgvordenes.ReadOnly = true;
            this.dgvordenes.RowHeadersWidth = 51;
            this.dgvordenes.Size = new System.Drawing.Size(525, 181);
            this.dgvordenes.TabIndex = 4;
            this.dgvordenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvordenes_CellContentClick);
            // 
            // lbltotalordenes
            // 
            this.lbltotalordenes.AutoSize = true;
            this.lbltotalordenes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbltotalordenes.Location = new System.Drawing.Point(19, 317);
            this.lbltotalordenes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltotalordenes.Name = "lbltotalordenes";
            this.lbltotalordenes.Size = new System.Drawing.Size(252, 19);
            this.lbltotalordenes.TabIndex = 5;
            this.lbltotalordenes.Text = "Cantidad de Ordenes encontradas: 0";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(450, 313);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(90, 26);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FrmConsultaOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 358);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lbltotalordenes);
            this.Controls.Add(this.dgvordenes);
            this.Controls.Add(this.dtphasta);
            this.Controls.Add(this.lblhasta);
            this.Controls.Add(this.dtpdesde);
            this.Controls.Add(this.lbldesde);
            this.Controls.Add(this.chkfechas);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.cboxfiltroestado);
            this.Controls.Add(this.lblfiltro);
            this.Controls.Add(this.lbltitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmConsultaOrdenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Ordenes - TallerTech";
            this.Load += new System.EventHandler(this.FrmConsultaOrdenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblfiltro;
        private System.Windows.Forms.ComboBox cboxfiltroestado;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView dgvordenes;
        private System.Windows.Forms.CheckBox chkfechas;
        private System.Windows.Forms.Label lbldesde;
        private System.Windows.Forms.DateTimePicker dtpdesde;
        private System.Windows.Forms.Label lblhasta;
        private System.Windows.Forms.DateTimePicker dtphasta;
        private System.Windows.Forms.Label lbltotalordenes;
        private System.Windows.Forms.Button btnsalir;
    }
}

