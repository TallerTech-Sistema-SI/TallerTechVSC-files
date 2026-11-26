using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos;

namespace Presentacion
{
    public partial class FrmLogin : Form
    {
        NUsuario objNegusuario = new NUsuario();

        public FrmLogin()
        {
            InitializeComponent();
            Tema.Aplicar(this);
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "" || txtcontrasena.Text == "")
            {
                MessageBox.Show("Ingrese usuario y contrasena", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario encontrado = objNegusuario.Validarusuario(txtusuario.Text, txtcontrasena.Text);

            if (encontrado == null)
            {
                MessageBox.Show("Usuario o contrasena incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcontrasena.Text = "";
                txtusuario.Focus();
                return;
            }

            Form1 frm = new Form1();
            frm.rolusuario = encontrado.Rol;
            frm.nombreusuario = encontrado.NombreUsuario;
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
