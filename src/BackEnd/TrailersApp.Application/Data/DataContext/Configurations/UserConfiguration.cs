using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrailersApp.Core.Entities;

namespace TrailersApp.Application.Data.DataContext.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = 1,
                    Name = "Admin",
                    Email = "admin@mail.com",
                    Password = "admin1234"
                });
        }
    }
}