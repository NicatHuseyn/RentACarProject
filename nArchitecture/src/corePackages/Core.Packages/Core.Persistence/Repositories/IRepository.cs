﻿using Core.Persistence.Dynamic;
using Core.Persistence.Paging;
using Microsoft.EntityFrameworkCore.Query;
using Octopus.Client.Repositories;
using System.Linq.Expressions;

namespace Core.Persistence.Repositories;

public interface IRepository<TEntity, TEntityId>:IQuery<TEntity> where TEntity : Entity<TEntityId>
{
    TEntity? Get(
        Expression<Func<TEntity, bool>> predicate,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
        );


    Paginate<TEntity> GetList(
        Expression<Func<TEntity, bool>>? predicate = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = false,
        CancellationToken cancellationToken = default
        );

    Paginate<TEntity> GetListDynamic(
        DynamicQuery dynamic,
        Expression<Func<TEntity, bool>>? predicate = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = false,
        CancellationToken cancellationToken = default
        );

    bool Any(
        Expression<Func<TEntity, bool>>? predicate = null,
        bool withDeleted = false,
        bool enableTracking = false,
        CancellationToken cancellationToken = default
        );

    TEntity Add(TEntity entity);

    ICollection<TEntity> AddRange(ICollection<TEntity> entities);

    TEntity Update(TEntity entity);

    ICollection<TEntity> UpdateRange(ICollection<TEntity> entities);

    /// <summary>
    /// you can delete the data either permanently or temporarily
    /// </summary>
    TEntity Delete(TEntity entity, bool permanent = false);

    ICollection<TEntity> DeleteRange(ICollection<TEntity> entities, bool permanent = false);
}
