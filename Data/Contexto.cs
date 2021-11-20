using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelManagementApi.Models;

namespace TravelManagementApi.Data
{
    public class Contexto: DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Ingreso>Ingreso { get; set; }
        public DbSet<Local> Local { get; set; }
        public Contexto(DbContextOptions<Contexto> options): base(options)
        {

        }
    }
}
