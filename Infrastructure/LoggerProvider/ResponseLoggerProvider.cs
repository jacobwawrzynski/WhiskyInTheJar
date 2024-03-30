using Infrastructure.DataContext;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.LoggerProvider
{
    public class ResponseLoggerProvider : ILoggerProvider
    {
        private readonly ApplicationDbContext _context;
        bool _disposed;

        public ResponseLoggerProvider(ApplicationDbContext context)
        {
            _context = context;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new ResponseLogger(_context);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                _context.Dispose();
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
