using CalculatorTest.Lib;

namespace CalculatorTest.API {

    public class Program {

        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddCors(options => {
                options.AddPolicy("Calculator",
                    policy => {
                        policy.WithOrigins("http://localhost:5141")
                                            .AllowAnyHeader()
                                            .AllowAnyMethod();
                    });
            });
            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddScoped<ISimpleCalculator, SimpleCalculator>();
            var app = builder.Build();
            // Configure the HTTP request pipeline.
            app.UseCors();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }

    }

}