using EdunovaAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace EdunovaAPP.Data
{
    public class EdunovaContekst : DbContext
    {
        public EdunovaContekst(DbContextOptions<EdunovaContekst> options) : base(options)
        {
            // ovdje bi upravljali sa različitim opcijama, za sad ništa
        }

        public DbSet<Smjer> Smjerovi { get; set; } // zbog ovog ovdje Smjerovi se tablica zove u množini



    }
}
