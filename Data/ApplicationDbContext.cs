using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using webTMDT.Models;

namespace webTMDT.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<DanhMuc> danhmuc { get; set; }
        public DbSet<SanPham> sanpham { get; set; }
    }
}
