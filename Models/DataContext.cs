/*using Microsoft.EntityFrameworkCore;
using AspHospitalMgmt.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace AspHospitalMgmt
{
    public class DataContext : IdentityDbContext<Microsoft.AspNetCore.Identity.IdentityUser>
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        // Add DbSets for your other entities here
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<RegUser> RegUsers { get; set; }
    }
}*/
using AspHospitalMgmt.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspHospitalMgmt
{
    public class DataContext : IdentityDbContext<IdentityUser>
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<RegUser> RegUsers { get; set; }
    }
}
