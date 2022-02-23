using HotelManagmentRefactored.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentRefactored.Context
{
    internal class LoginManagerContext : DbContext
    {
        public DbSet<frontend> frontend { get; set; }
        public DbSet<kitchen> kitchen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(
                @"Server=.;Database=LOGIN_MANAGERRef;Trusted_Connection=True;"
            );
    }
}
