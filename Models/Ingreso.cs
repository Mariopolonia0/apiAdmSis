using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelManagementApi.Models
{
    public class Ingreso
    {
        [Key]
        public int IngresoId { get; set; }
        public int ClienteId { get; set; }
        public string FechaCumplida { get; set; }
        public string FechaPagado { get; set; }
        public double MontoTotal { get; set; }  
    }
}
