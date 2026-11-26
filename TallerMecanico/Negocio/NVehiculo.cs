using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NVehiculo
    {
        DVehiculo objDatavehiculo = new DVehiculo();

        public string Registrarvehiculo(Vehiculo objvehiculo)
        {
            if (objDatavehiculo.Existeplaca(objvehiculo.Placa))
            {
                return "La placa ya se encuentra registrada";
            }
            else
            {
                return objDatavehiculo.Registrarvehiculo(objvehiculo);
            }
        }

        public List<Vehiculo> Listarvehiculos()
        {
            return objDatavehiculo.Listarvehiculos();
        }

        public List<Vehiculo> Buscarvehiculosporplaca(string placa)
        {
            List<Vehiculo> lista = objDatavehiculo.Listarvehiculos();
            List<Vehiculo> resultado = new List<Vehiculo>();
            string buscar = placa.Trim().ToLower();
            foreach (Vehiculo item in lista)
            {
                if (item.Placa != null && item.Placa.ToLower().Contains(buscar))
                {
                    resultado.Add(item);
                }
            }
            return resultado;
        }

        public string Modificarvehiculo(Vehiculo objvehiculo)
        {
            return objDatavehiculo.Modificarvehiculo(objvehiculo);
        }

        public string Eliminarvehiculo(int id)
        {
            return objDatavehiculo.Eliminarvehiculo(id);
        }

        public Vehiculo Buscarvehiculo(int id)
        {
            return objDatavehiculo.Buscarvehiculo(id);
        }

        public bool Existeplaca(string placa)
        {
            return objDatavehiculo.Existeplaca(placa);
        }

        public bool Existevehiculo(int id)
        {
            return objDatavehiculo.Existevehiculo(id);
        }

        public List<Vehiculo> Listarvehiculosporcliente(int idcliente)
        {
            return objDatavehiculo.Listarvehiculosporcliente(idcliente);
        }
    }
}
