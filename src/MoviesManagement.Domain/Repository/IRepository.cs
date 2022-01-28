using MoviesManagement.Core.Entities.Bases;

namespace MoviesManagement.Domain.Repository;

public interface IRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
{
    #region CREATE

    Task InsertAsync(TEntity entity);
    void Insert(TEntity entity);
    Task InsertRangeAsync(IList<TEntity> entities);
    void InsertRange(IList<TEntity> entities);

    #endregion

    #region UPDATE

    void Update(TEntity entity);
    void UpdateRange(IList<TEntity> entity);

    #endregion

    #region DELETE

    void Delete(TEntity entity);
    void DeleteRange(IList<TEntity> entities);

    #endregion

    #region GET
    IQueryable Get();
    #endregion

    #region Save
    Task SaveAsync();
    void Save();
    #endregion
}