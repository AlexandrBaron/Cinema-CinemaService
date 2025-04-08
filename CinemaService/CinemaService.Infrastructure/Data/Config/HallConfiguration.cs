using Hall = CinemaService.Core.Entities.Hall;

namespace CinemaService.Infrastructure.Data.Config
{
    public class HallConfiguration : IEntityTypeConfiguration<Hall>
    {
        public void Configure(EntityTypeBuilder<Hall> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(DataConstants.DEFAULT_NAME_LENGTH);
        }
    }
}
