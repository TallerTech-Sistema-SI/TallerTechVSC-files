using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCliente
    {
        public string Registrarcliente(Cliente objcliente)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                objcliente.CreatedAt = DateTime.Now;
                contexto.Cliente.Add(objcliente);
                contexto.SaveChanges();
                return "Se registro exitosamente el cliente";
            }
        }

        public List<Cliente> Listarclientes()
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                return contexto.Cliente.ToList();
            }
        }

        public string Modificarcliente(Cliente objcliente)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                var modificado = contexto.Cliente.Find(objcliente.ID_Cliente);
                modificado.DNI_RUC = objcliente.DNI_RUC;
                modificado.Nombre = objcliente.Nombre;
                modificado.Telefono = objcliente.Telefono;
                modificado.Direccion = objcliente.Direccion;
                modificado.ModifiedBy = objcliente.ModifiedBy;
                modificado.ModifiedAt = objcliente.ModifiedAt;
                contexto.SaveChanges();
                return "Se modifico exitosamente el cliente";
            }
        }

        public string Eliminarcliente(int id)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                contexto.Cliente.Remove(contexto.Cliente.Find(id));
                contexto.SaveChanges();
                return "Se elimino exitosamente el cliente";
            }
        }

        public Cliente Buscarcliente(int id)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                return contexto.Cliente.Find(id);
            }
        }

        public bool Existedniruc(string dniruc)
        {
            List<Cliente> lista = Listarclientes();
            foreach (Cliente item in lista)
            {
                if (item.DNI_RUC == dniruc)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Existecliente(int id)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                var encontrado = contexto.Cliente.Find(id);
                if (encontrado != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
