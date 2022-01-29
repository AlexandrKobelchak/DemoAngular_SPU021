using IdentityServer4.EntityFramework.Entities;
using IdentityServer4.EntityFramework.Extensions;
using IdentityServer4.EntityFramework.Interfaces;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDbContext
{
    public class MyApiAuthorizationDbContext<TUser, TRole, TKey>
        :IdentityDbContext<TUser, TRole, TKey>, IPersistedGrantDbContext
        where TUser : IdentityUser<TKey>
        where TRole: IdentityRole<TKey>
        where TKey: IEquatable<TKey>
    {
        IOptions<OperationalStoreOptions> _operationalOptions;
        public MyApiAuthorizationDbContext(
            DbContextOptions options, 
            IOptions<OperationalStoreOptions> operationalOptions)
            : base(options)
        {
            _operationalOptions = operationalOptions;
        }

        public DbSet<PersistedGrant> PersistedGrants { get; set; }
        public DbSet<DeviceFlowCodes> DeviceFlowCodes { get; set; }

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ConfigurePersistedGrantContext(_operationalOptions.Value);
        }
    }
}
