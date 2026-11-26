using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NCliente
    {
        DCliente objDatacliente = new DCliente();

        public string Registrarcliente(Cliente objcliente)
        {
            if (objDatacliente.Existedniruc(objcliente.DNI_RUC))
            {
                return "El DNI/RUC ya se encuentra registrado";
            }
            else
            {
                return objDatacliente.Registrarcliente(objcliente);
            }
        }

        public List<Cliente> Listarclientes()
        {
            return objDatacliente.Listarclientes();
        }

        public string Modificarcliente(Cliente objcliente)
        {
            return objDatacliente.Modificarcliente(objcliente);
        }

        public string Eliminarcliente(int id)
        {
            return objDatacliente.Eliminarcliente(id);
        }

        public Cliente Buscarcliente(int id)
        {
            return objDatacliente.Buscarcliente(id);
        }

        public bool Existedniruc(string dniruc)
        {
            return objDatacliente.Existedniruc(dniruc);
        }

        public bool Existecliente(int id)
        {
            return objDatacliente.Existecliente(id);
        }
    }
}
