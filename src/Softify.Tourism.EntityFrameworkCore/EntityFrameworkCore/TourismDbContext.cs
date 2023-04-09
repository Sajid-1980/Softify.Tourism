using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Softify.Tourism.Authorization.Roles;
using Softify.Tourism.Authorization.Users;
using Softify.Tourism.MultiTenancy;
using Softify.Tourism.Project;

namespace Softify.Tourism.EntityFrameworkCore
{
    public class TourismDbContext : AbpZeroDbContext<Tenant, Role, User, TourismDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TourismDbContext(DbContextOptions<TourismDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Room> Rooms{ get; set; }
        public virtual DbSet<Attribute> Attributes{ get; set; }
        public virtual DbSet<AttributeService> AttributeServices { get; set; }

       
    }
}
