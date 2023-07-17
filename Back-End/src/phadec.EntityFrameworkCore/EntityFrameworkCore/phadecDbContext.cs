using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using phadec.Authorization.Roles;
using phadec.Authorization.Users;
using phadec.MultiTenancy;
using Abp.Localization;
using phadec.Domain;
using phadec.Model;

namespace phadec.EntityFrameworkCore
{
    public class phadecDbContext : AbpZeroDbContext<Tenant, Role, User, phadecDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DrugInteraction> DrugInteactions { get; set; }
        public DbSet<FoodInteraction> FoodInteractions { get; set; }
        public DbSet<Opinion> Opinions { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }
        public DbSet<ReviewDeneme> ReviewDenemes { get; set; }

        public DbSet<RegisterAccount> RegisterAccounts { get; set; }

        public phadecDbContext(DbContextOptions<phadecDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(100); // any integer that is smaller than 10485760
        }
    }
}
