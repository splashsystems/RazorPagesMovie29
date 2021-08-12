using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie29.Models;

namespace RazorPagesMovie29.Data
{
    public class RazorPagesMovie29Context : DbContext
    {
        public RazorPagesMovie29Context (DbContextOptions<RazorPagesMovie29Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie29.Models.Movie> Movie { get; set; }
    }
}
