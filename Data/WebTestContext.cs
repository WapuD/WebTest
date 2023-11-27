using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebTest.Models;

namespace WebTest.Data
{
    public class WebTestContext : DbContext
    {
        public WebTestContext (DbContextOptions<WebTestContext> options)
            : base(options)
        {
        }

        public DbSet<WebTest.Models.Brand> Brand { get; set; } = default!;

        public DbSet<WebTest.Models.Model> Model { get; set; } = default!;

    }
}
