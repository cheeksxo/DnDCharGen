using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

using DnDCharGen.Models.AzureDatabase;

namespace DnDCharGen.Data
{
    public partial class AzureDatabaseContext : Microsoft.EntityFrameworkCore.DbContext
    {
        private readonly IHttpContextAccessor httpAccessor;

        public AzureDatabaseContext(IHttpContextAccessor httpAccessor, DbContextOptions<AzureDatabaseContext> options):base(options)
        {
            this.httpAccessor = httpAccessor;
        }

        public AzureDatabaseContext(IHttpContextAccessor httpAccessor)
        {
            this.httpAccessor = httpAccessor;
        }

        partial void OnModelBuilding(ModelBuilder builder);

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);



            this.OnModelBuilding(builder);
        }


        public DbSet<DnDCharGen.Models.AzureDatabase.Race> Races
        {
          get;
          set;
        }
    }
}
