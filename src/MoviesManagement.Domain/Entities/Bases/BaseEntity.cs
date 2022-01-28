namespace MoviesManagement.Core.Entities.Bases;

public abstract class BaseEntity<TKEY>
{
    public TKEY Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public bool Active { get; set; } = true;
}