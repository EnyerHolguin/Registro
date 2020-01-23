using Microsoft.EntityFrameworkCore;
using Registro.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Registro.DAL.Scripts
{
    public class Context : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public object Persona { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Serve = .\SqlExpress; Database = TestDb; Trusted_Connection = true; ");
        }

    }
}
