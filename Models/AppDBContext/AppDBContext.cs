using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookBorrow.Models
{
    public class AppDBContext : IdentityDbContext
    {
        private readonly DbContextOptions _options;

        public AppDBContext(DbContextOptions options) : base(options)
        {
            _options = options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BookIssue>()
                .HasOne(b => b.Book)
                .WithMany(bi => bi.BookIssue)
                .HasForeignKey(bk => bk.BookID);
            modelBuilder.Entity<BookIssue>()
                .HasOne(b => b.Member)
                .WithMany(bi => bi.BookIssue)
                .HasForeignKey(bk => bk.MemberId);

        }
       
        public DbSet<Book> Book { get; set; }
        public DbSet<Member> Member { get; set; }

        public DbSet<BookIssue> BookIssue { get; set; }

    }
}
