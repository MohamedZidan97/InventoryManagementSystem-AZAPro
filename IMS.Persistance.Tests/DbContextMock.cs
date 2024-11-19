using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Persistance.Tests
{
    public static class DbContextMock
    {
        // Helper method to create a mock DbSet from a list of entities
        public static Mock<DbSet<T>> CreateMockDbSet<T>(List<T> entities) where T : class
        {
            var queryable = entities.AsQueryable();

            var dbSet = new Mock<DbSet<T>>();
            dbSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryable.Provider);
            dbSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryable.Expression);
            dbSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            dbSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(queryable.GetEnumerator());

            // For async support
            dbSet.As<IAsyncEnumerable<T>>().Setup(m => m.GetAsyncEnumerator(new System.Threading.CancellationToken()))
                .Returns(new AsyncEnumerator<T>(queryable.GetEnumerator()));

            return dbSet;
        }

        // Custom async enumerator
        private class AsyncEnumerator<T> : IAsyncEnumerator<T>
        {
            private readonly IEnumerator<T> _inner;
            public AsyncEnumerator(IEnumerator<T> inner) { _inner = inner; }
            public ValueTask DisposeAsync() { _inner.Dispose(); return default; }
            public ValueTask<bool> MoveNextAsync() => new ValueTask<bool>(_inner.MoveNext());
            public T Current => _inner.Current;
        }
    }
}
