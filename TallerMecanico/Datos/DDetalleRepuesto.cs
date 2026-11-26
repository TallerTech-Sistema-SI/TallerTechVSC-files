using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DDetalleRepuesto
    {
        public string Registrardetalle(Detalle_Repuesto objdetalle)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                objdetalle.CreatedAt = DateTime.Now;
                contexto.Detalle_Repuesto.Add(objdetalle);
                contexto.SaveChanges();
                return "Se registro exitosamente el detalle";
            }
        }

        public List<Detalle_Repuesto> Listardetalles()
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                return contexto.Detalle_Repuesto.ToList();
            }
        }

        public List<Detalle_Repuesto> Listardetallesorden(int idorden)
        {
            List<Detalle_Repuesto> lista = Listardetalles();
            List<Detalle_Repuesto> resultado = new List<Detalle_Repuesto>();
            foreach (Detalle_Repuesto item in lista)
            {
                if (item.ID_Orden == idorden)
                {
                    resultado.Add(item);
                }
            }
            return resultado;
        }

        public string Modificardetalle(Detalle_Repuesto objdetalle)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                var modificado = contexto.Detalle_Repuesto.Find(objdetalle.ID_Detalle);
                modificado.ID_Orden = objdetalle.ID_Orden;
                modificado.ID_Repuesto = objdetalle.ID_Repuesto;
                modificado.Cantidad = objdetalle.Cantidad;
                modificado.Subtotal = objdetalle.Subtotal;
                modificado.ModifiedBy = objdetalle.ModifiedBy;
                modificado.ModifiedAt = objdetalle.ModifiedAt;
                contexto.SaveChanges();
                return "Se modifico exitosamente el detalle";
            }
        }

        public string Eliminardetalle(int id)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                contexto.Detalle_Repuesto.Remove(contexto.Detalle_Repuesto.Find(id));
                contexto.SaveChanges();
                return "Se elimino exitosamente el detalle";
            }
        }

        public Detalle_Repuesto Buscardetalle(int id)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                return contexto.Detalle_Repuesto.Find(id);
            }
        }
    }
}
