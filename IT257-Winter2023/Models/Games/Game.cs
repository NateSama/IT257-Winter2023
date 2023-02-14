using System;
using System.Security.Policy;

// The Game Model
// As do all models, it needs a primary key.
// Because multiple games can and does have the same name, it needs a separate key

namespace IT257_Winter2023.Models.Games
{
    public class GameModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int GenreId { get; set; }
        public GenreModel Genre { get; set; }
        public int ConsoleId { get; set; }
        public ConsoleModel Console { get; set; }
        public string Description { get; set; }

        //TODO: Implement Rating Capabilites
    }
}
