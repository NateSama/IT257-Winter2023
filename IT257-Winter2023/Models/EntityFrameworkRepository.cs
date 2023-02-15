using IT257_Winter2023.Models.Games;
using System.Linq;

namespace IT257_Winter2023.Models
{
    public interface IGameRepository
    {
        IQueryable<GameModel> Games { get; }
    }
}
