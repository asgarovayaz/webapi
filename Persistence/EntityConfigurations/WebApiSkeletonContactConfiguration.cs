using WebApiSkeleton.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApiSkeleton.Persistence.EntityConfigurations
{
    internal class WebApiSkeletonContactConfiguration : IEntityTypeConfiguration<WebApiSkeletonContact>
    {
        public void Configure(EntityTypeBuilder<WebApiSkeletonContact> builder)
        {
            builder.ToTable("WebApiSkeletonContact");
            builder.HasKey(d => d.Id);

            builder.Property(dc => dc.FullName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(dc => dc.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(dc => dc.Phone)
                .IsRequired()
                .HasMaxLength(100);



        }
    }
}
