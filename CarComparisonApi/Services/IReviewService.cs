using CarComparisonApi.Models;

namespace CarComparisonApi.Services
{
    public interface IReviewService
    {
        Task<IEnumerable<Review>> GetReviewsByTrimIdAsync(int trimId);
        Task<Review?> GetReviewByIdAsync(int id);
        Task<Review> CreateReviewAsync(Review review);
        Task UpdateReviewAsync(int id, Review review);
        Task DeleteReviewAsync(int id);
        Task<IEnumerable<Review>> GetReviewsByUserIdAsync(int userId);
        Task<IEnumerable<object>> GetReviewsWithDetailsByTrimIdAsync(int trimId);
    }
}