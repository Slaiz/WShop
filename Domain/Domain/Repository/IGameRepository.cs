using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.Repository
{
    public interface IGameRepository
    {
        IEnumerable<Game> Games { get; }
    }
}
