using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public static class Tema
    {
        public static Color Azul = Color.FromArgb(0, 90, 156);
        public static Color AzulClaro = Color.FromArgb(59, 130, 246);
        public static Color Verde = Color.FromArgb(40, 167, 69);
        public static Color Rojo = Color.FromArgb(220, 53, 69);
        public static Color Gris = Color.FromArgb(108, 117, 125);
        public static Color Fondo = Color.FromArgb(244, 246, 249);
        public static Color Blanco = Color.White;
        public static Color Texto = Color.FromArgb(51, 51, 51);

        public static void Aplicar(Control raiz)
        {
            if (raiz is Form)
            {
                raiz.BackColor = Blanco;
            }
            foreach (Control c in raiz.Controls)
            {
                if (c is Button)
                {
                    Estilarboton((Button)c);
                }
                else
                {
                    if (c is DataGridView)
                    {
                        Estilargrilla((DataGridView)c);
                    }
                    else
                    {
                        if (c is Label && c.Name == "lbltitulo" && c.Parent is Form)
                        {
                            c.ForeColor = Azul;
                        }
                    }
                }
                if (c.HasChildren)
                {
                    Aplicar(c);
                }
            }
        }

        public static void Estilarboton(Button btn)
        {
            string nombre = btn.Name.ToLower();
            Color fondo = Azul;
            if (nombre.Contains("eliminar") || nombre.Contains("critico"))
            {
                fondo = Rojo;
            }
            if (nombre.Contains("salir") || nombre.Contains("limpiar"))
            {
                fondo = Gris;
            }
            if (nombre.Contains("ingresar"))
            {
                fondo = Verde;
            }
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.UseVisualStyleBackColor = false;
            btn.BackColor = fondo;
            btn.ForeColor = Blanco;
            btn.Cursor = Cursors.Hand;
        }

        public static void Estilargrilla(DataGridView dgv)
        {
            dgv.BackgroundColor = Blanco;
            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersVisible = false;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(222, 226, 230);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(73, 80, 87);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 249, 250);
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(73, 80, 87);
            dgv.ColumnHeadersHeight = 32;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(73, 80, 87);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 224, 241);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            dgv.RowTemplate.Height = 26;
        }
    }
}
