namespace Presentacion
{
    partial class FrmConsultaRepuestos
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
            this.btnvercriticos = new System.Windows.Forms.Button();
            this.btnvertodos = new System.Windows.Forms.Button();
            this.dgvrepuestos = new System.Windows.Forms.DataGridView();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrepuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbltitulo.Location = new System.Drawing.Point(20, 15);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(370, 32);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Consulta y Control de Repuestos";
            // 
            // btnvercriticos
            // 
            this.btnvercriticos.BackColor = System.Drawing.Color.LightCoral;
            this.btnvercriticos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvercriticos.Location = new System.Drawing.Point(25, 65);
            this.btnvercriticos.Name = "btnvercriticos";
            this.btnvercriticos.Size = new System.Drawing.Size(200, 40);
            this.btnvercriticos.TabIndex = 1;
            this.btnvercriticos.Text = "Ver Stock Critico";
            this.btnvercriticos.UseVisualStyleBackColor = false;
            this.btnvercriticos.Click += new System.EventHandler(this.btnvercriticos_Click);
            // 
            // btnvertodos
            // 
            this.btnvertodos.Location = new System.Drawing.Point(250, 65);
            this.btnvertodos.Name = "btnvertodos";
            this.btnvertodos.Size = new System.Drawing.Size(200, 40);
            this.btnvertodos.TabIndex = 2;
            this.btnvertodos.Text = "Ver Todo el Inventario";
            this.btnvertodos.UseVisualStyleBackColor = true;
            this.btnvertodos.Click += new System.EventHandler(this.btnvertodos_Click);
            // 
            // dgvrepuestos
            // 
            this.dgvrepuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvrepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrepuestos.Location = new System.Drawing.Point(25, 120);
            this.dgvrepuestos.Name = "dgvrepuestos";
            this.dgvrepuestos.ReadOnly = true;
            this.dgvrepuestos.RowHeadersWidth = 51;
            this.dgvrepuestos.Size = new System.Drawing.Size(750, 250);
            this.dgvrepuestos.TabIndex = 3;
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblmensaje.Location = new System.Drawing.Point(25, 390);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(16, 23);
            this.lblmensaje.TabIndex = 4;
            this.lblmensaje.Text = "-";
            // 
            // btnsalir
            // 
            this.btnsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsalir.Location = new System.Drawing.Point(655, 385);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(120, 32);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FrmConsultaRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.dgvrepuestos);
            this.Controls.Add(this.btnvertodos);
            this.Controls.Add(this.btnvercriticos);
            this.Controls.Add(this.lbltitulo);
            this.Name = "FrmConsultaRepuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Stock de Repuestos - TallerTech";
            this.Load += new System.EventHandler(this.FrmConsultaRepuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrepuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnvercriticos;
        private System.Windows.Forms.Button btnvertodos;
        private System.Windows.Forms.DataGridView dgvrepuestos;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btnsalir;
    }
}

