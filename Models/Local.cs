using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelManagementApi.Models
{
    public class Local
    {
        [Key]
        public int LocalId { get; set; }
        public string Nombre { get; set; }
        public float MontoRenta { get; set; }
        public string TipoLocal { get; set; }
        public string Descripcion { get; set; } 
        public string FechaRegistro { get; set; } 
        public int ClienteId { get; set; }
    }
}
