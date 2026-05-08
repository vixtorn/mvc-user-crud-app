using Microsoft.EntityFrameworkCore;
using DatabaseDeneme.Models;

namespace DatabaseDeneme.Data
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options) { }

        // SQL'deki tablo adı 'Users' olduğu için burası mutlaka 'Users' olmalı. Eşleşmezsse hata verir.
        public DbSet<Kisi> Users { get; set; }
    }
}