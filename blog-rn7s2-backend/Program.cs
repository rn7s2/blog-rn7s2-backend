using blog_rn7s2_backend.Data;
using Microsoft.EntityFrameworkCore;

namespace blog_rn7s2_backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // TODO: Add PostgreSQL/MariaDB support in production mode.
            if (builder.Environment.IsDevelopment())
            {
                builder.Services.AddDbContext<BlogContextSQLite>(
                    options => options.UseSqlite(
                        builder.Configuration.GetConnectionString(nameof(BlogContextSQLite))
                    )
                );
            }
            else
            {
                builder.Services.AddDbContext<BlogContextSQLite>(
                    options => options.UseSqlite(
                        builder.Configuration.GetConnectionString(nameof(BlogContextSQLite))
                    )
                );
            }

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            var app = builder.Build();

            CreateDbIfNotExists(app);

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }

        private static void CreateDbIfNotExists(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<BlogContextSQLite>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }
        }

    }
}
