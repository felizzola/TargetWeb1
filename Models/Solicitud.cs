using Microsoft.AspNetCore.Authorization;
using System;
namespace TargetWeb1.Models
{
    public class Solicitud

    {
        public Guid Id { get; set; }
        public DateTime FechaPedido { get; set; }
        public string Estado { get; set; }

    }
}