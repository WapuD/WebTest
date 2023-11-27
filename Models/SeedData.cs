using Microsoft.EntityFrameworkCore;
using WebTest.Data;

namespace WebTest.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebTestContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WebTestContext>>()))
            {

                if (context.Brand.Any()) { return; }
                context.Brand.AddRange(
                    new Brand
                    {
                        Name = "BMW",
                        Active = 1,
                    },
                    new Brand
                    {
                        Name = "Toyota",
                        Active = 1,
                    },
                    new Brand
                    {
                        Name = "Volkswagen",
                        Active = 1,
                    },
                    new Brand
                    {
                        Name = "Mercedes-Benz",
                        Active = 1,
                    },
                    new Brand
                    {
                        Name = "Hyundai",
                        Active = 0,
                    },
                    new Brand
                    {
                        Name = "Ford",
                        Active = 1,
                    },
                    new Brand
                    {
                        Name = "Honda",
                        Active = 1,
                    },
                    new Brand
                    {
                        Name = "Nissan",
                        Active = 1,
                    }
                );
                context.SaveChanges();

                if (context.Model.Any()) { return; }
                context.Model.AddRange(
                    new Model
                    {
                        Name = "BMW X6 2016",
                        BrandId = 1,
                        Active = 1,
                    },
                    new Model
                    {
                        Name = "BMW X5 2020",
                        BrandId = 1,
                        Active = 0,
                    },
                    new Model
                    {
                        Name = "BMW 5 2019",
                        BrandId = 1,
                        Active = 1,
                    },
                    new Model
                    {
                        Name = "Toyota Roomy 2020",
                        BrandId = 2,
                        Active = 0,
                    },
                    new Model
                    {
                        Name = "Toyota Slenta 2020",
                        BrandId = 2,
                        Active = 0,
                    },
                    new Model
                    {
                        Name = "Toyota RAV4 2022",
                        BrandId = 2,
                        Active = 1,
                    },
                    new Model
                    {
                        Name = "Volkswagen Polo 2023",
                        BrandId = 3,
                        Active = 1,
                    },
                    new Model
                    {
                        Name = "Volkswagen Jetta 2022",
                        BrandId = 3,
                        Active = 1,
                    },
                    new Model
                    {
                        Name = "Volkswagen Passat 2020",
                        BrandId = 3,
                        Active = 0,
                    },
                    new Model
                    {
                        Name = "Mercedes - Benz GLC 2021",
                        BrandId = 4,
                        Active = 1,
                    },
                    new Model
                    {
                        Name = "Mercedes - Benz GLE 2021",
                        BrandId = 4,
                        Active = 1,
                    },
                    new Model
                    {
                        Name = "Mercedes - Benz Sprinter 2021",
                        BrandId = 4,
                        Active = 1,
                    },
                    new Model
                    {
                        Name = "Hyundai Creta 2023",
                        BrandId = 5,
                        Active = 0,
                    },
                    new Model
                    {
                        Name = "Hyundai Solaris 2020",
                        BrandId = 5,
                        Active = 0,
                    },
                    new Model
                    {
                        Name = "Hyundai Accent 2022",
                        BrandId = 5,
                        Active = 0,
                    },
                    new Model
                    {
                        Name = "Ford Mustang 2023",
                        BrandId = 6,
                        Active = 1,
                    },
                    new Model
                    {
                        Name = "Ford Mondeo 2007",
                        BrandId = 6,
                        Active = 0,
                    },
                    new Model
                    {
                        Name = "Ford Kuga 2019",
                        BrandId = 6,
                        Active = 0,
                    },
                    new Model
                    {
                        Name = "Honda UR-V Premium 2023",
                        BrandId = 7,
                        Active = 1,
                    },
                    new Model
                    {
                        Name = "Honda CR-V 2020",
                        BrandId = 7,
                        Active = 0,
                    },
                    new Model
                    {
                        Name = "Honda Civic 2010",
                        BrandId = 7,
                        Active = 0,
                    },
                    new Model
                    {
                        Name = "Nissan Terrano 2023",
                        BrandId = 8,
                        Active = 1,
                    },
                    new Model
                    {
                        Name = "Nissan Qashqai 2020",
                        BrandId = 8,
                        Active = 1,
                    },
                    new Model
                    {
                        Name = "Nissan X-trail 2018",
                        BrandId = 8,
                        Active = 0,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
