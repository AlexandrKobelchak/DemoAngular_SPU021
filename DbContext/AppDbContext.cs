using Entities;
using Entities.Identity;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;

namespace AppDbContext
{
    public class MyAppDbContext : MyApiAuthorizationDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public DbSet<Faculty> Faculties { get; set; }
        public MyAppDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalOptions) 
            : base(options, operationalOptions)
        {

        }
    }
}
