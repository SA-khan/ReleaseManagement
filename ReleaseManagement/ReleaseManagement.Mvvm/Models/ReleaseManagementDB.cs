using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Release_Management.Model
{
    public class ReleaseManagementDB : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);

        //}
        
        //DbContextOptionsBuilder dbContextOptionsBuilder = new DbContextOptionsBuilder();
       
        //public ReleaseManagementDB() : base()
        //{

        //}
        public DbSet<ENVIRONMENT> ENVIRONMENT { get; set; }
        public DbSet<CLIENT> CLIENT { get; set; }
        public DbSet<PRODUCT> PRODUCT { get; set; }
        public DbSet<ENVIRONMENT_TYPE> ENVIRONMENT_TYPE { get; set; }
    }
}
