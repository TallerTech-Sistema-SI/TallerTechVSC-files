namespace Presentacion
{
    partial class FrmReporteMecanico
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
            this.lblmecanico = new System.Windows.Forms.Label();
            this.cboxmecanico = new System.Windows.Forms.ComboBox();
            this.lblinicio = new System.Windows.Forms.Label();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.lblfin = new System.Windows.Forms.Label();
            this.dtpfin = new System.Windows.Forms.DateTimePicker();
            this.lblestado = new System.Windows.Forms.Label();
            this.cboxestado = new System.Windows.Forms.ComboBox();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.dgvordenes = new System.Windows.Forms.DataGridView();
            this.lblresumen = new System.Windows.Forms.Label();
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
            this.lbltitulo.Size = new System.Drawing.Size(270, 25);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Reporte de Ordenes por Mecanico";
            // 
            // lblmecanico
            // 
            this.lblmecanico.AutoSize = true;
            this.lblmecanico.Location = new System.Drawing.Point(19, 57);
            this.lblmecanico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmecanico.Name = "lblmecanico";
            this.lblmecanico.Size = new System.Drawing.Size(52, 13);
            this.lblmecanico.TabIndex = 1;
            this.lblmecanico.Text = "Mecanico:";
            // 
            // cboxmecanico
            // 
            this.cboxmecanico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxmecanico.FormattingEnabled = true;
            this.cboxmecanico.Location = new System.Drawing.Point(90, 54);
            this.cboxmecanico.Margin = new System.Windows.Forms.Padding(2);
            this.cboxmecanico.Name = "cboxmecanico";
            this.cboxmecanico.Size = new System.Drawing.Size(180, 21);
            this.cboxmecanico.TabIndex = 2;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(295, 57);
            this.lblestado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(43, 13);
            this.lblestado.TabIndex = 3;
            this.lblestado.Text = "Estado:";
            // 
            // cboxestado
            // 
            this.cboxestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxestado.FormattingEnabled = true;
            this.cboxestado.Location = new System.Drawing.Point(345, 54);
            this.cboxestado.Margin = new System.Windows.Forms.Padding(2);
            this.cboxestado.Name = "cboxestado";
            this.cboxestado.Size = new System.Drawing.Size(130, 21);
            this.cboxestado.TabIndex = 4;
            // 
            // lblinicio
            // 
            this.lblinicio.AutoSize = true;
            this.lblinicio.Location = new System.Drawing.Point(19, 92);
            this.lblinicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinicio.Name = "lblinicio";
            this.lblinicio.Size = new System.Drawing.Size(65, 13);
            this.lblinicio.TabIndex = 5;
            this.lblinicio.Text = "Fecha inicio:";
            // 
            // dtpinicio
            // 
            this.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpinicio.Location = new System.Drawing.Point(90, 88);
            this.dtpinicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(100, 20);
            this.dtpinicio.TabIndex = 6;
            // 
            // lblfin
            // 
            this.lblfin.AutoSize = true;
            this.lblfin.Location = new System.Drawing.Point(295, 92);
            this.lblfin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfin.Name = "lblfin";
            this.lblfin.Size = new System.Drawing.Size(52, 13);
            this.lblfin.TabIndex = 7;
            this.lblfin.Text = "Fecha fin:";
            // 
            // dtpfin
            // 
            this.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfin.Location = new System.Drawing.Point(345, 88);
            this.dtpfin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpfin.Name = "dtpfin";
            this.dtpfin.Size = new System.Drawing.Size(100, 20);
            this.dtpfin.TabIndex = 8;
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Location = new System.Drawing.Point(500, 72);
            this.btnfiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(90, 26);
            this.btnfiltrar.TabIndex = 9;
            this.btnfiltrar.Text = "Filtrar";
            this.btnfiltrar.UseVisualStyleBackColor = true;
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            // 
            // dgvordenes
            // 
            this.dgvordenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvordenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvordenes.Location = new System.Drawing.Point(19, 125);
            this.dgvordenes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvordenes.Name = "dgvordenes";
            this.dgvordenes.ReadOnly = true;
            this.dgvordenes.RowHeadersWidth = 51;
            this.dgvordenes.Size = new System.Drawing.Size(571, 190);
            this.dgvordenes.TabIndex = 10;
            // 
            // lblresumen
            // 
            this.lblresumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblresumen.AutoSize = true;
            this.lblresumen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblresumen.Location = new System.Drawing.Point(19, 330);
            this.lblresumen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblresumen.Name = "lblresumen";
            this.lblresumen.Size = new System.Drawing.Size(300, 19);
            this.lblresumen.TabIndex = 11;
            this.lblresumen.Text = "Ordenes encontradas: 0";
            // 
            // btnsalir
            // 
            this.btnsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsalir.Location = new System.Drawing.Point(500, 360);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(90, 26);
            this.btnsalir.TabIndex = 12;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FrmReporteMecanico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 400);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lblresumen);
            this.Controls.Add(this.dgvordenes);
            this.Controls.Add(this.btnfiltrar);
            this.Controls.Add(this.dtpfin);
            this.Controls.Add(this.lblfin);
            this.Controls.Add(this.dtpinicio);
            this.Controls.Add(this.lblinicio);
            this.Controls.Add(this.cboxestado);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.cboxmecanico);
            this.Controls.Add(this.lblmecanico);
            this.Controls.Add(this.lbltitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmReporteMecanico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte por Mecanico - TallerTech";
            this.Load += new System.EventHandler(this.FrmReporteMecanico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblmecanico;
        private System.Windows.Forms.ComboBox cboxmecanico;
        private System.Windows.Forms.Label lblinicio;
        private System.Windows.Forms.DateTimePicker dtpinicio;
        private System.Windows.Forms.Label lblfin;
        private System.Windows.Forms.DateTimePicker dtpfin;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.ComboBox cboxestado;
        private System.Windows.Forms.Button btnfiltrar;
        private System.Windows.Forms.DataGridView dgvordenes;
        private System.Windows.Forms.Label lblresumen;
        private System.Windows.Forms.Button btnsalir;
    }
}
