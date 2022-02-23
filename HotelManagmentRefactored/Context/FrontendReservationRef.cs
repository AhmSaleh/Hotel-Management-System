using HotelManagmentRefactored.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentRefactored.Context
{
    internal class FrontendReservationRef : DbContext
    {
        public DbSet<reservation> reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(
                @"Server=.;Database=FRONTEND_RESERVATIONRef;Trusted_Connection=True;"
            );
    }
}
