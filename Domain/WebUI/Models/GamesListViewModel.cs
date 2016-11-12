using Domain.Model;
using System.Collections.Generic;

namespace WebUI.Models
{
    /// <summary>
    /// Class model representation
    /// </summary>
    public class GamesListViewModel
    {
        public IEnumerable<Game> Games { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentGenre { get; set; }
    }
}