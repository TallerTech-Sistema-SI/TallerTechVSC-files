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

        public List<Cliente> Buscarclientes(string texto)
        {
            List<Cliente> lista = objDatacliente.Listarclientes();
            List<Cliente> resultado = new List<Cliente>();
            string buscar = texto.Trim().ToLower();
            foreach (Cliente item in lista)
            {
                bool coincide = false;
                if (item.DNI_RUC != null && item.DNI_RUC.ToLower().Contains(buscar))
                {
                    coincide = true;
                }
                if (item.Nombre != null && item.Nombre.ToLower().Contains(buscar))
                {
                    coincide = true;
                }
                if (coincide)
                {
                    resultado.Add(item);
                }
            }
            return resultado;
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
