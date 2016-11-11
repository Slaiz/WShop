using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.Concrete
{
    public class EFGameRepository : IGameRepository
    {
        public EFDbContext content = new EFDbContext();
        public IEnumerable<Game> Games
        {
            get{ return content.Games; }
        }
    }
}
