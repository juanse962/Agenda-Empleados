using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmpleadoController.Models
{
    public class EmpleadoContext : DbContext
    {
        public EmpleadoContext(DbContextOptions<EmpleadoContext> options) : base(options)
        {

        }
        public DbSet<Empleado> Empleado { get; set; }
        }
        public class Empleado
        {   
            [Key]
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string TipoDeDocumento { get; set; }
            public string NumeroDeDocumento { get; set; }
            public string Area { get; set; }
            public string SubArea { get; set; }
        }
    }   

    
