using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Repository
{
    public interface IMovieCastRepositoryAsync : IRepositoryAsync<MovieCast>
    {
        public Task<MovieCast> getMoviesAndCast(); // concatenate (join) results in linq? correlated subquery?
    }
}

