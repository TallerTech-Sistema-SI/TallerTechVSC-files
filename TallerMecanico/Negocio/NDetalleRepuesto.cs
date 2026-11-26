using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NDetalleRepuesto
    {
        DDetalleRepuesto objDatadetalle = new DDetalleRepuesto();
        DRepuesto objDatarepuesto = new DRepuesto();
        DOrdenServicio objDataorden = new DOrdenServicio();

        public string Agregardetalleorden(int idorden, int idrepuesto, int cantidad, string usuario)
        {
            OrdenServicio orden = objDataorden.Buscarorden(idorden);
            if (orden == null)
            {
                return "No se encontro la orden de servicio";
            }
            else
            {
                Repuesto repuesto = objDatarepuesto.Buscarrepuesto(idrepuesto);
                if (repuesto == null)
                {
                    return "No se encontro el repuesto";
                }
                else
                {
                    if (cantidad <= 0)
                    {
                        return "La cantidad debe ser mayor a cero";
                    }
                    else
                    {
                        if (repuesto.Stock < cantidad)
                        {
                            return "Stock insuficiente para el repuesto solicitado";
                        }
                        else
                        {
                            decimal subtotal = cantidad * repuesto.Precio;
                            int stockrestante = repuesto.Stock - cantidad;
                            objDatarepuesto.Descontarstock(idrepuesto, cantidad);

                            Detalle_Repuesto objdetalle = new Detalle_Repuesto();
                            objdetalle.ID_Orden = idorden;
                            objdetalle.ID_Repuesto = idrepuesto;
                            objdetalle.Cantidad = cantidad;
                            objdetalle.Subtotal = subtotal;
                            objdetalle.CreatedBy = usuario;
                            objDatadetalle.Registrardetalle(objdetalle);

                            objDataorden.Actualizartotalorden(idorden);

                            if (stockrestante <= repuesto.StockMinimo)
                            {
                                return "Se agrego exitosamente el repuesto a la orden. ALERTA: Stock critico (" + stockrestante.ToString() + " unidades restantes)";
                            }
                            else
                            {
                                return "Se agrego exitosamente el repuesto a la orden";
                            }
                        }
                    }
                }
            }
        }

        public List<Detalle_Repuesto> Listardetallesorden(int idorden)
        {
            return objDatadetalle.Listardetallesorden(idorden);
        }

        public List<Detalle_Repuesto> Listardetalles()
        {
            return objDatadetalle.Listardetalles();
        }

        public string Eliminardetalle(int id)
        {
            return objDatadetalle.Eliminardetalle(id);
        }

        public Detalle_Repuesto Buscardetalle(int id)
        {
            return objDatadetalle.Buscardetalle(id);
        }
    }
}
