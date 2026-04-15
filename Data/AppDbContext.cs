using Microsoft.EntityFrameworkCore;
using VotacionesAPI.Models;

namespace VotacionesAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Voto> Votos { get; set; }
}