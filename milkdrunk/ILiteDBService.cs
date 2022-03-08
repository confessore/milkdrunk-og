using LiteDB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace milkdrunk
{
    /// <summary>
    /// a service for interfacing with the local database
    /// </summary>
    /// <typeparam name="TEntity">the entity type of the table</typeparam>
    /// <typeparam name="TId">the primary key type of the entity</typeparam>
    public interface ILiteDBService<TEntity, TId>
            where TEntity : Entity<TId>
            where TId : IEquatable<TId>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Task InvokeAsync(Action<ILiteCollection<TEntity>> action = null);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<T> InvokeAsync<T>(Func<ILiteCollection<TEntity>, Task<T>> function);

        /// <summary>
        /// inserts an entity of type <see cref="TEntity"/> into the
        /// </summary>
        /// <param name="entity">an entity of type <see cref="TEntity"/></param>
        /// <returns>a <see cref="Task"/> upon insertion of the entity</returns>
        Task<int> InsertAsync(TEntity entity);

        /// <summary>
        /// inserts an <see cref="IEnumerable"/> of type <see cref="TEntity"/>
        /// </summary>
        /// <param name="entities">an <see cref="IEnumerable"/> of type <see cref="TEntity"/></param>
        /// <returns>a <see cref="Task"/> upon insertion of the <see cref="IEnumerable{T}"/></returns>
        Task<int> InsertAsync(IEnumerable<TEntity> entities);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> UpdateAsync(TEntity entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task<int> UpdateAsync(IEnumerable<TEntity> entities);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> UpsertAsync(TEntity entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TEntity> FindAsync(TEntity entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity> FindAsync(TId id);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> FindAllAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<ObservableCollection<TEntity>> RetrieveAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<ObservableCollection<TEntity>> RetrieveAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task DeleteAsync(TEntity entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteAsync(TId id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<bool> AnyAsync();
    }
}
