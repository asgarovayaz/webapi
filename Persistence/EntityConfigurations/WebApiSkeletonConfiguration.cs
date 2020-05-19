using WebApiSkeleton.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApiSkeleton.Persistence.EntityConfigurations
{
    internal class WebApiSkeletonConfiguration : IEntityTypeConfiguration<WebApiSkeletons>
    {
        public void Configure(EntityTypeBuilder<WebApiSkeletons> builder)
        {
            builder.ToTable("WebApiSkeletons");
            builder.HasKey(d => d.Id);


            #region WebApiSkeleton Configurations

            builder.Property(d => d.CountryCode)
                .HasMaxLength(5);

            #endregion


        }

    }
}
