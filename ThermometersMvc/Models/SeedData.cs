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
                        Display = "LCD",
                        Rating = "5 - Excellent"
                    },
                    new Thermometers
                    {
                        TypeOfThermometer = "Infrared",
                        TemperatureRange = 500,
                        ProbeType = "RTD",
                        Accuracy = "0.5°F",
                        Price = 19.99M,
                        Display = "LED",
                        Rating = "4 - Good"
                    },
                    new Thermometers
                    {
                        TypeOfThermometer = "Analog",
                        TemperatureRange = 1000,
                        ProbeType = "Thermistor",
                        Accuracy = "1°C",
                        Price = 29.99M,
                        Display = "Analog",
                        Rating = "5 - Excellent"
                    },
                    new Thermometers
                    {
                        TypeOfThermometer = "Wireless",
                        TemperatureRange = 300,
                        ProbeType = "Infrared",
                        Accuracy = "2°F",
                        Price = 49.99M,
                        Display = "Digital",
                        Rating = "2 - Okay"
                    },
                    new Thermometers
                    {
                        TypeOfThermometer = "Thermocouple",
                        TemperatureRange = 500,
                        ProbeType = "K-Type",
                        Accuracy = "5°C",
                        Price = 99.99M,
                        Display = "Backlit",
                        Rating = "3 - Average"
                    },
                    new Thermometers
                    {
                        TypeOfThermometer = "Surface",
                        TemperatureRange = 1000,
                        ProbeType = "J-Type",
                        Accuracy = "10°F",
                        Price = 149.99M,
                        Display = "Wireless",
                        Rating = "4 - Good"
                    },
                    new Thermometers
                    {
                        TypeOfThermometer = "Medical",
                        TemperatureRange = 100,
                        ProbeType = "T-Type",
                        Accuracy = "0.2%",
                        Price = 199.99M,
                        Display = "Smartphone",
                        Rating = "3 - Average"
                    },
                    new Thermometers
                    {
                        TypeOfThermometer = "Food",
                        TemperatureRange = 50,
                        ProbeType = "E-Type",
                        Accuracy = "0.5%",
                        Price = 299.99M,
                        Display = "Tablet",
                        Rating = "2 - Okay"
                    },
                    new Thermometers
                    {
                        TypeOfThermometer = "BBQ",
                        TemperatureRange = 100,
                        ProbeType = "Food-Grade",
                        Accuracy = "1%",
                        Price = 399.99M,
                        Display = "PC",
                        Rating = "1 - Poor"
                    },
                    new Thermometers
                    {
                        TypeOfThermometer = "Oven",
                        TemperatureRange = 200,
                        ProbeType = "Non-Contact",
                        Accuracy = "2%",
                        Price = 499.99M,
                        Display = "Bluetooth",
                        Rating = "1 - Poor"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}