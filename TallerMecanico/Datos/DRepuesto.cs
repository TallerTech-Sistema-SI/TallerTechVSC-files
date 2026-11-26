using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DRepuesto
    {
        public string Registrarrepuesto(Repuesto objrepuesto)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                objrepuesto.CreatedAt = DateTime.Now;
                contexto.Repuesto.Add(objrepuesto);
                contexto.SaveChanges();
                return "Se registro exitosamente el repuesto";
            }
        }

        public List<Repuesto> Listarrepuestos()
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                return contexto.Repuesto.ToList();
            }
        }

        public string Modificarrepuesto(Repuesto objrepuesto)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                var modificado = contexto.Repuesto.Find(objrepuesto.ID_Repuesto);
                modificado.Codigo = objrepuesto.Codigo;
                modificado.Nombre = objrepuesto.Nombre;
                modificado.Marca = objrepuesto.Marca;
                modificado.Precio = objrepuesto.Precio;
                modificado.Stock = objrepuesto.Stock;
                modificado.StockMinimo = objrepuesto.StockMinimo;
                modificado.ModifiedBy = objrepuesto.ModifiedBy;
                modificado.ModifiedAt = objrepuesto.ModifiedAt;
                contexto.SaveChanges();
                return "Se modifico exitosamente el repuesto";
            }
        }

        public string Eliminarrepuesto(int id)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                contexto.Repuesto.Remove(contexto.Repuesto.Find(id));
                contexto.SaveChanges();
                return "Se elimino exitosamente el repuesto";
            }
        }

        public Repuesto Buscarrepuesto(int id)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                return contexto.Repuesto.Find(id);
            }
        }

        public bool Existerepuesto(int id)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                var encontrado = contexto.Repuesto.Find(id);
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

        public bool Existecodigo(string codigo)
        {
            List<Repuesto> lista = Listarrepuestos();
            foreach (Repuesto item in lista)
            {
                if (item.Codigo == codigo)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Repuesto> Listarrepuestoscriticos()
        {
            List<Repuesto> lista = Listarrepuestos();
            List<Repuesto> resultado = new List<Repuesto>();
            foreach (Repuesto item in lista)
            {
                if (item.Stock <= item.StockMinimo)
                {
                    resultado.Add(item);
                }
            }
            return resultado;
        }

        public string Descontarstock(int idrepuesto, int cantidad)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                var modificado = contexto.Repuesto.Find(idrepuesto);
                if (modificado != null)
                {
                    modificado.Stock = modificado.Stock - cantidad;
                    modificado.ModifiedAt = DateTime.Now;
                    contexto.SaveChanges();
                    return "Stock actualizado exitosamente";
                }
                else
                {
                    return "No se encontro el repuesto";
                }
            }
        }

        public string Aumentarstock(int idrepuesto, int cantidad)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                var modificado = contexto.Repuesto.Find(idrepuesto);
                if (modificado != null)
                {
                    modificado.Stock = modificado.Stock + cantidad;
                    contexto.SaveChanges();
                    return "Stock actualizado exitosamente";
                }
                else
                {
                    return "No se encontro el repuesto";
                }
            }
        }
    }
}
