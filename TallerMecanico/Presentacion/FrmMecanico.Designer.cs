namespace Presentacion
{
    partial class FrmMecanico
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblespecialidad = new System.Windows.Forms.Label();
            this.cboxespecialidad = new System.Windows.Forms.ComboBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.dgvmecanicos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmecanicos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbltitulo.Location = new System.Drawing.Point(20, 15);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(271, 32);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Registro de Mecanicos";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(25, 65);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(62, 17);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(120, 62);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(320, 22);
            this.txtnombre.TabIndex = 2;
            // 
            // lblespecialidad
            // 
            this.lblespecialidad.AutoSize = true;
            this.lblespecialidad.Location = new System.Drawing.Point(25, 100);
            this.lblespecialidad.Name = "lblespecialidad";
            this.lblespecialidad.Size = new System.Drawing.Size(92, 17);
            this.lblespecialidad.TabIndex = 3;
            this.lblespecialidad.Text = "Especialidad:";
            // 
            // cboxespecialidad
            // 
            this.cboxespecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxespecialidad.FormattingEnabled = true;
            this.cboxespecialidad.Location = new System.Drawing.Point(120, 97);
            this.cboxespecialidad.Name = "cboxespecialidad";
            this.cboxespecialidad.Size = new System.Drawing.Size(200, 24);
            this.cboxespecialidad.TabIndex = 4;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(25, 135);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(68, 17);
            this.lbltelefono.TabIndex = 5;
            this.lbltelefono.Text = "Telefono:";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(120, 132);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(200, 22);
            this.txttelefono.TabIndex = 6;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(470, 50);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(120, 28);
            this.btnregistrar.TabIndex = 7;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(470, 85);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(120, 28);
            this.btnmodificar.TabIndex = 8;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(470, 120);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(120, 28);
            this.btneliminar.TabIndex = 9;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(470, 155);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(120, 28);
            this.btnlimpiar.TabIndex = 10;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(470, 190);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(120, 28);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // dgvmecanicos
            // 
            this.dgvmecanicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvmecanicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmecanicos.Location = new System.Drawing.Point(25, 180);
            this.dgvmecanicos.Name = "dgvmecanicos";
            this.dgvmecanicos.ReadOnly = true;
            this.dgvmecanicos.RowHeadersWidth = 51;
            this.dgvmecanicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmecanicos.Size = new System.Drawing.Size(650, 250);
            this.dgvmecanicos.TabIndex = 12;
            this.dgvmecanicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmecanicos_CellClick);
            // 
            // FrmMecanico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.dgvmecanicos);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.cboxespecialidad);
            this.Controls.Add(this.lblespecialidad);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lbltitulo);
            this.Name = "FrmMecanico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo de Mecanicos - TallerTech";
            this.Load += new System.EventHandler(this.FrmMecanico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmecanicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblespecialidad;
        private System.Windows.Forms.ComboBox cboxespecialidad;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DataGridView dgvmecanicos;
    }
}

