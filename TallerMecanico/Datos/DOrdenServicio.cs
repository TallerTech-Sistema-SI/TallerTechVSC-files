using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DOrdenServicio
    {
        public string Registrarorden(OrdenServicio objorden)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                objorden.CreatedAt = DateTime.Now;
                contexto.OrdenServicio.Add(objorden);
                contexto.SaveChanges();
                return "Se registro exitosamente la orden de servicio";
            }
        }

        public List<OrdenServicio> Listarordenes()
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                return contexto.OrdenServicio.ToList();
            }
        }

        public string Modificarorden(OrdenServicio objorden)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                var modificado = contexto.OrdenServicio.Find(objorden.ID_Orden);
                modificado.ID_Vehiculo = objorden.ID_Vehiculo;
                modificado.ID_Mecanico = objorden.ID_Mecanico;
                modificado.Fecha = objorden.Fecha;
                modificado.Descripcion = objorden.Descripcion;
                modificado.Estado = objorden.Estado;
                modificado.ManoObra = objorden.ManoObra;
                modificado.Total = objorden.Total;
                modificado.ModifiedBy = objorden.ModifiedBy;
                modificado.ModifiedAt = objorden.ModifiedAt;
                contexto.SaveChanges();
                return "Se modifico exitosamente la orden de servicio";
            }
        }

        public string Eliminarorden(int id)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                List<Detalle_Repuesto> detalles = contexto.Detalle_Repuesto.ToList();
                foreach (Detalle_Repuesto item in detalles)
                {
                    if (item.ID_Orden == id)
                    {
                        contexto.Detalle_Repuesto.Remove(item);
                    }
                }
                contexto.OrdenServicio.Remove(contexto.OrdenServicio.Find(id));
                contexto.SaveChanges();
                return "Se elimino exitosamente la orden de servicio";
            }
        }

        public OrdenServicio Buscarorden(int id)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                return contexto.OrdenServicio.Find(id);
            }
        }

        public bool Existeorden(int id)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                var encontrado = contexto.OrdenServicio.Find(id);
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

        public string Cambiarestadoorden(int idorden, string nuevoestado, string usuario)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                var modificado = contexto.OrdenServicio.Find(idorden);
                if (modificado != null)
                {
                    modificado.Estado = nuevoestado;
                    modificado.ModifiedBy = usuario;
                    modificado.ModifiedAt = DateTime.Now;
                    contexto.SaveChanges();
                    return "Se modifico exitosamente el estado de la orden";
                }
                else
                {
                    return "No se encontro la orden de servicio";
                }
            }
        }

        public string Actualizartotalorden(int idorden)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                var orden = contexto.OrdenServicio.Find(idorden);
                if (orden != null)
                {
                    decimal sumadetalles = 0;
                    List<Detalle_Repuesto> detalles = contexto.Detalle_Repuesto.ToList();
                    foreach (Detalle_Repuesto item in detalles)
                    {
                        if (item.ID_Orden == idorden)
                        {
                            sumadetalles = sumadetalles + item.Subtotal;
                        }
                    }
                    orden.Total = orden.ManoObra + sumadetalles;
                    orden.ModifiedAt = DateTime.Now;
                    contexto.SaveChanges();
                    return "Se actualizo exitosamente el total de la orden";
                }
                else
                {
                    return "No se encontro la orden de servicio";
                }
            }
        }

        public List<OrdenServicio> Listarordenesporestado(string estado)
        {
            List<OrdenServicio> lista = Listarordenes();
            if (estado.ToUpper() == "TODOS")
            {
                return lista;
            }
            else
            {
                string estadobuscar = estado.ToUpper();
                List<OrdenServicio> resultado = new List<OrdenServicio>();
                foreach (OrdenServicio item in lista)
                {
                    if (item.Estado.ToUpper() == estadobuscar)
                    {
                        resultado.Add(item);
                    }
                }
                return resultado;
            }
        }

        public decimal Calcularingresostotales()
        {
            List<OrdenServicio> lista = Listarordenes();
            decimal total = 0;
            foreach (OrdenServicio item in lista)
            {
                if (item.Estado.ToUpper() == "TERMINADO" || item.Estado.ToUpper() == "ENTREGADO")
                {
                    total = total + item.Total;
                }
            }
            return total;
        }

        public List<OrdenServicio> Listarordenesconcluidas(string estado, DateTime fechainicio, DateTime fechafin)
        {
            List<OrdenServicio> lista = Listarordenes();
            List<OrdenServicio> resultado = new List<OrdenServicio>();
            string estadobuscar = estado.ToUpper();
            foreach (OrdenServicio item in lista)
            {
                if (item.Fecha.Date >= fechainicio.Date && item.Fecha.Date <= fechafin.Date)
                {
                    if (estadobuscar == "TODOS")
                    {
                        if (item.Estado.ToUpper() == "TERMINADO" || item.Estado.ToUpper() == "ENTREGADO")
                        {
                            resultado.Add(item);
                        }
                    }
                    else
                    {
                        if (item.Estado.ToUpper() == estadobuscar)
                        {
                            resultado.Add(item);
                        }
                    }
                }
            }
            return resultado;
        }
    }
}
