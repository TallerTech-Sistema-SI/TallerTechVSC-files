using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DUsuario
    {
        public List<Usuario> Listarusuarios()
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                return contexto.Usuario.ToList();
            }
        }

        public Usuario Validarusuario(string nombreusuario, string contrasena)
        {
            List<Usuario> lista = Listarusuarios();
            foreach (Usuario item in lista)
            {
                if (item.NombreUsuario == nombreusuario && item.Contrasena == contrasena)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
