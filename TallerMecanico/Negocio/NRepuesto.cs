using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NRepuesto
    {
        DRepuesto objDatarepuesto = new DRepuesto();

        public string Registrarrepuesto(Repuesto objrepuesto)
        {
            if (objDatarepuesto.Existecodigo(objrepuesto.Codigo))
            {
                return "El codigo de repuesto ya se encuentra registrado";
            }
            else
            {
                if (objrepuesto.Precio < 0)
                {
                    return "El precio no puede ser negativo";
                }
                else
                {
                    if (objrepuesto.Stock < 0)
                    {
                        return "El stock no puede ser negativo";
                    }
                    else
                    {
                        return objDatarepuesto.Registrarrepuesto(objrepuesto);
                    }
                }
            }
        }

        public List<Repuesto> Listarrepuestos()
        {
            return objDatarepuesto.Listarrepuestos();
        }

        public List<Repuesto> Buscarrepuestos(string texto)
        {
            List<Repuesto> lista = objDatarepuesto.Listarrepuestos();
            List<Repuesto> resultado = new List<Repuesto>();
            string buscar = texto.Trim().ToLower();
            foreach (Repuesto item in lista)
            {
                bool coincide = false;
                if (item.Nombre != null && item.Nombre.ToLower().Contains(buscar))
                {
                    coincide = true;
                }
                if (item.Codigo != null && item.Codigo.ToLower().Contains(buscar))
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

        public List<Repuesto> Listarrepuestoscriticos()
        {
            return objDatarepuesto.Listarrepuestoscriticos();
        }

        public string Modificarrepuesto(Repuesto objrepuesto)
        {
            if (objrepuesto.Precio < 0)
            {
                return "El precio no puede ser negativo";
            }
            else
            {
                if (objrepuesto.Stock < 0)
                {
                    return "El stock no puede ser negativo";
                }
                else
                {
                    return objDatarepuesto.Modificarrepuesto(objrepuesto);
                }
            }
        }

        public string Eliminarrepuesto(int id)
        {
            return objDatarepuesto.Eliminarrepuesto(id);
        }

        public Repuesto Buscarrepuesto(int id)
        {
            return objDatarepuesto.Buscarrepuesto(id);
        }

        public bool Existerepuesto(int id)
        {
            return objDatarepuesto.Existerepuesto(id);
        }

        public bool Existecodigo(string codigo)
        {
            return objDatarepuesto.Existecodigo(codigo);
        }
    }
}
