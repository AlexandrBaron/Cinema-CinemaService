namespace CinemaService.Core.Entities
{
    public class BaseEntity : IAggregateRoot
    {
        public Guid Id { get; set; }
    }
}
