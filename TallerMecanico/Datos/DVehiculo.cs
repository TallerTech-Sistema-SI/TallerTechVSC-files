using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DVehiculo
    {
        public string Registrarvehiculo(Vehiculo objvehiculo)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                objvehiculo.CreatedAt = DateTime.Now;
                contexto.Vehiculo.Add(objvehiculo);
                contexto.SaveChanges();
                return "Se registro exitosamente el vehiculo";
            }
        }

        public List<Vehiculo> Listarvehiculos()
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                return contexto.Vehiculo.ToList();
            }
        }

        public string Modificarvehiculo(Vehiculo objvehiculo)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                var modificado = contexto.Vehiculo.Find(objvehiculo.ID_Vehiculo);
                modificado.ID_Cliente = objvehiculo.ID_Cliente;
                modificado.Placa = objvehiculo.Placa;
                modificado.Marca = objvehiculo.Marca;
                modificado.Modelo = objvehiculo.Modelo;
                modificado.Anio = objvehiculo.Anio;
                modificado.ModifiedBy = objvehiculo.ModifiedBy;
                modificado.ModifiedAt = objvehiculo.ModifiedAt;
                contexto.SaveChanges();
                return "Se modifico exitosamente el vehiculo";
            }
        }

        public string Eliminarvehiculo(int id)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                contexto.Vehiculo.Remove(contexto.Vehiculo.Find(id));
                contexto.SaveChanges();
                return "Se elimino exitosamente el vehiculo";
            }
        }

        public Vehiculo Buscarvehiculo(int id)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                return contexto.Vehiculo.Find(id);
            }
        }

        public bool Existeplaca(string placa)
        {
            List<Vehiculo> lista = Listarvehiculos();
            foreach (Vehiculo item in lista)
            {
                if (item.Placa == placa)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Existevehiculo(int id)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                var encontrado = contexto.Vehiculo.Find(id);
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

        public List<Vehiculo> Listarvehiculosporcliente(int idcliente)
        {
            List<Vehiculo> lista = Listarvehiculos();
            List<Vehiculo> resultado = new List<Vehiculo>();
            foreach (Vehiculo item in lista)
            {
                if (item.ID_Cliente == idcliente)
                {
                    resultado.Add(item);
                }
            }
            return resultado;
        }
    }
}
