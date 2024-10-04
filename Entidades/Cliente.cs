using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
        public int FrecuenciaVisitas { get; set; } = 0;

        // Relación con citas (Un cliente puede tener muchas citas)
        public ICollection<Cita> Citas { get; set; }

        // Relación con el historial de servicios
        public ICollection<HistorialServicio> HistorialServicios { get; set; }
    }


}
