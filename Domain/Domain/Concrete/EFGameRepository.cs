using Domain.Repository;
using System.Collections.Generic;
using Domain.Model;

namespace Domain.Concrete
{
    /// <summary>
    /// This class represents a necessary storage. Uses the instance of the EFdbContext to extract data from the database using Enttity Framework
    /// </summary>
    public class EFGameRepository : IGameRepository
    {
        public EFDbContext content = new EFDbContext();
        public IEnumerable<Game> Games
        {
            get{ return content.Games; }
        }
    }
}
