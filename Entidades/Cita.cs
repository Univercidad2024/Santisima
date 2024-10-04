using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cita
    {
        public int CitaId { get; set; }

        // Relación con Cliente
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        // Relación con Empleado
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }

        // Relación con Servicio
        public int ServicioId { get; set; }
        public Servicio Servicio { get; set; }

        public DateTime FechaCita { get; set; }
        public string Estado { get; set; } = "Pendiente"; // Estado de la cita (Pendiente, Confirmada, Cancelada)
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }


}
