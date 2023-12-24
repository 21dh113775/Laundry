using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class LaundyContext : DbContext
    {
        public LaundyContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<NhanVien> NhanViens { get; set; }

    }
}
