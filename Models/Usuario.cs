using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TargetWeb1.Models
{
    public abstract class Usuario 
    {

        public Guid Id { get; set; }
        public string Nombre{ get; set; }
        public string Apellido { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime FechaAlta { get; set; }
        public List<Solicitud> Solicitudes { get; set; }
    }
}
