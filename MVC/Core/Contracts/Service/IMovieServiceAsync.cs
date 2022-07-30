using Core.Entities;

namespace Core.Contracts.Service
{
    public interface IMovieServiceAsync
    {
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
		Task<Movie> GetByIdAsync(int movieId);
	}
}
