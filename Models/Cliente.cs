using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelManagementApi.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dirrecion { get; set; }   
        public string Numerotelefono { get; set; }  
        public string Referencia { get; set; }
    }
}
