using blog_rn7s2_backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;

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
            if(builder.Environment.IsDevelopment())
            {
            }
            else
            {
            }

            builder.Services.AddDbContext<BlogContextSQLite>(
                options => options.UseSqlite(
                    builder.Configuration.GetConnectionString(nameof(BlogContextSQLite))
                )
            );

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
