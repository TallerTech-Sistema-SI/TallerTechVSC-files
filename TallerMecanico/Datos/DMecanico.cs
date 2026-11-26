using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DMecanico
    {
        public string Registrarmecanico(Mecanico objmecanico)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                objmecanico.CreatedAt = DateTime.Now;
                contexto.Mecanico.Add(objmecanico);
                contexto.SaveChanges();
                return "Se registro exitosamente el mecanico";
            }
        }

        public List<Mecanico> Listarmecanicos()
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                return contexto.Mecanico.ToList();
            }
        }

        public string Modificarmecanico(Mecanico objmecanico)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                var modificado = contexto.Mecanico.Find(objmecanico.ID_Mecanico);
                modificado.Nombre = objmecanico.Nombre;
                modificado.Especialidad = objmecanico.Especialidad;
                modificado.Telefono = objmecanico.Telefono;
                modificado.ModifiedBy = objmecanico.ModifiedBy;
                modificado.ModifiedAt = objmecanico.ModifiedAt;
                contexto.SaveChanges();
                return "Se modifico exitosamente el mecanico";
            }
        }

        public string Eliminarmecanico(int id)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                contexto.Mecanico.Remove(contexto.Mecanico.Find(id));
                contexto.SaveChanges();
                return "Se elimino exitosamente el mecanico";
            }
        }

        public Mecanico Buscarmecanico(int id)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                return contexto.Mecanico.Find(id);
            }
        }

        public bool Existemecanico(int id)
        {
            using (var contexto = new TallerMecanicoEntities())
            {
                var encontrado = contexto.Mecanico.Find(id);
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
    }
}
