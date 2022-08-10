using LiteDB;
using milkdrunk.extensions;
using milkdrunk.models.abstractions;
using milkdrunk.services.interfaces;
using Serilog;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace milkdrunk.services
{
    /// <inheritdoc cref="ILiteDBService{T, U}" />
    public sealed class LiteDBService<TEntity, TId> : ILiteDBService<TEntity, TId>
            where TEntity : Entity<TId>
            where TId : IEquatable<TId>
    {
        ILocalStorageAccessService _liteDBAccessService =>
            DependencyService.Get<ILocalStorageAccessService>();

        /// <summary>
        /// string interpolation of the database file name based on the types of the entity and its primary key
        /// </summary>
        static readonly string filename = $"{nameof(LiteDBService<TEntity, TId>)}[{typeof(TEntity).Name}[{typeof(TId).Name}]]";

        LiteDatabase? Database { get; set; }
        ILiteCollection<TEntity>? Collection { get; set; }

        /// <inheritdoc/>
        public async Task InvokeAsync(Action<ILiteCollection<TEntity>> action = null)
        {
            try
            {
                var connection = await _liteDBAccessService.FilePathAsync(filename);
                using var database = new LiteDatabase(connection);
                var collection = database.GetCollection<TEntity>();
                action?.Invoke(collection);
            }
            catch (Exception e) { Log.Fatal(e.Message); }
        }

        /// <inheritdoc/>
        public async Task<T> InvokeAsync<T>(Func<ILiteCollection<TEntity>, Task<T>> function)
        {
            try
            {
                var connection = await _liteDBAccessService.FilePathAsync(filename);
                using var database = new LiteDatabase(connection);
                var collection = database.GetCollection<TEntity>();
                return await function.Invoke(collection);
            }
            catch (Exception e) { Log.Fatal(e.Message); }
            return default;
        }

        /// <inheritdoc />
        public async Task<int> InsertAsync(TEntity entity) =>
            await InvokeAsync((collection) =>
                Task.FromResult(collection.Insert(entity)));

        /// <inheritdoc />
        public async Task<int> InsertAsync(IEnumerable<TEntity> entities) =>
            await InvokeAsync((collection) =>
                Task.FromResult(collection.Insert(entities)));

        /// <inheritdoc/>
        public async Task<bool> UpdateAsync(TEntity entity) =>
            await InvokeAsync((collection) =>
                Task.FromResult(collection.Update(entity)));

        /// <inheritdoc/>
        public async Task<int> UpdateAsync(IEnumerable<TEntity> entities) =>
            await InvokeAsync((collection) =>
                Task.FromResult(collection.Update(entities)));

        /// <inheritdoc/>
        public async Task<bool> UpsertAsync(TEntity entity) =>
            await InvokeAsync((collection) =>
                Task.FromResult(collection.Upsert(entity)));

        /// <inheritdoc />
        public async Task<TEntity> FindAsync(TEntity entity) =>
            await InvokeAsync((collection) =>
                Task.FromResult(collection.Find(x => x == entity).FirstOrDefault()));

        /// <inheritdoc />
        public async Task<TEntity> FindAsync(TId id) =>
            await InvokeAsync((collection) =>
                Task.FromResult(collection.Find(x => EqualityComparer<TId>.Default.Equals(x.Id, id)).FirstOrDefault()));

        /// <inheritdoc />
        public async Task<IEnumerable<TEntity>> FindAllAsync() =>
            await InvokeAsync((collection) =>
                Task.FromResult(collection.FindAll().ToList()));

        /// <inheritdoc />
        public async Task<IEnumerable<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> predicate) =>
            await InvokeAsync((collection) =>
                Task.FromResult(collection.Find(predicate).ToList()));

        /// <inheritdoc />
        public async Task<ObservableCollection<TEntity>> RetrieveAsync() =>
            await InvokeAsync((collection) =>
                Task.FromResult(collection.FindAll().ToObservableCollection()));

        /// <inheritdoc />
        public async Task<ObservableCollection<TEntity>> RetrieveAsync(Expression<Func<TEntity, bool>> predicate) =>
            await InvokeAsync((collection) =>
                Task.FromResult(collection.Find(predicate).ToObservableCollection()));

        /// <inheritdoc />
        public async Task DeleteAsync(TEntity entity) =>
            await InvokeAsync((collection) =>
                Task.FromResult(collection.DeleteMany(x => x == entity)));

        /// <inheritdoc />
        public async Task DeleteAsync(TId id) =>
            await InvokeAsync((collection) =>
                Task.FromResult(collection.DeleteMany(x => EqualityComparer<TId>.Default.Equals(x.Id, id))));

        /// <inheritdoc/>
        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate) =>
            await InvokeAsync((collection) =>
                Task.FromResult(collection.Find(predicate).Any()));

        /// <inheritdoc />
        public async Task<bool> AnyAsync() =>
            await InvokeAsync((collection) =>
                Task.FromResult(collection.FindAll().Any()));
    }
}
