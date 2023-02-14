using System.Collections.Generic;

namespace IT257_Winter2023.Models
{
    public class ConsoleModel
    {
        public int ConsoleId { get; set; }
        public string ConsoleName { get; set; }
        public IEnumerable<GameModel> Games { get; set; }
    }
}
