
using OrderMusicApp.Modules.WebApi.Controllers;

namespace OrderMusicApp.Modules.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.WebHost.UseUrls([$"http://{args[1]}:{args[2]}"]);

            // Add services to the container.
            builder.Services.AddControllers().AddApplicationPart(typeof(AudioPlayerController).Assembly);
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                //app.UseSwagger();
                //app.UseSwaggerUI();
            }

            //app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
