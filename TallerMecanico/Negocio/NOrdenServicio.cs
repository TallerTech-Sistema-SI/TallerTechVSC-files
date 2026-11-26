using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NOrdenServicio
    {
        DOrdenServicio objDataorden = new DOrdenServicio();

        public string Registrarorden(OrdenServicio objorden)
        {
            objorden.Estado = "Pendiente";
            objorden.Total = objorden.ManoObra;
            return objDataorden.Registrarorden(objorden);
        }

        public List<OrdenServicio> Listarordenes()
        {
            return objDataorden.Listarordenes();
        }

        public List<OrdenServicio> Listarordenesporestado(string estado)
        {
            if (estado == "Todos" || estado == "TODOS" || estado == "todos")
            {
                return objDataorden.Listarordenesporestado("TODOS");
            }
            else
            {
                return objDataorden.Listarordenesporestado(estado);
            }
        }

        public List<OrdenServicio> Listarhistorialvehiculo(int idvehiculo)
        {
            List<OrdenServicio> lista = objDataorden.Listarordenes();
            List<OrdenServicio> resultado = new List<OrdenServicio>();
            foreach (OrdenServicio item in lista)
            {
                if (item.ID_Vehiculo == idvehiculo)
                {
                    resultado.Add(item);
                }
            }
            return resultado;
        }

        public OrdenServicio Buscarorden(int id)
        {
            return objDataorden.Buscarorden(id);
        }

        public string Cambiarestadoorden(int idorden, string nuevoestado, string usuario)
        {
            return objDataorden.Cambiarestadoorden(idorden, nuevoestado, usuario);
        }

        public decimal Calcularingresostotales()
        {
            return objDataorden.Calcularingresostotales();
        }

        public List<OrdenServicio> Listarordenesconcluidas(string estado, DateTime fechainicio, DateTime fechafin)
        {
            return objDataorden.Listarordenesconcluidas(estado, fechainicio, fechafin);
        }

        public string Modificarorden(OrdenServicio objorden)
        {
            return objDataorden.Modificarorden(objorden);
        }

        public string Eliminarorden(int id)
        {
            return objDataorden.Eliminarorden(id);
        }

        public bool Existeorden(int id)
        {
            return objDataorden.Existeorden(id);
        }
    }
}
