using WebApiSkeleton.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApiSkeleton.Persistence.EntityConfigurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Role)
                .IsRequired();

            builder.Property(u => u.CountryCode)
                .IsRequired();

            builder.Property(u => u.FirstName)
                .IsRequired().HasMaxLength(150);

            builder.Property(u => u.LastName)
                .IsRequired().HasMaxLength(150);

            builder.Property(u => u.Email)
                .IsRequired().HasMaxLength(150);

            builder.Property(u => u.Phone)
                .IsRequired().HasMaxLength(30);

            builder.Ignore(u => u.Token);

        }
    }
}
