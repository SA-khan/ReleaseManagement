using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ReleaseManagement.Domain.Models;

namespace ReleaseManagement.Infra.Data.Context
{
    public class ReleaseManagementDBContext : DbContext
    {
        public ReleaseManagementDBContext(DbContextOptions<ReleaseManagementDBContext> options) : base(options){

        }

        public DbSet<Client> Clients { get; set; }
    }
}
