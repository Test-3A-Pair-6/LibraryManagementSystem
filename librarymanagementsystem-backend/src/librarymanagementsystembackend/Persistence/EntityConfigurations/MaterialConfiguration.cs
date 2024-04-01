using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class MaterialConfiguration : IEntityTypeConfiguration<Material>
{
    public void Configure(EntityTypeBuilder<Material> builder)
    {
        builder.ToTable("Materials").HasKey(m => m.Id);

        builder.Property(m => m.Id).HasColumnName("Id").IsRequired();
        builder.Property(m => m.Name).HasColumnName("Name");
        builder.Property(m => m.Description).HasColumnName("Description");
        builder.Property(m => m.PublicationDate).HasColumnName("PublicationDate");
        builder.Property(m => m.PunishmentAmount).HasColumnName("PunishmentAmount");
        builder.Property(m => m.IsBorrowable).HasColumnName("IsBorrowable");
        builder.Property(m => m.BorrowDay).HasColumnName("BorrowDay");
        builder.Property(m => m.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(m => m.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(m => m.DeletedDate).HasColumnName("DeletedDate");


        builder.HasMany(m => m.FavoriteLists);
        builder.HasMany(m => m.MaterialCopies);
        builder.HasMany(m => m.MaterialPropertyValues);
        builder.HasMany(m => m.Languages);
        builder.HasMany(m => m.Authors);
        builder.HasMany(m => m.Publishers);
        builder.HasMany(m => m.Translators);

        builder.HasQueryFilter(m => !m.DeletedDate.HasValue);
    }
}