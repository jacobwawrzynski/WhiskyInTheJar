using Infrastructure.DataContext;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ProductsUnitOfWork : IProductsUnitOfWork, IDisposable
    {
        private Repository<Product> _productRepo;
        private Repository<NutritionFacts> _nutriFactRepo;
        private readonly ApplicationDbContext _context;
        private bool _disposed;

        public Repository<Product> productRepo 
            => _productRepo ?? (_productRepo = new Repository<Product>(_context));

        public Repository<NutritionFacts> nutriFactRepo
            => _nutriFactRepo ?? (_nutriFactRepo = new Repository<NutritionFacts>(_context));

        public async Task Commit() 
            => await _context.SaveChangesAsync();

        public void RollBack()
        {
            foreach (var entry in _context.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                }
            }
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
