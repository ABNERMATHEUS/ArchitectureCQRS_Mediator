using MoviesManagement.Core.Entities.Bases;

namespace MoviesManagement.Core.Entities;

public class Movies : BaseEntity<Guid>
{
    
    public string Name { get; set;}
}