using Bootcamp_CKres_Minor.Model;
using Microsoft.EntityFrameworkCore;

namespace Bootcamp_CKres_Minor
{
    public class SchoolDBContext : DbContext
    {
        public DbSet<MsGender> MsGender { get; set; }
        public DbSet<MsGrade> MsGrade { get; set; }
        public DbSet<MsReligion> MsReligion { get; set; }
        public DbSet<MsStudent> MsStudent { get; set; }
        public DbSet<MsSubject> MsSubject { get; set; }
        public DbSet<TrScore> TrScore { get; set; }
        public SchoolDBContext(DbContextOptions<SchoolDBContext> options) : base(options)
        {
            
        }
    }
}
