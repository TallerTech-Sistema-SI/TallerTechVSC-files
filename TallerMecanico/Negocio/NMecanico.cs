using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NMecanico
    {
        DMecanico objDatamecanico = new DMecanico();

        public string Registrarmecanico(Mecanico objmecanico)
        {
            return objDatamecanico.Registrarmecanico(objmecanico);
        }

        public List<Mecanico> Listarmecanicos()
        {
            return objDatamecanico.Listarmecanicos();
        }

        public string Modificarmecanico(Mecanico objmecanico)
        {
            return objDatamecanico.Modificarmecanico(objmecanico);
        }

        public string Eliminarmecanico(int id)
        {
            return objDatamecanico.Eliminarmecanico(id);
        }

        public Mecanico Buscarmecanico(int id)
        {
            return objDatamecanico.Buscarmecanico(id);
        }

        public bool Existemecanico(int id)
        {
            return objDatamecanico.Existemecanico(id);
        }
    }
}
