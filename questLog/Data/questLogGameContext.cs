using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using questLogGame.Models;

namespace questLogGame.Data
{
    public class questLogGameContext : DbContext
    {
        public questLogGameContext (DbContextOptions<questLogGameContext> options)
            : base(options)
        {
        }

        public DbSet<questLogGame.Models.Game> Game { get; set; } = default!;
    }
}
