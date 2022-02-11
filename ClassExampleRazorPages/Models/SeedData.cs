using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using ClassExampleRazorPages.Data;

namespace ClassExampleRazorPages.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ClassExampleRazorPagesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ClassExampleRazorPagesContext>>()))
            {
                // Look for any cars.
                if (context.Car.Any())
                {
                    return;   // DB has been seeded
                }

                context.Car.AddRange(
                    new Car
                    {
                        CarMake = "Ford",
                        CarModel = "Focus",
                        CarYearReleased =  DateTime.Parse("2001-1-1"),
                        Color = "Blue",
                        Price = 1
                    },
                    new Car
                    {
                        CarMake = "Ford",
                        CarModel = "Mustang",
                        CarYearReleased =  DateTime.Parse("1964-1-1"),
                        Color = "Black",
                        Price = 50000
                    },
                    new Car
                    {
                        CarMake = "Jaguar",
                        CarModel = "Range Rover",
                        CarYearReleased =  DateTime.Parse("2010-1-1"),
                        Color = "White",
                        Price = 40000
                    },
                    new Car
                    {
                        CarMake = "Jeep",
                        CarModel = "Wrangler",
                        CarYearReleased =  DateTime.Parse("2022-01-01"),
                        Color = "Yellow",
                        Price = 80000
                    }
                );
                context.SaveChanges();
            }
        }
    }
}