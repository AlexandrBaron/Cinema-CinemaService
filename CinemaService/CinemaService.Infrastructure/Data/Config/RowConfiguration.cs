using Row = CinemaService.Core.Entities.Row;

namespace CinemaService.Infrastructure.Data.Config
{
    public class RowConfiguration : IEntityTypeConfiguration<Row>
    {
        public void Configure(EntityTypeBuilder<Row> builder)
        {
            builder.Property(x => x.Number).IsRequired();
        }
    }
}
