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
