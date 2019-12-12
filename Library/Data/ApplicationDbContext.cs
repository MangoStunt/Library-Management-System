using System;
using System.Collections.Generic;
using System.Text;
using Library.Data.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Reader> Readers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Reader>()
        //        .HasOne<Book>(s => s.Books)
        //        .WithMany(g => g.)
        //        .HasForeignKey(s => s.CurrentGradeId);
        //}

    }
}

