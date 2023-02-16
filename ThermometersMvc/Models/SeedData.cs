using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ThermometersMvc.Data;
using System;
using System.Linq;

namespace ThermometersMvc.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Thermometers.Any())
                {
                    return;   // DB has been seeded
                }

                context.Thermometers.AddRange(
                    new Thermometers
                    {
                        TypeOfThermometer = "Digital",
                        TemperatureRange = 300,
                        ProbeType = "Thermocouple",
                        Accuracy = "0.1°C",
                        Price = 10.99M,
                        Display = "LCD"
                    },
                    new Thermometers
                    {
                        TypeOfThermometer = "Digital",
                        TemperatureRange = 300,
                        ProbeType = "Thermocouple",
                        Accuracy = "0.1°C",
                        Price = 10.99M,
                        Display = "LCD"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}