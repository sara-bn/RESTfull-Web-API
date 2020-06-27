using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDevSchoolApi.Entities;

namespace WebDevSchoolApi.DbContexts
{
    public class SchoolProgramContext :DbContext
    {
        public SchoolProgramContext(DbContextOptions<SchoolProgramContext> options)
           : base(options)
        {
        }

        public DbSet<School>Schools { get; set; }
        public DbSet<DevProgram> DevPrograms { get; set; }
    }
}
