using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcStrona.Models;

namespace MvcPracownik.Data
{
    public class MvcPracownikContext : DbContext
    {
        public MvcPracownikContext (DbContextOptions<MvcPracownikContext> options)
            : base(options)
        {
        }

        public DbSet<MvcStrona.Models.Pracownik> Pracownik { get; set; } = default!;
        public DbSet<MvcStrona.Models.Grupa> Grupa { get; set; } = default!;
        public DbSet<MvcStrona.Models.Student> Student { get; set; } = default!;
        public DbSet<MvcStrona.Models.GodzinyNauki> GodzinyNauki { get; set; } = default!;
    }
}
