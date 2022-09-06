using Headless.DB.Tables;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File = Headless.DB.Tables.File;

namespace Headless.DB
{
    public class HeadlessDbContext : IdentityDbContext<IdentityUser>
    {
        public HeadlessDbContext(DbContextOptions<HeadlessDbContext> dbContextOptions) : base()
        {
        }
        public DbSet<Lang> Languages { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<CustomForm> CustomForms { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=headless.db;Username=postgres;Password=postgres");
    }
}
