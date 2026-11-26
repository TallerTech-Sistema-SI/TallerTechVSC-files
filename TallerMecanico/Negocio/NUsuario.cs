using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NUsuario
    {
        DUsuario objDatausuario = new DUsuario();

        public Usuario Validarusuario(string nombreusuario, string contrasena)
        {
            if (nombreusuario != "" && contrasena != "")
            {
                return objDatausuario.Validarusuario(nombreusuario, contrasena);
            }
            else
            {
                return null;
            }
        }

        public List<Usuario> Listarusuarios()
        {
            return objDatausuario.Listarusuarios();
        }
    }
}
