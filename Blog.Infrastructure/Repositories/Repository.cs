using Blog.Domain.Repositories;
using Blog.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> 
        where TEntity : class
    {
        protected readonly BlogContext Context;
        protected readonly DbSet<TEntity> Table;
        private bool disposedValue;

        public Repository(BlogContext context)
        {
            Context = context;
            Table = Context.Set<TEntity>();
            
        }

        public IEnumerable<TEntity> GetAll(bool isTracking = true)
        {
            return isTracking ? Table : Table.AsNoTracking();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(bool isTracking = true)
        {
            return isTracking ? await Table.ToListAsync() : await Table.AsNoTracking().ToListAsync();
        }

        public IEnumerable<TEntity> GetByFilter(Expression<Func<TEntity, bool>> filter, bool isTracking = true)
        {
            return isTracking ? Table.Where(filter) : Table.AsNoTracking().Where(filter);
        }

        public async Task<IEnumerable<TEntity>> GetByFilterAsync(Expression<Func<TEntity, bool>> filter, bool isTracking = true)
        {
            return isTracking ? await Table.Where(filter).ToListAsync() : await Table.AsNoTracking().Where(filter).ToListAsync();
        }

        public TEntity GetById(int id, bool isTracking = true)
        {
            var entity = Table.Find(id);
            if (!isTracking && entity != null)
                Context.Entry(entity).State = EntityState.Detached;
            return entity;
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await Table.FindAsync(id);
        }

        public TEntity GetSingle(Expression<Func<TEntity, bool>> filter, bool isTracking = true)
        {
            return isTracking ? Table.SingleOrDefault(filter) : Table.AsNoTracking().SingleOrDefault(filter);
        }

        public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> filter, bool isTracking = true)
        {
            return isTracking ? await Table.SingleOrDefaultAsync(filter) : await Table.AsNoTracking().SingleOrDefaultAsync(filter);
        }


        public void Delete(TEntity entity)
        {
            Table.Remove(entity);
        }


        public void Insert(TEntity entity)
        {
            Table.Add(entity);
        }

        public void Insert(IEnumerable<TEntity> entities)
        {
            Table.AddRange(entities);
        }


        public void Update(TEntity entity)
        {
            Table.Update(entity);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: yönetilen durumu (yönetilen nesneleri) atın
                }

                // TODO: yönetilmeyen kaynakları (yönetilmeyen nesneleri) serbest bırakın ve sonlandırıcıyı geçersiz kılın
                // TODO: büyük alanları null olarak ayarlayın
                disposedValue = true;
            }
        }

        // // TODO: sonlandırıcıyı yalnızca 'Dispose(bool disposing)' içinde yönetilmeyen kaynakları serbest bırakacak kod varsa geçersiz kılın
        // ~Repository()
        // {
        //     // Bu kodu değiştirmeyin. Temizleme kodunu 'Dispose(bool disposing)' metodunun içine yerleştirin.
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Bu kodu değiştirmeyin. Temizleme kodunu 'Dispose(bool disposing)' metodunun içine yerleştirin.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
