using IT257_Winter2023.Models.Games;
using System.Linq;

namespace IT257_Winter2023.Models.Repository
{
    public interface IGameRepository
    {
        IQueryable<GameModel> Games { get; }
    }
}
