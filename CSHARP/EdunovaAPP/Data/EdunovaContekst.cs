using EdunovaAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace EdunovaAPP.Data
{
    public class EdunovaContekst : DbContext
    {
        public EdunovaContekst(DbContextOptions<EdunovaContekst> options) : base(options)
        {

        }

        public DbSet<Smjer> Smjerovi { get; set; }



    }
}
