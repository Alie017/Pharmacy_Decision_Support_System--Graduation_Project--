using System;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace phadec.EntityFrameworkCore
{
    public static class phadecDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<phadecDbContext> builder, string connectionString)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<phadecDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
