using System.Collections.Generic;

namespace IT257_Winter2023.Models
{
    public class GenreModel
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }

        public IEnumerable<GameModel> Games { get; set; }
    }
}
