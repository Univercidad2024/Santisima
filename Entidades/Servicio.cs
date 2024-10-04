using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Servicio
    {
        public int ServicioId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        // Relación con Citas (Un servicio puede tener muchas citas)
        public ICollection<Cita> Citas { get; set; }
    }

}
