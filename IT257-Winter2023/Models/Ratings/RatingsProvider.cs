using System.Collections.Generic;

namespace IT257_Winter2023.Models.Ratings
{
    public class RatingsProvider
    {
        public int Id { get; set; }
        public string ProviderName { get; set; }

        public List<Rating> Ratings { get; set; }
    }
}
