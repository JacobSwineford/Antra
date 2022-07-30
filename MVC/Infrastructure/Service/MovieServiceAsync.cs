using Core.Contracts.Repository;
using Core.Contracts.Service;
using Core.Entities;
using Core.Models;

namespace Infrastructure.Service
{
    public class MovieServiceAsync : IMovieServiceAsync
    {

        IMovieRepositoryAsync repo;

        public MovieServiceAsync(IMovieRepositoryAsync repo)
		{
            this.repo = repo;
		}

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            var result = await repo.GetAllAsync();
            return result.ToList();
        }

        public async Task<Movie> GetByIdAsync(int id)
		{
            return await repo.GetByIdAsync(id);
        } 
    }
}
