namespace CarComparisonApi.Models
{
    public class Favorite
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public int TrimId { get; set; }
        public Trim? Trim { get; set; }
        public DateTime AddedAt { get; set; } = DateTime.UtcNow;
    }
}