using System.Threading.Channels;

namespace CinemaService.Infrastructure.Data
{
    public class ApDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>, IDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            return CreateDbContext();
        }

        public AppDbContext CreateDbContext()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .AddJsonFile("appsettings.Development.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            var optionBuilder = new DbContextOptionsBuilder<AppDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            Console.WriteLine("### CONNECTION STRING");
            Console.WriteLine(connectionString ?? "nenalezeno");

            optionBuilder.UseSqlServer(connectionString);

            return new AppDbContext(optionBuilder.Options);
        }
    }
}
