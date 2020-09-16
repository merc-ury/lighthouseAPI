using Microsoft.EntityFrameworkCore;
using LighthouseAPI.Models;

namespace LighthouseAPI.Entities
{
    public class LighthouseContext : DbContext
    {
        public LighthouseContext(DbContextOptions<LighthouseContext> options) : base(options) {}

        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }
    }
}