using MsSql_MySql.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsSql_MySql.ContextDb
{
    public class MsSqlContext : DbContext
    {
        public MsSqlContext() : base("name=MsSqlConnectionString")
        {
        }

        public virtual DbSet<gi_comuni_validita> gi_comuni_validita { get; set; }

        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
