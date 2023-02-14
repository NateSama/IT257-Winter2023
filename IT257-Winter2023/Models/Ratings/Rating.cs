namespace IT257_Winter2023.Models.Ratings
{
    public class Rating
    {
        public int Id { get; set; }
        public int ProviderID { get; set; }
        public RatingsProvider Provider { get; set; }
        public string RatingValue { get; set; }
    }
}
