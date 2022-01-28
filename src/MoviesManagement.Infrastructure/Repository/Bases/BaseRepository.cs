using Microsoft.EntityFrameworkCore;
using MoviesManagement.Core.Entities.Bases;
using MoviesManagement.Domain.Repository;

namespace MoviesManagement.Infrastructure.Repository;

public abstract class BaseRepository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
{
    protected readonly DbContext dbContext;

    protected BaseRepository(DbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task InsertAsync(TEntity entity)
    {
        entity.CreatedDate = DateTime.Now;
        await dbContext.Set<TEntity>().AddAsync(entity);
    }

    public void Insert(TEntity entity)
    {
        entity.CreatedDate = DateTime.Now;
        dbContext.Set<TEntity>().Add(entity);
    }

    public async Task InsertRangeAsync(IList<TEntity> entities)
    {
        foreach (var x in entities)
        {
            x.CreatedDate = DateTime.Now;
        }

        await dbContext.Set<TEntity>().AddRangeAsync(entities);
    }

    public void InsertRange(IList<TEntity> entities)
    {
        foreach (var x in entities)
        {
            x.CreatedDate = DateTime.Now;
        }

        dbContext.Set<TEntity>().AddRange(entities);
    }

    public void Update(TEntity entity)
    {
        dbContext.Set<TEntity>().Update(entity);
    }

    public void UpdateRange(IList<TEntity> entities)
    {
        foreach (var x in entities)
        {
            x.ModifiedDate = DateTime.Now;
        }

        dbContext.Set<TEntity>().UpdateRange(entities);
    }

    public void Delete(TEntity entity)
    {
        entity.Active = false;
        dbContext.Set<TEntity>().Remove(entity);
    }


    public void DeleteRange(IList<TEntity> entities)
    {
        foreach (var x in entities)
        {
            x.Active = false;
        }

        dbContext.Set<TEntity>().RemoveRange(entities);
    }

    public IQueryable Get()
    {
        return dbContext.Set<TEntity>().Where(x => x.Active);
    }

    public async Task SaveAsync()
    {
        await dbContext.SaveChangesAsync();
    }

    public void Save()
    {
        dbContext.SaveChanges();
    }
}