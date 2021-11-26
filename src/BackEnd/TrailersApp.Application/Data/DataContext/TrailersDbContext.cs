using Microsoft.EntityFrameworkCore;
using TrailersApp.Application.Data.DataContext.Configurations;
using TrailersApp.Core.Entities;

namespace TrailersApp.Application.Data.DataContext
{
    public class TrailersDbContext : DbContext
    {
        public TrailersDbContext(DbContextOptions<TrailersDbContext> options)
            : base(options)
        {
            
        }  
        
        public DbSet<User> Users { get; set; }
        public DbSet<Trailer> Trailers { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.ApplyConfiguration(new UserConfiguration());
        }
    }
}