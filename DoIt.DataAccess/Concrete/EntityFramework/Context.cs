using DoIt.Entities.Concrete;
using System.Data.Entity;

namespace DoIt.DataAccess.Concrete.EntityFramework
{
    public class Context : DbContext
    {
        public Context() : base("DoIt")
        {
            Database.SetInitializer<Context>(null);
        }

        public DbSet<Organization> Organization { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Duty> Duty { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Quote> Quote { get; set; }
    }
}