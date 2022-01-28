using Microsoft.EntityFrameworkCore;
using MoviesManagement.Core.Entities;
using MoviesManagement.Domain.Repository;

namespace MoviesManagement.Infrastructure.Repository;

public class IMoviesRepository : BaseRepository<Movies,Guid>, IRepositoryMovies
{
    public IMoviesRepository(DbContext dbContext) : base(dbContext)
    {
    }
}