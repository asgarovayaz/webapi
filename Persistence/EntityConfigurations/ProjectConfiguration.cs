using WebApiSkeleton.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApiSkeleton.Persistence.EntityConfigurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project");
            builder.HasKey(p => p.Id);

            #region Project Information

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(300);

            builder.Property(p => p.Country)
                .IsRequired()
                .HasMaxLength(5);

            builder.Property(p => p.Location)
                .IsRequired()
                .HasMaxLength(5);

            builder.Property(p => p.Discipline)
                .IsRequired();

            builder.Property(p => p.BankRequisites)
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(p => p.Currency)
                .IsRequired();

            builder.Property(p => p.Status)
                .IsRequired();

            #endregion


            #region Project Deadlines

            builder.Property(p => p.StartDate)
                .IsRequired();

            builder.Property(p => p.EndDate)
                .IsRequired();

            #endregion


        }
    }
}
