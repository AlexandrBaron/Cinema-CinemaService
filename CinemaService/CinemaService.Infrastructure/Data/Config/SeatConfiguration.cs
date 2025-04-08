using Seat = CinemaService.Core.Entities.Seat;

namespace CinemaService.Infrastructure.Data.Config
{
    public class SeatConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder.Property(x => x.Number).IsRequired();
        }
    }
}
