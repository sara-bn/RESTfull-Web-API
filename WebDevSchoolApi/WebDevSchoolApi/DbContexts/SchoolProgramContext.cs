using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDevSchoolApi.Entities;

namespace WebDevSchoolApi.DbContexts
{
    public class SchoolProgramContext : DbContext
    {
        public SchoolProgramContext(DbContextOptions<SchoolProgramContext> options)
           : base(options)
        {
        }

        public DbSet<School> Schools { get; set; }
        public DbSet<DevProgram> DevPrograms { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<School>()
                .HasData(
                new School()
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    SchoolName = "BCIT",
                    Address = "555 Seymour St, Vancouver, BC V6B 3H6"
                },
                new School()
                {
                    Id = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                    SchoolName = "Langara",
                    Address = "100 W 49th Ave, Vancouver, BC V5Y 2Z6"
                },
                 new School()
                 {
                     Id = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                     SchoolName = "Lighthouse Labs",
                     Address = "401 W Georgia St, Vancouver, BC V6B 5A1"
                 }
                );
            modelBuilder.Entity<DevProgram>()
                .HasData(
                new DevProgram()
                {
                    Id = Guid.Parse("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                    ProgramName = "Software System Developer",
                    SchoolId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35")
                },
                new DevProgram()
                {
                    Id = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                    ProgramName = "Full Stack Web Development",
                    SchoolId = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                },
                new DevProgram()
                {
                    Id = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                    ProgramName = "Web Development Bootcamp",
                    SchoolId = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450")
                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
