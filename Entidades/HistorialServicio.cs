using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class HistorialServicio
    {
        public int HistorialId { get; set; }

        // Relación con Cliente
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        // Relación con Servicio
        public int ServicioId { get; set; }
        public Servicio Servicio { get; set; }

        public DateTime FechaServicio { get; set; } = DateTime.Now;
    }

}
