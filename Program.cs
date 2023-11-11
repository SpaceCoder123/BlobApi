namespace BlobStorage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new() { Title = "Mohan AzBlob Communication", Version = "v1" });
            });
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("ReactNativeCorsPolicy",
                    builder =>
                    {
                        builder
                            .AllowAnyOrigin() // You can also specify specific origins
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                    });
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("../swagger/v1/swagger.json", "v1"));
            app.UseCors("ReactNativeCorsPolicy");

            app.MapControllers();

            app.Run();
        }
    }
}