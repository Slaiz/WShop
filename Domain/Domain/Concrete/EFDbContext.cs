using Domain.Model;
using System.Data.Entity;

namespace Domain.Concrete
{
    /// <summary>
    /// Class for association model with db
    /// </summary>
    public class EFDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}
