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
        //Constructor for unit test
        // If this is a bad practise please tell me that
        public HeadlessDbContext() : base()
        {
        }
        public virtual DbSet<Lang> Languages { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<ActualPage> ActualPage { get; set; }
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<AuthorRole> AuthorRole { get; set; }
        public virtual DbSet<CustomForm> CustomForms { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<Image> Images { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=headless.db;Username=postgres;Password=postgres");
    }
}
