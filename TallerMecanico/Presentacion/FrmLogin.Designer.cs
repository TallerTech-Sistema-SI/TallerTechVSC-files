namespace Presentacion
{
    partial class FrmLogin
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
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblcontrasena = new System.Windows.Forms.Label();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(50, 20);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(237, 21);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "TallerTech - Acceso al Sistema";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(35, 65);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(50, 15);
            this.lblusuario.TabIndex = 1;
            this.lblusuario.Text = "Usuario:";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(120, 62);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(180, 23);
            this.txtusuario.TabIndex = 2;
            // 
            // lblcontrasena
            // 
            this.lblcontrasena.AutoSize = true;
            this.lblcontrasena.Location = new System.Drawing.Point(35, 105);
            this.lblcontrasena.Name = "lblcontrasena";
            this.lblcontrasena.Size = new System.Drawing.Size(69, 15);
            this.lblcontrasena.TabIndex = 3;
            this.lblcontrasena.Text = "Contrasena:";
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(120, 102);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.PasswordChar = '*';
            this.txtcontrasena.Size = new System.Drawing.Size(180, 23);
            this.txtcontrasena.TabIndex = 4;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(80, 150);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(100, 30);
            this.btningresar.TabIndex = 5;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsalir.Location = new System.Drawing.Point(195, 150);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(100, 30);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btningresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnsalir;
            this.ClientSize = new System.Drawing.Size(340, 210);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.lblcontrasena);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.lbltitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion - TallerTech";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblcontrasena;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Button btnsalir;
    }
}
