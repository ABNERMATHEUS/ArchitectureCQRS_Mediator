using MoviesManagement.Core.Entities;

namespace MoviesManagement.Domain.Repository;

public interface IRepositoryMovies : IRepository<Movies,Guid>
{
    
}