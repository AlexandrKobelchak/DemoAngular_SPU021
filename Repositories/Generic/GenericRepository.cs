using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Generic
{
    public class GenericRepository<T> : IDbRepository<T>
        where T : class, IDbEntity
    {
        DbContext _context;

        public GenericRepository(DbContext context)
        {
            _context=context;
        }

        public IQueryable<T> AllItems => throw new NotImplementedException();

        public Task<bool> AddItemAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddItemsAsync(IEnumerable<T> items)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ChangeItemAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetItemAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> ToListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
