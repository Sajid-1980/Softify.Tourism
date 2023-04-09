using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Softify.Tourism.EntityFrameworkCore
{
    public static class TourismDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TourismDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TourismDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
