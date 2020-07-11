using FlightLibrairy.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace FlightLibrairy
{
    public class VolContext : DbContext
    {
        public VolContext(DbContextOptions options) : base(options) { }
        public DbSet<VolEntite> Vols { get; set; }
    }
}
