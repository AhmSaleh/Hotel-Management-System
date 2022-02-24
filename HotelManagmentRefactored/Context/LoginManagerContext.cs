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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<frontend>().HasKey(f => f.user_name);

            modelBuilder
                .Entity<frontend>()
                .Property(f => f.user_name)
                .HasColumnName("user_name")
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder
                .Entity<frontend>()
                .Property(f => f.pass_word)
                .HasColumnName("pass_word")
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<kitchen>().HasKey(f => f.user_name);

            modelBuilder
                .Entity<kitchen>()
                .Property(f => f.user_name)
                .HasColumnName("user_name")
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder
                .Entity<kitchen>()
                .Property(f => f.pass_word)
                .HasColumnName("pass_word")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
