namespace Presentacion
{
    partial class FrmResumenIngresos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblinicio = new System.Windows.Forms.Label();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.lblfin = new System.Windows.Forms.Label();
            this.dtpfin = new System.Windows.Forms.DateTimePicker();
            this.lblestado = new System.Windows.Forms.Label();
            this.cboxestado = new System.Windows.Forms.ComboBox();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.lblingresos = new System.Windows.Forms.Label();
            this.dgvconcluidas = new System.Windows.Forms.DataGridView();
            this.chartbarras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartingresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconcluidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartbarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartingresos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbltitulo.Location = new System.Drawing.Point(20, 15);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(252, 32);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Resumen de Ingresos";
            // 
            // lblinicio
            // 
            this.lblinicio.AutoSize = true;
            this.lblinicio.Location = new System.Drawing.Point(25, 65);
            this.lblinicio.Name = "lblinicio";
            this.lblinicio.Size = new System.Drawing.Size(50, 17);
            this.lblinicio.TabIndex = 1;
            this.lblinicio.Text = "Desde:";
            // 
            // dtpinicio
            // 
            this.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpinicio.Location = new System.Drawing.Point(75, 62);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(115, 22);
            this.dtpinicio.TabIndex = 2;
            // 
            // lblfin
            // 
            this.lblfin.AutoSize = true;
            this.lblfin.Location = new System.Drawing.Point(205, 65);
            this.lblfin.Name = "lblfin";
            this.lblfin.Size = new System.Drawing.Size(47, 17);
            this.lblfin.TabIndex = 3;
            this.lblfin.Text = "Hasta:";
            // 
            // dtpfin
            // 
            this.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfin.Location = new System.Drawing.Point(255, 62);
            this.dtpfin.Name = "dtpfin";
            this.dtpfin.Size = new System.Drawing.Size(115, 22);
            this.dtpfin.TabIndex = 4;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(385, 65);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(54, 17);
            this.lblestado.TabIndex = 5;
            this.lblestado.Text = "Estado:";
            // 
            // cboxestado
            // 
            this.cboxestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxestado.FormattingEnabled = true;
            this.cboxestado.Location = new System.Drawing.Point(442, 62);
            this.cboxestado.Name = "cboxestado";
            this.cboxestado.Size = new System.Drawing.Size(145, 24);
            this.cboxestado.TabIndex = 6;
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Location = new System.Drawing.Point(605, 60);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(190, 28);
            this.btnfiltrar.TabIndex = 7;
            this.btnfiltrar.Text = "Filtrar";
            this.btnfiltrar.UseVisualStyleBackColor = true;
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            // 
            // lblingresos
            // 
            this.lblingresos.AutoSize = true;
            this.lblingresos.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblingresos.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblingresos.Location = new System.Drawing.Point(25, 102);
            this.lblingresos.Name = "lblingresos";
            this.lblingresos.Size = new System.Drawing.Size(240, 25);
            this.lblingresos.TabIndex = 8;
            this.lblingresos.Text = "Ingresos Totales: S/. 0.00";
            // 
            // dgvconcluidas
            // 
            this.dgvconcluidas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvconcluidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconcluidas.Location = new System.Drawing.Point(25, 138);
            this.dgvconcluidas.Name = "dgvconcluidas";
            this.dgvconcluidas.ReadOnly = true;
            this.dgvconcluidas.RowHeadersWidth = 51;
            this.dgvconcluidas.Size = new System.Drawing.Size(770, 190);
            this.dgvconcluidas.TabIndex = 9;
            // 
            // chartbarras
            // 
            this.chartbarras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            chartArea2.Name = "AreaBarras";
            this.chartbarras.ChartAreas.Add(chartArea2);
            this.chartbarras.Location = new System.Drawing.Point(25, 342);
            this.chartbarras.Name = "chartbarras";
            series2.ChartArea = "AreaBarras";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series2.IsValueShownAsLabel = true;
            series2.Name = "FacturadoMes";
            this.chartbarras.Series.Add(series2);
            this.chartbarras.Size = new System.Drawing.Size(375, 235);
            this.chartbarras.TabIndex = 12;
            this.chartbarras.Text = "chartbarras";
            // 
            // chartingresos
            // 
            this.chartingresos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "AreaGrafico";
            this.chartingresos.ChartAreas.Add(chartArea1);
            this.chartingresos.Location = new System.Drawing.Point(420, 342);
            this.chartingresos.Name = "chartingresos";
            series1.ChartArea = "AreaGrafico";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Name = "Ingresos";
            this.chartingresos.Series.Add(series1);
            this.chartingresos.Size = new System.Drawing.Size(375, 235);
            this.chartingresos.TabIndex = 10;
            this.chartingresos.Text = "chartingresos";
            // 
            // btnsalir
            // 
            this.btnsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsalir.Location = new System.Drawing.Point(675, 595);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(120, 32);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FrmResumenIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 645);
            this.Controls.Add(this.chartbarras);
            this.Controls.Add(this.chartingresos);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.dgvconcluidas);
            this.Controls.Add(this.lblingresos);
            this.Controls.Add(this.btnfiltrar);
            this.Controls.Add(this.cboxestado);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.dtpfin);
            this.Controls.Add(this.lblfin);
            this.Controls.Add(this.dtpinicio);
            this.Controls.Add(this.lblinicio);
            this.Controls.Add(this.lbltitulo);
            this.Name = "FrmResumenIngresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumen de Ingresos - TallerTech";
            this.Load += new System.EventHandler(this.FrmResumenIngresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvconcluidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartbarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartingresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblinicio;
        private System.Windows.Forms.DateTimePicker dtpinicio;
        private System.Windows.Forms.Label lblfin;
        private System.Windows.Forms.DateTimePicker dtpfin;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.ComboBox cboxestado;
        private System.Windows.Forms.Button btnfiltrar;
        private System.Windows.Forms.Label lblingresos;
        private System.Windows.Forms.DataGridView dgvconcluidas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartbarras;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartingresos;
        private System.Windows.Forms.Button btnsalir;
    }
}
