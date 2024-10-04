using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public DateTime FechaContratacion { get; set; } = DateTime.Now;
        public bool Disponibilidad { get; set; } = true; // 1 = Disponible, 0 = No Disponible

        // Relación con citas (Un empleado puede tener muchas citas)
        public ICollection<Cita> Citas { get; set; }
    }

}
